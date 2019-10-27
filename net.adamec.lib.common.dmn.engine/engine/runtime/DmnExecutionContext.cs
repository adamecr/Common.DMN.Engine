using System;
using System.Collections.Generic;
using System.Linq;
using DynamicExpresso;
using net.adamec.lib.common.core.logging;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.parser;
using net.adamec.lib.common.extensions;

namespace net.adamec.lib.common.dmn.engine.engine.runtime
{
    /// <summary>
    /// Context where is the DMN model executed
    /// </summary>
    public class DmnExecutionContext
    {
        /// <summary>
        /// Logger
        /// </summary>
        protected static ILogger Logger = CommonLogging.CreateLogger<DmnExecutionContext>();

        /// <summary>
        /// Parsed (pre-processed) expressions cache
        /// </summary>
        private static readonly Dictionary<(string, Type), Lambda> ParsedExpressionsCache = new Dictionary<(string, Type), Lambda>();

        /// <summary>
        /// DMN Model definition
        /// </summary>
        public DmnDefinition Definition { get; }

        /// <summary>
        /// Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions
        /// In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions
        /// </summary>
        public IDictionary<string, DmnExecutionVariable> Variables { get; }

        /// <summary>
        /// Input data interface. Input data will be stored as Variables, complex objects are supported
        /// </summary>
        public IDictionary<string, DmnExecutionVariable> InputData { get; }

        /// <summary>
        /// Dictionary of available decisions by name
        /// </summary>
        public IDictionary<string, IDmnDecision> Decisions { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="definition">DMN Model definition</param>
        /// <param name="variables">Variables used while executing the DMN model</param>
        /// <param name="inputData">Input data interface</param>
        /// <param name="decisions">Dictionary of available decisions by name</param>
        /// <exception cref="ArgumentNullException">Any of the parameters is null</exception>
        internal DmnExecutionContext(
            DmnDefinition definition,
            IDictionary<string, DmnExecutionVariable> variables,
            IDictionary<string, DmnExecutionVariable> inputData,
            IDictionary<string, IDmnDecision> decisions)
        {
            Definition = definition ?? throw Logger.Fatal<ArgumentNullException>($"{nameof(definition)} is null");
            Variables = variables ?? throw Logger.Fatal<ArgumentNullException>($"{nameof(variables)} is null");
            InputData = inputData ?? throw Logger.Fatal<ArgumentNullException>($"{nameof(inputData)} is null");
            Decisions = decisions ?? throw Logger.Fatal<ArgumentNullException>($"{nameof(decisions)} is null");
        }

        /// <summary>
        /// Resets the DMN execution context - clears all variables except the input parameters (sets them to null)
        /// </summary>
        /// <returns><see cref="DmnExecutionContext"/></returns>
        public DmnExecutionContext Reset()
        {
            if (Variables == null) return this;
            foreach (var variable in Variables.Values.Where(i => !i.IsInputParameter))
            {
                variable.Value = null;
            }
            return this;
        }

        /// <summary>
        /// Sets the <paramref name="name">named</paramref> input parameter <paramref name="value"/>
        /// </summary>
        /// <remarks>
        /// Variable <see cref="DmnExecutionVariable.Value"/> setter doesn't allow to set the value for the input parameters to prevent the change of them,
        ///  so <see cref="DmnExecutionVariable.SetInputParameterValue"/> is to be used explicitly
        /// </remarks>
        /// <param name="name">Name of the input parameter</param>
        /// <param name="value">Value of the input parameter</param>
        /// <returns><see cref="DmnExecutionContext"/></returns>
        /// <exception cref="ArgumentException"><paramref name="name"/> is null or empty</exception>    
        /// <exception cref="DmnExecutorException">Input parameter with given <paramref name="name"/> doesn't exist</exception>
        public DmnExecutionContext WithInputParameter(string name, object value)
        {
            if (string.IsNullOrWhiteSpace(name)) throw Logger.Fatal<ArgumentException>($"{nameof(name)} is null or empty");

            var variable = Variables?.Values.FirstOrDefault(i => i.IsInputParameter && i.Name == name);
            if (variable == null) throw Logger.Fatal<DmnExecutorException>($"WithInputParameter: {name} is not an input parameter");

            variable.SetInputParameterValue(value);
            Logger.Info($"Execution context input parameter {name} set to {value}");
            return this;
        }

        /// <summary>
        /// Executes (evaluates) decision with given <paramref name="decisionName"/>
        /// </summary>
        /// <param name="decisionName">Name of the decision to execute</param>
        /// <returns>Decision result</returns>
        /// <exception cref="ArgumentException"><paramref name="decisionName"/> is null or empty</exception>
        /// <exception cref="DmnExecutorException">Decision with <paramref name="decisionName"/> not found</exception>
        public DmnDecisionResult ExecuteDecision(string decisionName)
        {
            if (string.IsNullOrWhiteSpace(decisionName)) throw Logger.Fatal<ArgumentException>($"{nameof(decisionName)} is null or empty");
            if (!Decisions.ContainsKey(decisionName)) throw Logger.Fatal<DmnExecutorException>($"ExecuteDecision: - decision {decisionName} not found");

            var decision = Decisions[decisionName];
            return ExecuteDecision(decision);
        }

        /// <summary>
        /// Executes (evaluates) given <paramref name="decision"/>
        /// </summary>
        /// <param name="decision">Decision to execute</param>
        /// <returns>Decision result</returns>
        /// <exception cref="ArgumentNullException"><paramref name="decision"/> is null</exception>
        public DmnDecisionResult ExecuteDecision(IDmnDecision decision)
        {
            if (decision == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(decision)} is null");

            var correlationId = Guid.NewGuid().ToString();
            var result = decision.Execute(this, correlationId);
            return result;
        }

        /// <summary>
        /// Evaluates expression
        /// </summary>
        /// <param name="expression">Expression to evaluate</param>
        /// <param name="outputType">Output (result) type</param>
        /// <exception cref="ArgumentException"><paramref name="expression"/> is null or empty</exception>   
        /// <exception cref="ArgumentNullException"><paramref name="outputType"/> is null</exception>
        /// <exception cref="DmnExecutorException">Exception while invoking the expression</exception>
        /// <exception cref="DmnExecutorException">Can't convert the expression result to <paramref name="outputType"/></exception>
        /// <returns>The expression result converted to <paramref name="outputType"/></returns>
        public object EvalExpression(string expression, Type outputType)
        {
            if (string.IsNullOrWhiteSpace(expression)) throw Logger.Fatal<ArgumentException>($"{nameof(expression)} is null or empty");
            if (outputType == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(outputType)} is null");

            var interpreter = new Interpreter();
            var parameters = new List<Parameter>();
            
            //Prepare variables (as interpreter parameters)       
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var variable in Variables.Values)
            {
                //check null variable for value type
                var varValue = variable.Value ?? variable.Type?.GetDefaultValue();

                var parameter = new Parameter(
                    variable.Name,
                    variable.Type ?? varValue?.GetType() ?? typeof(object),
                    varValue);
                parameters.Add(parameter);
            }

            //Add S-FEEL functions to the interpreter
            foreach (var customFunction in SfeelParser.CustomFunctions)
            {
                interpreter.SetFunction(customFunction.Key, customFunction.Value);
            }

            //Check parsed expression cache
            if (!ParsedExpressionsCache.TryGetValue((expression, outputType),out var parsedExpression))
            {
                parsedExpression = interpreter.Parse(expression, outputType, parameters.ToArray());
                ParsedExpressionsCache[(expression, outputType)] = parsedExpression;
            }

            //Invoke expression to evaluate
            object result;
            try
            {
                result = parsedExpression.Invoke(parameters.ToArray());
            }
            catch (Exception exception)
            {
                throw Logger.Fatal<DmnExecutorException>($"Exception while invoking the expression {expression}", exception);
            }

            //Convert the result
            object resultConverted;
            try
            {
                resultConverted = Convert.ChangeType(result, outputType);
            }
            catch (Exception exception)
            {
                throw Logger.Fatal<DmnExecutorException>($"Can't convert the expression result to {outputType.Name}", exception);
            }
            return resultConverted;
        }

        /// <summary>
        /// Evaluates expression
        /// </summary>
        /// <param name="expression">Expression to evaluate</param>
        /// <typeparam name="TOutputType">Output (result) type</typeparam>
        /// <exception cref="ArgumentNullException"><paramref name="expression"/> is null or empty</exception>   
        /// <returns>The expression result converted to <typeparamref name="TOutputType"/></returns>
        public TOutputType EvalExpression<TOutputType>(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression)) throw Logger.Fatal<ArgumentNullException>($"EvalExpression: - {nameof(expression)} is null or empty");

            var result = EvalExpression(expression, typeof(TOutputType));
            var resultConverted = (TOutputType)result;
            return resultConverted;
        }

        /// <summary>
        /// Gets the runtime (execution) variable with given <paramref name="name"/>
        /// </summary>
        /// <param name="name">Name of the variable</param>
        /// <returns>Variable with given <paramref name="name"/></returns>
        /// <exception cref="ArgumentException"><paramref name="name"/> is null or empty</exception>
        /// <exception cref="DmnExecutorException">Variable not found</exception>
        public DmnExecutionVariable GetVariable(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw Logger.Fatal<ArgumentException>($"{nameof(name)} is null or empty");

            if (!Variables.ContainsKey(name))
            {
                throw Logger.Fatal<DmnExecutorException>($"GetVariable: - variable {name} not found");
            }

            return Variables[name];
        }

        /// <summary>
        /// Gets the runtime (execution) variable corresponding to its <paramref name="definition"/>
        /// </summary>
        /// <param name="definition">Name of the variable</param>
        /// <returns>Variable  corresponding to its <paramref name="definition"/></returns>
        /// <exception cref="ArgumentNullException"><paramref name="definition"/> is null</exception>
        public DmnExecutionVariable GetVariable(DmnVariableDefinition definition)
        {
            if (definition == null)
                throw Logger.Fatal<ArgumentNullException>($"{nameof(definition)} is null");

            return GetVariable(definition.Name);
        }

    }
}

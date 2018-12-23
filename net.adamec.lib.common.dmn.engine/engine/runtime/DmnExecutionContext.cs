using System;
using System.Collections.Generic;
using System.Linq;
using DynamicExpresso;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.parser;
using net.adamec.lib.common.extensions;
using net.adamec.lib.common.logging;

namespace net.adamec.lib.common.dmn.engine.engine.runtime
{
    public class DmnExecutionContext
    {
        protected static ILogger Logger = CommonLogging.CreateLogger<DmnExecutionContext>();
        private static Dictionary<(string, Type), Lambda> ParsedExpressionsCache = new Dictionary<(string, Type), Lambda>();

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

        public IDictionary<string, IDmnDecision> Decisions { get; }



        internal DmnExecutionContext(
            DmnDefinition definition,
            IDictionary<string, DmnExecutionVariable> variables,
            IDictionary<string, DmnExecutionVariable> inputData,
            IDictionary<string, IDmnDecision> decisions)
        {
            Definition = definition;
            Variables = variables;
            InputData = inputData;
            Decisions = decisions;
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
        /// <exception cref="DmnExecutorException">When the <paramref name="name"/> is not provided or the input parameter with given <paramref name="name"/> doesn't exist</exception>
        public DmnExecutionContext WithInputParameter(string name, object value)
        {
            if (string.IsNullOrEmpty(name)) throw Logger.Fatal<DmnExecutorException>($"WithInputParameter: Missing name parameter");

            var variable = Variables?.Values.FirstOrDefault(i => i.IsInputParameter && i.Name == name);
            if (variable == null) throw Logger.Fatal<DmnExecutorException>($"WithInputParameter: {name} is not an input parameter");

            variable.SetInputParameterValue(value);
            Logger.Info($"Execution context input parameter {name} set to {value}");
            return this;
        }

        public DmnDecisionResult ExecuteDecision(string decisionName)
        {
            if (string.IsNullOrEmpty(decisionName)) throw Logger.Fatal<DmnExecutorException>($"ExecuteDecision: - decisionName is null or empty");
            if (!Decisions.ContainsKey(decisionName)) throw Logger.Fatal<DmnExecutorException>($"ExecuteDecision: - decision {decisionName} not found");

            var decision = Decisions[decisionName];
            return ExecuteDecision(decision);
        }

        public DmnDecisionResult ExecuteDecision(IDmnDecision decision)
        {
            if (decision == null) throw Logger.Fatal<DmnExecutorException>($"ExecuteDecision: - decision is null");
            var correlationId = Guid.NewGuid().ToString();
            var result = decision.Execute(this, correlationId);
            return result;
        }


        public object EvalExpression(string expression, Type outputType)
        {
            var interpreter = new Interpreter();
            var parameters = new List<Parameter>();
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

            foreach (var customFunction in SfeelParser.CustomFunctions)
            {
                interpreter.SetFunction(customFunction.Key, customFunction.Value);
            }
            Lambda parsedExpression;
            if (ParsedExpressionsCache.ContainsKey((expression, outputType)))
            {
                parsedExpression = ParsedExpressionsCache[(expression, outputType)];
            }
            else
            {
                parsedExpression = interpreter.Parse(expression, outputType, parameters.ToArray());
                ParsedExpressionsCache[(expression, outputType)] = parsedExpression;
            }

            var result = parsedExpression.Invoke(parameters.ToArray()); //TODO interpeter exception
            var resultConverted = Convert.ChangeType(result, outputType);//TODO cast exception
            return resultConverted;
        }

        public T EvalExpression<T>(string expression)
        {
            var result = EvalExpression(expression, typeof(T));
            var resultConverted = (T)result;
            return resultConverted;
        }

        public DmnExecutionVariable GetVariable(string name)
        {
            if (!Variables.ContainsKey(name))
            {
                throw Logger.Fatal<DmnExecutorException>($"GetVariable: - variable {name} not found");
            }

            return Variables[name];
        }

        public DmnExecutionVariable GetVariable(DmnVariableDefinition definition)
        {
            return GetVariable(definition?.Name);
        }

    }
}

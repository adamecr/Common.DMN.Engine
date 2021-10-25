using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using DynamicExpresso;
using net.adamec.lib.common.core.logging;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.execution.result;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.engine.execution.context
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
        protected static readonly ConcurrentDictionary<string, Lambda> ParsedExpressionsCache = new ConcurrentDictionary<string, Lambda>();

        /// <summary>
        /// Unique identifier of the execution context (set at CTOR)
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// DMN Model definition
        /// </summary>
        public DmnDefinition Definition { get; }

        /// <summary>
        /// Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions
        /// In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions
        /// </summary>
        public IReadOnlyDictionary<string, DmnExecutionVariable> Variables { get; }

        /// <summary>
        /// Dictionary of available decisions by name
        /// </summary>
        public IReadOnlyDictionary<string, IDmnDecision> Decisions { get; }


        /// <summary>
        /// Snapshots of the context state during the execution
        /// </summary>
        public DmnExecutionSnapshots Snapshots { get; } = new DmnExecutionSnapshots();

        /// <summary>
        /// Execution context options
        /// </summary>
        private readonly DmnExecutionContextOptions options = new DmnExecutionContextOptions();
        /// <summary>
        /// Execution context options
        /// </summary>
        public IDmnExecutionContextOptions Options => options;

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="definition">DMN Model definition</param>
        /// <param name="variables">Variables used while executing the DMN model</param>
        /// <param name="decisions">Dictionary of available decisions by name</param>
        /// <param name="configure">Optional configuration action</param>
        /// <exception cref="ArgumentNullException">Any of the parameters is null</exception>
        public DmnExecutionContext(
             DmnDefinition definition,
             IReadOnlyDictionary<string, DmnExecutionVariable> variables,
             IReadOnlyDictionary<string, IDmnDecision> decisions,
             Action<DmnExecutionContextOptions> configure = null)
        {
            Id = Guid.NewGuid().ToString();

            Definition = definition ?? throw Logger.Fatal<ArgumentNullException>($"{nameof(definition)} is null");
            Variables = variables ?? throw Logger.Fatal<ArgumentNullException>($"{nameof(variables)} is null");
            Decisions = decisions ?? throw Logger.Fatal<ArgumentNullException>($"{nameof(decisions)} is null");

            configure?.Invoke(options);
        }

        /// <summary>
        /// Resets the DMN execution context - clears all variables except the input parameters (sets them to null)
        /// and clears the snapshots
        /// </summary>
        /// <returns><see cref="DmnExecutionContext"/></returns>
        public virtual DmnExecutionContext Reset()
        {
            if (Variables == null) return this;
            foreach (var variable in Variables.Values.Where(i => !i.IsInputParameter))
            {
                variable.Value = null;
            }

            Snapshots.Reset();
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
        public virtual DmnExecutionContext WithInputParameter(string name, object value)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw Logger.Fatal<ArgumentException>($"{nameof(name)} is null or empty");

            name = DmnVariableDefinition.NormalizeVariableName(name);
            var variable = Variables?.Values.FirstOrDefault(i => i.IsInputParameter && i.Name == name);
            if (variable == null)
                throw Logger.Fatal<DmnExecutorException>($"WithInputParameter: {name} is not an input parameter");

            variable.SetInputParameterValue(value);
            Logger.Info($"Execution context input parameter {name} set to {value}");
            return this;
        }

        /// <summary>
        /// Sets the input parameters from key-value collection (key=name of parameter, value=value to be set)
        /// </summary>
        /// <remarks>
        /// Variable <see cref="DmnExecutionVariable.Value"/> setter doesn't allow to set the value for the input parameters to prevent the change of them,
        ///  so <see cref="DmnExecutionVariable.SetInputParameterValue"/> is to be used explicitly
        /// </remarks>
        /// <param name="parameters">Collection of parameters - Key=name, Value=value</param>
        /// <returns><see cref="DmnExecutionContext"/></returns>
        /// <exception cref="ArgumentNullException"><paramref name="parameters"/> is null</exception>    
        public virtual DmnExecutionContext WithInputParameters(IReadOnlyCollection<KeyValuePair<string, object>> parameters)
        {
            if (parameters == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(parameters)} is null");

            foreach (var parameter in parameters)
            {
                WithInputParameter(parameter.Key, parameter.Value);
            }

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
            if (string.IsNullOrWhiteSpace(decisionName))
                throw Logger.Fatal<ArgumentException>($"{nameof(decisionName)} is null or empty");
            if (!Decisions.ContainsKey(decisionName))
                throw Logger.Fatal<DmnExecutorException>($"ExecuteDecision: - decision {decisionName} not found");

            var decision = Decisions[decisionName];
            return ExecuteDecision(decision);
        }

        /// <summary>
        /// Executes (evaluates) given <paramref name="decision"/>
        /// </summary>
        /// <param name="decision">Decision to execute</param>
        /// <returns>Decision result</returns>
        /// <exception cref="ArgumentNullException"><paramref name="decision"/> is null</exception>
        public virtual DmnDecisionResult ExecuteDecision(IDmnDecision decision)
        {
            if (decision == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(decision)} is null");

            if (Options.RecordSnapshots)
            {
                //clear snapshots and create "initial" snapshot of the variables
                Snapshots.Reset();
                Snapshots.CreateSnapshot(this);
            }

            var correlationId = Guid.NewGuid().ToString();
            var result = decision.Execute(this, correlationId);
            //note: the decision-after-execute snapshot is created by decision (for each decision in "dependency graph")

            return result;
        }

        /// <summary>
        /// Creates the execution context snapshot - to be called by decision after the evaluation
        /// </summary>
        /// <param name="decision">Decision evaluated just before the snapshot</param>
        /// <param name="result"><paramref name="decision"/> result</param>
        internal virtual void CreateSnapshot(IDmnDecision decision, DmnDecisionResult result)
        {
            if (Options.RecordSnapshots)
                Snapshots.CreateSnapshot(this, decision, result);
        }

        /// <summary>
        /// Evaluates expression
        /// </summary>
        /// <param name="expression">Expression to evaluate</param>
        /// <param name="outputType">Output (result) type</param>
        /// <param name="executionId">Identifier of the execution run</param>
        /// <exception cref="ArgumentException"><paramref name="expression"/> is null or empty</exception>   
        /// <exception cref="ArgumentNullException"><paramref name="outputType"/> is null</exception>
        /// <exception cref="DmnExecutorException">Exception while invoking the expression</exception>
        /// <exception cref="DmnExecutorException">Can't convert the expression result to <paramref name="outputType"/></exception>
        /// <returns>The expression result converted to <paramref name="outputType"/></returns>
        public virtual object EvalExpression(string expression, Type outputType, string executionId)
        {
            if (string.IsNullOrWhiteSpace(expression))
                throw Logger.Fatal<ArgumentException>($"{nameof(expression)} is null or empty");
            if (outputType == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(outputType)} is null");

            var interpreter = new Interpreter();
            var parameters = new List<Parameter>();

            //Prepare variables (as interpreter parameters)       
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var variable in Variables.Values)
            {
                //check null variable for value type
                var varValue = variable.Value ??
                               (variable.Type?.IsValueType ?? false ? Activator.CreateInstance(variable.Type) : null);

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
            var cacheKey = GetParsedExpressionCacheKey(executionId, expression, outputType);
            if (Options.ParsedExpressionCacheScope == ParsedExpressionCacheScopeEnum.None ||
                !GetParsedExpressionsFromCache(cacheKey, out var parsedExpression))
            {
                parsedExpression = interpreter.Parse(expression, outputType, parameters.ToArray());
                if (Options.ParsedExpressionCacheScope != ParsedExpressionCacheScopeEnum.None)
                    CacheParsedExpression(cacheKey, parsedExpression);
            }

            //Invoke expression to evaluate
            object result;
            try
            {
                result = parsedExpression.Invoke(parameters.ToArray());
            }
            catch (Exception exception)
            {
                throw Logger.Fatal<DmnExecutorException>($"Exception while invoking the expression {expression}",
                    exception);
            }

            //Convert the result
            object resultConverted;
            try
            {
                resultConverted = Convert.ChangeType(result, outputType);
            }
            catch (Exception exception)
            {
                throw Logger.Fatal<DmnExecutorException>($"Can't convert the expression result to {outputType.Name}",
                    exception);
            }

            return resultConverted;
        }

        /// <summary>
        /// Tries to retrieve the <paramref name="parsedExpression"/> from the parsed expression cache using the <paramref name="cacheKey"/>
        /// </summary>
        /// <param name="cacheKey">Retrieval key of the <paramref name="parsedExpression"/></param>
        /// <param name="parsedExpression">Parsed expression retrieved from cache if successful</param>
        /// <returns>True when the <paramref name="parsedExpression"/> has been retrieved from cache, otherwise false</returns>
        protected virtual bool GetParsedExpressionsFromCache(string cacheKey, out Lambda parsedExpression)
        {
            return ParsedExpressionsCache.TryGetValue(cacheKey, out parsedExpression);
        }

        /// <summary>
        /// Store the <paramref name="parsedExpression"/> into parsed expression cache using the <paramref name="cacheKey"/>
        /// </summary>
        /// <param name="cacheKey">Retrieval key of the <paramref name="parsedExpression"/></param>
        /// <param name="parsedExpression">Parsed expression to cache</param>
        protected virtual void CacheParsedExpression(string cacheKey, Lambda parsedExpression)
        {
            ParsedExpressionsCache[cacheKey] = parsedExpression;
        }

        /// <summary>
        /// Compose the parsed expression key (based on <see cref="DmnExecutionContextOptions.ParsedExpressionCacheScope"/>)
        /// </summary>
        /// <param name="executionId">Identifier of the execution run</param>
        /// <param name="expression">Unparsed (raw) expression</param>
        /// <param name="outputType">Expression output type</param>
        /// <returns>Parsed expression key</returns>
        protected virtual string GetParsedExpressionCacheKey(string executionId, string expression, Type outputType)
        {
            string prefix;
            switch (Options.ParsedExpressionCacheScope)
            {
                case ParsedExpressionCacheScopeEnum.None:
                    prefix = Guid.NewGuid().ToString(); //fallback, always unique key
                    break;
                case ParsedExpressionCacheScopeEnum.Execution:
                    prefix = executionId;
                    break;
                case ParsedExpressionCacheScopeEnum.Context:
                    prefix = Id;
                    break;
                case ParsedExpressionCacheScopeEnum.Definition:
                    prefix = Definition.Id;
                    break;
                case ParsedExpressionCacheScopeEnum.Global:
                    prefix = "";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return $"{prefix}||{expression}||{outputType.AssemblyQualifiedName}";
        }
        /// <summary>
        /// Evaluates expression
        /// </summary>
        /// <param name="expression">Expression to evaluate</param>
        /// <param name="executionId">Identifier of the execution run</param>
        /// <typeparam name="TOutputType">Output (result) type</typeparam>
        /// <exception cref="ArgumentNullException"><paramref name="expression"/> is null or empty</exception>   
        /// <returns>The expression result converted to <typeparamref name="TOutputType"/></returns>
        public TOutputType EvalExpression<TOutputType>(string expression, string executionId)
        {
            if (string.IsNullOrWhiteSpace(expression))
                throw Logger.Fatal<ArgumentNullException>($"EvalExpression: - {nameof(expression)} is null or empty");

            var result = EvalExpression(expression, typeof(TOutputType), executionId);
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
        public virtual DmnExecutionVariable GetVariable(string name)
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
        public DmnExecutionVariable GetVariable(IDmnVariable definition)
        {
            if (definition == null)
                throw Logger.Fatal<ArgumentNullException>($"{nameof(definition)} is null");

            return GetVariable(definition.Name);
        }

    }
}
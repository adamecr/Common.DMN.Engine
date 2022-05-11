#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa" />  net.adamec.lib.common.dmn.engine.engine.execution.context Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) | public | Context where is the DMN model executed | 
 | [DmnExecutionContextFactory](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextfactory__zcbl72) | public static | Factory creating the DMN Model execution context from [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) or [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) | 
 | [DmnExecutionContextOptions](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions__13hymf6) | public | Execution configuration options | 
 | [DmnExecutionSnapshot](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot__1i0lwwl) | public | Snapshot of execution context generated at the beginning of [execution](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.executedecision_system.string___1olcv5p) and after execution of decision. The snapshot (step) is generated for each decision in dependency tree | 
 | [DmnExecutionSnapshots](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots__wr7yxu) | public | Set of available snapshots | 
 | [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn) | public | Runtime (execution) variable | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IDmnExecutionContextOptions](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions__1nc74ur) | public abstract | Execution configuration options | 

 


###  Enums ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ParsedExpressionCacheScopeEnum](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum__li5aty) | public | Scope of the parsed expression cache | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88" />  DmnExecutionContext Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Context where is the DMN model executed



```csharp
public class DmnExecutionContext
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Logger](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.logger__1vnt2s8) | protected static | Logger | 
 | [options](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.options__12wzwum) | private | Execution context options | 
 | [ParsedExpressionsCache](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.parsedexpressionscache__t9bsca) | protected static | Parsed (pre-processed) expressions cache (Global and Definition) | 
 | [ParsedExpressionsInstanceCache](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.parsedexpressionsinstancecache__bqtrb7) | protected | Parsed (pre-processed) expressions cache (Context and Definitions) | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decisions](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.decisions__170xpbn) | public | Dictionary of available decisions by name | 
 | [Definition](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.definition__1o87lf9) | public | DMN Model definition | 
 | [Id](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.id__ns9ba9) | public | Unique identifier of the execution context (set at CTOR) | 
 | [Options](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.options__nfq4qk) | public | Execution context options | 
 | [Snapshots](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.snapshots__yzrrjf) | public | Snapshots of the context state during the execution | 
 | [Variables](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.variables__1o7e2gh) | public | Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExecutionContext(DmnDefinition, IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable&gt;, IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;, Action&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions&gt;)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition-system.collections.generic.ireadonlydictionary_system.string-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable_-system.collections.generic.ireadonlydictionary_system.string-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision_-system.action_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions____dcsjhx) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CacheParsedExpression(string, Lambda)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.cacheparsedexpression_system.string-dynamicexpresso.lambda___159dnk4) | protected | Store the <strong>parsedExpression</strong> into parsed expression cache using the <strong>cacheKey</strong> . [Global](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.global__1mtr259) and [Definition](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.definition__1muftjv) scopes use static [ParsedExpressionsCache](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.parsedexpressionscache__t9bsca) , otherwise the [ParsedExpressionsInstanceCache](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.parsedexpressionsinstancecache__bqtrb7) is used. | 
 | [ConfigureInterpreter(Interpreter)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.configureinterpreter_dynamicexpresso.interpreter___1b53b3s) | protected | Configures the <em>DynamicExpresso.Interpreter</em> that will invoke the expression. Adds S-FEEL functions to the interpreter and some &quot;common&quot; references (types) | 
 | [CreateSnapshot(IDmnDecision, DmnDecisionResult)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.createsnapshot_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult___1bztsza) | internal | Creates the execution context snapshot - to be called by decision after the evaluation | 
 | [EvalExpression(string, Type, string)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.evalexpression_system.string-system.type-system.string___icbo1v) | public | Evaluates expression | 
 | [EvalExpression&lt;TOutputType&gt;(string, string)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.evalexpression--1_system.string-system.string___1iaf9wt) | public | Evaluates expression | 
 | [ExecuteDecision(IDmnDecision)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.executedecision_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision___16z7t5v) | public | Executes (evaluates) given <strong>decision</strong> | 
 | [ExecuteDecision(string)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.executedecision_system.string___1olcv5p) | public | Executes (evaluates) decision with given <strong>decisionName</strong> | 
 | [GetParsedExpressionCacheKey(string, string, Type)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.getparsedexpressioncachekey_system.string-system.string-system.type___pepfrp) | protected | Compose the parsed expression key (based on [ParsedExpressionCacheScope](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions.parsedexpressioncachescope__1i7b48p) ) | 
 | [GetParsedExpressionsFromCache(string, Lambda)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.getparsedexpressionsfromcache_system.string-dynamicexpresso.lambda-___1emk6yb) | protected | Tries to retrieve the <strong>parsedExpression</strong> from the parsed expression cache using the <strong>cacheKey</strong> . [Global](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.global__1mtr259) and [Definition](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.definition__1muftjv) scopes use static [ParsedExpressionsCache](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.parsedexpressionscache__t9bsca) , otherwise the [ParsedExpressionsInstanceCache](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.parsedexpressionsinstancecache__bqtrb7) is used. | 
 | [GetVariable(IDmnVariable)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.getvariable_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable___qblh70) | public | Gets the runtime (execution) variable corresponding to its <strong>definition</strong> | 
 | [GetVariable(string)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.getvariable_system.string___1pjw2vs) | public | Gets the runtime (execution) variable with given <strong>name</strong> | 
 | [PurgeExpressionCacheContextScope()](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.purgeexpressioncachecontextscope__122h9jv) | public | Purge all cached expressions belonging to this Context scope | 
 | [PurgeExpressionCacheDefinitionScope(string)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.purgeexpressioncachedefinitionscope_system.string___1khcjlo) | public static | Purge all cached expressions belonging to given Definition <strong>definitionId</strong> scope | 
 | [PurgeExpressionCacheDefinitionScopeAll()](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.purgeexpressioncachedefinitionscopeall__ual138) | public static | Purge all cached expressions belonging to any Definition scope | 
 | [PurgeExpressionCacheExecutionScope(string)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.purgeexpressioncacheexecutionscope_system.string___1g6h7zp) | public | Purge all cached expressions belonging to given Execution <strong>executionId</strong> scope | 
 | [PurgeExpressionCacheExecutionScopeAll()](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.purgeexpressioncacheexecutionscopeall__2zws8b) | public | Purge all cached expressions belonging to any Execution scope | 
 | [PurgeExpressionCacheGlobalScope()](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.purgeexpressioncacheglobalscope__11j6uir) | public static | Purge all cached expressions belonging to Global scope | 
 | [Reset()](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.reset__2lfhbq) | public | Resets the DMN execution context - clears all variables except the input parameters (sets them to null) and clears the snapshots | 
 | [SetInterpreterParameters(List&lt;DynamicExpresso.Parameter&gt;)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.setinterpreterparameters_system.collections.generic.list_dynamicexpresso.parameter____g8t4d0) | protected | Prepares the parameters that will be used when invoking the expression. All [Variables](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.variables__1o7e2gh) are added to <strong>parameters</strong> . | 
 | [WithInputParameter(string, object)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.withinputparameter_system.string-system.object___qjwb99) | public | Sets the named input parameter <strong>value</strong> | 
 | [WithInputParameters(IReadOnlyCollection&lt;System.Collections.Generic.KeyValuePair&lt;string,object&gt;&gt;)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.withinputparameters_system.collections.generic.ireadonlycollection_system.collections.generic.keyvaluepair_system.string-system.object_____s0ztk9) | public | Sets the input parameters from key-value collection (key=name of parameter, value=value to be set) | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.logger__1vnt2s8" />  DmnExecutionContext.Logger Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Logger



```csharp
protected static ILogger Logger
```

<strong>Field value</strong><dl><dt>net.adamec.lib.common.core.logging.ILogger</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.options__12wzwum" />  DmnExecutionContext.options Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Execution context options



```csharp
private readonly DmnExecutionContextOptions options
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions__13hymf6)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.parsedexpressionscache__t9bsca" />  DmnExecutionContext.ParsedExpressionsCache Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Parsed (pre-processed) expressions cache (Global and Definition)



```csharp
protected static readonly ConcurrentDictionary<string,DynamicExpresso.Lambda> ParsedExpressionsCache
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentdictionary-2" target="_blank" >System.Collections.Concurrent.ConcurrentDictionary&lt;string,DynamicExpresso.Lambda&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.parsedexpressionsinstancecache__bqtrb7" />  DmnExecutionContext.ParsedExpressionsInstanceCache Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Parsed (pre-processed) expressions cache (Context and Definitions)



```csharp
protected readonly ConcurrentDictionary<string,DynamicExpresso.Lambda> ParsedExpressionsInstanceCache
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentdictionary-2" target="_blank" >System.Collections.Concurrent.ConcurrentDictionary&lt;string,DynamicExpresso.Lambda&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.decisions__170xpbn" />  DmnExecutionContext.Decisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Dictionary of available decisions by name



```csharp
public IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> Decisions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.definition__1o87lf9" />  DmnExecutionContext.Definition Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


DMN Model definition



```csharp
public DmnDefinition Definition { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.id__ns9ba9" />  DmnExecutionContext.Id Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Unique identifier of the execution context (set at CTOR)



```csharp
public string Id { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.options__nfq4qk" />  DmnExecutionContext.Options Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Execution context options



```csharp
public IDmnExecutionContextOptions Options { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.IDmnExecutionContextOptions](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions__1nc74ur)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.snapshots__yzrrjf" />  DmnExecutionContext.Snapshots Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Snapshots of the context state during the execution



```csharp
public DmnExecutionSnapshots Snapshots { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionSnapshots](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots__wr7yxu)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.variables__1o7e2gh" />  DmnExecutionContext.Variables Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions



```csharp
public IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable> Variables { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition-system.collections.generic.ireadonlydictionary_system.string-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable_-system.collections.generic.ireadonlydictionary_system.string-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision_-system.action_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions____dcsjhx" />  DmnExecutionContext.DmnExecutionContext(DmnDefinition, IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable&gt;, IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;, Action&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions&gt;) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


CTOR



```csharp
public DmnExecutionContext(DmnDefinition definition, IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable> variables, IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> decisions, Action<net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions> configure = null)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) <strong>definition</strong></dt><dd>DMN Model definition</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable&gt;</a> <strong>variables</strong></dt><dd>Variables used while executing the DMN model</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a> <strong>decisions</strong></dt><dd>Dictionary of available decisions by name</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.action-1" target="_blank" >System.Action&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions&gt;</a> <strong>configure</strong></dt><dd>Optional configuration action</dd></dl>
###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>Any of the parameters is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.cacheparsedexpression_system.string-dynamicexpresso.lambda___159dnk4" />  DmnExecutionContext.CacheParsedExpression(string, Lambda) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Store the <strong>parsedExpression</strong> into parsed expression cache using the <strong>cacheKey</strong> . [Global](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.global__1mtr259) and [Definition](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.definition__1muftjv) scopes use static [ParsedExpressionsCache](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.parsedexpressionscache__t9bsca) , otherwise the [ParsedExpressionsInstanceCache](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.parsedexpressionsinstancecache__bqtrb7) is used.



```csharp
protected virtual void CacheParsedExpression(string cacheKey, Lambda parsedExpression)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>cacheKey</strong></dt><dd>Retrieval key of the <strong>parsedExpression</strong></dd><dt>DynamicExpresso.Lambda <strong>parsedExpression</strong></dt><dd>Parsed expression to cache</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.configureinterpreter_dynamicexpresso.interpreter___1b53b3s" />  DmnExecutionContext.ConfigureInterpreter(Interpreter) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Configures the <em>DynamicExpresso.Interpreter</em> that will invoke the expression. Adds S-FEEL functions to the interpreter and some &quot;common&quot; references (types)



```csharp
protected virtual void ConfigureInterpreter(Interpreter interpreter)
```

<strong>Method parameters</strong><dl><dt>DynamicExpresso.Interpreter <strong>interpreter</strong></dt><dd>Interpreter to be configured</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.createsnapshot_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult___1bztsza" />  DmnExecutionContext.CreateSnapshot(IDmnDecision, DmnDecisionResult) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Creates the execution context snapshot - to be called by decision after the evaluation



```csharp
internal virtual void CreateSnapshot(IDmnDecision decision, DmnDecisionResult result)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6) <strong>decision</strong></dt><dd>Decision evaluated just before the snapshot</dd><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka) <strong>result</strong></dt><dd><strong>decision</strong> result</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.evalexpression_system.string-system.type-system.string___icbo1v" />  DmnExecutionContext.EvalExpression(string, Type, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Evaluates expression



```csharp
public virtual object EvalExpression(string expression, Type outputType, string executionId)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Expression to evaluate</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>outputType</strong></dt><dd>Output (result) type</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>executionId</strong></dt><dd>Identifier of the execution run</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>The expression result converted to <strong>outputType</strong></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>expression</strong> is null or empty</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>outputType</strong> is null</dd><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#t-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception__kkv81y)</dt><dd>Exception while invoking the expression</dd><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#t-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception__kkv81y)</dt><dd>Can&#39;t convert the expression result to <strong>outputType</strong></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.evalexpression--1_system.string-system.string___1iaf9wt" />  DmnExecutionContext.EvalExpression&lt;TOutputType&gt;(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Evaluates expression



```csharp
public DmnExecutionContext.TOutputType EvalExpression<TOutputType>(string expression, string executionId)
```

<strong>Type parameters</strong><dl><dt><strong>TOutputType</strong></dt><dd>Output (result) type</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Expression to evaluate</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>executionId</strong></dt><dd>Identifier of the execution run</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext.TOutputType</dt><dd>The expression result converted to <strong>TOutputType</strong></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>expression</strong> is null or empty</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.executedecision_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision___16z7t5v" />  DmnExecutionContext.ExecuteDecision(IDmnDecision) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Executes (evaluates) given <strong>decision</strong>



```csharp
public virtual DmnDecisionResult ExecuteDecision(IDmnDecision decision)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6) <strong>decision</strong></dt><dd>Decision to execute</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)</dt><dd>Decision result</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>decision</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.executedecision_system.string___1olcv5p" />  DmnExecutionContext.ExecuteDecision(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Executes (evaluates) decision with given <strong>decisionName</strong>



```csharp
public DmnDecisionResult ExecuteDecision(string decisionName)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>decisionName</strong></dt><dd>Name of the decision to execute</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)</dt><dd>Decision result</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>decisionName</strong> is null or empty</dd><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#t-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception__kkv81y)</dt><dd>Decision with <strong>decisionName</strong> not found</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.getparsedexpressioncachekey_system.string-system.string-system.type___pepfrp" />  DmnExecutionContext.GetParsedExpressionCacheKey(string, string, Type) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Compose the parsed expression key (based on [ParsedExpressionCacheScope](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions.parsedexpressioncachescope__1i7b48p) )



```csharp
protected virtual string GetParsedExpressionCacheKey(string executionId, string expression, Type outputType)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>executionId</strong></dt><dd>Identifier of the execution run</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Unparsed (raw) expression</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>outputType</strong></dt><dd>Expression output type</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Parsed expression key</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.getparsedexpressionsfromcache_system.string-dynamicexpresso.lambda-___1emk6yb" />  DmnExecutionContext.GetParsedExpressionsFromCache(string, Lambda) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Tries to retrieve the <strong>parsedExpression</strong> from the parsed expression cache using the <strong>cacheKey</strong> . [Global](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.global__1mtr259) and [Definition](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.definition__1muftjv) scopes use static [ParsedExpressionsCache](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.parsedexpressionscache__t9bsca) , otherwise the [ParsedExpressionsInstanceCache](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.parsedexpressionsinstancecache__bqtrb7) is used.



```csharp
protected virtual bool GetParsedExpressionsFromCache(string cacheKey, out Lambda parsedExpression)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>cacheKey</strong></dt><dd>Retrieval key of the <strong>parsedExpression</strong></dd><dt>DynamicExpresso.Lambda <strong>parsedExpression</strong></dt><dd>Parsed expression retrieved from cache if successful</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True when the <strong>parsedExpression</strong> has been retrieved from cache, otherwise false</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.getvariable_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable___qblh70" />  DmnExecutionContext.GetVariable(IDmnVariable) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Gets the runtime (execution) variable corresponding to its <strong>definition</strong>



```csharp
public DmnExecutionVariable GetVariable(IDmnVariable definition)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w) <strong>definition</strong></dt><dd>Name of the variable</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)</dt><dd>Variable  corresponding to its <strong>definition</strong></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>definition</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.getvariable_system.string___1pjw2vs" />  DmnExecutionContext.GetVariable(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Gets the runtime (execution) variable with given <strong>name</strong>



```csharp
public virtual DmnExecutionVariable GetVariable(string name)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the variable</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)</dt><dd>Variable with given <strong>name</strong></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>name</strong> is null or empty</dd><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#t-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception__kkv81y)</dt><dd>Variable not found</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.purgeexpressioncachecontextscope__122h9jv" />  DmnExecutionContext.PurgeExpressionCacheContextScope() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Purge all cached expressions belonging to this Context scope



```csharp
public virtual void PurgeExpressionCacheContextScope()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.purgeexpressioncachedefinitionscope_system.string___1khcjlo" />  DmnExecutionContext.PurgeExpressionCacheDefinitionScope(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Purge all cached expressions belonging to given Definition <strong>definitionId</strong> scope



```csharp
public static void PurgeExpressionCacheDefinitionScope(string definitionId)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>definitionId</strong></dt><dd>Definition Id</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.purgeexpressioncachedefinitionscopeall__ual138" />  DmnExecutionContext.PurgeExpressionCacheDefinitionScopeAll() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Purge all cached expressions belonging to any Definition scope



```csharp
public static void PurgeExpressionCacheDefinitionScopeAll()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.purgeexpressioncacheexecutionscope_system.string___1g6h7zp" />  DmnExecutionContext.PurgeExpressionCacheExecutionScope(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Purge all cached expressions belonging to given Execution <strong>executionId</strong> scope



```csharp
public virtual void PurgeExpressionCacheExecutionScope(string executionId)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>executionId</strong></dt><dd>Execution Id</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.purgeexpressioncacheexecutionscopeall__2zws8b" />  DmnExecutionContext.PurgeExpressionCacheExecutionScopeAll() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Purge all cached expressions belonging to any Execution scope



```csharp
public virtual void PurgeExpressionCacheExecutionScopeAll()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.purgeexpressioncacheglobalscope__11j6uir" />  DmnExecutionContext.PurgeExpressionCacheGlobalScope() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Purge all cached expressions belonging to Global scope



```csharp
public static void PurgeExpressionCacheGlobalScope()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.reset__2lfhbq" />  DmnExecutionContext.Reset() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Resets the DMN execution context - clears all variables except the input parameters (sets them to null) and clears the snapshots



```csharp
public virtual DmnExecutionContext Reset()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)</dt><dd>[DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.setinterpreterparameters_system.collections.generic.list_dynamicexpresso.parameter____g8t4d0" />  DmnExecutionContext.SetInterpreterParameters(List&lt;DynamicExpresso.Parameter&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Prepares the parameters that will be used when invoking the expression. All [Variables](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.variables__1o7e2gh) are added to <strong>parameters</strong> .



```csharp
protected virtual void SetInterpreterParameters(List<DynamicExpresso.Parameter> parameters)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;DynamicExpresso.Parameter&gt;</a> <strong>parameters</strong></dt><dd>Set of parameters that will be used for expression invocation</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.withinputparameter_system.string-system.object___qjwb99" />  DmnExecutionContext.WithInputParameter(string, object) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Sets the named input parameter <strong>value</strong>



```csharp
public virtual DmnExecutionContext WithInputParameter(string name, object value)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the input parameter</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>value</strong></dt><dd>Value of the input parameter</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)</dt><dd>[DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)</dd></dl>


###  Remarks ###
Variable [Value](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.value__19higaq) setter doesn&#39;t allow to set the value for the input parameters to prevent the change of them, so [SetInputParameterValue(object)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.setinputparametervalue_system.object___6idjlt) is to be used explicitly


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>name</strong> is null or empty</dd><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#t-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception__kkv81y)</dt><dd>Input parameter with given <strong>name</strong> doesn&#39;t exist</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.withinputparameters_system.collections.generic.ireadonlycollection_system.collections.generic.keyvaluepair_system.string-system.object_____s0ztk9" />  DmnExecutionContext.WithInputParameters(IReadOnlyCollection&lt;System.Collections.Generic.KeyValuePair&lt;string,object&gt;&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)           
Sources: engine\execution\context\DmnExecutionContext.cs</small>


Sets the input parameters from key-value collection (key=name of parameter, value=value to be set)



```csharp
public virtual DmnExecutionContext WithInputParameters(IReadOnlyCollection<System.Collections.Generic.KeyValuePair<string,object>> parameters)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;System.Collections.Generic.KeyValuePair&lt;string,object&gt;&gt;</a> <strong>parameters</strong></dt><dd>Collection of parameters - Key=name, Value=value</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)</dt><dd>[DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)</dd></dl>


###  Remarks ###
Variable [Value](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.value__19higaq) setter doesn&#39;t allow to set the value for the input parameters to prevent the change of them, so [SetInputParameterValue(object)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.setinputparametervalue_system.object___6idjlt) is to be used explicitly


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>parameters</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextfactory__zcbl72" />  DmnExecutionContextFactory Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\execution\context\DmnExecutionContextFactory.cs</small>


Factory creating the DMN Model execution context from [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) or [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)



```csharp
public static class DmnExecutionContextFactory
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CreateCustomExecutionContext&lt;T&gt;(DmnDefinition, Action&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions&gt;)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextfactory.createcustomexecutioncontext--1_net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition-system.action_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions____zyyiig) | public static | Creates the execution context from <strong>sourceDefinition</strong> | 
 | [CreateCustomExecutionContext&lt;T&gt;(DmnModel, Action&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions&gt;)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextfactory.createcustomexecutioncontext--1_net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel-system.action_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions____v6dyk7) | public static | Creates the execution context from <strong>sourceModel</strong> | 
 | [CreateExecutionContext(DmnDefinition, Action&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions&gt;)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextfactory.createexecutioncontext_net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition-system.action_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions____17my8oa) | public static | Creates the execution context from <strong>sourceDefinition</strong> | 
 | [CreateExecutionContext(DmnModel, Action&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions&gt;)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextfactory.createexecutioncontext_net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel-system.action_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions____1yuu2u9) | public static | Creates the execution context from <strong>sourceModel</strong> | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextfactory.createcustomexecutioncontext--1_net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition-system.action_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions____zyyiig" />  DmnExecutionContextFactory.CreateCustomExecutionContext&lt;T&gt;(DmnDefinition, Action&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContextFactory](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextfactory__zcbl72)           
Sources: engine\execution\context\DmnExecutionContextFactory.cs</small>


Creates the execution context from <strong>sourceDefinition</strong>



```csharp
public static DmnExecutionContext CreateCustomExecutionContext<T>(DmnDefinition sourceDefinition, Action<net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions> configure = null) where T: DmnExecutionContext
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd>Type of the execution context to be created. Must be [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) or its descendant</dd></dl>
<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) <strong>sourceDefinition</strong></dt><dd>Source model definition  to create the execution context for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.action-1" target="_blank" >System.Action&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions&gt;</a> <strong>configure</strong></dt><dd>Optional configuration action</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)</dt><dd><strong>sourceDefinition</strong> execution context</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>sourceDefinition</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextfactory.createcustomexecutioncontext--1_net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel-system.action_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions____v6dyk7" />  DmnExecutionContextFactory.CreateCustomExecutionContext&lt;T&gt;(DmnModel, Action&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContextFactory](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextfactory__zcbl72)           
Sources: engine\execution\context\DmnExecutionContextFactory.cs</small>


Creates the execution context from <strong>sourceModel</strong>



```csharp
public static DmnExecutionContext CreateCustomExecutionContext<T>(DmnModel sourceModel, Action<net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions> configure = null) where T: DmnExecutionContext
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd>Type of the execution context to be created. Must be [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) or its descendant</dd></dl>
<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) <strong>sourceModel</strong></dt><dd>Source model to create the execution context for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.action-1" target="_blank" >System.Action&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions&gt;</a> <strong>configure</strong></dt><dd>Optional configuration action</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)</dt><dd><strong>sourceModel</strong> execution context</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>sourceModel</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextfactory.createexecutioncontext_net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition-system.action_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions____17my8oa" />  DmnExecutionContextFactory.CreateExecutionContext(DmnDefinition, Action&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContextFactory](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextfactory__zcbl72)           
Sources: engine\execution\context\DmnExecutionContextFactory.cs</small>


Creates the execution context from <strong>sourceDefinition</strong>



```csharp
public static DmnExecutionContext CreateExecutionContext(DmnDefinition sourceDefinition, Action<net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions> configure = null)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) <strong>sourceDefinition</strong></dt><dd>Source model definition  to create the execution context for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.action-1" target="_blank" >System.Action&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions&gt;</a> <strong>configure</strong></dt><dd>Optional configuration action</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)</dt><dd><strong>sourceDefinition</strong> execution context</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>sourceDefinition</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextfactory.createexecutioncontext_net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel-system.action_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions____1yuu2u9" />  DmnExecutionContextFactory.CreateExecutionContext(DmnModel, Action&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContextFactory](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextfactory__zcbl72)           
Sources: engine\execution\context\DmnExecutionContextFactory.cs</small>


Creates the execution context from <strong>sourceModel</strong>



```csharp
public static DmnExecutionContext CreateExecutionContext(DmnModel sourceModel, Action<net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions> configure = null)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) <strong>sourceModel</strong></dt><dd>Source model to create the execution context for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.action-1" target="_blank" >System.Action&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions&gt;</a> <strong>configure</strong></dt><dd>Optional configuration action</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)</dt><dd><strong>sourceModel</strong> execution context</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>sourceModel</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions__13hymf6" />  DmnExecutionContextOptions Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\execution\context\DmnExecutionContextOptions.cs</small>


Execution configuration options



```csharp
public class DmnExecutionContextOptions : IDmnExecutionContextOptions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: [net.adamec.lib.common.dmn.engine.engine.execution.context.IDmnExecutionContextOptions](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions__1nc74ur)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [EvaluateTableOutputsInParallel](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions.evaluatetableoutputsinparallel__1t745k9) | public | Flag whether to evaluate the table outputs for positive rules in parallel (false by default). This option can be used for performance tuning. | 
 | [EvaluateTableRulesInParallel](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions.evaluatetablerulesinparallel__642z1w) | public | Flag whether to evaluate the table rules in parallel (true by default). This option can be used for performance tuning. | 
 | [ParsedExpressionCacheScope](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions.parsedexpressioncachescope__1i7b48p) | public | Scope of the parsed expression cache (Cache parsed expressions for definition cross contexts by default) | 
 | [RecordSnapshots](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions.recordsnapshots__owanre) | public | Flag whether to record snapshots of variables and results during the execution (false by default). This option can be used for execution tracking/audit and/or debugging | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions.evaluatetableoutputsinparallel__1t745k9" />  DmnExecutionContextOptions.EvaluateTableOutputsInParallel Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContextOptions](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions__13hymf6)           
Sources: engine\execution\context\DmnExecutionContextOptions.cs</small>


Flag whether to evaluate the table outputs for positive rules in parallel (false by default). This option can be used for performance tuning.



```csharp
public bool EvaluateTableOutputsInParallel { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>Implements: [IDmnExecutionContextOptions.EvaluateTableOutputsInParallel](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions.evaluatetableoutputsinparallel__35u85o)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions.evaluatetablerulesinparallel__642z1w" />  DmnExecutionContextOptions.EvaluateTableRulesInParallel Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContextOptions](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions__13hymf6)           
Sources: engine\execution\context\DmnExecutionContextOptions.cs</small>


Flag whether to evaluate the table rules in parallel (true by default). This option can be used for performance tuning.



```csharp
public bool EvaluateTableRulesInParallel { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>Implements: [IDmnExecutionContextOptions.EvaluateTableRulesInParallel](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions.evaluatetablerulesinparallel__14h13gd)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions.parsedexpressioncachescope__1i7b48p" />  DmnExecutionContextOptions.ParsedExpressionCacheScope Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContextOptions](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions__13hymf6)           
Sources: engine\execution\context\DmnExecutionContextOptions.cs</small>


Scope of the parsed expression cache (Cache parsed expressions for definition cross contexts by default)



```csharp
public ParsedExpressionCacheScopeEnum ParsedExpressionCacheScope { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.ParsedExpressionCacheScopeEnum](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum__li5aty)</dt><dd></dd></dl>Implements: [IDmnExecutionContextOptions.ParsedExpressionCacheScope](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions.parsedexpressioncachescope__is5v9o)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions.recordsnapshots__owanre" />  DmnExecutionContextOptions.RecordSnapshots Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContextOptions](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions__13hymf6)           
Sources: engine\execution\context\DmnExecutionContextOptions.cs</small>


Flag whether to record snapshots of variables and results during the execution (false by default). This option can be used for execution tracking/audit and/or debugging



```csharp
public bool RecordSnapshots { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>Implements: [IDmnExecutionContextOptions.RecordSnapshots](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions.recordsnapshots__194qspf)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot__1i0lwwl" />  DmnExecutionSnapshot Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\execution\context\DmnExecutionSnapshot.cs</small>


Snapshot of execution context generated at the beginning of [execution](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext.executedecision_system.string___1olcv5p) and after execution of decision. The snapshot (step) is generated for each decision in dependency tree



```csharp
public sealed class DmnExecutionSnapshot
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decision](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot.decision__1wdzzon) | public | Decision executed just before snapshot (null for the snapshot #0 created at the beginning of execution) | 
 | [DecisionName](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot.decisionname__tf23kg) | public | Name of the decision executed just before snapshot (null for the snapshot #0 created at the beginning of execution) | 
 | [DecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot.decisionresult__11f9i2a) | public | Result of the decision executed just before snapshot (null for the snapshot #0 created at the beginning of execution) | 
 | [Step](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot.step__foylex) | public | Zero based sequence number of the execution step | 
 | [Variables](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot.variables__bdt46) | public | Snapshot (clone) of all execution variables in execution context | 

 


###  Indexers ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [this[string]](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot.item_system.string___15rj7bd) | public | Gets the variable by <strong>variableName</strong> | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExecutionSnapshot(int, DmnExecutionContext)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot.-ctor_system.int32-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext___1lzvesn) | internal | CTOR | 
 | [DmnExecutionSnapshot(int, DmnExecutionContext, IDmnDecision, DmnDecisionResult)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot.-ctor_system.int32-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult___1r0ma51) | internal | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot.decision__1wdzzon" />  DmnExecutionSnapshot.Decision Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionSnapshot](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot__1i0lwwl)           
Sources: engine\execution\context\DmnExecutionSnapshot.cs</small>


Decision executed just before snapshot (null for the snapshot #0 created at the beginning of execution)



```csharp
public IDmnDecision Decision { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot.decisionname__tf23kg" />  DmnExecutionSnapshot.DecisionName Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionSnapshot](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot__1i0lwwl)           
Sources: engine\execution\context\DmnExecutionSnapshot.cs</small>


Name of the decision executed just before snapshot (null for the snapshot #0 created at the beginning of execution)



```csharp
public string DecisionName { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot.decisionresult__11f9i2a" />  DmnExecutionSnapshot.DecisionResult Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionSnapshot](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot__1i0lwwl)           
Sources: engine\execution\context\DmnExecutionSnapshot.cs</small>


Result of the decision executed just before snapshot (null for the snapshot #0 created at the beginning of execution)



```csharp
public DmnDecisionResult DecisionResult { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot.step__foylex" />  DmnExecutionSnapshot.Step Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionSnapshot](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot__1i0lwwl)           
Sources: engine\execution\context\DmnExecutionSnapshot.cs</small>


Zero based sequence number of the execution step



```csharp
public int Step { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot.item_system.string___15rj7bd" />  DmnExecutionSnapshot.this[string] Indexer ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionSnapshot](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot__1i0lwwl)           
Sources: engine\execution\context\DmnExecutionSnapshot.cs</small>


Gets the variable by <strong>variableName</strong>



```csharp
public DmnExecutionVariable this[string variableName] { get; }
```

<strong>Indexer parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <em>variableName</em></dt><dd>Name of the variable to retrieve</dd></dl>
<strong>Indexer value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)</dt><dd></dd></dl>Returns: Variable with given <strong>variableName</strong> or null when not found           



Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot.variables__bdt46" />  DmnExecutionSnapshot.Variables Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionSnapshot](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot__1i0lwwl)           
Sources: engine\execution\context\DmnExecutionSnapshot.cs</small>


Snapshot (clone) of all execution variables in execution context



```csharp
public IReadOnlyList<net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable> Variables { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot.-ctor_system.int32-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext___1lzvesn" />  DmnExecutionSnapshot.DmnExecutionSnapshot(int, DmnExecutionContext) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionSnapshot](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot__1i0lwwl)           
Sources: engine\execution\context\DmnExecutionSnapshot.cs</small>


CTOR



```csharp
internal DmnExecutionSnapshot(int step, DmnExecutionContext ctx)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>step</strong></dt><dd>Sequence number of the execution step</dd><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) <strong>ctx</strong></dt><dd>Execution context to create snapshot for</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot.-ctor_system.int32-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult___1r0ma51" />  DmnExecutionSnapshot.DmnExecutionSnapshot(int, DmnExecutionContext, IDmnDecision, DmnDecisionResult) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionSnapshot](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot__1i0lwwl)           
Sources: engine\execution\context\DmnExecutionSnapshot.cs</small>


CTOR



```csharp
internal DmnExecutionSnapshot(int step, DmnExecutionContext ctx, IDmnDecision decision, DmnDecisionResult result)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>step</strong></dt><dd>Sequence number of the execution step</dd><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) <strong>ctx</strong></dt><dd>Execution context to create snapshot for</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6) <strong>decision</strong></dt><dd>Decision executed just before snapshot</dd><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka) <strong>result</strong></dt><dd>Result of the decision executed just before snapshot</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots__wr7yxu" />  DmnExecutionSnapshots Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\execution\context\DmnExecutionSnapshots.cs</small>


Set of available snapshots



```csharp
public sealed class DmnExecutionSnapshots
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [snapshots](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots.snapshots__lwdmhp) | private | Internal set of available snapshots | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Last](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots.last__4me03k) | public | Last snapshot available or null when there are no snapshot | 
 | [Snapshots](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots.snapshots__1xtk5if) | public | Set of available snapshots | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExecutionSnapshots()](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots.-ctor__4mm0n8) | internal | Internal CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CreateSnapshot(DmnExecutionContext)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots.createsnapshot_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext___1cqnzqo) | internal | Creates the snapshot without the decision information | 
 | [CreateSnapshot(DmnExecutionContext, IDmnDecision, DmnDecisionResult)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots.createsnapshot_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult___1lnbhpg) | internal | Creates the snapshot with the decision information | 
 | [Reset()](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots.reset__7eocb4) | internal | Clears the set of snapshots | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots.snapshots__lwdmhp" />  DmnExecutionSnapshots.snapshots Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionSnapshots](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots__wr7yxu)           
Sources: engine\execution\context\DmnExecutionSnapshots.cs</small>


Internal set of available snapshots



```csharp
private readonly List<net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionSnapshot> snapshots
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionSnapshot&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots.last__4me03k" />  DmnExecutionSnapshots.Last Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionSnapshots](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots__wr7yxu)           
Sources: engine\execution\context\DmnExecutionSnapshots.cs</small>


Last snapshot available or null when there are no snapshot



```csharp
public DmnExecutionSnapshot Last { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionSnapshot](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshot__1i0lwwl)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots.snapshots__1xtk5if" />  DmnExecutionSnapshots.Snapshots Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionSnapshots](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots__wr7yxu)           
Sources: engine\execution\context\DmnExecutionSnapshots.cs</small>


Set of available snapshots



```csharp
public IReadOnlyList<net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionSnapshot> Snapshots { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionSnapshot&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots.-ctor__4mm0n8" />  DmnExecutionSnapshots.DmnExecutionSnapshots() Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionSnapshots](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots__wr7yxu)           
Sources: engine\execution\context\DmnExecutionSnapshots.cs</small>


Internal CTOR



```csharp
internal DmnExecutionSnapshots()
```

Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots.createsnapshot_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext___1cqnzqo" />  DmnExecutionSnapshots.CreateSnapshot(DmnExecutionContext) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionSnapshots](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots__wr7yxu)           
Sources: engine\execution\context\DmnExecutionSnapshots.cs</small>


Creates the snapshot without the decision information



```csharp
internal void CreateSnapshot(DmnExecutionContext ctx)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) <strong>ctx</strong></dt><dd>Execution context to create snapshot for</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots.createsnapshot_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult___1lnbhpg" />  DmnExecutionSnapshots.CreateSnapshot(DmnExecutionContext, IDmnDecision, DmnDecisionResult) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionSnapshots](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots__wr7yxu)           
Sources: engine\execution\context\DmnExecutionSnapshots.cs</small>


Creates the snapshot with the decision information



```csharp
internal void CreateSnapshot(DmnExecutionContext ctx, IDmnDecision decision, DmnDecisionResult result)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) <strong>ctx</strong></dt><dd>Execution context to create snapshot for</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6) <strong>decision</strong></dt><dd>Decision executed just before snapshot</dd><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka) <strong>result</strong></dt><dd>Result of the decision executed just before snapshot</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots.reset__7eocb4" />  DmnExecutionSnapshots.Reset() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionSnapshots](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionsnapshots__wr7yxu)           
Sources: engine\execution\context\DmnExecutionSnapshots.cs</small>


Clears the set of snapshots



```csharp
internal void Reset()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn" />  DmnExecutionVariable Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


Runtime (execution) variable



```csharp
public class DmnExecutionVariable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [_value](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable._value__bzp68z) | protected | Backing field for [Value](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.value__19higaq) property | 
 | [Logger](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.logger__1m5ji1b) | protected static | Logger | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Definition](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.definition__25wqos) | protected | Variable definition | 
 | [IsInputParameter](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.isinputparameter__42owxq) | public | Flag whether the variable is input parameter | 
 | [Label](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.label__bm6ver) | public | Label of the variable (used for input parameters) | 
 | [Name](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.name__bp1gta) | public | Unique variable name | 
 | [NameWithLabel](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.namewithlabel__1f40tgo) | public | Name with label information in case [Label](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.label__bm6ver) is different than [Name](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.name__bp1gta) | 
 | [Type](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.type__zll1w1) | public | Variable type or null if not defined | 
 | [Value](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.value__19higaq) | public | Variable value | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExecutionVariable(DmnExecutionVariable)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.-ctor_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable___1i5kgbp) | protected | CTOR for [Clone()](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.clone__691lg7) | 
 | [DmnExecutionVariable(IDmnVariable)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable___1c49d5k) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Clone()](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.clone__691lg7) | public | Clones the variable | 
 | [GetHashCode()](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.gethashcode__5b1sjh) | public | Gets the variable hashcode from name and value | 
 | [SetInputParameterValue(object)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.setinputparametervalue_system.object___6idjlt) | public | Sets the input parameter variable value | 
 | [SetValueInternal(object)](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.setvalueinternal_system.object___1k31hbt) | protected | Sets the internal value without checking whether it&#39;s input param | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.tostring__1w2rhw2) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable._value__bzp68z" />  DmnExecutionVariable._value Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


Backing field for [Value](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.value__19higaq) property



```csharp
protected object _value
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.logger__1m5ji1b" />  DmnExecutionVariable.Logger Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


Logger



```csharp
protected static ILogger Logger
```

<strong>Field value</strong><dl><dt>net.adamec.lib.common.core.logging.ILogger</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.definition__25wqos" />  DmnExecutionVariable.Definition Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


Variable definition



```csharp
protected IDmnVariable Definition { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.isinputparameter__42owxq" />  DmnExecutionVariable.IsInputParameter Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


Flag whether the variable is input parameter



```csharp
public bool IsInputParameter { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.label__bm6ver" />  DmnExecutionVariable.Label Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


Label of the variable (used for input parameters)



```csharp
public string Label { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.name__bp1gta" />  DmnExecutionVariable.Name Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


Unique variable name



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.namewithlabel__1f40tgo" />  DmnExecutionVariable.NameWithLabel Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


Name with label information in case [Label](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.label__bm6ver) is different than [Name](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.name__bp1gta)



```csharp
public string NameWithLabel { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.type__zll1w1" />  DmnExecutionVariable.Type Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


Variable type or null if not defined



```csharp
public Type Type { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.value__19higaq" />  DmnExecutionVariable.Value Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


Variable value



```csharp
public virtual object Value { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#t-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception__kkv81y)</dt><dd>Setter: Can&#39;t override input parameter</dd><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#t-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception__kkv81y)</dt><dd>Setter: Can&#39;t cast value to target type</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.-ctor_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable___1i5kgbp" />  DmnExecutionVariable.DmnExecutionVariable(DmnExecutionVariable) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


CTOR for [Clone()](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.clone__691lg7)



```csharp
protected DmnExecutionVariable(DmnExecutionVariable cloneFrom)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn) <strong>cloneFrom</strong></dt><dd>Variable to clone</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable___1c49d5k" />  DmnExecutionVariable.DmnExecutionVariable(IDmnVariable) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


CTOR



```csharp
public DmnExecutionVariable(IDmnVariable definition)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w) <strong>definition</strong></dt><dd>Variable definition</dd></dl>
###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>definition</strong> is null</dd><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#t-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception__kkv81y)</dt><dd>Missing variable name</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.clone__691lg7" />  DmnExecutionVariable.Clone() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


Clones the variable



```csharp
public virtual DmnExecutionVariable Clone()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)</dt><dd>Cloned variable</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.gethashcode__5b1sjh" />  DmnExecutionVariable.GetHashCode() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


Gets the variable hashcode from name and value



```csharp
public override int GetHashCode()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd>Variable hashcode</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode#System_Object_GetHashCode" target="_blank" >object.GetHashCode</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.setinputparametervalue_system.object___6idjlt" />  DmnExecutionVariable.SetInputParameterValue(object) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


Sets the input parameter variable value



```csharp
public virtual void SetInputParameterValue(object value)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>value</strong></dt><dd>Value to be set</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Remarks ###
It&#39;s not possible to set the input parameter variable value using the [Value](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.value__19higaq) property setter by design. This dedicated method it to be used to ensure that the input parameter value is set intentionally (from [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) )


###  Exceptions ###
<dl><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#t-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception__kkv81y)</dt><dd>Variable is not an input parameter</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.setvalueinternal_system.object___1k31hbt" />  DmnExecutionVariable.SetValueInternal(object) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


Sets the internal value without checking whether it&#39;s input param



```csharp
protected void SetValueInternal(object value)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>value</strong></dt><dd>New variable value</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#t-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception__kkv81y)</dt><dd>Can&#39;t cast value to target type</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable.tostring__1w2rhw2" />  DmnExecutionVariable.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)           
Sources: engine\execution\context\DmnExecutionVariable.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions__1nc74ur" />  IDmnExecutionContextOptions Interface ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\execution\context\IDmnExecutionContextOptions.cs</small>


Execution configuration options



```csharp
public interface IDmnExecutionContextOptions
```

Implemented by: [net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContextOptions](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontextoptions__13hymf6)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [EvaluateTableOutputsInParallel](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions.evaluatetableoutputsinparallel__35u85o) | public abstract | Flag whether to evaluate the table outputs for positive rules in parallel (false by default). This option can be used for performance tuning. | 
 | [EvaluateTableRulesInParallel](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions.evaluatetablerulesinparallel__14h13gd) | public abstract | Flag whether to evaluate the table rules in parallel (true by default). This option can be used for performance tuning. | 
 | [ParsedExpressionCacheScope](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions.parsedexpressioncachescope__is5v9o) | public abstract | Scope of the parsed expression cache (Cache parsed expressions for definition cross contexts by default) | 
 | [RecordSnapshots](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#p-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions.recordsnapshots__194qspf) | public abstract | Flag whether to record snapshots of variables and results during the execution (false by default). This option can be used for execution tracking/audit and/or debugging | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions.evaluatetableoutputsinparallel__35u85o" />  IDmnExecutionContextOptions.EvaluateTableOutputsInParallel Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnExecutionContextOptions](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions__1nc74ur)           
Sources: engine\execution\context\IDmnExecutionContextOptions.cs</small>


Flag whether to evaluate the table outputs for positive rules in parallel (false by default). This option can be used for performance tuning.



```csharp
public abstract bool EvaluateTableOutputsInParallel { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions.evaluatetablerulesinparallel__14h13gd" />  IDmnExecutionContextOptions.EvaluateTableRulesInParallel Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnExecutionContextOptions](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions__1nc74ur)           
Sources: engine\execution\context\IDmnExecutionContextOptions.cs</small>


Flag whether to evaluate the table rules in parallel (true by default). This option can be used for performance tuning.



```csharp
public abstract bool EvaluateTableRulesInParallel { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions.parsedexpressioncachescope__is5v9o" />  IDmnExecutionContextOptions.ParsedExpressionCacheScope Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnExecutionContextOptions](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions__1nc74ur)           
Sources: engine\execution\context\IDmnExecutionContextOptions.cs</small>


Scope of the parsed expression cache (Cache parsed expressions for definition cross contexts by default)



```csharp
public abstract ParsedExpressionCacheScopeEnum ParsedExpressionCacheScope { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.ParsedExpressionCacheScopeEnum](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum__li5aty)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions.recordsnapshots__194qspf" />  IDmnExecutionContextOptions.RecordSnapshots Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnExecutionContextOptions](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.idmnexecutioncontextoptions__1nc74ur)           
Sources: engine\execution\context\IDmnExecutionContextOptions.cs</small>


Flag whether to record snapshots of variables and results during the execution (false by default). This option can be used for execution tracking/audit and/or debugging



```csharp
public abstract bool RecordSnapshots { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum__li5aty" />  ParsedExpressionCacheScopeEnum Enum ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\execution\context\ParsedExpressionCacheScopeEnum.cs</small>


Scope of the parsed expression cache



```csharp
public enum ParsedExpressionCacheScopeEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [None](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.none__1di2vgo) | 0 | Don&#39;t cache parsed expressions | 
 | [Execution](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.execution__1p8porw) | 1 | Cache parsed expressions within the single execution run only | 
 | [Context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.context__1nigzat) | 2 | Cache parsed expressions within execution context only | 
 | [Definition](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.definition__1muftjv) | 3 | Cache parsed expressions for definition (cross execution contexts) | 
 | [Global](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.global__1mtr259) | 4 | Cache parsed expressions globally (cross definitions and execution contexts) | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.context__1nigzat" />  ParsedExpressionCacheScopeEnum.Context Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ParsedExpressionCacheScopeEnum](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum__li5aty)           
Sources: engine\execution\context\ParsedExpressionCacheScopeEnum.cs</small>


Cache parsed expressions within execution context only



```csharp
 Context = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.ParsedExpressionCacheScopeEnum](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum__li5aty)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.definition__1muftjv" />  ParsedExpressionCacheScopeEnum.Definition Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ParsedExpressionCacheScopeEnum](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum__li5aty)           
Sources: engine\execution\context\ParsedExpressionCacheScopeEnum.cs</small>


Cache parsed expressions for definition (cross execution contexts)



```csharp
 Definition = 3
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.ParsedExpressionCacheScopeEnum](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum__li5aty)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.execution__1p8porw" />  ParsedExpressionCacheScopeEnum.Execution Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ParsedExpressionCacheScopeEnum](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum__li5aty)           
Sources: engine\execution\context\ParsedExpressionCacheScopeEnum.cs</small>


Cache parsed expressions within the single execution run only



```csharp
 Execution = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.ParsedExpressionCacheScopeEnum](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum__li5aty)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.global__1mtr259" />  ParsedExpressionCacheScopeEnum.Global Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ParsedExpressionCacheScopeEnum](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum__li5aty)           
Sources: engine\execution\context\ParsedExpressionCacheScopeEnum.cs</small>


Cache parsed expressions globally (cross definitions and execution contexts)



```csharp
 Global = 4
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.ParsedExpressionCacheScopeEnum](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum__li5aty)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum.none__1di2vgo" />  ParsedExpressionCacheScopeEnum.None Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.context](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#n-net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ParsedExpressionCacheScopeEnum](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum__li5aty)           
Sources: engine\execution\context\ParsedExpressionCacheScopeEnum.cs</small>


Don&#39;t cache parsed expressions



```csharp
 None = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.ParsedExpressionCacheScopeEnum](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.parsedexpressioncachescopeenum__li5aty)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 




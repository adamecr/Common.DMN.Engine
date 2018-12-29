#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr" />  net.adamec.lib.common.dmn.engine.engine.runtime Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx) | public | Context where is the DMN model executed | 
 | [DmnExecutionContextFactory](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory__uacnp) | public | Factory creating the DMN Model execution context from [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) or [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) | 
 | [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc) | public | Runtime (execution) variable | 
 | [DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception__wgl6jc) | public | Exception thrown while executing (evaluating) the DMN Model | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx" />  DmnExecutionContext Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\runtime\DmnExecutionContext.cs</small>


Context where is the DMN model executed



```csharp
public class DmnExecutionContext
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Logger](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#f-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.logger__mpgrpl) | internal static | Logger | 
 | [ParsedExpressionsCache](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#f-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.parsedexpressionscache__1v2fbnt) | private static | Parsed (pre-processed) expressions cache | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decisions](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.decisions__wyubfy) | public | Dictionary of available decisions by name | 
 | [Definition](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.definition__15n6g7u) | public | DMN Model definition | 
 | [InputData](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.inputdata__1r9h2i9) | public | Input data interface. Input data will be stored as Variables, complex objects are supported | 
 | [Variables](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.variables__1e0n6x4) | public | Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExecutionContext(DmnDefinition, IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable&gt;, IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable&gt;, IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;)](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition-system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable_-system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable_-system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____z7886e) | internal | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [EvalExpression(string, Type)](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.evalexpression_system.string-system.type___xextna) | public | Evaluates expression | 
 | [EvalExpression&lt;TOutputType&gt;(string)](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.evalexpression--1_system.string___1dwxtzo) | public | Evaluates expression | 
 | [ExecuteDecision(IDmnDecision)](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.executedecision_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision___v1pcf2) | public | Executes (evaluates) given <strong>decision</strong> | 
 | [ExecuteDecision(string)](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.executedecision_system.string___5sc076) | public | Executes (evaluates) decision with given <strong>decisionName</strong> | 
 | [GetVariable(DmnVariableDefinition)](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.getvariable_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition___5npadz) | public | Gets the runtime (execution) variable corresponding to its <strong>definition</strong> | 
 | [GetVariable(string)](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.getvariable_system.string___1nfq849) | public | Gets the runtime (execution) variable with given <strong>name</strong> | 
 | [Reset()](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.reset__vwhi87) | public | Resets the DMN execution context - clears all variables except the input parameters (sets them to null) | 
 | [WithInputParameter(string, object)](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.withinputparameter_system.string-system.object___10uo5oi) | public | Sets the named input parameter <strong>value</strong> | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.logger__mpgrpl" />  DmnExecutionContext.Logger Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)           
Sources: engine\runtime\DmnExecutionContext.cs</small>


Logger



```csharp
internal static ILogger Logger
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.parsedexpressionscache__1v2fbnt" />  DmnExecutionContext.ParsedExpressionsCache Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)           
Sources: engine\runtime\DmnExecutionContext.cs</small>


Parsed (pre-processed) expressions cache



```csharp
private static readonly Dictionary<(string Item1, System.Type Item2),DynamicExpresso.Lambda> ParsedExpressionsCache
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;(string Item1, System.Type Item2),DynamicExpresso.Lambda&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.decisions__wyubfy" />  DmnExecutionContext.Decisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)           
Sources: engine\runtime\DmnExecutionContext.cs</small>


Dictionary of available decisions by name



```csharp
public IDictionary<string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> Decisions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.definition__15n6g7u" />  DmnExecutionContext.Definition Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)           
Sources: engine\runtime\DmnExecutionContext.cs</small>


DMN Model definition



```csharp
public DmnDefinition Definition { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.inputdata__1r9h2i9" />  DmnExecutionContext.InputData Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)           
Sources: engine\runtime\DmnExecutionContext.cs</small>


Input data interface. Input data will be stored as Variables, complex objects are supported



```csharp
public IDictionary<string,net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable> InputData { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.variables__1e0n6x4" />  DmnExecutionContext.Variables Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)           
Sources: engine\runtime\DmnExecutionContext.cs</small>


Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions



```csharp
public IDictionary<string,net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable> Variables { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition-system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable_-system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable_-system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____z7886e" />  DmnExecutionContext.DmnExecutionContext(DmnDefinition, IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable&gt;, IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable&gt;, IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)           
Sources: engine\runtime\DmnExecutionContext.cs</small>


CTOR



```csharp
internal DmnExecutionContext(DmnDefinition definition, IDictionary<string,net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable> variables, IDictionary<string,net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable> inputData, IDictionary<string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> decisions)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) <strong>definition</strong></dt><dd>DMN Model definition</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable&gt;</a> <strong>variables</strong></dt><dd>Variables used while executing the DMN model</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable&gt;</a> <strong>inputData</strong></dt><dd>Input data interface</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a> <strong>decisions</strong></dt><dd>Dictionary of available decisions by name</dd></dl>
###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>Any of the parameters is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.evalexpression_system.string-system.type___xextna" />  DmnExecutionContext.EvalExpression(string, Type) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)           
Sources: engine\runtime\DmnExecutionContext.cs</small>


Evaluates expression



```csharp
public object EvalExpression(string expression, Type outputType)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Expression to evaluate</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>outputType</strong></dt><dd>Output (result) type</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>The expression result converted to <strong>outputType</strong></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>expression</strong> is null or empty</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>outputType</strong> is null</dd><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception__wgl6jc)</dt><dd>Exception while invoking the expression</dd><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception__wgl6jc)</dt><dd>Can&#39;t convert the expression result to <strong>outputType</strong></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.evalexpression--1_system.string___1dwxtzo" />  DmnExecutionContext.EvalExpression&lt;TOutputType&gt;(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)           
Sources: engine\runtime\DmnExecutionContext.cs</small>


Evaluates expression



```csharp
public DmnExecutionContext.TOutputType EvalExpression<TOutputType>(string expression)
```

<strong>Type parameters</strong><dl><dt><strong>TOutputType</strong></dt><dd>Output (result) type</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Expression to evaluate</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionContext.TOutputType</dt><dd>The expression result converted to <strong>TOutputType</strong></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>expression</strong> is null or empty</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.executedecision_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision___v1pcf2" />  DmnExecutionContext.ExecuteDecision(IDmnDecision) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)           
Sources: engine\runtime\DmnExecutionContext.cs</small>


Executes (evaluates) given <strong>decision</strong>



```csharp
public DmnDecisionResult ExecuteDecision(IDmnDecision decision)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6) <strong>decision</strong></dt><dd>Decision to execute</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm)</dt><dd>Decision result</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>decision</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.executedecision_system.string___5sc076" />  DmnExecutionContext.ExecuteDecision(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)           
Sources: engine\runtime\DmnExecutionContext.cs</small>


Executes (evaluates) decision with given <strong>decisionName</strong>



```csharp
public DmnDecisionResult ExecuteDecision(string decisionName)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>decisionName</strong></dt><dd>Name of the decision to execute</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm)</dt><dd>Decision result</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>decisionName</strong> is null or empty</dd><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception__wgl6jc)</dt><dd>Decision with <strong>decisionName</strong> not found</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.getvariable_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition___5npadz" />  DmnExecutionContext.GetVariable(DmnVariableDefinition) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)           
Sources: engine\runtime\DmnExecutionContext.cs</small>


Gets the runtime (execution) variable corresponding to its <strong>definition</strong>



```csharp
public DmnExecutionVariable GetVariable(DmnVariableDefinition definition)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88) <strong>definition</strong></dt><dd>Name of the variable</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc)</dt><dd>Variable  corresponding to its <strong>definition</strong></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>definition</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.getvariable_system.string___1nfq849" />  DmnExecutionContext.GetVariable(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)           
Sources: engine\runtime\DmnExecutionContext.cs</small>


Gets the runtime (execution) variable with given <strong>name</strong>



```csharp
public DmnExecutionVariable GetVariable(string name)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the variable</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc)</dt><dd>Variable with given <strong>name</strong></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>name</strong> is null or empty</dd><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception__wgl6jc)</dt><dd>Variable not found</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.reset__vwhi87" />  DmnExecutionContext.Reset() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)           
Sources: engine\runtime\DmnExecutionContext.cs</small>


Resets the DMN execution context - clears all variables except the input parameters (sets them to null)



```csharp
public DmnExecutionContext Reset()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)</dt><dd>[DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext.withinputparameter_system.string-system.object___10uo5oi" />  DmnExecutionContext.WithInputParameter(string, object) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)           
Sources: engine\runtime\DmnExecutionContext.cs</small>


Sets the named input parameter <strong>value</strong>



```csharp
public DmnExecutionContext WithInputParameter(string name, object value)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the input parameter</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>value</strong></dt><dd>Value of the input parameter</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)</dt><dd>[DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)</dd></dl>


###  Remarks ###
Variable [Value](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.value__1tc871d) setter doesn&#39;t allow to set the value for the input parameters to prevent the change of them, so [SetInputParameterValue(object)](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.setinputparametervalue_system.object___1xg18tu) is to be used explicitly


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>name</strong> is null or empty</dd><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception__wgl6jc)</dt><dd>Input parameter with given <strong>name</strong> doesn&#39;t exist</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory__uacnp" />  DmnExecutionContextFactory Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\runtime\DmnExecutionContextFactory.cs</small>


Factory creating the DMN Model execution context from [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) or [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)



```csharp
public class DmnExecutionContextFactory
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decisions](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory.decisions__1shjjni) | public | Dictionary of available decisions by name | 
 | [InputData](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory.inputdata__xlqca5) | public | Input data interface. Input data will be stored as Variables, complex objects are supported | 
 | [Variables](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory.variables__12i376k) | public | Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExecutionContextFactory(DmnDefinition)](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition___16d9tcw) | protected | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CreateExecutionContext(DmnDefinition)](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory.createexecutioncontext_net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition___b1kv2e) | public static | Creates the execution context from <strong>sourceDefinition</strong> | 
 | [CreateExecutionContext(DmnModel)](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory.createexecutioncontext_net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel___1ha8kjx) | public static | Creates the execution context from <strong>sourceModel</strong> | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory.decisions__1shjjni" />  DmnExecutionContextFactory.Decisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContextFactory](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory__uacnp)           
Sources: engine\runtime\DmnExecutionContextFactory.cs</small>


Dictionary of available decisions by name



```csharp
public IDictionary<string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> Decisions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory.inputdata__xlqca5" />  DmnExecutionContextFactory.InputData Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContextFactory](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory__uacnp)           
Sources: engine\runtime\DmnExecutionContextFactory.cs</small>


Input data interface. Input data will be stored as Variables, complex objects are supported



```csharp
public IDictionary<string,net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable> InputData { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory.variables__12i376k" />  DmnExecutionContextFactory.Variables Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContextFactory](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory__uacnp)           
Sources: engine\runtime\DmnExecutionContextFactory.cs</small>


Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions



```csharp
public IDictionary<string,net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable> Variables { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition___16d9tcw" />  DmnExecutionContextFactory.DmnExecutionContextFactory(DmnDefinition) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContextFactory](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory__uacnp)           
Sources: engine\runtime\DmnExecutionContextFactory.cs</small>


CTOR



```csharp
protected DmnExecutionContextFactory(DmnDefinition source)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) <strong>source</strong></dt><dd>Source model definition  to create the execution context factory for</dd></dl>
###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>source</strong> is null</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd>No decisions in the source definition</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd>No variables in the source definition</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory.createexecutioncontext_net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition___b1kv2e" />  DmnExecutionContextFactory.CreateExecutionContext(DmnDefinition) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContextFactory](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory__uacnp)           
Sources: engine\runtime\DmnExecutionContextFactory.cs</small>


Creates the execution context from <strong>sourceDefinition</strong>



```csharp
public static DmnExecutionContext CreateExecutionContext(DmnDefinition sourceDefinition)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) <strong>sourceDefinition</strong></dt><dd>Source model definition  to create the execution context for</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)</dt><dd><strong>sourceDefinition</strong> execution context</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>sourceDefinition</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory.createexecutioncontext_net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel___1ha8kjx" />  DmnExecutionContextFactory.CreateExecutionContext(DmnModel) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionContextFactory](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory__uacnp)           
Sources: engine\runtime\DmnExecutionContextFactory.cs</small>


Creates the execution context from <strong>sourceModel</strong>



```csharp
public static DmnExecutionContext CreateExecutionContext(DmnModel sourceModel)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) <strong>sourceModel</strong></dt><dd>Source model to create the execution context for</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)</dt><dd><strong>sourceModel</strong> execution context</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>sourceModel</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc" />  DmnExecutionVariable Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\runtime\DmnExecutionVariable.cs</small>


Runtime (execution) variable



```csharp
public class DmnExecutionVariable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [_value](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#f-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable._value__10kb2mi) | private | Backing field for [Value](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.value__1tc871d) property | 
 | [Logger](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#f-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.logger__1q6bj3o) | internal static | Logger | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Definition](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.definition__b2ps5z) | private | Variable definition | 
 | [IsInputParameter](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.isinputparameter__1khcl57) | public | Flag whether the variable is input parameter | 
 | [Name](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.name__1uwcnwd) | public | Unique variable name | 
 | [Type](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.type__1rkj246) | public | Variable type or null if not defined | 
 | [Value](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.value__1tc871d) | public | Variable value | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExecutionVariable(DmnVariableDefinition)](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition___nql6cf) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Clone()](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.clone__bzm4ju) | public | Clones the variable | 
 | [GetHashCode()](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.gethashcode__jztng2) | public | Gets the variable hashcode from name and value | 
 | [SetInputParameterValue(object)](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.setinputparametervalue_system.object___1xg18tu) | public | Sets the input parameter variable value | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.tostring__1adloah) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable._value__10kb2mi" />  DmnExecutionVariable._value Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc)           
Sources: engine\runtime\DmnExecutionVariable.cs</small>


Backing field for [Value](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.value__1tc871d) property



```csharp
private object _value
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.logger__1q6bj3o" />  DmnExecutionVariable.Logger Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc)           
Sources: engine\runtime\DmnExecutionVariable.cs</small>


Logger



```csharp
internal static ILogger Logger
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.definition__b2ps5z" />  DmnExecutionVariable.Definition Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc)           
Sources: engine\runtime\DmnExecutionVariable.cs</small>


Variable definition



```csharp
private DmnVariableDefinition Definition { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.isinputparameter__1khcl57" />  DmnExecutionVariable.IsInputParameter Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc)           
Sources: engine\runtime\DmnExecutionVariable.cs</small>


Flag whether the variable is input parameter



```csharp
public bool IsInputParameter { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.name__1uwcnwd" />  DmnExecutionVariable.Name Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc)           
Sources: engine\runtime\DmnExecutionVariable.cs</small>


Unique variable name



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.type__1rkj246" />  DmnExecutionVariable.Type Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc)           
Sources: engine\runtime\DmnExecutionVariable.cs</small>


Variable type or null if not defined



```csharp
public Type Type { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.value__1tc871d" />  DmnExecutionVariable.Value Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc)           
Sources: engine\runtime\DmnExecutionVariable.cs</small>


Variable value



```csharp
public object Value { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception__wgl6jc)</dt><dd>Setter: Can&#39;t override input parameter</dd><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception__wgl6jc)</dt><dd>Setter: Can&#39;t cast value to target type</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition___nql6cf" />  DmnExecutionVariable.DmnExecutionVariable(DmnVariableDefinition) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc)           
Sources: engine\runtime\DmnExecutionVariable.cs</small>


CTOR



```csharp
public DmnExecutionVariable(DmnVariableDefinition definition)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88) <strong>definition</strong></dt><dd>Variable definition</dd></dl>
###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>definition</strong> is null</dd><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception__wgl6jc)</dt><dd>Missing variable name</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.clone__bzm4ju" />  DmnExecutionVariable.Clone() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc)           
Sources: engine\runtime\DmnExecutionVariable.cs</small>


Clones the variable



```csharp
public DmnExecutionVariable Clone()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc)</dt><dd>Cloned variable</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.gethashcode__jztng2" />  DmnExecutionVariable.GetHashCode() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc)           
Sources: engine\runtime\DmnExecutionVariable.cs</small>


Gets the variable hashcode from name and value



```csharp
public override int GetHashCode()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd>Variable hashcode</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode#System_Object_GetHashCode" target="_blank" >object.GetHashCode</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.setinputparametervalue_system.object___1xg18tu" />  DmnExecutionVariable.SetInputParameterValue(object) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc)           
Sources: engine\runtime\DmnExecutionVariable.cs</small>


Sets the input parameter variable value



```csharp
public void SetInputParameterValue(object value)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>value</strong></dt><dd>Value to be set</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Remarks ###
It&#39;s not possible to set the input parameter variable value using the [Value](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#p-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.value__1tc871d) property setter by design. This dedicated method it to be used to ensure that the input parameter value is set intentionally (from [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx) )


###  Exceptions ###
<dl><dt>[DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception__wgl6jc)</dt><dd>Variable is not an input parameter</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable.tostring__1adloah" />  DmnExecutionVariable.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc)           
Sources: engine\runtime\DmnExecutionVariable.cs</small>


Returns a string that represents the current object.



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception__wgl6jc" />  DmnExecutorException Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\runtime\DmnExecutorException.cs</small>


Exception thrown while executing (evaluating) the DMN Model



```csharp
public class DmnExecutorException : Exception
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable" target="_blank" >System.Runtime.Serialization.ISerializable</a>


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExecutorException(string, Exception)](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception.-ctor_system.string-system.exception___13w1dm1) | public | Creates [DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception__wgl6jc) with given <strong>message</strong> and optional <strong>innerException</strong> | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception.-ctor_system.string-system.exception___13w1dm1" />  DmnExecutorException.DmnExecutorException(string, Exception) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception__wgl6jc)           
Sources: engine\runtime\DmnExecutorException.cs</small>


Creates [DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception__wgl6jc) with given <strong>message</strong> and optional <strong>innerException</strong>



```csharp
public DmnExecutorException(string message, Exception innerException = null)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Error message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Optional inner exception</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 




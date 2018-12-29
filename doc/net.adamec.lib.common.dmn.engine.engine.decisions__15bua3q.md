#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q" />  net.adamec.lib.common.dmn.engine.engine.decisions Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj) | public abstract | DMN Decision definition | 
 | [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm) | public | Decision evaluation result (single or multiple) | 
 | [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult__12jrmrq) | public | Single decision result | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6) | public abstract | Decision interface | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj" />  DmnDecision Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\DmnDecision.cs</small>


DMN Decision definition



```csharp
public abstract class DmnDecision : IDmnDecision
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [net.adamec.lib.common.dmn.engine.engine.decisions.expression.DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9), [net.adamec.lib.common.dmn.engine.engine.decisions.table.DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Implements: [net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Logger](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.logger__1xp222x) | internal | Logger | 
 | [Name](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.name__11d67s8) | public | Decision unique name | 
 | [RequiredDecisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.requireddecisions__6uus9z) | public | List of decisions, the decision depends on | 
 | [RequiredInputs](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.requiredinputs__1kiuu49) | public | Decision required inputs (input variables) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecision(string, List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;, List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.-ctor_system.string-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition_-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____1w8i7j6) | protected | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Evaluate(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.evaluate_net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext-system.string___svwyjn) | protected abstract | Evaluates the decision. | 
 | [Execute(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.execute_net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext-system.string___8f53dn) | public | Executes the decision. The execution wrapper around [Evaluate(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.evaluate_net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext-system.string___svwyjn) . | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.logger__1xp222x" />  DmnDecision.Logger Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


Logger



```csharp
internal ILogger Logger { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.name__11d67s8" />  DmnDecision.Name Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


Decision unique name



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Implements: [IDmnDecision.Name](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.name__oi3x33)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.requireddecisions__6uus9z" />  DmnDecision.RequiredDecisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


List of decisions, the decision depends on



```csharp
public List<net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> RequiredDecisions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a></dt><dd></dd></dl>Implements: [IDmnDecision.RequiredDecisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requireddecisions__fxqsi4)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.requiredinputs__1kiuu49" />  DmnDecision.RequiredInputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


Decision required inputs (input variables)



```csharp
public List<net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> RequiredInputs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a></dt><dd></dd></dl>Implements: [IDmnDecision.RequiredInputs](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requiredinputs__nfywic)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.-ctor_system.string-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition_-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____1w8i7j6" />  DmnDecision.DmnDecision(string, List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;, List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


CTOR



```csharp
protected DmnDecision(string name, List<net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> requiredInputs, List<net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> requiredDecisions)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Decision unique name</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a> <strong>requiredInputs</strong></dt><dd>Decision required inputs (input variables)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a> <strong>requiredDecisions</strong></dt><dd>List of decisions, the decision depends on</dd></dl>
###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>name</strong> , <strong>requiredInputs</strong> or <strong>requiredDecisions</strong> is null</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd>Name is empty</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.evaluate_net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext-system.string___svwyjn" />  DmnDecision.Evaluate(DmnExecutionContext, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


Evaluates the decision.



```csharp
protected abstract DmnDecisionResult Evaluate(DmnExecutionContext context, string correlationId = null)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx) <strong>context</strong></dt><dd>DMN Engine execution context</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Optional correlation ID used while logging</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm)</dt><dd>Decision result</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.execute_net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext-system.string___8f53dn" />  DmnDecision.Execute(DmnExecutionContext, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


Executes the decision. The execution wrapper around [Evaluate(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.evaluate_net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext-system.string___svwyjn) .



```csharp
public DmnDecisionResult Execute(DmnExecutionContext context, string correlationId = null)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx) <strong>context</strong></dt><dd>DMN Engine execution context</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Optional correlation ID used while logging</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm)</dt><dd>Decision result</dd></dl>Implements: [IDmnDecision.Execute(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.execute_net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext-system.string___omcsfw)


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>context</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm" />  DmnDecisionResult Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\DmnDecisionResult.cs</small>


Decision evaluation result (single or multiple)



```csharp
public class DmnDecisionResult
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [results](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#f-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult.results__1ebt9pk) | private | Internal list of results. The first item represents the [SingleResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult.singleresult__1ojq3kz) | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [HasResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult.hasresult__1sfykxj) | public | Flag whether there is any result available | 
 | [IsSingleResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult.issingleresult__91fvfx) | public | Flag whether the decision  has single result | 
 | [Results](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult.results__1kp9eou) | public | List of decision evaluation results. | 
 | [SingleResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult.singleresult__1ojq3kz) | public | Decision evaluation single (first) result variables. When there is no result, the empty list of [variables](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc) is returned. | 

 


###  Operators and Conversions ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Add(DmnDecisionResult, DmnDecisionSingleResult)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult.op_addition_net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult___8283oa) | public static | Adds a single (one) result into the list of results | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult.results__1ebt9pk" />  DmnDecisionResult.results Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm)           
Sources: engine\decisions\DmnDecisionResult.cs</small>


Internal list of results. The first item represents the [SingleResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult.singleresult__1ojq3kz)



```csharp
private readonly List<net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecisionSingleResult> results
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecisionSingleResult&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult.hasresult__1sfykxj" />  DmnDecisionResult.HasResult Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm)           
Sources: engine\decisions\DmnDecisionResult.cs</small>


Flag whether there is any result available



```csharp
public bool HasResult { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult.issingleresult__91fvfx" />  DmnDecisionResult.IsSingleResult Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm)           
Sources: engine\decisions\DmnDecisionResult.cs</small>


Flag whether the decision  has single result



```csharp
public bool IsSingleResult { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult.results__1kp9eou" />  DmnDecisionResult.Results Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm)           
Sources: engine\decisions\DmnDecisionResult.cs</small>


List of decision evaluation results.



```csharp
public IReadOnlyList<net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecisionSingleResult> Results { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecisionSingleResult&gt;</a></dt><dd></dd></dl>


###  Remarks ###
The first item represents the [SingleResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult.singleresult__1ojq3kz) , however it&#39;s recommended to use the [SingleResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult.singleresult__1ojq3kz) when expecting the single result.


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult.singleresult__1ojq3kz" />  DmnDecisionResult.SingleResult Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm)           
Sources: engine\decisions\DmnDecisionResult.cs</small>


Decision evaluation single (first) result variables. When there is no result, the empty list of [variables](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc) is returned.



```csharp
public IReadOnlyList<net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable> SingleResult { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult.op_addition_net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult___8283oa" />  DmnDecisionResult.Add(DmnDecisionResult, DmnDecisionSingleResult) Operator ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm)           
Sources: engine\decisions\DmnDecisionResult.cs</small>


Adds a single (one) result into the list of results



```csharp
public static DmnDecisionResult operator +(DmnDecisionResult instance, DmnDecisionSingleResult result)
```

<strong>Operator parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm) <strong>instance</strong></dt><dd>Decision result</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult__12jrmrq) <strong>result</strong></dt><dd>Decision result to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm)</dt><dd>Decision result</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>instance</strong> or <strong>result</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult__12jrmrq" />  DmnDecisionSingleResult Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\DmnDecisionSingleResult.cs</small>


Single decision result



```csharp
public class DmnDecisionSingleResult
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [variables](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#f-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult.variables__qyuu15) | private | Internal list of result variables | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Variables](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult.variables__2ygsfn) | public | List of result variables | 

 


###  Operators and Conversions ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Add(DmnDecisionSingleResult, DmnExecutionVariable)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult.op_addition_net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable___18sze4q) | public static | Add result variable into the decision result | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult.variables__qyuu15" />  DmnDecisionSingleResult.variables Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult__12jrmrq)           
Sources: engine\decisions\DmnDecisionSingleResult.cs</small>


Internal list of result variables



```csharp
private readonly List<net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable> variables
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult.variables__2ygsfn" />  DmnDecisionSingleResult.Variables Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult__12jrmrq)           
Sources: engine\decisions\DmnDecisionSingleResult.cs</small>


List of result variables



```csharp
public IReadOnlyList<net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable> Variables { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult.op_addition_net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable___18sze4q" />  DmnDecisionSingleResult.Add(DmnDecisionSingleResult, DmnExecutionVariable) Operator ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult__12jrmrq)           
Sources: engine\decisions\DmnDecisionSingleResult.cs</small>


Add result variable into the decision result



```csharp
public static DmnDecisionSingleResult operator +(DmnDecisionSingleResult instance, DmnExecutionVariable variable)
```

<strong>Operator parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult__12jrmrq) <strong>instance</strong></dt><dd>Single decision result</dd><dt>[net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc) <strong>variable</strong></dt><dd>Result variable to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult__12jrmrq)</dt><dd>Decision result</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>instance</strong> or <strong>variable</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6" />  IDmnDecision Interface ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\IDmnDecision.cs</small>


Decision interface



```csharp
public interface IDmnDecision
```

Implemented by: [net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj), [net.adamec.lib.common.dmn.engine.engine.decisions.expression.DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9), [net.adamec.lib.common.dmn.engine.engine.decisions.table.DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Name](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.name__oi3x33) | public abstract | Unique name of the decision | 
 | [RequiredDecisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requireddecisions__fxqsi4) | public abstract | List of decisions, the decision depends on | 
 | [RequiredInputs](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requiredinputs__nfywic) | public abstract | Decision required inputs (input variables) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Execute(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.execute_net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext-system.string___omcsfw) | public abstract | Executes the decision. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.name__oi3x33" />  IDmnDecision.Name Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)           
Sources: engine\decisions\IDmnDecision.cs</small>


Unique name of the decision



```csharp
public abstract string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requireddecisions__fxqsi4" />  IDmnDecision.RequiredDecisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)           
Sources: engine\decisions\IDmnDecision.cs</small>


List of decisions, the decision depends on



```csharp
public abstract List<net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> RequiredDecisions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requiredinputs__nfywic" />  IDmnDecision.RequiredInputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)           
Sources: engine\decisions\IDmnDecision.cs</small>


Decision required inputs (input variables)



```csharp
public abstract List<net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> RequiredInputs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.execute_net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext-system.string___omcsfw" />  IDmnDecision.Execute(DmnExecutionContext, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)           
Sources: engine\decisions\IDmnDecision.cs</small>


Executes the decision.



```csharp
public abstract DmnDecisionResult Execute(DmnExecutionContext context, string correlationId = null)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx) <strong>context</strong></dt><dd>DMN Engine execution context</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Optional correlation ID used while logging</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm)</dt><dd>Decision result</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 




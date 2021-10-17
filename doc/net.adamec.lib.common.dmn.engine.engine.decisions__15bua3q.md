#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q" />  net.adamec.lib.common.dmn.engine.engine.decisions Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj) | public abstract | DMN Decision definition | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6) | public abstract | Decision interface | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


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
 | [Logger](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.logger__1xp222x) | protected | Logger | 
 | [Name](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.name__11d67s8) | public | Decision unique name | 
 | [RequiredDecisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.requireddecisions__6uus9z) | public | List of decisions, the decision depends on | 
 | [RequiredInputs](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.requiredinputs__1kiuu49) | public | Decision required inputs (input variables) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecision(string, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.-ctor_system.string-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____1dokm2u) | protected | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Evaluate(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.evaluate_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___4pf6g8) | protected abstract | Evaluates the decision. | 
 | [Execute(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.execute_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___14nzync) | public | Executes the decision. The execution wrapper around [Evaluate(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.evaluate_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___4pf6g8) . | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.logger__1xp222x" />  DmnDecision.Logger Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


Logger



```csharp
protected ILogger Logger { get; }
```

<strong>Property value</strong><dl><dt>net.adamec.lib.common.core.logging.ILogger</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


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


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.requireddecisions__6uus9z" />  DmnDecision.RequiredDecisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


List of decisions, the decision depends on



```csharp
public IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> RequiredDecisions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a></dt><dd></dd></dl>Implements: [IDmnDecision.RequiredDecisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requireddecisions__fxqsi4)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.requiredinputs__1kiuu49" />  DmnDecision.RequiredInputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


Decision required inputs (input variables)



```csharp
public IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> RequiredInputs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a></dt><dd></dd></dl>Implements: [IDmnDecision.RequiredInputs](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requiredinputs__nfywic)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.-ctor_system.string-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____1dokm2u" />  DmnDecision.DmnDecision(string, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


CTOR



```csharp
protected DmnDecision(string name, IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> requiredInputs, IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> requiredDecisions)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Decision unique name</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a> <strong>requiredInputs</strong></dt><dd>Decision required inputs (input variables)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a> <strong>requiredDecisions</strong></dt><dd>List of decisions, the decision depends on</dd></dl>
###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>name</strong> , <strong>requiredInputs</strong> or <strong>requiredDecisions</strong> is null</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd>Name is empty</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.evaluate_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___4pf6g8" />  DmnDecision.Evaluate(DmnExecutionContext, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


Evaluates the decision.



```csharp
protected abstract DmnDecisionResult Evaluate(DmnExecutionContext context, string correlationId = null)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) <strong>context</strong></dt><dd>DMN Engine execution context</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Optional correlation ID used while logging</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)</dt><dd>Decision result</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.execute_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___14nzync" />  DmnDecision.Execute(DmnExecutionContext, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


Executes the decision. The execution wrapper around [Evaluate(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.evaluate_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___4pf6g8) .



```csharp
public DmnDecisionResult Execute(DmnExecutionContext context, string correlationId = null)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) <strong>context</strong></dt><dd>DMN Engine execution context</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Optional correlation ID used while logging</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)</dt><dd>Decision result</dd></dl>Implements: [IDmnDecision.Execute(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.execute_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___1924ukl)


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>context</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


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
 | [Execute(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.execute_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___1924ukl) | public abstract | Executes the decision. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


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


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requireddecisions__fxqsi4" />  IDmnDecision.RequiredDecisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)           
Sources: engine\decisions\IDmnDecision.cs</small>


List of decisions, the decision depends on



```csharp
public abstract IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> RequiredDecisions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requiredinputs__nfywic" />  IDmnDecision.RequiredInputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)           
Sources: engine\decisions\IDmnDecision.cs</small>


Decision required inputs (input variables)



```csharp
public abstract IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> RequiredInputs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.execute_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___1924ukl" />  IDmnDecision.Execute(DmnExecutionContext, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)           
Sources: engine\decisions\IDmnDecision.cs</small>


Executes the decision.



```csharp
public abstract DmnDecisionResult Execute(DmnExecutionContext context, string correlationId = null)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) <strong>context</strong></dt><dd>DMN Engine execution context</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Optional correlation ID used while logging</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)</dt><dd>Decision result</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 




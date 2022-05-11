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
Implements: [net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6), [net.adamec.lib.common.dmn.engine.engine.definition.IDmnElement](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement__1odpnhw), [net.adamec.lib.common.dmn.engine.engine.definition.extensions.IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Extensions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.extensions__1ikhryr) | public | List of extensions that can be used to any related data. Engine doesn&#39;t neither manage nor touches the extensions | 
 | [Label](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.label__q7xq13) | public | Label of the decision | 
 | [Logger](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.logger__1xp222x) | protected | Logger | 
 | [Name](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.name__11d67s8) | public | Decision unique name | 
 | [NameWithLabel](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.namewithlabel__wz2t4e) | public | Name with label information in case [Label](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.label__q7xq13) is different than [Name](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.name__11d67s8) | 
 | [RequiredDecisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.requireddecisions__6uus9z) | public | List of decisions, the decision depends on Only direct dependencies are here, use [GetAllRequiredDecisions()](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.getallrequireddecisions__a864n1) method to get the full list | 
 | [RequiredInputs](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.requiredinputs__1kiuu49) | public | Decision required inputs (input variables) Only direct dependencies are here, use [GetAllRequiredInputs()](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.getallrequiredinputs__1mruz7z) method to get the full list | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecision(string, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.-ctor_system.string-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision_-system.string___1pn7ql6) | protected | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Evaluate(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.evaluate_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___4pf6g8) | protected abstract | Evaluates the decision. | 
 | [Execute(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.execute_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___14nzync) | public | Executes the decision. The execution wrapper around [Evaluate(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.evaluate_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___4pf6g8) . | 
 | [GetAllRequiredDecisions()](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.getallrequireddecisions__a864n1) | public | List of all decisions, the decision depends on Takes also the required decisions from [RequiredDecisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.requireddecisions__6uus9z) in recursion | 
 | [GetAllRequiredInputs()](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.getallrequiredinputs__1mruz7z) | public | Returns all required inputs (input variables) for decision. Takes also the required inputs from [RequiredDecisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.requireddecisions__6uus9z) in recursion | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.tostring__cexmb2) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.extensions__1ikhryr" />  DmnDecision.Extensions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


List of extensions that can be used to any related data. Engine doesn&#39;t neither manage nor touches the extensions



```csharp
public List<object> Extensions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;object&gt;</a></dt><dd></dd></dl>Implements: [IDmnExtendable.Extensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable.extensions__1fyoyrc)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.label__q7xq13" />  DmnDecision.Label Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


Label of the decision



```csharp
public string Label { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Implements: [IDmnElement.Label](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement.label__h6tcbk)


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

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Implements: [IDmnElement.Name](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement.name__1wmto3f)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.namewithlabel__wz2t4e" />  DmnDecision.NameWithLabel Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


Name with label information in case [Label](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.label__q7xq13) is different than [Name](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.name__11d67s8)



```csharp
public string NameWithLabel { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Implements: [IDmnElement.NameWithLabel](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement.namewithlabel__qmuhj7)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.requireddecisions__6uus9z" />  DmnDecision.RequiredDecisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


List of decisions, the decision depends on Only direct dependencies are here, use [GetAllRequiredDecisions()](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.getallrequireddecisions__a864n1) method to get the full list



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


Decision required inputs (input variables) Only direct dependencies are here, use [GetAllRequiredInputs()](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.getallrequiredinputs__1mruz7z) method to get the full list



```csharp
public IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> RequiredInputs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a></dt><dd></dd></dl>Implements: [IDmnDecision.RequiredInputs](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requiredinputs__nfywic)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.-ctor_system.string-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision_-system.string___1pn7ql6" />  DmnDecision.DmnDecision(string, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


CTOR



```csharp
protected DmnDecision(string name, IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> requiredInputs, IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> requiredDecisions, string label = null)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Decision unique name</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a> <strong>requiredInputs</strong></dt><dd>Decision required inputs (input variables)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a> <strong>requiredDecisions</strong></dt><dd>List of decisions, the decision depends on</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Optional decision label. If not set, the name will be used</dd></dl>
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
protected abstract DmnDecisionResult Evaluate(DmnExecutionContext context, string executionId)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) <strong>context</strong></dt><dd>DMN Engine execution context</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>executionId</strong></dt><dd>Identifier of the execution run</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)</dt><dd>Decision result</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.execute_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___14nzync" />  DmnDecision.Execute(DmnExecutionContext, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


Executes the decision. The execution wrapper around [Evaluate(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.evaluate_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___4pf6g8) .



```csharp
public DmnDecisionResult Execute(DmnExecutionContext context, string executionId = null)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) <strong>context</strong></dt><dd>DMN Engine execution context</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>executionId</strong></dt><dd>Identified of the execution run</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)</dt><dd>Decision result</dd></dl>Implements: [IDmnDecision.Execute(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.execute_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___1924ukl)


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>context</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.getallrequireddecisions__a864n1" />  DmnDecision.GetAllRequiredDecisions() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


List of all decisions, the decision depends on Takes also the required decisions from [RequiredDecisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.requireddecisions__6uus9z) in recursion



```csharp
public IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> GetAllRequiredDecisions()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a></dt><dd></dd></dl>Implements: [IDmnDecision.GetAllRequiredDecisions()](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.getallrequireddecisions__ctamqs)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.getallrequiredinputs__1mruz7z" />  DmnDecision.GetAllRequiredInputs() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


Returns all required inputs (input variables) for decision. Takes also the required inputs from [RequiredDecisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.requireddecisions__6uus9z) in recursion



```csharp
public IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> GetAllRequiredInputs()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a></dt><dd></dd></dl>Implements: [IDmnDecision.GetAllRequiredInputs()](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.getallrequiredinputs__8n8xs0)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.tostring__cexmb2" />  DmnDecision.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Sources: engine\decisions\DmnDecision.cs</small>


Returns a string that represents the current object.



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6" />  IDmnDecision Interface ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\IDmnDecision.cs</small>


Decision interface



```csharp
public interface IDmnDecision : IDmnElement
```

Implemented by: [net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj), [net.adamec.lib.common.dmn.engine.engine.decisions.expression.DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9), [net.adamec.lib.common.dmn.engine.engine.decisions.table.DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Implements: [net.adamec.lib.common.dmn.engine.engine.definition.IDmnElement](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement__1odpnhw), [net.adamec.lib.common.dmn.engine.engine.definition.extensions.IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RequiredDecisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requireddecisions__fxqsi4) | public abstract | List of decisions, the decision depends on Only direct dependencies are here, use [GetAllRequiredDecisions()](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.getallrequireddecisions__ctamqs) method to get the full list | 
 | [RequiredInputs](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requiredinputs__nfywic) | public abstract | Decision required inputs (input variables) Only direct dependencies are here, use [GetAllRequiredInputs()](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.getallrequiredinputs__8n8xs0) method to get the full list | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Execute(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.execute_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___1924ukl) | public abstract | Executes the decision. | 
 | [GetAllRequiredDecisions()](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.getallrequireddecisions__ctamqs) | public abstract | List of all decisions, the decision depends on Takes also the required decisions from [RequiredDecisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requireddecisions__fxqsi4) in recursion | 
 | [GetAllRequiredInputs()](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.getallrequiredinputs__8n8xs0) | public abstract | Returns all required inputs (input variables) for decision. Takes also the required inputs from [RequiredDecisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requireddecisions__fxqsi4) in recursion | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requireddecisions__fxqsi4" />  IDmnDecision.RequiredDecisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)           
Sources: engine\decisions\IDmnDecision.cs</small>


List of decisions, the decision depends on Only direct dependencies are here, use [GetAllRequiredDecisions()](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.getallrequireddecisions__ctamqs) method to get the full list



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


Decision required inputs (input variables) Only direct dependencies are here, use [GetAllRequiredInputs()](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.getallrequiredinputs__8n8xs0) method to get the full list



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
public abstract DmnDecisionResult Execute(DmnExecutionContext context, string executionId)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) <strong>context</strong></dt><dd>DMN Engine execution context</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>executionId</strong></dt><dd>Identifier of the execution run</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)</dt><dd>Decision result</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.getallrequireddecisions__ctamqs" />  IDmnDecision.GetAllRequiredDecisions() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)           
Sources: engine\decisions\IDmnDecision.cs</small>


List of all decisions, the decision depends on Takes also the required decisions from [RequiredDecisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requireddecisions__fxqsi4) in recursion



```csharp
public abstract IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> GetAllRequiredDecisions()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.getallrequiredinputs__8n8xs0" />  IDmnDecision.GetAllRequiredInputs() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)           
Sources: engine\decisions\IDmnDecision.cs</small>


Returns all required inputs (input variables) for decision. Takes also the required inputs from [RequiredDecisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision.requireddecisions__fxqsi4) in recursion



```csharp
public abstract IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> GetAllRequiredInputs()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 




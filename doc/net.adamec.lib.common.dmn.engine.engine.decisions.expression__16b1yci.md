#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci" />  net.adamec.lib.common.dmn.engine.engine.decisions.expression Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9) | public | Expression decision definition | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9" />  DmnExpressionDecision Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.expression](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\expression\DmnExpressionDecision.cs</small>


Expression decision definition



```csharp
public class DmnExpressionDecision : DmnDecision
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Implements: [net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6), [net.adamec.lib.common.dmn.engine.engine.definition.IDmnElement](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement__1odpnhw), [net.adamec.lib.common.dmn.engine.engine.definition.extensions.IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Expression](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision.expression__1s712kp) | public | Decision expression | 
 | [Output](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision.output__pl5v14) | public | Decision output variable | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExpressionDecision(string, string, IDmnVariable, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;, string)](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision.-ctor_system.string-system.string-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision_-system.string___7hr64q) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Evaluate(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision.evaluate_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___1wzqei8) | protected | Evaluates the decision. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision.expression__1s712kp" />  DmnExpressionDecision.Expression Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.expression](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9)           
Sources: engine\decisions\expression\DmnExpressionDecision.cs</small>


Decision expression



```csharp
public string Expression { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision.output__pl5v14" />  DmnExpressionDecision.Output Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.expression](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9)           
Sources: engine\decisions\expression\DmnExpressionDecision.cs</small>


Decision output variable



```csharp
public IDmnVariable Output { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision.-ctor_system.string-system.string-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision_-system.string___7hr64q" />  DmnExpressionDecision.DmnExpressionDecision(string, string, IDmnVariable, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.expression](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9)           
Sources: engine\decisions\expression\DmnExpressionDecision.cs</small>


CTOR



```csharp
public DmnExpressionDecision(string name, string expression, IDmnVariable output, IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> requiredInputs, IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> requiredDecisions, string label = null)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Unique name of the decision</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Decision expression</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w) <strong>output</strong></dt><dd>Decision output variable</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a> <strong>requiredInputs</strong></dt><dd>Decision required inputs (input variables)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a> <strong>requiredDecisions</strong></dt><dd>List of decisions, the decision depends on</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Optional label of decision, name is used when not provided</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision.evaluate_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___1wzqei8" />  DmnExpressionDecision.Evaluate(DmnExecutionContext, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.expression](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9)           
Sources: engine\decisions\expression\DmnExpressionDecision.cs</small>


Evaluates the decision.



```csharp
protected override DmnDecisionResult Evaluate(DmnExecutionContext context, string executionId)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) <strong>context</strong></dt><dd>DMN Engine execution context</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>executionId</strong></dt><dd>Identifier of the execution run</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)</dt><dd>Decision result</dd></dl>Overrides: [DmnDecision.Evaluate(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.evaluate_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___4pf6g8)


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>context</strong> is nul</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 




#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci" />  net.adamec.lib.common.dmn.engine.engine.decisions.expression Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9) | public | Expression decision definition | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9" />  DmnExpressionDecision Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.expression](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\expression\DmnExpressionDecision.cs</small>


Expression decision definition



```csharp
public class DmnExpressionDecision : DmnDecision
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Implements: [net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Expression](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision.expression__1s712kp) | public | Decision expression | 
 | [Output](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision.output__pl5v14) | public | Decision output definition | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExpressionDecision(string, string, DmnVariableDefinition, List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;, List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;)](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision.-ctor_system.string-system.string-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition_-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____1d6ubok) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Evaluate(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision.evaluate_net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext-system.string___3j62yx) | protected | Evaluates the decision. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


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


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision.output__pl5v14" />  DmnExpressionDecision.Output Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.expression](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9)           
Sources: engine\decisions\expression\DmnExpressionDecision.cs</small>


Decision output definition



```csharp
public DmnVariableDefinition Output { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision.-ctor_system.string-system.string-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition_-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____1d6ubok" />  DmnExpressionDecision.DmnExpressionDecision(string, string, DmnVariableDefinition, List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;, List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.expression](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9)           
Sources: engine\decisions\expression\DmnExpressionDecision.cs</small>


CTOR



```csharp
public DmnExpressionDecision(string name, string expression, DmnVariableDefinition output, List<net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> requiredInputs, List<net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> requiredDecisions)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Unique name of the decision</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Decision expression</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88) <strong>output</strong></dt><dd>Decision output definition</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a> <strong>requiredInputs</strong></dt><dd>Decision required inputs (input variables)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a> <strong>requiredDecisions</strong></dt><dd>List of decisions, the decision depends on</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision.evaluate_net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext-system.string___3j62yx" />  DmnExpressionDecision.Evaluate(DmnExecutionContext, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.expression](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9)           
Sources: engine\decisions\expression\DmnExpressionDecision.cs</small>


Evaluates the decision.



```csharp
protected override DmnDecisionResult Evaluate(DmnExecutionContext context, string correlationId = null)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx) <strong>context</strong></dt><dd>DMN Engine execution context</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Optional correlation ID used while logging</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm)</dt><dd>Decision result</dd></dl>Overrides: [DmnDecision.Evaluate(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.evaluate_net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext-system.string___svwyjn)


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>context</strong> is nul</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 




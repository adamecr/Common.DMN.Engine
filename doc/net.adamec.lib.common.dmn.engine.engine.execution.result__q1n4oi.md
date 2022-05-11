#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi" />  net.adamec.lib.common.dmn.engine.engine.execution.result Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka) | public | Decision evaluation result (single or multiple) | 
 | [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u) | public | Single decision result | 
 | [DmnResultVariable](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg) | public | Execution result variable | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka" />  DmnDecisionResult Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\execution\result\DmnDecisionResult.cs</small>


Decision evaluation result (single or multiple)



```csharp
public class DmnDecisionResult
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ResultsInternal](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#f-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.resultsinternal__v901ox) | protected | Internal list of results. The first item represents the [FirstResultVariables](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.firstresultvariables__1s6kyp0) | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [First](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.first__nu3rp6) | public | Decision evaluation single (first) result. When there is no result, null is returned. | 
 | [FirstResultVariables](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.firstresultvariables__1s6kyp0) | public | Decision evaluation single (first) result variables. When there is no result, the empty list of [variables](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg) is returned. | 
 | [HasResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.hasresult__h948fd) | public | Flag whether there is any result available | 
 | [IsSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.issingleresult__1ycasez) | public | Flag whether the decision  has single result | 
 | [Results](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.results__1c3jrwm) | public | List of decision evaluation results. | 
 | [SingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.singleresult__ghkfy1) | public | This method is obsolete, use [FirstResultVariables](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.firstresultvariables__1s6kyp0) instead. Decision evaluation single (first) result variables. When there is no result, the empty list of [variables](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg) is returned. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecisionResult()](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.-ctor__1lmwiny) | public |  | 
 | [DmnDecisionResult(DmnDecisionSingleResult)](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.-ctor_net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult___14l4b9f) | public |  | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Clone()](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.clone__1eb4d4w) | public | Clones the decision result | 

 


###  Operators and Conversions ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Add(DmnDecisionResult, DmnDecisionSingleResult)](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.op_addition_net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult___1ygczpo) | public static | Adds a single (one) result into the list of results | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.resultsinternal__v901ox" />  DmnDecisionResult.ResultsInternal Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)           
Sources: engine\execution\result\DmnDecisionResult.cs</small>


Internal list of results. The first item represents the [FirstResultVariables](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.firstresultvariables__1s6kyp0)



```csharp
protected readonly List<net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionSingleResult> ResultsInternal
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionSingleResult&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.first__nu3rp6" />  DmnDecisionResult.First Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)           
Sources: engine\execution\result\DmnDecisionResult.cs</small>


Decision evaluation single (first) result. When there is no result, null is returned.



```csharp
public DmnDecisionSingleResult First { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.firstresultvariables__1s6kyp0" />  DmnDecisionResult.FirstResultVariables Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)           
Sources: engine\execution\result\DmnDecisionResult.cs</small>


Decision evaluation single (first) result variables. When there is no result, the empty list of [variables](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg) is returned.



```csharp
public IReadOnlyList<net.adamec.lib.common.dmn.engine.engine.execution.result.DmnResultVariable> FirstResultVariables { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.lib.common.dmn.engine.engine.execution.result.DmnResultVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.hasresult__h948fd" />  DmnDecisionResult.HasResult Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)           
Sources: engine\execution\result\DmnDecisionResult.cs</small>


Flag whether there is any result available



```csharp
public bool HasResult { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.issingleresult__1ycasez" />  DmnDecisionResult.IsSingleResult Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)           
Sources: engine\execution\result\DmnDecisionResult.cs</small>


Flag whether the decision  has single result



```csharp
public bool IsSingleResult { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.results__1c3jrwm" />  DmnDecisionResult.Results Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)           
Sources: engine\execution\result\DmnDecisionResult.cs</small>


List of decision evaluation results.



```csharp
public IReadOnlyList<net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionSingleResult> Results { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionSingleResult&gt;</a></dt><dd></dd></dl>


###  Remarks ###
The first item represents the [FirstResultVariables](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.firstresultvariables__1s6kyp0) , however it&#39;s recommended to use the [FirstResultVariables](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.firstresultvariables__1s6kyp0) when expecting the single result.


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.singleresult__ghkfy1" />  DmnDecisionResult.SingleResult Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)           
Sources: engine\execution\result\DmnDecisionResult.cs</small>


This method is obsolete, use [FirstResultVariables](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.firstresultvariables__1s6kyp0) instead. Decision evaluation single (first) result variables. When there is no result, the empty list of [variables](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg) is returned.



```csharp
[Obsolete("This method is obsolete, use FirstResultVariables instead")]
[ExcludeFromCodeCoverage]
public IReadOnlyList<net.adamec.lib.common.dmn.engine.engine.execution.result.DmnResultVariable> SingleResult { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.lib.common.dmn.engine.engine.execution.result.DmnResultVariable&gt;</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.obsoleteattribute" target="_blank" >System.ObsoleteAttribute</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.-ctor__1lmwiny" />  DmnDecisionResult.DmnDecisionResult() Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)           
Sources: engine\execution\result\DmnDecisionResult.cs</small>



```csharp
public DmnDecisionResult()
```

Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.-ctor_net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult___14l4b9f" />  DmnDecisionResult.DmnDecisionResult(DmnDecisionSingleResult) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)           
Sources: engine\execution\result\DmnDecisionResult.cs</small>



```csharp
public DmnDecisionResult(DmnDecisionSingleResult result)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u) <strong>result</strong></dt><dd></dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.clone__1eb4d4w" />  DmnDecisionResult.Clone() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)           
Sources: engine\execution\result\DmnDecisionResult.cs</small>


Clones the decision result



```csharp
public DmnDecisionResult Clone()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)</dt><dd>Cloned decision result</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult.op_addition_net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult___1ygczpo" />  DmnDecisionResult.Add(DmnDecisionResult, DmnDecisionSingleResult) Operator ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)           
Sources: engine\execution\result\DmnDecisionResult.cs</small>


Adds a single (one) result into the list of results



```csharp
public static DmnDecisionResult operator +(DmnDecisionResult instance, DmnDecisionSingleResult result)
```

<strong>Operator parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka) <strong>instance</strong></dt><dd>Decision result</dd><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u) <strong>result</strong></dt><dd>Decision result to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)</dt><dd>Decision result</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>instance</strong> or <strong>result</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u" />  DmnDecisionSingleResult Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\execution\result\DmnDecisionSingleResult.cs</small>


Single decision result



```csharp
public class DmnDecisionSingleResult
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [HitRulesInternal](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#f-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.hitrulesinternal__bcesx9) | protected | Internal list of table rules with the positive hit (based on hit policy) leading to this decision result. Empty for expression decisions | 
 | [VariablesInternal](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#f-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.variablesinternal__e64bdq) | protected | Internal list of result variables | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [HitRules](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.hitrules__ytekk8) | public | List of table rules with the positive hit (based on hit policy) leading to this decision result. Empty for expression decisions | 
 | [Variables](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.variables__1c767qh) | public | List of result variables | 

 


###  Indexers ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [this[string]](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.item_system.string___1fefeca) | public | Gets the variable by <strong>variableName</strong> | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecisionSingleResult()](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.-ctor__ik18tu) | public | CTOR | 
 | [DmnDecisionSingleResult(DmnDecisionTableRule)](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.-ctor_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule___1rtbv7b) | public | CTOR | 
 | [DmnDecisionSingleResult(DmnExecutionVariable)](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.-ctor_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable___1lkrko6) | public | CTOR | 
 | [DmnDecisionSingleResult(DmnExecutionVariable, DmnDecisionTableRule)](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.-ctor_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule___ht2y8e) | public | CTOR | 
 | [DmnDecisionSingleResult(DmnExecutionVariable, IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;)](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.-ctor_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable-system.collections.generic.ienumerable_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule____io7noa) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Clone()](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.clone__24bfo) | public | Clones the single result | 

 


###  Operators and Conversions ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Add(DmnDecisionSingleResult, DmnExecutionVariable)](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.op_addition_net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable___ijtftt) | public static | Add result variable into the decision result | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.hitrulesinternal__bcesx9" />  DmnDecisionSingleResult.HitRulesInternal Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u)           
Sources: engine\execution\result\DmnDecisionSingleResult.cs</small>


Internal list of table rules with the positive hit (based on hit policy) leading to this decision result. Empty for expression decisions



```csharp
protected readonly List<net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule> HitRulesInternal
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.variablesinternal__e64bdq" />  DmnDecisionSingleResult.VariablesInternal Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u)           
Sources: engine\execution\result\DmnDecisionSingleResult.cs</small>


Internal list of result variables



```csharp
protected readonly List<net.adamec.lib.common.dmn.engine.engine.execution.result.DmnResultVariable> VariablesInternal
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.execution.result.DmnResultVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.hitrules__ytekk8" />  DmnDecisionSingleResult.HitRules Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u)           
Sources: engine\execution\result\DmnDecisionSingleResult.cs</small>


List of table rules with the positive hit (based on hit policy) leading to this decision result. Empty for expression decisions



```csharp
public IReadOnlyList<net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule> HitRules { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.item_system.string___1fefeca" />  DmnDecisionSingleResult.this[string] Indexer ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u)           
Sources: engine\execution\result\DmnDecisionSingleResult.cs</small>


Gets the variable by <strong>variableName</strong>



```csharp
public DmnResultVariable this[string variableName] { get; }
```

<strong>Indexer parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <em>variableName</em></dt><dd>Name of the variable to retrieve</dd></dl>
<strong>Indexer value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnResultVariable](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg)</dt><dd></dd></dl>Returns: Variable with given <strong>variableName</strong> or null when not found           



Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.variables__1c767qh" />  DmnDecisionSingleResult.Variables Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u)           
Sources: engine\execution\result\DmnDecisionSingleResult.cs</small>


List of result variables



```csharp
public IReadOnlyList<net.adamec.lib.common.dmn.engine.engine.execution.result.DmnResultVariable> Variables { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.lib.common.dmn.engine.engine.execution.result.DmnResultVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.-ctor__ik18tu" />  DmnDecisionSingleResult.DmnDecisionSingleResult() Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u)           
Sources: engine\execution\result\DmnDecisionSingleResult.cs</small>


CTOR



```csharp
public DmnDecisionSingleResult()
```

Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.-ctor_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule___1rtbv7b" />  DmnDecisionSingleResult.DmnDecisionSingleResult(DmnDecisionTableRule) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u)           
Sources: engine\execution\result\DmnDecisionSingleResult.cs</small>


CTOR



```csharp
public DmnDecisionSingleResult(DmnDecisionTableRule hitRule)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko) <strong>hitRule</strong></dt><dd>The decision table rule with positive hit to be added to the decision result</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.-ctor_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable___1lkrko6" />  DmnDecisionSingleResult.DmnDecisionSingleResult(DmnExecutionVariable) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u)           
Sources: engine\execution\result\DmnDecisionSingleResult.cs</small>


CTOR



```csharp
public DmnDecisionSingleResult(DmnExecutionVariable variable)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn) <strong>variable</strong></dt><dd>The execution variable to be added to the decision result</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.-ctor_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule___ht2y8e" />  DmnDecisionSingleResult.DmnDecisionSingleResult(DmnExecutionVariable, DmnDecisionTableRule) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u)           
Sources: engine\execution\result\DmnDecisionSingleResult.cs</small>


CTOR



```csharp
public DmnDecisionSingleResult(DmnExecutionVariable variable, DmnDecisionTableRule hitRule)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn) <strong>variable</strong></dt><dd>The execution variable to be added to the decision result</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko) <strong>hitRule</strong></dt><dd>The decision table rule with positive hit to be added to the decision result</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.-ctor_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable-system.collections.generic.ienumerable_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule____io7noa" />  DmnDecisionSingleResult.DmnDecisionSingleResult(DmnExecutionVariable, IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u)           
Sources: engine\execution\result\DmnDecisionSingleResult.cs</small>


CTOR



```csharp
public DmnDecisionSingleResult(DmnExecutionVariable variable, IEnumerable<net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule> multipleHitRules)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn) <strong>variable</strong></dt><dd>The execution variable to be added to the decision result</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;</a> <strong>multipleHitRules</strong></dt><dd>The decision table rules with positive hit to be added to the decision result</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.clone__24bfo" />  DmnDecisionSingleResult.Clone() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u)           
Sources: engine\execution\result\DmnDecisionSingleResult.cs</small>


Clones the single result



```csharp
public virtual DmnDecisionSingleResult Clone()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u)</dt><dd>Cloned single result</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult.op_addition_net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable___ijtftt" />  DmnDecisionSingleResult.Add(DmnDecisionSingleResult, DmnExecutionVariable) Operator ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u)           
Sources: engine\execution\result\DmnDecisionSingleResult.cs</small>


Add result variable into the decision result



```csharp
public static DmnDecisionSingleResult operator +(DmnDecisionSingleResult instance, DmnExecutionVariable variable)
```

<strong>Operator parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u) <strong>instance</strong></dt><dd>Single decision result</dd><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn) <strong>variable</strong></dt><dd>Execution variable to add as a result variable</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionsingleresult__ly679u)</dt><dd>Decision result</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>instance</strong> or <strong>variable</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg" />  DmnResultVariable Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\execution\result\DmnResultVariable.cs</small>


Execution result variable



```csharp
public class DmnResultVariable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IsInputParameter](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.isinputparameter__ng5v81) | public | Flag whether the variable is input parameter | 
 | [Label](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.label__741128) | public | Label of the variable (used for input parameters) | 
 | [Name](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.name__1lrrp4r) | public | Unique variable name | 
 | [NameWithLabel](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.namewithlabel__1u9fku3) | public | Name with label information in case [Label](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.label__741128) is different than [Name](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.name__1lrrp4r) | 
 | [Type](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.type__tv6yj2) | public | Variable type or null if not defined | 
 | [Value](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.value__88aq3z) | public | Variable value | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnResultVariable(DmnExecutionVariable)](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.-ctor_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable___uje7fc) | public | CTOR | 
 | [DmnResultVariable(DmnResultVariable)](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.-ctor_net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable___t5n6bl) | private | CTOR used by [Clone()](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.clone__gj3nmq) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Clone()](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.clone__gj3nmq) | public | Clones the variable | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.tostring__1n14d07) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.isinputparameter__ng5v81" />  DmnResultVariable.IsInputParameter Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnResultVariable](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg)           
Sources: engine\execution\result\DmnResultVariable.cs</small>


Flag whether the variable is input parameter



```csharp
public bool IsInputParameter { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.label__741128" />  DmnResultVariable.Label Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnResultVariable](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg)           
Sources: engine\execution\result\DmnResultVariable.cs</small>


Label of the variable (used for input parameters)



```csharp
public string Label { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.name__1lrrp4r" />  DmnResultVariable.Name Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnResultVariable](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg)           
Sources: engine\execution\result\DmnResultVariable.cs</small>


Unique variable name



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.namewithlabel__1u9fku3" />  DmnResultVariable.NameWithLabel Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnResultVariable](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg)           
Sources: engine\execution\result\DmnResultVariable.cs</small>


Name with label information in case [Label](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.label__741128) is different than [Name](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.name__1lrrp4r)



```csharp
public string NameWithLabel { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.type__tv6yj2" />  DmnResultVariable.Type Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnResultVariable](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg)           
Sources: engine\execution\result\DmnResultVariable.cs</small>


Variable type or null if not defined



```csharp
public Type Type { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.value__88aq3z" />  DmnResultVariable.Value Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnResultVariable](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg)           
Sources: engine\execution\result\DmnResultVariable.cs</small>


Variable value



```csharp
public object Value { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.-ctor_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable___uje7fc" />  DmnResultVariable.DmnResultVariable(DmnExecutionVariable) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnResultVariable](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg)           
Sources: engine\execution\result\DmnResultVariable.cs</small>


CTOR



```csharp
public DmnResultVariable(DmnExecutionVariable executionVariable)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn) <strong>executionVariable</strong></dt><dd>Execution variable to build the result variable from</dd></dl>
###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>executionVariable</strong> is null</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd>Missing variable name in <strong>executionVariable</strong></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.-ctor_net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable___t5n6bl" />  DmnResultVariable.DmnResultVariable(DmnResultVariable) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnResultVariable](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg)           
Sources: engine\execution\result\DmnResultVariable.cs</small>


CTOR used by [Clone()](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.clone__gj3nmq)



```csharp
private DmnResultVariable(DmnResultVariable cloneFrom)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnResultVariable](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg) <strong>cloneFrom</strong></dt><dd>Variable to be cloned</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.clone__gj3nmq" />  DmnResultVariable.Clone() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnResultVariable](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg)           
Sources: engine\execution\result\DmnResultVariable.cs</small>


Clones the variable



```csharp
public virtual DmnResultVariable Clone()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnResultVariable](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg)</dt><dd>Cloned variable</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable.tostring__1n14d07" />  DmnResultVariable.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution.result](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#n-net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnResultVariable](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmnresultvariable__11d1drg)           
Sources: engine\execution\result\DmnResultVariable.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 




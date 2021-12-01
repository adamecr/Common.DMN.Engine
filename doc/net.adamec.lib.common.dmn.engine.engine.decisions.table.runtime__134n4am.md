#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am" />  net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9) | public | Decision table rules execution results | 
 | [DmnDecisionTableRuleExecutionResultsParallel](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresultsparallel__6x96jo) | public | Decision table rules execution results | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9" />  DmnDecisionTableRuleExecutionResults Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\table\runtime\DmnDecisionTableRuleExecutionResults.cs</small>


Decision table rules execution results



```csharp
public class DmnDecisionTableRuleExecutionResults
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.DmnDecisionTableRuleExecutionResultsParallel](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresultsparallel__6x96jo)           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Results](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#f-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.results__8r99ef) | protected | Internal dictionary of results per rule and output | 
 | [RuleResultHashCodes](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#f-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.ruleresulthashcodes__livmls) | protected | Internal dictionary of rule result hashcodes (hashcode per rule) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetResult(DmnDecisionTableRule, DmnDecisionTableRuleOutput)](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.getresult_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput___1szwn17) | public | Gets the result for given pair <strong>rule</strong> - <strong>output</strong> | 
 | [GetResultsHashCode(DmnDecisionTableRule)](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.getresultshashcode_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule___72g8de) | public | Gets the hashcode of <strong>rule</strong> results | 
 | [SetResult(DmnDecisionTableRule, DmnDecisionTableRuleOutput, DmnExecutionVariable)](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.setresult_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable___1jkdwi8) | public | Sets the <strong>result</strong> of the single <strong>output</strong> of the <strong>rule</strong> . | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.results__8r99ef" />  DmnDecisionTableRuleExecutionResults.Results Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9)           
Sources: engine\decisions\table\runtime\DmnDecisionTableRuleExecutionResults.cs</small>


Internal dictionary of results per rule and output



```csharp
protected readonly Dictionary<(net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule Item1, net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRuleOutput Item2),net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable> Results
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;(net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule Item1, net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRuleOutput Item2),net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.ruleresulthashcodes__livmls" />  DmnDecisionTableRuleExecutionResults.RuleResultHashCodes Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9)           
Sources: engine\decisions\table\runtime\DmnDecisionTableRuleExecutionResults.cs</small>


Internal dictionary of rule result hashcodes (hashcode per rule)



```csharp
protected readonly Dictionary<net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule,int> RuleResultHashCodes
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule,int&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.getresult_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput___1szwn17" />  DmnDecisionTableRuleExecutionResults.GetResult(DmnDecisionTableRule, DmnDecisionTableRuleOutput) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9)           
Sources: engine\decisions\table\runtime\DmnDecisionTableRuleExecutionResults.cs</small>


Gets the result for given pair <strong>rule</strong> - <strong>output</strong>



```csharp
public DmnExecutionVariable GetResult(DmnDecisionTableRule rule, DmnDecisionTableRuleOutput output)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko) <strong>rule</strong></dt><dd>Rule to get the result for</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRuleOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput__1gob6sb) <strong>output</strong></dt><dd>Output to get the result for</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn)</dt><dd>Result for given pair <strong>rule</strong> - <strong>output</strong> or null when the result is not found or <strong>output</strong> is null</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>rule</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.getresultshashcode_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule___72g8de" />  DmnDecisionTableRuleExecutionResults.GetResultsHashCode(DmnDecisionTableRule) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9)           
Sources: engine\decisions\table\runtime\DmnDecisionTableRuleExecutionResults.cs</small>


Gets the hashcode of <strong>rule</strong> results



```csharp
public int GetResultsHashCode(DmnDecisionTableRule rule)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko) <strong>rule</strong></dt><dd>Rule to get the hashcode for</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd>Hashcode of rule results or zero when there are not results for given <strong>rule</strong></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>rule</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.setresult_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable___1jkdwi8" />  DmnDecisionTableRuleExecutionResults.SetResult(DmnDecisionTableRule, DmnDecisionTableRuleOutput, DmnExecutionVariable) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9)           
Sources: engine\decisions\table\runtime\DmnDecisionTableRuleExecutionResults.cs</small>


Sets the <strong>result</strong> of the single <strong>output</strong> of the <strong>rule</strong> .



```csharp
public virtual void SetResult(DmnDecisionTableRule rule, DmnDecisionTableRuleOutput output, DmnExecutionVariable result)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko) <strong>rule</strong></dt><dd>Rule to set the <strong>result</strong> for.</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRuleOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput__1gob6sb) <strong>output</strong></dt><dd>Output to set the <strong>result</strong> for.</dd><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn) <strong>result</strong></dt><dd>Result to set</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Remarks ###
When a result is set (updated), the hashcode of whole rule results is recalculated.


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>rule</strong> or <strong>output</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresultsparallel__6x96jo" />  DmnDecisionTableRuleExecutionResultsParallel Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\table\runtime\DmnDecisionTableRuleExecutionResultsParallel.cs</small>


Decision table rules execution results



```csharp
public class DmnDecisionTableRuleExecutionResultsParallel : DmnDecisionTableRuleExecutionResults
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9)           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [concurrentResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#f-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresultsparallel.concurrentresults__iozw67) | private | Internal dictionary of results per rule and output | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [FinalizeConcurrentResults()](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresultsparallel.finalizeconcurrentresults__1eaxsb4) | public |  | 
 | [SetResult(DmnDecisionTableRule, DmnDecisionTableRuleOutput, DmnExecutionVariable)](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresultsparallel.setresult_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable___c4a07p) | public | Sets the <strong>result</strong> of the single <strong>output</strong> of the <strong>rule</strong> . | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresultsparallel.concurrentresults__iozw67" />  DmnDecisionTableRuleExecutionResultsParallel.concurrentResults Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleExecutionResultsParallel](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresultsparallel__6x96jo)           
Sources: engine\decisions\table\runtime\DmnDecisionTableRuleExecutionResultsParallel.cs</small>


Internal dictionary of results per rule and output



```csharp
private readonly ConcurrentDictionary<(net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule Item1, net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRuleOutput Item2),net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable> concurrentResults
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentdictionary-2" target="_blank" >System.Collections.Concurrent.ConcurrentDictionary&lt;(net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule Item1, net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRuleOutput Item2),net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresultsparallel.finalizeconcurrentresults__1eaxsb4" />  DmnDecisionTableRuleExecutionResultsParallel.FinalizeConcurrentResults() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleExecutionResultsParallel](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresultsparallel__6x96jo)           
Sources: engine\decisions\table\runtime\DmnDecisionTableRuleExecutionResultsParallel.cs</small>



```csharp
public DmnDecisionTableRuleExecutionResults FinalizeConcurrentResults()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresultsparallel.setresult_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable___c4a07p" />  DmnDecisionTableRuleExecutionResultsParallel.SetResult(DmnDecisionTableRule, DmnDecisionTableRuleOutput, DmnExecutionVariable) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleExecutionResultsParallel](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresultsparallel__6x96jo)           
Sources: engine\decisions\table\runtime\DmnDecisionTableRuleExecutionResultsParallel.cs</small>


Sets the <strong>result</strong> of the single <strong>output</strong> of the <strong>rule</strong> .



```csharp
public override void SetResult(DmnDecisionTableRule rule, DmnDecisionTableRuleOutput output, DmnExecutionVariable result)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko) <strong>rule</strong></dt><dd>Rule to set the <strong>result</strong> for.</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRuleOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput__1gob6sb) <strong>output</strong></dt><dd>Output to set the <strong>result</strong> for.</dd><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable__1bfwjcn) <strong>result</strong></dt><dd>Result to set</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Overrides: [DmnDecisionTableRuleExecutionResults.SetResult(DmnDecisionTableRule, DmnDecisionTableRuleOutput, DmnExecutionVariable)](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.setresult_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutionvariable___1jkdwi8)


###  Remarks ###
When a result is set (updated), the hashcode of whole rule results is recalculated.


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>rule</strong> or <strong>output</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 




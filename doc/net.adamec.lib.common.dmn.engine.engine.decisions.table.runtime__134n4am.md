#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am" />  net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9) | public | Decision table rules execution results | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9" />  DmnDecisionTableRuleExecutionResults Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\table\runtime\DmnDecisionTableExecutionResults.cs</small>


Decision table rules execution results



```csharp
public class DmnDecisionTableRuleExecutionResults
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [results](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#f-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.results__1nhoos7) | private | Internal dictionary of results per rule and output | 
 | [ruleResultHashCodes](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#f-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.ruleresulthashcodes__16bh4i8) | private | Internal dictionary of rule result hashcodes (hashcode per rule) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetResult(DmnDecisionTableRule, DmnDecisionTableRuleOutput)](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.getresult_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput___1szwn17) | public | Gets the result for given pair <strong>rule</strong> - <strong>output</strong> | 
 | [GetResultsHashCode(DmnDecisionTableRule)](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.getresultshashcode_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule___72g8de) | public | Gets the hashcode of <strong>rule</strong> results | 
 | [SetResult(DmnDecisionTableRule, DmnDecisionTableRuleOutput, DmnExecutionVariable)](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.setresult_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable___1ticw3h) | public | Sets the <strong>result</strong> of the single <strong>output</strong> of the <strong>rule</strong> . | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.results__1nhoos7" />  DmnDecisionTableRuleExecutionResults.results Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9)           
Sources: engine\decisions\table\runtime\DmnDecisionTableExecutionResults.cs</small>


Internal dictionary of results per rule and output



```csharp
private readonly Dictionary<(net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule Item1, net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRuleOutput Item2),net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable> results
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;(net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule Item1, net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRuleOutput Item2),net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.ruleresulthashcodes__16bh4i8" />  DmnDecisionTableRuleExecutionResults.ruleResultHashCodes Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9)           
Sources: engine\decisions\table\runtime\DmnDecisionTableExecutionResults.cs</small>


Internal dictionary of rule result hashcodes (hashcode per rule)



```csharp
private readonly Dictionary<net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule,int> ruleResultHashCodes
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule,int&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.getresult_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput___1szwn17" />  DmnDecisionTableRuleExecutionResults.GetResult(DmnDecisionTableRule, DmnDecisionTableRuleOutput) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9)           
Sources: engine\decisions\table\runtime\DmnDecisionTableExecutionResults.cs</small>


Gets the result for given pair <strong>rule</strong> - <strong>output</strong>



```csharp
public DmnExecutionVariable GetResult(DmnDecisionTableRule rule, DmnDecisionTableRuleOutput output)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko) <strong>rule</strong></dt><dd>Rule to get the result for</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRuleOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput__1gob6sb) <strong>output</strong></dt><dd>Output to get the result for</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc)</dt><dd>Result for given pair <strong>rule</strong> - <strong>output</strong> or null when the result is not found</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>rule</strong> or <strong>output</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.getresultshashcode_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule___72g8de" />  DmnDecisionTableRuleExecutionResults.GetResultsHashCode(DmnDecisionTableRule) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9)           
Sources: engine\decisions\table\runtime\DmnDecisionTableExecutionResults.cs</small>


Gets the hashcode of <strong>rule</strong> results



```csharp
public int GetResultsHashCode(DmnDecisionTableRule rule)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko) <strong>rule</strong></dt><dd>Rule to get the hashcode for</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd>Hashcode of rule results or zero when there are not results for given <strong>rule</strong></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>rule</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults.setresult_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable___1ticw3h" />  DmnDecisionTableRuleExecutionResults.SetResult(DmnDecisionTableRule, DmnDecisionTableRuleOutput, DmnExecutionVariable) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9)           
Sources: engine\decisions\table\runtime\DmnDecisionTableExecutionResults.cs</small>


Sets the <strong>result</strong> of the single <strong>output</strong> of the <strong>rule</strong> .



```csharp
public void SetResult(DmnDecisionTableRule rule, DmnDecisionTableRuleOutput output, DmnExecutionVariable result)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko) <strong>rule</strong></dt><dd>Rule to set the <strong>result</strong> for.</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRuleOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput__1gob6sb) <strong>output</strong></dt><dd>Output to set the <strong>result</strong> for.</dd><dt>[net.adamec.lib.common.dmn.engine.engine.runtime.DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc) <strong>result</strong></dt><dd>Result to set</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Remarks ###
When a result is set (updated), the hashcode of whole rule results is recalculated.


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>rule</strong> or <strong>output</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 




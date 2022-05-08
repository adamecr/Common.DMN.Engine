#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k" />  net.adamec.lib.common.dmn.engine.engine.decisions.table Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh) | public | DMN Decision Table definition | 
 | [DmnDecisionTable.PositiveRulesCollectValues](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues__z17b4n) | private | Container of aggregate values for positive rules when [Collect](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.collect__t0bm9p) hit policy is used. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh" />  DmnDecisionTable Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


DMN Decision Table definition



```csharp
public class DmnDecisionTable : DmnDecision
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj)           
Implements: [net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6), [net.adamec.lib.common.dmn.engine.engine.definition.IDmnElement](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement__1odpnhw), [net.adamec.lib.common.dmn.engine.engine.definition.extensions.IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Aggregation](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.aggregation__1em3bg7) | public | Aggregation type of collect hit policy | 
 | [HitPolicy](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.hitpolicy__176002e) | public | Decision table hit policy | 
 | [Inputs](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.inputs__1gukefi) | public | Decision table inputs | 
 | [Outputs](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.outputs__1l9brdj) | public | Decision table outputs | 
 | [Rules](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.rules__jyebdy) | public | Decision table rules | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecisionTable(string, HitPolicyEnum, CollectHitPolicyAggregationEnum, DmnDecisionTableInput[], DmnDecisionTableOutput[], DmnDecisionTableRule[], IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;, string)](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.-ctor_system.string-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput__-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision_-system.string___1d9wq0l) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CalculatePositiveRulesCollectCountValue(IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;, DmnDecisionTableRuleExecutionResults)](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.calculatepositiverulescollectcountvalue_system.collections.generic.ienumerable_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule_-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults___t20dfe) | private static | Calculates the distinct count of output values for Collect hit policy | 
 | [CalculatePositiveRulesCollectValues(IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;, DmnDecisionTableRuleExecutionResults)](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.calculatepositiverulescollectvalues_system.collections.generic.ienumerable_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule_-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults___10017b8) | private static | Calculates the aggregate output values for Collect hit policy | 
 | [Evaluate(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.evaluate_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___15i5vei) | protected | Evaluates the decision table. | 
 | [EvaluateOutputsForPositiveRules(DmnExecutionContext, string, IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;)](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.evaluateoutputsforpositiverules_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string-system.collections.generic.ienumerable_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule____avs6of) | private | Evaluates the output expressions for  positive rules and stores generates the table execution results ( (rule, output)-&gt;temp variable with result) | 
 | [EvaluateOutputsForPositiveRulesParallel(DmnExecutionContext, string, IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;)](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.evaluateoutputsforpositiverulesparallel_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string-system.collections.generic.ienumerable_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule____130dol6) | private | Evaluates the output expressions for  positive rules and stores generates the table execution results ( (rule, output)-&gt;temp variable with result) | 
 | [EvaluateRules(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.evaluaterules_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___11j8juf) | private | Evaluates the rules and return the list of positive rules (rules that match the input) | 
 | [EvaluateRulesParallel(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.evaluaterulesparallel_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___t2vmo) | private | Evaluates the rules and return the list of positive rules (rules that match the input) | 
 | [GetIndexOfOutputValue(string[], object, string)](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.getindexofoutputvalue_system.string__-system.object-system.string___1so6u2i) | private | Gets the index of output <strong>value</strong> within the list of <strong>allowedValues</strong> . When the output <strong>value</strong> is null, it returns <a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32.maxvalue#System_Int32_MaxValue" target="_blank" >System.Int32.MaxValue</a> , so the items will be added to the end of the list when ordering by index. | 
 | [MatchRuleOutputs(IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;, DmnDecisionTableRuleExecutionResults)](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.matchruleoutputs_system.collections.generic.ienumerable_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule_-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults___gnnfg1) | private static | Checks whether all positive rule outputs match as required by Any hit policy | 
 | [OrderPositiveRulesByOutputPriority(IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;, DmnDecisionTableRuleExecutionResults, string)](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.orderpositiverulesbyoutputpriority_system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule_-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults-system.string___1d7km3g) | private | Orders the positive rules by output priorities for the Priority and Output order hit policies. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.aggregation__1em3bg7" />  DmnDecisionTable.Aggregation Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Aggregation type of collect hit policy



```csharp
public CollectHitPolicyAggregationEnum Aggregation { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.hitpolicy__176002e" />  DmnDecisionTable.HitPolicy Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Decision table hit policy



```csharp
public HitPolicyEnum HitPolicy { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.inputs__1gukefi" />  DmnDecisionTable.Inputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Decision table inputs



```csharp
public DmnDecisionTableInput[] Inputs { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableInput[]](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__qptrq2)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.outputs__1l9brdj" />  DmnDecisionTable.Outputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Decision table outputs



```csharp
public DmnDecisionTableOutput[] Outputs { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableOutput[]](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput__nhnleh)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.rules__jyebdy" />  DmnDecisionTable.Rules Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Decision table rules



```csharp
public DmnDecisionTableRule[] Rules { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule[]](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.-ctor_system.string-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput__-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision_-system.string___1d9wq0l" />  DmnDecisionTable.DmnDecisionTable(string, HitPolicyEnum, CollectHitPolicyAggregationEnum, DmnDecisionTableInput[], DmnDecisionTableOutput[], DmnDecisionTableRule[], IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


CTOR



```csharp
public DmnDecisionTable(string name, HitPolicyEnum hitPolicy, CollectHitPolicyAggregationEnum aggregation, DmnDecisionTableInput[] inputs, DmnDecisionTableOutput[] outputs, DmnDecisionTableRule[] rules, IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> requiredInputs, IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> requiredDecisions, string label = null)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Decision table name</dd><dt>[net.adamec.lib.common.dmn.engine.parser.dto.HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz) <strong>hitPolicy</strong></dt><dd>Decision table hit policy</dd><dt>[net.adamec.lib.common.dmn.engine.parser.dto.CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9) <strong>aggregation</strong></dt><dd>Aggregation type of Collect hit policy</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableInput[]](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__qptrq2) <strong>inputs</strong></dt><dd>Decision table inputs</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableOutput[]](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput__nhnleh) <strong>outputs</strong></dt><dd>Decision table outputs</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule[]](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko) <strong>rules</strong></dt><dd>Decision table rules</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a> <strong>requiredInputs</strong></dt><dd>Inputs the decision table depends on.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a> <strong>requiredDecisions</strong></dt><dd>Decisions that needs to be evaluated before the decision table (provide the inputs to the table).</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Optional decision table label. Name is used when not provided</dd></dl>
###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>inputs</strong> , <strong>outputs</strong> or <strong>rules</strong> is null</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>inputs</strong> , <strong>outputs</strong> or <strong>rules</strong> is empty</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.calculatepositiverulescollectcountvalue_system.collections.generic.ienumerable_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule_-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults___t20dfe" />  DmnDecisionTable.CalculatePositiveRulesCollectCountValue(IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;, DmnDecisionTableRuleExecutionResults) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Calculates the distinct count of output values for Collect hit policy



```csharp
private static DmnDecisionTable.PositiveRulesCollectValues CalculatePositiveRulesCollectCountValue(IEnumerable<net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule> positiveRules, DmnDecisionTableRuleExecutionResults results)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;</a> <strong>positiveRules</strong></dt><dd>Rules evaluates as positive match</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9) <strong>results</strong></dt><dd>Evaluated (calculated) results (rule outputs)</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.DmnDecisionTable.PositiveRulesCollectValues](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues__z17b4n)</dt><dd>[DmnDecisionTable.PositiveRulesCollectValues](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues__z17b4n) container where the [Count](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#f-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues.count__brqcxm) contains the distinct count of values, the other properties are zeroed</dd></dl>


###  Remarks ###
Based on the collect hit policy, the aggregated count is calculated for the first output.


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.calculatepositiverulescollectvalues_system.collections.generic.ienumerable_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule_-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults___10017b8" />  DmnDecisionTable.CalculatePositiveRulesCollectValues(IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;, DmnDecisionTableRuleExecutionResults) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Calculates the aggregate output values for Collect hit policy



```csharp
private static DmnDecisionTable.PositiveRulesCollectValues CalculatePositiveRulesCollectValues(IEnumerable<net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule> positiveRules, DmnDecisionTableRuleExecutionResults results)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;</a> <strong>positiveRules</strong></dt><dd>Rules evaluates as positive match</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9) <strong>results</strong></dt><dd>Evaluated (calculated) results (rule outputs)</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.DmnDecisionTable.PositiveRulesCollectValues](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues__z17b4n)</dt><dd>[DmnDecisionTable.PositiveRulesCollectValues](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues__z17b4n) container with aggregated output values</dd></dl>


###  Remarks ###
Based on the collect hit policy, the aggregates are calculated for the first output


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.evaluate_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___15i5vei" />  DmnDecisionTable.Evaluate(DmnExecutionContext, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Evaluates the decision table.



```csharp
protected override DmnDecisionResult Evaluate(DmnExecutionContext context, string executionId)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) <strong>context</strong></dt><dd>DMN Engine execution context</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>executionId</strong></dt><dd>Identifier of the execution run</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.result.DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.execution.result__q1n4oi.md#t-net.adamec.lib.common.dmn.engine.engine.execution.result.dmndecisionresult__1v2ltka)</dt><dd>Decision result</dd></dl>Overrides: [DmnDecision.Evaluate(DmnExecutionContext, string)](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision.evaluate_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___4pf6g8)


###  Remarks ###
While evaluating the decision table, the [Rules](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.rules__jyebdy) are evaluated first. Then it evaluates (calculates) the outputs for positive rules and applies the hit policy.


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>context</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.evaluateoutputsforpositiverules_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string-system.collections.generic.ienumerable_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule____avs6of" />  DmnDecisionTable.EvaluateOutputsForPositiveRules(DmnExecutionContext, string, IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Evaluates the output expressions for  positive rules and stores generates the table execution results ( (rule, output)-&gt;temp variable with result)



```csharp
private DmnDecisionTableRuleExecutionResults EvaluateOutputsForPositiveRules(DmnExecutionContext context, string executionId, IEnumerable<net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule> positiveRules)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) <strong>context</strong></dt><dd>Engine execution context</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>executionId</strong></dt><dd>Identifier of the execution run</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;</a> <strong>positiveRules</strong></dt><dd>List of positive rules</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9)</dt><dd>Table execution results</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.evaluateoutputsforpositiverulesparallel_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string-system.collections.generic.ienumerable_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule____130dol6" />  DmnDecisionTable.EvaluateOutputsForPositiveRulesParallel(DmnExecutionContext, string, IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Evaluates the output expressions for  positive rules and stores generates the table execution results ( (rule, output)-&gt;temp variable with result)



```csharp
private DmnDecisionTableRuleExecutionResults EvaluateOutputsForPositiveRulesParallel(DmnExecutionContext context, string executionId, IEnumerable<net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule> positiveRules)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) <strong>context</strong></dt><dd>Engine execution context</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>executionId</strong></dt><dd>Identifier of the execution run</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;</a> <strong>positiveRules</strong></dt><dd>List of positive rules</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9)</dt><dd>Table execution results</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.evaluaterules_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___11j8juf" />  DmnDecisionTable.EvaluateRules(DmnExecutionContext, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Evaluates the rules and return the list of positive rules (rules that match the input)



```csharp
private List<net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule> EvaluateRules(DmnExecutionContext context, string executionId)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) <strong>context</strong></dt><dd>Engine execution context</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>executionId</strong></dt><dd>Identifier of the execution run</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;</a></dt><dd>List of positive rules (rules that match the input)</dd></dl>


###  Remarks ###
Decision table defines the set of rules - &quot;when the input values matches all input conditions, provide defined outputs&quot;. The input data are compared with corresponding rule expressions and when all match (comparison is true), the rule is evaluated as positive. Technically, when there is a negative comparison result, the rule is evaluates as negative and the rest of inputs is not evaluated. It&#39;s possible to omit all input expressions, so the rule will be always evaluated as positive match.


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>context</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.evaluaterulesparallel_net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext-system.string___t2vmo" />  DmnDecisionTable.EvaluateRulesParallel(DmnExecutionContext, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Evaluates the rules and return the list of positive rules (rules that match the input)



```csharp
private List<net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule> EvaluateRulesParallel(DmnExecutionContext context, string executionId)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.execution.context.DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) <strong>context</strong></dt><dd>Engine execution context</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>executionId</strong></dt><dd>Identifier of the execution run</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;</a></dt><dd>List of positive rules (rules that match the input)</dd></dl>


###  Remarks ###
Decision table defines the set of rules - &quot;when the input values matches all input conditions, provide defined outputs&quot;. The input data are compared with corresponding rule expressions and when all match (comparison is true), the rule is evaluated as positive. Technically, when there is a negative comparison result, the rule is evaluates as negative and the rest of inputs is not evaluated. It&#39;s possible to omit all input expressions, so the rule will be always evaluated as positive match.


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>context</strong> is nul</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.getindexofoutputvalue_system.string__-system.object-system.string___1so6u2i" />  DmnDecisionTable.GetIndexOfOutputValue(string[], object, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Gets the index of output <strong>value</strong> within the list of <strong>allowedValues</strong> . When the output <strong>value</strong> is null, it returns <a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32.maxvalue#System_Int32_MaxValue" target="_blank" >System.Int32.MaxValue</a> , so the items will be added to the end of the list when ordering by index.



```csharp
private int GetIndexOfOutputValue(string[] allowedValues, object value, string executionId)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>allowedValues</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>value</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>executionId</strong></dt><dd>Identifier of the execution run</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd>Index of output <strong>value</strong> within the list of <strong>allowedValues</strong> . When the output <strong>value</strong> is null, it returns <a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32.maxvalue#System_Int32_MaxValue" target="_blank" >System.Int32.MaxValue</a> .</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.matchruleoutputs_system.collections.generic.ienumerable_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule_-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults___gnnfg1" />  DmnDecisionTable.MatchRuleOutputs(IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;, DmnDecisionTableRuleExecutionResults) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Checks whether all positive rule outputs match as required by Any hit policy



```csharp
private static bool MatchRuleOutputs(IEnumerable<net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule> positiveRules, DmnDecisionTableRuleExecutionResults results)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;</a> <strong>positiveRules</strong></dt><dd>Rules evaluates as positive match</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9) <strong>results</strong></dt><dd>Evaluated (calculated) results (rule outputs)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True when all positive rule outputs match</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.orderpositiverulesbyoutputpriority_system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule_-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults-system.string___1d7km3g" />  DmnDecisionTable.OrderPositiveRulesByOutputPriority(IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;, DmnDecisionTableRuleExecutionResults, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Orders the positive rules by output priorities for the Priority and Output order hit policies.



```csharp
private IOrderedEnumerable<net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule> OrderPositiveRulesByOutputPriority(IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule> positiveRules, DmnDecisionTableRuleExecutionResults results, string executionId)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;</a> <strong>positiveRules</strong></dt><dd>Rules evaluates as positive match</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9) <strong>results</strong></dt><dd>Evaluated (calculated) results (rule outputs)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>executionId</strong></dt><dd>Identifier of the execution run</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.linq.iorderedenumerable-1" target="_blank" >System.Linq.IOrderedEnumerable&lt;net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;</a></dt><dd>Positive rules ordered by output priorities for the Priority and Output order hit policies</dd></dl>


###  Remarks ###
For the Priority and Output order hit policies, priority is decided in compound output tables over all the outputs for which output values have been provided. The priority for each output is specified in the ordered list of output values in decreasing order of priority, and the overall priority is established by considering the ordered outputs from left to right. Outputs for which no output values are provided are not taken into account in the ordering, although their output entries are included in the ordered compound output.


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues__z17b4n" />  DmnDecisionTable.PositiveRulesCollectValues Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Container of aggregate values for positive rules when [Collect](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.collect__t0bm9p) hit policy is used.



```csharp
private class DmnDecisionTable.PositiveRulesCollectValues
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Count](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#f-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues.count__brqcxm) | public | Count of distinct evaluated values | 
 | [Max](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#f-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues.max__1jkdaiz) | public | Max evaluated value | 
 | [Min](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#f-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues.min__1doa1ep) | public | Min evaluated value | 
 | [Sum](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#f-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues.sum__5bl57u) | public | Sum of evaluated values | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecisionTable.PositiveRulesCollectValues(double, double, double, int)](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues.-ctor_system.double-system.double-system.double-system.int32___1ikh4qb) | public | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues.count__brqcxm" />  DmnDecisionTable.PositiveRulesCollectValues.Count Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable.PositiveRulesCollectValues](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues__z17b4n)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Count of distinct evaluated values



```csharp
public readonly int Count
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues.max__1jkdaiz" />  DmnDecisionTable.PositiveRulesCollectValues.Max Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable.PositiveRulesCollectValues](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues__z17b4n)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Max evaluated value



```csharp
public readonly double Max
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues.min__1doa1ep" />  DmnDecisionTable.PositiveRulesCollectValues.Min Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable.PositiveRulesCollectValues](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues__z17b4n)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Min evaluated value



```csharp
public readonly double Min
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues.sum__5bl57u" />  DmnDecisionTable.PositiveRulesCollectValues.Sum Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable.PositiveRulesCollectValues](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues__z17b4n)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


Sum of evaluated values



```csharp
public readonly double Sum
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues.-ctor_system.double-system.double-system.double-system.int32___1ikh4qb" />  DmnDecisionTable.PositiveRulesCollectValues.DmnDecisionTable.PositiveRulesCollectValues(double, double, double, int) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTable.PositiveRulesCollectValues](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues__z17b4n)           
Sources: engine\decisions\table\DmnDecisionTable.cs</small>


CTOR



```csharp
public DmnDecisionTable.PositiveRulesCollectValues(double sum, double min, double max, int count)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a> <strong>sum</strong></dt><dd>Sum of evaluated values</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a> <strong>min</strong></dt><dd>Min evaluated value</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a> <strong>max</strong></dt><dd>Max evaluated value</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>count</strong></dt><dd>Count of distinct evaluated values</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 




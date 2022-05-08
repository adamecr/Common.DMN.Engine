#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v" />  net.adamec.lib.common.dmn.engine.engine.decisions.table.definition Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecisionTableInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__qptrq2) | public | Definition of decision table input - contains index (order), mapping to the source variable or source expression, and optional list of allowed values | 
 | [DmnDecisionTableOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput__nhnleh) | public | Definition of decision table output - contains index (order), mapping to the variable and optional list of allowed values | 
 | [DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko) | public | Definition of table rule | 
 | [DmnDecisionTableRuleInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput__11odv5c) | public | Definition of decision table rule input - contains the input match evaluation expression and mapping to table input | 
 | [DmnDecisionTableRuleOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput__1gob6sb) | public | Definition of decision table rule output - contains the calculation expression and mapping to table output | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__qptrq2" />  DmnDecisionTableInput Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\table\definition\DmnDecisionTableInput.cs</small>


Definition of decision table input - contains index (order), mapping to the source variable or source expression, and optional list of allowed values



```csharp
public class DmnDecisionTableInput
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Remarks ###
Source variable and source expression are mutually exclusive and one of them has to be provided. When the definition contains both variable and expression, the expression is used. See [CreateDecisionTable(DecisionTable, string, List&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.createdecisiontable_net.adamec.lib.common.dmn.engine.parser.dto.decisiontable-system.string-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____1f55han) for details.


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllowedValues](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput.allowedvalues__1ew66cu) | public | Optional array of allowed values | 
 | [Expression](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput.expression__1cn0pci) | public | Input source expression (the evaluated expression is compared to the rules) | 
 | [Index](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput.index__azcv2w) | public | Index of the input (order) | 
 | [Label](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput.label__wgih96) | public | Input label, &quot;Input#{Index+1}&quot; will be used if not provided (1-based index) | 
 | [Variable](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput.variable__1k6dlgo) | public | Input source variable (the variable value is compared to the rules) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecisionTableInput(int, IDmnVariable, string, string[], string)](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput.-ctor_system.int32-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable-system.string-system.string__-system.string___1urvpyg) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput.tostring__1hvoill) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput.allowedvalues__1ew66cu" />  DmnDecisionTableInput.AllowedValues Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__qptrq2)           
Sources: engine\decisions\table\definition\DmnDecisionTableInput.cs</small>


Optional array of allowed values



```csharp
public string[] AllowedValues { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput.expression__1cn0pci" />  DmnDecisionTableInput.Expression Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__qptrq2)           
Sources: engine\decisions\table\definition\DmnDecisionTableInput.cs</small>


Input source expression (the evaluated expression is compared to the rules)



```csharp
public string Expression { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


###  Remarks ###
Source variable and source expression are mutually exclusive. Expression has the priority over the variable


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput.index__azcv2w" />  DmnDecisionTableInput.Index Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__qptrq2)           
Sources: engine\decisions\table\definition\DmnDecisionTableInput.cs</small>


Index of the input (order)



```csharp
public int Index { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput.label__wgih96" />  DmnDecisionTableInput.Label Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__qptrq2)           
Sources: engine\decisions\table\definition\DmnDecisionTableInput.cs</small>


Input label, &quot;Input#{Index+1}&quot; will be used if not provided (1-based index)



```csharp
public string Label { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput.variable__1k6dlgo" />  DmnDecisionTableInput.Variable Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__qptrq2)           
Sources: engine\decisions\table\definition\DmnDecisionTableInput.cs</small>


Input source variable (the variable value is compared to the rules)



```csharp
public IDmnVariable Variable { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w)</dt><dd></dd></dl>


###  Remarks ###
Source variable and source expression are mutually exclusive. Expression has the priority over the variable


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput.-ctor_system.int32-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable-system.string-system.string__-system.string___1urvpyg" />  DmnDecisionTableInput.DmnDecisionTableInput(int, IDmnVariable, string, string[], string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__qptrq2)           
Sources: engine\decisions\table\definition\DmnDecisionTableInput.cs</small>


CTOR



```csharp
public DmnDecisionTableInput(int index, IDmnVariable variable, string expression = null, string[] allowedValues = null, string label = null)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>index</strong></dt><dd>Index of the input (order)</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w) <strong>variable</strong></dt><dd>Input source variable (the variable value is compared to the rules)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Input source expression (the evaluated expression is compared to the rules)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>allowedValues</strong></dt><dd>Optional array of allowed values</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Input label, &quot;Input#{Index+1}&quot; will be used if not provided</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput.tostring__1hvoill" />  DmnDecisionTableInput.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__qptrq2)           
Sources: engine\decisions\table\definition\DmnDecisionTableInput.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput__nhnleh" />  DmnDecisionTableOutput Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\table\definition\DmnDecisionTableOutput.cs</small>


Definition of decision table output - contains index (order), mapping to the variable and optional list of allowed values



```csharp
public class DmnDecisionTableOutput
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllowedValues](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput.allowedvalues__1r9ae17) | public | Optional array of allowed values | 
 | [Index](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput.index__jk2zpd) | public | Index of the output (order) | 
 | [Label](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput.label__wc79s1) | public | Output label, &quot;Output#{Index+1}&quot; will be used if not provided (1-based index) | 
 | [Variable](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput.variable__1q0vo3l) | public | Variable to store the output to | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecisionTableOutput(int, IDmnVariable, string[], string)](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput.-ctor_system.int32-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable-system.string__-system.string___vzrzed) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput.tostring__120d08q) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput.allowedvalues__1r9ae17" />  DmnDecisionTableOutput.AllowedValues Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput__nhnleh)           
Sources: engine\decisions\table\definition\DmnDecisionTableOutput.cs</small>


Optional array of allowed values



```csharp
public string[] AllowedValues { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput.index__jk2zpd" />  DmnDecisionTableOutput.Index Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput__nhnleh)           
Sources: engine\decisions\table\definition\DmnDecisionTableOutput.cs</small>


Index of the output (order)



```csharp
public int Index { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput.label__wc79s1" />  DmnDecisionTableOutput.Label Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput__nhnleh)           
Sources: engine\decisions\table\definition\DmnDecisionTableOutput.cs</small>


Output label, &quot;Output#{Index+1}&quot; will be used if not provided (1-based index)



```csharp
public string Label { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput.variable__1q0vo3l" />  DmnDecisionTableOutput.Variable Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput__nhnleh)           
Sources: engine\decisions\table\definition\DmnDecisionTableOutput.cs</small>


Variable to store the output to



```csharp
public IDmnVariable Variable { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput.-ctor_system.int32-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable-system.string__-system.string___vzrzed" />  DmnDecisionTableOutput.DmnDecisionTableOutput(int, IDmnVariable, string[], string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput__nhnleh)           
Sources: engine\decisions\table\definition\DmnDecisionTableOutput.cs</small>


CTOR



```csharp
public DmnDecisionTableOutput(int index, IDmnVariable variable, string[] allowedValues = null, string label = null)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>index</strong></dt><dd>Index of the output (order)</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w) <strong>variable</strong></dt><dd>Variable to store the output to</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>allowedValues</strong></dt><dd>Optional array of allowed values</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Output label, &quot;Output#{Index+1}&quot; will be used if not provided</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput.tostring__120d08q" />  DmnDecisionTableOutput.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput__nhnleh)           
Sources: engine\decisions\table\definition\DmnDecisionTableOutput.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko" />  DmnDecisionTableRule Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\table\definition\DmnDecisionTableRule.cs</small>


Definition of table rule



```csharp
public class DmnDecisionTableRule
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Description](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule.description__uhwbkg) | public | Optional rule description (annotation) | 
 | [Index](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule.index__24u1wy) | public | Index (order) of the rule within the decision table | 
 | [Inputs](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule.inputs__u5s2hn) | public | Definition of decision table rule inputs (each input contains the input match evaluation expression and mapping to table input) | 
 | [Name](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule.name__t2vzyp) | public | Rule name | 
 | [Outputs](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule.outputs__kx35i0) | public | Definition of decision table rule outputs (each output contains the calculation expression and mapping to table output) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecisionTableRule(int, string, DmnDecisionTableRuleInput[], DmnDecisionTableRuleOutput[], string)](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule.-ctor_system.int32-system.string-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput__-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput__-system.string___1fed6xz) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule.tostring__1l47m4p) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule.description__uhwbkg" />  DmnDecisionTableRule.Description Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko)           
Sources: engine\decisions\table\definition\DmnDecisionTableRule.cs</small>


Optional rule description (annotation)



```csharp
public string Description { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule.index__24u1wy" />  DmnDecisionTableRule.Index Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko)           
Sources: engine\decisions\table\definition\DmnDecisionTableRule.cs</small>


Index (order) of the rule within the decision table



```csharp
public int Index { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule.inputs__u5s2hn" />  DmnDecisionTableRule.Inputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko)           
Sources: engine\decisions\table\definition\DmnDecisionTableRule.cs</small>


Definition of decision table rule inputs (each input contains the input match evaluation expression and mapping to table input)



```csharp
public DmnDecisionTableRuleInput[] Inputs { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRuleInput[]](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput__11odv5c)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule.name__t2vzyp" />  DmnDecisionTableRule.Name Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko)           
Sources: engine\decisions\table\definition\DmnDecisionTableRule.cs</small>


Rule name



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule.outputs__kx35i0" />  DmnDecisionTableRule.Outputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko)           
Sources: engine\decisions\table\definition\DmnDecisionTableRule.cs</small>


Definition of decision table rule outputs (each output contains the calculation expression and mapping to table output)



```csharp
public DmnDecisionTableRuleOutput[] Outputs { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRuleOutput[]](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput__1gob6sb)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule.-ctor_system.int32-system.string-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput__-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput__-system.string___1fed6xz" />  DmnDecisionTableRule.DmnDecisionTableRule(int, string, DmnDecisionTableRuleInput[], DmnDecisionTableRuleOutput[], string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko)           
Sources: engine\decisions\table\definition\DmnDecisionTableRule.cs</small>


CTOR



```csharp
public DmnDecisionTableRule(int index, string name, DmnDecisionTableRuleInput[] inputs, DmnDecisionTableRuleOutput[] outputs, string description = null)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>index</strong></dt><dd>Index (order) of the rule within the decision table</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Rule name</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRuleInput[]](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput__11odv5c) <strong>inputs</strong></dt><dd>Definition of decision table rule inputs</dd><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRuleOutput[]](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput__1gob6sb) <strong>outputs</strong></dt><dd>Definition of decision table rule outputs</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>description</strong></dt><dd>Optional rule description (annotation)</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule.tostring__1l47m4p" />  DmnDecisionTableRule.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko)           
Sources: engine\decisions\table\definition\DmnDecisionTableRule.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput__11odv5c" />  DmnDecisionTableRuleInput Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\table\definition\DmnDecisionTableRuleInput.cs</small>


Definition of decision table rule input - contains the input match evaluation expression and mapping to table input



```csharp
public class DmnDecisionTableRuleInput
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Expression](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput.expression__gj6d2o) | public | Expression used to evaluate the rule input match (&quot;both sides&quot;) | 
 | [Input](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput.input__1y72dxq) | public | Corresponding table input | 
 | [UnparsedExpression](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput.unparsedexpression__vkfm9q) | public | Unparsed expression used to evaluate the rule input match (&quot;right side&quot;) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecisionTableRuleInput(DmnDecisionTableInput, string)](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput.-ctor_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput-system.string___1tqtgil) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput.tostring__1ogy34r) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput.expression__gj6d2o" />  DmnDecisionTableRuleInput.Expression Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput__11odv5c)           
Sources: engine\decisions\table\definition\DmnDecisionTableRuleInput.cs</small>


Expression used to evaluate the rule input match (&quot;both sides&quot;)



```csharp
public string Expression { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput.input__1y72dxq" />  DmnDecisionTableRuleInput.Input Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput__11odv5c)           
Sources: engine\decisions\table\definition\DmnDecisionTableRuleInput.cs</small>


Corresponding table input



```csharp
public DmnDecisionTableInput Input { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__qptrq2)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput.unparsedexpression__vkfm9q" />  DmnDecisionTableRuleInput.UnparsedExpression Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput__11odv5c)           
Sources: engine\decisions\table\definition\DmnDecisionTableRuleInput.cs</small>


Unparsed expression used to evaluate the rule input match (&quot;right side&quot;)



```csharp
public string UnparsedExpression { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput.-ctor_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput-system.string___1tqtgil" />  DmnDecisionTableRuleInput.DmnDecisionTableRuleInput(DmnDecisionTableInput, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput__11odv5c)           
Sources: engine\decisions\table\definition\DmnDecisionTableRuleInput.cs</small>


CTOR



```csharp
public DmnDecisionTableRuleInput(DmnDecisionTableInput input, string unparsedExpression)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__qptrq2) <strong>input</strong></dt><dd>Corresponding table input</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>unparsedExpression</strong></dt><dd>Expression used to evaluate the rule input match (&quot;right side&quot;)</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput.tostring__1ogy34r" />  DmnDecisionTableRuleInput.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput__11odv5c)           
Sources: engine\decisions\table\definition\DmnDecisionTableRuleInput.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput__1gob6sb" />  DmnDecisionTableRuleOutput Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\decisions\table\definition\DmnDecisionTableRuleOutput.cs</small>


Definition of decision table rule output - contains the calculation expression and mapping to table output



```csharp
public class DmnDecisionTableRuleOutput
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Expression](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput.expression__1dimker) | public | Expression used to calculate the value of rule output | 
 | [Output](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput.output__i8y76c) | public | Corresponding table output | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDecisionTableRuleOutput(DmnDecisionTableOutput, string)](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput.-ctor_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput-system.string___1eexcsx) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput.tostring__1ri5kxs) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput.expression__1dimker" />  DmnDecisionTableRuleOutput.Expression Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput__1gob6sb)           
Sources: engine\decisions\table\definition\DmnDecisionTableRuleOutput.cs</small>


Expression used to calculate the value of rule output



```csharp
public string Expression { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput.output__i8y76c" />  DmnDecisionTableRuleOutput.Output Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput__1gob6sb)           
Sources: engine\decisions\table\definition\DmnDecisionTableRuleOutput.cs</small>


Corresponding table output



```csharp
public DmnDecisionTableOutput Output { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput__nhnleh)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput.-ctor_net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput-system.string___1eexcsx" />  DmnDecisionTableRuleOutput.DmnDecisionTableRuleOutput(DmnDecisionTableOutput, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput__1gob6sb)           
Sources: engine\decisions\table\definition\DmnDecisionTableRuleOutput.cs</small>


CTOR



```csharp
public DmnDecisionTableRuleOutput(DmnDecisionTableOutput output, string expression)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput__nhnleh) <strong>output</strong></dt><dd>Corresponding table output</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Expression used to calculate the value of rule output</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput.tostring__1ri5kxs" />  DmnDecisionTableRuleOutput.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDecisionTableRuleOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput__1gob6sb)           
Sources: engine\decisions\table\definition\DmnDecisionTableRuleOutput.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 




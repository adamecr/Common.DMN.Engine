#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6" />  net.adamec.lib.common.dmn.engine.engine.definition Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) | public | DMN model definition for execution engine | 
 | [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi) | public | Factory that validates and transforms the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) to [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) that can be executed within [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx) | 
 | [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88) | public | Definition of DMN model variable | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4" />  DmnDefinition Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\DmnDefinition.cs</small>


DMN model definition for execution engine



```csharp
public class DmnDefinition
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decisions](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.decisions__1drwp89) | public | Dictionary of available decisions by name | 
 | [InputData](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.inputdata__1605bm2) | public | Input data interface. Input data will be stored as Variables, complex objects are supported | 
 | [Variables](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.variables__1aage4j) | public | Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDefinition(IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;, IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;, IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.-ctor_system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition_-system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition_-system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____hwvko1) | internal | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.decisions__1drwp89" />  DmnDefinition.Decisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)           
Sources: engine\definition\DmnDefinition.cs</small>


Dictionary of available decisions by name



```csharp
public IDictionary<string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> Decisions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.inputdata__1605bm2" />  DmnDefinition.InputData Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)           
Sources: engine\definition\DmnDefinition.cs</small>


Input data interface. Input data will be stored as Variables, complex objects are supported



```csharp
public IDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> InputData { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.variables__1aage4j" />  DmnDefinition.Variables Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)           
Sources: engine\definition\DmnDefinition.cs</small>


Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions



```csharp
public IDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> Variables { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.-ctor_system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition_-system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition_-system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____hwvko1" />  DmnDefinition.DmnDefinition(IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;, IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;, IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)           
Sources: engine\definition\DmnDefinition.cs</small>


CTOR



```csharp
internal DmnDefinition(IDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> variables, IDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> inputData, IDictionary<string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> decisions)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a> <strong>variables</strong></dt><dd>Variables used while executing the DMN model</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a> <strong>inputData</strong></dt><dd>Input data interface. Input data will be stored as Variables, complex objects are supported</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a> <strong>decisions</strong></dt><dd>Dictionary of available decisions by name</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi" />  DmnDefinitionFactory Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Factory that validates and transforms the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) to [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) that can be executed within [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)



```csharp
public class DmnDefinitionFactory
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Remarks ###
As the [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga) is responsible for parsing the XML with the model, the [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi) contains the main logic of checking the model and preparing it for the execution. It&#39;s recommended not to build [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) out of this factory, as the crucial validations may be missed.


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Logger](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#f-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.logger__a8qmti) | internal static | Logger | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decisions](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.decisions__1rcbwu9) | public | Dictionary of available decisions by name | 
 | [InputData](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdata__l7jpfg) | public | Input data interface. Input data will be stored as Variables, complex objects are supported | 
 | [Variables](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.variables__85kbnj) | public | Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDefinitionFactory(DmnModel)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.-ctor_net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel___16qajmq) | protected | CTOR - Validates the <strong>source</strong> model and creates the [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) from [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddNewRequiredInputs(IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;, List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.addnewrequiredinputs_system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition_-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition____1qff34w) | protected static | Adds <strong>newInputs</strong> into the list of <strong>requiredInputs</strong> . <strong>newInputs</strong> can be null or empty (no addition then) | 
 | [CreateDecisionTable(DecisionTable, string, List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;, List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.createdecisiontable_net.adamec.lib.common.dmn.engine.parser.dto.decisiontable-system.string-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition_-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____2r7jwn) | protected | Validates the <strong>sourceTable</strong> within the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) and creates [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh) | 
 | [CreateDmnDefinition(DmnModel)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.createdmndefinition_net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel___svybqf) | public static | Validates the <strong>source</strong> model and creates the [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) from [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) | 
 | [CreateExpressionDecision(Decision, string, List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;, List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.createexpressiondecision_net.adamec.lib.common.dmn.engine.parser.dto.decision-system.string-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition_-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____l4v9i1) | protected | Validates the <strong>sourceDecision</strong> within the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) and creates [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9) | 
 | [CheckAndUpdateVariableType(DmnVariableDefinition, string)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.checkandupdatevariabletype_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition-system.string___zic7ay) | protected static | Assigns the <strong>variable</strong> with <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> corresponding to the <strong>typeName</strong> . When the variable already contains the type information, it must match with the <strong>typeName</strong> | 
 | [NormalizeVariableName(string)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.normalizevariablename_system.string___ll3bce) | protected static | Normalize the variable name (trim and replace space with underscore) | 
 | [ParseTypeName(string)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.parsetypename_system.string___1eh82ka) | private static | Parses the type name to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> | 
 | [ProcessDecision(Decision, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.parser.dto.Decision&gt;, IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;, IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.processdecision_net.adamec.lib.common.dmn.engine.parser.dto.decision-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.parser.dto.decision_-system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision_-system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition____9k3xwd) | protected | Validates the <strong>sourceDecision</strong> within the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) and creates [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9) or [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh) | 
 | [ProcessInputDataSource(DmnModel, IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.processinputdatasource_net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel-system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition____fkuaxj) | protected | Validates the inputs of the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) ( <strong>source</strong> and populates [InputData](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdata__l7jpfg) and related [Variables](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.variables__85kbnj) | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.logger__a8qmti" />  DmnDefinitionFactory.Logger Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Logger



```csharp
internal static ILogger Logger
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.decisions__1rcbwu9" />  DmnDefinitionFactory.Decisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Dictionary of available decisions by name



```csharp
public IDictionary<string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> Decisions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdata__l7jpfg" />  DmnDefinitionFactory.InputData Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Input data interface. Input data will be stored as Variables, complex objects are supported



```csharp
public IDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> InputData { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.variables__85kbnj" />  DmnDefinitionFactory.Variables Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions



```csharp
public IDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> Variables { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.-ctor_net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel___16qajmq" />  DmnDefinitionFactory.DmnDefinitionFactory(DmnModel) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


CTOR - Validates the <strong>source</strong> model and creates the [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) from [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9)



```csharp
protected DmnDefinitionFactory(DmnModel source)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) <strong>source</strong></dt><dd>Source DMN Model parsed from XML</dd></dl>
###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>source</strong> is null.</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.addnewrequiredinputs_system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition_-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition____1qff34w" />  DmnDefinitionFactory.AddNewRequiredInputs(IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;, List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Adds <strong>newInputs</strong> into the list of <strong>requiredInputs</strong> . <strong>newInputs</strong> can be null or empty (no addition then)



```csharp
protected static void AddNewRequiredInputs(IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> newInputs, List<net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> requiredInputs)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a> <strong>newInputs</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a> <strong>requiredInputs</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>requiredInputs</strong> is null.</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.createdecisiontable_net.adamec.lib.common.dmn.engine.parser.dto.decisiontable-system.string-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition_-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____2r7jwn" />  DmnDefinitionFactory.CreateDecisionTable(DecisionTable, string, List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;, List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Validates the <strong>sourceTable</strong> within the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) and creates [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)



```csharp
protected DmnDecisionTable CreateDecisionTable(DecisionTable sourceTable, string decisionName, List<net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> requiredInputs, List<net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> requiredDecisions)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr) <strong>sourceTable</strong></dt><dd>Decision source parsed from XML</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>decisionName</strong></dt><dd>Unique name of decision</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a> <strong>requiredInputs</strong></dt><dd>Inputs required by decision</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a> <strong>requiredDecisions</strong></dt><dd>Decisions, the decision table depends on</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>sourceTable</strong> , <strong>decisionName</strong> , <strong>requiredInputs</strong> or <strong>requiredDecisions</strong> is null.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>decisionName</strong> is empty</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>No outputs for decision table</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>No inputs for decision table</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Input variable for decision table not found</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>No rules for decision table</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Number of rule input entries doesn&#39;t match the number of inputs for decision table</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Number of rule output entries doesn&#39;t match the number of outputs for decision table</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.createdmndefinition_net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel___svybqf" />  DmnDefinitionFactory.CreateDmnDefinition(DmnModel) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Validates the <strong>source</strong> model and creates the [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) from [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9)



```csharp
public static DmnDefinition CreateDmnDefinition(DmnModel source)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) <strong>source</strong></dt><dd>Source DMN Model parsed from XML</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)</dt><dd>DMN model definition that can be used to execute the decisions within the [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx)</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>source</strong> is null.</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.createexpressiondecision_net.adamec.lib.common.dmn.engine.parser.dto.decision-system.string-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition_-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____l4v9i1" />  DmnDefinitionFactory.CreateExpressionDecision(Decision, string, List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;, List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Validates the <strong>sourceDecision</strong> within the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) and creates [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9)



```csharp
protected DmnExpressionDecision CreateExpressionDecision(Decision sourceDecision, string decisionName, List<net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> requiredInputs, List<net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> requiredDecisions)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.Decision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9) <strong>sourceDecision</strong></dt><dd>Decision source parsed from XML</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>decisionName</strong></dt><dd>Unique name of decision</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a> <strong>requiredInputs</strong></dt><dd>Inputs required by decision</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a> <strong>requiredDecisions</strong></dt><dd>Decisions, the decision table depends on</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.expression.DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>sourceDecision</strong> , <strong>decisionName</strong> , <strong>requiredInputs</strong> or <strong>requiredDecisions</strong> is null.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>decisionName</strong> is empty</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing expression for expression decision</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing output variable for expression decision</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.checkandupdatevariabletype_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition-system.string___zic7ay" />  DmnDefinitionFactory.CheckAndUpdateVariableType(DmnVariableDefinition, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Assigns the <strong>variable</strong> with <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> corresponding to the <strong>typeName</strong> . When the variable already contains the type information, it must match with the <strong>typeName</strong>



```csharp
protected static void CheckAndUpdateVariableType(DmnVariableDefinition variable, string typeName)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88) <strong>variable</strong></dt><dd>Variable to check or update. If null, function returns without an exception</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>typeName</strong></dt><dd>Type name to assign. If null or empty, function returns without an exception (assuming that the type is not know yet)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Type for variable don&#39;t match the one assigned before</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.normalizevariablename_system.string___ll3bce" />  DmnDefinitionFactory.NormalizeVariableName(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Normalize the variable name (trim and replace space with underscore)



```csharp
protected static string NormalizeVariableName(string name)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Normalized variable name</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>name</strong> is null or empty</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.parsetypename_system.string___1eh82ka" />  DmnDefinitionFactory.ParseTypeName(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Parses the type name to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a>



```csharp
private static Type ParseTypeName(string typeName)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>typeName</strong></dt><dd>Type name to parse</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> corresponding to <strong>typeName</strong></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>typeName</strong> is null or empty</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Unsupported type name</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.processdecision_net.adamec.lib.common.dmn.engine.parser.dto.decision-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.parser.dto.decision_-system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision_-system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition____9k3xwd" />  DmnDefinitionFactory.ProcessDecision(Decision, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.parser.dto.Decision&gt;, IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;, IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Validates the <strong>sourceDecision</strong> within the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) and creates [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9) or [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)



```csharp
protected IDmnDecision ProcessDecision(Decision sourceDecision, IReadOnlyCollection<net.adamec.lib.common.dmn.engine.parser.dto.Decision> allDecisions, IDictionary<string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> decisionsById, IDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> inputDataById)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.Decision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9) <strong>sourceDecision</strong></dt><dd>Decision source parsed from XML</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.parser.dto.Decision&gt;</a> <strong>allDecisions</strong></dt><dd>All decisions parsed from XML source</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a> <strong>decisionsById</strong></dt><dd>Temporary dictionary of decisions (by ID) - decisions are added here</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a> <strong>inputDataById</strong></dt><dd>Temporary dictionary of input data (by ID) - input data are populated here</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>sourceDecision</strong> , <strong>decisionsById</strong> or <strong>inputDataById</strong> is null.</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing decision id</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Duplicate decision name</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing required decision reference</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Decision with given reference id not found</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing required input reference for</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Input with given reference id not found</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.processinputdatasource_net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel-system.collections.generic.idictionary_system.string-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition____fkuaxj" />  DmnDefinitionFactory.ProcessInputDataSource(DmnModel, IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Validates the inputs of the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) ( <strong>source</strong> and populates [InputData](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdata__l7jpfg) and related [Variables](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.variables__85kbnj)



```csharp
protected void ProcessInputDataSource(DmnModel source, IDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> inputDataById)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) <strong>source</strong></dt><dd>Source DMN Model parsed from XML</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2" target="_blank" >IDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a> <strong>inputDataById</strong></dt><dd>Temporary dictionary of input data (by ID) - input data are populated here</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>source</strong> or <strong>inputDataById</strong> is null.</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing input id</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Duplicate input data name</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88" />  DmnVariableDefinition Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Definition of DMN model variable



```csharp
public class DmnVariableDefinition
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [HasValueSetter](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.hasvaluesetter__10beqao) | public | Flag whether the variable has any &quot;setter&quot; - is there any output to Variable or is Input parameter | 
 | [IsInputParameter](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.isinputparameter__1uoo4y9) | public | Flag whether the variable represents the input parameter of the decision model. Such variable will be read-only | 
 | [Name](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.name__1vxst0n) | public | Name of the variable | 
 | [Type](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.type__1ddehym) | public | Type of the variable when recognized from the decisions | 
 | [ValueSetters](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.valuesetters__1m2s7dp) | public | List of value &quot;setters&quot; for the variable. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnVariableDefinition(string)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.-ctor_system.string___1yg68v3) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.tostring__fng80j) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.hasvaluesetter__10beqao" />  DmnVariableDefinition.HasValueSetter Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Flag whether the variable has any &quot;setter&quot; - is there any output to Variable or is Input parameter



```csharp
public bool HasValueSetter { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.isinputparameter__1uoo4y9" />  DmnVariableDefinition.IsInputParameter Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Flag whether the variable represents the input parameter of the decision model. Such variable will be read-only



```csharp
public bool IsInputParameter { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.name__1vxst0n" />  DmnVariableDefinition.Name Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Name of the variable



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.type__1ddehym" />  DmnVariableDefinition.Type Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Type of the variable when recognized from the decisions



```csharp
public Type Type { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.valuesetters__1m2s7dp" />  DmnVariableDefinition.ValueSetters Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


List of value &quot;setters&quot; for the variable.



```csharp
public List<string> ValueSetters { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a></dt><dd></dd></dl>


###  Remarks ###
Can be &quot;Input: {inputName}&quot;, &quot;Table Decision {decisionName}&quot; or &quot;Expression Decision {decisionName}&quot;.


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.-ctor_system.string___1yg68v3" />  DmnVariableDefinition.DmnVariableDefinition(string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


CTOR



```csharp
public DmnVariableDefinition(string name)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the variable</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.tostring__fng80j" />  DmnVariableDefinition.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Returns a string that represents the current object.



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 




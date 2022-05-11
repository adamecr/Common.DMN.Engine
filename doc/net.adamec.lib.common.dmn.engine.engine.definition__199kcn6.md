#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6" />  net.adamec.lib.common.dmn.engine.engine.definition Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) | public | DMN model definition for execution engine - encapsulates Decisions, Variables (incl. Input data) | 
 | [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi) | public | Factory that validates and transforms the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) to [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) that can be executed within [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) | 
 | [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88) | public | Definition of DMN model variable | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IDmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmndefinition__81b50x) | public abstract | DMN model definition for execution engine - encapsulates Decisions, Variables and Input data | 
 | [IDmnElement](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement__1odpnhw) | public abstract | Common properties for Decisions and Variables (also representing Input parameters) | 
 | [IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w) | public abstract | Read only definition DMN model variable | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4" />  DmnDefinition Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\DmnDefinition.cs</small>


DMN model definition for execution engine - encapsulates Decisions, Variables (incl. Input data)



```csharp
public class DmnDefinition : IDmnDefinition
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: [net.adamec.lib.common.dmn.engine.engine.definition.IDmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmndefinition__81b50x), [net.adamec.lib.common.dmn.engine.engine.definition.extensions.IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decisions](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.decisions__1drwp89) | public | Dictionary of available decisions by name | 
 | [Extensions](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.extensions__prba9s) | public | List of extensions that can be used to any related data. Engine doesn&#39;t neither manage nor touches the extensions | 
 | [Id](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.id__2fgy87) | public | Unique identifier of the definition (set at CTOR) | 
 | [InputData](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.inputdata__1605bm2) | public | Input data interface. Input data are stored as Variables with [IsInputParameter](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable.isinputparameter__1benkdl) flag, complex objects are supported | 
 | [Variables](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.variables__1aage4j) | public | Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDefinition(IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.-ctor_system.collections.generic.ireadonlydictionary_system.string-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.ireadonlydictionary_system.string-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____9fkjdz) | public | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.decisions__1drwp89" />  DmnDefinition.Decisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)           
Sources: engine\definition\DmnDefinition.cs</small>


Dictionary of available decisions by name



```csharp
public IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> Decisions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a></dt><dd></dd></dl>Implements: [IDmnDefinition.Decisions](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmndefinition.decisions__10l9ock)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.extensions__prba9s" />  DmnDefinition.Extensions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)           
Sources: engine\definition\DmnDefinition.cs</small>


List of extensions that can be used to any related data. Engine doesn&#39;t neither manage nor touches the extensions



```csharp
public List<object> Extensions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;object&gt;</a></dt><dd></dd></dl>Implements: [IDmnExtendable.Extensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable.extensions__1fyoyrc)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.id__2fgy87" />  DmnDefinition.Id Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)           
Sources: engine\definition\DmnDefinition.cs</small>


Unique identifier of the definition (set at CTOR)



```csharp
public string Id { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.inputdata__1605bm2" />  DmnDefinition.InputData Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)           
Sources: engine\definition\DmnDefinition.cs</small>


Input data interface. Input data are stored as Variables with [IsInputParameter](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable.isinputparameter__1benkdl) flag, complex objects are supported



```csharp
public IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> InputData { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a></dt><dd></dd></dl>Implements: [IDmnDefinition.InputData](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmndefinition.inputdata__98vjlt)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.variables__1aage4j" />  DmnDefinition.Variables Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)           
Sources: engine\definition\DmnDefinition.cs</small>


Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions



```csharp
public IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> Variables { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a></dt><dd></dd></dl>Implements: [IDmnDefinition.Variables](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmndefinition.variables__jjgze2)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition.-ctor_system.collections.generic.ireadonlydictionary_system.string-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.ireadonlydictionary_system.string-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____9fkjdz" />  DmnDefinition.DmnDefinition(IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)           
Sources: engine\definition\DmnDefinition.cs</small>


CTOR



```csharp
public DmnDefinition(IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> variables, IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> decisions)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a> <strong>variables</strong></dt><dd>Variables used while executing the DMN model</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a> <strong>decisions</strong></dt><dd>Dictionary of available decisions by name</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi" />  DmnDefinitionFactory Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Factory that validates and transforms the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) to [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) that can be executed within [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)



```csharp
public class DmnDefinitionFactory
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Remarks ###
As the [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga) is responsible for parsing the XML with the model, the [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi) contains the main logic of checking the model and preparing it for the execution. It&#39;s recommended not to build [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) out of this factory, as the crucial validations may be missed.


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DefaultKnowTypes](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#f-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.defaultknowtypes__12ulxuh) | public static | Default known types recognized by factory | 
 | [knownTypes](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#f-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.knowntypes__4vc8h6) | private | Set of known types that can be used for inputs/variables | 
 | [Logger](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#f-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.logger__a8qmti) | protected static | Logger | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decisions](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.decisions__1rcbwu9) | protected | Dictionary of available decisions by name | 
 | [DecisionsById](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.decisionsbyid__2fd72z) | protected | Dictionary of decision definitions (by ID) | 
 | [InputData](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdata__l7jpfg) | protected | Input data interface. Input data will be stored as Variables, complex objects are supported. Dictionary by Input/Variable name | 
 | [InputDataById](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdatabyid__5owg9s) | protected | Dictionary of input data variable definitions (by ID) | 
 | [KnownTypes](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.knowntypes__9ae0qg) | public | Set of known types that can be used for inputs/variables | 
 | [SourceModel](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.sourcemodel__vkf8za) | protected | Source DMN Model parsed from XML | 
 | [Variables](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.variables__85kbnj) | protected | Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions Dictionary by Variable name | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDefinitionFactory(DmnModel)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.-ctor_net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel___16qajmq) | protected | Protected CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddNewRequiredInputs(IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, List&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.addnewrequiredinputs_system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable____1vaeclm) | protected | Adds <strong>newInputs</strong> into the list of <strong>requiredInputs</strong> . <strong>newInputs</strong> can be null or empty (no addition then) | 
 | [CreateDecisionTable(DecisionTable, string, List&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.createdecisiontable_net.adamec.lib.common.dmn.engine.parser.dto.decisiontable-system.string-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____1f55han) | protected | Validates the <strong>sourceTable</strong> within the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) and creates [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh) | 
 | [CreateDmnDefinition(DmnModel)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.createdmndefinition_net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel___svybqf) | public static | Validates the <strong>source</strong> model and creates the [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) from [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) | 
 | [CreateExpressionDecision(Decision, string, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.createexpressiondecision_net.adamec.lib.common.dmn.engine.parser.dto.decision-system.string-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____iyvnd5) | protected | Validates the <strong>sourceDecision</strong> within the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) and creates [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9) | 
 | [CheckAndUpdateVariableType(DmnVariableDefinition, string)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.checkandupdatevariabletype_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition-system.string___zic7ay) | protected | Assigns the <strong>variable</strong> with <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> corresponding to the <strong>typeName</strong> . When the variable already contains the type information, it must match with the <strong>typeName</strong> | 
 | [CheckTableInputForVariable(string, Dictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;, bool, string, string, string)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.checktableinputforvariable_system.string-system.collections.generic.dictionary_system.string-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition_-system.boolean--system.string--system.string--system.string-___yuaco1) | protected | Checks whether is either not set (null or whitespace) or variable or expression. | 
 | [InitKnownTypes()](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.initknowntypes__ckc9g5) | protected | Initialize set of known types that can be used in DMN definition for inputs/variables | 
 | [ParseTypeName(string)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.parsetypename_system.string___1eh82ka) | public | Parses the type name to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> | 
 | [ProcessDecision(Decision)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.processdecision_net.adamec.lib.common.dmn.engine.parser.dto.decision___kq81f8) | protected | Validates the <strong>sourceDecision</strong> within the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) and creates [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9) or [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh) . Populates [Decisions](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.decisions__1rcbwu9) and [DecisionsById](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.decisionsbyid__2fd72z) | 
 | [ProcessDiagramExtension(DmnDefinition)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.processdiagramextension_net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition___1udrwgf) | protected | When the [SourceModel](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.sourcemodel__vkf8za) has the DI diagram data, it gets individual shapes having bounds and tries to find them within [InputDataById](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdatabyid__5owg9s) and [DecisionsById](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.decisionsbyid__2fd72z) . When there is a match, it creates [DiDiagramShapeExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension__1g3jyq3) attached to the element. All matched bounds are also added to [DiDiagramExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension__rjfeea) attached to the definition | 
 | [ProcessInputDataSource()](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.processinputdatasource__1jtm787) | protected | Validates the inputs of the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) ( [SourceModel](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.sourcemodel__vkf8za) ) and populates [InputData](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdata__l7jpfg) , [InputDataById](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdatabyid__5owg9s) and related [Variables](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.variables__85kbnj) | 
 | [ProcessModel()](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.processmodel__knqybn) | protected | Validates the [SourceModel](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.sourcemodel__vkf8za) model and creates the [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) from [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.defaultknowtypes__12ulxuh" />  DmnDefinitionFactory.DefaultKnowTypes Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Default known types recognized by factory



```csharp
public static Dictionary<string,System.Type> DefaultKnowTypes
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,System.Type&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.knowntypes__4vc8h6" />  DmnDefinitionFactory.knownTypes Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Set of known types that can be used for inputs/variables



```csharp
private Dictionary<string,System.Type> knownTypes
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,System.Type&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.logger__a8qmti" />  DmnDefinitionFactory.Logger Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Logger



```csharp
protected static ILogger Logger
```

<strong>Field value</strong><dl><dt>net.adamec.lib.common.core.logging.ILogger</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.decisions__1rcbwu9" />  DmnDefinitionFactory.Decisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Dictionary of available decisions by name



```csharp
protected Dictionary<string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> Decisions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.decisionsbyid__2fd72z" />  DmnDefinitionFactory.DecisionsById Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Dictionary of decision definitions (by ID)



```csharp
protected Dictionary<string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> DecisionsById { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdata__l7jpfg" />  DmnDefinitionFactory.InputData Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Input data interface. Input data will be stored as Variables, complex objects are supported. Dictionary by Input/Variable name



```csharp
protected Dictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> InputData { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdatabyid__5owg9s" />  DmnDefinitionFactory.InputDataById Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Dictionary of input data variable definitions (by ID)



```csharp
protected Dictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> InputDataById { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.knowntypes__9ae0qg" />  DmnDefinitionFactory.KnownTypes Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Set of known types that can be used for inputs/variables



```csharp
public Dictionary<string,System.Type> KnownTypes { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,System.Type&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.sourcemodel__vkf8za" />  DmnDefinitionFactory.SourceModel Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Source DMN Model parsed from XML



```csharp
protected DmnModel SourceModel { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.variables__85kbnj" />  DmnDefinitionFactory.Variables Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions Dictionary by Variable name



```csharp
protected Dictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> Variables { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.-ctor_net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel___16qajmq" />  DmnDefinitionFactory.DmnDefinitionFactory(DmnModel) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Protected CTOR



```csharp
protected DmnDefinitionFactory(DmnModel sourceModel)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) <strong>sourceModel</strong></dt><dd>Source DMN Model parsed from XML</dd></dl>
###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>sourceModel</strong> is null.</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.addnewrequiredinputs_system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable____1vaeclm" />  DmnDefinitionFactory.AddNewRequiredInputs(IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, List&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Adds <strong>newInputs</strong> into the list of <strong>requiredInputs</strong> . <strong>newInputs</strong> can be null or empty (no addition then)



```csharp
protected virtual void AddNewRequiredInputs(IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> newInputs, List<net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> requiredInputs)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a> <strong>newInputs</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a> <strong>requiredInputs</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>requiredInputs</strong> is null.</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.createdecisiontable_net.adamec.lib.common.dmn.engine.parser.dto.decisiontable-system.string-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.list_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____1f55han" />  DmnDefinitionFactory.CreateDecisionTable(DecisionTable, string, List&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Validates the <strong>sourceTable</strong> within the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) and creates [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)



```csharp
protected virtual DmnDecisionTable CreateDecisionTable(DecisionTable sourceTable, string decisionName, List<net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> requiredInputs, List<net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> requiredDecisions)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr) <strong>sourceTable</strong></dt><dd>Decision source parsed from XML</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>decisionName</strong></dt><dd>Unique name of decision</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a> <strong>requiredInputs</strong></dt><dd>Inputs required by decision</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a> <strong>requiredDecisions</strong></dt><dd>Decisions, the decision table depends on</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>sourceTable</strong> , <strong>decisionName</strong> , <strong>requiredInputs</strong> or <strong>requiredDecisions</strong> is null.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>decisionName</strong> is empty</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>No outputs for decision table</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>No inputs for decision table</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Input variable for decision table not found</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Input for decision table has no source</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>No rules for decision table</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Number of rule input entries doesn&#39;t match the number of inputs for decision table</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Number of rule output entries doesn&#39;t match the number of outputs for decision table</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


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
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)</dt><dd>DMN model definition that can be used to execute the decisions within the [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>source</strong> is null.</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.createexpressiondecision_net.adamec.lib.common.dmn.engine.parser.dto.decision-system.string-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable_-system.collections.generic.ireadonlycollection_net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision____iyvnd5" />  DmnDefinitionFactory.CreateExpressionDecision(Decision, string, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;, IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Validates the <strong>sourceDecision</strong> within the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) and creates [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9)



```csharp
protected virtual DmnExpressionDecision CreateExpressionDecision(Decision sourceDecision, string decisionName, IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> requiredInputs, IReadOnlyCollection<net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> requiredDecisions)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.Decision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9) <strong>sourceDecision</strong></dt><dd>Decision source parsed from XML</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>decisionName</strong></dt><dd>Unique name of decision</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a> <strong>requiredInputs</strong></dt><dd>Inputs required by decision</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a> <strong>requiredDecisions</strong></dt><dd>Decisions, the decision table depends on</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.expression.DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>sourceDecision</strong> , <strong>decisionName</strong> , <strong>requiredInputs</strong> or <strong>requiredDecisions</strong> is null.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>decisionName</strong> is empty</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing expression for expression decision</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing output variable for expression decision</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.checkandupdatevariabletype_net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition-system.string___zic7ay" />  DmnDefinitionFactory.CheckAndUpdateVariableType(DmnVariableDefinition, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Assigns the <strong>variable</strong> with <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> corresponding to the <strong>typeName</strong> . When the variable already contains the type information, it must match with the <strong>typeName</strong>



```csharp
protected virtual void CheckAndUpdateVariableType(DmnVariableDefinition variable, string typeName)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88) <strong>variable</strong></dt><dd>Variable to check or update. If null, function returns without an exception</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>typeName</strong></dt><dd>Type name to assign. If null or empty, function returns without an exception (assuming that the type is not know yet)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Type for variable don&#39;t match the one assigned before</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.checktableinputforvariable_system.string-system.collections.generic.dictionary_system.string-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition_-system.boolean--system.string--system.string--system.string-___yuaco1" />  DmnDefinitionFactory.CheckTableInputForVariable(string, Dictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;, bool, string, string, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Checks whether is either not set (null or whitespace) or variable or expression.



```csharp
protected virtual bool CheckTableInputForVariable(string source, Dictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition> knownVariables, out bool isVariable, out string sourceVariableName, out string variableName, out string expression)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>source</strong></dt><dd>Source string to check</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;</a> <strong>knownVariables</strong></dt><dd>Dictionary of know variables</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>isVariable</strong></dt><dd>Out: Flag whether the <strong>source</strong> is set and represents variable</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>sourceVariableName</strong></dt><dd>Out: Source variable name (before normalization) when <strong>source</strong> is set and represents variable</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>variableName</strong></dt><dd>Out: Variable name when <strong>source</strong> is set and represents variable</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Out: Expression when <strong>source</strong> is set and represents expression</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True when is not null or whitespace, so it represents variable or expression</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>knownVariables</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.initknowntypes__ckc9g5" />  DmnDefinitionFactory.InitKnownTypes() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Initialize set of known types that can be used in DMN definition for inputs/variables



```csharp
protected virtual void InitKnownTypes()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.parsetypename_system.string___1eh82ka" />  DmnDefinitionFactory.ParseTypeName(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Parses the type name to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a>



```csharp
public virtual Type ParseTypeName(string typeName)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>typeName</strong></dt><dd>Type name to parse</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> corresponding to <strong>typeName</strong></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>typeName</strong> is null or empty</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Unsupported type name</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.processdecision_net.adamec.lib.common.dmn.engine.parser.dto.decision___kq81f8" />  DmnDefinitionFactory.ProcessDecision(Decision) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Validates the <strong>sourceDecision</strong> within the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) and creates [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9) or [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh) . Populates [Decisions](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.decisions__1rcbwu9) and [DecisionsById](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.decisionsbyid__2fd72z)



```csharp
protected virtual IDmnDecision ProcessDecision(Decision sourceDecision)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.Decision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9) <strong>sourceDecision</strong></dt><dd>Decision source parsed from XML</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>sourceDecision</strong> is null.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception" target="_blank" >System.InvalidOperationException</a></dt><dd>[SourceModel](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.sourcemodel__vkf8za) , [InputData](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdata__l7jpfg) or [DecisionsById](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.decisionsbyid__2fd72z) is null.</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing decision id</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Duplicate decision name</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing required decision reference</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Decision with given reference id not found</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing required input reference for</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Input with given reference id not found</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.processdiagramextension_net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition___1udrwgf" />  DmnDefinitionFactory.ProcessDiagramExtension(DmnDefinition) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


When the [SourceModel](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.sourcemodel__vkf8za) has the DI diagram data, it gets individual shapes having bounds and tries to find them within [InputDataById](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdatabyid__5owg9s) and [DecisionsById](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.decisionsbyid__2fd72z) . When there is a match, it creates [DiDiagramShapeExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension__1g3jyq3) attached to the element. All matched bounds are also added to [DiDiagramExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension__rjfeea) attached to the definition



```csharp
protected virtual void ProcessDiagramExtension(DmnDefinition dmnDefinition)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) <strong>dmnDefinition</strong></dt><dd>DMN Definition built by factory</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>dmnDefinition</strong> is null.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception" target="_blank" >System.InvalidOperationException</a></dt><dd>[SourceModel](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.sourcemodel__vkf8za) , [InputData](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdata__l7jpfg) or [DecisionsById](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.decisionsbyid__2fd72z) is null.</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.processinputdatasource__1jtm787" />  DmnDefinitionFactory.ProcessInputDataSource() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Validates the inputs of the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) ( [SourceModel](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.sourcemodel__vkf8za) ) and populates [InputData](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdata__l7jpfg) , [InputDataById](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdatabyid__5owg9s) and related [Variables](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.variables__85kbnj)



```csharp
protected virtual void ProcessInputDataSource()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception" target="_blank" >System.InvalidOperationException</a></dt><dd>[SourceModel](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.sourcemodel__vkf8za) , [InputData](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.inputdata__l7jpfg) is null.</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing input id</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Duplicate input data name</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.processmodel__knqybn" />  DmnDefinitionFactory.ProcessModel() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi)           
Sources: engine\definition\DmnDefinitionFactory.cs</small>


Validates the [SourceModel](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.sourcemodel__vkf8za) model and creates the [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) from [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9)



```csharp
protected virtual DmnDefinition ProcessModel()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)</dt><dd>DMN model definition that can be used to execute the decisions within the [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception" target="_blank" >System.InvalidOperationException</a></dt><dd>[SourceModel](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory.sourcemodel__vkf8za) is null.</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88" />  DmnVariableDefinition Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Definition of DMN model variable



```csharp
public class DmnVariableDefinition : IDmnVariable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: [net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w), [net.adamec.lib.common.dmn.engine.engine.definition.IDmnElement](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement__1odpnhw), [net.adamec.lib.common.dmn.engine.engine.definition.extensions.IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o)


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [valueSetters](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#f-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.valuesetters__1kpqy4r) | private | List of value &quot;setters&quot; for the variable. | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Extensions](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.extensions__15u39qw) | public | List of extensions that can be used to any related data. Engine doesn&#39;t neither manage nor touches the extensions | 
 | [HasValueSetter](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.hasvaluesetter__10beqao) | public | Flag whether the variable has any &quot;setter&quot; - is there any output to Variable or is Input parameter | 
 | [IsInputParameter](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.isinputparameter__1uoo4y9) | public | Flag whether the variable represents the input parameter of the decision model. Such variable will be read-only | 
 | [Label](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.label__me2mk) | public | Label of the variable (used for input parameters) | 
 | [Name](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.name__1vxst0n) | public | Name of the variable | 
 | [NameWithLabel](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.namewithlabel__30a3qf) | public | Name with label information in case [Label](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.label__me2mk) is different than [Name](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.name__1vxst0n) | 
 | [Type](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.type__1ddehym) | public | Type of the variable when recognized from the decisions | 
 | [ValueSetters](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.valuesetters__1m2s7dp) | public | Enumerable list of value &quot;setters&quot; for the variable. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnVariableDefinition(string, string, Type, string)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.-ctor_system.string-system.string-system.type-system.string___12bfxq0) | public | CTOR - variable for input | 
 | [DmnVariableDefinition(string, Type, bool, List&lt;string&gt;, string)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.-ctor_system.string-system.type-system.boolean-system.collections.generic.list_system.string_-system.string___1lntuo0) | public | CTOR - variable | 
 | [DmnVariableDefinition(string, Type, string)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.-ctor_system.string-system.type-system.string___lrp94c) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddValueSetter(string)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.addvaluesetter_system.string___kesj3d) | public | Adds a value setter information to variable definition | 
 | [CanNormalizeVariableName(string, string, string)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.cannormalizevariablename_system.string-system.string--system.string-___19hyd4i) | public static | Tries to normalize the variable name (trim, replace space with underscore and remove some special characters) and check that all characters are letters, digits or underscore and that the first character is letter. | 
 | [NormalizeVariableName(string)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.normalizevariablename_system.string___1e8myh2) | public static | Normalize the variable name (trim, replace space with underscore and remove some special characters) and check that all characters are letters, digits or underscore and that the first character is letter | 
 | [SetRecognizedType(Type)](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.setrecognizedtype_system.type___1td9h71) | public | Sets the variable type if recognized later than constructed. When the type is already defined, the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception" target="_blank" >System.InvalidOperationException</a> is thrown | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.tostring__fng80j) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.valuesetters__1kpqy4r" />  DmnVariableDefinition.valueSetters Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


List of value &quot;setters&quot; for the variable.



```csharp
private readonly List<string> valueSetters
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a></dt><dd></dd></dl>


###  Remarks ###
Can be &quot;Input: {inputName}&quot;, &quot;Table Decision {decisionName}&quot; or &quot;Expression Decision {decisionName}&quot;.


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.extensions__15u39qw" />  DmnVariableDefinition.Extensions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


List of extensions that can be used to any related data. Engine doesn&#39;t neither manage nor touches the extensions



```csharp
public List<object> Extensions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;object&gt;</a></dt><dd></dd></dl>Implements: [IDmnExtendable.Extensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable.extensions__1fyoyrc)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.hasvaluesetter__10beqao" />  DmnVariableDefinition.HasValueSetter Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Flag whether the variable has any &quot;setter&quot; - is there any output to Variable or is Input parameter



```csharp
public bool HasValueSetter { get; protected set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>Implements: [IDmnVariable.HasValueSetter](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable.hasvaluesetter__rjo8es)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.isinputparameter__1uoo4y9" />  DmnVariableDefinition.IsInputParameter Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Flag whether the variable represents the input parameter of the decision model. Such variable will be read-only



```csharp
public bool IsInputParameter { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>Implements: [IDmnVariable.IsInputParameter](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable.isinputparameter__1benkdl)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.label__me2mk" />  DmnVariableDefinition.Label Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Label of the variable (used for input parameters)



```csharp
public string Label { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Implements: [IDmnElement.Label](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement.label__h6tcbk)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.name__1vxst0n" />  DmnVariableDefinition.Name Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Name of the variable



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Implements: [IDmnElement.Name](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement.name__1wmto3f)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.namewithlabel__30a3qf" />  DmnVariableDefinition.NameWithLabel Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Name with label information in case [Label](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.label__me2mk) is different than [Name](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.name__1vxst0n)



```csharp
public string NameWithLabel { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Implements: [IDmnElement.NameWithLabel](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement.namewithlabel__qmuhj7)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.type__1ddehym" />  DmnVariableDefinition.Type Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Type of the variable when recognized from the decisions



```csharp
public Type Type { get; protected set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>Implements: [IDmnVariable.Type](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable.type__muymo2)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.valuesetters__1m2s7dp" />  DmnVariableDefinition.ValueSetters Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Enumerable list of value &quot;setters&quot; for the variable.



```csharp
public IEnumerable<string> ValueSetters { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;string&gt;</a></dt><dd></dd></dl>Implements: [IDmnVariable.ValueSetters](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable.valuesetters__1rpx9)


###  Remarks ###
Can be &quot;Input: {inputName}&quot;, &quot;Table Decision {decisionName}&quot; or &quot;Expression Decision {decisionName}&quot;.


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.-ctor_system.string-system.string-system.type-system.string___12bfxq0" />  DmnVariableDefinition.DmnVariableDefinition(string, string, Type, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


CTOR - variable for input



```csharp
public DmnVariableDefinition(string name, string inputName, Type type = null, string label = null)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the variable</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>inputName</strong></dt><dd>Name of the input</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd>Optional Type of the variable if known</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Optional variable label. Name is used when not set</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.-ctor_system.string-system.type-system.boolean-system.collections.generic.list_system.string_-system.string___1lntuo0" />  DmnVariableDefinition.DmnVariableDefinition(string, Type, bool, List&lt;string&gt;, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


CTOR - variable



```csharp
public DmnVariableDefinition(string name, Type type, bool isInputParameter, List<string> valueSetters, string label = null)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the variable</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd>Optional Type of the variable if known</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>isInputParameter</strong></dt><dd>Flag whether the variable is backing the input</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a> <strong>valueSetters</strong></dt><dd>List of the information about the value setters</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Optional variable label. Name is used when not set</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.-ctor_system.string-system.type-system.string___lrp94c" />  DmnVariableDefinition.DmnVariableDefinition(string, Type, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


CTOR



```csharp
public DmnVariableDefinition(string name, Type type = null, string label = null)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the variable</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd>Optional Type of the variable if known</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Optional variable label. Name is used when not set</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.addvaluesetter_system.string___kesj3d" />  DmnVariableDefinition.AddValueSetter(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Adds a value setter information to variable definition



```csharp
public void AddValueSetter(string setter)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>setter</strong></dt><dd>Setter information to add</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.cannormalizevariablename_system.string-system.string--system.string-___19hyd4i" />  DmnVariableDefinition.CanNormalizeVariableName(string, string, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Tries to normalize the variable name (trim, replace space with underscore and remove some special characters) and check that all characters are letters, digits or underscore and that the first character is letter.



```csharp
public static bool CanNormalizeVariableName(string name, out string normalizedName, out string error)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Proposed variable name to be normalized</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>normalizedName</strong></dt><dd>Normalized variable name when valid</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>error</strong></dt><dd>Validation error message when invalid</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True when the <strong>name</strong> can be normalized (together with <strong>normalizedName</strong> ) or false when the normalization failed (together with <strong>error</strong> )</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.normalizevariablename_system.string___1e8myh2" />  DmnVariableDefinition.NormalizeVariableName(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Normalize the variable name (trim, replace space with underscore and remove some special characters) and check that all characters are letters, digits or underscore and that the first character is letter



```csharp
public static string NormalizeVariableName(string name)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Proposed variable name to be normalized</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Normalized variable name</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd><strong>name</strong> is null or empty or invalid</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition.setrecognizedtype_system.type___1td9h71" />  DmnVariableDefinition.SetRecognizedType(Type) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Sources: engine\definition\DmnVariableDefinition.cs</small>


Sets the variable type if recognized later than constructed. When the type is already defined, the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception" target="_blank" >System.InvalidOperationException</a> is thrown



```csharp
public void SetRecognizedType(Type type)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd>New Type of variable</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


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


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.idmndefinition__81b50x" />  IDmnDefinition Interface ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\IDmnDefinition.cs</small>


DMN model definition for execution engine - encapsulates Decisions, Variables and Input data



```csharp
public interface IDmnDefinition : IDmnExtendable
```

Implemented by: [net.adamec.lib.common.dmn.engine.engine.definition.DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)           
Implements: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decisions](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmndefinition.decisions__10l9ock) | public abstract | Dictionary of available decisions by name | 
 | [InputData](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmndefinition.inputdata__98vjlt) | public abstract | Input data interface. Input data will be stored as Variables, complex objects are supported | 
 | [Variables](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmndefinition.variables__jjgze2) | public abstract | Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.idmndefinition.decisions__10l9ock" />  IDmnDefinition.Decisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmndefinition__81b50x)           
Sources: engine\definition\IDmnDefinition.cs</small>


Dictionary of available decisions by name



```csharp
public abstract IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> Decisions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.idmndefinition.inputdata__98vjlt" />  IDmnDefinition.InputData Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmndefinition__81b50x)           
Sources: engine\definition\IDmnDefinition.cs</small>


Input data interface. Input data will be stored as Variables, complex objects are supported



```csharp
public abstract IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> InputData { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.idmndefinition.variables__jjgze2" />  IDmnDefinition.Variables Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmndefinition__81b50x)           
Sources: engine\definition\IDmnDefinition.cs</small>


Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions



```csharp
public abstract IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> Variables { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement__1odpnhw" />  IDmnElement Interface ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\IDmnElement.cs</small>


Common properties for Decisions and Variables (also representing Input parameters)



```csharp
public interface IDmnElement : IDmnExtendable
```

Implemented by: [net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj), [net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6), [net.adamec.lib.common.dmn.engine.engine.decisions.expression.DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9), [net.adamec.lib.common.dmn.engine.engine.decisions.table.DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh), [net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88), [net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w)           
Implements: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Label](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement.label__h6tcbk) | public abstract | Label of the element | 
 | [Name](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement.name__1wmto3f) | public abstract | Name of the element | 
 | [NameWithLabel](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement.namewithlabel__qmuhj7) | public abstract | Name with label information in case [Label](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement.label__h6tcbk) is different than [Name](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement.name__1wmto3f) | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement.label__h6tcbk" />  IDmnElement.Label Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnElement](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement__1odpnhw)           
Sources: engine\definition\IDmnElement.cs</small>


Label of the element



```csharp
public abstract string Label { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement.name__1wmto3f" />  IDmnElement.Name Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnElement](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement__1odpnhw)           
Sources: engine\definition\IDmnElement.cs</small>


Name of the element



```csharp
public abstract string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement.namewithlabel__qmuhj7" />  IDmnElement.NameWithLabel Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnElement](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement__1odpnhw)           
Sources: engine\definition\IDmnElement.cs</small>


Name with label information in case [Label](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement.label__h6tcbk) is different than [Name](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement.name__1wmto3f)



```csharp
public abstract string NameWithLabel { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w" />  IDmnVariable Interface ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\IDmnVariable.cs</small>


Read only definition DMN model variable



```csharp
public interface IDmnVariable : IDmnElement
```

Implemented by: [net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)           
Implements: [net.adamec.lib.common.dmn.engine.engine.definition.IDmnElement](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement__1odpnhw), [net.adamec.lib.common.dmn.engine.engine.definition.extensions.IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [HasValueSetter](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable.hasvaluesetter__rjo8es) | public abstract | Flag whether the variable has any &quot;setter&quot; - is there any output to Variable or is Input parameter | 
 | [IsInputParameter](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable.isinputparameter__1benkdl) | public abstract | Flag whether the variable represents the input parameter of the decision model. Such variable will be read-only | 
 | [Type](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable.type__muymo2) | public abstract | Type of the variable when recognized from the decisions | 
 | [ValueSetters](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable.valuesetters__1rpx9) | public abstract | Information about value &quot;setters&quot; for the variable. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable.hasvaluesetter__rjo8es" />  IDmnVariable.HasValueSetter Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w)           
Sources: engine\definition\IDmnVariable.cs</small>


Flag whether the variable has any &quot;setter&quot; - is there any output to Variable or is Input parameter



```csharp
public abstract bool HasValueSetter { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable.isinputparameter__1benkdl" />  IDmnVariable.IsInputParameter Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w)           
Sources: engine\definition\IDmnVariable.cs</small>


Flag whether the variable represents the input parameter of the decision model. Such variable will be read-only



```csharp
public abstract bool IsInputParameter { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable.type__muymo2" />  IDmnVariable.Type Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w)           
Sources: engine\definition\IDmnVariable.cs</small>


Type of the variable when recognized from the decisions



```csharp
public abstract Type Type { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable.valuesetters__1rpx9" />  IDmnVariable.ValueSetters Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w)           
Sources: engine\definition\IDmnVariable.cs</small>


Information about value &quot;setters&quot; for the variable.



```csharp
public abstract IEnumerable<string> ValueSetters { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;string&gt;</a></dt><dd></dd></dl>


###  Remarks ###
Can be &quot;Input: {inputName}&quot;, &quot;Table Decision {decisionName}&quot; or &quot;Expression Decision {decisionName}&quot;.


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 




# DMN Engine #
DMN Engine is a rule engine allowing to execute and evaluate the decisions defined in a DMN  model. Its primary target is to evaluate the decision tables that transform the inputs into the output(s) using the decision rules. Simple expression decisions are also supported as well as the complex decision models containing set of dependent decisions (tables or expressions).
 
The DMN Model is defined using the adopted [standard](https://www.omg.org/spec/DMN/1.1/) XML file defined by OMG. Such definition can be designed for example using the [Camunda modeler](https://camunda.com/download/modeler/), keeping in mind the following principles how the file is parsed and the definition used in DMN Engine.

**NuGet package ID:** net.adamec.lib.common.dmn.engine

See the latest changes in [changelog](changelog.md)

### Quick start ###
The basic use case is:
1. Parse the DMN model from file.
2. Create and engine execution context and load (and validate) the model into engine context.
3. Provide the input parameter(s).
4. Execute (and evaluate) the decision and get the result(s).


```csharp
var def = DmnParser.Parse(fileName);
var ctx = DmnExecutionContextFactory.CreateExecutionContext(def);
ctx.WithInputParameter("input name", inputValue);
var result = ctx.ExecuteDecision("decision name");
```

DMN Engine usage flows are quite straightforward.

![DMN engine blocks](doc/img/blocks.png)

The decision model can be defined in DMN XML defined by OMG (version 1.1 or 1.3). The XML is parsed into `DmnModel` using `DmnParser.Parse`, `DmnParser.Parse13`, `DmnParser.ParseString` or `DmnParser.ParseString13` methods.

The DMN Model is to be further transfered to `DmnDefinition` using `DmnDefinitionFactory.CreateDmnDefinition`.
The alternative way of creating the DMN Definition is to use the `DmnDefinitionBuilder`. The builder provides fluent methods to prepare the definition and built it at the end using `DmnDefinitionBuilder.Build` method.

Once the DMN Definition is ready, it's to be provided to `DmnExecutionContextFactory.CreateExecutionContext` method to create the DMN execution context. (the `DmnExecutionContext` can be also created directly from `DmnModel` using the `DmnExecutionContextFactory.CreateExecutionContext` overload).

Provide the execution context with input parameters using `WithInputParameter` or `WithInputParameters` methods of context and call `DmnContext.ExecuteDecision` method to get the `DmnDecisionResult`.

*Note: The DMN definition is designed to be "virtually immutable" once created allowing the execution context (execution engine) to reference the definition and its parts without a need to take into a consideration the potential changes in the definition. The meaning of "virtually immutable" is that for sake of simplicity, sometimes the immutability is achieved just by using the read only interface (for example `IReadOnlyDictionary` hiding some of the methods of `Dictionary` or `IDmnVariable` hiding the methods of `DmnVariableDefinition`).*

### Build ###
The library uses the customized MS Build process in projects `build` and `build.tasks`. It's safe to remove such projects from solution if needed.
Details about the build process are described in [build documentation](build/readme.md).

### Tests ###
Tests are implemented using [MS Test Framework](https://github.com/microsoft/testfx) and provide also bunch of sample models that can help together with the test code to better understand how the DMN Engine works and is to be used. 

Note: adjust the `LogHome` variable in `nlog.config` of test project as you need.

The test code is in shared code project that is "linked" to test projects targetting different platforms (.net core 2.1, 3.1, 5; .net framework 4.6.2, 4.7.2).
`DmnTestBase` class provides abstraction allowing to simply apply the same tests using the different sources (DMN XML 1.1/1.3 or builders). 

The "primary" test class inherits from `DmnTestBase` and contains the test code and is set to test against DMN XML 1.1.

The test classes for DMN 1.3 inherits from "primary" test class and override the `Source` property to use the DMN 1.3, the tests themselves are just inherited, so no need to code them again. 

The builder based definition tests are prepared similar way - inherit from "primary" test class and set the `Source` to used the builders. `DmnBuilderSamples` class is generated from DMN XML files to provide the same decision model (DMN definition) but using the builders (Note: it might be useful to check this class to have a quick look how the builders work).



### Code Documentation ###
The [code documentation](doc/net.adamec.lib.common.dmn.engine.md) is generated during the customized build using [MarkupDoc](https://github.com/adamecr/MarkupDoc).


## DMN Decision Model ##
The DMN Model is actually set of inputs (parameters) and decisions.

![DMN digram](doc/img/dmn_diagram.png)

The DMN Model XML is parsed (deserialized) using the `DmnParser.Parse` method getting the `fileName` as input parameter and returning the `DmnModel` (deserialized XML) based on such decisions model XML definition. The DmnParser contains a very simple logic only, as its intention is just to deserialize the XML.
```csharp
model = DmnParser.Parse(fileName);
```

The XML model definition can also be provided as a `string` to `DmnParser.ParseString` method
```csharp
model = DmnParser.ParseString("xml string");
```
`DmnParser` uses the DMN XML v 1.1 by default. It can be overriden using the optional parameter `dmnVersion` when calling the parser. It can contain value `V1_1`(default) or `V1_3`(to support DMN XML version 1.3). The values are defined in `DmnVersionEnum`. Alternative way of using the DMN version 1.3 is to call methods `DmnParser.Parse13(fileName)` or `DmnParser.ParseString13("xml string")`.  

The `DmnModel` needs to be transformed to the `DmnDefinition` using the `DmnDefinitionFactory` that gets the DMN Model and executes "second level parsing" to prepare the DMN Model for the Engine. The most of the "parsing" and validation logic is here. `DmnDefinition` is then used to create the `DmnExecutionContext` allowing the execution/evaluation of the decisions based on the parameters provided.

```csharp
var model=DmnParser.Parse(file);
var definition= DmnDefinitionFactory.CreateDmnDefinition(model);
var ctx = DmnExecutionContextFactory.CreateExecutionContext(definition);
```

The `DmnModel` can be transformed directly to the `DmnExecutionContext` using the `DmnExecutionContextFactory` overload that gets the DMN Model and encapsulates Model-to-Definition transformation.

```csharp
var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse(file));
```

#### DMN Decision Model Builder ####
In some cases, it might be easier to define the decision model directly in the code, for example for simple "static" decision model definitions or in cases when the decision model definition needs to be created dynamically. In such cases, the `DmnDefinitionBuilder` takes place. It provides fluent interface methods to prepare the definition (see details in individual chapters later in this document) and the final method `Build` that will build the definition of the builder for the use in the execution context.

```csharp
var definition = new DmnDefinitionBuilder()
                 ....
                .Build();
var ctx = DmnExecutionContextFactory.CreateExecutionContext(definition);
```

### Inputs ###
![DMN digram](doc/img/dmn_input.png) Input represents an external data entering the Engine while evaluating the decision. You can think about it as it's the parameter of the decision to be made.

The input is defined in XML file using the `inputData` element and recognized by its unique name taken from `name` attribute (or from `id` attribute when the `name` attribute is missing. The `id` attribute is mandatory). 

```xml
<?xml version="1.0" encoding="UTF-8"?>
<definitions xmlns="http://www.omg.org/spec/DMN/20151101/dmn.xsd" xmlns:biodi="http://bpmn.io/schema/dmn/biodi/1.0" xmlns:camunda="http://camunda.org/schema/1.0/dmn" id="definitions_1k3ls5v" name="definitions" namespace="http://camunda.org/schema/1.0/dmn">
  <inputData id="InputData_1upwrsh" name="Age">
  </inputData>
</definitions>
```
The parser creates the variable used in Engine context allowing the Engine to access the input parameter. The variable is created with flag `IsInputParameter`, meaning that the Engine will not allow writing the values into such variable (inputs are immutable).

The input (parameter) is to be set to Engine context before evaluating the decision. If not set, its value will be `null`, which might be OK in case the model takes this into the consideration.
*Note: The value type variables without value are translated to default value, so for example `int` variable will not be `null` but will be set to `0` when the first expression is evaluated (even if the variable is not used in there!).*    
```csharp
ctx.WithInputParameter("input name", inputValue);
``` 
*Note: Inputs by default don't define the data type. The parser tries to recognize the type when "back-tracking" the dependency tree from Decision Table inputs that can define the data type.*

When using the builder, it provides several overloads of `WithInput` method alloving to define the inputs that can be used in the decisions.

```csharp
var def = new DmnDefinitionBuilder()
  .WithInput<int>("input1")
  .WithInput<int>("input2", out var inputVariable2Ref)
  .WithInput("input2", typeof(string))
  .WithInput("input4", typeof(string), out var inputVariable4Ref)
  .WithInputs<string>("input5", "input6")
   ...
  .Build();
```

Although the builder also allows to create the input without specifiyng the variable type (as in XML), it's recommended to always use the typed inputs within the builders to prevent some potentionaly unexpected behavior during the execution.


### Decisions ###
![DMN digram](doc/img/dmn_decision.png) Decision represents an entity the Engine can evaluate and provide the required output(s).

The decision is defined in XML file using the `decision` element and recognized by its unique name taken from `name` attribute (or from `id` attribute when the `name` attribute is missing. The `id` attribute is mandatory). 

```xml
<?xml version="1.0" encoding="UTF-8"?>
<definitions xmlns="http://www.omg.org/spec/DMN/20151101/dmn.xsd" xmlns:biodi="http://bpmn.io/schema/dmn/biodi/1.0" xmlns:camunda="http://camunda.org/schema/1.0/dmn" id="definitions_1k3ls5v" name="definitions" namespace="http://camunda.org/schema/1.0/dmn">
  <decision id="mainDt" name="MainDT">
  </decision>
</definitions>

```


The name of the decision is used to execute its evaluation
```csharp
result = ctx.ExecuteDecision("decision name");
```
The Engine supports the following decision types
- ![DMN digram](doc/img/dmn_decision_expression.png) Expression Decisions that evaluate the defined expression and output the result into defined output variable
- ![DMN digram](doc/img/dmn_decision_table.png) Decision Tables that evaluate set of decision rules and provide matching output(s) 

The builder provides two methods `WithExpressionDecision` and `WithTableDecision` to define the decisions. We will get to the details in the chapters related to expression decisions and decision tables.

```csharp
var definition = new DmnDefinitionBuilder()
  .WithInput<int>("input1")
  .WithVariable<bool>("variable1", out var variable1)
  .WithVariable<string>("variable2", out var variable2)
  .WithExpressionDecision("exprDecision", "input1>3", variable1)
  .WithTableDecision("tableDecision", table=>
    table
      .WithInput(variable1,out var tblInputRef)
      .WithOutput(variable2,out var tblOutputRef)
      .WithRule("rule 1",r=>r
         .When(tblInputRef,"true")
         .Then(tblOutputRef,@"""T"""))
      .WithRule("rule 2", r=>r
         .Always()
         .Then(tblOutputRef,@"""F""")))
  .Build();
```

#### Dependency Tree ####
When the model is parsed, the parser builds the dependency tree based on the information requirement connector. The decision can depend on zero or more inputs and on zero or more other decisions. When parsing the decision, the parser creates the full dependency tree of required decisions that need to be evaluated before (in proper order).
![DMN digram](doc/img/dmn_dependency.png)

Required inputs actually don't define the "hard dependency", meaning they are not checked during the execution for the existence of value (not being null). Definition of the required inputs is rather to describe the connection between the input and the decision for the information or better understanding of the whole decision model

The dependency is stored in XML within the `informationRequirement` element that can be `requiredInput` or `requiredDecision`. Both types must have the `href` attribute referencing the proper input or decision by their id (with "#" prefix). 
*Note: Exactly one of the sub elements (`requiredDecision` or `requiredInput`) must be present within the `informationRequirement` element.*
```xml
<decision id="mainDt" name="MainDT">
    <informationRequirement>
      <requiredDecision href="#doubleAge" />
    </informationRequirement>
    <informationRequirement>
      <requiredInput href="#InputData_1" />
    </informationRequirement>
</decision>

<decision id="doubleAge" name="Double (Age+10)">
</decision>
<inputData id="InputData_1" name="Age">
</inputData>
```

Builders for decisions provide two overloads of `Require` method allowing to define the required input(s) and/or decision(s).

```csharp
var def = new DmnDefinitionBuilder()
  .WithInput<int>("input1", out var input1Ref)
  .WithInput<int>("input2", out var input2Ref)
  .WithVariable<bool>("variable1", out var variable1Ref)
  .WithVariable<bool>("variable2", out var variable2Ref)
  .WithExpressionDecision("eDecision1", "input1>3",variable1Ref,out var eDecision1Ref)
  .WithExpressionDecision("eDecision2", eDecision =>
    eDecision
      .Put("variable1 && input2=='ahoy'").To(variable2Ref)
      .Requires(input2Ref)
      .Requires(eDecision1Ref),out var eDecision2Ref)
  .WithTableDecision("tDecision1", table=>
    table
      .WithInput(input1Ref,out var tableInput1Ref)
      .WithInput(variable2Ref,out var tableInput2Ref)
      .WithOutput(variable2Ref,out var tableOutput)
      .WithRule("Rule1",r=>r.When(tableInput1Ref, ">6").And(tableInput2Ref,"true").Then(tableOutput,"ABC"))
      .WithRule("Rule2", r => r.Always().Then(tableOutput, "DEF"))
      .Requires(input1Ref)
      .Requires(eDecision2Ref))
  .Build();
```

The decision is executed and evaluated by Engine using the method `ctx.ExecuteDecision`.
```csharp
result = ctx.ExecuteDecision("decision name");
```
The Engine checks for the decision dependencies and when any decision needs to be evaluated before (required decision), the Engine evaluates such decision. This is done recursively, so the complex dependencies can be defined.
*Note: The Engine doesn't check for the circular dependencies, so the execution of model will fail with `StackOverflowException` in such cases.*

## Variables in Decision Model ##
As mentioned above, the inputs are one kind of variables existing in the Engine context. The variables allow sharing the data between the model elements. When the decision is evaluated, it gets some information at the input and produces the outputs. The outputs are also stored into the variables, so they can be used as inputs for another decisions.

The Engine uses the [Dynamic Expresso](https://github.com/davideicardi/DynamicExpresso) interpreter and the full set of variables is provided to the interpreter while evaluating any of the expressions within the Engine, so they can be recognized in expressions.*Note: Technically, the variables are provided as parameters, so it's possible to parse the expression once and invoke it with the real values when needed - DMN Engine implements the parsed expressions cache.*

```csharp
var parameters = new List<Parameter>();
foreach (var variable in Variables.Values)
{
	//check null variable for value type
	var varValue = variable.Value ?? variable.Type?.GetDefaultValue();

	var parameter = new Parameter(variable.Name, variable.Type ?? varValue?.GetType() ?? typeof(object), varValue);
	parameters.Add(parameter);
}

parsedExpression = interpreter.Parse(expression, outputType, parameters.ToArray());
var result = parsedExpression.Invoke(parameters.ToArray());
}
```

The Engine context keeps the list of variables as triplets:
- `Name` - name of the variable that is used as a reference as well as the name of the variable for the expression interpreter. The variable names are "normalized" (`name.Trim().Replace(' ', '_')`), so it might cause the un-intentional duplicity if not taken into the consideration 
- `Type` - the variable values are stored within the Engine context as `object`, however, it provides some support for the data types. It's possible to define the data type in some parts of model - output variable for the expression decision, inputs and outputs for decision tables. The XML parser sets the type of variable at the first place where known and then checks that the data type is the same if set somwhere else. The definition builder for variable requires the type to be specified. When the variable value is set during the execution and the type is known, the Engine tries to cast (`Convert.ChangeType(value, Type)`) the value to required type. 
- `Value` - current value of the variable. When provided to the expression interpreter, the value type (non-nullable) variables are set to default value of the value type when the current value stored within the context is null

When using the DMN XML, the variables are defined during the processing the XML based on:
 - Decision model inputs
 - Output variables for expression decisions
 - Inputs of decision tables bound to variable
 - Outputs variables for decision tables 

When using the builders, the variables must be explicitly defined. When the variable is to be used in builder, get the variable reference from the variable builder and use it in other builders.

```csharp
var def = new DmnDefinitionBuilder()
  .WithVariable<bool>("variable1", out var variable1Ref)
  .WithVariable("variable2",typeof(string), out var variable2Ref)
  .Build();
```

*Note: The expressions are not parsed/analyzed when the definition is being prepared, so there is no kind of detection/validation of the variables within the expressions*
 

### Data Types for Variables ###
When the data type is defined in DMN model (attribute `typeRef`), the parser maps the types to the .NET types using the function below
```csharp
private static Type ParseTypeName(string typeName)
{
   typeName = typeName.ToLower();
   switch (typeName)
   {
     case "string": return typeof(string);
     case "boolean": return typeof(bool);
     case "integer": return typeof(int);
     case "long": return typeof(long);
     case "double": return typeof(double);
     case "date": return typeof(DateTime);
     default: throw Logger.Fatal<DmnParserException>( $"Unsupported type name {typeName}");
   }
}
```
Besides the defined data types, the Engine actually supports any .NET type known while evaluating the expressions, it's just not possible to explicitly define such data type for the variables in DMN Model.
For example, let's have following model

![DMN digram](doc/img/dmn_complexObjects.png)

Input parameter `dyna` is complex object
```csharp
var dyna = new { Name = "name", IsOk = true, Direct="some value" };
ctx.WithInputParameter("dyna", dyna);
```
It can be simply used in expression decision, however the output is mapped to variable of "standard" type
![DMN digram](doc/img/dmn_complexObjectExpr.png)

When used in decision tables, the complex objects can be used as inputs as well as in rules for input/output expressions. Once again, the output is mapped to variable of "standard" type. The XML syntax is described below at Decision Tables chapter.
![DMN digram](doc/img/dmn_complexObjectTable.png)

## Expressions in Decision Model ##
As mentioned above, the Engine uses the [Dynamic Expresso](https://github.com/davideicardi/DynamicExpresso) interpreter, so the expression syntax must comply with the interpreter, on the other side, it brings quite a flexibility into the rule definition.
- All Engine context variables are provided to the interpreter (see above)
- The expressions in Expression decisions are evaluated and assigned to the output variable
- The expressions in Decision tables input parameter definitions are evaluated to get the "left side" of rule comparison (each input/column within the rule is evaluated separately)
- The expressions in Decision table rule inputs are evaluated as the "operator and the right side" of rule comparison.
- The expressions in Decision table rule outputs are evaluated and assigned to the output variable

S-FEEL expressions subset is supported for Decision table rule input conditions. S-FEEL expressions are translated to expressions using `SfeelParser`.
- `not(expression)` - negates the condition. The `expression` can be S-FEEL expression as well
- list of values (`expr1,expr2,exprN`) - the `expr` can be number constant, string constant (in quotation marks), variable name
- simple comparators - `<`,`>`,`<=`,`>=`
- ranges - `[from..to]`. `[..]` means inclusive, `(..)` or `]..[` is exclusive. Start and end inclusive/exclusive markers can be different - for example `(..]`

Some of the S-FEEL functions are injected to Dynamic Expresso interpreter as custom functions, so they can be used within the expression:
- `date` - returns the `DateTime` from `string` in format `yyyy-MM-dd`
- `date and time` - returns the `DateTime` from `string` in format `yyyy-MM-ddTHH:mm:sszzzzzz`, `yyyy-MM-ddTHH:mm:ss`, `yyyy-MM-ddTHH:mm`. As the function name contains spaces, it's internally translated to `date_and_time`
- `time` - returns the `DateTime` from `string` in format `HH:mm:sszzzzzz`, `HH:mm:ss`, `HH:mm`. The date part is current date.
- `duration` - returns the `TimeSpan` from `string` in [ISO 8601 durations format](https://en.wikipedia.org/wiki/ISO_8601#Durations "ISO 8601")

## Expression Decisions ##
Expression decision evaluates the expression and stores the returned value in output variable.
![DMN digram](doc/img/dmn_complexObjectExpr.png)

The expression is in `text` element of the `literalExpression` child of the `decision` element in DMN XML.
The output variable is identified by `name` (or `id` if `name` is missing) attribute. The data type is defined in `typeRef` attribute and is used to specify/cross-check the variable data type (casting is not supported).
  
```xml
  <decision id="D1" name="IsOk">
    <variable id="var1" name="b" typeRef="boolean" />
    <informationRequirement>
      <requiredInput href="#InputData1" />
    </informationRequirement>
    <literalExpression id="expr1">
      <text>dyna.IsOk</text>
    </literalExpression>
  </decision>
```

The builder provides several overloads of method `WithExpressionDecision` allowing to define the expression decision. The simplest one is just to define the decision name, expression and the reference to the output variable. It's also possible to get the reference to the expression decision using the other overload.
The more complex way is using the expression decision builder with methods `Put` for the definition of the expression and `To` to define the output variable. This allows using the `Required` methods when needed. This way also have an overload with the output of the reference to the expression decision defined.

```csharp
var expressionDecisionDefinition1 = new DmnDefinitionBuilder()
  .WithInput<int>("input1")
  .WithVariable<bool>("outputVariableE1", out var outputVariableE1)
  .WithExpressionDecision("eDecision1", "input1>3", outputVariableE1)
  .Build();

var expressionDecisionDefinition2 = new DmnDefinitionBuilder()
  .WithInput<int>("input1")
  .WithVariable<bool>("outputVariableE2", out var outputVariableE2)
  .WithExpressionDecision("eDecision2", "input1>3", outputVariableE2, out var eDecision2)
  .Build();

var expressionDecisionDefinition3 = new DmnDefinitionBuilder()
  .WithInput<int>("input1", out var input1Variable)
  .WithVariable<bool>("outputVariableE3", out var outputVariableE3)
  .WithExpressionDecision("eDecision3",
     eDecision => eDecision.Put("input1>3").To(outputVariableE3))
  .Build();

var expressionDecisionDefinition4 = new DmnDefinitionBuilder()
  .WithInput<int>("input1")
  .WithVariable<bool>("outputVariableE4", out var outputVariableE4)
  .WithExpressionDecision("eDecision4",
     eDecision => eDecision.Put("input1>3").To(outputVariableE4),
     out var eDecision4)
  .Build();

var expressionDecisionDefinition5 = new DmnDefinitionBuilder()
  .WithInput<int>("input1", out var input1E5)
  .WithVariable<string>("someVariableE5", out var someVariableE5)
  .WithVariable<bool>("outputVariableE5", out var outputVariableE5)
  .WithExpressionDecision("eDecision5A",
     eDecision => eDecision.Put("input1>3").To(outputVariableE5),
     out var eDecision5A)
  .WithExpressionDecision("eDecision5b", eDecision =>
     eDecision
       .Put("outputVariableE5 && someVariableE5=='ahoy'").To(outputVariableE5)
       .Requires(input1E5)
       .Requires(eDecision5A))
  .Build();
```

## Decision Tables ##
Decision table defines the set of rules - "when the input values matches all input conditions, provide defined outputs".
![DMN digram](doc/img/dmn_table_parts.png)
Input and output definitions (declarations) are common for all rules and define the columns used in decision table.
**Decision table input** means that there will be an input data of given type that are to be evaluated using the rule input expression. Decision table input also defines, where to get the input data - from variable (variable input) or by evaluating the expression (expression input). 
*Note:The expression input expressions are evaluated for each rule.*
There are three table inputs in the example above:
- Variable input mapped to variable `a` of type `string`
- Variable input mapped to variable `b` of type `boolean` (`bool`)
- Expression input with expression `dyna.Direct` evaluated to `string`.

**Decision table output** means that Engine will provide the output for rules with positive match and store them into defined variables with given type.
There are two table outputs in the example above:
- Output mapped to variable `res` of type `string`
- Output mapped to variable `amount` of type `integer`

*Note: The mapping to the variables (persistence) is done after all rules are evaluated and the single or multiple rules with positive match are selected by Hit policy. Although it's possible to manipulate the output mapped variables within the rule expression, it's strongly recommended not to do so.* 

**Rule** is the set of input and output expressions.
The **Rule input expression** defines kind of condition that the input data must meet to make the rule the positive match. It's possible to omit the rule input expression, meaning that the related table input will not be evaluated for such rule.
There will be following conditions used when evaluating the decision table above

- Rule 1 - will be evaluated as positive, if all following conditions are valid (true)
  - `a=="a"` - value of string variable `a` is constant `a`.
  - `b==true` - value of bool variable `b` is `true`
  - `!(dyna.Direct=="over")` - result of expression `dyna.Direct` is not the constant `over`
- Rule 2 - will be evaluated as positive, if all following conditions are valid (true)
  - `b==false` - value of bool variable `b` is `false`
  - `dyna.Direct=="over"` - result of expression `dyna.Direct` is the constant `over`

Actually, it's possible to omit all input expressions, so the rule will be always evaluated as positive match. 
 
The **Rule output expression** defines the data that the Engine will store to defined output variables (and return). It's always handled as the expression even if returning the constant.
There are following outputs for the rules of the decision table above

- Rule 1 - will produce following outputs
  - `a+(b!=null?b.ToString():"")+dyna.Direct` - concatenated string of value of variable `a`, value of variable `b` and value of `Direct` property of object (variable) `dyna`. This concatenated string will be stored to variable `res`.
  - `50` - integer constant `50` will be store to variable `amount`.
- Rule 2 - will produce following output
  - `"dyna.Direct==over"` - string constant `dyna.Direct==over` will be stored to variable `res`.
  
It's possible to omit one or more (all) output expressions. In this case the Engine will just not produce the output value (so the output variable will NOT be "cleaned" or set to `null`).

### Inputs in XML ###
The decision table in the example above will have following inputs in the XML definition
```xml    
<decisionTable>
  <input id="InputClause1" label="a">
    <inputExpression id="e1" typeRef="string" />
  </input>
  <input id="InputClause2" label="b">
    <inputExpression id="e2" typeRef="boolean" />
  </input>
  <input id="InputClause3" label="">
    <inputExpression id="e3" typeRef="string">
      <text>dyna.Direct</text>
    </inputExpression>
  </input>
</decisionTable>
```

As you can see, if there is no value in `text` element of the `inputExpression`, the table input is *variable input* mapped to the variable with name defined in `label` attribute of `input` element. If the `label` attribute is missing, the `id` attribute will be used instead to get the name of the input variable. The data type defined in `typeRef` attribute is used to specify/cross-check the variable data type (casting is not supported)

Whenever the `text` element of the `inputExpression` is not empty, the table input is *expression input* and the expression within the `text` element will be evaluated as described above. Type specified in `typeRef` is ignored (not used at all) for the expression inputs.

### Inputs in Builder ###
`TableDecision` builder provides methods `WithInput` for table input definition. The input can be either directly bound to the model variable/input (*variable input*) or the expression can be used to get the input value  (*expression input*)

```csharp
var definition = new DmnDefinitionBuilder()
  .WithInput<int>("modelInput1", out var modelInput1Ref)
  .WithVariable<string>("variable1", out var variable1Ref)
  .WithTableDecision("tableDecision", table =>
    table
      .WithInput(modelInput1Ref, out var tableInput1)
      .WithInput(variable1Ref, out var tableInput2, "a", "b")
      .WithInput(@"modelInput1.ToString()+""<""", out var tableInput3)
      .WithInput("variable1.ToString()[0]", out var tableInput4, "1", "2", "3", "4")
      .WithOutput(variable1Ref,out var tableOutputRef)
      .WithRule("rule1", r => r
         .When(tableInput1, "(2..5[")
         .Then(tableOutputRef, "it's 2 to 5"))
    )
  .Build();
```

### Outputs in XML ###
The decision table in the example above will have following outputs in the XML definition
```xml  
<decisionTable>
  <output id="output_1" label="res" name="" typeRef="string" />
  <output id="output_2" label="amount" typeRef="integer" />
</decisionTable>
```
The output definition XML is quite simple, it just defines the name of the output variable within the attribute `label` (or `id` if `label` is missing) and the required variable. Data type is defined in `typeRef` attribute and is used to specify/cross-check the variable data type (casting is not supported).

### Outputs in Builder ###
`TableDecision` builder provides method `WithOutput` for table output definition. It takes a reference to the output variable and provided the reference to the table output to be used in rules. Allowed values (see later in this document) can be provided when needed.

```csharp
var definition = new DmnDefinitionBuilder()
  .WithInput<int>("modelInput1", out var modelInput1Ref)
  .WithVariable<int>("variable1", out var variable1Ref)
  .WithVariable<bool>("variable2", out var variable2Ref)
  .WithTableDecision("tableDecision", table =>
     table
       .WithInput(modelInput1Ref, out var tableInput1)
       .WithOutput(variable1Ref, out var tableOutput1Ref,"1","2","3")
       .WithOutput(variable2Ref, out var tableOutput2Ref)
       .WithRule("t1Rule1", r => r
          .When(tableInput1, "(2..5[")
          .Then(tableOutput1Ref, "1")
          .And(tableOutput2Ref,"true"))
     )
  .Build();
```

### Rules in XML ###
The decision table in the example above will have following rules in the XML definition
```xml  
<decisionTable>
  <rule id="row1">
    <description>some rule</description>

    <inputEntry id="id1">
      <text><![CDATA["a"]]></text>
    </inputEntry>
    <inputEntry id="id2">
      <text>true</text>
    </inputEntry>
    <inputEntry id="id3">
      <text><![CDATA[not("over")]]></text>
    </inputEntry>
    
    <outputEntry id="id4">
      <text><![CDATA[a+(b!=null?b.ToString():"")+dyna.Direct]]></text>
    </outputEntry>
    <outputEntry id="id5">
      <text>50</text>
    </outputEntry>
  </rule>

  <rule id="row2">
    <inputEntry id="id6">
      <text></text>
    </inputEntry>
    <inputEntry id="id7">
      <text>false</text>
    </inputEntry>
    <inputEntry id="id8">
      <text><![CDATA["over"]]></text>
    </inputEntry>
  
    <outputEntry id="id9">
      <text><![CDATA["dyna.Direct==over"]]></text>
    </outputEntry>
    <outputEntry id="id10">
      <text></text>
    </outputEntry>
  </rule>
</decisionTable>
```
The rule input expressions are defined using the `inputEntry` elements. **Their count and order must match the table input definitions** (there is no other way of pairing). The `text` sub-element of `inputEntry` defines the rule input expression. If the `text` element is empty or contains constant `-` (dash) the input will be omitted in rule evaluation.

The rule output expressions are defined using the `outputEntry` elements. **Their count and order must match the table output definitions** (there is no other way of pairing). The `text` sub-element of `outputEntry` defines the rule output expression. If the `text` element is empty or contains constant `-` (dash) the output will be omitted (not produced) during the decision table evaluation.

The optional rule annotation is stored in element `description`. 

### Rules in Builder ###
`TableDecision` builder provides method `WithRule` for table rule definition. It takes a mandatory table-unique rule name and optional description and provides the rule builder to define the input conditions and output calculations.

The input condition is defined as a pair of table input reference and the rule input expression. The first condition (doesn't need to be related to the first input) is defined using `When` method and additional ones can be added using `And` method(s). Use `Always` to skip the rule input definition (rule will be always evaluated as positive hit).

The output calculation is defined as a pair of table output reference and the rule output expression. The first output calc expression (doesn't need to be related to the output input) is defined using `Then` method and additional ones can be added using `And` method(s). Use `SkipOutput` to skip the rule output definition (rule will produce no output).

Some examples:

```csharp
var definition = new DmnDefinitionBuilder()
  .WithInput<int>("input1", out var inputVar1Ref)
  .WithInput<bool>("input2", out var inputVar2Ref)
  .WithVariable<string>("output1", out var outputVar1Ref)
  .WithVariable<int>("output2", out var outputVar2Ref)
  .WithVariable<bool>("output3", out var outputVar3Ref)
  .WithTableDecision("tDecision1", table =>
     table
       .WithInput(inputVar1Ref, out var tableInput1Ref)
       .WithInput(inputVar2Ref, out var tableInput2Ref)
       .WithInput("input2.ToString()[0]", out var tableInput3Ref)
       .WithOutput(outputVar1Ref, out var tableOutput1Ref)
       .WithOutput(outputVar2Ref, out var tableOutput2Ref)
       .WithOutput(outputVar3Ref, out var tableOutput3Ref)
       
       .WithRule("rule1", r => r
          .When(tableInput1Ref, "1")
          .Then(tableOutput1Ref, "\"a\""))
       .WithRule("rule2", r => r
          .When(tableInput1Ref, "11")
          .And(tableInput2Ref, "false")
          .Then(tableOutput2Ref, "111"))
       .WithRule("rule3", r => r
          .When(tableInput1Ref, "2")
          .And(tableInput2Ref, "true")
          .Then(tableOutput2Ref, "2")
          .And(tableOutput1Ref, "\"b\"")
          .And(tableOutput3Ref, "false"))
       .WithRule("rule4", "some rule description", r => r
          .When(tableInput1Ref, "33")
          .And(tableInput2Ref, "false")
          .And(tableInput3Ref, "\"t\"")
          .Then(tableOutput1Ref, "\"three\""))
       .WithRule("rule5", r => r
          .When(tableInput1Ref, "4")
          .Then(tableOutput1Ref, "\"four\"")
          .And(tableOutput2Ref, "4")
          .And(tableOutput3Ref, "true"))
       .WithRule("rule5", r => r
          .Always()
          .Then(tableOutput3Ref, "false"))
       .WithRule("rule6", r => r
          .Always()
          .Then(tableOutput1Ref, "\"six\"")
          .And(tableOutput2Ref, "66"))
       .WithRule("rule7", r => r
          .Always()
          .Then(tableOutput1Ref, "\"7\"")
          .And(tableOutput3Ref, "true"))
       .WithRule("rule8", r => r
          .When(tableInput2Ref, "false")
          .SkipOutput())
       .WithRule("rule9", r => r
          .When(tableInput1Ref, "9")
          .And(tableInput2Ref, "true")
          .SkipOutput())
       .WithRule("rule10", r => r
          .Always()
          .SkipOutput())
    )
 .Build();
```

### Allowed Values Constraints ###
It's possible to define the constraints for input a/or output values. When the constraint is defined and there is no match, the exception is thrown during the execution. The output allowed values might be also needed for the hit policy (see next chapter for details)

The input allowed values are checked when evaluating the rules (for each rule and for each input defined for the rule). When the input defines the constraint, it gets the variable value as string for the variable inputs or evaluates the input expression and converts the result to string for the expression inputs. Then it's checked against the list of allowed values for the input.
If the table input is not used for the particular rule, the allowed values for that particular input are not checked for that rule.

The output allowed values are checked when processing the rules with positive hit (for each positive hit rule and for each output). The output result is calculated by evaluating the output expression (that's the way of calculating the output result). When the output defines the constraint, the result is converted to string and the string value is checked against the list of allowed values for the output.


The DMN XML defines the constraints as optional `inputValues` or `outputValues` child elements for input/output.
```xml  
<decisionTable>
  <input id="InputClause1" label="a">
    <inputExpression id="e1" typeRef="string" />
    <inputValues id="c1">
       <text><![CDATA["a","b","c"]]></text>
    </inputValues>
  </input>

  <output id="output_1" label="res" name="" typeRef="string">
    <outputValues id="c2">
       <text><![CDATA["a","b","c"]]></text>
    </outputValues>
  </output>
</decisionTable>
```

The table decision builder has the overloads for `WithInput` and `WithOutput` methods allowing the provide the set of allowed values for the input/output (it's the method parameter marked with `params` keyword).

```csharp
var definition = new DmnDefinitionBuilder()
  .WithInput<int>("modelInput1", out var modelInput1Ref)
  .WithVariable<string>("variable1", out var variable1Ref)
  .WithTableDecision("tableDecision", table =>
    table
      .WithInput(modelInput1Ref, out var tableInput1, "10", "20")
      .WithInput(variable1Ref, out var tableInput2, "a", "b")
      .WithInput(@"modelInput1.ToString()+""<""", out var tableInput3,"10<","20<")
      .WithInput("variable1.ToString()[0]", out var tableInput4, "1", "2", "3", "4")
      .WithOutput(variable1Ref,out var tableOutputRef,"s10","s20","s30")
      .WithRule("rule1", r => r
         .When(tableInput1, "10")
         .Then(tableOutputRef, "s10"))
    )
  .Build();
```



### Hit Policy ###
Decision Table hit policy specifies what the result of the decision table is in cases of overlapping rules, i.e. when more than one rule matches the input data.

Following single-hit policies are supported
- **Unique** - No overlap is possible and all rules are disjoint. Only a single rule can be matched. Overlapping rules represent an error.
- **First** - Multiple (overlapping) rules can match, with different output entries. The first hit by rule order is returned.
- **Priority** - Multiple rules can match, with different output entries. This policy returns the matching rule with the highest output priority. Output priorities are specified in the ordered list of allowed output values, in decreasing order of priority. Note that priorities are independent from rule sequence.A Priority table that omits allowed output values is an error.
- **Any** - There may be overlap, but all of the matching rules show equal output entries for each output, so any match can be used. If the output entries are non-equal, the hit policy is incorrect and the result is an error.

Following multiple-hit policies are supported
- **Collect** - Multiple rules can be satisfied.
	- If there is not aggregator or aggregator is `LIST`, the decision table result contains the output of all satisfied rules in an arbitrary order as a list.
	- If the Collect hit policy is used with an aggregator (other than `List`), the decision table can only have single output.The aggregator will generate the output entry from all satisfied rules.
	- Except for C-count and C-list, the rules must have numeric or boolean output values.
	- COUNT aggregator for string stores the counted value (number) as a string into the output variable
	- Boolean output values are valid for SUM, MIN and MAX aggregator
		- SUM and MAX return true if there is at lease one true result
		- MIN returns false if there is at least one false result. 
	

- **RuleOrder** - Multiple rules can be satisfied. The decision table result contains the output of all satisfied rules in the order of the rules in the decision table.
- **OutputOrder** - Returns all hits in decreasing output priority order. Output priorities are specified in the ordered list of output values in decreasing order of priority

*Note: The multiple-hit policy decision table returns full set of outputs, however the output variables are set to the values corresponding to the **last** (ordered) positive rule. Take this into the consideration when mapping the output of the multiple-hit policy decision table as the input for another decision*

Decision tables with compound outputs support only the following hit policies: Unique, Any, Priority, First, Output order, Rule order and Collect without operator, because the collect operator is undefined over multiple outputs.
 
For the Priority and Output order hit policies, priority is decided in compound output tables over all the outputs for which output values have been provided.The priority for each output is specified in the ordered list of output values in decreasing order of priority, and the overall priority is established by considering the ordered outputs from left to right. Outputs for which no output values are provided are not taken into account in the ordering, although their output entries are included in the ordered compound output.

DMN XML defines the hit policy and aggregation at the attributes of `decisionTable`.
```xml
<decisionTable hitPolicy="FIRST">
</decisionTable>
```

```xml
<decisionTable hitPolicy="COLLECT" aggregation="SUM">
</decisionTable>
```

```csharp
var definition = new DmnDefinitionBuilder()
  .WithTableDecision("tDecision1", table =>
     table
       .WithHitPolicy(HitPolicyEnum.Collect))
  .Build();
```

The table builder provides `WithHitPolicy` and `WithAggregation` methods.

```csharp
var definition = new DmnDefinitionBuilder()
  .WithTableDecision("tDecision1", table =>
     table
       .WithHitPolicy(HitPolicyEnum.Collect)
       .WithAggregation(CollectHitPolicyAggregationEnum.Sum))
  .Build();
```

## Decision results ##
The decision results are returned as `DmnDecisionResult` object. In general, there can be zero, one or multiple results.
- When there are none (zero) results, `DmnDecisionResult.HasResult` is `false`
- When there is single (one) result, `IsSingleResult` is `true` (`DmnDecisionResult.HasResult` is `true`)
- When there are multiple results, `DmnDecisionResult.HasResult` is `true` and  `IsSingleResult` is `false`.

The results are accessible using  `DmnDecisionResult.Results` list. The first (single) result can be retrieved using `DmnDecisionResult.First` method.

Each result is of type `DmnDecisionSingleResult` containing the list of output `Variables` where each variable has `Name`, `Value` and `Type` (when the output variable type is know). The variable can be retrieved using name-based indexed (for example `result.First["output1"]` to get the output variable named "output1" or `result.First["output1"].Value` to get the value of such variable).

When the result comes from the decision table, it also provides the `HitRules` - list of rules (`DmnDecisionTableRule`) that had a positive hit (according to the evaluation and the hit policy) when the table has been evaluated (simple meaning - the list of rules that have been used to decide). *Thanks [Noel](https://github.com/nlysaght) for contribution.*

There is a kind of a "shortcut" to the variables for the single result - `DmnDecisionResult.FirstResultVariables` returns the list of variables of the first result (the only one for the single result).

## Execution Context Options ##
When creating the execution context, it's possible to override the execution options when needed.

```csharp
var ctx = DmnExecutionContextFactory.CreateExecutionContext(def, configure =>
  {
    configure.EvaluateTableOutputsInParallel = true;
    configure.EvaluateTableRulesInParallel = true;
    configure.RecordSnapshots = true;
  });
```
`EvaluateTableRulesInParallel` is a flag whether to evaluate the table rules in parallel (true by default) or in sequence and `EvaluateTableOutputsInParallel` is a flag whether to evaluate the table outputs for positive rules in parallel (false by default) or in sequence. These flags can be used for performance fine tuning of the processing of the decision tables when needed.
*Note: Honestly, I didn't find the settings that will have conclusive results in general, so you can try to tweak the settings based on your decision tables and see what (and if) will bring better performance in each particular case.*

`RecordSnaphots`, when on, can be used for auditing/tracking of the processing or even for debugging of the decisions when needed. It creates a context snapshot when `ctx.ExecuteDecision` is called to store the initial state (input parameters and variable "defaults"). This is snapshot with `Step=0`. Then a snapshot is created after each decision evaluation (one if there is not depencency, multiple when there are some decisions that needed to be evaluated first.). So the last snapshot relates to the decision referenced in `ExecuteDecision` for which the decision result is returned.

The snapshots (`DmnExecutionSnapshots`) are avalable from execution context (`ctx.Snapshots`) providing the access to the `Last` snapshot and/or to all `Snapshots`.
Each snapshot (`DmnExecutionSnapshot`) contains the step (sequence number), clone of all execution variables in execution context (with values corresponding to the time of snapshot creating) and `DecisionName`, `Decision` and `DecisionResult` for the snapshots created after decision execution.


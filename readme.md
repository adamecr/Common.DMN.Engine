# DMN Engine #
DMN Engine is a rule engine allowing to execute and evaluate the decisions defined in a DMN  model. Its primary target is to evaluate the decision tables that transform the inputs into the output(s) using the decision rules. Simple expression decisions are also supported as well as the complex decision models containing set of dependent decisions (tables or expressions).
 
The DMN Model is defined using the adopted [standard](https://www.omg.org/spec/DMN/1.1/) XML file defined by OMG. Such definition can be designed for example using the [Camunda modeler](https://camunda.com/download/modeler/), keeping in mind the following principles how the file is parsed and the definition used in DMN Engine.

**NuGet package ID:** net.adamec.lib.common.dmn.engine

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
### Build ###
The library uses the customized MS Build process in projects `build` and `build.tasks`. It's safe to remove such projects from solution if needed.
Details about the build process are described in [build documentation](build/readme.md).

### Tests ###
Tests are implemented using [MS Test Framework](https://github.com/microsoft/testfx) and provide also bunch of sample models that can help together with the test code to better understand how the DMN Engine works and is to be used. 

Note: adjust the `LogHome` variable in `nlog.config` of test project as you need.

### Code Documentation ###
The [code documentation](doc/net.adamec.lib.common.dmn.engine.md) is generated during the customized build using [MarkupDoc](https://github.com/adamecr/MarkupDoc).


## DMN Decision Model ##
The DMN Model is actually set of inputs (parameters) and decisions.

![DMN digram](doc/img/dmn_diagram.png)

The DMN Model XML is parsed (deserialized) using the `DmnParser.Parse` method getting the `fileName` as input parameter and returning the `DmnModel` (deserialized XML) based on such decisions model XML definition. The DmnParser contains a very simple logic only, as its intention is just to deserialize the XML.
```csharp
def = DmnParser.Parse(fileName);
```

The XML model definition can also be provided as a `string` to `DmnParser.ParseString` method
```csharp
def = DmnParser.ParseString("xml string");
```

The `DmnModel` needs to be transformed to the `DmnExecutionContext` (Engine context) using the `DmnExecutionContextFactory` that gets the DMN Model and executes "second level parsing" to prepare the DMN Model for the Engine. The most of the "parsing" and validation logic is here.

```csharp
var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse(file));
```
`DmnParser` uses the DMN XML v 1.1 by default. It can be overriden using the optional parameter `dmnVersion` when calling the parser. It can contain value `V1_1`(default) or `V1_3`(to support DMN XML version 1.3). The values are defined in `DmnVersionEnum`. Alternative way of using the DMN version 1.3 is to call methods `DmnParser.Parse13(fileName)` or `DmnParser.ParseString13("xml string")`.  

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

#### Dependency Tree ####
When the model is parsed, the parser builds the dependency tree based on the information requirement connector. The decision can depend on zero or more inputs and on zero or more other decisions. When parsing the decision, the parser creates the full dependency tree of required inputs and decisions that need to be evaluated before (in proper order).
![DMN digram](doc/img/dmn_dependency.png)

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

The decision is executed and evaluated by Engine using the method `ctx.ExecuteDecision`.
```csharp
result = ctx.ExecuteDecision("decision name");
```
The Engine checks for the decision dependencies and when any decision needs to be evaluated before, the Engine evaluates such decision. This is done recursively, so the complex dependencies can be defined.
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
- `Type` - the variable values are stored within the Engine context as `object`, however, it provides some support for the data types. It's possible to define the data type in some parts of model - output variable for the expression decision, inputs and outputs for decision tables. The parser sets the type of variable at the first place where known and then checks that the data type is the same if set somwhere else. When the variable value is set and the type is known, the Engine tries to cast (`Convert.ChangeType(value, Type)`) the value to required type. 
- `Value` - current value of the variable. When provided to the expression interpreter, the value type (non-nullable) variables are set to default value of the value type when the current value stored within the context is null

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

The expression is in `text` element of the `literalExpression` child of the `decision` element.
The output variable is identified by `name` (or `id` if `name` is missing) attribute. The data type is defined in `typeRef` attribute.
  
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
  
It's possible to omit one or more (all) output input expressions. In this case the Engine will just not produce the output value (so the output variable will NOT be "cleaned" or set to `null`).

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

As you can see, if there is no value in `text` element of the `inputExpression`, the table input is *variable input* mapped to the variable with name defined in `label` attribute of `input` element. If the `label` attribute is missing, the `id` attribute will be used instead to get the name of the input variable.

Whenever the `text` element of the `inputExpression` is not empty, the table input is *expression input* and the expression within the `text` element will be evaluated as described above.

### Outputs in XML ###
The decision table in the example above will have following outputs in the XML definition
```xml  
<decisionTable>
  <output id="output_1" label="res" name="" typeRef="string" />
  <output id="output_2" label="amount" typeRef="integer" />
</decisionTable>
```
The output definition XML is quite simple, it just defines the name of the output variable within the attribute `label` (or `id` if `label` is missing) and the required variable data type in the attribute `typeRef`

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
The rule input expressions are defined using the `inputEntry` elements. **Their count and order must match the table input definitions** (there is no other way of pairing). The `text` sub-element of `inputEntry` defines the rule input expression. If the `text` element is empty of contains constant `-` (dash) the input will be omitted in rule evaluation.

The rule output expressions are defined using the `outputEntry` elements. **Their count and order must match the table output definitions** (there is no other way of pairing). The `text` sub-element of `outputEntry` defines the rule output expression. If the `text` element is empty of contains constant `-` (dash) the output will be omitted (not produced) during the decision table evaluation.

The optional rule annotation is stored in element `description`. 

### Allowed Values Constraints ###

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
If the rule input expression is omited, the value for corresponding input is not checked for allowed values.


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


```xml
<decisionTable hitPolicy="FIRST">
</decisionTable>
```

```xml
<decisionTable hitPolicy="COLLECT" aggregation="SUM">
</decisionTable>
```

## Decision results ##
The decision results are returned as `DmnDecisionResult` object. In general, there can be zero, one or multiple results.
- When there are none (zero) results, `DmnDecisionResult.HasResult` is `false`
- When there is single (one) result, `IsSingleResult.HasResult` is `true` (`DmnDecisionResult.HasResult` is `true`)
- When there are multiple results, `DmnDecisionResult.HasResult` is `true` and  `IsSingleResult.HasResult` is `false`.

The results are accessible using  `DmnDecisionResult.Results` list. Each result contains the list of output `Variables` and each variable has `Name`, `Value` and `Type` (when the output variable type is know).

There is a kind of a "shortcut" to the variables for the single result - `DmnDecisionResult.SingleResult` returns the list of variables of the first result (the only one for the single result).


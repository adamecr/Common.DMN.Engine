# DMN Engine #
DMN Engine is a rule engine allowing to execute and evaluate the decisions defined in a DMN model. Its primary target is to evaluate the decision tables that transform the inputs into the output(s) using the decision rules. Simple expression decisions are also supported as well as the complex decision models containing set of dependent decisions (tables or expressions).

The DMN Model is defined using the adopted [standard](https://www.omg.org/spec/DMN/1.1/) XML file defined by OMG. Such definition can be designed for example using the [Camunda modeler](https://camunda.com/download/modeler/), keeping in mind the principles how the file is parsed and the definition used in DMN Engine.

## Quick start ##
The basic use case is:

1. Parse the DMN model from file.
2. Create an engine execution context and load (and validate) the model into engine context.
3. Provide the input parameter(s).
4. Execute (and evaluate) the decision and get the result(s).

```
var def = DmnParser.Parse(fileName);
var ctx = DmnExecutionContextFactory.CreateExecutionContext(def);
ctx.WithInputParameter("input name", inputValue);
var result = ctx.ExecuteDecision("decision name");
```
Note: [DMN standard 1.3](https://www.omg.org/spec/DMN/1.3/) files can be also parsed and used, however no new functionality has been adopted for the execution.

It's also possible to create the DMN Definition by code (instead of parsing the DMN model from file) using the `DmnDefinitionBuilder`. The builder provides fluent methods to prepare the definition and built it at the end using `DmnDefinitionBuilder.Build` method.

## Documentation ##
More details are available in [readme](https://github.com/adamecr/Common.DMN.Engine/blob/master/readme.md) at [github repo](https://github.com/adamecr/Common.DMN.Engine). It's highly recommended to read it first to understand how the DMN Engine works and how to design the (XML) models properly.

The code documentation is available [here](https://github.com/adamecr/Common.DMN.Engine/blob/master/doc/net.adamec.lib.common.dmn.engine.md) (generated during the customized build using [MarkupDoc](https://github.com/adamecr/MarkupDoc)).
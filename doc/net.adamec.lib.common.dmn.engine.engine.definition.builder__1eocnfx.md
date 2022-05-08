#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx" />  net.adamec.lib.common.dmn.engine.engine.definition.builder Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x) | public abstract | Decision definition builder | 
 | [Decision.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4) | public | Decision definition builder reference class | 
 | [DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) | public | Catalog holding the decision definition builders used in [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4) and their reference | 
 | [DmnBuilderElement](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement__vtdze1) | public abstract | Base class for the elements of DMN definition [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4) | 
 | [DmnBuilderElement&lt;TBuilder,TResult&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv) | public abstract | Base class for the buildable elements of DMN definition [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4) | 
 | [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) | public | Exception thrown while building the DMN Definition | 
 | [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4) | public | Builder used to create [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) | 
 | [ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub) | public | Expression decision definition builder Expression decision definition is built using the chain of builders provided as lambda/delegate when calling ```csharp DmnDefinitionBuilder.WithExpressionDecision ``` . It has syntax ```csharp expressionDecision.Put("expression").To(outputVariableReference) ``` . [ExpressionDecision.ExpressionDecisionSrcBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder__v3hf38) provides [Put(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder.put_system.string___1klf8dt) method and returns [ExpressionDecision.ExpressionDecisionVarBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder__1pb5wlr) . [ExpressionDecision.ExpressionDecisionVarBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder__1pb5wlr) provides [To(Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder.to_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___c89334) method and returns [&amp;quot;final&amp;quot; expression decision builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub) that can be used to configure the required inputs and decisions when needed and to fully build the expression decision | 
 | [ExpressionDecision.ExpressionDecisionSrcBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder__v3hf38) | public | Helper builder used to configure the expression decision definition using the chain of builders. [ExpressionDecision.ExpressionDecisionSrcBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder__v3hf38) provides [Put(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder.put_system.string___1klf8dt) method to define the expression and returns [ExpressionDecision.ExpressionDecisionVarBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder__1pb5wlr) used to define the output variable. | 
 | [ExpressionDecision.ExpressionDecisionVarBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder__1pb5wlr) | public | Helper builder used to configure the expression decision definition using the chain of builders. [ExpressionDecision.ExpressionDecisionVarBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder__1pb5wlr) provides [To(Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder.to_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___c89334) method to define output variable and returns [&amp;quot;final&amp;quot; expression decision builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub) that can be used to configure the required inputs and decisions when needed and to fully build the expression decision | 
 | [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b) | public | Decision table definition builder | 
 | [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5) | public | Definition of decision table input - contains index (order), mapping to the source variable or source expression, and optional list of allowed values | 
 | [TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6) | public | Table input definition builder reference class | 
 | [TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu) | public | Definition of decision table output - contains index (order), mapping to the variable and optional list of allowed values | 
 | [TableOutput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff) | public | Table output definition builder reference class | 
 | [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5) | public | Decision table rule definition builder Rule definition is built using the chain of builders provided as lambda/delegate when calling ```csharp TableDecision.WithRule ``` . The table inputs and outputs must be defined in TableDecision builder first, as the rule builders must be provided with proper table input/output references.  The builder chain provides methods to define the input conditions (When, When.And[.And], Always) and the output calculations (Then, Then.And[.And], SkipOutput)  Syntax examples:   ```csharp rule.When(input1Ref, "input 1 eval expression").Then(output1Ref, "output 1 calc expression") ```    ```csharp rule.When(input1Ref, "input 1 eval expression").And(input2Ref, "input 2 eval expression").Then(output1Ref, "output 1 calc expression").And(output2Ref, "output 2 calc expression") ```    ```csharp rule.Always().Then(output1Ref, "output 1 calc expression").And(output2Ref, "output 2 calc expression") ```    ```csharp rule.When(input1Ref, "input 1 eval expression").SkipOutput() ```    ```csharp rule.When(input1Ref, "input 1 eval expression").And(input2Ref, "input 2 eval expression").SkipOutput() ```    ```csharp rule.Always().SkipOutput() ```   [TableRule.TableRuleInputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder__1yj4dla) provides [When(TableInput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder.when_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-system.string___liomuk) method to provide the first input condition and returns [TableRule.TableRuleInputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder__1yj4dla) .  [TableRule.TableRuleInputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder__1yj4dla) provides [Always()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder.always__muenim) method to let the rule accept any input and returns [TableRule.TableRuleThenOnlyBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder__1xu4ma9) .  [TableRule.TableRuleThenOrAndBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br) provides [And(TableInput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.and_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-system.string___ie3ztu) method provide the additional input condition and returns [TableRule.TableRuleThenOrAndBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br) .  [TableRule.TableRuleThenOrAndBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br) provides [Then(TableOutput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.then_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-system.string___k06qrt) method to provide the first output expression and returns [TableRule.TableRuleAndOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder__1z0ktcy) .  [TableRule.TableRuleThenOrAndBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br) provides [SkipOutput()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.skipoutput__1erqm32) method to skip the output calculation and returns [TableRule.TableRuleOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder__18hetz1) .  [TableRule.TableRuleThenOnlyBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder__1xu4ma9) provides [Then(TableOutput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder.then_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-system.string___7sc76z) method to provide the first output calculation and returns [TableRule.TableRuleAndOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder__1z0ktcy) .  [TableRule.TableRuleThenOnlyBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder__1xu4ma9) provides [SkipOutput()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder.skipoutput__bxdug) method to skip the output calculation and returns [TableRule.TableRuleOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder__18hetz1) .  [TableRule.TableRuleAndOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder__1z0ktcy) inherits from [TableRule.TableRuleOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder__18hetz1) and provides [And(TableOutput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder.and_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-system.string___ttut00) method to provide the additional output calculation and returns [TableRule.TableRuleAndOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder__1z0ktcy) .  [TableRule.TableRuleOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder__18hetz1) is the final rule builder. | 
 | [TableRule.TableRuleAndOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder__1z0ktcy) | public | Helper builder used to configure the decision table rule definition using the chain of builders. | 
 | [TableRule.TableRuleInputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder__1yj4dla) | public | Helper builder used to configure the decision table rule definition using the chain of builders. | 
 | [TableRule.TableRuleOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder__18hetz1) | public | Helper builder used to configure the decision table rule definition using the chain of builders. | 
 | [TableRule.TableRuleThenOnlyBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder__1xu4ma9) | public | Helper builder used to configure the decision table rule definition using the chain of builders. | 
 | [TableRule.TableRuleThenOrAndBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br) | public | Helper builder used to configure the decision table rule definition using the chain of builders. | 
 | [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr) | public | Variable definition builder | 
 | [Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) | public | Variable definition builder reference class | 
 | [VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) | public | Catalog holding the variable definitions (builders) used in [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4) and their reference | 

 


###  Structures ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) | public | Helper struct for composing the SFeel input expressions | 
 | [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) | public | Helper struct for composing the SFeel input expression tokens - the single &quot;constant&quot; or variable | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x" />  Decision Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\Decision.cs</small>


Decision definition builder



```csharp
public abstract class Decision : DmnBuilderElement<net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision>
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement__vtdze1) -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv)           
Derived: [net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub), [net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Label](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.label__ob44qp) | public | Label of the decision | 
 | [Name](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.name__1jjvncw) | public | Decision unique name | 
 | [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.refctor__ey2dwy) | private static | Reference CTOR delegate | 
 | [Reference](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.reference__1w631w8) | public | Decision reference that can be used in other builders | 
 | [RequiredDecisions](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.requireddecisions__vgkn55) | protected | List of decisions, the decision depends on | 
 | [RequiredInputs](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.requiredinputs__1x2tsu7) | protected | Decision required inputs (input variables) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decision()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.-cctor__b2dbx2) | private static | Static CTOR - forces the run of [Decision.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4) static CTOR to ensure that [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.refctor__ey2dwy) is properly initialized | 
 | [Decision(VariableCatalog, DecisionCatalog, string, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog-system.string-system.string___1as30wi) | protected | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddRequiredDecision(Decision.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.addrequireddecision_net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref___1f73hd7) | protected | Adds the required decision reference to the decision. | 
 | [AddRequiredInput(Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.addrequiredinput_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___1syen1r) | protected | Adds the required input reference to the decision. | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.tostring__1gi326q) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.label__ob44qp" />  Decision.Label Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x)           
Sources: engine\definition\builder\Decision.cs</small>


Label of the decision



```csharp
public string Label { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.name__1jjvncw" />  Decision.Name Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x)           
Sources: engine\definition\builder\Decision.cs</small>


Decision unique name



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.refctor__ey2dwy" />  Decision.RefCtor Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x)           
Sources: engine\definition\builder\Decision.cs</small>


Reference CTOR delegate



```csharp
private static Func<net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision,net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision.Ref> RefCtor { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision,net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision.Ref&gt;</a></dt><dd></dd></dl>


###  Remarks ###
The idea is to allow only &quot;owner class&quot; to be able to create the instances of the nested class. Nested class has the private CTOR. Static CTOR of nested class (Ref) sets the delegate to 
```csharp
RefCtor = owner => new Ref(owner)
```
 , so such delegate can be used within the owner class to create the instances of nested class.


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.reference__1w631w8" />  Decision.Reference Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x)           
Sources: engine\definition\builder\Decision.cs</small>


Decision reference that can be used in other builders



```csharp
public Decision.Ref Reference { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.requireddecisions__vgkn55" />  Decision.RequiredDecisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x)           
Sources: engine\definition\builder\Decision.cs</small>


List of decisions, the decision depends on



```csharp
protected List<net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision.Ref> RequiredDecisions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision.Ref&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.requiredinputs__1x2tsu7" />  Decision.RequiredInputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x)           
Sources: engine\definition\builder\Decision.cs</small>


Decision required inputs (input variables)



```csharp
protected List<net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref> RequiredInputs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.-cctor__b2dbx2" />  Decision.Decision() Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x)           
Sources: engine\definition\builder\Decision.cs</small>


Static CTOR - forces the run of [Decision.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4) static CTOR to ensure that [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.refctor__ey2dwy) is properly initialized



```csharp
private static Decision()
```

Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog-system.string-system.string___1as30wi" />  Decision.Decision(VariableCatalog, DecisionCatalog, string, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x)           
Sources: engine\definition\builder\Decision.cs</small>


CTOR



```csharp
protected Decision(VariableCatalog variables, DecisionCatalog decisions, string name, string label = null)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) <strong>variables</strong></dt><dd>[VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) managing the definition builder variables</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) <strong>decisions</strong></dt><dd>[DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) managing the definition builder decisions</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Unique name of the decision</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Optional label for the decision, <strong>name</strong> is used when not provided</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.addrequireddecision_net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref___1f73hd7" />  Decision.AddRequiredDecision(Decision.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x)           
Sources: engine\definition\builder\Decision.cs</small>


Adds the required decision reference to the decision.



```csharp
protected void AddRequiredDecision(Decision.Ref decision)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4) <strong>decision</strong></dt><dd>Reference to the decision this decision depends on</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Remarks ###
When executing the decision, the engine checks for required decisions and executes them before executing this decision


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.addrequiredinput_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___1syen1r" />  Decision.AddRequiredInput(Variable.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x)           
Sources: engine\definition\builder\Decision.cs</small>


Adds the required input reference to the decision.



```csharp
protected void AddRequiredInput(Variable.Ref input)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>input</strong></dt><dd>Reference to the input variable</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Remarks ###
Required inputs represents the &quot;link&quot; between input and decision in a model. Technically, the input requirements (existence of the input) are not checked during the execution, it&#39;s more for better understanding the DMN model


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.tostring__1gi326q" />  Decision.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x)           
Sources: engine\definition\builder\Decision.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4" />  Decision.Ref Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\Decision.cs</small>


Decision definition builder reference class



```csharp
public sealed class Decision.Ref
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref.decision__1i9n2vs) | private | Encapsulated decision (&quot;owner&quot; of the reference) | 
 | [DecisionType](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref.decisiontype__1ru6734) | public | Type of the decision | 
 | [Name](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref.name__1tzew3z) | public | Decision unique name | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decision.Ref()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref.-cctor__se6vbv) | private static | Static CTOR - sets the [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.refctor__ey2dwy) delegate to Ref&#39;s private instance CTOR allowing the &quot;owner&quot; to create the Ref instances | 
 | [Decision.Ref(Decision)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.decision___1as7vkc) | private | Private CTOR - accessible from &quot;owner class&quot; via [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.refctor__ey2dwy) | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref.decision__1i9n2vs" />  Decision.Ref.Decision Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4)           
Sources: engine\definition\builder\Decision.cs</small>


Encapsulated decision (&quot;owner&quot; of the reference)



```csharp
private Decision Decision { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref.decisiontype__1ru6734" />  Decision.Ref.DecisionType Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4)           
Sources: engine\definition\builder\Decision.cs</small>


Type of the decision



```csharp
public Type DecisionType { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref.name__1tzew3z" />  Decision.Ref.Name Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4)           
Sources: engine\definition\builder\Decision.cs</small>


Decision unique name



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref.-cctor__se6vbv" />  Decision.Ref.Decision.Ref() Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4)           
Sources: engine\definition\builder\Decision.cs</small>


Static CTOR - sets the [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.refctor__ey2dwy) delegate to Ref&#39;s private instance CTOR allowing the &quot;owner&quot; to create the Ref instances



```csharp
private static Decision.Ref()
```

Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.decision___1as7vkc" />  Decision.Ref.Decision.Ref(Decision) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4)           
Sources: engine\definition\builder\Decision.cs</small>


Private CTOR - accessible from &quot;owner class&quot; via [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.refctor__ey2dwy)



```csharp
private Decision.Ref(Decision decision)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x) <strong>decision</strong></dt><dd>Decision to create the reference for</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76" />  DecisionCatalog Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\DecisionCatalog.cs</small>


Catalog holding the decision definition builders used in [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4) and their reference



```csharp
public sealed class DecisionCatalog
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [decisions](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#f-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog.decisions__17koqut) | private | Internal dictionary containing the decisions definition builders by decision name | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decisions](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog.decisions__bk6vyj) | public | Dictionary containing the decisions definition builders by decision name | 
 | [DecisionsByRef](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog.decisionsbyref__77krpl) | private | Internal dictionary containing the decisions definition builders by reference | 
 | [IsBuilt](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog.isbuilt__6bak2w) | public | Flag whether the definition has been already built. | 

 


###  Indexers ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [this[Decision.Ref]](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog.item_net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref___x8a0ky) | public | Retrieves the [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x) definition builder by its [reference](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddDecision(Decision)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog.adddecision_net.adamec.lib.common.dmn.engine.engine.definition.builder.decision___d8va8y) | public | Adds a decision to catalog | 
 | [Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog.build__n57ic7) | internal | Builds all decision definitions stored in the catalog | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog.tostring__91ets7) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog.decisions__17koqut" />  DecisionCatalog.decisions Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76)           
Sources: engine\definition\builder\DecisionCatalog.cs</small>


Internal dictionary containing the decisions definition builders by decision name



```csharp
private readonly Dictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision> decisions
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog.decisions__bk6vyj" />  DecisionCatalog.Decisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76)           
Sources: engine\definition\builder\DecisionCatalog.cs</small>


Dictionary containing the decisions definition builders by decision name



```csharp
public IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision> Decisions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog.decisionsbyref__77krpl" />  DecisionCatalog.DecisionsByRef Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76)           
Sources: engine\definition\builder\DecisionCatalog.cs</small>


Internal dictionary containing the decisions definition builders by reference



```csharp
private Dictionary<net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision> DecisionsByRef { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog.isbuilt__6bak2w" />  DecisionCatalog.IsBuilt Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76)           
Sources: engine\definition\builder\DecisionCatalog.cs</small>


Flag whether the definition has been already built.



```csharp
public bool IsBuilt { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


###  Remarks ###
When set to true, the definition can&#39;t be modified anymore - the modification functions will throw [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when called


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog.item_net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref___x8a0ky" />  DecisionCatalog.this[Decision.Ref] Indexer ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76)           
Sources: engine\definition\builder\DecisionCatalog.cs</small>


Retrieves the [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x) definition builder by its [reference](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4)



```csharp
public Decision this[Decision.Ref reference] { get; }
```

<strong>Indexer parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4) <em>reference</em></dt><dd>Decision definition builder reference</dd></dl>
<strong>Indexer value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x)</dt><dd></dd></dl>Returns: Decision definition builder or null when the reference is not found           



Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog.adddecision_net.adamec.lib.common.dmn.engine.engine.definition.builder.decision___d8va8y" />  DecisionCatalog.AddDecision(Decision) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76)           
Sources: engine\definition\builder\DecisionCatalog.cs</small>


Adds a decision to catalog



```csharp
public DecisionCatalog AddDecision(Decision decision)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x) <strong>decision</strong></dt><dd>Decision definition builder to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76)</dt><dd>This decision catalog</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the catalog has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog.build__n57ic7" />  DecisionCatalog.Build() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76)           
Sources: engine\definition\builder\DecisionCatalog.cs</small>


Builds all decision definitions stored in the catalog



```csharp
internal IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision> Build()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;</a></dt><dd>Dictionary of the variable definitions by variable name</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the catalog has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog.tostring__91ets7" />  DecisionCatalog.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76)           
Sources: engine\definition\builder\DecisionCatalog.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement__vtdze1" />  DmnBuilderElement Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\DmnBuilderElement.cs</small>


Base class for the elements of DMN definition [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)



```csharp
public abstract class DmnBuilderElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement&lt;TBuilder,TResult&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv)           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Logger](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#f-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement.logger__2at1ol) | protected | Logger | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decisions](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement.decisions__1ufpe8g) | protected | All known decisions of [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4) | 
 | [Variables](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement.variables__19zk8au) | protected | All known variables of [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnBuilderElement(VariableCatalog, DecisionCatalog)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog___191abfe) | protected | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement.logger__2at1ol" />  DmnBuilderElement.Logger Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnBuilderElement](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement__vtdze1)           
Sources: engine\definition\builder\DmnBuilderElement.cs</small>


Logger



```csharp
protected ILogger Logger
```

<strong>Field value</strong><dl><dt>net.adamec.lib.common.core.logging.ILogger</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement.decisions__1ufpe8g" />  DmnBuilderElement.Decisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnBuilderElement](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement__vtdze1)           
Sources: engine\definition\builder\DmnBuilderElement.cs</small>


All known decisions of [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)



```csharp
protected DecisionCatalog Decisions { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement.variables__19zk8au" />  DmnBuilderElement.Variables Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnBuilderElement](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement__vtdze1)           
Sources: engine\definition\builder\DmnBuilderElement.cs</small>


All known variables of [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)



```csharp
protected VariableCatalog Variables { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog___191abfe" />  DmnBuilderElement.DmnBuilderElement(VariableCatalog, DecisionCatalog) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnBuilderElement](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement__vtdze1)           
Sources: engine\definition\builder\DmnBuilderElement.cs</small>


CTOR



```csharp
protected DmnBuilderElement(VariableCatalog variables, DecisionCatalog decisions)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) <strong>variables</strong></dt><dd>Variable catalog of of [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) <strong>decisions</strong></dt><dd>Decisions catalog of of [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv" />  DmnBuilderElement&lt;TBuilder,TResult&gt; Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\DmnBuilderElement.cs</small>


Base class for the buildable elements of DMN definition [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)



```csharp
public abstract class DmnBuilderElement<TBuilder, TResult> : DmnBuilderElement
 where TBuilder: DmnBuilderElement<TBuilder,TResult>
 where TResult: class
```

<strong>Type parameters</strong><dl><dt><strong>TBuilder</strong></dt><dd>Type of the builder - &quot;reference&quot; to itself</dd><dt><strong>TResult</strong></dt><dd>Type of the definition to be built</dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement__vtdze1)           
Derived: [net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x), [net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5), [net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu), [net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5), [net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ResultInternal](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#f-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.resultinternal__1hb7kdp) | protected | Internal build result | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IsBuilt](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.isbuilt__ran6tx) | public | Flag whether the definition has been already built. | 
 | [Result](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.result__7u3vqa) | public | Build result | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnBuilderElement&lt;TBuilder,TResult&gt;(VariableCatalog, DecisionCatalog)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog___1vk627o) | protected | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.build__rlrom0) | protected internal abstract | Builds the builder element and returns the built definition element | 
 | [GetResultOrBuild()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.getresultorbuild__fuvqm4) | protected internal | Gets built definition element. Calls [Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.build__rlrom0) first if needed | 
 | [GetResultOrBuild&lt;TBuilderElement,TBuilderElementResult&gt;(DmnBuilderElement&lt;TBuilderElement,TBuilderElementResult&gt;)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.getresultorbuild--2_net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement_--0---1____1a3e7rz) | protected static | Gets built definition of given <strong>element</strong> . | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.resultinternal__1hb7kdp" />  DmnBuilderElement&lt;TBuilder,TResult&gt;.ResultInternal Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnBuilderElement&lt;TBuilder,TResult&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv)           
Sources: engine\definition\builder\DmnBuilderElement.cs</small>


Internal build result



```csharp
protected DmnBuilderElement<TBuilder,TResult>.TResult ResultInternal
```

<strong>Field value</strong><dl><dt>net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement&lt;TBuilder,TResult&gt;.TResult</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.isbuilt__ran6tx" />  DmnBuilderElement&lt;TBuilder,TResult&gt;.IsBuilt Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnBuilderElement&lt;TBuilder,TResult&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv)           
Sources: engine\definition\builder\DmnBuilderElement.cs</small>


Flag whether the definition has been already built.



```csharp
public bool IsBuilt { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


###  Remarks ###
When set to true, the definition can&#39;t be modified anymore - the modification functions will throw [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when called


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.result__7u3vqa" />  DmnBuilderElement&lt;TBuilder,TResult&gt;.Result Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnBuilderElement&lt;TBuilder,TResult&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv)           
Sources: engine\definition\builder\DmnBuilderElement.cs</small>


Build result



```csharp
public DmnBuilderElement<TBuilder,TResult>.TResult Result { get; }
```

<strong>Property value</strong><dl><dt>net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement&lt;TBuilder,TResult&gt;.TResult</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) in case the element is not built yet</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog___1vk627o" />  DmnBuilderElement&lt;TBuilder,TResult&gt;.DmnBuilderElement&lt;TBuilder,TResult&gt;(VariableCatalog, DecisionCatalog) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnBuilderElement&lt;TBuilder,TResult&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv)           
Sources: engine\definition\builder\DmnBuilderElement.cs</small>


CTOR



```csharp
protected DmnBuilderElement<TBuilder,TResult>(VariableCatalog variables, DecisionCatalog decisions)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) <strong>variables</strong></dt><dd>Variable catalog of of [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) <strong>decisions</strong></dt><dd>Decisions catalog of of [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.build__rlrom0" />  DmnBuilderElement&lt;TBuilder,TResult&gt;.Build() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnBuilderElement&lt;TBuilder,TResult&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv)           
Sources: engine\definition\builder\DmnBuilderElement.cs</small>


Builds the builder element and returns the built definition element



```csharp
protected internal abstract DmnBuilderElement<TBuilder,TResult>.TResult Build()
```

<strong>Return value</strong><dl><dt>net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement&lt;TBuilder,TResult&gt;.TResult</dt><dd>Built definition element</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.getresultorbuild__fuvqm4" />  DmnBuilderElement&lt;TBuilder,TResult&gt;.GetResultOrBuild() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnBuilderElement&lt;TBuilder,TResult&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv)           
Sources: engine\definition\builder\DmnBuilderElement.cs</small>


Gets built definition element. Calls [Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.build__rlrom0) first if needed



```csharp
protected internal DmnBuilderElement<TBuilder,TResult>.TResult GetResultOrBuild()
```

<strong>Return value</strong><dl><dt>net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement&lt;TBuilder,TResult&gt;.TResult</dt><dd>Built definition element</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.getresultorbuild--2_net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement_--0---1____1a3e7rz" />  DmnBuilderElement&lt;TBuilder,TResult&gt;.GetResultOrBuild&lt;TBuilderElement,TBuilderElementResult&gt;(DmnBuilderElement&lt;TBuilderElement,TBuilderElementResult&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnBuilderElement&lt;TBuilder,TResult&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv)           
Sources: engine\definition\builder\DmnBuilderElement.cs</small>


Gets built definition of given <strong>element</strong> .



```csharp
protected static DmnBuilderElement<TBuilder,TResult>.TBuilderElementResult GetResultOrBuild<TBuilderElement, TBuilderElementResult>(DmnBuilderElement<TBuilderElement,TBuilderElementResult> element)
 where TBuilderElement: DmnBuilderElement<TBuilderElement,TBuilderElementResult>
 where TBuilderElementResult: class
```

<strong>Type parameters</strong><dl><dt><strong>TBuilderElement</strong></dt><dd>Builder element type of <strong>element</strong></dd><dt><strong>TBuilderElementResult</strong></dt><dd>Build result type of <strong>element</strong></dd></dl>
<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement&lt;TBuilderElement,TBuilderElementResult&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv) <strong>element</strong></dt><dd>Builder element to get the built definition from</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement&lt;TBuilder,TResult&gt;.TBuilderElementResult</dt><dd>Built definition element</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8" />  DmnBuilderException Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\DmnBuilderException.cs</small>


Exception thrown while building the DMN Definition



```csharp
public class DmnBuilderException : Exception
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable" target="_blank" >System.Runtime.Serialization.ISerializable</a>


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnBuilderException(string, Exception)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception.-ctor_system.string-system.exception___18mrwld) | public | Creates <em>net.adamec.lib.common.dmn.engine.definition.builder.DmnBuilderException</em> with given <strong>message</strong> and optional <strong>innerException</strong> | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception.-ctor_system.string-system.exception___18mrwld" />  DmnBuilderException.DmnBuilderException(string, Exception) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)           
Sources: engine\definition\builder\DmnBuilderException.cs</small>


Creates <em>net.adamec.lib.common.dmn.engine.definition.builder.DmnBuilderException</em> with given <strong>message</strong> and optional <strong>innerException</strong>



```csharp
public DmnBuilderException(string message, Exception innerException = null)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Error message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Optional inner exception</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4" />  DmnDefinitionBuilder Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Builder used to create [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)



```csharp
public class DmnDefinitionBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Logger](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#f-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.logger__p6rnog) | private static | Logger | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decisions](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.decisions__1los4sb) | protected | Catalog holding the decisions used in [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4) | 
 | [IsBuilt](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.isbuilt__sxfs1q) | public | Flag whether the definition has been already built. | 
 | [Variables](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.variables__13wvsht) | protected | Catalog holding the variables used in [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.build__y4d87v) | public | Builds the DMN definition as prepared in [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4) and returns [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) that can be executed within [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.tostring__1cekl3f) | public | Returns a string that represents the current object. | 
 | [WithExpressionDecision(string, Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision.ExpressionDecisionSrcBuilder,net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision&gt;, Decision.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withexpressiondecision_system.string-system.func_net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision_-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref--system.string___ym8ftk) | public | Adds the expression decision into the definition | 
 | [WithExpressionDecision(string, Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision.ExpressionDecisionSrcBuilder,net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision&gt;, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withexpressiondecision_system.string-system.func_net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision_-system.string___amqdfi) | public | Adds the expression decision into the definition | 
 | [WithExpressionDecision(string, string, Variable.Ref, Decision.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withexpressiondecision_system.string-system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref--system.string___xh1eeu) | public | Adds the expression decision into the definition | 
 | [WithExpressionDecision(string, string, Variable.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withexpressiondecision_system.string-system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-system.string___1525lag) | public | Adds the expression decision into the definition | 
 | [WithInput(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput_system.string___1so0sks) | public | Adds the untyped input with given <strong>name</strong> into the definition. Avoid using the untyped inputs where possible - the input type will be set based on the value assigned to the [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) , so this needs to be taken into the consideration when defining the decisions | 
 | [WithInput(string, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput_system.string-system.string___1s32rkw) | public | Adds the untyped input with given <strong>name</strong> into the definition. Avoid using the untyped inputs where possible - the input type will be set based on the value assigned to the [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) , so this needs to be taken into the consideration when defining the decisions | 
 | [WithInput(string, string, Type)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput_system.string-system.string-system.type___4sjo7f) | public | Adds the inputs of given <strong>name</strong> and type into the definition | 
 | [WithInput(string, string, Type, Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput_system.string-system.string-system.type-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-___1hx7q51) | public | Adds the inputs of given <strong>name</strong> and type into the definition | 
 | [WithInput(string, string, Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput_system.string-system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-___1248cvw) | public | Adds the untyped input with given <strong>name</strong> into the definition. Avoid using the untyped inputs where possible - the input type will be set based on the value assigned to the [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) , so this needs to be taken into the consideration when defining the decisions | 
 | [WithInput(string, Type)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput_system.string-system.type___d9veyd) | public | Adds the inputs of given <strong>name</strong> and type into the definition | 
 | [WithInput(string, Type, Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput_system.string-system.type-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-___1kb93qj) | public | Adds the inputs of given <strong>name</strong> and type into the definition | 
 | [WithInput(string, Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-___ek73e8) | public | Adds the untyped input with given <strong>name</strong> into the definition. Avoid using the untyped inputs where possible - the input type will be set based on the value assigned to the [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) , so this needs to be taken into the consideration when defining the decisions | 
 | [WithInput&lt;TVariableType&gt;(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput--1_system.string___11r2m3n) | public | Adds the inputs of given <strong>name</strong> and type into the definition | 
 | [WithInput&lt;TVariableType&gt;(string, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput--1_system.string-system.string___ahdiwh) | public | Adds the inputs of given <strong>name</strong> and type into the definition | 
 | [WithInput&lt;TVariableType&gt;(string, string, Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput--1_system.string-system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-___x21f9v) | public | Adds the inputs of given <strong>name</strong> and type into the definition | 
 | [WithInput&lt;TVariableType&gt;(string, Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput--1_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-___14vhmap) | public | Adds the inputs of given <strong>name</strong> and type into the definition | 
 | [WithInputs&lt;TVariableType&gt;(string[])](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinputs--1_system.string_____kjx7pc) | public | Adds the inputs of <strong>TVariableType</strong> with given <strong>names</strong> into the definition | 
 | [WithTableDecision(string, Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision&gt;)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withtabledecision_system.string-system.func_net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision____rvj83d) | public | Adds the decision table into the definition | 
 | [WithTableDecision(string, Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision&gt;, Decision.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withtabledecision_system.string-system.func_net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision_-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref--system.string___1xzhvtf) | public | Adds the decision table into the definition | 
 | [WithVariable(string, Type)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withvariable_system.string-system.type___1eqz8ul) | public | Adds the (non-input) variable of given <strong>name</strong> and type into the definition | 
 | [WithVariable(string, Type, Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withvariable_system.string-system.type-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-___gpl9mj) | public | Adds the (non-input) variable of given <strong>name</strong> and type into the definition | 
 | [WithVariable&lt;TVariableType&gt;(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withvariable--1_system.string___1u2d1cr) | public | Adds the (non-input) variable of given <strong>name</strong> and type into the definition | 
 | [WithVariable&lt;TVariableType&gt;(string, Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withvariable--1_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-___19655b5) | public | Adds the (non-input) variable of given <strong>name</strong> and type into the definition | 
 | [WithVariables&lt;TVariableType&gt;(string[])](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withvariables--1_system.string_____1njd71m) | public | Adds the (non-input) variables of <strong>TVariableType</strong> with given <strong>names</strong> into the definition | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.logger__p6rnog" />  DmnDefinitionBuilder.Logger Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Logger



```csharp
private static readonly ILogger Logger
```

<strong>Field value</strong><dl><dt>net.adamec.lib.common.core.logging.ILogger</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.decisions__1los4sb" />  DmnDefinitionBuilder.Decisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Catalog holding the decisions used in [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)



```csharp
protected DecisionCatalog Decisions { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.isbuilt__sxfs1q" />  DmnDefinitionBuilder.IsBuilt Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Flag whether the definition has been already built.



```csharp
public bool IsBuilt { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


###  Remarks ###
When set to true, the definition can&#39;t be modified anymore - the modification functions will throw [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when called


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.variables__13wvsht" />  DmnDefinitionBuilder.Variables Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Catalog holding the variables used in [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)



```csharp
protected VariableCatalog Variables { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.build__y4d87v" />  DmnDefinitionBuilder.Build() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Builds the DMN definition as prepared in [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4) and returns [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) that can be executed within [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)



```csharp
public DmnDefinition Build()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4)</dt><dd>[DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) that can be executed within [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition contains no decision</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.tostring__1cekl3f" />  DmnDefinitionBuilder.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withexpressiondecision_system.string-system.func_net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision_-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref--system.string___ym8ftk" />  DmnDefinitionBuilder.WithExpressionDecision(string, Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision.ExpressionDecisionSrcBuilder,net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision&gt;, Decision.Ref, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the expression decision into the definition



```csharp
public DmnDefinitionBuilder WithExpressionDecision(string name, Func<net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision.ExpressionDecisionSrcBuilder,net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision> builder, out Decision.Ref decisionRef, string label = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the decision to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision.ExpressionDecisionSrcBuilder,net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision&gt;</a> <strong>builder</strong></dt><dd>Builder to be used to fully configure the expression decision definition</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4) <strong>decisionRef</strong></dt><dd>Reference to the decision added</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Label of the decision, name is used when not provided</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withexpressiondecision_system.string-system.func_net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision_-system.string___amqdfi" />  DmnDefinitionBuilder.WithExpressionDecision(string, Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision.ExpressionDecisionSrcBuilder,net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the expression decision into the definition



```csharp
public DmnDefinitionBuilder WithExpressionDecision(string name, Func<net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision.ExpressionDecisionSrcBuilder,net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision> builder, string label = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the decision to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision.ExpressionDecisionSrcBuilder,net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision&gt;</a> <strong>builder</strong></dt><dd>Builder to be used to fully configure the expression decision definition</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Label of the decision, name is used when not provided</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withexpressiondecision_system.string-system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref--system.string___xh1eeu" />  DmnDefinitionBuilder.WithExpressionDecision(string, string, Variable.Ref, Decision.Ref, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the expression decision into the definition



```csharp
public DmnDefinitionBuilder WithExpressionDecision(string name, string expression, Variable.Ref outputVariable, out Decision.Ref decisionRef, string label = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the decision to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Expression to be evaluated during the decision execution</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>outputVariable</strong></dt><dd>Reference to existing variable to store the output of the decision evaluation</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4) <strong>decisionRef</strong></dt><dd>Reference to the decision added</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Label of the decision, name is used when not provided</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withexpressiondecision_system.string-system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-system.string___1525lag" />  DmnDefinitionBuilder.WithExpressionDecision(string, string, Variable.Ref, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the expression decision into the definition



```csharp
public DmnDefinitionBuilder WithExpressionDecision(string name, string expression, Variable.Ref outputVariable, string label = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the decision to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Expression to be evaluated during the decision execution</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>outputVariable</strong></dt><dd>Reference to existing variable to store the output of the decision evaluation</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Label of the decision, name is used when not provided</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput_system.string___1so0sks" />  DmnDefinitionBuilder.WithInput(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the untyped input with given <strong>name</strong> into the definition. Avoid using the untyped inputs where possible - the input type will be set based on the value assigned to the [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) , so this needs to be taken into the consideration when defining the decisions



```csharp
public DmnDefinitionBuilder WithInput(string name)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the input to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput_system.string-system.string___1s32rkw" />  DmnDefinitionBuilder.WithInput(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the untyped input with given <strong>name</strong> into the definition. Avoid using the untyped inputs where possible - the input type will be set based on the value assigned to the [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) , so this needs to be taken into the consideration when defining the decisions



```csharp
public DmnDefinitionBuilder WithInput(string name, string label)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the input to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Label of the input, name is used when not provided</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput_system.string-system.string-system.type___4sjo7f" />  DmnDefinitionBuilder.WithInput(string, string, Type) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the inputs of given <strong>name</strong> and type into the definition



```csharp
public DmnDefinitionBuilder WithInput(string name, string label, Type variableType)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the input to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Label of the input, name is used when not provided</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>variableType</strong></dt><dd>Type of the input to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput_system.string-system.string-system.type-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-___1hx7q51" />  DmnDefinitionBuilder.WithInput(string, string, Type, Variable.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the inputs of given <strong>name</strong> and type into the definition



```csharp
public DmnDefinitionBuilder WithInput(string name, string label, Type variableType, out Variable.Ref inputVariable)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the input to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Label of the input, name is used when not provided</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>variableType</strong></dt><dd>Type of the input to add</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>inputVariable</strong></dt><dd>Reference to the input variable backing the input added</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput_system.string-system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-___1248cvw" />  DmnDefinitionBuilder.WithInput(string, string, Variable.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the untyped input with given <strong>name</strong> into the definition. Avoid using the untyped inputs where possible - the input type will be set based on the value assigned to the [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) , so this needs to be taken into the consideration when defining the decisions



```csharp
public DmnDefinitionBuilder WithInput(string name, string label, out Variable.Ref inputVariable)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the input to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Label of the input, name is used when not provided</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>inputVariable</strong></dt><dd>Reference to the input variable backing the input added</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput_system.string-system.type___d9veyd" />  DmnDefinitionBuilder.WithInput(string, Type) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the inputs of given <strong>name</strong> and type into the definition



```csharp
public DmnDefinitionBuilder WithInput(string name, Type variableType)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the input to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>variableType</strong></dt><dd>Type of the input to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput_system.string-system.type-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-___1kb93qj" />  DmnDefinitionBuilder.WithInput(string, Type, Variable.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the inputs of given <strong>name</strong> and type into the definition



```csharp
public DmnDefinitionBuilder WithInput(string name, Type variableType, out Variable.Ref inputVariable)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the input to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>variableType</strong></dt><dd>Type of the input to add</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>inputVariable</strong></dt><dd>Reference to the input variable backing the input added</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-___ek73e8" />  DmnDefinitionBuilder.WithInput(string, Variable.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the untyped input with given <strong>name</strong> into the definition. Avoid using the untyped inputs where possible - the input type will be set based on the value assigned to the [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.execution.context__143xaoa.md#t-net.adamec.lib.common.dmn.engine.engine.execution.context.dmnexecutioncontext__17lps88) , so this needs to be taken into the consideration when defining the decisions



```csharp
public DmnDefinitionBuilder WithInput(string name, out Variable.Ref inputVariable)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the input to add</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>inputVariable</strong></dt><dd>Reference to the input variable backing the input added</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput--1_system.string___11r2m3n" />  DmnDefinitionBuilder.WithInput&lt;TVariableType&gt;(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the inputs of given <strong>name</strong> and type into the definition



```csharp
public DmnDefinitionBuilder WithInput<TVariableType>(string name)
```

<strong>Type parameters</strong><dl><dt><strong>TVariableType</strong></dt><dd>Type of the input to add</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the input to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput--1_system.string-system.string___ahdiwh" />  DmnDefinitionBuilder.WithInput&lt;TVariableType&gt;(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the inputs of given <strong>name</strong> and type into the definition



```csharp
public DmnDefinitionBuilder WithInput<TVariableType>(string name, string label)
```

<strong>Type parameters</strong><dl><dt><strong>TVariableType</strong></dt><dd>Type of the input to add</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the input to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Label of the input, name is used when not provided</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput--1_system.string-system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-___x21f9v" />  DmnDefinitionBuilder.WithInput&lt;TVariableType&gt;(string, string, Variable.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the inputs of given <strong>name</strong> and type into the definition



```csharp
public DmnDefinitionBuilder WithInput<TVariableType>(string name, string label, out Variable.Ref inputVariable)
```

<strong>Type parameters</strong><dl><dt><strong>TVariableType</strong></dt><dd>Type of the input to add</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the input to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Label of the input, name is used when not provided</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>inputVariable</strong></dt><dd>Reference to the input variable backing the input added</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinput--1_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-___14vhmap" />  DmnDefinitionBuilder.WithInput&lt;TVariableType&gt;(string, Variable.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the inputs of given <strong>name</strong> and type into the definition



```csharp
public DmnDefinitionBuilder WithInput<TVariableType>(string name, out Variable.Ref inputVariable)
```

<strong>Type parameters</strong><dl><dt><strong>TVariableType</strong></dt><dd>Type of the input to add</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the input to add</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>inputVariable</strong></dt><dd>Reference to the input variable backing the input added</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withinputs--1_system.string_____kjx7pc" />  DmnDefinitionBuilder.WithInputs&lt;TVariableType&gt;(string[]) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the inputs of <strong>TVariableType</strong> with given <strong>names</strong> into the definition



```csharp
public DmnDefinitionBuilder WithInputs<TVariableType>(params string[] names)
```

<strong>Type parameters</strong><dl><dt><strong>TVariableType</strong></dt><dd>Type of the inputs to add</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>names</strong></dt><dd>Names of the inputs to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withtabledecision_system.string-system.func_net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision____rvj83d" />  DmnDefinitionBuilder.WithTableDecision(string, Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the decision table into the definition



```csharp
public DmnDefinitionBuilder WithTableDecision(string name, Func<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision> builder)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the decision table to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision&gt;</a> <strong>builder</strong></dt><dd>Builder to be used to fully configure the decision table definition</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withtabledecision_system.string-system.func_net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision_-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref--system.string___1xzhvtf" />  DmnDefinitionBuilder.WithTableDecision(string, Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision&gt;, Decision.Ref, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the decision table into the definition



```csharp
public DmnDefinitionBuilder WithTableDecision(string name, Func<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision> builder, out Decision.Ref decisionRef, string label = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the decision table to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision&gt;</a> <strong>builder</strong></dt><dd>Builder to be used to fully configure the decision table definition</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4) <strong>decisionRef</strong></dt><dd>Reference to the decision added</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Label of the decision, name is used when not provided</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withvariable_system.string-system.type___1eqz8ul" />  DmnDefinitionBuilder.WithVariable(string, Type) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the (non-input) variable of given <strong>name</strong> and type into the definition



```csharp
public DmnDefinitionBuilder WithVariable(string name, Type variableType)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the variable to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>variableType</strong></dt><dd>Type of the variable to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withvariable_system.string-system.type-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-___gpl9mj" />  DmnDefinitionBuilder.WithVariable(string, Type, Variable.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the (non-input) variable of given <strong>name</strong> and type into the definition



```csharp
public DmnDefinitionBuilder WithVariable(string name, Type variableType, out Variable.Ref variableRef)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the variable to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>variableType</strong></dt><dd>Type of the variable to add</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>variableRef</strong></dt><dd>Reference to the variable added</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withvariable--1_system.string___1u2d1cr" />  DmnDefinitionBuilder.WithVariable&lt;TVariableType&gt;(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the (non-input) variable of given <strong>name</strong> and type into the definition



```csharp
public DmnDefinitionBuilder WithVariable<TVariableType>(string name)
```

<strong>Type parameters</strong><dl><dt><strong>TVariableType</strong></dt><dd>Type of the variable to add</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the variable to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withvariable--1_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-___19655b5" />  DmnDefinitionBuilder.WithVariable&lt;TVariableType&gt;(string, Variable.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the (non-input) variable of given <strong>name</strong> and type into the definition



```csharp
public DmnDefinitionBuilder WithVariable<TVariableType>(string name, out Variable.Ref variableRef)
```

<strong>Type parameters</strong><dl><dt><strong>TVariableType</strong></dt><dd>Type of the variable to add</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the variable to add</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>variableRef</strong></dt><dd>Reference to the variable added</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder.withvariables--1_system.string_____1njd71m" />  DmnDefinitionBuilder.WithVariables&lt;TVariableType&gt;(string[]) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)           
Sources: engine\definition\builder\DmnDefinitionBuilder.cs</small>


Adds the (non-input) variables of <strong>TVariableType</strong> with given <strong>names</strong> into the definition



```csharp
public DmnDefinitionBuilder WithVariables<TVariableType>(params string[] names)
```

<strong>Type parameters</strong><dl><dt><strong>TVariableType</strong></dt><dd>Type of the variable to add</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>names</strong></dt><dd>Names of the variables to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dt><dd>The current [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4)</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub" />  ExpressionDecision Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


Expression decision definition builder Expression decision definition is built using the chain of builders provided as lambda/delegate when calling 
```csharp
DmnDefinitionBuilder.WithExpressionDecision
```
 . It has syntax 
```csharp
expressionDecision.Put("expression").To(outputVariableReference)
```
 . [ExpressionDecision.ExpressionDecisionSrcBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder__v3hf38) provides [Put(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder.put_system.string___1klf8dt) method and returns [ExpressionDecision.ExpressionDecisionVarBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder__1pb5wlr) . [ExpressionDecision.ExpressionDecisionVarBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder__1pb5wlr) provides [To(Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder.to_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___c89334) method and returns [&amp;quot;final&amp;quot; expression decision builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub) that can be used to configure the required inputs and decisions when needed and to fully build the expression decision





```csharp
public sealed class ExpressionDecision : Decision
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement__vtdze1) -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv) -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Expression](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expression__8rfm17) | public | Expression to be evaluated when the expression decision is executed | 
 | [OutputVariable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.outputvariable__1qm3oc0) | public | Reference to the variable used to store the expression decision output | 
 | [OutputVariableInternal](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.outputvariableinternal__i8lypf) | private | Builder of variable used to store the expression decision output | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ExpressionDecision(VariableCatalog, DecisionCatalog, string, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog-system.string-system.string___155k5kk) | internal | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.build__16lp2w) | protected internal | Builds the expression decision definition | 
 | [Requires(Decision.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.requires_net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref___1vafzm7) | public | Adds the required decision reference to the decision. | 
 | [Requires(Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.requires_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___4jzelp) | public | Adds the required input reference to the decision. | 
 | [SetExpression(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.setexpression_system.string___i40673) | private | Sets the expression to be evaluated when the expression decision is executed | 
 | [SetOutput(Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.setoutput_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___7x74za) | private | Sets the output variable to store the result of the decision expression evaluation to | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.tostring__lpbv7s) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expression__8rfm17" />  ExpressionDecision.Expression Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub)           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


Expression to be evaluated when the expression decision is executed



```csharp
public string Expression { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.outputvariable__1qm3oc0" />  ExpressionDecision.OutputVariable Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub)           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


Reference to the variable used to store the expression decision output



```csharp
public Variable.Ref OutputVariable { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.outputvariableinternal__i8lypf" />  ExpressionDecision.OutputVariableInternal Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub)           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


Builder of variable used to store the expression decision output



```csharp
private Variable OutputVariableInternal { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog-system.string-system.string___155k5kk" />  ExpressionDecision.ExpressionDecision(VariableCatalog, DecisionCatalog, string, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub)           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


CTOR



```csharp
internal ExpressionDecision(VariableCatalog variables, DecisionCatalog decisions, string name, string label = null)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) <strong>variables</strong></dt><dd>[VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) managing the definition builder variables</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) <strong>decisions</strong></dt><dd>[DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) managing the definition builder decisions</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Unique name of the decision</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Optional label of the decision, name is used when not provided</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.build__16lp2w" />  ExpressionDecision.Build() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub)           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


Builds the expression decision definition



```csharp
protected internal override IDmnDecision Build()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)</dt><dd>Decision definition built</dd></dl>Overrides: [DmnBuilderElement&lt;TBuilder,TResult&gt;.Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.build__rlrom0)


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the expression or output variable is not defined in builder</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.requires_net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref___1vafzm7" />  ExpressionDecision.Requires(Decision.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub)           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


Adds the required decision reference to the decision.



```csharp
public ExpressionDecision Requires(Decision.Ref decision)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4) <strong>decision</strong></dt><dd>Reference to the decision this decision depends on</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub)</dt><dd></dd></dl>


###  Remarks ###
When executing the decision, the engine checks for required decisions and executes them before executing this decision


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.requires_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___4jzelp" />  ExpressionDecision.Requires(Variable.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub)           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


Adds the required input reference to the decision.



```csharp
public ExpressionDecision Requires(Variable.Ref input)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>input</strong></dt><dd>Reference to the input variable</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub)</dt><dd></dd></dl>


###  Remarks ###
Required inputs represents the &quot;link&quot; between input and decision in a model. Technically, the input requirements (existence of the input) are not checked during the execution, it&#39;s more for better understanding the DMN model


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.setexpression_system.string___i40673" />  ExpressionDecision.SetExpression(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub)           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


Sets the expression to be evaluated when the expression decision is executed



```csharp
private void SetExpression(string expression)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Expression to be evaluated when the expression decision is executed</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>When the <strong>expression</strong> is null</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the <strong>expression</strong> is empty or whitespace</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.setoutput_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___7x74za" />  ExpressionDecision.SetOutput(Variable.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub)           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


Sets the output variable to store the result of the decision expression evaluation to



```csharp
private void SetOutput(Variable.Ref variable)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>variable</strong></dt><dd>Reference to the variable used to store the expression decision output</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>When the <strong>variable</strong> is null</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the <strong>variable</strong> can&#39;t be found in [VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko)</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.tostring__lpbv7s" />  ExpressionDecision.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub)           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: [Decision.ToString()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.tostring__1gi326q)Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder__v3hf38" />  ExpressionDecision.ExpressionDecisionSrcBuilder Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


Helper builder used to configure the expression decision definition using the chain of builders. [ExpressionDecision.ExpressionDecisionSrcBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder__v3hf38) provides [Put(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder.put_system.string___1klf8dt) method to define the expression and returns [ExpressionDecision.ExpressionDecisionVarBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder__1pb5wlr) used to define the output variable.



```csharp
public class ExpressionDecision.ExpressionDecisionSrcBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder.decision__3smyuk) | private | &quot;Parent&quot; expression decision builder. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ExpressionDecision.ExpressionDecisionSrcBuilder(ExpressionDecision)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision___t5f73g) | internal | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Put(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder.put_system.string___1klf8dt) | public | Sets the expression of the expression decision | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder.decision__3smyuk" />  ExpressionDecision.ExpressionDecisionSrcBuilder.Decision Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ExpressionDecision.ExpressionDecisionSrcBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder__v3hf38)           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


&quot;Parent&quot; expression decision builder.



```csharp
private ExpressionDecision Decision { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision___t5f73g" />  ExpressionDecision.ExpressionDecisionSrcBuilder.ExpressionDecision.ExpressionDecisionSrcBuilder(ExpressionDecision) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ExpressionDecision.ExpressionDecisionSrcBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder__v3hf38)           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


CTOR



```csharp
internal ExpressionDecision.ExpressionDecisionSrcBuilder(ExpressionDecision decision)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub) <strong>decision</strong></dt><dd>&quot;Parent&quot; expression decision builder</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder.put_system.string___1klf8dt" />  ExpressionDecision.ExpressionDecisionSrcBuilder.Put(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ExpressionDecision.ExpressionDecisionSrcBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionsrcbuilder__v3hf38)           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


Sets the expression of the expression decision



```csharp
public ExpressionDecision.ExpressionDecisionVarBuilder Put(string expression)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Expression to be evaluated</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision.ExpressionDecisionVarBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder__1pb5wlr)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder__1pb5wlr" />  ExpressionDecision.ExpressionDecisionVarBuilder Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


Helper builder used to configure the expression decision definition using the chain of builders. [ExpressionDecision.ExpressionDecisionVarBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder__1pb5wlr) provides [To(Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder.to_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___c89334) method to define output variable and returns [&amp;quot;final&amp;quot; expression decision builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub) that can be used to configure the required inputs and decisions when needed and to fully build the expression decision



```csharp
public class ExpressionDecision.ExpressionDecisionVarBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder.decision__10aval5) | private | &quot;Parent&quot; expression decision builder. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ExpressionDecision.ExpressionDecisionVarBuilder(ExpressionDecision)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision___1kso2qh) | internal | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [To(Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder.to_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___c89334) | public | Sets the output variable to store the result of the decision expression evaluation to | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder.decision__10aval5" />  ExpressionDecision.ExpressionDecisionVarBuilder.Decision Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ExpressionDecision.ExpressionDecisionVarBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder__1pb5wlr)           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


&quot;Parent&quot; expression decision builder.



```csharp
private ExpressionDecision Decision { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision___1kso2qh" />  ExpressionDecision.ExpressionDecisionVarBuilder.ExpressionDecision.ExpressionDecisionVarBuilder(ExpressionDecision) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ExpressionDecision.ExpressionDecisionVarBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder__1pb5wlr)           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


CTOR



```csharp
internal ExpressionDecision.ExpressionDecisionVarBuilder(ExpressionDecision decision)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub) <strong>decision</strong></dt><dd>&quot;Parent&quot; expression decision builder</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder.to_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___c89334" />  ExpressionDecision.ExpressionDecisionVarBuilder.To(Variable.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ExpressionDecision.ExpressionDecisionVarBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision.expressiondecisionvarbuilder__1pb5wlr)           
Sources: engine\definition\builder\ExpressionDecision.cs</small>


Sets the output variable to store the result of the decision expression evaluation to



```csharp
public ExpressionDecision To(Variable.Ref variable)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>variable</strong></dt><dd>Reference to the variable used to store the expression decision output</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.ExpressionDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.expressiondecision__1s8ywub)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b" />  TableDecision Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\TableDecision.cs</small>


Decision table definition builder



```csharp
public sealed class TableDecision : Decision
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement__vtdze1) -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision,net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv) -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision__10m2s6x)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Aggregation](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.aggregation__1i05h11) | public | Decision table hit policy aggregation type (default [List](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum.list__u0sgin) ) | 
 | [HitPolicy](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.hitpolicy__p9bwpk) | public | Decision table hit policy (default [Unique](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.unique__pve6y6) ) | 
 | [Inputs](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.inputs__uly3kc) | public | Table input builders | 
 | [InputsByRef](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.inputsbyref__1xk6tj6) | private | Table input builders by reference | 
 | [InputsInternal](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.inputsinternal__1otlpjj) | private | Internal list of table input builders | 
 | [Outputs](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.outputs__f7vbt1) | public | Table output builders | 
 | [OutputsByRef](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.outputsbyref__vacu4z) | private | Table output builders by reference | 
 | [OutputsInternal](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.outputsinternal__1txfwyc) | private | Internal list of table output builders | 
 | [Rules](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.rules__1s3sg9g) | public | Table rule builders | 
 | [RulesInternal](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.rulesinternal__188ezfn) | private | Internal list of table rule builders | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TableDecision(VariableCatalog, DecisionCatalog, string, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog-system.string-system.string___155akoa) | internal | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.build__1hn8ora) | protected internal | Builds the decision table definition | 
 | [Requires(Decision.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.requires_net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref___1ouroor) | public | Adds the required decision reference to the decision. | 
 | [Requires(Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.requires_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___q7t18x) | public | Adds the required input reference to the decision. | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.tostring__12dgu3i) | public | Returns a string that represents the current object. | 
 | [WithAggregation(CollectHitPolicyAggregationEnum)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withaggregation_net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum___h94lek) | public | Sets the hit policy aggregation type of the decision table | 
 | [WithHitPolicy(HitPolicyEnum)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withhitpolicy_net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum___iicj6b) | public | Sets the hit policy of the decision table | 
 | [WithInput(string, string, TableInput.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withinput_system.string-system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-___m0ytt1) | public | Adds the expression based table input | 
 | [WithInput(string, string, TableInput.Ref, string[])](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withinput_system.string-system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref--system.string_____12t3i0x) | public | Adds the expression based table input | 
 | [WithInput(string, TableInput.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withinput_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-___doh04v) | public | Adds the expression based table input | 
 | [WithInput(string, TableInput.Ref, string[])](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withinput_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref--system.string_____s6xlm3) | public | Adds the expression based table input | 
 | [WithInput(string, Variable.Ref, TableInput.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withinput_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-___1etnm8x) | public | Adds the variable based table input | 
 | [WithInput(string, Variable.Ref, TableInput.Ref, string[])](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withinput_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref--system.string_____ptv0yl) | public | Adds the variable based table input | 
 | [WithInput(Variable.Ref, TableInput.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withinput_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-___ki40pf) | public | Adds the variable based table input | 
 | [WithInput(Variable.Ref, TableInput.Ref, string[])](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withinput_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref--system.string_____12svflb) | public | Adds the variable based table input | 
 | [WithOutput(string, Variable.Ref, TableOutput.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withoutput_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-___qspahh) | public | Adds the table output with reference to the variable to store the output value to | 
 | [WithOutput(string, Variable.Ref, TableOutput.Ref, string[])](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withoutput_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref--system.string_____1ex7ad5) | public | Adds the table output with reference to the variable to store the output value to | 
 | [WithOutput(Variable.Ref, TableOutput.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withoutput_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-___1nspfcj) | public | Adds the table output with reference to the variable to store the output value to | 
 | [WithOutput(Variable.Ref, TableOutput.Ref, string[])](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withoutput_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref--system.string_____17tdb2v) | public | Adds the table output with reference to the variable to store the output value to | 
 | [WithRule(string, Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleInputBuilder,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleOutputBuilder&gt;)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withrule_system.string-system.func_net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder____1381d49) | public | Adds the table rule. | 
 | [WithRule(string, string, Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleInputBuilder,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleOutputBuilder&gt;)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withrule_system.string-system.string-system.func_net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder____zlu0cr) | public | Adds the table rule. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.aggregation__1i05h11" />  TableDecision.Aggregation Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Decision table hit policy aggregation type (default [List](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum.list__u0sgin) )



```csharp
public CollectHitPolicyAggregationEnum Aggregation { get; private set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.hitpolicy__p9bwpk" />  TableDecision.HitPolicy Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Decision table hit policy (default [Unique](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.unique__pve6y6) )



```csharp
public HitPolicyEnum HitPolicy { get; private set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.inputs__uly3kc" />  TableDecision.Inputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Table input builders



```csharp
public IReadOnlyList<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput> Inputs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.inputsbyref__1xk6tj6" />  TableDecision.InputsByRef Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Table input builders by reference



```csharp
private Dictionary<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput> InputsByRef { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.inputsinternal__1otlpjj" />  TableDecision.InputsInternal Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Internal list of table input builders



```csharp
private List<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput> InputsInternal { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.outputs__f7vbt1" />  TableDecision.Outputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Table output builders



```csharp
public IReadOnlyList<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput> Outputs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.outputsbyref__vacu4z" />  TableDecision.OutputsByRef Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Table output builders by reference



```csharp
private Dictionary<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput> OutputsByRef { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.outputsinternal__1txfwyc" />  TableDecision.OutputsInternal Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Internal list of table output builders



```csharp
private List<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput> OutputsInternal { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.rules__1s3sg9g" />  TableDecision.Rules Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Table rule builders



```csharp
public IReadOnlyList<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule> Rules { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.rulesinternal__188ezfn" />  TableDecision.RulesInternal Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Internal list of table rule builders



```csharp
private List<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule> RulesInternal { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog-system.string-system.string___155akoa" />  TableDecision.TableDecision(VariableCatalog, DecisionCatalog, string, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


CTOR



```csharp
internal TableDecision(VariableCatalog variables, DecisionCatalog decisions, string name, string label = null)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) <strong>variables</strong></dt><dd>[VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) managing the definition builder variables</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) <strong>decisions</strong></dt><dd>[DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) managing the definition builder decisions</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Unique name of the decision</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Optional label of the decision, name is used when not provided</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.build__1hn8ora" />  TableDecision.Build() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Builds the decision table definition



```csharp
protected internal override IDmnDecision Build()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6)</dt><dd>Table decision definition built</dd></dl>Overrides: [DmnBuilderElement&lt;TBuilder,TResult&gt;.Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.build__rlrom0)


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when there is no input, no output or no rule defined in builder</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.requires_net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref___1ouroor" />  TableDecision.Requires(Decision.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Adds the required decision reference to the decision.



```csharp
public TableDecision Requires(Decision.Ref decision)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.ref__fi37g4) <strong>decision</strong></dt><dd>Reference to the decision this decision depends on</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Remarks ###
When executing the decision, the engine checks for required decisions and executes them before executing this decision


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.requires_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___q7t18x" />  TableDecision.Requires(Variable.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Adds the required input reference to the decision.



```csharp
public TableDecision Requires(Variable.Ref input)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>input</strong></dt><dd>Reference to the input variable</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Remarks ###
Required inputs represents the &quot;link&quot; between input and decision in a model. Technically, the input requirements (existence of the input) are not checked during the execution, it&#39;s more for better understanding the DMN model


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.tostring__12dgu3i" />  TableDecision.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: [Decision.ToString()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.decision.tostring__1gi326q)Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withaggregation_net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum___h94lek" />  TableDecision.WithAggregation(CollectHitPolicyAggregationEnum) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Sets the hit policy aggregation type of the decision table



```csharp
public TableDecision WithAggregation(CollectHitPolicyAggregationEnum aggregation)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9) <strong>aggregation</strong></dt><dd>Hit policy aggregation</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withhitpolicy_net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum___iicj6b" />  TableDecision.WithHitPolicy(HitPolicyEnum) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Sets the hit policy of the decision table



```csharp
public TableDecision WithHitPolicy(HitPolicyEnum hitPolicy)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz) <strong>hitPolicy</strong></dt><dd>Decision table hit policy</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withinput_system.string-system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-___m0ytt1" />  TableDecision.WithInput(string, string, TableInput.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Adds the expression based table input



```csharp
public TableDecision WithInput(string label, string expression, out TableInput.Ref inputRef)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Input label, &quot;Input#{Index}&quot; will be used if not provided</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Expression to be used as table input</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6) <strong>inputRef</strong></dt><dd>Reference to added table input that can be used in rule builders</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Remarks ###
The inputs are &quot;indexed&quot; in the order as added to the table definition builder


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>when the <strong>expression</strong> is not provided</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd>when the <strong>expression</strong> is empty or whitespace</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withinput_system.string-system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref--system.string_____12t3i0x" />  TableDecision.WithInput(string, string, TableInput.Ref, string[]) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Adds the expression based table input



```csharp
public TableDecision WithInput(string label, string expression, out TableInput.Ref inputRef, params string[] allowedValues)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Input label, &quot;Input#{Index}&quot; will be used if not provided</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Expression to be used as table input</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6) <strong>inputRef</strong></dt><dd>Reference to added table input that can be used in rule builders</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>allowedValues</strong></dt><dd>Allowed input values</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Remarks ###
The inputs are &quot;indexed&quot; in the order as added to the table definition builder


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>when the <strong>expression</strong> is not provided</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd>when the <strong>expression</strong> is empty or whitespace</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withinput_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-___doh04v" />  TableDecision.WithInput(string, TableInput.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Adds the expression based table input



```csharp
public TableDecision WithInput(string expression, out TableInput.Ref inputRef)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Expression to be used as table input</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6) <strong>inputRef</strong></dt><dd>Reference to added table input that can be used in rule builders</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Remarks ###
The inputs are &quot;indexed&quot; in the order as added to the table definition builder


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>when the <strong>expression</strong> is not provided</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd>when the <strong>expression</strong> is empty or whitespace</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withinput_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref--system.string_____s6xlm3" />  TableDecision.WithInput(string, TableInput.Ref, string[]) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Adds the expression based table input



```csharp
public TableDecision WithInput(string expression, out TableInput.Ref inputRef, params string[] allowedValues)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Expression to be used as table input</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6) <strong>inputRef</strong></dt><dd>Reference to added table input that can be used in rule builders</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>allowedValues</strong></dt><dd>Allowed input values</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Remarks ###
The inputs are &quot;indexed&quot; in the order as added to the table definition builder


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>when the <strong>expression</strong> is not provided</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd>when the <strong>expression</strong> is empty or whitespace</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withinput_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-___1etnm8x" />  TableDecision.WithInput(string, Variable.Ref, TableInput.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Adds the variable based table input



```csharp
public TableDecision WithInput(string label, Variable.Ref variableRef, out TableInput.Ref inputRef)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Input label, &quot;Input#{Index}&quot; will be used if not provided</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>variableRef</strong></dt><dd>Reference to variable used as table input</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6) <strong>inputRef</strong></dt><dd>Reference to added table input that can be used in rule builders</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Remarks ###
The inputs are &quot;indexed&quot; in the order as added to the table definition builder


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withinput_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref--system.string_____ptv0yl" />  TableDecision.WithInput(string, Variable.Ref, TableInput.Ref, string[]) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Adds the variable based table input



```csharp
public TableDecision WithInput(string label, Variable.Ref variableRef, out TableInput.Ref inputRef, params string[] allowedValues)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Input label, &quot;Input#{Index}&quot; will be used if not provided</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>variableRef</strong></dt><dd>Reference to variable used as table input</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6) <strong>inputRef</strong></dt><dd>Reference to added table input that can be used in rule builders</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>allowedValues</strong></dt><dd>Allowed input values</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Remarks ###
The inputs are &quot;indexed&quot; in the order as added to the table definition builder


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>when the <strong>variableRef</strong> is not provided</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withinput_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-___ki40pf" />  TableDecision.WithInput(Variable.Ref, TableInput.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Adds the variable based table input



```csharp
public TableDecision WithInput(Variable.Ref variableRef, out TableInput.Ref inputRef)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>variableRef</strong></dt><dd>Reference to variable used as table input</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6) <strong>inputRef</strong></dt><dd>Reference to added table input that can be used in rule builders</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Remarks ###
The inputs are &quot;indexed&quot; in the order as added to the table definition builder


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withinput_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref--system.string_____12svflb" />  TableDecision.WithInput(Variable.Ref, TableInput.Ref, string[]) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Adds the variable based table input



```csharp
public TableDecision WithInput(Variable.Ref variableRef, out TableInput.Ref inputRef, params string[] allowedValues)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>variableRef</strong></dt><dd>Reference to variable used as table input</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6) <strong>inputRef</strong></dt><dd>Reference to added table input that can be used in rule builders</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>allowedValues</strong></dt><dd>Allowed input values</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Remarks ###
The inputs are &quot;indexed&quot; in the order as added to the table definition builder


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>when the <strong>variableRef</strong> is not provided</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withoutput_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-___qspahh" />  TableDecision.WithOutput(string, Variable.Ref, TableOutput.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Adds the table output with reference to the variable to store the output value to



```csharp
public TableDecision WithOutput(string label, Variable.Ref variableRef, out TableOutput.Ref outputRef)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Output label, &quot;Output#{Index}&quot; will be used if not provided</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>variableRef</strong></dt><dd>Reference to variable used to store the table output to</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff) <strong>outputRef</strong></dt><dd>Reference to added table output that can be used in rule builders</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Remarks ###
The outputs are &quot;indexed&quot; in the order as added to the table definition builder


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>when the <strong>variableRef</strong> is not provided</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withoutput_system.string-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref--system.string_____1ex7ad5" />  TableDecision.WithOutput(string, Variable.Ref, TableOutput.Ref, string[]) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Adds the table output with reference to the variable to store the output value to



```csharp
public TableDecision WithOutput(string label, Variable.Ref variableRef, out TableOutput.Ref outputRef, params string[] allowedValues)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Output label, &quot;Output#{Index}&quot; will be used if not provided</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>variableRef</strong></dt><dd>Reference to variable used to store the table output to</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff) <strong>outputRef</strong></dt><dd>Reference to added table output that can be used in rule builders</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>allowedValues</strong></dt><dd>Allowed output values</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Remarks ###
The outputs are &quot;indexed&quot; in the order as added to the table definition builder


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>when the <strong>variableRef</strong> is not provided</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withoutput_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-___1nspfcj" />  TableDecision.WithOutput(Variable.Ref, TableOutput.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Adds the table output with reference to the variable to store the output value to



```csharp
public TableDecision WithOutput(Variable.Ref variableRef, out TableOutput.Ref outputRef)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>variableRef</strong></dt><dd>Reference to variable used to store the table output to</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff) <strong>outputRef</strong></dt><dd>Reference to added table output that can be used in rule builders</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Remarks ###
The outputs are &quot;indexed&quot; in the order as added to the table definition builder


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>when the <strong>variableRef</strong> is not provided</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withoutput_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref--system.string_____17tdb2v" />  TableDecision.WithOutput(Variable.Ref, TableOutput.Ref, string[]) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Adds the table output with reference to the variable to store the output value to



```csharp
public TableDecision WithOutput(Variable.Ref variableRef, out TableOutput.Ref outputRef, params string[] allowedValues)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>variableRef</strong></dt><dd>Reference to variable used to store the table output to</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff) <strong>outputRef</strong></dt><dd>Reference to added table output that can be used in rule builders</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>allowedValues</strong></dt><dd>Allowed output values</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Remarks ###
The outputs are &quot;indexed&quot; in the order as added to the table definition builder


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>when the <strong>variableRef</strong> is not provided</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withrule_system.string-system.func_net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder____1381d49" />  TableDecision.WithRule(string, Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleInputBuilder,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleOutputBuilder&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Adds the table rule.



```csharp
public TableDecision WithRule(string name, Func<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleInputBuilder,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleOutputBuilder> builder)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the table rule</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleInputBuilder,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleOutputBuilder&gt;</a> <strong>builder</strong></dt><dd>Builder used to create the rule definition (see [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5) for details)</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>when the <strong>name</strong> is not provided</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd>when the <strong>name</strong> is empty or whitespace</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>when the <strong>builder</strong> is not provided</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the rule with given <strong>name</strong> already exists</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision.withrule_system.string-system.string-system.func_net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder____zlu0cr" />  TableDecision.WithRule(string, string, Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleInputBuilder,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleOutputBuilder&gt;) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)           
Sources: engine\definition\builder\TableDecision.cs</small>


Adds the table rule.



```csharp
public TableDecision WithRule(string name, string description, Func<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleInputBuilder,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleOutputBuilder> builder)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the table rule</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>description</strong></dt><dd>Description of th rule</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleInputBuilder,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleOutputBuilder&gt;</a> <strong>builder</strong></dt><dd>Builder used to create the rule definition (see [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5) for details)</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableDecision](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tabledecision__1yrne6b)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>when the <strong>name</strong> is not provided</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd>when the <strong>name</strong> is empty or whitespace</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>when the <strong>builder</strong> is not provided</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the rule with given <strong>name</strong> already exists</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5" />  TableInput Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\TableInput.cs</small>


Definition of decision table input - contains index (order), mapping to the source variable or source expression, and optional list of allowed values



```csharp
public sealed class TableInput : DmnBuilderElement<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput,net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableInput>
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement__vtdze1) -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput,net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableInput&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv)           



###  Remarks ###
Source variable and source expression are mutually exclusive and one of them has to be provided.


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllowedValues](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.allowedvalues__op80rn) | public | Optional array of allowed values | 
 | [Expression](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.expression__1qyeeix) | public | Input source expression (the evaluated expression is compared to the rules) | 
 | [Index](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.index__1ni5qtd) | public | Index of the input (order) | 
 | [Label](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.label__5x8usx) | public | Input label, &quot;Input#{Index}&quot; will be used if not provided | 
 | [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.refctor__jm8zq0) | private static | Reference CTOR delegate | 
 | [Reference](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.reference__7vrh5e) | public | Table input reference that can be used in other builders | 
 | [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.variable__51nqyh) | public | Reference to input source variable (the variable value is compared to the rules) | 
 | [VariableInternal](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.variableinternal__fuf9h4) | private | Input source variable (the variable value is compared to the rules) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TableInput()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.-cctor__1vahg3g) | private static | Static CTOR - forces the run of [TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6) static CTOR to ensure that [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.refctor__jm8zq0) is properly initialized | 
 | [TableInput(VariableCatalog, DecisionCatalog, int, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog-system.int32-system.string___jlourj) | internal | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.build__ffj7k8) | protected internal | Builds the decision table input definition | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.tostring__1tet1g8) | public | Returns a string that represents the current object. | 
 | [WithAllowedValues(string[])](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.withallowedvalues_system.string_____1s8723x) | public | Sets the list of values allowed for the input | 
 | [WithExpression(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.withexpression_system.string___216i3t) | public | Binds the table input to given expression | 
 | [WithoutAllowedValuesConstraint()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.withoutallowedvaluesconstraint__e9z9mz) | public | Clears the list of values allowed for the input | 
 | [WithVariable(Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.withvariable_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___1a2r0xp) | public | Binds the table input to given variable reference | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.allowedvalues__op80rn" />  TableInput.AllowedValues Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)           
Sources: engine\definition\builder\TableInput.cs</small>


Optional array of allowed values



```csharp
public string[] AllowedValues { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.expression__1qyeeix" />  TableInput.Expression Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)           
Sources: engine\definition\builder\TableInput.cs</small>


Input source expression (the evaluated expression is compared to the rules)



```csharp
public string Expression { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


###  Remarks ###
Source variable and source expression are mutually exclusive.


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.index__1ni5qtd" />  TableInput.Index Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)           
Sources: engine\definition\builder\TableInput.cs</small>


Index of the input (order)



```csharp
public int Index { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


###  Remarks ###
The inputs are &quot;indexed&quot; in the order as added to the table definition builder


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.label__5x8usx" />  TableInput.Label Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)           
Sources: engine\definition\builder\TableInput.cs</small>


Input label, &quot;Input#{Index}&quot; will be used if not provided



```csharp
public string Label { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.refctor__jm8zq0" />  TableInput.RefCtor Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)           
Sources: engine\definition\builder\TableInput.cs</small>


Reference CTOR delegate



```csharp
private static Func<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref> RefCtor { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref&gt;</a></dt><dd></dd></dl>


###  Remarks ###
The idea is to allow only &quot;owner class&quot; to be able to create the instances of the nested class. Nested class has the private CTOR. Static CTOR of nested class (Ref) sets the delegate to 
```csharp
RefCtor = owner => new Ref(owner)
```
 , so such delegate can be used within the owner class to create the instances of nested class.


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.reference__7vrh5e" />  TableInput.Reference Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)           
Sources: engine\definition\builder\TableInput.cs</small>


Table input reference that can be used in other builders



```csharp
public TableInput.Ref Reference { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.variable__51nqyh" />  TableInput.Variable Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)           
Sources: engine\definition\builder\TableInput.cs</small>


Reference to input source variable (the variable value is compared to the rules)



```csharp
public Variable.Ref Variable { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau)</dt><dd></dd></dl>


###  Remarks ###
Source variable and source expression are mutually exclusive.


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.variableinternal__fuf9h4" />  TableInput.VariableInternal Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)           
Sources: engine\definition\builder\TableInput.cs</small>


Input source variable (the variable value is compared to the rules)



```csharp
private Variable VariableInternal { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)</dt><dd></dd></dl>


###  Remarks ###
Source variable and source expression are mutually exclusive.


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.-cctor__1vahg3g" />  TableInput.TableInput() Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)           
Sources: engine\definition\builder\TableInput.cs</small>


Static CTOR - forces the run of [TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6) static CTOR to ensure that [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.refctor__jm8zq0) is properly initialized



```csharp
private static TableInput()
```

Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog-system.int32-system.string___jlourj" />  TableInput.TableInput(VariableCatalog, DecisionCatalog, int, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)           
Sources: engine\definition\builder\TableInput.cs</small>


CTOR



```csharp
internal TableInput(VariableCatalog variables, DecisionCatalog decisions, int index, string label = null)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) <strong>variables</strong></dt><dd>[VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) managing the definition builder variables</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) <strong>decisions</strong></dt><dd>[DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) managing the definition builder decisions</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>index</strong></dt><dd>Index of the input (order)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Input label, &quot;Input#{Index}&quot; will be used if not provided</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.build__ffj7k8" />  TableInput.Build() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)           
Sources: engine\definition\builder\TableInput.cs</small>


Builds the decision table input definition



```csharp
protected internal override DmnDecisionTableInput Build()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__qptrq2)</dt><dd>Decision table input definition built</dd></dl>Overrides: [DmnBuilderElement&lt;TBuilder,TResult&gt;.Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.build__rlrom0)


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when neither expression nor variable is defined for the input</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.tostring__1tet1g8" />  TableInput.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)           
Sources: engine\definition\builder\TableInput.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.withallowedvalues_system.string_____1s8723x" />  TableInput.WithAllowedValues(string[]) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)           
Sources: engine\definition\builder\TableInput.cs</small>


Sets the list of values allowed for the input



```csharp
public TableInput WithAllowedValues(string[] allowedValues)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>allowedValues</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.withexpression_system.string___216i3t" />  TableInput.WithExpression(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)           
Sources: engine\definition\builder\TableInput.cs</small>


Binds the table input to given expression



```csharp
public TableInput WithExpression(string expression)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expression</strong></dt><dd>Expression to be used as the table input source</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when <strong>expression</strong> is missing</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a></dt><dd>Throws <a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception" target="_blank" >System.ArgumentException</a> when <strong>expression</strong> is empty or whitespace</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.withoutallowedvaluesconstraint__e9z9mz" />  TableInput.WithoutAllowedValuesConstraint() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)           
Sources: engine\definition\builder\TableInput.cs</small>


Clears the list of values allowed for the input



```csharp
public TableInput WithoutAllowedValuesConstraint()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.withvariable_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___1a2r0xp" />  TableInput.WithVariable(Variable.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)           
Sources: engine\definition\builder\TableInput.cs</small>


Binds the table input to given variable reference



```csharp
public TableInput WithVariable(Variable.Ref variableRef)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>variableRef</strong></dt><dd>Reference to variable used as the table input source</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when <strong>variableRef</strong> is missing</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when <strong>variableRef</strong> can&#39;t be found in the variable catalog</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6" />  TableInput.Ref Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\TableInput.cs</small>


Table input definition builder reference class



```csharp
public sealed class TableInput.Ref
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Index](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref.index__1aqetd4) | public | Index (order) of the table input | 
 | [Input](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref.input__yy8ao0) | private | Encapsulated table input (&quot;owner&quot; of the reference) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TableInput.Ref()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref.-cctor__61i49r) | private static | Static CTOR - sets the [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.refctor__jm8zq0) delegate to Ref&#39;s private instance CTOR allowing the &quot;owner&quot; to create the Ref instances | 
 | [TableInput.Ref(TableInput)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput___1eq46ss) | private | Private CTOR - accessible from &quot;owner class&quot; via [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.refctor__jm8zq0) | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref.index__1aqetd4" />  TableInput.Ref.Index Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6)           
Sources: engine\definition\builder\TableInput.cs</small>


Index (order) of the table input



```csharp
public int Index { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref.input__yy8ao0" />  TableInput.Ref.Input Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6)           
Sources: engine\definition\builder\TableInput.cs</small>


Encapsulated table input (&quot;owner&quot; of the reference)



```csharp
private TableInput Input { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref.-cctor__61i49r" />  TableInput.Ref.TableInput.Ref() Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6)           
Sources: engine\definition\builder\TableInput.cs</small>


Static CTOR - sets the [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.refctor__jm8zq0) delegate to Ref&#39;s private instance CTOR allowing the &quot;owner&quot; to create the Ref instances



```csharp
private static TableInput.Ref()
```

Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput___1eq46ss" />  TableInput.Ref.TableInput.Ref(TableInput) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6)           
Sources: engine\definition\builder\TableInput.cs</small>


Private CTOR - accessible from &quot;owner class&quot; via [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.refctor__jm8zq0)



```csharp
private TableInput.Ref(TableInput input)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput__5wt9j5) <strong>input</strong></dt><dd>Table input to create the reference for</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu" />  TableOutput Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\TableOutput.cs</small>


Definition of decision table output - contains index (order), mapping to the variable and optional list of allowed values



```csharp
public sealed class TableOutput : DmnBuilderElement<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput,net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableOutput>
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement__vtdze1) -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput,net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableOutput&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllowedValues](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.allowedvalues__1kwrsb6) | public | Optional array of allowed values | 
 | [Index](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.index__jqbhjg) | public | Index of the output (order) | 
 | [Label](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.label__1xlvsdy) | public | Output label, &quot;Output#{Index}&quot; will be used if not provided | 
 | [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.refctor__1rhfe95) | private static | Reference CTOR delegate | 
 | [Reference](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.reference__1jho6w1) | public | Table output reference that can be used in other builders | 
 | [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.variable__yjr5g4) | public | Reference to variable to store the output to | 
 | [VariableInternal](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.variableinternal__qr2mv7) | private | Variable to store the output to | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TableOutput()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.-cctor__kms0td) | private static | Static CTOR - forces the run of [TableOutput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff) static CTOR to ensure that [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.refctor__1rhfe95) is properly initialized | 
 | [TableOutput(VariableCatalog, DecisionCatalog, int, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog-system.int32-system.string___1njjmq) | internal | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.build__1jze84t) | protected internal | Builds the decision table output definition | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.tostring__2tljv1) | public | Returns a string that represents the current object. | 
 | [WithAllowedValues(string[])](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.withallowedvalues_system.string_____ks15za) | public | Sets the list of values allowed for the output | 
 | [WithoutAllowedValuesConstraint()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.withoutallowedvaluesconstraint__807am) | public | Clears the list of values allowed for the output | 
 | [WithVariable(Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.withvariable_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___exc3h0) | public | Binds the table output to given variable reference | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.allowedvalues__1kwrsb6" />  TableOutput.AllowedValues Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)           
Sources: engine\definition\builder\TableOutput.cs</small>


Optional array of allowed values



```csharp
public string[] AllowedValues { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.index__jqbhjg" />  TableOutput.Index Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)           
Sources: engine\definition\builder\TableOutput.cs</small>


Index of the output (order)



```csharp
public int Index { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


###  Remarks ###
The outputs are &quot;indexed&quot; in the order as added to the table definition builder


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.label__1xlvsdy" />  TableOutput.Label Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)           
Sources: engine\definition\builder\TableOutput.cs</small>


Output label, &quot;Output#{Index}&quot; will be used if not provided



```csharp
public string Label { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.refctor__1rhfe95" />  TableOutput.RefCtor Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)           
Sources: engine\definition\builder\TableOutput.cs</small>


Reference CTOR delegate



```csharp
private static Func<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref> RefCtor { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref&gt;</a></dt><dd></dd></dl>


###  Remarks ###
The idea is to allow only &quot;owner class&quot; to be able to create the instances of the nested class. Nested class has the private CTOR. Static CTOR of nested class (Ref) sets the delegate to 
```csharp
RefCtor = owner => new Ref(owner)
```
 , so such delegate can be used within the owner class to create the instances of nested class.


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.reference__1jho6w1" />  TableOutput.Reference Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)           
Sources: engine\definition\builder\TableOutput.cs</small>


Table output reference that can be used in other builders



```csharp
public TableOutput.Ref Reference { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.variable__yjr5g4" />  TableOutput.Variable Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)           
Sources: engine\definition\builder\TableOutput.cs</small>


Reference to variable to store the output to



```csharp
public Variable.Ref Variable { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.variableinternal__qr2mv7" />  TableOutput.VariableInternal Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)           
Sources: engine\definition\builder\TableOutput.cs</small>


Variable to store the output to



```csharp
private Variable VariableInternal { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.-cctor__kms0td" />  TableOutput.TableOutput() Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)           
Sources: engine\definition\builder\TableOutput.cs</small>


Static CTOR - forces the run of [TableOutput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff) static CTOR to ensure that [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.refctor__1rhfe95) is properly initialized



```csharp
private static TableOutput()
```

Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog-system.int32-system.string___1njjmq" />  TableOutput.TableOutput(VariableCatalog, DecisionCatalog, int, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)           
Sources: engine\definition\builder\TableOutput.cs</small>


CTOR



```csharp
internal TableOutput(VariableCatalog variables, DecisionCatalog decisions, int index, string label = null)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) <strong>variables</strong></dt><dd>[VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) managing the definition builder variables</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) <strong>decisions</strong></dt><dd>[DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) managing the definition builder decisions</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>index</strong></dt><dd>Index of the output (order)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Output label, &quot;Output#{Index}&quot; will be used if not provided</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.build__1jze84t" />  TableOutput.Build() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)           
Sources: engine\definition\builder\TableOutput.cs</small>


Builds the decision table output definition



```csharp
protected internal override DmnDecisionTableOutput Build()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput__nhnleh)</dt><dd>Decision table output definition built</dd></dl>Overrides: [DmnBuilderElement&lt;TBuilder,TResult&gt;.Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.build__rlrom0)


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the output variable is not defined in builder</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.tostring__2tljv1" />  TableOutput.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)           
Sources: engine\definition\builder\TableOutput.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.withallowedvalues_system.string_____ks15za" />  TableOutput.WithAllowedValues(string[]) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)           
Sources: engine\definition\builder\TableOutput.cs</small>


Sets the list of values allowed for the output



```csharp
public TableOutput WithAllowedValues(string[] allowedValues)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>allowedValues</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.withoutallowedvaluesconstraint__807am" />  TableOutput.WithoutAllowedValuesConstraint() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)           
Sources: engine\definition\builder\TableOutput.cs</small>


Clears the list of values allowed for the output



```csharp
public TableOutput WithoutAllowedValuesConstraint()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.withvariable_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___exc3h0" />  TableOutput.WithVariable(Variable.Ref) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)           
Sources: engine\definition\builder\TableOutput.cs</small>


Binds the table output to given variable reference



```csharp
public TableOutput WithVariable(Variable.Ref variableRef)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>variableRef</strong></dt><dd>Reference to variable used as the table output destination</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when <strong>variableRef</strong> is missing</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when <strong>variableRef</strong> can&#39;t be found in the variable catalog</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff" />  TableOutput.Ref Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\TableOutput.cs</small>


Table output definition builder reference class



```csharp
public sealed class TableOutput.Ref
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Index](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref.index__1kqr02r) | public | Index (order) of the table output | 
 | [Output](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref.output__h6eiww) | private | Encapsulated table output (&quot;owner&quot; of the reference) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TableOutput.Ref()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref.-cctor__1gd0n5e) | private static | Static CTOR - sets the [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.refctor__1rhfe95) delegate to Ref&#39;s private instance CTOR allowing the &quot;owner&quot; to create the Ref instances | 
 | [TableOutput.Ref(TableOutput)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput___azjaus) | private | Private CTOR - accessible from &quot;owner class&quot; via [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.refctor__1rhfe95) | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref.index__1kqr02r" />  TableOutput.Ref.Index Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff)           
Sources: engine\definition\builder\TableOutput.cs</small>


Index (order) of the table output



```csharp
public int Index { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref.output__h6eiww" />  TableOutput.Ref.Output Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff)           
Sources: engine\definition\builder\TableOutput.cs</small>


Encapsulated table output (&quot;owner&quot; of the reference)



```csharp
private TableOutput Output { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref.-cctor__1gd0n5e" />  TableOutput.Ref.TableOutput.Ref() Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff)           
Sources: engine\definition\builder\TableOutput.cs</small>


Static CTOR - sets the [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.refctor__1rhfe95) delegate to Ref&#39;s private instance CTOR allowing the &quot;owner&quot; to create the Ref instances



```csharp
private static TableOutput.Ref()
```

Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput___azjaus" />  TableOutput.Ref.TableOutput.Ref(TableOutput) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableOutput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff)           
Sources: engine\definition\builder\TableOutput.cs</small>


Private CTOR - accessible from &quot;owner class&quot; via [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.refctor__1rhfe95)



```csharp
private TableOutput.Ref(TableOutput output)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput__1sn9ecu) <strong>output</strong></dt><dd>Table output to create the reference for</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5" />  TableRule Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\TableRule.cs</small>


Decision table rule definition builder Rule definition is built using the chain of builders provided as lambda/delegate when calling 
```csharp
TableDecision.WithRule
```
 . The table inputs and outputs must be defined in TableDecision builder first, as the rule builders must be provided with proper table input/output references.

 The builder chain provides methods to define the input conditions (When, When.And[.And], Always) and the output calculations (Then, Then.And[.And], SkipOutput)

 Syntax examples:

 
```csharp
rule.When(input1Ref, "input 1 eval expression").Then(output1Ref, "output 1 calc expression")
```


 
```csharp
rule.When(input1Ref, "input 1 eval expression").And(input2Ref, "input 2 eval expression").Then(output1Ref, "output 1 calc expression").And(output2Ref, "output 2 calc expression")
```


 
```csharp
rule.Always().Then(output1Ref, "output 1 calc expression").And(output2Ref, "output 2 calc expression")
```


 
```csharp
rule.When(input1Ref, "input 1 eval expression").SkipOutput()
```


 
```csharp
rule.When(input1Ref, "input 1 eval expression").And(input2Ref, "input 2 eval expression").SkipOutput()
```


 
```csharp
rule.Always().SkipOutput()
```


  [TableRule.TableRuleInputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder__1yj4dla) provides [When(TableInput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder.when_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-system.string___liomuk) method to provide the first input condition and returns [TableRule.TableRuleInputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder__1yj4dla) .

 [TableRule.TableRuleInputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder__1yj4dla) provides [Always()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder.always__muenim) method to let the rule accept any input and returns [TableRule.TableRuleThenOnlyBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder__1xu4ma9) .

 [TableRule.TableRuleThenOrAndBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br) provides [And(TableInput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.and_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-system.string___ie3ztu) method provide the additional input condition and returns [TableRule.TableRuleThenOrAndBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br) .

 [TableRule.TableRuleThenOrAndBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br) provides [Then(TableOutput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.then_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-system.string___k06qrt) method to provide the first output expression and returns [TableRule.TableRuleAndOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder__1z0ktcy) .

 [TableRule.TableRuleThenOrAndBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br) provides [SkipOutput()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.skipoutput__1erqm32) method to skip the output calculation and returns [TableRule.TableRuleOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder__18hetz1) .

 [TableRule.TableRuleThenOnlyBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder__1xu4ma9) provides [Then(TableOutput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder.then_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-system.string___7sc76z) method to provide the first output calculation and returns [TableRule.TableRuleAndOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder__1z0ktcy) .

 [TableRule.TableRuleThenOnlyBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder__1xu4ma9) provides [SkipOutput()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder.skipoutput__bxdug) method to skip the output calculation and returns [TableRule.TableRuleOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder__18hetz1) .

 [TableRule.TableRuleAndOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder__1z0ktcy) inherits from [TableRule.TableRuleOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder__18hetz1) and provides [And(TableOutput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder.and_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-system.string___ttut00) method to provide the additional output calculation and returns [TableRule.TableRuleAndOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder__1z0ktcy) .

 [TableRule.TableRuleOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder__18hetz1) is the final rule builder.





```csharp
public sealed class TableRule : DmnBuilderElement<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule,net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule>
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement__vtdze1) -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule,net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllTableInputs](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.alltableinputs__e5l0th) | private | All inputs defined for decision table (by reference) | 
 | [AllTableOutputs](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.alltableoutputs__1pvqhfy) | private | All outputs defined for decision table (by reference) | 
 | [Description](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.description__kq90e9) | public | Optional rule description (annotation) | 
 | [Index](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.index__1sfu2qp) | public | Index (order) of the rule within the decision table | 
 | [Inputs](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.inputs__lx4x7g) | public | Definition of decision table rule inputs as a dictionary of pairs table input reference and the evaluation expression | 
 | [InputsInternal](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.inputsinternal__1pnl7fl) | private | Internal definition of decision table rule inputs as a dictionary of pairs table input reference and the evaluation expression | 
 | [Name](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.name__jmrvie) | public | Rule name | 
 | [Outputs](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.outputs__1a28hub) | public | Definition of decision table rule outputs as a dictionary of pairs table output reference and the calculation expression | 
 | [OutputsInternal](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.outputsinternal__1w0k6q8) | private | Internal definition of decision table rule outputs as a dictionary of pairs table output reference and the calculation expression | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TableRule(VariableCatalog, DecisionCatalog, IReadOnlyDictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput&gt;, IReadOnlyDictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput&gt;, int, string, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog-system.collections.generic.ireadonlydictionary_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput_-system.collections.generic.ireadonlydictionary_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput_-system.int32-system.string-system.string___10qikih) | internal | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.build__1po6hr6) | protected internal | Builds the decision table rule definition | 
 | [ClearInputs()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.clearinputs__jfa60q) | private | Clears input expressions for all inputs | 
 | [ClearOutputs()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.clearoutputs__1ww44wn) | private | Clears the output calculation expressions for all outputs | 
 | [SetInput(TableInput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.setinput_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-system.string___19sjs2l) | private | Sets the input expression for the input referenced by <strong>inputRef</strong> | 
 | [SetOutput(TableOutput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.setoutput_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-system.string___1npn6u9) | private | Sets the output expression for the output referenced by <strong>outputRef</strong> | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tostring__1i4ly5e) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.alltableinputs__e5l0th" />  TableRule.AllTableInputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)           
Sources: engine\definition\builder\TableRule.cs</small>


All inputs defined for decision table (by reference)



```csharp
private IReadOnlyDictionary<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput> AllTableInputs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.alltableoutputs__1pvqhfy" />  TableRule.AllTableOutputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)           
Sources: engine\definition\builder\TableRule.cs</small>


All outputs defined for decision table (by reference)



```csharp
private IReadOnlyDictionary<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput> AllTableOutputs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.description__kq90e9" />  TableRule.Description Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)           
Sources: engine\definition\builder\TableRule.cs</small>


Optional rule description (annotation)



```csharp
public string Description { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.index__1sfu2qp" />  TableRule.Index Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)           
Sources: engine\definition\builder\TableRule.cs</small>


Index (order) of the rule within the decision table



```csharp
public int Index { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.inputs__lx4x7g" />  TableRule.Inputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)           
Sources: engine\definition\builder\TableRule.cs</small>


Definition of decision table rule inputs as a dictionary of pairs table input reference and the evaluation expression



```csharp
public IReadOnlyDictionary<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref,string> Inputs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref,string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.inputsinternal__1pnl7fl" />  TableRule.InputsInternal Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)           
Sources: engine\definition\builder\TableRule.cs</small>


Internal definition of decision table rule inputs as a dictionary of pairs table input reference and the evaluation expression



```csharp
private Dictionary<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref,string> InputsInternal { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref,string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.name__jmrvie" />  TableRule.Name Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)           
Sources: engine\definition\builder\TableRule.cs</small>


Rule name



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.outputs__1a28hub" />  TableRule.Outputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)           
Sources: engine\definition\builder\TableRule.cs</small>


Definition of decision table rule outputs as a dictionary of pairs table output reference and the calculation expression



```csharp
public IReadOnlyDictionary<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref,string> Outputs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref,string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.outputsinternal__1w0k6q8" />  TableRule.OutputsInternal Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)           
Sources: engine\definition\builder\TableRule.cs</small>


Internal definition of decision table rule outputs as a dictionary of pairs table output reference and the calculation expression



```csharp
private Dictionary<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref,string> OutputsInternal { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref,string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog-system.collections.generic.ireadonlydictionary_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput_-system.collections.generic.ireadonlydictionary_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput_-system.int32-system.string-system.string___10qikih" />  TableRule.TableRule(VariableCatalog, DecisionCatalog, IReadOnlyDictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput&gt;, IReadOnlyDictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput&gt;, int, string, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)           
Sources: engine\definition\builder\TableRule.cs</small>


CTOR



```csharp
internal TableRule(VariableCatalog variables, DecisionCatalog decisions, IReadOnlyDictionary<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput> allTableInputs, IReadOnlyDictionary<net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput> allTableOutputs, int index, string name, string description = null)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) <strong>variables</strong></dt><dd>[VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) managing the definition builder variables</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) <strong>decisions</strong></dt><dd>[DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) managing the definition builder decisions</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput&gt;</a> <strong>allTableInputs</strong></dt><dd>All inputs defined for table (by reference)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput&gt;</a> <strong>allTableOutputs</strong></dt><dd>All outputs defined for table (by reference)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>index</strong></dt><dd>Index of the rule (order)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Table unique rule name</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>description</strong></dt><dd>Optional rule description</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.build__1po6hr6" />  TableRule.Build() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)           
Sources: engine\definition\builder\TableRule.cs</small>


Builds the decision table rule definition



```csharp
protected internal override DmnDecisionTableRule Build()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko)</dt><dd>Decision table rule definition built</dd></dl>Overrides: [DmnBuilderElement&lt;TBuilder,TResult&gt;.Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.build__rlrom0)


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the rule name is not defined in the builder</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.clearinputs__jfa60q" />  TableRule.ClearInputs() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)           
Sources: engine\definition\builder\TableRule.cs</small>


Clears input expressions for all inputs



```csharp
private void ClearInputs()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.clearoutputs__1ww44wn" />  TableRule.ClearOutputs() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)           
Sources: engine\definition\builder\TableRule.cs</small>


Clears the output calculation expressions for all outputs



```csharp
private void ClearOutputs()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.setinput_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-system.string___19sjs2l" />  TableRule.SetInput(TableInput.Ref, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)           
Sources: engine\definition\builder\TableRule.cs</small>


Sets the input expression for the input referenced by <strong>inputRef</strong>



```csharp
private void SetInput(TableInput.Ref inputRef, string inputExpression)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6) <strong>inputRef</strong></dt><dd>Reference to decision table input</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>inputExpression</strong></dt><dd>Input evaluation expression</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Remarks ###
When the expression is null or whitespace the table input will not be used for the rule (will be removed when it was already defined before). When the expression is &quot;valid&quot; and the input expression has been defined before, it will override it


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>Throws <a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a> when the <strong>inputRef</strong> is null</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the <strong>inputRef</strong> is not recognized as the valid table input</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.setoutput_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-system.string___1npn6u9" />  TableRule.SetOutput(TableOutput.Ref, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)           
Sources: engine\definition\builder\TableRule.cs</small>


Sets the output expression for the output referenced by <strong>outputRef</strong>



```csharp
private void SetOutput(TableOutput.Ref outputRef, string outputExpression)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff) <strong>outputRef</strong></dt><dd>Reference to decision table output</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>outputExpression</strong></dt><dd>Output calculation expression</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Remarks ###
When the expression is null or whitespace the table output will not be used for the rule (will be removed when it was already defined before). When the expression is &quot;valid&quot; and the output expression has been defined before, it will override it


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>Throws <a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a> when the <strong>outputRef</strong> is null</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the <strong>outputRef</strong> is not recognized as the valid table output</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tostring__1i4ly5e" />  TableRule.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)           
Sources: engine\definition\builder\TableRule.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder__1z0ktcy" />  TableRule.TableRuleAndOutputBuilder Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\TableRule.cs</small>


Helper builder used to configure the decision table rule definition using the chain of builders.



```csharp
public class TableRule.TableRuleAndOutputBuilder : TableRule.TableRuleOutputBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder__18hetz1)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TableRule.TableRuleAndOutputBuilder(TableRule)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule___1o9b96q) | internal | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [And(TableOutput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder.and_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-system.string___ttut00) | public | Sets the output expression for the output referenced by <strong>outputRef</strong> | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule___1o9b96q" />  TableRule.TableRuleAndOutputBuilder.TableRule.TableRuleAndOutputBuilder(TableRule) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleAndOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder__1z0ktcy)           
Sources: engine\definition\builder\TableRule.cs</small>


CTOR



```csharp
internal TableRule.TableRuleAndOutputBuilder(TableRule rule)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5) <strong>rule</strong></dt><dd>&quot;Parent&quot;rule builder</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder.and_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-system.string___ttut00" />  TableRule.TableRuleAndOutputBuilder.And(TableOutput.Ref, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleAndOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder__1z0ktcy)           
Sources: engine\definition\builder\TableRule.cs</small>


Sets the output expression for the output referenced by <strong>outputRef</strong>



```csharp
public TableRule.TableRuleAndOutputBuilder And(TableOutput.Ref outputRef, string outputExpression)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff) <strong>outputRef</strong></dt><dd>Reference to decision table output</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>outputExpression</strong></dt><dd>Output calculation expression</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleAndOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder__1z0ktcy)</dt><dd></dd></dl>


###  Remarks ###
When the expression is null or whitespace the table output will not be used for the rule (will be removed when it was already defined before). When the expression is &quot;valid&quot; and the output expression has been defined before, it will override it


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>Throws <a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a> when the <strong>outputRef</strong> is null</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the <strong>outputRef</strong> is not recognized as the valid table output</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder__1yj4dla" />  TableRule.TableRuleInputBuilder Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\TableRule.cs</small>


Helper builder used to configure the decision table rule definition using the chain of builders.



```csharp
public class TableRule.TableRuleInputBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Rule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder.rule__lsjyd2) | private | &quot;Parent&quot;rule builder. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TableRule.TableRuleInputBuilder(TableRule)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule___193a70e) | internal | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Always()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder.always__muenim) | public | Skips the input conditions for rule meaning that the rule will accept any input. All existing input conditions, if any, are removed | 
 | [When(TableInput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder.when_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-system.string___liomuk) | public | Sets the input expression for the input referenced by <strong>inputRef</strong> | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder.rule__lsjyd2" />  TableRule.TableRuleInputBuilder.Rule Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleInputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder__1yj4dla)           
Sources: engine\definition\builder\TableRule.cs</small>


&quot;Parent&quot;rule builder.



```csharp
private TableRule Rule { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule___193a70e" />  TableRule.TableRuleInputBuilder.TableRule.TableRuleInputBuilder(TableRule) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleInputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder__1yj4dla)           
Sources: engine\definition\builder\TableRule.cs</small>


CTOR



```csharp
internal TableRule.TableRuleInputBuilder(TableRule rule)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5) <strong>rule</strong></dt><dd>&quot;Parent&quot;rule builder</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder.always__muenim" />  TableRule.TableRuleInputBuilder.Always() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleInputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder__1yj4dla)           
Sources: engine\definition\builder\TableRule.cs</small>


Skips the input conditions for rule meaning that the rule will accept any input. All existing input conditions, if any, are removed



```csharp
public TableRule.TableRuleThenOnlyBuilder Always()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleThenOnlyBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder__1xu4ma9)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder.when_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-system.string___liomuk" />  TableRule.TableRuleInputBuilder.When(TableInput.Ref, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleInputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder__1yj4dla)           
Sources: engine\definition\builder\TableRule.cs</small>


Sets the input expression for the input referenced by <strong>inputRef</strong>



```csharp
public TableRule.TableRuleThenOrAndBuilder When(TableInput.Ref inputRef, string inputExpression)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6) <strong>inputRef</strong></dt><dd>Reference to decision table input</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>inputExpression</strong></dt><dd>Input evaluation expression</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleThenOrAndBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br)</dt><dd></dd></dl>


###  Remarks ###
[When(TableInput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleinputbuilder.when_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-system.string___liomuk) clears all input expressions for the rule first and then add the <strong>inputExpression</strong> for <em>inputRef</em> When the expression is null or whitespace the table input will not be used for the rule (will not be added).


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>Throws <a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a> when the <strong>inputRef</strong> is null</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the <strong>inputRef</strong> is not recognized as the valid table input</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder__18hetz1" />  TableRule.TableRuleOutputBuilder Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\TableRule.cs</small>


Helper builder used to configure the decision table rule definition using the chain of builders.



```csharp
public class TableRule.TableRuleOutputBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleAndOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder__1z0ktcy)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Rule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder.rule__cpbmot) | protected | &quot;Parent&quot;rule builder. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TableRule.TableRuleOutputBuilder(TableRule)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule___1gt5kz5) | internal | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder.rule__cpbmot" />  TableRule.TableRuleOutputBuilder.Rule Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder__18hetz1)           
Sources: engine\definition\builder\TableRule.cs</small>


&quot;Parent&quot;rule builder.



```csharp
protected TableRule Rule { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule___1gt5kz5" />  TableRule.TableRuleOutputBuilder.TableRule.TableRuleOutputBuilder(TableRule) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder__18hetz1)           
Sources: engine\definition\builder\TableRule.cs</small>


CTOR



```csharp
internal TableRule.TableRuleOutputBuilder(TableRule rule)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5) <strong>rule</strong></dt><dd>&quot;Parent&quot;rule builder</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder__1xu4ma9" />  TableRule.TableRuleThenOnlyBuilder Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\TableRule.cs</small>


Helper builder used to configure the decision table rule definition using the chain of builders.



```csharp
public class TableRule.TableRuleThenOnlyBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Rule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder.rule__rkqmwx) | private | &quot;Parent&quot;rule builder. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TableRule.TableRuleThenOnlyBuilder(TableRule)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule___1wmmkjh) | internal | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SkipOutput()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder.skipoutput__bxdug) | public | Skips the output definition for the rule (no output to be provided). When there are already any output calculations for the rule, they will be removed/ | 
 | [Then(TableOutput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder.then_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-system.string___7sc76z) | public | Sets the output expression for the output referenced by <strong>outputRef</strong> | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder.rule__rkqmwx" />  TableRule.TableRuleThenOnlyBuilder.Rule Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleThenOnlyBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder__1xu4ma9)           
Sources: engine\definition\builder\TableRule.cs</small>


&quot;Parent&quot;rule builder.



```csharp
private TableRule Rule { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule___1wmmkjh" />  TableRule.TableRuleThenOnlyBuilder.TableRule.TableRuleThenOnlyBuilder(TableRule) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleThenOnlyBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder__1xu4ma9)           
Sources: engine\definition\builder\TableRule.cs</small>


CTOR



```csharp
internal TableRule.TableRuleThenOnlyBuilder(TableRule rule)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5) <strong>rule</strong></dt><dd>&quot;Parent&quot;rule builder</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder.skipoutput__bxdug" />  TableRule.TableRuleThenOnlyBuilder.SkipOutput() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleThenOnlyBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder__1xu4ma9)           
Sources: engine\definition\builder\TableRule.cs</small>


Skips the output definition for the rule (no output to be provided). When there are already any output calculations for the rule, they will be removed/



```csharp
public TableRule.TableRuleOutputBuilder SkipOutput()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder__18hetz1)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder.then_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-system.string___7sc76z" />  TableRule.TableRuleThenOnlyBuilder.Then(TableOutput.Ref, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleThenOnlyBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder__1xu4ma9)           
Sources: engine\definition\builder\TableRule.cs</small>


Sets the output expression for the output referenced by <strong>outputRef</strong>



```csharp
public TableRule.TableRuleAndOutputBuilder Then(TableOutput.Ref outputRef, string outputExpression)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff) <strong>outputRef</strong></dt><dd>Reference to decision table output</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>outputExpression</strong></dt><dd>Output calculation expression</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleAndOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder__1z0ktcy)</dt><dd></dd></dl>


###  Remarks ###
[Then(TableOutput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenonlybuilder.then_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-system.string___7sc76z) clears all output expressions for the rule first and then add the <strong>outputExpression</strong> for <em>outputRef</em> When the expression is null or whitespace the table input will not be used for the rule (will not be added).


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>Throws <a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a> when the <strong>outputRef</strong> is null</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the <strong>outputRef</strong> is not recognized as the valid table output</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br" />  TableRule.TableRuleThenOrAndBuilder Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\TableRule.cs</small>


Helper builder used to configure the decision table rule definition using the chain of builders.



```csharp
public class TableRule.TableRuleThenOrAndBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Rule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.rule__1xy4mmz) | private | &quot;Parent&quot;rule builder. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TableRule.TableRuleThenOrAndBuilder(TableRule)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule___9rma8f) | internal | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [And(TableInput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.and_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-system.string___ie3ztu) | public | Sets the input expression for the input referenced by <strong>inputRef</strong> | 
 | [SkipOutput()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.skipoutput__1erqm32) | public | Skips the output definition for the rule (no output to be provided). When there are already any output calculations for the rule, they will be removed. | 
 | [Then(TableOutput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.then_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-system.string___k06qrt) | public | Sets the output expression for the output referenced by <strong>outputRef</strong> | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.rule__1xy4mmz" />  TableRule.TableRuleThenOrAndBuilder.Rule Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleThenOrAndBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br)           
Sources: engine\definition\builder\TableRule.cs</small>


&quot;Parent&quot;rule builder.



```csharp
private TableRule Rule { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule___9rma8f" />  TableRule.TableRuleThenOrAndBuilder.TableRule.TableRuleThenOrAndBuilder(TableRule) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleThenOrAndBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br)           
Sources: engine\definition\builder\TableRule.cs</small>


CTOR



```csharp
internal TableRule.TableRuleThenOrAndBuilder(TableRule rule)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule__khh4t5) <strong>rule</strong></dt><dd>&quot;Parent&quot;rule builder</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.and_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref-system.string___ie3ztu" />  TableRule.TableRuleThenOrAndBuilder.And(TableInput.Ref, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleThenOrAndBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br)           
Sources: engine\definition\builder\TableRule.cs</small>


Sets the input expression for the input referenced by <strong>inputRef</strong>



```csharp
public TableRule.TableRuleThenOrAndBuilder And(TableInput.Ref inputRef, string inputExpression)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableInput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableinput.ref__1ylq0m6) <strong>inputRef</strong></dt><dd>Reference to decision table input</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>inputExpression</strong></dt><dd>Input evaluation expression</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleThenOrAndBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br)</dt><dd></dd></dl>


###  Remarks ###
When the expression is null or whitespace the table input will not be used for the rule (will be removed when it was already defined before). When the expression is &quot;valid&quot; and the input expression has been defined before, it will override it


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>Throws <a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a> when the <strong>inputRef</strong> is null</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the <strong>inputRef</strong> is not recognized as the valid table input</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.skipoutput__1erqm32" />  TableRule.TableRuleThenOrAndBuilder.SkipOutput() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleThenOrAndBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br)           
Sources: engine\definition\builder\TableRule.cs</small>


Skips the output definition for the rule (no output to be provided). When there are already any output calculations for the rule, they will be removed.



```csharp
public TableRule.TableRuleOutputBuilder SkipOutput()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleoutputbuilder__18hetz1)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.then_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-system.string___k06qrt" />  TableRule.TableRuleThenOrAndBuilder.Then(TableOutput.Ref, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TableRule.TableRuleThenOrAndBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder__1dha7br)           
Sources: engine\definition\builder\TableRule.cs</small>


Sets the output expression for the output referenced by <strong>outputRef</strong>



```csharp
public TableRule.TableRuleAndOutputBuilder Then(TableOutput.Ref outputRef, string outputExpression)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableOutput.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref__1pq6cff) <strong>outputRef</strong></dt><dd>Reference to decision table output</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>outputExpression</strong></dt><dd>Output calculation expression</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.TableRule.TableRuleAndOutputBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tableruleandoutputbuilder__1z0ktcy)</dt><dd></dd></dl>


###  Remarks ###
[Then(TableOutput.Ref, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.tablerule.tablerulethenorandbuilder.then_net.adamec.lib.common.dmn.engine.engine.definition.builder.tableoutput.ref-system.string___k06qrt) clears all output expressions for the rule first and then add the <strong>outputExpression</strong> for <em>outputRef</em> When the expression is null or whitespace the table output will not be used for the rule (will not be added).


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>Throws <a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a> when the <strong>outputRef</strong> is null</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the <strong>outputRef</strong> is not recognized as the valid table output</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr" />  Variable Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\Variable.cs</small>


Variable definition builder



```csharp
public sealed class Variable : DmnBuilderElement<net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition>
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement__vtdze1) -&gt; [net.adamec.lib.common.dmn.engine.engine.definition.builder.DmnBuilderElement&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable,net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition&gt;](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2__xebtv)           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [valueSetters](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#f-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.valuesetters__tw5akw) | private | List of value &quot;setters&quot; for the variable. | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IsInputParameter](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.isinputparameter__1g10ohq) | public | Flag whether the variable represents the input parameter of the decision model. Such variable will be read-only | 
 | [Label](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.label__mb926b) | public | Label of the variable | 
 | [Name](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.name__15zhreq) | public | Name of the variable | 
 | [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.refctor__k3d4tw) | private static | Reference CTOR delegate | 
 | [Reference](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.reference__16954m) | public | Variable reference that can be used in other builders | 
 | [Type](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.type__qzg62l) | public | Type of the variable | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Variable()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.-cctor__rp0g48) | private static | Static CTOR - forces the run of [Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) static CTOR to ensure that [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.refctor__k3d4tw) is properly initialized | 
 | [Variable(VariableCatalog, DecisionCatalog, string, Type, string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog-system.string-system.type-system.string___8nokk5) | internal | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddValueSetter(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.addvaluesetter_system.string___1cqrima) | public | Adds a value setter information to variable definition | 
 | [Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.build__1hd7zk4) | protected internal | Builds the variable definition | 
 | [ForInput()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.forinput__1ennt8x) | public | Flags variable for input | 
 | [CheckAndSetVariableType(Type)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.checkandsetvariabletype_system.type___1lewn9b) | public | Assigns the variable with [Type](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.type__qzg62l) corresponding to the <strong>newType</strong> and returns true. When the variable already contains the type information, it must match with the <strong>newType</strong> , otherwise the [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) is thrown. | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.tostring__dhobjw) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.valuesetters__tw5akw" />  Variable.valueSetters Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)           
Sources: engine\definition\builder\Variable.cs</small>


List of value &quot;setters&quot; for the variable.



```csharp
private readonly List<string> valueSetters
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a></dt><dd></dd></dl>


###  Remarks ###
Can be &quot;Input: {inputName}&quot;, &quot;Table Decision {decisionName}&quot; or &quot;Expression Decision {decisionName}&quot;.


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.isinputparameter__1g10ohq" />  Variable.IsInputParameter Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)           
Sources: engine\definition\builder\Variable.cs</small>


Flag whether the variable represents the input parameter of the decision model. Such variable will be read-only



```csharp
public bool IsInputParameter { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.label__mb926b" />  Variable.Label Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)           
Sources: engine\definition\builder\Variable.cs</small>


Label of the variable



```csharp
public string Label { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.name__15zhreq" />  Variable.Name Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)           
Sources: engine\definition\builder\Variable.cs</small>


Name of the variable



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.refctor__k3d4tw" />  Variable.RefCtor Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)           
Sources: engine\definition\builder\Variable.cs</small>


Reference CTOR delegate



```csharp
private static Func<net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable,net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref> RefCtor { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable,net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref&gt;</a></dt><dd></dd></dl>


###  Remarks ###
The idea is to allow only &quot;owner class&quot; to be able to create the instances of the nested class. Nested class has the private CTOR. Static CTOR of nested class (Ref) sets the delegate to 
```csharp
RefCtor = owner => new Ref(owner)
```
 , so such delegate can be used within the owner class to create the instances of nested class.


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.reference__16954m" />  Variable.Reference Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)           
Sources: engine\definition\builder\Variable.cs</small>


Variable reference that can be used in other builders



```csharp
public Variable.Ref Reference { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.type__qzg62l" />  Variable.Type Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)           
Sources: engine\definition\builder\Variable.cs</small>


Type of the variable



```csharp
public Type Type { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.-cctor__rp0g48" />  Variable.Variable() Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)           
Sources: engine\definition\builder\Variable.cs</small>


Static CTOR - forces the run of [Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) static CTOR to ensure that [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.refctor__k3d4tw) is properly initialized



```csharp
private static Variable()
```

Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog-system.string-system.type-system.string___8nokk5" />  Variable.Variable(VariableCatalog, DecisionCatalog, string, Type, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)           
Sources: engine\definition\builder\Variable.cs</small>


CTOR



```csharp
internal Variable(VariableCatalog variables, DecisionCatalog decisions, string name, Type type = null, string label = null)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) <strong>variables</strong></dt><dd>[VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko) managing the definition builder variables</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) <strong>decisions</strong></dt><dd>[DecisionCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.decisioncatalog__1ghg76) managing the definition builder decisions</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the variable</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd>Optional Type of the variable if known</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>label</strong></dt><dd>Label of the variable (input parameter), name is used when not provided</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.addvaluesetter_system.string___1cqrima" />  Variable.AddValueSetter(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)           
Sources: engine\definition\builder\Variable.cs</small>


Adds a value setter information to variable definition



```csharp
public Variable AddValueSetter(string setter)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>setter</strong></dt><dd>Setter information to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.build__1hd7zk4" />  Variable.Build() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)           
Sources: engine\definition\builder\Variable.cs</small>


Builds the variable definition



```csharp
protected internal override DmnVariableDefinition Build()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88)</dt><dd>Variable definition built</dd></dl>Overrides: [DmnBuilderElement&lt;TBuilder,TResult&gt;.Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderelement-2.build__rlrom0)


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.forinput__1ennt8x" />  Variable.ForInput() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)           
Sources: engine\definition\builder\Variable.cs</small>


Flags variable for input



```csharp
public Variable ForInput()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.checkandsetvariabletype_system.type___1lewn9b" />  Variable.CheckAndSetVariableType(Type) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)           
Sources: engine\definition\builder\Variable.cs</small>


Assigns the variable with [Type](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.type__qzg62l) corresponding to the <strong>newType</strong> and returns true. When the variable already contains the type information, it must match with the <strong>newType</strong> , otherwise the [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) is thrown.



```csharp
public Variable CheckAndSetVariableType(Type newType)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>newType</strong></dt><dd>[Type](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.type__qzg62l) to assign. If null, function returns without an exception (assuming that the type is not know yet)</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Thrown when the <strong>newType</strong> doesn&#39;t match already existing [Type](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.type__qzg62l)</dd><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.tostring__dhobjw" />  Variable.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)           
Sources: engine\definition\builder\Variable.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau" />  Variable.Ref Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\Variable.cs</small>


Variable definition builder reference class



```csharp
public sealed class Variable.Ref
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IsInputParameter](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref.isinputparameter__38gm3b) | public | Flag whether the variable represents the input parameter of the decision model | 
 | [Name](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref.name__yg55kd) | public | Name of the variable | 
 | [Type](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref.type__1h4hyhc) | public | Type of the variable | 
 | [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref.variable__dqonzw) | private | Encapsulated variable (&quot;owner&quot; of the reference) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Variable.Ref()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref.-cctor__1o595rt) | private static | Static CTOR - sets the [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.refctor__k3d4tw) delegate to Ref&#39;s private instance CTOR allowing the &quot;owner&quot; to create the Ref instances | 
 | [Variable.Ref(Variable)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable___1q89m18) | private | Private CTOR - accessible from &quot;owner class&quot; via [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.refctor__k3d4tw) | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref.isinputparameter__38gm3b" />  Variable.Ref.IsInputParameter Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau)           
Sources: engine\definition\builder\Variable.cs</small>


Flag whether the variable represents the input parameter of the decision model



```csharp
public bool IsInputParameter { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref.name__yg55kd" />  Variable.Ref.Name Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau)           
Sources: engine\definition\builder\Variable.cs</small>


Name of the variable



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref.type__1h4hyhc" />  Variable.Ref.Type Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau)           
Sources: engine\definition\builder\Variable.cs</small>


Type of the variable



```csharp
public Type Type { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref.variable__dqonzw" />  Variable.Ref.Variable Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau)           
Sources: engine\definition\builder\Variable.cs</small>


Encapsulated variable (&quot;owner&quot; of the reference)



```csharp
private Variable Variable { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref.-cctor__1o595rt" />  Variable.Ref.Variable.Ref() Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau)           
Sources: engine\definition\builder\Variable.cs</small>


Static CTOR - sets the [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.refctor__k3d4tw) delegate to Ref&#39;s private instance CTOR allowing the &quot;owner&quot; to create the Ref instances



```csharp
private static Variable.Ref()
```

Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable___1q89m18" />  Variable.Ref.Variable.Ref(Variable) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau)           
Sources: engine\definition\builder\Variable.cs</small>


Private CTOR - accessible from &quot;owner class&quot; via [RefCtor](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.refctor__k3d4tw)



```csharp
private Variable.Ref(Variable variable)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr) <strong>variable</strong></dt><dd>Variable to create the reference for</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko" />  VariableCatalog Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\VariableCatalog.cs</small>


Catalog holding the variable definitions (builders) used in [DmnDefinitionBuilder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmndefinitionbuilder__1ic9dr4) and their reference



```csharp
public sealed class VariableCatalog
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [InputData](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.inputdata__izck9e) | public | Input data interface. Input data are stored as Variables with [IsInputParameter](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable.isinputparameter__1benkdl) flag, complex objects are supported | 
 | [IsBuilt](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.isbuilt__m0m6p6) | public | Flag whether the definition has been already built. | 
 | [Variables](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.variables__11k9nuz) | public | Dictionary containing the variable definition builders by variable name | 
 | [VariablesByRef](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.variablesbyref__d8qk5l) | private | Internal dictionary containing the variable definition builders by reference | 
 | [VariablesInternal](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.variablesinternal__pw118a) | private | Internal dictionary containing the variable definition builders by variable name | 

 


###  Indexers ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [this[Variable.Ref]](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.item_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___1qepmpe) | public | Retrieves the [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr) definition builder by its [reference](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddVariable(Variable)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.addvariable_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable___103n67g) | public | Adds a variable to catalog | 
 | [Build()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.build__1vwvi2p) | internal | Builds all variable definitions stored in the catalog | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.tostring__ub6bux) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.inputdata__izck9e" />  VariableCatalog.InputData Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko)           
Sources: engine\definition\builder\VariableCatalog.cs</small>


Input data interface. Input data are stored as Variables with [IsInputParameter](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#p-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable.isinputparameter__1benkdl) flag, complex objects are supported



```csharp
public IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable> InputData { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.isbuilt__m0m6p6" />  VariableCatalog.IsBuilt Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko)           
Sources: engine\definition\builder\VariableCatalog.cs</small>


Flag whether the definition has been already built.



```csharp
public bool IsBuilt { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


###  Remarks ###
When set to true, the definition can&#39;t be modified anymore - the modification functions will throw [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when called


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.item_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___1qepmpe" />  VariableCatalog.this[Variable.Ref] Indexer ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko)           
Sources: engine\definition\builder\VariableCatalog.cs</small>


Retrieves the [Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr) definition builder by its [reference](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau)



```csharp
public Variable this[Variable.Ref reference] { get; }
```

<strong>Indexer parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <em>reference</em></dt><dd>Variable definition builder reference</dd></dl>
<strong>Indexer value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr)</dt><dd></dd></dl>Returns: Variable definition builder or null when the reference is not found           



Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.variables__11k9nuz" />  VariableCatalog.Variables Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko)           
Sources: engine\definition\builder\VariableCatalog.cs</small>


Dictionary containing the variable definition builders by variable name



```csharp
public IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable> Variables { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.variablesbyref__d8qk5l" />  VariableCatalog.VariablesByRef Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko)           
Sources: engine\definition\builder\VariableCatalog.cs</small>


Internal dictionary containing the variable definition builders by reference



```csharp
private Dictionary<net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable> VariablesByRef { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref,net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.variablesinternal__pw118a" />  VariableCatalog.VariablesInternal Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko)           
Sources: engine\definition\builder\VariableCatalog.cs</small>


Internal dictionary containing the variable definition builders by variable name



```csharp
private Dictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable> VariablesInternal { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.addvariable_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable___103n67g" />  VariableCatalog.AddVariable(Variable) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko)           
Sources: engine\definition\builder\VariableCatalog.cs</small>


Adds a variable to catalog



```csharp
public VariableCatalog AddVariable(Variable variable)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable__irqhjr) <strong>variable</strong></dt><dd>Variable definition builder to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko)</dt><dd>This variable catalog</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the catalog has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.build__1vwvi2p" />  VariableCatalog.Build() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko)           
Sources: engine\definition\builder\VariableCatalog.cs</small>


Builds all variable definitions stored in the catalog



```csharp
internal IReadOnlyDictionary<string,net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable> Build()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable&gt;</a></dt><dd>Dictionary of the variable definitions by variable name</dd></dl>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the catalog has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog.tostring__ub6bux" />  VariableCatalog.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [VariableCatalog](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variablecatalog__abzpko)           
Sources: engine\definition\builder\VariableCatalog.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


###  Exceptions ###
<dl><dt>[DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8)</dt><dd>Throws [DmnBuilderException](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.dmnbuilderexception__u6eai8) when the definition has already been built</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee" />  SFeel Struct ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\Sfeel.cs</small>


Helper struct for composing the SFeel input expressions



```csharp
public struct SFeel
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a>           



###  Remarks ###
The struct helps with the syntax, but don&#39;t check for semantics, so it&#39;s necessary to understand how to compose the valid expressions


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [expression](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#f-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.expression__1bjlwj8) | private | String expression represented by [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SFeel(SFeel.Token)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___kupwwq) | private | CTOR - creates an expression from [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Date(DateTime)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.date_system.datetime___mh6epq) | public static | Creates an expression token representing SFeel ```csharp date ``` function | 
 | [Date(int, int, int)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.date_system.int32-system.int32-system.int32___5ha35j) | public static | Creates an expression token representing SFeel ```csharp date ``` function | 
 | [Date(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.date_system.string___u49rim) | public static | Creates an expression token representing SFeel ```csharp date ``` function | 
 | [DateAndTime(DateTime)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.dateandtime_system.datetime___1nqqh78) | public static | Creates an expression token representing SFeel ```csharp date and time ``` function | 
 | [DateAndTime(int, int, int, int, int)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.dateandtime_system.int32-system.int32-system.int32-system.int32-system.int32___17q4gat) | public static | Creates an expression token representing SFeel ```csharp date and time ``` function | 
 | [DateAndTime(int, int, int, int, int, int)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.dateandtime_system.int32-system.int32-system.int32-system.int32-system.int32-system.int32___1o4oi2m) | public static | Creates an expression token representing SFeel ```csharp date and time ``` function | 
 | [DateAndTime(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.dateandtime_system.string___3jczx4) | public static | Creates an expression token representing SFeel ```csharp date and time ``` function | 
 | [DateStr(int, int, int)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.datestr_system.int32-system.int32-system.int32___vxv8sm) | private static | Creates a date time string in ```csharp YYYY-MM-DD ``` format | 
 | [DateTimeStr(int, int, int, int, int, int)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.datetimestr_system.int32-system.int32-system.int32-system.int32-system.int32-system.int32___1kizdym) | private static | Creates a date time string in ```csharp YYYY-MM-DDTHHmmSS ``` format or ```csharp YYYY-MM-DDTHHmm ``` format if <strong>second</strong> is 0 or ```csharp YYYY-MM-DD ``` format if all time parts are 0 | 
 | [Duration(int, int, int, bool)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.duration_system.int32-system.int32-system.int32-system.boolean___lzld36) | public static | Creates an expression token representing SFeel ```csharp duration ``` function | 
 | [Duration(int, int, int, int, int, bool)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.duration_system.int32-system.int32-system.int32-system.int32-system.int32-system.boolean___117u3w0) | public static | Creates an expression token representing SFeel ```csharp duration ``` function | 
 | [Duration(int, int, int, int, int, int, bool)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.duration_system.int32-system.int32-system.int32-system.int32-system.int32-system.int32-system.boolean___ntixv) | public static | Creates an expression token representing SFeel ```csharp duration ``` function | 
 | [Duration(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.duration_system.string___1efzila) | public static | Creates an expression token representing SFeel ```csharp duration ``` function | 
 | [Duration(TimeSpan)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.duration_system.timespan___roecbu) | public static | Creates an expression token representing SFeel ```csharp duration ``` function | 
 | [DurationStr(int, int, int, int, int, int, bool)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.durationstr_system.int32-system.int32-system.int32-system.int32-system.int32-system.int32-system.boolean___cwfd6q) | private static | Creates a string representing the duration in XML (ISO 8601) format (see https://www.w3.org/TR/xmlschema-2/#duration) | 
 | [Eq(SFeel)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.eq_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel___1604dy0) | public static | Creates an equality expression from existing [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) expression | 
 | [Eq(SFeel.Token)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.eq_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___sndcyx) | public static | Creates an equality expression from existing expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) | 
 | [Eq(SFeel.Token[])](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.eq_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token_____yx0afr) | public static |  | 
 | [Expr(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.expr_system.string___8kyoy7) | public static | Creates an expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) from string representing &quot;raw expression&quot; | 
 | [Ge(SFeel.Token)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.ge_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___z1vdhv) | public static | Creates a greater-or-equal expression from existing expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) | 
 | [Gt(SFeel.Token)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.gt_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___2ihwtg) | public static | Creates a greater-than expression from existing expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) | 
 | [Le(SFeel.Token)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.le_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___17vvts) | public static | Creates a less-or-equal expression from existing expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) | 
 | [Lt(SFeel.Token)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.lt_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___13pmh4h) | public static | Creates a less-than expression from existing expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) | 
 | [Ne(SFeel)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.ne_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel___sil8fb) | public static | Creates an inequality expression from existing [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) expression | 
 | [Ne(SFeel.Token)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.ne_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___13bgavq) | public static | Creates an inequality expression from existing expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) | 
 | [Ne(SFeel.Token[])](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.ne_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token_____1bmcsla) | public static |  | 
 | [Not(SFeel)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.not_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel___1hi3q61) | public static | Creates a ```csharp not ``` SFeel expression encapsulating an existing [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) expression | 
 | [Not(SFeel.Token)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.not_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___7yo50c) | public static | Creates a ```csharp not ``` SFeel expression encapsulating an existing expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) | 
 | [Not(SFeel.Token[])](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.not_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token_____1bkcqok) | public static | Creates a ```csharp not ``` SFeel expression encapsulating an existing expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) set | 
 | [Not(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.not_system.string___1ov2909) | public static | Creates a ```csharp not ``` SFeel expression encapsulating an expression string | 
 | [Rng(int, int, bool, bool)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.rng_system.int32-system.int32-system.boolean-system.boolean___1rs7lil) | private static | Creates an expression token representing the range of values | 
 | [RngE(int, int)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.rnge_system.int32-system.int32___101rux0) | public static | Creates an expression token representing the range of values ( ```csharp ]from..to[ ``` ) | 
 | [RngEI(int, int)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.rngei_system.int32-system.int32___1x670ql) | public static | Creates an expression token representing the range of values ( ```csharp ]from..to] ``` ) | 
 | [RngI(int, int)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.rngi_system.int32-system.int32___58kgcw) | public static | Creates an expression token representing the range of values ( ```csharp [from..to] ``` ) | 
 | [RngIE(int, int)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.rngie_system.int32-system.int32___ke01bh) | public static | Creates an expression token representing the range of values ( ```csharp [from..to[ ``` ) | 
 | [Time(int, int)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.time_system.int32-system.int32___1u92glb) | public static | Creates an expression token representing SFeel ```csharp time ``` function | 
 | [Time(int, int, int)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.time_system.int32-system.int32-system.int32___12wpb02) | public static | Creates an expression token representing SFeel ```csharp time ``` function | 
 | [Time(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.time_system.string___17dr4nd) | public static | Creates an expression token representing SFeel ```csharp time ``` function | 
 | [Time(TimeSpan)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.time_system.timespan___1omp3kt) | public static | Creates an expression token representing SFeel ```csharp time ``` function | 
 | [TimeStr(int, int, int)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.timestr_system.int32-system.int32-system.int32___19n2r63) | private static | Creates a time string in ```csharp HHmmSS ``` format or ```csharp HHmm ``` format if <strong>second</strong> is 0 | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.tostring__7y1exh) | public | Returns a string that represents the current object. | 

 


###  Operators and Conversions ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [From(SFeel.Token)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.op_implicit_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token_dtornet.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__7re3vu) | public static | Implicit conversion of [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) to [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) expression | 
 | [ToString(SFeel)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.op_implicit_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel_dtorsystem.string__1l8wtlv) | public static | Implicit conversion of [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a> | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.expression__1bjlwj8" />  SFeel.expression Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


String expression represented by [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)



```csharp
private readonly string expression
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___kupwwq" />  SFeel.SFeel(SFeel.Token) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


CTOR - creates an expression from [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)



```csharp
private SFeel(SFeel.Token t)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>t</strong></dt><dd>Token to create an expression from</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.date_system.datetime___mh6epq" />  SFeel.Date(DateTime) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing SFeel 
```csharp
date
```
 function



```csharp
public static SFeel.Token Date(DateTime dt)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >DateTime</a> <strong>dt</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >System.DateTime</a> to create an SFeel 
```csharp
date
```
 function from</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.date_system.int32-system.int32-system.int32___5ha35j" />  SFeel.Date(int, int, int) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing SFeel 
```csharp
date
```
 function



```csharp
public static SFeel.Token Date(int year, int month, int day)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>year</strong></dt><dd>Years part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>month</strong></dt><dd>Months part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>day</strong></dt><dd>Days part</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.date_system.string___u49rim" />  SFeel.Date(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing SFeel 
```csharp
date
```
 function



```csharp
public static SFeel.Token Date(string s)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>s</strong></dt><dd>String representing the date in 
```csharp
YYYY-MM-DD
```
 format</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.dateandtime_system.datetime___1nqqh78" />  SFeel.DateAndTime(DateTime) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing SFeel 
```csharp
date and time
```
 function



```csharp
public static SFeel.Token DateAndTime(DateTime dt)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >DateTime</a> <strong>dt</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >System.DateTime</a> to create an SFeel 
```csharp
date and time
```
 function from</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


###  Remarks ###
If all time parts are 0 the time part is not generated


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.dateandtime_system.int32-system.int32-system.int32-system.int32-system.int32___17q4gat" />  SFeel.DateAndTime(int, int, int, int, int) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing SFeel 
```csharp
date and time
```
 function



```csharp
public static SFeel.Token DateAndTime(int year, int month, int day, int hour, int minute)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>year</strong></dt><dd>Years part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>month</strong></dt><dd>Months part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>day</strong></dt><dd>Days part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>hour</strong></dt><dd>Hours part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>minute</strong></dt><dd>Minutes part</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


###  Remarks ###
If all time parts are 0 the time part is not generated


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.dateandtime_system.int32-system.int32-system.int32-system.int32-system.int32-system.int32___1o4oi2m" />  SFeel.DateAndTime(int, int, int, int, int, int) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing SFeel 
```csharp
date and time
```
 function



```csharp
public static SFeel.Token DateAndTime(int year, int month, int day, int hour, int minute, int second)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>year</strong></dt><dd>Years part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>month</strong></dt><dd>Months part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>day</strong></dt><dd>Days part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>hour</strong></dt><dd>Hours part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>minute</strong></dt><dd>Minutes part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>second</strong></dt><dd>Seconds part or 0 to skip</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


###  Remarks ###
If all time parts are 0 the time part is not generated


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.dateandtime_system.string___3jczx4" />  SFeel.DateAndTime(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing SFeel 
```csharp
date and time
```
 function



```csharp
public static SFeel.Token DateAndTime(string s)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>s</strong></dt><dd>String representing the date and time in 
```csharp
YYYY-MM-DDTHHmmSS
```
 , 
```csharp
YYYY-MM-DDTHHmm
```
 or 
```csharp
YYYY-MM-DD
```
 format</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.datestr_system.int32-system.int32-system.int32___vxv8sm" />  SFeel.DateStr(int, int, int) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates a date time string in 
```csharp
YYYY-MM-DD
```
 format



```csharp
private static string DateStr(int year, int month, int day)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>year</strong></dt><dd>Years part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>month</strong></dt><dd>Months part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>day</strong></dt><dd>Days part</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.datetimestr_system.int32-system.int32-system.int32-system.int32-system.int32-system.int32___1kizdym" />  SFeel.DateTimeStr(int, int, int, int, int, int) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates a date time string in 
```csharp
YYYY-MM-DDTHHmmSS
```
 format or 
```csharp
YYYY-MM-DDTHHmm
```
 format if <strong>second</strong> is 0 or 
```csharp
YYYY-MM-DD
```
 format if all time parts are 0



```csharp
private static string DateTimeStr(int year, int month, int day, int hour, int minute, int second)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>year</strong></dt><dd>Years part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>month</strong></dt><dd>Months part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>day</strong></dt><dd>Days part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>hour</strong></dt><dd>Hours part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>minute</strong></dt><dd>Minutes part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>second</strong></dt><dd>Seconds part or 0 to skip</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.duration_system.int32-system.int32-system.int32-system.boolean___lzld36" />  SFeel.Duration(int, int, int, bool) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing SFeel 
```csharp
duration
```
 function



```csharp
public static SFeel.Token Duration(int days, int hours, int minutes, bool negative = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>days</strong></dt><dd>Days part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>hours</strong></dt><dd>Hours part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>minutes</strong></dt><dd>Minutes part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>negative</strong></dt><dd>Flag whether the duration is negative</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.duration_system.int32-system.int32-system.int32-system.int32-system.int32-system.boolean___117u3w0" />  SFeel.Duration(int, int, int, int, int, bool) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing SFeel 
```csharp
duration
```
 function



```csharp
public static SFeel.Token Duration(int years, int months, int days, int hours, int minutes, bool negative = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>years</strong></dt><dd>Years part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>months</strong></dt><dd>Months part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>days</strong></dt><dd>Days part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>hours</strong></dt><dd>Hours part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>minutes</strong></dt><dd>Minutes part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>negative</strong></dt><dd>Flag whether the duration is negative</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.duration_system.int32-system.int32-system.int32-system.int32-system.int32-system.int32-system.boolean___ntixv" />  SFeel.Duration(int, int, int, int, int, int, bool) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing SFeel 
```csharp
duration
```
 function



```csharp
public static SFeel.Token Duration(int years, int months, int days, int hours, int minutes, int seconds, bool negative = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>years</strong></dt><dd>Years part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>months</strong></dt><dd>Months part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>days</strong></dt><dd>Days part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>hours</strong></dt><dd>Hours part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>minutes</strong></dt><dd>Minutes part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>seconds</strong></dt><dd>Seconds part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>negative</strong></dt><dd>Flag whether the duration is negative</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.duration_system.string___1efzila" />  SFeel.Duration(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing SFeel 
```csharp
duration
```
 function



```csharp
public static SFeel.Token Duration(string s)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>s</strong></dt><dd>String representing the duration in XML (ISO 8601) format</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.duration_system.timespan___roecbu" />  SFeel.Duration(TimeSpan) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing SFeel 
```csharp
duration
```
 function



```csharp
public static SFeel.Token Duration(TimeSpan ts)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.timespan" target="_blank" >System.TimeSpan</a> <strong>ts</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.timespan" target="_blank" >System.TimeSpan</a> to create an SFeel 
```csharp
duration
```
 function from</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.durationstr_system.int32-system.int32-system.int32-system.int32-system.int32-system.int32-system.boolean___cwfd6q" />  SFeel.DurationStr(int, int, int, int, int, int, bool) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates a string representing the duration in XML (ISO 8601) format (see https://www.w3.org/TR/xmlschema-2/#duration)



```csharp
private static string DurationStr(int years, int months, int days, int hours, int minutes, int seconds, bool negative = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>years</strong></dt><dd>Years part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>months</strong></dt><dd>Months part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>days</strong></dt><dd>Days part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>hours</strong></dt><dd>Hours part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>minutes</strong></dt><dd>Minutes part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>seconds</strong></dt><dd>Seconds part or 0 to skip</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>negative</strong></dt><dd>Flag whether the duration is negative</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.eq_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel___1604dy0" />  SFeel.Eq(SFeel) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an equality expression from existing [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) expression



```csharp
public static string Eq(SFeel e)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) <strong>e</strong></dt><dd>[SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) expression</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.eq_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___sndcyx" />  SFeel.Eq(SFeel.Token) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an equality expression from existing expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)



```csharp
public static string Eq(SFeel.Token t)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>t</strong></dt><dd>Expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.eq_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token_____yx0afr" />  SFeel.Eq(SFeel.Token[]) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>



```csharp
public static string Eq(params SFeel.Token[] t)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token[]](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>t</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.expr_system.string___8kyoy7" />  SFeel.Expr(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) from string representing &quot;raw expression&quot;



```csharp
public static SFeel.Token Expr(string s)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>s</strong></dt><dd>String representing &quot;raw expression&quot;</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.ge_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___z1vdhv" />  SFeel.Ge(SFeel.Token) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates a greater-or-equal expression from existing expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)



```csharp
public static string Ge(SFeel.Token t)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>t</strong></dt><dd>Expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.gt_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___2ihwtg" />  SFeel.Gt(SFeel.Token) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates a greater-than expression from existing expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)



```csharp
public static string Gt(SFeel.Token t)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>t</strong></dt><dd>Expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.le_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___17vvts" />  SFeel.Le(SFeel.Token) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates a less-or-equal expression from existing expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)



```csharp
public static string Le(SFeel.Token t)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>t</strong></dt><dd>Expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.lt_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___13pmh4h" />  SFeel.Lt(SFeel.Token) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates a less-than expression from existing expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)



```csharp
public static string Lt(SFeel.Token t)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>t</strong></dt><dd>Expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.ne_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel___sil8fb" />  SFeel.Ne(SFeel) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an inequality expression from existing [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) expression



```csharp
public static string Ne(SFeel e)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) <strong>e</strong></dt><dd>[SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) expression</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.ne_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___13bgavq" />  SFeel.Ne(SFeel.Token) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an inequality expression from existing expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)



```csharp
public static string Ne(SFeel.Token t)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>t</strong></dt><dd>Expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.ne_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token_____1bmcsla" />  SFeel.Ne(SFeel.Token[]) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>



```csharp
public static string Ne(params SFeel.Token[] t)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token[]](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>t</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.not_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel___1hi3q61" />  SFeel.Not(SFeel) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates a 
```csharp
not
```
 SFeel expression encapsulating an existing [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) expression



```csharp
public static string Not(SFeel e)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) <strong>e</strong></dt><dd>[SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) expression to negate</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.not_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___7yo50c" />  SFeel.Not(SFeel.Token) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates a 
```csharp
not
```
 SFeel expression encapsulating an existing expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)



```csharp
public static string Not(SFeel.Token t)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>t</strong></dt><dd>Expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) to negate</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.not_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token_____1bkcqok" />  SFeel.Not(SFeel.Token[]) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates a 
```csharp
not
```
 SFeel expression encapsulating an existing expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) set



```csharp
public static string Not(params SFeel.Token[] t)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token[]](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>t</strong></dt><dd>Expression [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) set to negate</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.not_system.string___1ov2909" />  SFeel.Not(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates a 
```csharp
not
```
 SFeel expression encapsulating an expression string



```csharp
public static string Not(string s)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>s</strong></dt><dd>Expression to negate</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.rng_system.int32-system.int32-system.boolean-system.boolean___1rs7lil" />  SFeel.Rng(int, int, bool, bool) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing the range of values



```csharp
private static SFeel.Token Rng(int from, int to, bool fromInclusive = true, bool toInclusive = true)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>from</strong></dt><dd>Range opening value</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>to</strong></dt><dd>Range closing value</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>fromInclusive</strong></dt><dd>Flag whether the <strong>from</strong> value is to be included within the range</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>toInclusive</strong></dt><dd>Flag whether the <strong>to</strong> value is to be included within the range</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.rnge_system.int32-system.int32___101rux0" />  SFeel.RngE(int, int) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing the range of values ( 
```csharp
]from..to[
```
 )



```csharp
public static SFeel.Token RngE(int from, int to)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>from</strong></dt><dd>Range opening value (excluding)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>to</strong></dt><dd>Range closing value (excluding)</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.rngei_system.int32-system.int32___1x670ql" />  SFeel.RngEI(int, int) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing the range of values ( 
```csharp
]from..to]
```
 )



```csharp
public static SFeel.Token RngEI(int from, int to)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>from</strong></dt><dd>Range opening value (excluding)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>to</strong></dt><dd>Range closing value (including)</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.rngi_system.int32-system.int32___58kgcw" />  SFeel.RngI(int, int) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing the range of values ( 
```csharp
[from..to]
```
 )



```csharp
public static SFeel.Token RngI(int from, int to)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>from</strong></dt><dd>Range opening value (including)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>to</strong></dt><dd>Range closing value (including)</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.rngie_system.int32-system.int32___ke01bh" />  SFeel.RngIE(int, int) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing the range of values ( 
```csharp
[from..to[
```
 )



```csharp
public static SFeel.Token RngIE(int from, int to)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>from</strong></dt><dd>Range opening value (including)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>to</strong></dt><dd>Range closing value (excluding)</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.time_system.int32-system.int32___1u92glb" />  SFeel.Time(int, int) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing SFeel 
```csharp
time
```
 function



```csharp
public static SFeel.Token Time(int hour, int minute)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>hour</strong></dt><dd>Hours part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>minute</strong></dt><dd>Minutes part</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.time_system.int32-system.int32-system.int32___12wpb02" />  SFeel.Time(int, int, int) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing SFeel 
```csharp
time
```
 function



```csharp
public static SFeel.Token Time(int hour, int minute, int second)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>hour</strong></dt><dd>Hours part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>minute</strong></dt><dd>Minutes part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>second</strong></dt><dd>Seconds part or 0 to skip</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.time_system.string___17dr4nd" />  SFeel.Time(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing SFeel 
```csharp
time
```
 function



```csharp
public static SFeel.Token Time(string s)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>s</strong></dt><dd>String representing the time in 
```csharp
HHmmSS
```
 format or 
```csharp
HHmm
```
 format</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.time_system.timespan___1omp3kt" />  SFeel.Time(TimeSpan) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates an expression token representing SFeel 
```csharp
time
```
 function



```csharp
public static SFeel.Token Time(TimeSpan ts)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.timespan" target="_blank" >System.TimeSpan</a> <strong>ts</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.timespan" target="_blank" >System.TimeSpan</a> to create an SFeel 
```csharp
time
```
 function from</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.timestr_system.int32-system.int32-system.int32___19n2r63" />  SFeel.TimeStr(int, int, int) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Creates a time string in 
```csharp
HHmmSS
```
 format or 
```csharp
HHmm
```
 format if <strong>second</strong> is 0



```csharp
private static string TimeStr(int hour, int minute, int second)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>hour</strong></dt><dd>Hours part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>minute</strong></dt><dd>Minutes part</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>second</strong></dt><dd>Seconds part or 0 to skip</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.tostring__7y1exh" />  SFeel.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.tostring#System_ValueType_ToString" target="_blank" >ValueType.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.op_implicit_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token_dtornet.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__7re3vu" />  SFeel.From(SFeel.Token) Conversion ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Implicit conversion of [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) to [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) expression



```csharp
public static SFeel op_Implicit(SFeel.Token t)
```

<strong>Conversion parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>t</strong></dt><dd>Token to convert to SFeel expression</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.op_implicit_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel_dtorsystem.string__1l8wtlv" />  SFeel.ToString(SFeel) Conversion ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee)           
Sources: engine\definition\builder\Sfeel.cs</small>


Implicit conversion of [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a>



```csharp
public static string op_Implicit(SFeel e)
```

<strong>Conversion parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel__18mxoee) <strong>e</strong></dt><dd>Expression representation to convert to string (expression)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp" />  SFeel.Token Struct ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\builder\Sfeel.cs</small>


Helper struct for composing the SFeel input expression tokens - the single &quot;constant&quot; or variable



```csharp
public struct SFeel.Token
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [value](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#f-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.value__1myu194) | private | String representation of the [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SFeel.Token(bool)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.-ctor_system.boolean___18ln97d) | public | CTOR - create a new token representing a bool constant | 
 | [SFeel.Token(int)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.-ctor_system.int32___y5m58r) | public | CTOR - create a new token representing an integer constant | 
 | [SFeel.Token(SFeel.Token)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___hiwhsx) | private | CTOR | 
 | [SFeel.Token(SFeel.Token[])](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token_____17s1zcz) | public | CTOR - create a new token representing set of tokens (&quot;list of constants/variables&quot;) | 
 | [SFeel.Token(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.-ctor_system.string___1l0frb8) | public | CTOR - create a new token representing a string constant | 
 | [SFeel.Token(string, bool)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.-ctor_system.string-system.boolean___16n4ch3) | internal | CTOR - creates a new [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) based on expression representation ( <strong>isValue</strong> is true) or string constant | 
 | [SFeel.Token(Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___1u21qju) | public | CTOR - create a new token representing a reference to variable | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.tostring__4s6a6m) | public | Returns a string that represents the current object. | 

 


###  Operators and Conversions ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Add(SFeel.Token, SFeel.Token)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.op_addition_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___1fgkk07) | public static | Implicit &quot;+&quot; operator - creates a new set of constants/variables from <strong>token1</strong> and <strong>token2</strong> | 
 | [From(bool)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.op_implicit_system.boolean_dtornet.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__19d0zy) | public static | Implicit conversion from <a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >System.Boolean</a> - creates a token representing a bool constant | 
 | [From(int)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.op_implicit_system.int32_dtornet.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__17pghj2) | public static | Implicit conversion from <a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >System.Int32</a> - creates a token representing an int constant | 
 | [From(string)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.op_implicit_system.string_dtornet.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__1wwhitr) | public static | Implicit conversion from <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a> - creates a token representing a string constant | 
 | [From(Variable.Ref)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.op_implicit_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref_dtornet.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__1hr6p2r) | public static | Implicit conversion from [Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) - creates a token representing a reference to variable | 
 | [ToString(SFeel.Token)](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.op_implicit_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token_dtorsystem.string__1c5a1b) | public static | Implicit conversion of [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a> | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.value__1myu194" />  SFeel.Token.value Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)           
Sources: engine\definition\builder\Sfeel.cs</small>


String representation of the [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)



```csharp
private readonly string value
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.-ctor_system.boolean___18ln97d" />  SFeel.Token.SFeel.Token(bool) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)           
Sources: engine\definition\builder\Sfeel.cs</small>


CTOR - create a new token representing a bool constant



```csharp
public SFeel.Token(bool b)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>b</strong></dt><dd>Bool constant</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.-ctor_system.int32___y5m58r" />  SFeel.Token.SFeel.Token(int) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)           
Sources: engine\definition\builder\Sfeel.cs</small>


CTOR - create a new token representing an integer constant



```csharp
public SFeel.Token(int i)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>i</strong></dt><dd>Integer constant</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___hiwhsx" />  SFeel.Token.SFeel.Token(SFeel.Token) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)           
Sources: engine\definition\builder\Sfeel.cs</small>


CTOR



```csharp
private SFeel.Token(SFeel.Token t)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>t</strong></dt><dd>Existing token to clone</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token_____17s1zcz" />  SFeel.Token.SFeel.Token(SFeel.Token[]) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)           
Sources: engine\definition\builder\Sfeel.cs</small>


CTOR - create a new token representing set of tokens (&quot;list of constants/variables&quot;)



```csharp
public SFeel.Token(params SFeel.Token[] tokens)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token[]](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>tokens</strong></dt><dd>Tokens (&quot;list of constants/variables&quot;) to put into the set</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.-ctor_system.string___1l0frb8" />  SFeel.Token.SFeel.Token(string) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)           
Sources: engine\definition\builder\Sfeel.cs</small>


CTOR - create a new token representing a string constant



```csharp
public SFeel.Token(string s)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>s</strong></dt><dd>String constant</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.-ctor_system.string-system.boolean___16n4ch3" />  SFeel.Token.SFeel.Token(string, bool) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)           
Sources: engine\definition\builder\Sfeel.cs</small>


CTOR - creates a new [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) based on expression representation ( <strong>isValue</strong> is true) or string constant



```csharp
internal SFeel.Token(string s, bool isValue = false)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>s</strong></dt><dd>String constant ( <strong>isValue</strong> is true) or expression</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>isValue</strong></dt><dd>Flag whether represents the expression (value) or string constant</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.-ctor_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref___1u21qju" />  SFeel.Token.SFeel.Token(Variable.Ref) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)           
Sources: engine\definition\builder\Sfeel.cs</small>


CTOR - create a new token representing a reference to variable



```csharp
public SFeel.Token(Variable.Ref variableRef)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>variableRef</strong></dt><dd>Reference to existing variable</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.tostring__4s6a6m" />  SFeel.Token.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)           
Sources: engine\definition\builder\Sfeel.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype.tostring#System_ValueType_ToString" target="_blank" >ValueType.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.op_addition_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token___1fgkk07" />  SFeel.Token.Add(SFeel.Token, SFeel.Token) Operator ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)           
Sources: engine\definition\builder\Sfeel.cs</small>


Implicit &quot;+&quot; operator - creates a new set of constants/variables from <strong>token1</strong> and <strong>token2</strong>



```csharp
public static SFeel.Token operator +(SFeel.Token token1, SFeel.Token token2)
```

<strong>Operator parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>token1</strong></dt><dd>The first token to add to a new set</dd><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>token2</strong></dt><dd>The second token to add to a new set</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


###  Remarks ###
The tokens can be either single constant/variable or already existing set


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.op_implicit_system.boolean_dtornet.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__19d0zy" />  SFeel.Token.From(bool) Conversion ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)           
Sources: engine\definition\builder\Sfeel.cs</small>


Implicit conversion from <a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >System.Boolean</a> - creates a token representing a bool constant



```csharp
public static SFeel.Token op_Implicit(bool b)
```

<strong>Conversion parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>b</strong></dt><dd>Bool constant</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.op_implicit_system.int32_dtornet.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__17pghj2" />  SFeel.Token.From(int) Conversion ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)           
Sources: engine\definition\builder\Sfeel.cs</small>


Implicit conversion from <a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >System.Int32</a> - creates a token representing an int constant



```csharp
public static SFeel.Token op_Implicit(int i)
```

<strong>Conversion parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>i</strong></dt><dd>Integer constant</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.op_implicit_system.string_dtornet.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__1wwhitr" />  SFeel.Token.From(string) Conversion ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)           
Sources: engine\definition\builder\Sfeel.cs</small>


Implicit conversion from <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a> - creates a token representing a string constant



```csharp
public static SFeel.Token op_Implicit(string s)
```

<strong>Conversion parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>s</strong></dt><dd>String constant</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.op_implicit_net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref_dtornet.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__1hr6p2r" />  SFeel.Token.From(Variable.Ref) Conversion ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)           
Sources: engine\definition\builder\Sfeel.cs</small>


Implicit conversion from [Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) - creates a token representing a reference to variable



```csharp
public static SFeel.Token op_Implicit(Variable.Ref variableRef)
```

<strong>Conversion parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable.Ref](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.variable.ref__ekhvau) <strong>variableRef</strong></dt><dd>Reference to existing variable</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token.op_implicit_net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token_dtorsystem.string__1c5a1b" />  SFeel.Token.ToString(SFeel.Token) Conversion ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.builder](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#n-net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp)           
Sources: engine\definition\builder\Sfeel.cs</small>


Implicit conversion of [SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a>



```csharp
public static string op_Implicit(SFeel.Token t)
```

<strong>Conversion parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.builder.SFeel.Token](net.adamec.lib.common.dmn.engine.engine.definition.builder__1eocnfx.md#t-net.adamec.lib.common.dmn.engine.engine.definition.builder.sfeel.token__co8prp) <strong>t</strong></dt><dd>Token to convert to string (expression)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 




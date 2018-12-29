#  DMN Engine Documentation #
##  <a id="namespace-list" />  Namespaces ##

 | Name | Summary | 
 | ------ | --------- | 
 | [net.adamec.lib.common.dmn.engine.engine.decisions](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#n-net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q) |  | 
 | [net.adamec.lib.common.dmn.engine.engine.decisions.expression](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci) |  | 
 | [net.adamec.lib.common.dmn.engine.engine.decisions.table](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k) |  | 
 | [net.adamec.lib.common.dmn.engine.engine.decisions.table.definition](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v) |  | 
 | [net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#n-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am) |  | 
 | [net.adamec.lib.common.dmn.engine.engine.definition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#n-net.adamec.lib.common.dmn.engine.engine.definition__199kcn6) |  | 
 | [net.adamec.lib.common.dmn.engine.engine.runtime](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#n-net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr) |  | 
 | [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa) |  | 
 | [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp) |  | 
 | [net.adamec.lib.common.extensions](net.adamec.lib.common.extensions__1vwuhoq.md#n-net.adamec.lib.common.extensions__1vwuhoq) |  | 
 | [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29) |  | 
 | [net.adamec.lib.common.utils](net.adamec.lib.common.utils__7vdji9.md#n-net.adamec.lib.common.utils__7vdji9) |  | 

##  <a id="type-list" />  Types ##

 | Name | Modifier | Kind | Summary | 
 | ------ | ---------- | ------ | --------- | 
 | [AllowedValues](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues__1bbwvx1) | public | Class | Defines the list of allowed values for decision table inputs and outputs | 
 | [BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps) | public abstract | Class | Helper class for implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> types | 
 | [CommonLogging](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.commonlogging__1dar5wb) | internal static | Class | [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm) factory | 
 | [Decision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9) | public | Class | Single decision within the DMN file It can be expression decision of decision table. Decision table is recognized by having the [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decision.decisiontable__192844l) element, otherwise, the expression decision is expected with elements [Expression](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decision.expression__1qkgb95) and [OutputVariable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decision.outputvariable__1gr23po) | 
 | [DecisionRule](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule__ug9ttn) | public | Class | Decision table rule | 
 | [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr) | public | Class | Decision table definition | 
 | [DecisionTableInput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput__csk49) | public | Class | Decision table input definition | 
 | [DecisionTableOutput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput__63fwne) | public | Class | Decision table output definition | 
 | [DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj) | public abstract | Class | DMN Decision definition | 
 | [DmnDecisionResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionresult__rhbcm) | public | Class | Decision evaluation result (single or multiple) | 
 | [DmnDecisionSingleResult](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecisionsingleresult__12jrmrq) | public | Class | Single decision result | 
 | [DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh) | public | Class | DMN Decision Table definition | 
 | [DmnDecisionTable.PositiveRulesCollectValues](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable.positiverulescollectvalues__z17b4n) | private | Class | Container of aggregate values for positive rules when [Collect](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.collect__t0bm9p) hit policy is used. | 
 | [DmnDecisionTableInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableinput__qptrq2) | public | Class | Definition of decision table input - contains index (order), mapping to the source variable or source expression, and optional list of allowed values | 
 | [DmnDecisionTableOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableoutput__nhnleh) | public | Class | Definition of decision table output - contains index (order), mapping to the variable and optional list of allowed values | 
 | [DmnDecisionTableRule](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontablerule__9p0gko) | public | Class | Definition of table rule | 
 | [DmnDecisionTableRuleExecutionResults](net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime__134n4am.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime.dmndecisiontableruleexecutionresults__1p37jl9) | public | Class | Decision table rules execution results | 
 | [DmnDecisionTableRuleInput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleinput__11odv5c) | public | Class | Definition of decision table rule input - contains the input match evaluation expression and mapping to table input | 
 | [DmnDecisionTableRuleOutput](net.adamec.lib.common.dmn.engine.engine.decisions.table.definition__1xpej0v.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.definition.dmndecisiontableruleoutput__1gob6sb) | public | Class | Definition of decision table rule output - contains the calculation expression and mapping to table output | 
 | [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) | public | Class | DMN model definition for execution engine | 
 | [DmnDefinitionFactory](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinitionfactory__1rr2kdi) | public | Class | Factory that validates and transforms the [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) to [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) that can be executed within [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx) | 
 | [DmnExecutionContext](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontext__10tpicx) | public | Class | Context where is the DMN model executed | 
 | [DmnExecutionContextFactory](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutioncontextfactory__uacnp) | public | Class | Factory creating the DMN Model execution context from [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) or [DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4) | 
 | [DmnExecutionVariable](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutionvariable__15aolfc) | public | Class | Runtime (execution) variable | 
 | [DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.runtime__1b6yzkr.md#t-net.adamec.lib.common.dmn.engine.engine.runtime.dmnexecutorexception__wgl6jc) | public | Class | Exception thrown while executing (evaluating) the DMN Model | 
 | [DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9) | public | Class | Expression decision definition | 
 | [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) | public | Class | Root of DMN definition XML - DMN Model | 
 | [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga) | public | Class | DMN Model XML parser | 
 | [DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7) | public | Class | Exception thrown while parsing the DMN Model | 
 | [DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88) | public | Class | Definition of DMN model variable | 
 | [Expression](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.expression__tql32b) | public | Class | Expression within the DMN definition file | 
 | [IdedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v) | public abstract | Class | Element with id attribute | 
 | [InformationRequirement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement__1lwftc6) | public | Class | Defines the input or decision needed for the decision to be evaluated. The inputs are referenced by [RequiredInput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.requiredinput__jq7sir) sub-element and decisions by [RequiredDecision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.requireddecision__12tqhtx) one. Exactly one of the sub element must be present | 
 | [InformationRequirement.InformationRequirementItem](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.informationrequirementitem__1gbx84m) | public | Class | Required input or decision reference | 
 | [InputData](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.inputdata__jk22hv) | public | Class | Input Data element Defines the input data item provided to the DMN model. The input parameter and related variable are defined by [Name](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.namedelement.name__3ml05) | 
 | [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2) | internal | Class | [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm) extensions | 
 | [NamedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.namedelement__11eai0o) | public abstract | Class | Element with id and name attributes | 
 | [SfeelParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.sfeelparser__1rin914) | public | Class | S-FEEL simple parser | 
 | [TypeExtensions](net.adamec.lib.common.extensions__1vwuhoq.md#t-net.adamec.lib.common.extensions.typeextensions__63ezc8) | internal static | Class | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> extensions | 
 | [Variable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.variable__1klt78r) | public | Class | Variable definition Used in [expression decision definition](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9) to define the output variable | 
 | [IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6) | public abstract | Interface | Decision interface | 
 | [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm) | internal abstract | Interface | Logger interface - wrapper around the <em>NLog.ILogger</em> with some additional methods | 
 | [CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9) | public | Enum | Collect hit policy aggregation type | 
 | [HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz) | public | Enum | Decision Table hit policy - the hit policy specifies what the result of the decision table is in cases of overlapping rules, i.e. when more than one rule matches the input data. | 
 | [InformationRequirementType](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementtype__f6e7u6) | public | Enum | Type of the dependency | 

Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="package-list" />  Source-only packages ##

 | Name | Summary | 
 | ------ | --------- | 
 | [RadCommons.extensions.TypeExtensions.DefaultValue](src-only-packages--.html#src-only-package--RadCommons.extensions.TypeExtensions.DefaultValue) | Provides default value for types (Source only package). | 
 | [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging) | RadCommons logging wrapper around NLog with some extended functionality (Source only package). | 
 | [RadCommons.utils.BaseDisposable](src-only-packages--.html#src-only-package--RadCommons.utils.BaseDisposable) | Helper class for implementation of IDisposable types (Source only package). | 

Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 




# Changelog #
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).
## [1.2.0] - 2022-12-14 ##

### Added ###
DmnExecutionContextOptions now supports external configurations to initialize dynamic expresso interpreter options.

## [1.1.1] - 2022-05-15 ##

### Fixed ###
Diagram Shape `Bounds` and Edged `Waypoint` properties are `double` now (changed in Parser, Definition, Simulator) according to the OMG standard. It was `int` in v1.1.0 and it blocked loading the DMN XML models with double values in boundaries due to a parser exception.
DmnDefinitionFactory ignores unsupported decision types 

### Added ###
Known types now recognize `number` as a `typeRef` in DMN XML and maps it to `decimal` .NET type

### Changed ###
`NormalizeVariableName` replace `-` (dash) with `_` (underscore). The name of (normalized) variable can also start with underscore
When there are multiple DI:Shapes for the same element within the diagram, the element will have multiple extensions, but the extension at Definition level will have just the last one.

## [1.1.0] - 2022-05-13 ##
As this is a major update, it's recommended to go through the [documentation](readme.md) for both "big picture" and the details.

### Breaking changes ###
- `DmnDefinitionFactory` - when building the definition, `RequiredInputs` now contain direct input requirements only (before v1.1.0, it did the recursive check through required decisions and added also the inputs required by them). 
- Removed support for .Net Core 2.1 
  - The library still might work when used in .Net Core 2.1 apps, however it's not being tested against .Net Core 2.1 anymore and no related fixes/updates are expected in future

### Fixed ###
- [Issue#15 Memory leak detected within DmnExecutionContext class](https://github.com/adamecr/Common.DMN.Engine/issues/15) - The (static) parsed expression cache have been split to instance dictionary (for Execution and Context scopes) and to static dictionary (for Definition and Global scopes). The purge methods for individual scopes have been added to `DmnExecutionContext` class. Thanks [@JoanRosell](https://github.com/JoanRosell) for identifying the issue. 
- `DmnDefinition` now implements `IDmnDefinition`

### Added ###
- `DmnParser.DmnVersionEnum.V1_3ext` - new version of algorithm and mapping when building the DmnDefinition from DMN XML. **Read the [documentation](readme.md) for details** as it might have the impact on the way how to prepare DMN XML models for DMN engine when using the extended version (1_3ext). The major change is for table inputs, mapping of table output attributes also changed.
- Support for *extensions* to DMN definition, decision and variable. These can be used to store and manage any custom data, however the engine doesn't "touch" the extensions during the execution. When parsing with version 1_3 and above, the DMN DI shape data are stored as extensions. More information is provided in the [documentation](readme.md).
- Information about `DmnParser.DmnVersionEnum` used/required is added to `DmnModel`. 
- DmnDefinition entities Decision, Variable, Table Input, Table Output now have also the `Label` and `NameWithLabel` properties that might be used for visualization (are not significant for execution).
- Demo application **DMN Engine Simulator** has been added as WPF application targeting .Net 6.0 (Desktop) to demonstrate features of DMN Engine. It uses the `DmnParser.DmnVersionEnum.V1_3ext` when reading the DMN XML files! 
- Support (and test project) for .Net 6.0

### Changed ###
- `DmnDefinitionFactory` protected methods are made virtual and the factory has been refactored a bit allowing to create the customized factories based on the DmnDefinitionFactory.
- Methods `GetAllRequiredInputs` and `GetAllRequiredDecisions` providing the required information through all dependency tree were added to `DmnDecision`.
- Method 'DmnVariableDefinition.NormalizeVariableName` allows the characters `?#$%&*()` in non-normalized variable name. These characters are removed during the normalization without throwing the exception. Public static method `CanNormalizeVariableName` has been added allowing to check the variable name "soft" way.
- Other
  - Referenced NuGet packages versions update
  - Solution now primary for VS2022 (was 2019)


## [1.0.1] - 2022-01-08 ##
### Fixed ###
- [Issue#11 NormalizeVariableName(string name)](https://github.com/adamecr/Common.DMN.Engine/issues/11) -  with the main fix in [PR#12 
allowing international letters like æøå](https://github.com/adamecr/Common.DMN.Engine/pull/12) by [@samuelsen](https://github.com/samuelsen). 

## [1.0.0] - 2021-12-29 ##
As this is a major update, it's recommended to go through the [documentation](readme.md) for both "big picture" and the details.

### Breaking change ###
- Decision table
  - **Allowed input values checks don't throw the exception when the constraint is violated** (see the documentation for more details)

### Added ###

- Definition classes
  - The DMN definition can be created also by code using the builders (`DmnDefinitionBuilder`)

- Execution context
  - New method `WithInputParameters` allowing to set multiple parameters in one call using the dictionary (`IReadOnlyCollection<KeyValuePair<string,object>>`)
  - Decision execution can be traced/audited using the snapshots
  - When the result comes from the decision table, it also provides the list of rules that had a positive hit. Thanks [Noel](https://github.com/nlysaght) for contribution.
  - Execution context can be configured using the `DmnExecutionContextOptions` when calling the factory - set the snapshots on/off, table rules parallel processing, parsed expressions cache
  - Parsed expression cache is now configurable 
  
- Tests
  - Shared code project with tests - "single test code"
    - Hierarchy of test classes for same test but different source (DMN XML 1.1/1.3 or builders)
    - Projects using the shared code targetting different platforms (.net core 2.1, 3.1, 5; .net framework 4.6.2, 4.7.2)

### Changed ###
- Definition classes
  - In general, trying to have kind of immutable public interface after constructed 
  - `DmnVariableDefinition` is "hidden" via R/O `IDmnVariable`. Also the setters are now not public (can be changed via dedicated methods encapsulating the logic)
  - `IDmnVariable` and `IDmnDecision` is used as reference to variable/decision definition
  - `IReadOnlyCollection` is used for required inputs and decision
  - Arrays are used instead of lists for decision table - Inputs, Outpus, Rules, Allowed values

- Execution context
  - Properties are published as `IReadOnlyDictionary` instead of `IDictionary`
  - Parsed expressions cache (static property) is `ConcurrentDictionary` now
  - `DmnExecutionContextFactory` class is static now
  - The execution related classes have been better adapted for the support of extended/customized functionality using the inheritance
  
- Other
  - DynamicExpresso, NLog packages updated to current versions 
  - Solution now primary for VS2019 (was 2017)
  - Updated documentation with more details in some parts
 
### Fixed ###
- When cloning the variables (for example from context to result), the ICloneable value is clonned properly
- DmnExecutionVariable.SetInputParameterValue - type/cast check
- [Issue#8](https://github.com/adamecr/Common.DMN.Engine/issues/8) - ParsedExpressionsCache Corruption when running multiple concurrent evaluations

## [0.1.2] - 2020-07-18 ##
### Added ###
- Support for parsing the DMN 1.3 documents (no additional functionality, just XML namespaces adjustments)

## [0.1.1] - 2019-11-03 ##
### Fixed ###
- Issue with serializer in full .NET framework as described by [@fgollas](https://github.com/fgollas) in [PR#1](https://github.com/adamecr/Common.DMN.Engine/pull/1). Proxy classes are used when there are "hidden" model properties without getters. Added the tests running on .NET framework (the v 0.1.0 code has been tested just for .NET core, where this issue not appeared).
- Some small corrections in read.me

## [0.1.0] - 2018-12-29 ##
### Added ###
- Initial release

[1.1.1]: https://github.com/adamecr/Common.DMN.Engine/compare/v1.1.0...v1.1.1
[1.1.0]: https://github.com/adamecr/Common.DMN.Engine/compare/v1.0.1...v1.1.0
[1.0.1]: https://github.com/adamecr/Common.DMN.Engine/compare/v1.0.0...v1.0.1
[1.0.0]: https://github.com/adamecr/Common.DMN.Engine/compare/v0.1.2...v1.0.0
[0.1.2]: https://github.com/adamecr/Common.DMN.Engine/compare/v0.1.1...v0.1.2
[0.1.1]: https://github.com/adamecr/Common.DMN.Engine/compare/v0.1.0...v0.1.1
[0.1.0]: https://github.com/adamecr/Common.DMN.Engine/releases/tag/v0.1.0
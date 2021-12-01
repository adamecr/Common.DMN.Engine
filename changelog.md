# Changelog #
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).

## [Unreleased] ##
__Version-1__
- Tests
  - Shared code project with tests - "single test code"
    - Hierarchy of test classes for same test but different source (DMN XML 1.1/1.3 or builders)
    - Projects using the shared code targetting different platforms (.net core 2.1, 3.1, 5; .net framework 4.6.2, 4.7.2)


- Definition classes
  - In general, trying to have kind of immutable public interface after constructed 
  - `DmnVariableDefinition` is "hidden" via R/O `IDmnVariable`. Also the setters are now not public (can be changed via dedicated methods encapsulating the logic)
  - `IDmnVariable` and `IDmnDecision` is used are reference to variable/decision definition
  - `IReadOnlyCollection` is used for required inputs and decision
  - Arrays are used instead of lists for decision table - Inputs, Outpus, Rules, Allowed values
  - The DMN definition can be created also by code using the builders (`DmnDefinitionBuilder`)


- Execution context
  - Properties are published as `IReadOnlyDictionary` instead of `IDictionary`
  - Parsed expressions cache (static property) is `ConcurrentDictionary` now
  - New method `WithInputParameters` allowing to set multiple parameters in one call using the dictionary (`IReadOnlyCollection<KeyValuePair<string,object>>`)
  - `DmnExecutionContextFactory` class is static now
  - Decision execution can be traced/audited using the snapshots
  - Execution context can be configured using the `DmnExecutionContextOptions` when calling the factory - set the snapshots on/off, table rules parallel processing, parsed expressions cache
  - FIX: when cloning the variables (for example from context to result), the ICloneable value is clonned properly
  - Parsed expression cache is now configurable 
  - The execution related classes have been better adapted for the support of extended/customized functionality using the inheritance
  - FIX: DmnExecutionVariable.SetInputParameterValue - type/cast check

- Decision table
  - **Allowed input values checks don't throw the exception when the constraint is violated** (see the documentation for more details)

- Other
  - DynamicExpresso, NLog packages to current versions 
  - Solution now primary for VS2019 (was 2017)
 

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

[0.1.2]: https://github.com/adamecr/Common.DMN.Engine/compare/v0.1.1...v0.1.2
[0.1.1]: https://github.com/adamecr/Common.DMN.Engine/compare/v0.1.0...v0.1.1
[0.1.0]: https://github.com/adamecr/Common.DMN.Engine/releases/tag/v0.1.0
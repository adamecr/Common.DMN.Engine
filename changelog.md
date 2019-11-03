# Changelog #
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).

## [0.1.1] - 2019-11-03 ##
### Fixed ###
- Issue with serializer in full .NET framework as described by [@fgollas](https://github.com/fgollas) in [PR#1](https://github.com/adamecr/Common.DMN.Engine/pull/1). Proxy classes are used when there are "hidden" model properties without getters. Added the tests running on .NET framework (the v 0.1.0 code has been tested just for .NET core, where this issue not appeared).
- Some small corrections in read.me

## [0.1.0] - 2018-12-29 ##
### Added ###
- Initial release

[0.1.1]: https://github.com/adamecr/Common.DMN.Engine/compare/v0.1.0...v0.1.1
[0.1.0]: https://github.com/adamecr/Common.DMN.Engine/releases/tag/v0.1.0
#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.logging__1g9pm29" />  net.adamec.lib.common.logging Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CommonLogging](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.commonlogging__1dar5wb) | internal static | [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm) factory | 
 | [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2) | internal | [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm) extensions | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm) | internal abstract | Logger interface - wrapper around the <em>NLog.ILogger</em> with some additional methods | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.logging.commonlogging__1dar5wb" />  CommonLogging Class ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\CommonLogging.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


[ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm) factory



```csharp
internal static class CommonLogging
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CreateLogger(string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.commonlogging.createlogger_system.string___wn77if) | public static | Creates the logger with given <strong>categoryName</strong> | 
 | [CreateLogger(Type)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.commonlogging.createlogger_system.type___uhum9e) | public static | Creates the logger for given type. The name of the logger will be <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type.fullname#System_Type_FullName" target="_blank" >System.Type.FullName</a> | 
 | [CreateLogger&lt;T&gt;()](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.commonlogging.createlogger--1__lp2vax) | public static | Creates the logger for given type. The name of the logger will be <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type.fullname#System_Type_FullName" target="_blank" >System.Type.FullName</a> | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.commonlogging.createlogger_system.string___wn77if" />  CommonLogging.CreateLogger(string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [CommonLogging](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.commonlogging__1dar5wb)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\CommonLogging.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Creates the logger with given <strong>categoryName</strong>



```csharp
public static ILogger CreateLogger(string categoryName)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>categoryName</strong></dt><dd>Name of the logger</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd>Logger instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.commonlogging.createlogger_system.type___uhum9e" />  CommonLogging.CreateLogger(Type) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [CommonLogging](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.commonlogging__1dar5wb)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\CommonLogging.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Creates the logger for given type. The name of the logger will be <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type.fullname#System_Type_FullName" target="_blank" >System.Type.FullName</a>



```csharp
public static ILogger CreateLogger(Type type)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd>Type to create the logger for</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd>Logger instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.commonlogging.createlogger--1__lp2vax" />  CommonLogging.CreateLogger&lt;T&gt;() Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [CommonLogging](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.commonlogging__1dar5wb)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\CommonLogging.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Creates the logger for given type. The name of the logger will be <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type.fullname#System_Type_FullName" target="_blank" >System.Type.FullName</a>



```csharp
public static ILogger CreateLogger<T>()
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd>Type to create the logger for</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd>Logger instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.logging.loggerext__ac9km2" />  LoggerExt Class ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


[ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm) extensions



```csharp
internal class LoggerExt : Logger, ILogger
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; NLog.Logger           
Implements: [net.adamec.lib.common.logging.ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm), NLog.ILogger, NLog.ILoggerBase, NLog.ISuppress


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CreateException&lt;TException&gt;(string, Exception)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.createexception--1_system.string-system.exception___1wtd924) | private static | Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type | 
 | [Debug(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.debug_system.collections.generic.dictionary_system.string-system.object_-system.string___by66ma) | public | Writes the diagnostic message at the `Debug` level. | 
 | [DebugCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.debugcorr_system.string-system.string___i119af) | public | Writes the diagnostic message at the `Debug` level with correlation ID. | 
 | [Error(Dictionary&lt;string,object&gt;, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.error_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___7fy00h) | public | Writes the diagnostic message at the `Error` level. | 
 | [Error(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.error_system.collections.generic.dictionary_system.string-system.object_-system.string___u5pc5h) | public | Writes the diagnostic message at the `Error` level. | 
 | [Error&lt;TException&gt;(string, Exception)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.error--1_system.string-system.exception___1qowqgx) | public | Writes the diagnostic message at the `Error` level. Creates and returns the exception of given type | 
 | [ErrorCorr(string, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.errorcorr_system.string-system.exception-system.string___1tdd1hu) | public | Writes the diagnostic message at the `Error` level with correlation ID. | 
 | [ErrorCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.errorcorr_system.string-system.string___1vt0qk2) | public | Writes the diagnostic message at the `Error` level with correlation ID. | 
 | [ErrorCorr&lt;TException&gt;(string, LoggerExt.TException, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.errorcorr--1_system.string---0-system.string___bk3vj3) | public | Writes the diagnostic message at the `Error` level and returns the exception of given type | 
 | [ErrorCorr&lt;TException&gt;(string, string, Exception)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.errorcorr--1_system.string-system.string-system.exception___4hcjn7) | public | Writes the diagnostic message at the `Error` level with correlation ID. Creates and returns the exception of given type | 
 | [ErrorFltr&lt;TException&gt;(LoggerExt.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.errorfltr--1_--0-system.string-system.boolean___ipfsfa) | public | Writes the diagnostic message at the `Error` level and returns the exception of given type | 
 | [ErrorFltrCorr&lt;TException&gt;(string, LoggerExt.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.errorfltrcorr--1_system.string---0-system.string-system.boolean___84xqu8) | public | Writes the diagnostic message at the `Error` level and returns the exception of given type | 
 | [ErrorPassThrough(Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.errorpassthrough_system.exception-system.string___1ey2kd0) | public | Writes the diagnostic message at the `Error` level and returns given <strong>exception</strong> | 
 | [Fatal(Dictionary&lt;string,object&gt;, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.fatal_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___pw9hcn) | public | Writes the diagnostic message at the `Fatal` level. | 
 | [Fatal(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.fatal_system.collections.generic.dictionary_system.string-system.object_-system.string___1ff2uef) | public | Writes the diagnostic message at the `Fatal` level. | 
 | [Fatal&lt;TException&gt;(string, Exception)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.fatal--1_system.string-system.exception___1myw0tj) | public | Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type | 
 | [FatalCorr(string, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.fatalcorr_system.string-system.exception-system.string___1q1adwi) | public | Writes the diagnostic message at the `Fatal` level with correlation ID. | 
 | [FatalCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.fatalcorr_system.string-system.string___c131ta) | public | Writes the diagnostic message at the `Fatal` level with correlation ID. | 
 | [FatalCorr&lt;TException&gt;(string, LoggerExt.TException, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.fatalcorr--1_system.string---0-system.string___17i1735) | public | Writes the diagnostic message at the `Fatal` level and returns the exception of given type | 
 | [FatalCorr&lt;TException&gt;(string, string, Exception)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.fatalcorr--1_system.string-system.string-system.exception___w1l5gt) | public | Writes the diagnostic message at the `Fatal` level with correlation ID. Creates and returns the exception of given type | 
 | [FatalFltr&lt;TException&gt;(LoggerExt.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.fatalfltr--1_--0-system.string-system.boolean___5rdjqe) | public | Writes the diagnostic message at the `Fatal` level and returns <strong>catchIt</strong> value. | 
 | [FatalFltrCorr&lt;TException&gt;(string, LoggerExt.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.fatalfltrcorr--1_system.string---0-system.string-system.boolean___15t2hh0) | public | Writes the diagnostic message at the `Fatal` level and returns <strong>catchIt</strong> value. | 
 | [FatalPassThrough(Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.fatalpassthrough_system.exception-system.string___10psm2o) | public | Writes the diagnostic message at the `Fatal` level and returns given <strong>exception</strong> &gt; | 
 | [Info(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.info_system.collections.generic.dictionary_system.string-system.object_-system.string___1qxds6b) | public | Writes the diagnostic message at the `Info` level. | 
 | [InfoCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.infocorr_system.string-system.string___3vobha) | public | Writes the diagnostic message at the `Info` level with correlation ID. | 
 | [LogIt(LogLevel, Dictionary&lt;string,object&gt;, string, Exception)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.logit_nlog.loglevel-system.collections.generic.dictionary_system.string-system.object_-system.string-system.exception___5yngu4) | private | Writes the item (message with optional event properties and exception)  into the log | 
 | [LogIt(LogLevel, string, Exception)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.logit_nlog.loglevel-system.string-system.exception___hxtfrf) | private | Writes the item (message with optional exception)  into the log | 
 | [LogIt(LogLevel, string, string, Exception)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.logit_nlog.loglevel-system.string-system.string-system.exception___1l4ejwt) | private | Writes the item (message with optional exception) with correlation Id into the log | 
 | [Trace(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.trace_system.collections.generic.dictionary_system.string-system.object_-system.string___1k5wn70) | public | Writes the diagnostic message at the `Trace` level. | 
 | [TraceCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.tracecorr_system.string-system.string___1e218kz) | public | Writes the diagnostic message at the `Trace` level with correlation ID | 
 | [Warn(Dictionary&lt;string,object&gt;, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.warn_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___8kyvvj) | public | Writes the diagnostic message at the `Warn` level. | 
 | [Warn(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.warn_system.collections.generic.dictionary_system.string-system.object_-system.string___wuc2dz) | public | Writes the diagnostic message at the `Warn` level. | 
 | [WarnCorr(string, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.warncorr_system.string-system.exception-system.string___sfdb1u) | public | Writes the diagnostic message at the `Warn` level with correlation ID. | 
 | [WarnCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.warncorr_system.string-system.string___cfr64e) | public | Writes the diagnostic message at the `Warn` level with correlation ID. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.createexception--1_system.string-system.exception___1wtd924" />  LoggerExt.CreateException&lt;TException&gt;(string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type



```csharp
private static LoggerExt.TException CreateException<TException>(string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.LoggerExt.TException</dt><dd>Created exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.debug_system.collections.generic.dictionary_system.string-system.object_-system.string___by66ma" />  LoggerExt.Debug(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Debug` level.



```csharp
public void Debug(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Debug(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.debug_system.collections.generic.dictionary_system.string-system.object_-system.string___jxdraq)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.debugcorr_system.string-system.string___i119af" />  LoggerExt.DebugCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Debug` level with correlation ID.



```csharp
public void DebugCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.DebugCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.debugcorr_system.string-system.string___aozvfj)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.error_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___7fy00h" />  LoggerExt.Error(Dictionary&lt;string,object&gt;, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level.



```csharp
public void Error(Dictionary<string,object> eventProperties, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Error(Dictionary&lt;string,object&gt;, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.error_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1watp5d)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.error_system.collections.generic.dictionary_system.string-system.object_-system.string___u5pc5h" />  LoggerExt.Error(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level.



```csharp
public void Error(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Error(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.error_system.collections.generic.dictionary_system.string-system.object_-system.string___kfa9gl)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.error--1_system.string-system.exception___1qowqgx" />  LoggerExt.Error&lt;TException&gt;(string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level. Creates and returns the exception of given type



```csharp
public LoggerExt.TException Error<TException>(string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.LoggerExt.TException</dt><dd>Created exception</dd></dl>Implements: [ILogger.Error&lt;TException&gt;(string, Exception)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.error--1_system.string-system.exception___pmrssh)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.errorcorr_system.string-system.exception-system.string___1tdd1hu" />  LoggerExt.ErrorCorr(string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level with correlation ID.



```csharp
public void ErrorCorr(string correlationId, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.ErrorCorr(string, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorcorr_system.string-system.exception-system.string___1qll13u)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.errorcorr_system.string-system.string___1vt0qk2" />  LoggerExt.ErrorCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level with correlation ID.



```csharp
public void ErrorCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.ErrorCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorcorr_system.string-system.string___coifvu)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.errorcorr--1_system.string---0-system.string___bk3vj3" />  LoggerExt.ErrorCorr&lt;TException&gt;(string, LoggerExt.TException, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level and returns the exception of given type



```csharp
public LoggerExt.TException ErrorCorr<TException>(string correlationId, LoggerExt.TException exception, string message = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt>net.adamec.lib.common.logging.LoggerExt.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.LoggerExt.TException</dt><dd>Pass-through exception</dd></dl>Implements: [ILogger.ErrorCorr&lt;TException&gt;(string, ILogger.TException, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorcorr--1_system.string---0-system.string___eypxkv)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.errorcorr--1_system.string-system.string-system.exception___4hcjn7" />  LoggerExt.ErrorCorr&lt;TException&gt;(string, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level with correlation ID. Creates and returns the exception of given type



```csharp
public LoggerExt.TException ErrorCorr<TException>(string correlationId, string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.LoggerExt.TException</dt><dd>Created exception</dd></dl>Implements: [ILogger.ErrorCorr&lt;TException&gt;(string, string, Exception)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorcorr--1_system.string-system.string-system.exception___91akh7)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.errorfltr--1_--0-system.string-system.boolean___ipfsfa" />  LoggerExt.ErrorFltr&lt;TException&gt;(LoggerExt.TException, string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level and returns the exception of given type



```csharp
public bool ErrorFltr<TException>(LoggerExt.TException exception, string message = null, bool catchIt = false) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt>net.adamec.lib.common.logging.LoggerExt.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>catchIt</strong></dt><dd>Flag whether the <strong>exception</strong> is to be catch by filter (default is false)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Flag whether the exception is to be catch by exception filter</dd></dl>Implements: [ILogger.ErrorFltr&lt;TException&gt;(ILogger.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorfltr--1_--0-system.string-system.boolean___135nosm)


###  Example ###
The following code logs any exception without catching it (function returns false by default) 
```csharp
    try
    {
      ...
    }
    catch (Exception e) when (Logger.FatalFltr(e)) {}
```
 The following code catch and log the ArgumentException and logs any other exception without catching it. 
```csharp
    try
    {
      ...
    }
    catch (ArgumentException e) when (Logger.ErrorFltr(e,catchIt:true)) {}
    catch (Exception e) when (Logger.FatalFltr(e)) {}
```



###  Remarks ###
This function is intended for catch exception filters. The parameter <strong>catchIt</strong> defines whether the exception filter will be applied after logging. The exception will be catch when <strong>catchIt</strong> is true, otherwise the filter is evaluated as false and it will continue with finding the catch clause (in both cases the log entry will be created)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.errorfltrcorr--1_system.string---0-system.string-system.boolean___84xqu8" />  LoggerExt.ErrorFltrCorr&lt;TException&gt;(string, LoggerExt.TException, string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level and returns the exception of given type



```csharp
public bool ErrorFltrCorr<TException>(string correlationId, LoggerExt.TException exception, string message = null, bool catchIt = false) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt>net.adamec.lib.common.logging.LoggerExt.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>catchIt</strong></dt><dd>Flag whether the <strong>exception</strong> is to be catch by filter (default is false)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Flag whether the exception is to be catch by exception filter</dd></dl>Implements: [ILogger.ErrorFltrCorr&lt;TException&gt;(string, ILogger.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorfltrcorr--1_system.string---0-system.string-system.boolean___1spds2w)


###  Remarks ###
This function is intended for catch exception filters. The parameter <strong>catchIt</strong> defines whether the exception filter will be applied after logging. The exception will be catch when <strong>catchIt</strong> is true, otherwise the filter is evaluated as false and it will continue with finding the catch clause (in both cases the log entry will be created)


###  See Also ###
[ErrorFltr&lt;TException&gt;(LoggerExt.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.errorfltr--1_--0-system.string-system.boolean___ipfsfa)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.errorpassthrough_system.exception-system.string___1ey2kd0" />  LoggerExt.ErrorPassThrough(Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level and returns given <strong>exception</strong>



```csharp
public Exception ErrorPassThrough(Exception exception, string message = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a></dt><dd>Pass-through exception</dd></dl>Implements: [ILogger.ErrorPassThrough(Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorpassthrough_system.exception-system.string___1vc33gk)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.fatal_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___pw9hcn" />  LoggerExt.Fatal(Dictionary&lt;string,object&gt;, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level.



```csharp
public void Fatal(Dictionary<string,object> eventProperties, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Fatal(Dictionary&lt;string,object&gt;, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatal_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___175gumn)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.fatal_system.collections.generic.dictionary_system.string-system.object_-system.string___1ff2uef" />  LoggerExt.Fatal(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level.



```csharp
public void Fatal(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Fatal(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatal_system.collections.generic.dictionary_system.string-system.object_-system.string___1yxmkzz)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.fatal--1_system.string-system.exception___1myw0tj" />  LoggerExt.Fatal&lt;TException&gt;(string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type



```csharp
public LoggerExt.TException Fatal<TException>(string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.LoggerExt.TException</dt><dd>Created exception</dd></dl>Implements: [ILogger.Fatal&lt;TException&gt;(string, Exception)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatal--1_system.string-system.exception___x5u73)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.fatalcorr_system.string-system.exception-system.string___1q1adwi" />  LoggerExt.FatalCorr(string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level with correlation ID.



```csharp
public void FatalCorr(string correlationId, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.FatalCorr(string, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatalcorr_system.string-system.exception-system.string___yt34nm)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.fatalcorr_system.string-system.string___c131ta" />  LoggerExt.FatalCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level with correlation ID.



```csharp
public void FatalCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.FatalCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatalcorr_system.string-system.string___ufcx32)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.fatalcorr--1_system.string---0-system.string___17i1735" />  LoggerExt.FatalCorr&lt;TException&gt;(string, LoggerExt.TException, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level and returns the exception of given type



```csharp
public LoggerExt.TException FatalCorr<TException>(string correlationId, LoggerExt.TException exception, string message = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt>net.adamec.lib.common.logging.LoggerExt.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.LoggerExt.TException</dt><dd>Pass-through exception</dd></dl>Implements: [ILogger.FatalCorr&lt;TException&gt;(string, ILogger.TException, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatalcorr--1_system.string---0-system.string___108vdu1)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.fatalcorr--1_system.string-system.string-system.exception___w1l5gt" />  LoggerExt.FatalCorr&lt;TException&gt;(string, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level with correlation ID. Creates and returns the exception of given type



```csharp
public LoggerExt.TException FatalCorr<TException>(string correlationId, string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.LoggerExt.TException</dt><dd>Created exception</dd></dl>Implements: [ILogger.FatalCorr&lt;TException&gt;(string, string, Exception)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatalcorr--1_system.string-system.string-system.exception___1hlu7x)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.fatalfltr--1_--0-system.string-system.boolean___5rdjqe" />  LoggerExt.FatalFltr&lt;TException&gt;(LoggerExt.TException, string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level and returns <strong>catchIt</strong> value.



```csharp
public bool FatalFltr<TException>(LoggerExt.TException exception, string message = null, bool catchIt = false) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt>net.adamec.lib.common.logging.LoggerExt.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>catchIt</strong></dt><dd>Flag whether the <strong>exception</strong> is to be catch by filter (default is false)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Flag whether the exception is to be catch by exception filter</dd></dl>Implements: [ILogger.FatalFltr&lt;TException&gt;(ILogger.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatalfltr--1_--0-system.string-system.boolean___1av7ixa)


###  Remarks ###
This function is intended for catch exception filters. The parameter <strong>catchIt</strong> defines whether the exception filter will be applied after logging. The exception will be catch when <strong>catchIt</strong> is true, otherwise the filter is evaluated as false and it will continue with finding the catch clause (in both cases the log entry will be created)


###  See Also ###
[ErrorFltr&lt;TException&gt;(LoggerExt.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.errorfltr--1_--0-system.string-system.boolean___ipfsfa)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.fatalfltrcorr--1_system.string---0-system.string-system.boolean___15t2hh0" />  LoggerExt.FatalFltrCorr&lt;TException&gt;(string, LoggerExt.TException, string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level and returns <strong>catchIt</strong> value.



```csharp
public bool FatalFltrCorr<TException>(string correlationId, LoggerExt.TException exception, string message = null, bool catchIt = false) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt>net.adamec.lib.common.logging.LoggerExt.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>catchIt</strong></dt><dd>Flag whether the <strong>exception</strong> is to be catch by filter (default is false)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Flag whether the exception is to be catch by exception filter</dd></dl>Implements: [ILogger.FatalFltrCorr&lt;TException&gt;(string, ILogger.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatalfltrcorr--1_system.string---0-system.string-system.boolean___a9m338)


###  Remarks ###
This function is intended for catch exception filters. The parameter <strong>catchIt</strong> defines whether the exception filter will be applied after logging. The exception will be catch when <strong>catchIt</strong> is true, otherwise the filter is evaluated as false and it will continue with finding the catch clause (in both cases the log entry will be created)


###  See Also ###
[ErrorFltr&lt;TException&gt;(LoggerExt.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.loggerext.errorfltr--1_--0-system.string-system.boolean___ipfsfa)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.fatalpassthrough_system.exception-system.string___10psm2o" />  LoggerExt.FatalPassThrough(Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level and returns given <strong>exception</strong> &gt;



```csharp
public Exception FatalPassThrough(Exception exception, string message = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a></dt><dd>Pass-through exception</dd></dl>Implements: [ILogger.FatalPassThrough(Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatalpassthrough_system.exception-system.string___1fx8xs8)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.info_system.collections.generic.dictionary_system.string-system.object_-system.string___1qxds6b" />  LoggerExt.Info(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Info` level.



```csharp
public void Info(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Info(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.info_system.collections.generic.dictionary_system.string-system.object_-system.string___1kbhewr)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.infocorr_system.string-system.string___3vobha" />  LoggerExt.InfoCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Info` level with correlation ID.



```csharp
public void InfoCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.InfoCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.infocorr_system.string-system.string___2iypny)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.logit_nlog.loglevel-system.collections.generic.dictionary_system.string-system.object_-system.string-system.exception___5yngu4" />  LoggerExt.LogIt(LogLevel, Dictionary&lt;string,object&gt;, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the item (message with optional event properties and exception)  into the log



```csharp
private void LogIt(LogLevel level, Dictionary<string,object> eventProperties, [Localizable(false)] string message, Exception exception = null)
```

<strong>Method parameters</strong><dl><dt>NLog.LogLevel <strong>level</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties (null when no properties are provided)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Optional exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.logit_nlog.loglevel-system.string-system.exception___hxtfrf" />  LoggerExt.LogIt(LogLevel, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the item (message with optional exception)  into the log



```csharp
private void LogIt(LogLevel level, [Localizable(false)] string message, Exception exception = null)
```

<strong>Method parameters</strong><dl><dt>NLog.LogLevel <strong>level</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Optional exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.logit_nlog.loglevel-system.string-system.string-system.exception___1l4ejwt" />  LoggerExt.LogIt(LogLevel, string, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the item (message with optional exception) with correlation Id into the log



```csharp
private void LogIt(LogLevel level, string correlationId, [Localizable(false)] string message, Exception exception = null)
```

<strong>Method parameters</strong><dl><dt>NLog.LogLevel <strong>level</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Optional exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.trace_system.collections.generic.dictionary_system.string-system.object_-system.string___1k5wn70" />  LoggerExt.Trace(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Trace` level.



```csharp
public void Trace(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Trace(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.trace_system.collections.generic.dictionary_system.string-system.object_-system.string___15kc02k)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.tracecorr_system.string-system.string___1e218kz" />  LoggerExt.TraceCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Trace` level with correlation ID



```csharp
public void TraceCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.TraceCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.tracecorr_system.string-system.string___1bdni2z)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.warn_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___8kyvvj" />  LoggerExt.Warn(Dictionary&lt;string,object&gt;, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Warn` level.



```csharp
public void Warn(Dictionary<string,object> eventProperties, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Warn(Dictionary&lt;string,object&gt;, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.warn_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___10z37vj)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.warn_system.collections.generic.dictionary_system.string-system.object_-system.string___wuc2dz" />  LoggerExt.Warn(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Warn` level.



```csharp
public void Warn(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.Warn(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.warn_system.collections.generic.dictionary_system.string-system.object_-system.string___1hy0rp3)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.warncorr_system.string-system.exception-system.string___sfdb1u" />  LoggerExt.WarnCorr(string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Warn` level with correlation ID.



```csharp
public void WarnCorr(string correlationId, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.WarnCorr(string, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.warncorr_system.string-system.exception-system.string___1kh0i9m)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerext.warncorr_system.string-system.string___cfr64e" />  LoggerExt.WarnCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\LoggerExt.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Warn` level with correlation ID.



```csharp
public void WarnCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [ILogger.WarnCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.warncorr_system.string-system.string___pr2tiu)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.logging.ilogger__y2ollm" />  ILogger Interface ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Logger interface - wrapper around the <em>NLog.ILogger</em> with some additional methods



```csharp
internal interface ILogger : ILogger
```

Implemented by: [net.adamec.lib.common.logging.LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2)           
Implements: NLog.ILogger, NLog.ILoggerBase, NLog.ISuppress


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Debug(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.debug_system.collections.generic.dictionary_system.string-system.object_-system.string___jxdraq) | public abstract | Writes the diagnostic message at the `Debug` level. | 
 | [DebugCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.debugcorr_system.string-system.string___aozvfj) | public abstract | Writes the diagnostic message at the `Debug` level with correlation ID. | 
 | [Error(Dictionary&lt;string,object&gt;, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.error_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1watp5d) | public abstract | Writes the diagnostic message at the `Error` level. | 
 | [Error(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.error_system.collections.generic.dictionary_system.string-system.object_-system.string___kfa9gl) | public abstract | Writes the diagnostic message at the `Error` level. | 
 | [Error&lt;TException&gt;(string, Exception)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.error--1_system.string-system.exception___pmrssh) | public abstract | Writes the diagnostic message at the `Error` level. Creates and returns the exception of given type | 
 | [ErrorCorr(string, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorcorr_system.string-system.exception-system.string___1qll13u) | public abstract | Writes the diagnostic message at the `Error` level with correlation ID. | 
 | [ErrorCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorcorr_system.string-system.string___coifvu) | public abstract | Writes the diagnostic message at the `Error` level with correlation ID. | 
 | [ErrorCorr&lt;TException&gt;(string, ILogger.TException, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorcorr--1_system.string---0-system.string___eypxkv) | public abstract | Writes the diagnostic message at the `Error` level and returns the exception of given type | 
 | [ErrorCorr&lt;TException&gt;(string, string, Exception)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorcorr--1_system.string-system.string-system.exception___91akh7) | public abstract | Writes the diagnostic message at the `Error` level with correlation ID. Creates and returns the exception of given type | 
 | [ErrorFltr&lt;TException&gt;(ILogger.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorfltr--1_--0-system.string-system.boolean___135nosm) | public abstract | Writes the diagnostic message at the `Error` level and returns the exception of given type | 
 | [ErrorFltrCorr&lt;TException&gt;(string, ILogger.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorfltrcorr--1_system.string---0-system.string-system.boolean___1spds2w) | public abstract | Writes the diagnostic message at the `Error` level and returns the exception of given type | 
 | [ErrorPassThrough(Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorpassthrough_system.exception-system.string___1vc33gk) | public abstract | Writes the diagnostic message at the `Error` level and returns given <strong>exception</strong> | 
 | [Fatal(Dictionary&lt;string,object&gt;, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatal_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___175gumn) | public abstract | Writes the diagnostic message at the `Fatal` level. | 
 | [Fatal(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatal_system.collections.generic.dictionary_system.string-system.object_-system.string___1yxmkzz) | public abstract | Writes the diagnostic message at the `Fatal` level. | 
 | [Fatal&lt;TException&gt;(string, Exception)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatal--1_system.string-system.exception___x5u73) | public abstract | Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type | 
 | [FatalCorr(string, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatalcorr_system.string-system.exception-system.string___yt34nm) | public abstract | Writes the diagnostic message at the `Fatal` level with correlation ID. | 
 | [FatalCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatalcorr_system.string-system.string___ufcx32) | public abstract | Writes the diagnostic message at the `Fatal` level with correlation ID. | 
 | [FatalCorr&lt;TException&gt;(string, ILogger.TException, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatalcorr--1_system.string---0-system.string___108vdu1) | public abstract | Writes the diagnostic message at the `Fatal` level and returns the exception of given type | 
 | [FatalCorr&lt;TException&gt;(string, string, Exception)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatalcorr--1_system.string-system.string-system.exception___1hlu7x) | public abstract | Writes the diagnostic message at the `Fatal` level with correlation ID. Creates and returns the exception of given type | 
 | [FatalFltr&lt;TException&gt;(ILogger.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatalfltr--1_--0-system.string-system.boolean___1av7ixa) | public abstract | Writes the diagnostic message at the `Fatal` level and returns <strong>catchIt</strong> value. | 
 | [FatalFltrCorr&lt;TException&gt;(string, ILogger.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatalfltrcorr--1_system.string---0-system.string-system.boolean___a9m338) | public abstract | Writes the diagnostic message at the `Fatal` level and returns <strong>catchIt</strong> value. | 
 | [FatalPassThrough(Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.fatalpassthrough_system.exception-system.string___1fx8xs8) | public abstract | Writes the diagnostic message at the `Fatal` level and returns given <strong>exception</strong> | 
 | [Info(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.info_system.collections.generic.dictionary_system.string-system.object_-system.string___1kbhewr) | public abstract | Writes the diagnostic message at the `Info` level. | 
 | [InfoCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.infocorr_system.string-system.string___2iypny) | public abstract | Writes the diagnostic message at the `Info` level with correlation ID. | 
 | [Trace(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.trace_system.collections.generic.dictionary_system.string-system.object_-system.string___15kc02k) | public abstract | Writes the diagnostic message at the `Trace` level. | 
 | [TraceCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.tracecorr_system.string-system.string___1bdni2z) | public abstract | Writes the diagnostic message at the `Trace` level with correlation ID. | 
 | [Warn(Dictionary&lt;string,object&gt;, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.warn_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___10z37vj) | public abstract | Writes the diagnostic message at the `Warn` level. | 
 | [Warn(Dictionary&lt;string,object&gt;, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.warn_system.collections.generic.dictionary_system.string-system.object_-system.string___1hy0rp3) | public abstract | Writes the diagnostic message at the `Warn` level. | 
 | [WarnCorr(string, Exception, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.warncorr_system.string-system.exception-system.string___1kh0i9m) | public abstract | Writes the diagnostic message at the `Warn` level with correlation ID. | 
 | [WarnCorr(string, string)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.warncorr_system.string-system.string___pr2tiu) | public abstract | Writes the diagnostic message at the `Warn` level with correlation ID. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.debug_system.collections.generic.dictionary_system.string-system.object_-system.string___jxdraq" />  ILogger.Debug(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Debug` level.



```csharp
public abstract void Debug(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.debugcorr_system.string-system.string___aozvfj" />  ILogger.DebugCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Debug` level with correlation ID.



```csharp
public abstract void DebugCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.error_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1watp5d" />  ILogger.Error(Dictionary&lt;string,object&gt;, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level.



```csharp
public abstract void Error(Dictionary<string,object> eventProperties, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.error_system.collections.generic.dictionary_system.string-system.object_-system.string___kfa9gl" />  ILogger.Error(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level.



```csharp
public abstract void Error(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.error--1_system.string-system.exception___pmrssh" />  ILogger.Error&lt;TException&gt;(string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level. Creates and returns the exception of given type



```csharp
public abstract ILogger.TException Error<TException>(string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.ILogger.TException</dt><dd>Created exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.errorcorr_system.string-system.exception-system.string___1qll13u" />  ILogger.ErrorCorr(string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level with correlation ID.



```csharp
public abstract void ErrorCorr(string correlationId, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.errorcorr_system.string-system.string___coifvu" />  ILogger.ErrorCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level with correlation ID.



```csharp
public abstract void ErrorCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.errorcorr--1_system.string---0-system.string___eypxkv" />  ILogger.ErrorCorr&lt;TException&gt;(string, ILogger.TException, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level and returns the exception of given type



```csharp
public abstract ILogger.TException ErrorCorr<TException>(string correlationId, ILogger.TException exception, string message = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt>net.adamec.lib.common.logging.ILogger.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.ILogger.TException</dt><dd>Pass-through exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.errorcorr--1_system.string-system.string-system.exception___91akh7" />  ILogger.ErrorCorr&lt;TException&gt;(string, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level with correlation ID. Creates and returns the exception of given type



```csharp
public abstract ILogger.TException ErrorCorr<TException>(string correlationId, string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.ILogger.TException</dt><dd>Created exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.errorfltr--1_--0-system.string-system.boolean___135nosm" />  ILogger.ErrorFltr&lt;TException&gt;(ILogger.TException, string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level and returns the exception of given type



```csharp
public abstract bool ErrorFltr<TException>(ILogger.TException exception, string message = null, bool catchIt = false) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt>net.adamec.lib.common.logging.ILogger.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>catchIt</strong></dt><dd>Flag whether the <strong>exception</strong> is to be catch by filter (default is false)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Flag whether the exception is to be catch by exception filter</dd></dl>


###  Example ###
The following code logs any exception without catching it (function returns false by default) 
```csharp
    try
    {
      ...
    }
    catch (Exception e) when (Logger.FatalFltr(e)) {}
```
 The following code catch and log the ArgumentException and logs any other exception without catching it. 
```csharp
    try
    {
      ...
    }
    catch (ArgumentException e) when (Logger.ErrorFltr(e,catchIt:true)) {}
    catch (Exception e) when (Logger.FatalFltr(e)) {}
```



###  Remarks ###
This function is intended for catch exception filters. The parameter <strong>catchIt</strong> defines whether the exception filter will be applied after logging. The exception will be catch when <strong>catchIt</strong> is true, otherwise the filter is evaluated as false and it will continue with finding the catch clause (in both cases the log entry will be created)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.errorfltrcorr--1_system.string---0-system.string-system.boolean___1spds2w" />  ILogger.ErrorFltrCorr&lt;TException&gt;(string, ILogger.TException, string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level and returns the exception of given type



```csharp
public abstract bool ErrorFltrCorr<TException>(string correlationId, ILogger.TException exception, string message = null, bool catchIt = false) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt>net.adamec.lib.common.logging.ILogger.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>catchIt</strong></dt><dd>Flag whether the <strong>exception</strong> is to be catch by filter (default is false)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Flag whether the exception is to be catch by exception filter</dd></dl>


###  Remarks ###
This function is intended for catch exception filters. The parameter <strong>catchIt</strong> defines whether the exception filter will be applied after logging. The exception will be catch when <strong>catchIt</strong> is true, otherwise the filter is evaluated as false and it will continue with finding the catch clause (in both cases the log entry will be created)


###  See Also ###
[ErrorFltr&lt;TException&gt;(ILogger.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorfltr--1_--0-system.string-system.boolean___135nosm)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.errorpassthrough_system.exception-system.string___1vc33gk" />  ILogger.ErrorPassThrough(Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level and returns given <strong>exception</strong>



```csharp
public abstract Exception ErrorPassThrough(Exception exception, string message = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a></dt><dd>Pass-through exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.fatal_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___175gumn" />  ILogger.Fatal(Dictionary&lt;string,object&gt;, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level.



```csharp
public abstract void Fatal(Dictionary<string,object> eventProperties, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.fatal_system.collections.generic.dictionary_system.string-system.object_-system.string___1yxmkzz" />  ILogger.Fatal(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level.



```csharp
public abstract void Fatal(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.fatal--1_system.string-system.exception___x5u73" />  ILogger.Fatal&lt;TException&gt;(string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type



```csharp
public abstract ILogger.TException Fatal<TException>(string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.ILogger.TException</dt><dd>Created exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.fatalcorr_system.string-system.exception-system.string___yt34nm" />  ILogger.FatalCorr(string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level with correlation ID.



```csharp
public abstract void FatalCorr(string correlationId, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.fatalcorr_system.string-system.string___ufcx32" />  ILogger.FatalCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level with correlation ID.



```csharp
public abstract void FatalCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.fatalcorr--1_system.string---0-system.string___108vdu1" />  ILogger.FatalCorr&lt;TException&gt;(string, ILogger.TException, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level and returns the exception of given type



```csharp
public abstract ILogger.TException FatalCorr<TException>(string correlationId, ILogger.TException exception, string message = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt>net.adamec.lib.common.logging.ILogger.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.ILogger.TException</dt><dd>Pass-through exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.fatalcorr--1_system.string-system.string-system.exception___1hlu7x" />  ILogger.FatalCorr&lt;TException&gt;(string, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level with correlation ID. Creates and returns the exception of given type



```csharp
public abstract ILogger.TException FatalCorr<TException>(string correlationId, string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.ILogger.TException</dt><dd>Created exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.fatalfltr--1_--0-system.string-system.boolean___1av7ixa" />  ILogger.FatalFltr&lt;TException&gt;(ILogger.TException, string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level and returns <strong>catchIt</strong> value.



```csharp
public abstract bool FatalFltr<TException>(ILogger.TException exception, string message = null, bool catchIt = false) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt>net.adamec.lib.common.logging.ILogger.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>catchIt</strong></dt><dd>Flag whether the <strong>exception</strong> is to be catch by filter (default is false)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Flag whether the exception is to be catch by exception filter</dd></dl>


###  Remarks ###
This function is intended for catch exception filters. The parameter <strong>catchIt</strong> defines whether the exception filter will be applied after logging. The exception will be catch when <strong>catchIt</strong> is true, otherwise the filter is evaluated as false and it will continue with finding the catch clause (in both cases the log entry will be created)


###  See Also ###
[ErrorFltr&lt;TException&gt;(ILogger.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorfltr--1_--0-system.string-system.boolean___135nosm)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.fatalfltrcorr--1_system.string---0-system.string-system.boolean___a9m338" />  ILogger.FatalFltrCorr&lt;TException&gt;(string, ILogger.TException, string, bool) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level and returns <strong>catchIt</strong> value.



```csharp
public abstract bool FatalFltrCorr<TException>(string correlationId, ILogger.TException exception, string message = null, bool catchIt = false) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt>net.adamec.lib.common.logging.ILogger.TException <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>catchIt</strong></dt><dd>Flag whether the <strong>exception</strong> is to be catch by filter (default is false)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Flag whether the exception is to be catch by exception filter</dd></dl>


###  Remarks ###
This function is intended for catch exception filters. The parameter <strong>catchIt</strong> defines whether the exception filter will be applied after logging. The exception will be catch when <strong>catchIt</strong> is true, otherwise the filter is evaluated as false and it will continue with finding the catch clause (in both cases the log entry will be created)


###  See Also ###
[ErrorFltr&lt;TException&gt;(ILogger.TException, string, bool)](net.adamec.lib.common.logging__1g9pm29.md#m-net.adamec.lib.common.logging.ilogger.errorfltr--1_--0-system.string-system.boolean___135nosm)


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.fatalpassthrough_system.exception-system.string___1fx8xs8" />  ILogger.FatalPassThrough(Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level and returns given <strong>exception</strong>



```csharp
public abstract Exception FatalPassThrough(Exception exception, string message = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a></dt><dd>Pass-through exception</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.info_system.collections.generic.dictionary_system.string-system.object_-system.string___1kbhewr" />  ILogger.Info(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Info` level.



```csharp
public abstract void Info(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.infocorr_system.string-system.string___2iypny" />  ILogger.InfoCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Info` level with correlation ID.



```csharp
public abstract void InfoCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.trace_system.collections.generic.dictionary_system.string-system.object_-system.string___15kc02k" />  ILogger.Trace(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Trace` level.



```csharp
public abstract void Trace(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.tracecorr_system.string-system.string___1bdni2z" />  ILogger.TraceCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Trace` level with correlation ID.



```csharp
public abstract void TraceCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.warn_system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___10z37vj" />  ILogger.Warn(Dictionary&lt;string,object&gt;, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Warn` level.



```csharp
public abstract void Warn(Dictionary<string,object> eventProperties, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.warn_system.collections.generic.dictionary_system.string-system.object_-system.string___1hy0rp3" />  ILogger.Warn(Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Warn` level.



```csharp
public abstract void Warn(Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.warncorr_system.string-system.exception-system.string___1kh0i9m" />  ILogger.WarnCorr(string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Warn` level with correlation ID.



```csharp
public abstract void WarnCorr(string correlationId, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.ilogger.warncorr_system.string-system.string___pr2tiu" />  ILogger.WarnCorr(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)           
Sources: cs\any\App_Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](src-only-packages--.html#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Warn` level with correlation ID.



```csharp
public abstract void WarnCorr(string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 




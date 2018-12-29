#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.parser__src1fa" />  net.adamec.lib.common.dmn.engine.parser Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga) | public | DMN Model XML parser | 
 | [DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7) | public | Exception thrown while parsing the DMN Model | 
 | [SfeelParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.sfeelparser__1rin914) | public | S-FEEL simple parser | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga" />  DmnParser Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\DmnParser.cs</small>


DMN Model XML parser



```csharp
public class DmnParser
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDefinitionsSerializer](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmndefinitionsserializer__1rtavq1) | protected static | DMN Model XML serializer | 
 | [Logger](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.logger__1w7m682) | internal static |  | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Parse(string)](net.adamec.lib.common.dmn.engine.parser__src1fa.md#m-net.adamec.lib.common.dmn.engine.parser.dmnparser.parse_system.string___14hqoi9) | public static | Parse the file with DMN Model XML definition | 
 | [ParseString(string)](net.adamec.lib.common.dmn.engine.parser__src1fa.md#m-net.adamec.lib.common.dmn.engine.parser.dmnparser.parsestring_system.string___1flgut8) | public static | Parse the string with DMN Model XML definition | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmndefinitionsserializer__1rtavq1" />  DmnParser.DmnDefinitionsSerializer Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga)           
Sources: parser\DmnParser.cs</small>


DMN Model XML serializer



```csharp
protected static XmlSerializer DmnDefinitionsSerializer
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer" target="_blank" >System.Xml.Serialization.XmlSerializer</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dmnparser.logger__1w7m682" />  DmnParser.Logger Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga)           
Sources: parser\DmnParser.cs</small>



```csharp
internal static ILogger Logger
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dmnparser.parse_system.string___14hqoi9" />  DmnParser.Parse(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga)           
Sources: parser\DmnParser.cs</small>


Parse the file with DMN Model XML definition



```csharp
public static DmnModel Parse(string filePath)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>filePath</strong></dt><dd>Path to the file to be parsed</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9)</dt><dd>Parsed DMN Model</dd></dl>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing file path ( <strong>filePath</strong> is null or empty)</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>File doesn&#39;t exist</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Can&#39;t parse file</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dmnparser.parsestring_system.string___1flgut8" />  DmnParser.ParseString(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga)           
Sources: parser\DmnParser.cs</small>


Parse the string with DMN Model XML definition



```csharp
public static DmnModel ParseString(string dmnDefinition)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>dmnDefinition</strong></dt><dd>DMN Model XML definition</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9)</dt><dd>Parsed DMN Model</dd></dl>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing DMN Model definition ( <strong>dmnDefinition</strong> is null or empty)</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Can&#39;t parse DMN definition</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7" />  DmnParserException Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\DmnParserException.cs</small>


Exception thrown while parsing the DMN Model



```csharp
public class DmnParserException : Exception
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable" target="_blank" >System.Runtime.Serialization.ISerializable</a>


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnParserException(string, Exception)](net.adamec.lib.common.dmn.engine.parser__src1fa.md#m-net.adamec.lib.common.dmn.engine.parser.dmnparserexception.-ctor_system.string-system.exception___1mxhbyy) | public | Creates [DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7) with given <strong>message</strong> and optional <strong>innerException</strong> | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dmnparserexception.-ctor_system.string-system.exception___1mxhbyy" />  DmnParserException.DmnParserException(string, Exception) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)           
Sources: parser\DmnParserException.cs</small>


Creates [DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7) with given <strong>message</strong> and optional <strong>innerException</strong>



```csharp
public DmnParserException(string message, Exception innerException = null)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Error message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Optional inner exception</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.sfeelparser__1rin914" />  SfeelParser Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\SfeelParser.cs</small>


S-FEEL simple parser



```csharp
public class SfeelParser
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Logger](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.sfeelparser.logger__1txjqko) | internal static |  | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CustomFunctions](net.adamec.lib.common.dmn.engine.parser__src1fa.md#p-net.adamec.lib.common.dmn.engine.parser.sfeelparser.customfunctions__zgl9qa) | public static | Custom functions to be  used in DynamoExpression for S-FEEL functions | 
 | [CustomFunctionTranslations](net.adamec.lib.common.dmn.engine.parser__src1fa.md#p-net.adamec.lib.common.dmn.engine.parser.sfeelparser.customfunctiontranslations__wlq0ll) | private static | Translations of custom functions from  S-FEEL to [CustomFunctions](net.adamec.lib.common.dmn.engine.parser__src1fa.md#p-net.adamec.lib.common.dmn.engine.parser.sfeelparser.customfunctions__zgl9qa) For example &quot;date and time&quot; will be &quot;date_and_time&quot; | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SfeelParser()](net.adamec.lib.common.dmn.engine.parser__src1fa.md#m-net.adamec.lib.common.dmn.engine.parser.sfeelparser.-cctor__l74yw7) | private static | Initialize [SfeelParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.sfeelparser__1rin914) . Defines the [CustomFunctions](net.adamec.lib.common.dmn.engine.parser__src1fa.md#p-net.adamec.lib.common.dmn.engine.parser.sfeelparser.customfunctions__zgl9qa) for the DynamoExpression interpreter | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ParseInput(string, string)](net.adamec.lib.common.dmn.engine.parser__src1fa.md#m-net.adamec.lib.common.dmn.engine.parser.sfeelparser.parseinput_system.string-system.string___1yu774r) | public static | Parses the S-FEEL expression and creates the comparison that will be used in rule evaluation The parser recognize the basic types of S-FEEL expressions: not(expr), simple comparators, multiple values and range | 
 | [PrepareCustomFunctions()](net.adamec.lib.common.dmn.engine.parser__src1fa.md#m-net.adamec.lib.common.dmn.engine.parser.sfeelparser.preparecustomfunctions__axhm1y) | public static | Defines the [CustomFunctions](net.adamec.lib.common.dmn.engine.parser__src1fa.md#p-net.adamec.lib.common.dmn.engine.parser.sfeelparser.customfunctions__zgl9qa) for the DynamoExpression interpreter. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.sfeelparser.logger__1txjqko" />  SfeelParser.Logger Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SfeelParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.sfeelparser__1rin914)           
Sources: parser\SfeelParser.cs</small>



```csharp
internal static ILogger Logger
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.sfeelparser.customfunctions__zgl9qa" />  SfeelParser.CustomFunctions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SfeelParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.sfeelparser__1rin914)           
Sources: parser\SfeelParser.cs</small>


Custom functions to be  used in DynamoExpression for S-FEEL functions



```csharp
public static Dictionary<string,Delegate> CustomFunctions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,Delegate&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.sfeelparser.customfunctiontranslations__wlq0ll" />  SfeelParser.CustomFunctionTranslations Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SfeelParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.sfeelparser__1rin914)           
Sources: parser\SfeelParser.cs</small>


Translations of custom functions from  S-FEEL to [CustomFunctions](net.adamec.lib.common.dmn.engine.parser__src1fa.md#p-net.adamec.lib.common.dmn.engine.parser.sfeelparser.customfunctions__zgl9qa) For example &quot;date and time&quot; will be &quot;date_and_time&quot;



```csharp
private static Dictionary<string,string> CustomFunctionTranslations { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.sfeelparser.-cctor__l74yw7" />  SfeelParser.SfeelParser() Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SfeelParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.sfeelparser__1rin914)           
Sources: parser\SfeelParser.cs</small>


Initialize [SfeelParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.sfeelparser__1rin914) . Defines the [CustomFunctions](net.adamec.lib.common.dmn.engine.parser__src1fa.md#p-net.adamec.lib.common.dmn.engine.parser.sfeelparser.customfunctions__zgl9qa) for the DynamoExpression interpreter



```csharp
private static SfeelParser()
```

Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.sfeelparser.parseinput_system.string-system.string___1yu774r" />  SfeelParser.ParseInput(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SfeelParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.sfeelparser__1rin914)           
Sources: parser\SfeelParser.cs</small>


Parses the S-FEEL expression and creates the comparison that will be used in rule evaluation The parser recognize the basic types of S-FEEL expressions: not(expr), simple comparators, multiple values and range



```csharp
public static string ParseInput(string expr, string leftSide)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>expr</strong></dt><dd>Source expression</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>leftSide</strong></dt><dd>Left side of comparison expression - to what to compare to</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Expression to be used in rule evaluation</dd></dl>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing expression ( <strong>expr</strong> is null or empty)</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing left side of expression ( <strong>leftSide</strong> is null or empty)</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Wrong S-FEEL range</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.sfeelparser.preparecustomfunctions__axhm1y" />  SfeelParser.PrepareCustomFunctions() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SfeelParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.sfeelparser__1rin914)           
Sources: parser\SfeelParser.cs</small>


Defines the [CustomFunctions](net.adamec.lib.common.dmn.engine.parser__src1fa.md#p-net.adamec.lib.common.dmn.engine.parser.sfeelparser.customfunctions__zgl9qa) for the DynamoExpression interpreter.



```csharp
public static void PrepareCustomFunctions()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 




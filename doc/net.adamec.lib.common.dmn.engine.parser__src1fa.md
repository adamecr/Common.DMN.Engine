#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.parser__src1fa" />  net.adamec.lib.common.dmn.engine.parser Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga) | public | DMN Model XML parser | 
 | [DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7) | public | Exception thrown while parsing the DMN Model | 
 | [SfeelParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.sfeelparser__1rin914) | public | S-FEEL simple parser | 

 


###  Enums ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnParser.DmnVersionEnum](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum__1a1w78g) | public | DMN standard version to be used by [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga) | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga" />  DmnParser Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\DmnParser.cs</small>


DMN Model XML parser



```csharp
public class DmnParser
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [XmlNamespaceDmn11](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.xmlnamespacedmn11__152tpht) | http://www.omg.org/spec/DMN/20151101/dmn.xsd | XML namespace for DMN 1.1 documents | 
 | [XmlNamespaceDmn13](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.xmlnamespacedmn13__152tphr) | https://www.omg.org/spec/DMN/20191111/MODEL/ | XML namespace for DMN 1.3 documents | 

 


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnDefinitionsSerializer](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmndefinitionsserializer__1rtavq1) | protected static | DMN Model XML serializer for DMN v1.1 | 
 | [DmnDefinitionsSerializer13](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmndefinitionsserializer13__1jeue2b) | protected static | DMN Model XML serializer for DMN v1.3 | 
 | [Logger](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.logger__1w7m682) | internal static |  | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Parse(string, DmnParser.DmnVersionEnum)](net.adamec.lib.common.dmn.engine.parser__src1fa.md#m-net.adamec.lib.common.dmn.engine.parser.dmnparser.parse_system.string-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum___1tvf0mj) | public static | Parse the file with DMN Model XML definition based on DMN standard version . | 
 | [Parse13(string)](net.adamec.lib.common.dmn.engine.parser__src1fa.md#m-net.adamec.lib.common.dmn.engine.parser.dmnparser.parse13_system.string___3jyezv) | public static | Parse the file with DMN Model XML definition based on [DMN standard version 1.3](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum.v1_3__14p7r3b) . | 
 | [Parse13ext(string)](net.adamec.lib.common.dmn.engine.parser__src1fa.md#m-net.adamec.lib.common.dmn.engine.parser.dmnparser.parse13ext_system.string___f2z1fm) | public static | Parse the file with DMN Model XML definition based on [DMN standard version 1.3 with extensions](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum.v1_3__14p7r3b) . | 
 | [ParseString(string, DmnParser.DmnVersionEnum)](net.adamec.lib.common.dmn.engine.parser__src1fa.md#m-net.adamec.lib.common.dmn.engine.parser.dmnparser.parsestring_system.string-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum___1ldin6) | public static | Parse the string with DMN Model XML definition based on DMN standard version . | 
 | [ParseString13(string)](net.adamec.lib.common.dmn.engine.parser__src1fa.md#m-net.adamec.lib.common.dmn.engine.parser.dmnparser.parsestring13_system.string___1cswehw) | public static | Parse the string with DMN Model XML definition based on [DMN standard version 1.3](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum.v1_3__14p7r3b) . | 
 | [ParseString13ext(string)](net.adamec.lib.common.dmn.engine.parser__src1fa.md#m-net.adamec.lib.common.dmn.engine.parser.dmnparser.parsestring13ext_system.string___1quh80z) | public static | Parse the string with DMN Model XML definition based on [DMN standard version 1.3 with extensions](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum.v1_3__14p7r3b) . | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmndefinitionsserializer__1rtavq1" />  DmnParser.DmnDefinitionsSerializer Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga)           
Sources: parser\DmnParser.cs</small>


DMN Model XML serializer for DMN v1.1



```csharp
protected static XmlSerializer DmnDefinitionsSerializer
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer" target="_blank" >System.Xml.Serialization.XmlSerializer</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmndefinitionsserializer13__1jeue2b" />  DmnParser.DmnDefinitionsSerializer13 Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga)           
Sources: parser\DmnParser.cs</small>


DMN Model XML serializer for DMN v1.3



```csharp
protected static XmlSerializer DmnDefinitionsSerializer13
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer" target="_blank" >System.Xml.Serialization.XmlSerializer</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dmnparser.logger__1w7m682" />  DmnParser.Logger Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga)           
Sources: parser\DmnParser.cs</small>



```csharp
internal static ILogger Logger
```

<strong>Field value</strong><dl><dt>net.adamec.lib.common.core.logging.ILogger</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dmnparser.xmlnamespacedmn11__152tpht" />  DmnParser.XmlNamespaceDmn11 Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga)           
Sources: parser\DmnParser.cs</small>


XML namespace for DMN 1.1 documents



```csharp
public const string XmlNamespaceDmn11 = "http://www.omg.org/spec/DMN/20151101/dmn.xsd"
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dmnparser.xmlnamespacedmn13__152tphr" />  DmnParser.XmlNamespaceDmn13 Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga)           
Sources: parser\DmnParser.cs</small>


XML namespace for DMN 1.3 documents



```csharp
public const string XmlNamespaceDmn13 = "https://www.omg.org/spec/DMN/20191111/MODEL/"
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dmnparser.parse_system.string-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum___1tvf0mj" />  DmnParser.Parse(string, DmnParser.DmnVersionEnum) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga)           
Sources: parser\DmnParser.cs</small>


Parse the file with DMN Model XML definition based on DMN standard version .



```csharp
public static DmnModel Parse(string filePath, DmnParser.DmnVersionEnum dmnVersion = 0)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>filePath</strong></dt><dd>Path to the file to be parsed</dd><dt>[net.adamec.lib.common.dmn.engine.parser.DmnParser.DmnVersionEnum](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum__1a1w78g) <strong>dmnVersion</strong></dt><dd>DMN standard version to be used for parsing. Version 1.1 ( [V1_1](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum.v1_1__14p7r3d) is used as default if the version is not provided.</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9)</dt><dd>Parsed DMN Model</dd></dl>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing file path ( <strong>filePath</strong> is null or empty)</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>File doesn&#39;t exist</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Can&#39;t parse file</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dmnparser.parse13_system.string___3jyezv" />  DmnParser.Parse13(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga)           
Sources: parser\DmnParser.cs</small>


Parse the file with DMN Model XML definition based on [DMN standard version 1.3](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum.v1_3__14p7r3b) .



```csharp
public static DmnModel Parse13(string filePath)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>filePath</strong></dt><dd>Path to the file to be parsed</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9)</dt><dd>Parsed DMN Model</dd></dl>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing file path ( <strong>filePath</strong> is null or empty)</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>File doesn&#39;t exist</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Can&#39;t parse file</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dmnparser.parse13ext_system.string___f2z1fm" />  DmnParser.Parse13ext(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga)           
Sources: parser\DmnParser.cs</small>


Parse the file with DMN Model XML definition based on [DMN standard version 1.3 with extensions](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum.v1_3__14p7r3b) .



```csharp
public static DmnModel Parse13ext(string filePath)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>filePath</strong></dt><dd>Path to the file to be parsed</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9)</dt><dd>Parsed DMN Model</dd></dl>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing file path ( <strong>filePath</strong> is null or empty)</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>File doesn&#39;t exist</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Can&#39;t parse file</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dmnparser.parsestring_system.string-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum___1ldin6" />  DmnParser.ParseString(string, DmnParser.DmnVersionEnum) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga)           
Sources: parser\DmnParser.cs</small>


Parse the string with DMN Model XML definition based on DMN standard version .



```csharp
public static DmnModel ParseString(string dmnDefinition, DmnParser.DmnVersionEnum dmnVersion = 0)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>dmnDefinition</strong></dt><dd>DMN Model XML definition</dd><dt>[net.adamec.lib.common.dmn.engine.parser.DmnParser.DmnVersionEnum](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum__1a1w78g) <strong>dmnVersion</strong></dt><dd>DMN standard version to be used for parsing. Version 1.1 ( [V1_1](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum.v1_1__14p7r3d) is used as default if the version is not provided.</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9)</dt><dd>Parsed DMN Model</dd></dl>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing DMN Model definition ( <strong>dmnDefinition</strong> is null or empty)</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Can&#39;t parse DMN definition</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dmnparser.parsestring13_system.string___1cswehw" />  DmnParser.ParseString13(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga)           
Sources: parser\DmnParser.cs</small>


Parse the string with DMN Model XML definition based on [DMN standard version 1.3](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum.v1_3__14p7r3b) .



```csharp
public static DmnModel ParseString13(string dmnDefinition)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>dmnDefinition</strong></dt><dd>DMN Model XML definition</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9)</dt><dd>Parsed DMN Model</dd></dl>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing DMN Model definition ( <strong>dmnDefinition</strong> is null or empty)</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Can&#39;t parse DMN definition</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dmnparser.parsestring13ext_system.string___1quh80z" />  DmnParser.ParseString13ext(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga)           
Sources: parser\DmnParser.cs</small>


Parse the string with DMN Model XML definition based on [DMN standard version 1.3 with extensions](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum.v1_3__14p7r3b) .



```csharp
public static DmnModel ParseString13ext(string dmnDefinition)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>dmnDefinition</strong></dt><dd>DMN Model XML definition</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9)</dt><dd>Parsed DMN Model</dd></dl>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Missing DMN Model definition ( <strong>dmnDefinition</strong> is null or empty)</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Can&#39;t parse DMN definition</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


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

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


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
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


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
 | [Logger](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.sfeelparser.logger__1txjqko) | protected static |  | 

 


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

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.sfeelparser.logger__1txjqko" />  SfeelParser.Logger Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SfeelParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.sfeelparser__1rin914)           
Sources: parser\SfeelParser.cs</small>



```csharp
protected static ILogger Logger
```

<strong>Field value</strong><dl><dt>net.adamec.lib.common.core.logging.ILogger</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


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


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


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


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.sfeelparser.-cctor__l74yw7" />  SfeelParser.SfeelParser() Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [SfeelParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.sfeelparser__1rin914)           
Sources: parser\SfeelParser.cs</small>


Initialize [SfeelParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.sfeelparser__1rin914) . Defines the [CustomFunctions](net.adamec.lib.common.dmn.engine.parser__src1fa.md#p-net.adamec.lib.common.dmn.engine.parser.sfeelparser.customfunctions__zgl9qa) for the DynamoExpression interpreter



```csharp
private static SfeelParser()
```

Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


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


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


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


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum__1a1w78g" />  DmnParser.DmnVersionEnum Enum ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\DmnParser.cs</small>


DMN standard version to be used by [DmnParser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser__ckbnga)



```csharp
[SuppressMessage("ReSharper", "InconsistentNaming")]
public enum DmnParser.DmnVersionEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.suppressmessageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.SuppressMessageAttribute</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [V1_1](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum.v1_1__14p7r3d) | 0 | DMN version 1.1 | 
 | [V1_3](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum.v1_3__14p7r3b) | 1 | DMN version 1.3 | 
 | [V1_3ext](net.adamec.lib.common.dmn.engine.parser__src1fa.md#f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum.v1_3ext__is8jxm) | 2 | DMN version 1.3 with extensions | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum.v1_1__14p7r3d" />  DmnParser.DmnVersionEnum.V1_1 Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser.DmnVersionEnum](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum__1a1w78g)           
Sources: parser\DmnParser.cs</small>


DMN version 1.1



```csharp
 V1_1 = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.DmnParser.DmnVersionEnum](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum__1a1w78g)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum.v1_3__14p7r3b" />  DmnParser.DmnVersionEnum.V1_3 Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser.DmnVersionEnum](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum__1a1w78g)           
Sources: parser\DmnParser.cs</small>


DMN version 1.3



```csharp
 V1_3 = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.DmnParser.DmnVersionEnum](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum__1a1w78g)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum.v1_3ext__is8jxm" />  DmnParser.DmnVersionEnum.V1_3ext Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser](net.adamec.lib.common.dmn.engine.parser__src1fa.md#n-net.adamec.lib.common.dmn.engine.parser__src1fa)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnParser.DmnVersionEnum](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum__1a1w78g)           
Sources: parser\DmnParser.cs</small>


DMN version 1.3 with extensions



```csharp
 V1_3ext = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.DmnParser.DmnVersionEnum](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum__1a1w78g)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 




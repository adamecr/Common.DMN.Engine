#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp" />  net.adamec.lib.common.dmn.engine.parser.dto Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllowedValues](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues__1bbwvx1) | public | Defines the list of allowed values for decision table inputs and outputs | 
 | [Decision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9) | public | Single decision within the DMN file It can be expression decision of decision table. Decision table is recognized by having the [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decision.decisiontable__192844l) element, otherwise, the expression decision is expected with elements [Expression](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decision.expression__1qkgb95) and [OutputVariable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decision.outputvariable__1gr23po) | 
 | [DecisionRule](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule__ug9ttn) | public | Decision table rule | 
 | [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr) | public | Decision table definition | 
 | [DecisionTableInput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput__csk49) | public | Decision table input definition | 
 | [DecisionTableOutput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput__63fwne) | public | Decision table output definition | 
 | [DecisionTableSerializable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable__a9v25k) | public | Decision table (de)serialization proxy implemented to support the private getters in [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr) | 
 | [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9) | public | Root of DMN definition XML - DMN Model | 
 | [Expression](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.expression__tql32b) | public | Expression within the DMN definition file | 
 | [IdedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v) | public abstract | Element with id attribute | 
 | [InformationRequirement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement__1lwftc6) | public | Defines the input or decision needed for the decision to be evaluated. The inputs are referenced by [RequiredInput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.requiredinput__jq7sir) sub-element and decisions by [RequiredDecision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.requireddecision__12tqhtx) one. Exactly one of the sub element must be present | 
 | [InformationRequirement.InformationRequirementItem](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.informationrequirementitem__1gbx84m) | public | Required input or decision reference | 
 | [InformationRequirementSerializable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementserializable__isg04z) | public | Information Requirement (de)serialization proxy implemented to support the private getters in [InformationRequirement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement__1lwftc6) | 
 | [InputData](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.inputdata__jk22hv) | public | Input Data element Defines the input data item provided to the DMN model. The input parameter and related variable are defined by [Name](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.namedelement.name__3ml05) | 
 | [NamedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.namedelement__11eai0o) | public abstract | Element with id and name attributes | 
 | [Variable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.variable__1klt78r) | public | Variable definition Used in [expression decision definition](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9) to define the output variable | 

 


###  Enums ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9) | public | Collect hit policy aggregation type | 
 | [HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz) | public | Decision Table hit policy - the hit policy specifies what the result of the decision table is in cases of overlapping rules, i.e. when more than one rule matches the input data. | 
 | [InformationRequirementType](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementtype__f6e7u6) | public | Type of the dependency | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues__1bbwvx1" />  AllowedValues Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\AllowedValues.cs</small>


Defines the list of allowed values for decision table inputs and outputs



```csharp
public class AllowedValues : IXmlSerializable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable" target="_blank" >System.Xml.Serialization.IXmlSerializable</a>


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Text](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues.text__v1ms34) | private | The source list of allowed values in form &quot;value 1&quot;, &quot;value 2&quot;, &quot;value 3&quot;, &quot;value n&quot; | 
 | [Values](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues.values__1jdoyaj) | public | List of allowed values | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetSchema()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues.getschema__6pb4rt) | public | This method is reserved and should not be used. When implementing the IXmlSerializable interface, you should return null (Nothing in Visual Basic) from this method, and instead, if specifying a custom schema is required, apply the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlschemaproviderattribute" target="_blank" >System.Xml.Serialization.XmlSchemaProviderAttribute</a> to the class. | 
 | [ReadXml(XmlReader)](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues.readxml_system.xml.xmlreader___ezr1qu) | public | Generates an object from its XML representation. | 
 | [ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues.tostring__16y15q) | public | Returns a string that represents the current object. | 
 | [WriteXml(XmlWriter)](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues.writexml_system.xml.xmlwriter___154r01p) | public | Converts an object into its XML representation. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues.text__v1ms34" />  AllowedValues.Text Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [AllowedValues](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues__1bbwvx1)           
Sources: parser\dto\AllowedValues.cs</small>


The source list of allowed values in form &quot;value 1&quot;, &quot;value 2&quot;, &quot;value 3&quot;, &quot;value n&quot;



```csharp
private string Text { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues.values__1jdoyaj" />  AllowedValues.Values Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [AllowedValues](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues__1bbwvx1)           
Sources: parser\dto\AllowedValues.cs</small>


List of allowed values



```csharp
public string[] Values { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues.getschema__6pb4rt" />  AllowedValues.GetSchema() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [AllowedValues](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues__1bbwvx1)           
Sources: parser\dto\AllowedValues.cs</small>


This method is reserved and should not be used. When implementing the IXmlSerializable interface, you should return null (Nothing in Visual Basic) from this method, and instead, if specifying a custom schema is required, apply the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlschemaproviderattribute" target="_blank" >System.Xml.Serialization.XmlSchemaProviderAttribute</a> to the class.



```csharp
public XmlSchema GetSchema()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.schema.xmlschema" target="_blank" >System.Xml.Schema.XmlSchema</a></dt><dd>An <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.schema.xmlschema" target="_blank" >System.Xml.Schema.XmlSchema</a> that describes the XML representation of the object that is produced by the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.writexml#System_Xml_Serialization_IXmlSerializable_WriteXml_System_Xml_XmlWriter_" target="_blank" >System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)</a> method and consumed by the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.readxml#System_Xml_Serialization_IXmlSerializable_ReadXml_System_Xml_XmlReader_" target="_blank" >System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)</a> method.</dd></dl>Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.getschema#System_Xml_Serialization_IXmlSerializable_GetSchema" target="_blank" >Serialization.IXmlSerializable.GetSchema</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues.readxml_system.xml.xmlreader___ezr1qu" />  AllowedValues.ReadXml(XmlReader) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [AllowedValues](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues__1bbwvx1)           
Sources: parser\dto\AllowedValues.cs</small>


Generates an object from its XML representation.



```csharp
public void ReadXml(XmlReader reader)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlreader" target="_blank" >System.Xml.XmlReader</a> <strong>reader</strong></dt><dd>The <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlreader" target="_blank" >System.Xml.XmlReader</a> stream from which the object is deserialized.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.readxml#System_Xml_Serialization_IXmlSerializable_ReadXml_System_Xml_XmlReader_" target="_blank" >Serialization.IXmlSerializable.ReadXml</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues.tostring__16y15q" />  AllowedValues.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [AllowedValues](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues__1bbwvx1)           
Sources: parser\dto\AllowedValues.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues.writexml_system.xml.xmlwriter___154r01p" />  AllowedValues.WriteXml(XmlWriter) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [AllowedValues](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues__1bbwvx1)           
Sources: parser\dto\AllowedValues.cs</small>


Converts an object into its XML representation.



```csharp
public void WriteXml(XmlWriter writer)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlwriter" target="_blank" >System.Xml.XmlWriter</a> <strong>writer</strong></dt><dd>The <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlwriter" target="_blank" >System.Xml.XmlWriter</a> stream to which the object is serialized.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.writexml#System_Xml_Serialization_IXmlSerializable_WriteXml_System_Xml_XmlWriter_" target="_blank" >Serialization.IXmlSerializable.WriteXml</a>


###  Remarks ###
Not implemented - always throws <a href="https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception" target="_blank" >System.NotImplementedException</a>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception" target="_blank" >System.NotImplementedException</a></dt><dd>Method not implemented and should not be used</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9" />  Decision Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\Decision.cs</small>


Single decision within the DMN file It can be expression decision of decision table. Decision table is recognized by having the [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decision.decisiontable__192844l) element, otherwise, the expression decision is expected with elements [Expression](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decision.expression__1qkgb95) and [OutputVariable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decision.outputvariable__1gr23po)



```csharp
public class Decision : NamedElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.parser.dto.IdedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v) -&gt; [net.adamec.lib.common.dmn.engine.parser.dto.NamedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.namedelement__11eai0o)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decision.decisiontable__192844l) | public | Decision table encapsulating element | 
 | [Expression](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decision.expression__1qkgb95) | public | Expression of the expression decision | 
 | [InformationRequirements](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decision.informationrequirements__7unznf) | public | List of inputs of decisions the decision depends on | 
 | [OutputVariable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decision.outputvariable__1gr23po) | public | Output variable for the expression decision | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decision.decisiontable__192844l" />  Decision.DecisionTable Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9)           
Sources: parser\dto\Decision.cs</small>


Decision table encapsulating element



```csharp
[XmlElement("decisionTable")]
public DecisionTable DecisionTable { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr)</dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decision.expression__1qkgb95" />  Decision.Expression Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9)           
Sources: parser\dto\Decision.cs</small>


Expression of the expression decision



```csharp
[XmlElement("literalExpression")]
public Expression Expression { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.Expression](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.expression__tql32b)</dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decision.informationrequirements__7unznf" />  Decision.InformationRequirements Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9)           
Sources: parser\dto\Decision.cs</small>


List of inputs of decisions the decision depends on



```csharp
[XmlElement("informationRequirement")]
public List<net.adamec.lib.common.dmn.engine.parser.dto.InformationRequirement> InformationRequirements { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.parser.dto.InformationRequirement&gt;</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decision.outputvariable__1gr23po" />  Decision.OutputVariable Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Decision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9)           
Sources: parser\dto\Decision.cs</small>


Output variable for the expression decision



```csharp
[XmlElement("variable")]
public Variable OutputVariable { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.Variable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.variable__1klt78r)</dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule__ug9ttn" />  DecisionRule Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\DecisionRule.cs</small>


Decision table rule



```csharp
public class DecisionRule : IdedElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.parser.dto.IdedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Description](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule.description__1c17efb) | public | Optional description of the rule | 
 | [InputEntries](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule.inputentries__u88kch) | public | List of expressions to be evaluated for individual inputs | 
 | [Label](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule.label__1hb05zb) | public | Label used to name the rule If not provided, the Id is used instead | 
 | [OutputEntries](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule.outputentries__xm0172) | public | List of expressions to be evaluated when creating the outputs when rule matches | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule.tostring__f1k45s) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule.description__1c17efb" />  DecisionRule.Description Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionRule](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule__ug9ttn)           
Sources: parser\dto\DecisionRule.cs</small>


Optional description of the rule



```csharp
[XmlElement("description")]
public string Description { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule.inputentries__u88kch" />  DecisionRule.InputEntries Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionRule](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule__ug9ttn)           
Sources: parser\dto\DecisionRule.cs</small>


List of expressions to be evaluated for individual inputs



```csharp
[XmlElement("inputEntry")]
public List<net.adamec.lib.common.dmn.engine.parser.dto.Expression> InputEntries { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.parser.dto.Expression&gt;</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule.label__1hb05zb" />  DecisionRule.Label Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionRule](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule__ug9ttn)           
Sources: parser\dto\DecisionRule.cs</small>


Label used to name the rule If not provided, the Id is used instead



```csharp
[XmlAttribute("label")]
public string Label { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule.outputentries__xm0172" />  DecisionRule.OutputEntries Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionRule](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule__ug9ttn)           
Sources: parser\dto\DecisionRule.cs</small>


List of expressions to be evaluated when creating the outputs when rule matches



```csharp
[XmlElement("outputEntry")]
public List<net.adamec.lib.common.dmn.engine.parser.dto.Expression> OutputEntries { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.parser.dto.Expression&gt;</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule.tostring__f1k45s" />  DecisionRule.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionRule](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule__ug9ttn)           
Sources: parser\dto\DecisionRule.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: [IdedElement.ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.idedelement.tostring__11jwa8k)Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr" />  DecisionTable Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\DecisionTable.cs</small>


Decision table definition



```csharp
public class DecisionTable : IdedElement, IXmlSerializable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.parser.dto.IdedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable" target="_blank" >System.Xml.Serialization.IXmlSerializable</a>


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DecisionTableSerializableSerializer](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.decisiontableserializableserializer__1py1ie) | private static | Serializer used for the serialization proxy class - DMN version 1.1 | 
 | [DecisionTableSerializableSerializer13](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.decisiontableserializableserializer13__1ukdb4u) | private static | Serializer used for the serialization proxy class - DMN version 1.3 | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Aggregation](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.aggregation__1tmu6gt) | public | [Aggregation](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9) defined for &quot;COLLECT&quot; hit policy If not defined, [List](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum.list__u0sgin) is used as default | 
 | [AggregationSrc](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.aggregationsrc__1nlixpb) | private | Aggregation attribute for &quot;COLLECT&quot; hit policy Used just by deserializer, translated within [Aggregation](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.aggregation__1tmu6gt) property getter | 
 | [HitPolicy](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.hitpolicy__12cqsva) | public | [Hit policy](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz) defined for decision table If not defined, [Unique](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.unique__pve6y6) is used as default | 
 | [HitPolicySrc](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.hitpolicysrc__vijplw) | private | Hit policy attribute Used just by deserializer, translated within [HitPolicy](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.hitpolicy__12cqsva) property getter | 
 | [Inputs](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.inputs__1u48wwa) | public | List of decision table [inputs](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput__csk49) | 
 | [Outputs](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.outputs__68bgpp) | public | List of decision table [outputs](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput__63fwne) | 
 | [Rules](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.rules__1xxlmgi) | public | List of decision table [rules](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule__ug9ttn) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetSchema()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.getschema__u49m8r) | public | This method is reserved and should not be used. When implementing the IXmlSerializable interface, you should return null (Nothing in Visual Basic) from this method, and instead, if specifying a custom schema is required, apply the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlschemaproviderattribute" target="_blank" >System.Xml.Serialization.XmlSchemaProviderAttribute</a> to the class. | 
 | [ReadXml(XmlReader)](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.readxml_system.xml.xmlreader___1kcmfxa) | public | Generates an object from its XML representation. | 
 | [WriteXml(XmlWriter)](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.writexml_system.xml.xmlwriter___12g7mb) | public | Converts an object into its XML representation. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.decisiontableserializableserializer__1py1ie" />  DecisionTable.DecisionTableSerializableSerializer Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr)           
Sources: parser\dto\DecisionTable.cs</small>


Serializer used for the serialization proxy class - DMN version 1.1



```csharp
private static readonly XmlSerializer DecisionTableSerializableSerializer
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer" target="_blank" >System.Xml.Serialization.XmlSerializer</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.decisiontableserializableserializer13__1ukdb4u" />  DecisionTable.DecisionTableSerializableSerializer13 Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr)           
Sources: parser\dto\DecisionTable.cs</small>


Serializer used for the serialization proxy class - DMN version 1.3



```csharp
private static readonly XmlSerializer DecisionTableSerializableSerializer13
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer" target="_blank" >System.Xml.Serialization.XmlSerializer</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.aggregation__1tmu6gt" />  DecisionTable.Aggregation Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr)           
Sources: parser\dto\DecisionTable.cs</small>


[Aggregation](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9) defined for &quot;COLLECT&quot; hit policy If not defined, [List](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum.list__u0sgin) is used as default



```csharp
public CollectHitPolicyAggregationEnum Aggregation { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Wrong hit policy aggregation</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.aggregationsrc__1nlixpb" />  DecisionTable.AggregationSrc Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr)           
Sources: parser\dto\DecisionTable.cs</small>


Aggregation attribute for &quot;COLLECT&quot; hit policy Used just by deserializer, translated within [Aggregation](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.aggregation__1tmu6gt) property getter



```csharp
private string AggregationSrc { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Wrong hit policy aggregation</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.hitpolicy__12cqsva" />  DecisionTable.HitPolicy Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr)           
Sources: parser\dto\DecisionTable.cs</small>


[Hit policy](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz) defined for decision table If not defined, [Unique](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.unique__pve6y6) is used as default



```csharp
public HitPolicyEnum HitPolicy { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Wrong hit policy</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.hitpolicysrc__vijplw" />  DecisionTable.HitPolicySrc Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr)           
Sources: parser\dto\DecisionTable.cs</small>


Hit policy attribute Used just by deserializer, translated within [HitPolicy](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.hitpolicy__12cqsva) property getter



```csharp
private string HitPolicySrc { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.inputs__1u48wwa" />  DecisionTable.Inputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr)           
Sources: parser\dto\DecisionTable.cs</small>


List of decision table [inputs](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput__csk49)



```csharp
public List<net.adamec.lib.common.dmn.engine.parser.dto.DecisionTableInput> Inputs { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.parser.dto.DecisionTableInput&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.outputs__68bgpp" />  DecisionTable.Outputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr)           
Sources: parser\dto\DecisionTable.cs</small>


List of decision table [outputs](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput__63fwne)



```csharp
public List<net.adamec.lib.common.dmn.engine.parser.dto.DecisionTableOutput> Outputs { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.parser.dto.DecisionTableOutput&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.rules__1xxlmgi" />  DecisionTable.Rules Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr)           
Sources: parser\dto\DecisionTable.cs</small>


List of decision table [rules](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule__ug9ttn)



```csharp
public List<net.adamec.lib.common.dmn.engine.parser.dto.DecisionRule> Rules { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.parser.dto.DecisionRule&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.getschema__u49m8r" />  DecisionTable.GetSchema() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr)           
Sources: parser\dto\DecisionTable.cs</small>


This method is reserved and should not be used. When implementing the IXmlSerializable interface, you should return null (Nothing in Visual Basic) from this method, and instead, if specifying a custom schema is required, apply the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlschemaproviderattribute" target="_blank" >System.Xml.Serialization.XmlSchemaProviderAttribute</a> to the class.



```csharp
public XmlSchema GetSchema()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.schema.xmlschema" target="_blank" >System.Xml.Schema.XmlSchema</a></dt><dd>An <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.schema.xmlschema" target="_blank" >System.Xml.Schema.XmlSchema</a> that describes the XML representation of the object that is produced by the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.writexml#System_Xml_Serialization_IXmlSerializable_WriteXml_System_Xml_XmlWriter_" target="_blank" >System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)</a> method and consumed by the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.readxml#System_Xml_Serialization_IXmlSerializable_ReadXml_System_Xml_XmlReader_" target="_blank" >System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)</a> method.</dd></dl>Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.getschema#System_Xml_Serialization_IXmlSerializable_GetSchema" target="_blank" >Serialization.IXmlSerializable.GetSchema</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.readxml_system.xml.xmlreader___1kcmfxa" />  DecisionTable.ReadXml(XmlReader) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr)           
Sources: parser\dto\DecisionTable.cs</small>


Generates an object from its XML representation.



```csharp
public void ReadXml(XmlReader reader)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlreader" target="_blank" >System.Xml.XmlReader</a> <strong>reader</strong></dt><dd>The <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlreader" target="_blank" >System.Xml.XmlReader</a> stream from which the object is deserialized.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.readxml#System_Xml_Serialization_IXmlSerializable_ReadXml_System_Xml_XmlReader_" target="_blank" >Serialization.IXmlSerializable.ReadXml</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable.writexml_system.xml.xmlwriter___12g7mb" />  DecisionTable.WriteXml(XmlWriter) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr)           
Sources: parser\dto\DecisionTable.cs</small>


Converts an object into its XML representation.



```csharp
public void WriteXml(XmlWriter writer)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlwriter" target="_blank" >System.Xml.XmlWriter</a> <strong>writer</strong></dt><dd>The <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlwriter" target="_blank" >System.Xml.XmlWriter</a> stream to which the object is serialized.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.writexml#System_Xml_Serialization_IXmlSerializable_WriteXml_System_Xml_XmlWriter_" target="_blank" >Serialization.IXmlSerializable.WriteXml</a>


###  Remarks ###
Not implemented - always throws <a href="https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception" target="_blank" >System.NotImplementedException</a>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception" target="_blank" >System.NotImplementedException</a></dt><dd>Method not implemented and should not be used</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput__csk49" />  DecisionTableInput Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\DecisionTableInput.cs</small>


Decision table input definition



```csharp
public class DecisionTableInput : IdedElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.parser.dto.IdedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllowedInputValues](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput.allowedinputvalues__c6w9c9) | public | Optional list of allowed input values If the expression input is used, the allowed input values are checked after the expression evaluation | 
 | [InputExpression](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput.inputexpression__11ipo6n) | public | Input expression without the [Text](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.expression.text__oc7916) subelement just defines the data type of the input. When  the [Text](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.expression.text__oc7916) subelement is provided the expression is used as the input | 
 | [InputVariable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput.inputvariable__3707tj) | public | Name of the input variable if present | 
 | [Label](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput.label__azd7ah) | public | Label used to map to variable when the expression is not used | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput.tostring__2xejfu) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput.allowedinputvalues__c6w9c9" />  DecisionTableInput.AllowedInputValues Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTableInput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput__csk49)           
Sources: parser\dto\DecisionTableInput.cs</small>


Optional list of allowed input values If the expression input is used, the allowed input values are checked after the expression evaluation



```csharp
[XmlElement("inputValues")]
public AllowedValues AllowedInputValues { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.AllowedValues](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues__1bbwvx1)</dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput.inputexpression__11ipo6n" />  DecisionTableInput.InputExpression Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTableInput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput__csk49)           
Sources: parser\dto\DecisionTableInput.cs</small>


Input expression without the [Text](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.expression.text__oc7916) subelement just defines the data type of the input. When  the [Text](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.expression.text__oc7916) subelement is provided the expression is used as the input



```csharp
[XmlElement("inputExpression")]
public Expression InputExpression { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.Expression](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.expression__tql32b)</dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput.inputvariable__3707tj" />  DecisionTableInput.InputVariable Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTableInput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput__csk49)           
Sources: parser\dto\DecisionTableInput.cs</small>


Name of the input variable if present



```csharp
[XmlAttribute("inputVariable", Namespace = "http://camunda.org/schema/1.0/dmn")]
public string InputVariable { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput.label__azd7ah" />  DecisionTableInput.Label Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTableInput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput__csk49)           
Sources: parser\dto\DecisionTableInput.cs</small>


Label used to map to variable when the expression is not used



```csharp
[XmlAttribute("label")]
public string Label { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput.tostring__2xejfu" />  DecisionTableInput.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTableInput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput__csk49)           
Sources: parser\dto\DecisionTableInput.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: [IdedElement.ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.idedelement.tostring__11jwa8k)Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput__63fwne" />  DecisionTableOutput Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\DecisionTableOutput.cs</small>


Decision table output definition



```csharp
public class DecisionTableOutput : NamedElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.parser.dto.IdedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v) -&gt; [net.adamec.lib.common.dmn.engine.parser.dto.NamedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.namedelement__11eai0o)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllowedOutputValues](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput.allowedoutputvalues__1bxjand) | public | Allowed output values | 
 | [Label](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput.label__18qzvgi) | public | Label ouf the output | 
 | [TypeRef](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput.typeref__19e17wf) | public | Type of the output variable | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput.tostring__29qoix) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput.allowedoutputvalues__1bxjand" />  DecisionTableOutput.AllowedOutputValues Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTableOutput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput__63fwne)           
Sources: parser\dto\DecisionTableOutput.cs</small>


Allowed output values



```csharp
[XmlElement("outputValues")]
public AllowedValues AllowedOutputValues { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.AllowedValues](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.allowedvalues__1bbwvx1)</dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput.label__18qzvgi" />  DecisionTableOutput.Label Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTableOutput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput__63fwne)           
Sources: parser\dto\DecisionTableOutput.cs</small>


Label ouf the output



```csharp
[XmlAttribute("label")]
public string Label { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput.typeref__19e17wf" />  DecisionTableOutput.TypeRef Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTableOutput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput__63fwne)           
Sources: parser\dto\DecisionTableOutput.cs</small>


Type of the output variable



```csharp
[XmlAttribute("typeRef")]
public string TypeRef { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput.tostring__29qoix" />  DecisionTableOutput.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTableOutput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput__63fwne)           
Sources: parser\dto\DecisionTableOutput.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: [NamedElement.ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.namedelement.tostring__1txv1o1)Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable__a9v25k" />  DecisionTableSerializable Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\DecisionTable.cs</small>


Decision table (de)serialization proxy implemented to support the private getters in [DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr)



```csharp
public class DecisionTableSerializable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Aggregation](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable.aggregation__gifa90) | public | Aggregation attribute for &quot;COLLECT&quot; hit policy Used just by deserializer, translated within [Aggregation](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable.aggregation__gifa90) property getter | 
 | [HitPolicy](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable.hitpolicy__1b0m3m5) | public | Hit policy attribute Used just by deserializer, translated within [HitPolicy](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable.hitpolicy__1b0m3m5) property getter | 
 | [Inputs](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable.inputs__gn116p) | public | List of decision table [inputs](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput__csk49) | 
 | [Outputs](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable.outputs__1nwdb6c) | public | List of decision table [outputs](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput__63fwne) | 
 | [Rules](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable.rules__rrkc2x) | public | List of decision table [rules](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule__ug9ttn) | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable.aggregation__gifa90" />  DecisionTableSerializable.Aggregation Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTableSerializable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable__a9v25k)           
Sources: parser\dto\DecisionTable.cs</small>


Aggregation attribute for &quot;COLLECT&quot; hit policy Used just by deserializer, translated within [Aggregation](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable.aggregation__gifa90) property getter



```csharp
[XmlAttribute("aggregation")]
public string Aggregation { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Wrong hit policy aggregation</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable.hitpolicy__1b0m3m5" />  DecisionTableSerializable.HitPolicy Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTableSerializable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable__a9v25k)           
Sources: parser\dto\DecisionTable.cs</small>


Hit policy attribute Used just by deserializer, translated within [HitPolicy](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable.hitpolicy__1b0m3m5) property getter



```csharp
[XmlAttribute("hitPolicy")]
public string HitPolicy { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable.inputs__gn116p" />  DecisionTableSerializable.Inputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTableSerializable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable__a9v25k)           
Sources: parser\dto\DecisionTable.cs</small>


List of decision table [inputs](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput__csk49)



```csharp
[XmlElement("input")]
public List<net.adamec.lib.common.dmn.engine.parser.dto.DecisionTableInput> Inputs { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.parser.dto.DecisionTableInput&gt;</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable.outputs__1nwdb6c" />  DecisionTableSerializable.Outputs Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTableSerializable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable__a9v25k)           
Sources: parser\dto\DecisionTable.cs</small>


List of decision table [outputs](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput__63fwne)



```csharp
[XmlElement("output")]
public List<net.adamec.lib.common.dmn.engine.parser.dto.DecisionTableOutput> Outputs { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.parser.dto.DecisionTableOutput&gt;</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable.rules__rrkc2x" />  DecisionTableSerializable.Rules Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DecisionTableSerializable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableserializable__a9v25k)           
Sources: parser\dto\DecisionTable.cs</small>


List of decision table [rules](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule__ug9ttn)



```csharp
[XmlElement("rule")]
public List<net.adamec.lib.common.dmn.engine.parser.dto.DecisionRule> Rules { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.parser.dto.DecisionRule&gt;</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9" />  DmnModel Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\DmnModel.cs</small>


Root of DMN definition XML - DMN Model



```csharp
public class DmnModel
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Decisions](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel.decisions__cplqsq) | public | List of [decisions](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9) within DMN Model | 
 | [DiagramExtension](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel.diagramextension__1tdoo3v) | public | Diagrams within DMN Model | 
 | [DmnVersion](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel.dmnversion__1qhlawq) | public | DMN Version used by parser | 
 | [InputData](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel.inputdata__1pcg5ip) | public | List of input data parameters to be used by [Decisions](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel.decisions__cplqsq) for DMN Model | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel.decisions__cplqsq" />  DmnModel.Decisions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9)           
Sources: parser\dto\DmnModel.cs</small>


List of [decisions](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9) within DMN Model



```csharp
[XmlElement("decision")]
public List<net.adamec.lib.common.dmn.engine.parser.dto.Decision> Decisions { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.parser.dto.Decision&gt;</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel.diagramextension__1tdoo3v" />  DmnModel.DiagramExtension Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9)           
Sources: parser\dto\DmnModel.cs</small>


Diagrams within DMN Model



```csharp
[XmlElement("DMNDI", Namespace = "https://www.omg.org/spec/DMN/20191111/DMNDI/")]
public DmnDi DiagramExtension { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.diagram.DmnDi](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.dmndi__x0v2yy)</dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel.dmnversion__1qhlawq" />  DmnModel.DmnVersion Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9)           
Sources: parser\dto\DmnModel.cs</small>


DMN Version used by parser



```csharp
[XmlIgnore]
public DmnParser.DmnVersionEnum DmnVersion { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.DmnParser.DmnVersionEnum](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparser.dmnversionenum__1a1w78g)</dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlignoreattribute" target="_blank" >System.Xml.Serialization.XmlIgnoreAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel.inputdata__1pcg5ip" />  DmnModel.InputData Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnModel](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel__tqe6m9)           
Sources: parser\dto\DmnModel.cs</small>


List of input data parameters to be used by [Decisions](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.dmnmodel.decisions__cplqsq) for DMN Model



```csharp
[XmlElement("inputData")]
public List<net.adamec.lib.common.dmn.engine.parser.dto.InputData> InputData { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.parser.dto.InputData&gt;</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.expression__tql32b" />  Expression Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\Expression.cs</small>


Expression within the DMN definition file



```csharp
public class Expression : IdedElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.parser.dto.IdedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Language](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.expression.language__lir17f) | public | Currently not used (ignored) | 
 | [Text](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.expression.text__oc7916) | public | Expression text | 
 | [TypeRef](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.expression.typeref__6hvb6u) | public | Optional data type of the expression output | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.expression.tostring__7fbhse) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.expression.language__lir17f" />  Expression.Language Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Expression](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.expression__tql32b)           
Sources: parser\dto\Expression.cs</small>


Currently not used (ignored)



```csharp
[ExcludeFromCodeCoverage]
[XmlAttribute("expressionLanguage")]
public string Language { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.expression.text__oc7916" />  Expression.Text Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Expression](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.expression__tql32b)           
Sources: parser\dto\Expression.cs</small>


Expression text



```csharp
[XmlElement("text")]
public string Text { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.expression.typeref__6hvb6u" />  Expression.TypeRef Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Expression](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.expression__tql32b)           
Sources: parser\dto\Expression.cs</small>


Optional data type of the expression output



```csharp
[XmlAttribute("typeRef")]
public string TypeRef { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.expression.tostring__7fbhse" />  Expression.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Expression](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.expression__tql32b)           
Sources: parser\dto\Expression.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: [IdedElement.ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.idedelement.tostring__11jwa8k)Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v" />  IdedElement Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\IdedElement.cs</small>


Element with id attribute



```csharp
public abstract class IdedElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [net.adamec.lib.common.dmn.engine.parser.dto.DecisionRule](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisionrule__ug9ttn), [net.adamec.lib.common.dmn.engine.parser.dto.DecisionTable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontable__x8zzrr), [net.adamec.lib.common.dmn.engine.parser.dto.DecisionTableInput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableinput__csk49), [net.adamec.lib.common.dmn.engine.parser.dto.Expression](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.expression__tql32b), [net.adamec.lib.common.dmn.engine.parser.dto.NamedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.namedelement__11eai0o), [net.adamec.lib.common.dmn.engine.parser.dto.diagram.Diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.diagram__1il17tj), [net.adamec.lib.common.dmn.engine.parser.dto.diagram.Edge](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.edge__u1u2r5), [net.adamec.lib.common.dmn.engine.parser.dto.diagram.Shape](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.shape__1751ksp)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Id](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.idedelement.id__apj4gw) | public | ID of the element | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.idedelement.tostring__11jwa8k) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.idedelement.id__apj4gw" />  IdedElement.Id Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IdedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v)           
Sources: parser\dto\IdedElement.cs</small>


ID of the element



```csharp
[XmlAttribute("id")]
public string Id { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.idedelement.tostring__11jwa8k" />  IdedElement.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IdedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v)           
Sources: parser\dto\IdedElement.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement__1lwftc6" />  InformationRequirement Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\InformationRequirement.cs</small>


Defines the input or decision needed for the decision to be evaluated. The inputs are referenced by [RequiredInput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.requiredinput__jq7sir) sub-element and decisions by [RequiredDecision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.requireddecision__12tqhtx) one. Exactly one of the sub element must be present



```csharp
public class InformationRequirement : IXmlSerializable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable" target="_blank" >System.Xml.Serialization.IXmlSerializable</a>


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [InformationRequirementSerializableSerializer](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.informationrequirementserializableserializer__1eee3uo) | private static | Serializer used for the serialization proxy class - DMN version 1.1 | 
 | [InformationRequirementSerializableSerializer13](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.informationrequirementserializableserializer13__jp6cec) | private static | Serializer used for the serialization proxy class - DMN version 1.3 | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Ref](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.ref__1qmp3n1) | public | Gets the reference to ID of decision or input the decision depends to | 
 | [RequiredDecision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.requireddecision__12tqhtx) | private | Reference to required decision | 
 | [RequiredInput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.requiredinput__jq7sir) | private | Reference to required input | 
 | [RequirementType](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.requirementtype__uq9quz) | public | Gets the type of dependency (requirement) - input of decision | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetSchema()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.getschema__gotc92) | public | This method is reserved and should not be used. When implementing the IXmlSerializable interface, you should return null (Nothing in Visual Basic) from this method, and instead, if specifying a custom schema is required, apply the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlschemaproviderattribute" target="_blank" >System.Xml.Serialization.XmlSchemaProviderAttribute</a> to the class. | 
 | [ParseRef(string)](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.parseref_system.string___19xmaoq) | private static | Parses the reference attribute - get&#39;s the ID of the required decision/input from href attribute by removing the &quot;#&quot; prefix. | 
 | [ReadXml(XmlReader)](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.readxml_system.xml.xmlreader___u6p23z) | public | Generates an object from its XML representation. | 
 | [ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.tostring__55kkp7) | public | Returns a string that represents the current object. | 
 | [WriteXml(XmlWriter)](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.writexml_system.xml.xmlwriter___1y9a01y) | public | Converts an object into its XML representation. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.informationrequirementserializableserializer__1eee3uo" />  InformationRequirement.InformationRequirementSerializableSerializer Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [InformationRequirement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement__1lwftc6)           
Sources: parser\dto\InformationRequirement.cs</small>


Serializer used for the serialization proxy class - DMN version 1.1



```csharp
private static readonly XmlSerializer InformationRequirementSerializableSerializer
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer" target="_blank" >System.Xml.Serialization.XmlSerializer</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.informationrequirementserializableserializer13__jp6cec" />  InformationRequirement.InformationRequirementSerializableSerializer13 Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [InformationRequirement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement__1lwftc6)           
Sources: parser\dto\InformationRequirement.cs</small>


Serializer used for the serialization proxy class - DMN version 1.3



```csharp
private static readonly XmlSerializer InformationRequirementSerializableSerializer13
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer" target="_blank" >System.Xml.Serialization.XmlSerializer</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.ref__1qmp3n1" />  InformationRequirement.Ref Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [InformationRequirement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement__1lwftc6)           
Sources: parser\dto\InformationRequirement.cs</small>


Gets the reference to ID of decision or input the decision depends to



```csharp
public string Ref { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.requireddecision__12tqhtx" />  InformationRequirement.RequiredDecision Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [InformationRequirement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement__1lwftc6)           
Sources: parser\dto\InformationRequirement.cs</small>


Reference to required decision



```csharp
private InformationRequirement.InformationRequirementItem RequiredDecision { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.InformationRequirement.InformationRequirementItem](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.informationrequirementitem__1gbx84m)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.requiredinput__jq7sir" />  InformationRequirement.RequiredInput Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [InformationRequirement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement__1lwftc6)           
Sources: parser\dto\InformationRequirement.cs</small>


Reference to required input



```csharp
private InformationRequirement.InformationRequirementItem RequiredInput { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.InformationRequirement.InformationRequirementItem](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.informationrequirementitem__1gbx84m)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.requirementtype__uq9quz" />  InformationRequirement.RequirementType Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [InformationRequirement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement__1lwftc6)           
Sources: parser\dto\InformationRequirement.cs</small>


Gets the type of dependency (requirement) - input of decision



```csharp
public InformationRequirementType RequirementType { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.InformationRequirementType](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementtype__f6e7u6)</dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>informationRequirement element doesn&#39;t contain requiredDecision nor requiredInput elements or contains both</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.getschema__gotc92" />  InformationRequirement.GetSchema() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [InformationRequirement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement__1lwftc6)           
Sources: parser\dto\InformationRequirement.cs</small>


This method is reserved and should not be used. When implementing the IXmlSerializable interface, you should return null (Nothing in Visual Basic) from this method, and instead, if specifying a custom schema is required, apply the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlschemaproviderattribute" target="_blank" >System.Xml.Serialization.XmlSchemaProviderAttribute</a> to the class.



```csharp
public XmlSchema GetSchema()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.schema.xmlschema" target="_blank" >System.Xml.Schema.XmlSchema</a></dt><dd>An <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.schema.xmlschema" target="_blank" >System.Xml.Schema.XmlSchema</a> that describes the XML representation of the object that is produced by the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.writexml#System_Xml_Serialization_IXmlSerializable_WriteXml_System_Xml_XmlWriter_" target="_blank" >System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)</a> method and consumed by the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.readxml#System_Xml_Serialization_IXmlSerializable_ReadXml_System_Xml_XmlReader_" target="_blank" >System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)</a> method.</dd></dl>Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.getschema#System_Xml_Serialization_IXmlSerializable_GetSchema" target="_blank" >Serialization.IXmlSerializable.GetSchema</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.parseref_system.string___19xmaoq" />  InformationRequirement.ParseRef(string) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [InformationRequirement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement__1lwftc6)           
Sources: parser\dto\InformationRequirement.cs</small>


Parses the reference attribute - get&#39;s the ID of the required decision/input from href attribute by removing the &quot;#&quot; prefix.



```csharp
private static string ParseRef(string reference)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>reference</strong></dt><dd>href attribute value (source reference with &quot;#&quot; prefix</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The ID of required decision or input</dd></dl>


###  Exceptions ###
<dl><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Can&#39;t parse InformationRequirement - reference is null or empty</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Can&#39;t parse InformationRequirement - reference doesn&#39;t start with #</dd><dt>[DmnParserException](net.adamec.lib.common.dmn.engine.parser__src1fa.md#t-net.adamec.lib.common.dmn.engine.parser.dmnparserexception__1bq7ch7)</dt><dd>Can&#39;t parse InformationRequirement - reference too short/missing</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.readxml_system.xml.xmlreader___u6p23z" />  InformationRequirement.ReadXml(XmlReader) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [InformationRequirement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement__1lwftc6)           
Sources: parser\dto\InformationRequirement.cs</small>


Generates an object from its XML representation.



```csharp
public void ReadXml(XmlReader reader)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlreader" target="_blank" >System.Xml.XmlReader</a> <strong>reader</strong></dt><dd>The <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlreader" target="_blank" >System.Xml.XmlReader</a> stream from which the object is deserialized.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.readxml#System_Xml_Serialization_IXmlSerializable_ReadXml_System_Xml_XmlReader_" target="_blank" >Serialization.IXmlSerializable.ReadXml</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.tostring__55kkp7" />  InformationRequirement.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [InformationRequirement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement__1lwftc6)           
Sources: parser\dto\InformationRequirement.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.writexml_system.xml.xmlwriter___1y9a01y" />  InformationRequirement.WriteXml(XmlWriter) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [InformationRequirement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement__1lwftc6)           
Sources: parser\dto\InformationRequirement.cs</small>


Converts an object into its XML representation.



```csharp
public void WriteXml(XmlWriter writer)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlwriter" target="_blank" >System.Xml.XmlWriter</a> <strong>writer</strong></dt><dd>The <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlwriter" target="_blank" >System.Xml.XmlWriter</a> stream to which the object is serialized.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.ixmlserializable.writexml#System_Xml_Serialization_IXmlSerializable_WriteXml_System_Xml_XmlWriter_" target="_blank" >Serialization.IXmlSerializable.WriteXml</a>


###  Remarks ###
Not implemented - always throws <a href="https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception" target="_blank" >System.NotImplementedException</a>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception" target="_blank" >System.NotImplementedException</a></dt><dd>Method not implemented and should not be used</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.informationrequirementitem__1gbx84m" />  InformationRequirement.InformationRequirementItem Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\InformationRequirement.cs</small>


Required input or decision reference



```csharp
public class InformationRequirement.InformationRequirementItem
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Ref](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.informationrequirementitem.ref__15xndl) | public | Reference to input/decision by it&#39;s ID prefixed with &quot;#&quot; - for example href=&quot;#Input1&quot; | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.informationrequirementitem.ref__15xndl" />  InformationRequirement.InformationRequirementItem.Ref Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [InformationRequirement.InformationRequirementItem](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.informationrequirementitem__1gbx84m)           
Sources: parser\dto\InformationRequirement.cs</small>


Reference to input/decision by it&#39;s ID prefixed with &quot;#&quot; - for example href=&quot;#Input1&quot;



```csharp
[XmlAttribute("href")]
public string Ref { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementserializable__isg04z" />  InformationRequirementSerializable Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\InformationRequirement.cs</small>


Information Requirement (de)serialization proxy implemented to support the private getters in [InformationRequirement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement__1lwftc6)



```csharp
public class InformationRequirementSerializable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RequiredDecision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementserializable.requireddecision__19vhq2a) | public | Reference to required decision | 
 | [RequiredInput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementserializable.requiredinput__1qud5bc) | public | Reference to required input | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementserializable.requireddecision__19vhq2a" />  InformationRequirementSerializable.RequiredDecision Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [InformationRequirementSerializable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementserializable__isg04z)           
Sources: parser\dto\InformationRequirement.cs</small>


Reference to required decision



```csharp
[XmlElement("requiredDecision")]
public InformationRequirement.InformationRequirementItem RequiredDecision { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.InformationRequirement.InformationRequirementItem](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.informationrequirementitem__1gbx84m)</dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementserializable.requiredinput__1qud5bc" />  InformationRequirementSerializable.RequiredInput Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [InformationRequirementSerializable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementserializable__isg04z)           
Sources: parser\dto\InformationRequirement.cs</small>


Reference to required input



```csharp
[XmlElement("requiredInput")]
public InformationRequirement.InformationRequirementItem RequiredInput { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.InformationRequirement.InformationRequirementItem](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirement.informationrequirementitem__1gbx84m)</dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.inputdata__jk22hv" />  InputData Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\InputData.cs</small>


Input Data element Defines the input data item provided to the DMN model. The input parameter and related variable are defined by [Name](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.namedelement.name__3ml05)



```csharp
public class InputData : NamedElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.parser.dto.IdedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v) -&gt; [net.adamec.lib.common.dmn.engine.parser.dto.NamedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.namedelement__11eai0o)           



Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.namedelement__11eai0o" />  NamedElement Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\NamedElement.cs</small>


Element with id and name attributes



```csharp
public abstract class NamedElement : IdedElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.parser.dto.IdedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v)           
Derived: [net.adamec.lib.common.dmn.engine.parser.dto.Decision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9), [net.adamec.lib.common.dmn.engine.parser.dto.DecisionTableOutput](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decisiontableoutput__63fwne), [net.adamec.lib.common.dmn.engine.parser.dto.InputData](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.inputdata__jk22hv), [net.adamec.lib.common.dmn.engine.parser.dto.Variable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.variable__1klt78r)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Name](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.namedelement.name__3ml05) | public | Name of the element | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.namedelement.tostring__1txv1o1) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.namedelement.name__3ml05" />  NamedElement.Name Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [NamedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.namedelement__11eai0o)           
Sources: parser\dto\NamedElement.cs</small>


Name of the element



```csharp
[XmlAttribute("name")]
public string Name { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.namedelement.tostring__1txv1o1" />  NamedElement.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [NamedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.namedelement__11eai0o)           
Sources: parser\dto\NamedElement.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: [IdedElement.ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.idedelement.tostring__11jwa8k)Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.variable__1klt78r" />  Variable Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\Variable.cs</small>


Variable definition Used in [expression decision definition](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.decision__132ore9) to define the output variable



```csharp
public class Variable : NamedElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.parser.dto.IdedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v) -&gt; [net.adamec.lib.common.dmn.engine.parser.dto.NamedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.namedelement__11eai0o)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypeRef](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#p-net.adamec.lib.common.dmn.engine.parser.dto.variable.typeref__19fa0oc) | public | Data type of the variable | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.variable.tostring__1x0es0w) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.variable.typeref__19fa0oc" />  Variable.TypeRef Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.variable__1klt78r)           
Sources: parser\dto\Variable.cs</small>


Data type of the variable



```csharp
[XmlAttribute("typeRef")]
public string TypeRef { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.variable.tostring__1x0es0w" />  Variable.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Variable](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.variable__1klt78r)           
Sources: parser\dto\Variable.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: [NamedElement.ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.namedelement.tostring__1txv1o1)Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9" />  CollectHitPolicyAggregationEnum Enum ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\CollectHitPolicyAggregationEnum.cs</small>


Collect hit policy aggregation type



```csharp
public enum CollectHitPolicyAggregationEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [List](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum.list__u0sgin) | 0 | None, return list of values | 
 | [Sum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum.sum__rgvsee) | 1 | The sum of all output values | 
 | [Min](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum.min__1o1e7dz) | 2 | The smallest value of all output values | 
 | [Max](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum.max__1i5ay9l) | 3 | The largest value of all output values | 
 | [Count](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum.count__1mjyy32) | 4 | The number of output values | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum.count__1mjyy32" />  CollectHitPolicyAggregationEnum.Count Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9)           
Sources: parser\dto\CollectHitPolicyAggregationEnum.cs</small>


The number of output values



```csharp
 Count = 4
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum.list__u0sgin" />  CollectHitPolicyAggregationEnum.List Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9)           
Sources: parser\dto\CollectHitPolicyAggregationEnum.cs</small>


None, return list of values



```csharp
 List = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum.max__1i5ay9l" />  CollectHitPolicyAggregationEnum.Max Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9)           
Sources: parser\dto\CollectHitPolicyAggregationEnum.cs</small>


The largest value of all output values



```csharp
 Max = 3
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum.min__1o1e7dz" />  CollectHitPolicyAggregationEnum.Min Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9)           
Sources: parser\dto\CollectHitPolicyAggregationEnum.cs</small>


The smallest value of all output values



```csharp
 Min = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum.sum__rgvsee" />  CollectHitPolicyAggregationEnum.Sum Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9)           
Sources: parser\dto\CollectHitPolicyAggregationEnum.cs</small>


The sum of all output values



```csharp
 Sum = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.CollectHitPolicyAggregationEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.collecthitpolicyaggregationenum__1cnwis9)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz" />  HitPolicyEnum Enum ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\HitPolicyEnum.cs</small>


Decision Table hit policy - the hit policy specifies what the result of the decision table is in cases of overlapping rules, i.e. when more than one rule matches the input data.



```csharp
public enum HitPolicyEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>


###  Remarks ###
Decision tables with compound outputs support only the following hit policies: Unique, Any, Priority, First, Output order, Rule order and Collect without operator, because the collect operator is undefined over multiple outputs. For the Priority and Output order hit policies, priority is decided in compound output tables over all the outputs for which output values have been provided. The priority for each output is specified in the ordered list of output values in decreasing order of priority, and the overall priority is established by considering the ordered outputs from left to right. Outputs for which no output values are provided are not taken into account in the ordering, although their output entries are included in the ordered compound output.


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [Unique](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.unique__pve6y6) | 0 | No overlap is possible and all rules are disjoint. Only a single rule can be matched Overlapping rules represent an error. | 
 | [First](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.first__i9lwet) | 1 | Multiple (overlapping) rules can match, with different output entries. The first hit by rule order is returned | 
 | [Priority](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.priority__1pkij7x) | 2 | Multiple rules can match, with different output entries. This policy returns the matching rule with the highest output priority. Output priorities are specified in the ordered list of output values, in decreasing order of priority. Note that priorities are independent from rule sequence A P table that omits allowed output values is an error. | 
 | [Any](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.any__73sdbt) | 3 | There may be overlap, but all of the matching rules show equal output entries for each output, so any match can be used. If the output entries are non-equal, the hit policy is incorrect and the result is an error. | 
 | [Collect](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.collect__t0bm9p) | 4 | Multiple rules can be satisfied. The decision table result contains the output of all satisfied rules in an arbitrary order as a list. If an aggregator is specified, the decision table result will only contain a single output entry. The aggregator will generate the output entry from all satisfied rules. Except for C-count and C-list, the rules must have numeric output values (bool is also allowed - 0=false, 1=true). If the Collect hit policy is used with an aggregator, the decision table can only have one output. | 
 | [RuleOrder](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.ruleorder__xho807) | 5 | Multiple rules can be satisfied. The decision table result contains the output of all satisfied rules in the order of the rules in the decision table. | 
 | [OutputOrder](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.outputorder__3etfj0) | 6 | Returns all hits in decreasing output priority order. Output priorities are specified in the ordered list of output values in decreasing order of priority | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.any__73sdbt" />  HitPolicyEnum.Any Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)           
Sources: parser\dto\HitPolicyEnum.cs</small>


There may be overlap, but all of the matching rules show equal output entries for each output, so any match can be used. If the output entries are non-equal, the hit policy is incorrect and the result is an error.



```csharp
 Any = 3
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.collect__t0bm9p" />  HitPolicyEnum.Collect Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)           
Sources: parser\dto\HitPolicyEnum.cs</small>


Multiple rules can be satisfied. The decision table result contains the output of all satisfied rules in an arbitrary order as a list. If an aggregator is specified, the decision table result will only contain a single output entry. The aggregator will generate the output entry from all satisfied rules. Except for C-count and C-list, the rules must have numeric output values (bool is also allowed - 0=false, 1=true). If the Collect hit policy is used with an aggregator, the decision table can only have one output.



```csharp
 Collect = 4
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.first__i9lwet" />  HitPolicyEnum.First Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)           
Sources: parser\dto\HitPolicyEnum.cs</small>


Multiple (overlapping) rules can match, with different output entries. The first hit by rule order is returned



```csharp
 First = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.outputorder__3etfj0" />  HitPolicyEnum.OutputOrder Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)           
Sources: parser\dto\HitPolicyEnum.cs</small>


Returns all hits in decreasing output priority order. Output priorities are specified in the ordered list of output values in decreasing order of priority



```csharp
 OutputOrder = 6
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.priority__1pkij7x" />  HitPolicyEnum.Priority Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)           
Sources: parser\dto\HitPolicyEnum.cs</small>


Multiple rules can match, with different output entries. This policy returns the matching rule with the highest output priority. Output priorities are specified in the ordered list of output values, in decreasing order of priority. Note that priorities are independent from rule sequence A P table that omits allowed output values is an error.



```csharp
 Priority = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.ruleorder__xho807" />  HitPolicyEnum.RuleOrder Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)           
Sources: parser\dto\HitPolicyEnum.cs</small>


Multiple rules can be satisfied. The decision table result contains the output of all satisfied rules in the order of the rules in the decision table.



```csharp
 RuleOrder = 5
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum.unique__pve6y6" />  HitPolicyEnum.Unique Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)           
Sources: parser\dto\HitPolicyEnum.cs</small>


No overlap is possible and all rules are disjoint. Only a single rule can be matched Overlapping rules represent an error.



```csharp
 Unique = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.HitPolicyEnum](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.hitpolicyenum__g25tbz)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementtype__f6e7u6" />  InformationRequirementType Enum ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\InformationRequirement.cs</small>


Type of the dependency



```csharp
public enum InformationRequirementType: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [Decision](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementtype.decision__1jucpps) | 0 | Required decision | 
 | [Input](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#f-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementtype.input__e2nv6i) | 1 | Required input | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementtype.decision__1jucpps" />  InformationRequirementType.Decision Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [InformationRequirementType](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementtype__f6e7u6)           
Sources: parser\dto\InformationRequirement.cs</small>


Required decision



```csharp
 Decision = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.InformationRequirementType](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementtype__f6e7u6)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementtype.input__e2nv6i" />  InformationRequirementType.Input Constant ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#n-net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [InformationRequirementType](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementtype__f6e7u6)           
Sources: parser\dto\InformationRequirement.cs</small>


Required input



```csharp
 Input = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.InformationRequirementType](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.informationrequirementtype__f6e7u6)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 




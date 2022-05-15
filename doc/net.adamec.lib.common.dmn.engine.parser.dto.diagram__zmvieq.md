#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq" />  net.adamec.lib.common.dmn.engine.parser.dto.diagram Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Bounds](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds__iejac7) | public | Represents dc:Bounds element of [Shape](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.shape__1751ksp) in DMN XML | 
 | [Diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.diagram__1il17tj) | public | Represents dmndi:DMNDiagram element in DMN XML | 
 | [DmnDi](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.dmndi__x0v2yy) | public | Represents dmndi:DMNDI element in DMN XML | 
 | [Edge](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.edge__u1u2r5) | public | Represents dmndi:DMNEdge element in DMN XML | 
 | [Shape](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.shape__1751ksp) | public | Represents dmndi:DMNShape element in DMN XML | 
 | [Waypoint](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.waypoint__wmsg1p) | public | Represents di:waypoint element of [Edge](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.edge__u1u2r5) in DMN XML | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds__iejac7" />  Bounds Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\diagram\Bounds.cs</small>


Represents dc:Bounds element of [Shape](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.shape__1751ksp) in DMN XML



```csharp
public class Bounds
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Height](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds.height__19v1bao) | public | Height of shape | 
 | [Width](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds.width__r4prsf) | public | Width of shape | 
 | [X](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds.x__1rfblwp) | public | X position of shape | 
 | [Y](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds.y__iam61a) | public | Y position of shape | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#m-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds.tostring__1nf2v3w) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds.height__19v1bao" />  Bounds.Height Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Bounds](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds__iejac7)           
Sources: parser\dto\diagram\Bounds.cs</small>


Height of shape



```csharp
[XmlAttribute("height")]
public double Height { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds.width__r4prsf" />  Bounds.Width Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Bounds](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds__iejac7)           
Sources: parser\dto\diagram\Bounds.cs</small>


Width of shape



```csharp
[XmlAttribute("width")]
public double Width { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds.x__1rfblwp" />  Bounds.X Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Bounds](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds__iejac7)           
Sources: parser\dto\diagram\Bounds.cs</small>


X position of shape



```csharp
[XmlAttribute("x")]
public double X { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds.y__iam61a" />  Bounds.Y Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Bounds](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds__iejac7)           
Sources: parser\dto\diagram\Bounds.cs</small>


Y position of shape



```csharp
[XmlAttribute("y")]
public double Y { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds.tostring__1nf2v3w" />  Bounds.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Bounds](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds__iejac7)           
Sources: parser\dto\diagram\Bounds.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.diagram__1il17tj" />  Diagram Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\diagram\Diagram.cs</small>


Represents dmndi:DMNDiagram element in DMN XML



```csharp
public class Diagram : IdedElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.parser.dto.IdedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Edges](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.diagram.edges__w2j7kp) | public | List of elements within the diagram | 
 | [Shapes](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.diagram.shapes__167im0p) | public | List of shapes within the diagram | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#m-net.adamec.lib.common.dmn.engine.parser.dto.diagram.diagram.tostring__7toy3m) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.diagram.edges__w2j7kp" />  Diagram.Edges Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.diagram__1il17tj)           
Sources: parser\dto\diagram\Diagram.cs</small>


List of elements within the diagram



```csharp
[XmlElement("DMNEdge", Namespace = "https://www.omg.org/spec/DMN/20191111/DMNDI/")]
public List<net.adamec.lib.common.dmn.engine.parser.dto.diagram.Edge> Edges { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.parser.dto.diagram.Edge&gt;</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.diagram.shapes__167im0p" />  Diagram.Shapes Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.diagram__1il17tj)           
Sources: parser\dto\diagram\Diagram.cs</small>


List of shapes within the diagram



```csharp
[XmlElement("DMNShape", Namespace = "https://www.omg.org/spec/DMN/20191111/DMNDI/")]
public List<net.adamec.lib.common.dmn.engine.parser.dto.diagram.Shape> Shapes { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.parser.dto.diagram.Shape&gt;</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.diagram.diagram.tostring__7toy3m" />  Diagram.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.diagram__1il17tj)           
Sources: parser\dto\diagram\Diagram.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: [IdedElement.ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.idedelement.tostring__11jwa8k)Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.dmndi__x0v2yy" />  DmnDi Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\diagram\DmnDi.cs</small>


Represents dmndi:DMNDI element in DMN XML



```csharp
public class DmnDi
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Diagrams](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.dmndi.diagrams__9sdz9e) | public | List of [diagrams](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.diagram__1il17tj) within DMN Model | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#m-net.adamec.lib.common.dmn.engine.parser.dto.diagram.dmndi.tostring__uw0ww9) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.dmndi.diagrams__9sdz9e" />  DmnDi.Diagrams Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDi](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.dmndi__x0v2yy)           
Sources: parser\dto\diagram\DmnDi.cs</small>


List of [diagrams](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.diagram__1il17tj) within DMN Model



```csharp
[XmlElement("DMNDiagram", Namespace = "https://www.omg.org/spec/DMN/20191111/DMNDI/")]
public List<net.adamec.lib.common.dmn.engine.parser.dto.diagram.Diagram> Diagrams { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.parser.dto.diagram.Diagram&gt;</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.diagram.dmndi.tostring__uw0ww9" />  DmnDi.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnDi](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.dmndi__x0v2yy)           
Sources: parser\dto\diagram\DmnDi.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.edge__u1u2r5" />  Edge Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\diagram\Edge.cs</small>


Represents dmndi:DMNEdge element in DMN XML



```csharp
public class Edge : IdedElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.parser.dto.IdedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnElementRef](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.edge.dmnelementref__1ds1r5b) | public | Reference to DMN element in model (typically information requirement) | 
 | [Waypoints](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.edge.waypoints__1r8pj6z) | public | List of waypoints of the edge | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#m-net.adamec.lib.common.dmn.engine.parser.dto.diagram.edge.tostring__1fim5j4) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.edge.dmnelementref__1ds1r5b" />  Edge.DmnElementRef Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Edge](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.edge__u1u2r5)           
Sources: parser\dto\diagram\Edge.cs</small>


Reference to DMN element in model (typically information requirement)



```csharp
[XmlAttribute("dmnElementRef")]
public string DmnElementRef { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.edge.waypoints__1r8pj6z" />  Edge.Waypoints Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Edge](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.edge__u1u2r5)           
Sources: parser\dto\diagram\Edge.cs</small>


List of waypoints of the edge



```csharp
[XmlElement("waypoint", Namespace = "http://www.omg.org/spec/DMN/20180521/DI/")]
public List<net.adamec.lib.common.dmn.engine.parser.dto.diagram.Waypoint> Waypoints { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.dmn.engine.parser.dto.diagram.Waypoint&gt;</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.diagram.edge.tostring__1fim5j4" />  Edge.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Edge](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.edge__u1u2r5)           
Sources: parser\dto\diagram\Edge.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: [IdedElement.ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.idedelement.tostring__11jwa8k)Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.shape__1751ksp" />  Shape Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\diagram\Shape.cs</small>


Represents dmndi:DMNShape element in DMN XML



```csharp
public class Shape : IdedElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.dmn.engine.parser.dto.IdedElement](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#t-net.adamec.lib.common.dmn.engine.parser.dto.idedelement__1e85r4v)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Bounds](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.shape.bounds__erva56) | public | Boundaries of the shape | 
 | [DmnElementRef](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.shape.dmnelementref__ob994v) | public | Reference to DMN element in model (typically decision or input parameter) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#m-net.adamec.lib.common.dmn.engine.parser.dto.diagram.shape.tostring__h1ma8i) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.shape.bounds__erva56" />  Shape.Bounds Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Shape](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.shape__1751ksp)           
Sources: parser\dto\diagram\Shape.cs</small>


Boundaries of the shape



```csharp
[XmlElement("Bounds", Namespace = "http://www.omg.org/spec/DMN/20180521/DC/")]
public Bounds Bounds { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.parser.dto.diagram.Bounds](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.bounds__iejac7)</dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlelementattribute" target="_blank" >System.Xml.Serialization.XmlElementAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.shape.dmnelementref__ob994v" />  Shape.DmnElementRef Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Shape](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.shape__1751ksp)           
Sources: parser\dto\diagram\Shape.cs</small>


Reference to DMN element in model (typically decision or input parameter)



```csharp
[XmlAttribute("dmnElementRef")]
public string DmnElementRef { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.diagram.shape.tostring__h1ma8i" />  Shape.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Shape](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.shape__1751ksp)           
Sources: parser\dto\diagram\Shape.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: [IdedElement.ToString()](net.adamec.lib.common.dmn.engine.parser.dto__17tk5mp.md#m-net.adamec.lib.common.dmn.engine.parser.dto.idedelement.tostring__11jwa8k)Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.waypoint__wmsg1p" />  Waypoint Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: parser\dto\diagram\Waypoint.cs</small>


Represents di:waypoint element of [Edge](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.edge__u1u2r5) in DMN XML



```csharp
public class Waypoint
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [X](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.waypoint.x__14je5pr) | public | X position of waypoint | 
 | [Y](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.waypoint.y__1ufsrtg) | public | Y position of waypoint | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#m-net.adamec.lib.common.dmn.engine.parser.dto.diagram.waypoint.tostring__lb5jgm) | public | Returns a string that represents the current object. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.waypoint.x__14je5pr" />  Waypoint.X Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Waypoint](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.waypoint__wmsg1p)           
Sources: parser\dto\diagram\Waypoint.cs</small>


X position of waypoint



```csharp
[XmlAttribute("x")]
public double X { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.parser.dto.diagram.waypoint.y__1ufsrtg" />  Waypoint.Y Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Waypoint](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.waypoint__wmsg1p)           
Sources: parser\dto\diagram\Waypoint.cs</small>


Y position of waypoint



```csharp
[XmlAttribute("y")]
public double Y { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlattributeattribute" target="_blank" >System.Xml.Serialization.XmlAttributeAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.parser.dto.diagram.waypoint.tostring__lb5jgm" />  Waypoint.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.parser.dto.diagram](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#n-net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [Waypoint](net.adamec.lib.common.dmn.engine.parser.dto.diagram__zmvieq.md#t-net.adamec.lib.common.dmn.engine.parser.dto.diagram.waypoint__wmsg1p)           
Sources: parser\dto\diagram\Waypoint.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 




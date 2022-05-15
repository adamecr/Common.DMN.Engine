#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25" />  net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DiDiagramExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension__rjfeea) | public | Extension containing the DMN DI Diagram shapes with bounds for elements in definition | 
 | [DiDiagramShapeExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension__1g3jyq3) | public | Extension containing the DMN DI Diagram shape bounds for single element | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension__rjfeea" />  DiDiagramExtension Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\extensions\diagram\DiDiagramExtension.cs</small>


Extension containing the DMN DI Diagram shapes with bounds for elements in definition



```csharp
public class DiDiagramExtension : ICloneable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icloneable" target="_blank" >System.ICloneable</a>


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [shapesByElement](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#f-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension.shapesbyelement__1cvvf1) | private | DMN DI Diagram shapes with bounds for elements in definition | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ShapesByElement](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension.shapesbyelement__yu1ed3) | public | DMN DI Diagram shapes with bounds for elements in definition | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Clone()](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension.clone__gcm93k) | public | Creates a new object that is a copy of the current instance | 
 | [System.ICloneable.Clone()](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension.system-icloneable-clone__m5d4ml) | private | Creates a new object that is a copy of the current instance | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension.tostring__1lqgiqx) | public | Returns a string that represents the current object. | 

 


###  Explicit Interface Implementations ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [System.ICloneable.Clone()](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension.system-icloneable-clone__m5d4ml) | private | Creates a new object that is a copy of the current instance | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="f-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension.shapesbyelement__1cvvf1" />  DiDiagramExtension.shapesByElement Field ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DiDiagramExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension__rjfeea)           
Sources: engine\definition\extensions\diagram\DiDiagramExtension.cs</small>


DMN DI Diagram shapes with bounds for elements in definition



```csharp
private Dictionary<net.adamec.lib.common.dmn.engine.engine.definition.IDmnElement,net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.DiDiagramShapeExtension> shapesByElement
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnElement,net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.DiDiagramShapeExtension&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension.shapesbyelement__yu1ed3" />  DiDiagramExtension.ShapesByElement Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DiDiagramExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension__rjfeea)           
Sources: engine\definition\extensions\diagram\DiDiagramExtension.cs</small>


DMN DI Diagram shapes with bounds for elements in definition



```csharp
public Dictionary<net.adamec.lib.common.dmn.engine.engine.definition.IDmnElement,net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.DiDiagramShapeExtension> ShapesByElement { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;net.adamec.lib.common.dmn.engine.engine.definition.IDmnElement,net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.DiDiagramShapeExtension&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension.clone__gcm93k" />  DiDiagramExtension.Clone() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DiDiagramExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension__rjfeea)           
Sources: engine\definition\extensions\diagram\DiDiagramExtension.cs</small>


Creates a new object that is a copy of the current instance



```csharp
public DiDiagramExtension Clone()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.DiDiagramExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension__rjfeea)</dt><dd>A new object that is a copy of the current instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension.system-icloneable-clone__m5d4ml" />  DiDiagramExtension.System.ICloneable.Clone() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DiDiagramExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension__rjfeea)           
Sources: engine\definition\extensions\diagram\DiDiagramExtension.cs</small>


Creates a new object that is a copy of the current instance



```csharp
private object System.ICloneable.Clone()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>A new object that is a copy of the current instance</dd></dl>Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icloneable.clone#System_ICloneable_Clone" target="_blank" >System.ICloneable.Clone</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension.tostring__1lqgiqx" />  DiDiagramExtension.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DiDiagramExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramextension__rjfeea)           
Sources: engine\definition\extensions\diagram\DiDiagramExtension.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension__1g3jyq3" />  DiDiagramShapeExtension Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\extensions\diagram\DiDiagramShapeExtension.cs</small>


Extension containing the DMN DI Diagram shape bounds for single element



```csharp
public class DiDiagramShapeExtension : ICloneable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icloneable" target="_blank" >System.ICloneable</a>


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Height](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.height__1c0nh8o) | public | Height of shape in diagram | 
 | [Width](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.width__12v4zib) | public | Width of shape in diagram | 
 | [X](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.x__1gql5fp) | public | X position of shape in diagram | 
 | [Y](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.y__1gql5fq) | public | Y position of shape in diagram | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DiDiagramShapeExtension(double, double, double, double)](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.-ctor_system.double-system.double-system.double-system.double___xbxmn4) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Clone()](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.clone__10pf7dz) | public | Creates a new object that is a copy of the current instance | 
 | [System.ICloneable.Clone()](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.system-icloneable-clone__1m4gcg6) | private | Creates a new object that is a copy of the current instance | 
 | [ToString()](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.tostring__5spriu) | public | Returns a string that represents the current object. | 

 


###  Explicit Interface Implementations ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [System.ICloneable.Clone()](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.system-icloneable-clone__1m4gcg6) | private | Creates a new object that is a copy of the current instance | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.height__1c0nh8o" />  DiDiagramShapeExtension.Height Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DiDiagramShapeExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension__1g3jyq3)           
Sources: engine\definition\extensions\diagram\DiDiagramShapeExtension.cs</small>


Height of shape in diagram



```csharp
public double Height { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.width__12v4zib" />  DiDiagramShapeExtension.Width Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DiDiagramShapeExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension__1g3jyq3)           
Sources: engine\definition\extensions\diagram\DiDiagramShapeExtension.cs</small>


Width of shape in diagram



```csharp
public double Width { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.x__1gql5fp" />  DiDiagramShapeExtension.X Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DiDiagramShapeExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension__1g3jyq3)           
Sources: engine\definition\extensions\diagram\DiDiagramShapeExtension.cs</small>


X position of shape in diagram



```csharp
public double X { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.y__1gql5fq" />  DiDiagramShapeExtension.Y Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DiDiagramShapeExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension__1g3jyq3)           
Sources: engine\definition\extensions\diagram\DiDiagramShapeExtension.cs</small>


Y position of shape in diagram



```csharp
public double Y { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.-ctor_system.double-system.double-system.double-system.double___xbxmn4" />  DiDiagramShapeExtension.DiDiagramShapeExtension(double, double, double, double) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DiDiagramShapeExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension__1g3jyq3)           
Sources: engine\definition\extensions\diagram\DiDiagramShapeExtension.cs</small>


CTOR



```csharp
public DiDiagramShapeExtension(double x, double y, double width, double height)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a> <strong>x</strong></dt><dd>X position of shape in diagram</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a> <strong>y</strong></dt><dd>Y position of shape in diagram</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a> <strong>width</strong></dt><dd>Width of shape in diagram</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a> <strong>height</strong></dt><dd>Height of shape in diagram</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.clone__10pf7dz" />  DiDiagramShapeExtension.Clone() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DiDiagramShapeExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension__1g3jyq3)           
Sources: engine\definition\extensions\diagram\DiDiagramShapeExtension.cs</small>


Creates a new object that is a copy of the current instance



```csharp
public DiDiagramShapeExtension Clone()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.DiDiagramShapeExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension__1g3jyq3)</dt><dd>A new object that is a copy of the current instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.system-icloneable-clone__1m4gcg6" />  DiDiagramShapeExtension.System.ICloneable.Clone() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DiDiagramShapeExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension__1g3jyq3)           
Sources: engine\definition\extensions\diagram\DiDiagramShapeExtension.cs</small>


Creates a new object that is a copy of the current instance



```csharp
private object System.ICloneable.Clone()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>A new object that is a copy of the current instance</dd></dl>Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icloneable.clone#System_ICloneable_Clone" target="_blank" >System.ICloneable.Clone</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension.tostring__5spriu" />  DiDiagramShapeExtension.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DiDiagramShapeExtension](net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram__1fw6w25.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram.didiagramshapeextension__1g3jyq3)           
Sources: engine\definition\extensions\diagram\DiDiagramShapeExtension.cs</small>


Returns a string that represents the current object.



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>A string that represents the current object.</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 




#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.extensions__1vwuhoq" />  net.adamec.lib.common.extensions Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypeExtensions](net.adamec.lib.common.extensions__1vwuhoq.md#t-net.adamec.lib.common.extensions.typeextensions__63ezc8) | internal static | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> extensions | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.extensions.typeextensions__63ezc8" />  TypeExtensions Class ##
<small>Namespace: [net.adamec.lib.common.extensions](net.adamec.lib.common.extensions__1vwuhoq.md#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: ny\App_Packages\RadCommons.extensions.TypeExtensions.DefaultValue\TypeExtensionsDefaultValue.cs           
Source-only packages: [RadCommons.extensions.TypeExtensions.DefaultValue](src-only-packages--.html#src-only-package--RadCommons.extensions.TypeExtensions.DefaultValue)</small>


<a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> extensions



```csharp
internal static class TypeExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetDefaultValue(Type)](net.adamec.lib.common.extensions__1vwuhoq.md#m-net.adamec.lib.common.extensions.typeextensions.getdefaultvalue_system.type___vn2w69) | public static | Gets the default value of given <strong>type</strong> | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.typeextensions.getdefaultvalue_system.type___vn2w69" />  TypeExtensions.GetDefaultValue(Type) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](net.adamec.lib.common.extensions__1vwuhoq.md#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [TypeExtensions](net.adamec.lib.common.extensions__1vwuhoq.md#t-net.adamec.lib.common.extensions.typeextensions__63ezc8)           
Sources: ny\App_Packages\RadCommons.extensions.TypeExtensions.DefaultValue\TypeExtensionsDefaultValue.cs           
Source-only packages: [RadCommons.extensions.TypeExtensions.DefaultValue](src-only-packages--.html#src-only-package--RadCommons.extensions.TypeExtensions.DefaultValue)</small>


Gets the default value of given <strong>type</strong>



```csharp
public static object GetDefaultValue(this Type type)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>Default value of given <strong>type</strong> . Null for non-value types, new instance for value types.</dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd><strong>type</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 




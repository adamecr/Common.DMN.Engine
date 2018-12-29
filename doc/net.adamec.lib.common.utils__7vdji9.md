#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.utils__7vdji9" />  net.adamec.lib.common.utils Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps) | public abstract | Helper class for implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> types | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.basedisposable__7s72ps" />  BaseDisposable Class ##
<small>Namespace: [net.adamec.lib.common.utils](net.adamec.lib.common.utils__7vdji9.md#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: s\any\App_Packages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](src-only-packages--.html#src-only-package--RadCommons.utils.BaseDisposable)</small>


Helper class for implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> types



```csharp
public abstract class BaseDisposable : IDisposable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Disposed](net.adamec.lib.common.utils__7vdji9.md#p-net.adamec.lib.common.utils.basedisposable.disposed__nxq2fp) | public | Flag whether the object is fully disposed | 
 | [DisposedManaged](net.adamec.lib.common.utils__7vdji9.md#p-net.adamec.lib.common.utils.basedisposable.disposedmanaged__1pm7df6) | public | Flag whether the managed resources are disposed | 
 | [DisposedNative](net.adamec.lib.common.utils__7vdji9.md#p-net.adamec.lib.common.utils.basedisposable.disposednative__fqjn7i) | public | Flag whether the native resources are disposed | 

 


###  Destructor ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [~BaseDisposable()](net.adamec.lib.common.utils__7vdji9.md#m-net.adamec.lib.common.utils.basedisposable.finalize__1l3n8dl) | protected |  | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Dispose()](net.adamec.lib.common.utils__7vdji9.md#m-net.adamec.lib.common.utils.basedisposable.dispose__6qe9ri) | public | Dispose the object | 
 | [Dispose(bool)](net.adamec.lib.common.utils__7vdji9.md#m-net.adamec.lib.common.utils.basedisposable.dispose_system.boolean___1vzs8w4) | protected | Internal implementation of dispose - free the managed and native resources using the respective methods | 
 | [DisposeManaged()](net.adamec.lib.common.utils__7vdji9.md#m-net.adamec.lib.common.utils.basedisposable.disposemanaged__1ht3p85) | protected | Dispose any disposable managed fields or properties. | 
 | [DisposeNative()](net.adamec.lib.common.utils__7vdji9.md#m-net.adamec.lib.common.utils.basedisposable.disposenative__uaa3i9) | protected | Dispose of COM objects, Handles, etc. Then set those objects to null. | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.basedisposable.disposed__nxq2fp" />  BaseDisposable.Disposed Property ##
<small>Namespace: [net.adamec.lib.common.utils](net.adamec.lib.common.utils__7vdji9.md#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Sources: s\any\App_Packages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](src-only-packages--.html#src-only-package--RadCommons.utils.BaseDisposable)</small>


Flag whether the object is fully disposed



```csharp
public bool Disposed { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.basedisposable.disposedmanaged__1pm7df6" />  BaseDisposable.DisposedManaged Property ##
<small>Namespace: [net.adamec.lib.common.utils](net.adamec.lib.common.utils__7vdji9.md#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Sources: s\any\App_Packages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](src-only-packages--.html#src-only-package--RadCommons.utils.BaseDisposable)</small>


Flag whether the managed resources are disposed



```csharp
public bool DisposedManaged { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.basedisposable.disposednative__fqjn7i" />  BaseDisposable.DisposedNative Property ##
<small>Namespace: [net.adamec.lib.common.utils](net.adamec.lib.common.utils__7vdji9.md#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Sources: s\any\App_Packages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](src-only-packages--.html#src-only-package--RadCommons.utils.BaseDisposable)</small>


Flag whether the native resources are disposed



```csharp
public bool DisposedNative { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.basedisposable.finalize__1l3n8dl" />  BaseDisposable.~BaseDisposable() Destructor ##
<small>Namespace: [net.adamec.lib.common.utils](net.adamec.lib.common.utils__7vdji9.md#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Sources: s\any\App_Packages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](src-only-packages--.html#src-only-package--RadCommons.utils.BaseDisposable)</small>



```csharp
 ~BaseDisposable()
```

Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.basedisposable.dispose__6qe9ri" />  BaseDisposable.Dispose() Method ##
<small>Namespace: [net.adamec.lib.common.utils](net.adamec.lib.common.utils__7vdji9.md#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Sources: s\any\App_Packages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](src-only-packages--.html#src-only-package--RadCommons.utils.BaseDisposable)</small>


Dispose the object



```csharp
public void Dispose()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable.dispose#System_IDisposable_Dispose" target="_blank" >IDisposable.Dispose</a>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.basedisposable.dispose_system.boolean___1vzs8w4" />  BaseDisposable.Dispose(bool) Method ##
<small>Namespace: [net.adamec.lib.common.utils](net.adamec.lib.common.utils__7vdji9.md#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Sources: s\any\App_Packages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](src-only-packages--.html#src-only-package--RadCommons.utils.BaseDisposable)</small>


Internal implementation of dispose - free the managed and native resources using the respective methods



```csharp
protected virtual void Dispose(bool disposing)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>disposing</strong></dt><dd>Flag whether the object is disposing (called from [Dispose()](net.adamec.lib.common.utils__7vdji9.md#m-net.adamec.lib.common.utils.basedisposable.dispose__6qe9ri) method). False if called from destructor</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.basedisposable.disposemanaged__1ht3p85" />  BaseDisposable.DisposeManaged() Method ##
<small>Namespace: [net.adamec.lib.common.utils](net.adamec.lib.common.utils__7vdji9.md#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Sources: s\any\App_Packages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](src-only-packages--.html#src-only-package--RadCommons.utils.BaseDisposable)</small>


Dispose any disposable managed fields or properties.



```csharp
protected virtual void DisposeManaged()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.basedisposable.disposenative__uaa3i9" />  BaseDisposable.DisposeNative() Method ##
<small>Namespace: [net.adamec.lib.common.utils](net.adamec.lib.common.utils__7vdji9.md#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Sources: s\any\App_Packages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](src-only-packages--.html#src-only-package--RadCommons.utils.BaseDisposable)</small>


Dispose of COM objects, Handles, etc. Then set those objects to null.



```csharp
protected virtual void DisposeNative()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list) or [source-only packages](net.adamec.lib.common.dmn.engine.md#package-list)


 




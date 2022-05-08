#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu" />  net.adamec.lib.common.dmn.engine.engine.definition.extensions Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExtendableExtensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.dmnextendableextensions__18z3obb) | public static | [IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o) extension methods to access the [Extensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable.extensions__1fyoyrc) | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o) | public abstract | DMN definition classes that can have extensions | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.dmnextendableextensions__18z3obb" />  DmnExtendableExtensions Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\extensions\DmnExtendableExtensions.cs</small>


[IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o) extension methods to access the [Extensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable.extensions__1fyoyrc)



```csharp
public static class DmnExtendableExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddExtension(IDmnExtendable, object)](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.dmnextendableextensions.addextension_net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable-system.object___eyzeu9) | public static | Adds <strong>extension</strong> to <strong>element</strong> | 
 | [GetExtension&lt;TExtension&gt;(IDmnExtendable)](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.dmnextendableextensions.getextension--1_net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable___1fm96rp) | public static | Get the first extension of type <strong>TExtension</strong> from <strong>element</strong> | 
 | [GetExtensions&lt;TExtension&gt;(IDmnExtendable)](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.dmnextendableextensions.getextensions--1_net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable___7pp1ws) | public static | Get all extensions of type <strong>TExtension</strong> from <strong>element</strong> | 
 | [HasExtension&lt;TExtension&gt;(IDmnExtendable)](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.dmnextendableextensions.hasextension--1_net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable___1f14ct5) | public static | Check whether <strong>element</strong> has the extension of type <strong>TExtension</strong> | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.dmnextendableextensions.addextension_net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable-system.object___eyzeu9" />  DmnExtendableExtensions.AddExtension(IDmnExtendable, object) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExtendableExtensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.dmnextendableextensions__18z3obb)           
Sources: engine\definition\extensions\DmnExtendableExtensions.cs</small>


Adds <strong>extension</strong> to <strong>element</strong>



```csharp
public static void AddExtension(this IDmnExtendable element, object extension)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.extensions.IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o) <strong>element</strong></dt><dd>DMN element to add the extension to</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>extension</strong></dt><dd>Extension to add</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception" target="_blank" >System.ArgumentNullException</a></dt><dd>When <strong>element</strong> or <strong>extension</strong> is null</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.dmnextendableextensions.getextension--1_net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable___1fm96rp" />  DmnExtendableExtensions.GetExtension&lt;TExtension&gt;(IDmnExtendable) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExtendableExtensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.dmnextendableextensions__18z3obb)           
Sources: engine\definition\extensions\DmnExtendableExtensions.cs</small>


Get the first extension of type <strong>TExtension</strong> from <strong>element</strong>



```csharp
public static DmnExtendableExtensions.TExtension GetExtension<TExtension>(this IDmnExtendable element)
```

<strong>Type parameters</strong><dl><dt><strong>TExtension</strong></dt><dd>Type of the extension</dd></dl>
<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.extensions.IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o) <strong>element</strong></dt><dd>DMN element</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.dmn.engine.engine.definition.extensions.DmnExtendableExtensions.TExtension</dt><dd>The first extension of type <strong>TExtension</strong> from <strong>element</strong> or default value of <strong>TExtension</strong></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.dmnextendableextensions.getextensions--1_net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable___7pp1ws" />  DmnExtendableExtensions.GetExtensions&lt;TExtension&gt;(IDmnExtendable) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExtendableExtensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.dmnextendableextensions__18z3obb)           
Sources: engine\definition\extensions\DmnExtendableExtensions.cs</small>


Get all extensions of type <strong>TExtension</strong> from <strong>element</strong>



```csharp
public static DmnExtendableExtensions.TExtension[] GetExtensions<TExtension>(this IDmnExtendable element)
```

<strong>Type parameters</strong><dl><dt><strong>TExtension</strong></dt><dd>Type of the extension</dd></dl>
<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.extensions.IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o) <strong>element</strong></dt><dd>DMN element</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.dmn.engine.engine.definition.extensions.DmnExtendableExtensions.TExtension[]</dt><dd>All extensions of type <strong>TExtension</strong> from <strong>element</strong> or empty array when no such extension is found</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.definition.extensions.dmnextendableextensions.hasextension--1_net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable___1f14ct5" />  DmnExtendableExtensions.HasExtension&lt;TExtension&gt;(IDmnExtendable) Method ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExtendableExtensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.dmnextendableextensions__18z3obb)           
Sources: engine\definition\extensions\DmnExtendableExtensions.cs</small>


Check whether <strong>element</strong> has the extension of type <strong>TExtension</strong>



```csharp
public static bool HasExtension<TExtension>(this IDmnExtendable element)
```

<strong>Type parameters</strong><dl><dt><strong>TExtension</strong></dt><dd>Type of the extension</dd></dl>
<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.dmn.engine.engine.definition.extensions.IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o) <strong>element</strong></dt><dd>DMN element</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True when <strong>element</strong> has the extension of type <strong>TExtension</strong> otherwise false</dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o" />  IDmnExtendable Interface ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\definition\extensions\IDmnExtendable.cs</small>


DMN definition classes that can have extensions



```csharp
public interface IDmnExtendable
```

Implemented by: [net.adamec.lib.common.dmn.engine.engine.decisions.DmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.dmndecision__1dk0ggj), [net.adamec.lib.common.dmn.engine.engine.decisions.IDmnDecision](net.adamec.lib.common.dmn.engine.engine.decisions__15bua3q.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.idmndecision__13vf8a6), [net.adamec.lib.common.dmn.engine.engine.decisions.expression.DmnExpressionDecision](net.adamec.lib.common.dmn.engine.engine.decisions.expression__16b1yci.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.expression.dmnexpressiondecision__wqzfc9), [net.adamec.lib.common.dmn.engine.engine.decisions.table.DmnDecisionTable](net.adamec.lib.common.dmn.engine.engine.decisions.table__1gb724k.md#t-net.adamec.lib.common.dmn.engine.engine.decisions.table.dmndecisiontable__186v1kh), [net.adamec.lib.common.dmn.engine.engine.definition.DmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmndefinition__1clvtf4), [net.adamec.lib.common.dmn.engine.engine.definition.DmnVariableDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.dmnvariabledefinition__1spm88), [net.adamec.lib.common.dmn.engine.engine.definition.IDmnDefinition](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmndefinition__81b50x), [net.adamec.lib.common.dmn.engine.engine.definition.IDmnElement](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnelement__1odpnhw), [net.adamec.lib.common.dmn.engine.engine.definition.IDmnVariable](net.adamec.lib.common.dmn.engine.engine.definition__199kcn6.md#t-net.adamec.lib.common.dmn.engine.engine.definition.idmnvariable__xmkw7w)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Extensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable.extensions__1fyoyrc) | public abstract | List of extensions that can be used to any related data. Engine doesn&#39;t neither manage nor touches the extensions | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="p-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable.extensions__1fyoyrc" />  IDmnExtendable.Extensions Property ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.definition.extensions](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#n-net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [IDmnExtendable](net.adamec.lib.common.dmn.engine.engine.definition.extensions__16t6ocu.md#t-net.adamec.lib.common.dmn.engine.engine.definition.extensions.idmnextendable__1x6o04o)           
Sources: engine\definition\extensions\IDmnExtendable.cs</small>


List of extensions that can be used to any related data. Engine doesn&#39;t neither manage nor touches the extensions



```csharp
public abstract List<object> Extensions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;object&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 




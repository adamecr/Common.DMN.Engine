#  DMN Engine Documentation #
##  <a id="n-net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp" />  net.adamec.lib.common.dmn.engine.engine.execution Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#t-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception__kkv81y) | public | Exception thrown while executing (evaluating) the DMN Model | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="t-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception__kkv81y" />  DmnExecutorException Class ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#n-net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp)           
Assembly: net.adamec.lib.common.dmn.engine           
Sources: engine\execution\DmnExecutorException.cs</small>


Exception thrown while executing (evaluating) the DMN Model



```csharp
public class DmnExecutorException : Exception
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable" target="_blank" >System.Runtime.Serialization.ISerializable</a>


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DmnExecutorException(string, Exception)](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#m-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception.-ctor_system.string-system.exception___265x3) | public | Creates [DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#t-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception__kkv81y) with given <strong>message</strong> and optional <strong>innerException</strong> | 

 


Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 


##  <a id="m-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception.-ctor_system.string-system.exception___265x3" />  DmnExecutorException.DmnExecutorException(string, Exception) Constructor ##
<small>Namespace: [net.adamec.lib.common.dmn.engine.engine.execution](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#n-net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp)           
Assembly: net.adamec.lib.common.dmn.engine           
Type: [DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#t-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception__kkv81y)           
Sources: engine\execution\DmnExecutorException.cs</small>


Creates [DmnExecutorException](net.adamec.lib.common.dmn.engine.engine.execution__b8ylzp.md#t-net.adamec.lib.common.dmn.engine.engine.execution.dmnexecutorexception__kkv81y) with given <strong>message</strong> and optional <strong>innerException</strong>



```csharp
public DmnExecutorException(string message, Exception innerException = null)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Error message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Optional inner exception</dd></dl>
Go to [namespaces](net.adamec.lib.common.dmn.engine.md#namespace-list) or [types](net.adamec.lib.common.dmn.engine.md#type-list)


 




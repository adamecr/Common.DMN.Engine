using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace net.adamec.lib.common.dmn.engine.test
{
    public class TestTools
    {
        public static object InvokeNonPublicStaticMethod<TType>(string methodName, params object[] parameters)
        {
            var factoryType = typeof(TType);
            try
            {
                return factoryType
                    .GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.Static)
                    .Invoke(null, parameters);
            }
            catch (TargetInvocationException ex)
            {
                if (ex.InnerException != null)
                    throw ex.InnerException;
                else
                    throw ex;
            }
        }

        public static object InvokeNonPublicMethod(object instance, string methodName, params object[] parameters)
        {
            var factoryType = instance.GetType();
            try
            {
                return factoryType
                    .GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.Instance)
                    .Invoke(instance, parameters);
            }
            catch (TargetInvocationException ex)
            {
                if (ex.InnerException != null)
                    throw ex.InnerException;
                else
                    throw ex;
            }
        }

        public static object InvokeNonPublicCtor<TType>(params object[] parameters)
        {
            var factoryType = typeof(TType);
            var parameterTypes = (parameters ?? Array.Empty<object>()).Select(p => p?.GetType() ?? typeof(object)).ToArray();
            try
            {
                return factoryType
                    .GetConstructor(BindingFlags.NonPublic| BindingFlags.CreateInstance | BindingFlags.Instance, null,parameterTypes,null)
                    .Invoke(parameters);
            }
            catch (TargetInvocationException ex)
            {
                if (ex.InnerException != null)
                    throw ex.InnerException;
                else
                    throw ex;
            }
        }
    }

    public static class TestExtensions
    {
        public static MethodInfo GetMethod(this Type type, string methodName, Type[] argTypes, bool isGeneric)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            // ReSharper disable once ConvertToNullCoalescingCompoundAssignment
            argTypes =argTypes?? new Type[] { };

            var methods = type
                .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Where(m => m.Name == methodName && m.IsGenericMethod == isGeneric);
            
            var methodsOut = new List<MethodInfo>();
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var method in methods)
            {
                var methodParams = method.GetParameters();

                if (methodParams.Length != argTypes.Length) continue; // params cnt mismatch
                if (methodParams.Where((t, idx) => t.ParameterType != argTypes[idx]).Any()) continue; // params mismatch

                methodsOut.Add(method);
            }

            switch (methodsOut.Count)
            {
                case 1: return methodsOut[0];
                case 0: throw new MissingMethodException($"{(isGeneric?"Generic":"Non-Generic")} method {methodName} with given params not found");
                default:throw new AmbiguousMatchException($"{(isGeneric ? "Generic" : "Non-Generic")} method {methodName} with given params has {methodsOut.Count} matches");
            }
        }
    }
}

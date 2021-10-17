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
                    .GetMethod(methodName, BindingFlags.NonPublic|BindingFlags.InvokeMethod | BindingFlags.Static)
                    .Invoke(null, parameters);
            }
            catch (TargetInvocationException ex)
            {
                throw ex.InnerException;
            }
        }

        public static object InvokeNonPublicMethod(object instance,string methodName, params object[] parameters)
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
                throw ex.InnerException;
            }
        }
    }
}

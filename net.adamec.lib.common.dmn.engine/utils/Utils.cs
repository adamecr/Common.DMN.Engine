using System;

namespace net.adamec.lib.common.dmn.engine.utils
{
    /// <summary>
    /// Common utils
    /// </summary>
    public class Utils
    {
        /// <summary>
        /// Get default value of given type.  It's the equivalent of C# keyword default(type)
        /// </summary>
        /// <param name="type">Type to get the default value for</param>
        /// <returns>Null for non value types and default value for value types.</returns>
        public static object GetDefault(Type type)
        {
            return type == null || !type.IsValueType ? null : Activator.CreateInstance(type);
        }
    }
}

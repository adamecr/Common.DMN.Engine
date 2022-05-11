namespace net.adamec.lib.common.dmn.engine.utils
{
    /// <summary>
    /// DMN engine related utilities
    /// </summary>
    public class DmnUtils
    {
        /// <summary>
        /// Name with label string in case <paramref name="label"/> is different than <paramref name="name"/>,
        /// otherwise <paramref name="name"/> only is returned
        /// </summary>
        public static string NameWithLabel(string name,string label)
        {
            return label != name ? $"{name} ({label})" : name;
        }
    }
}

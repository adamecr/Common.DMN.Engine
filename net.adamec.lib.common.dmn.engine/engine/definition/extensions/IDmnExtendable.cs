using System.Collections.Generic;

namespace net.adamec.lib.common.dmn.engine.engine.definition.extensions
{
    /// <summary>
    /// DMN definition classes that can have extensions
    /// </summary>
    public interface IDmnExtendable
    {
        /// <summary>
        /// List of extensions that can be used to any related data.
        /// Engine doesn't neither manage nor touches the extensions
        /// </summary>
        List<object> Extensions { get; }
    }
}

using net.adamec.lib.common.dmn.engine.engine.definition.extensions;

namespace net.adamec.lib.common.dmn.engine.engine.definition
{
    /// <summary>
    /// Common properties for Decisions and Variables (also representing Input parameters)
    /// </summary>
    public interface IDmnElement: IDmnExtendable
    {
        /// <summary>
        /// Name of the element
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Label of the element
        /// </summary>
        string Label { get; }

        /// <summary>
        /// Name with label information in case <see cref="Label"/> is different than <see cref="Name"/>
        /// </summary>
        string NameWithLabel { get; }
    }
}

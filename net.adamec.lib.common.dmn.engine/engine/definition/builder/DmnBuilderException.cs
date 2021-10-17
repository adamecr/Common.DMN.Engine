using System;

namespace net.adamec.lib.common.dmn.engine.engine.definition.builder
{
    /// <inheritdoc />
    /// <summary>
    /// Exception thrown while building the DMN Definition
    /// </summary>
    public class DmnBuilderException : Exception
    {
        /// <inheritdoc />
        /// <summary>
        /// Creates <see cref="T:net.adamec.lib.common.dmn.engine.definition.builder.DmnBuilderException" /> with given <paramref name="message" /> and optional <paramref name="innerException" />
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="innerException">Optional inner exception</param>
        public DmnBuilderException(string message, Exception innerException=null) : base(message, innerException)
        {
        }
    }
}

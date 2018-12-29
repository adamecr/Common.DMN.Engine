using System;

namespace net.adamec.lib.common.dmn.engine.engine.runtime
{
    /// <summary>
    /// Exception thrown while executing (evaluating) the DMN Model
    /// </summary>
    public class DmnExecutorException : Exception
    {
        /// <summary>
        /// Creates <see cref="DmnExecutorException" /> with given <paramref name="message" /> and optional <paramref name="innerException" />
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="innerException">Optional inner exception</param>
        public DmnExecutorException(string message, Exception innerException = null) : base(message, innerException)
        {
        }
    }
}

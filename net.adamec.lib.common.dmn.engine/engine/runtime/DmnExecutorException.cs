using System;

namespace net.adamec.lib.common.dmn.engine.engine.runtime
{
    public class DmnExecutorException : Exception
    {
        public DmnExecutorException(string message, Exception innerException = null) : base(message, innerException)
        {
        }
    }
}

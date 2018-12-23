using System;
using System.Collections.Generic;
using NLog;

namespace net.adamec.lib.common.dmn.engine.utils
{
    /// <summary>
    /// Logging abstraction class
    /// Encapsulates NLog logging, so it can be simply changed when another logging framework is used
    /// </summary>
    public class Logging
    {
        private ILogger Logger { get; }

        private Logging(ILogger logger)
        {
            Logger = logger;
        }

        public static Logging CreateLogging(string name)
        {
            return new Logging(LogManager.GetLogger(name));
        }

        public static Logging CreateLogging(Type type)
        {
            return CreateLogging(type.FullName);
        }
        public static Logging CreateLogging<T>()
        {
            return CreateLogging(typeof(T));
        }


        public T Fatal<T>(string message, Exception innerException = null) where T : Exception
        {
            return Fatal<T>(null, message, innerException);
        }
        public T Fatal<T>(string correlationId, string message, Exception innerException = null) where T : Exception
        {
            var exception = (T)Activator.CreateInstance(typeof(T), message, innerException);
            LogIt(Logger, LogLevel.Fatal, correlationId, message, innerException);
            return exception;
        }

        public T Error<T>(string message, Exception innerException = null) where T : Exception
        {
            return Error<T>(null, message, innerException);
        }

        public T Error<T>(string correlationId, string message, Exception innerException = null) where T : Exception
        {
            var exception = (T)Activator.CreateInstance(typeof(T), message, innerException);
            LogIt(Logger, LogLevel.Error, correlationId, message, innerException);
            return exception;
        }

        public void Info(string message)
        {
            Info(null, message);
        }

        public void Info(string correlationId, string message)
        {
            LogIt(Logger, LogLevel.Info, correlationId, message);
        }

        public bool IsTraceEnabled=>Logger.IsTraceEnabled;

        public void Trace(string message)
        {
            Trace(null, message);
        }
        public void Trace(string correlationId, string message)
        {
            if (Logger.IsTraceEnabled) LogIt(Logger, LogLevel.Trace, correlationId, message);
        }

        private static void LogIt(ILogger logger, LogLevel level, string correlationId, string message, Exception exception = null)
        {
            LogIt(logger, level, new Dictionary<string, object>() { { "CorrelationId", correlationId } }, message, exception);
        }

        // ReSharper disable once SuggestBaseTypeForParameter
        private static void LogIt(ILogger logger, LogLevel level, Dictionary<string, object> eventProperties, string message, Exception exception = null)
        {
            var logEvent = new LogEventInfo(level, logger.Name, message) { Exception = exception };
            if (eventProperties != null)
            {
                foreach (var eventProperty in eventProperties)
                {
                    logEvent.Properties.Add(eventProperty.Key, eventProperty.Value);
                }
            }
            logger.Log(logEvent);
        }
    }
}

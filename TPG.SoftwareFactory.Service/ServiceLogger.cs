using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPG.SoftwareFactory.Contract;
using System.ServiceModel;

namespace TPG.SoftwareFactory.Service
{
    [Serializable]
    public class ServiceLogger : ILogger
    {
        LoggerServiceRef.LoggerClient serviceLogger;

        public ServiceLogger()
        {
        }

        public void Debug(string message)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.DebugMessage(message);
            }
        }

        public void Debug(object message)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.DebugMessage(message);
            }
        }

        public void Debug(object message, Exception exception)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.DebugMessageException(message, exception);
            }
        }

        public void DebugFormat(string format, object arg0)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.DebugFormatArg(format, arg0);
            }
        }

        public void DebugFormat(string format, params object[] args)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.DebugFormatArg(format, args);
            }
        }

        public void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.DebugProviderFormatParams(provider, format, args);
            }
        }

        public void DebugFormat(string format, object arg0, object arg1)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.DebugFormatTwoArgs(format, arg0, arg1);
            }
        }

        public void DebugFormat(string format, object arg0, object arg1, object arg2)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.DebugFormatThreeArgs(format, arg0, arg1, arg2);
            }
        }

        public void Error(object message)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.ErrorMessage(message);
            }
        }

        public void Error(object message, Exception exception)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.ErrorMessageException(message, exception);
            }
        }

        public void ErrorFormat(string format, object arg0)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.ErrorFormatArg(format, arg0);
            }
        }

        public void ErrorFormat(string format, params object[] args)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.ErrorFormatParams(format, args);
            }
        }

        public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.ErrorProviderFormatParams(provider, format, args);
            }
        }

        public void ErrorFormat(string format, object arg0, object arg1)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.ErrorFormatTwoArgs(format, arg0, arg1);
            }
        }

        public void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.ErrorFormatThreeArgs(format, arg0, arg1, arg2);
            }
        }

        public void Fatal(object message)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.FatalMessage(message);
            }
        }

        public void Fatal(object message, Exception exception)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.FatalMessageException(message, exception);
            }
        }

        public void FatalFormat(string format, object arg0)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.FatalFormatArg(format, arg0);
            }
        }

        public void FatalFormat(string format, params object[] args)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.FatalFormatParams(format, args);
            }
        }

        public void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.FatalProviderFormatParams(provider, format, args);
            }
        }

        public void FatalFormat(string format, object arg0, object arg1)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.FatalFormatTwoArgs(format, arg0, arg1);
            }
        }

        public void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.FatalFormatThreeArgs(format, arg0, arg1, arg2);
            }
        }

        public void Info(object message)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.InfoMessage(message);
            }
        }

        public void Info(object message, Exception exception)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.InfoMessageException(message, exception);
            }
        }

        public void InfoFormat(string format, object arg0)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.InfoFormatArg(format, arg0);
            }
        }

        public void InfoFormat(string format, params object[] args)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.InfoFormatParams(format, args);
            }
        }

        public void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.InfoProviderFormatParams(provider, format, args);
            }
        }

        public void InfoFormat(string format, object arg0, object arg1)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.InfoFormatTwoArgs(format, arg0, arg1);
            }
        }

        public void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.InfoFormatThreeArgs(format, arg0, arg1, arg2);
            }
        }

        public void Warn(object message)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.WarnMessage(message);
            }
        }

        public void Warn(object message, Exception exception)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.WarnMessageException(message, exception);
            }
        }

        public void WarnFormat(string format, object arg0)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.WarnFormatArg(format, arg0);
            }
        }

        public void WarnFormat(string format, params object[] args)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.WarnFormatParams(format, args);
            }
        }

        public void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.WarnProviderFormatParams(provider, format, args);
            }
        }

        public void WarnFormat(string format, object arg0, object arg1)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.WarnFormatTwoArgs(format, arg0, arg1);
            }
        }

        public void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.WarnFormatThreeArgs(format, arg0, arg1, arg2);
            }
        }



        public void TestMessage(ObjectContainer message)
        {
            using (serviceLogger = new LoggerServiceRef.LoggerClient())
            {
                serviceLogger.TestMessage(message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPG.SoftwareFactory.Contract;

namespace TPG.SoftwareFactory.Logger
{
    [Serializable]
    public class Logger : ILogger
    {
        public Contract.ILogger InjectedLogger;

        public Logger(ILogger logger)
        {
            this.InjectedLogger = logger;

        }
        

        public Logger()
        {
        }

        public void Debug(ObjectContainer message)
        {
            InjectedLogger.Debug(message);
        }

        public void Debug(object message, Exception exception)
        {
            InjectedLogger.Debug(message, exception);
        }

        public void DebugFormat(string format, object arg0)
        {
            InjectedLogger.DebugFormat(format, arg0);
        }

        public void DebugFormat(string format, params object[] args)
        {
            InjectedLogger.DebugFormat(format, args);
        }

        public void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            InjectedLogger.DebugFormat(provider, format, args);
        }

        public void DebugFormat(string format, object arg0, object arg1)
        {
            InjectedLogger.DebugFormat(format, arg0, arg1);
        }

        public void DebugFormat(string format, object arg0, object arg1, object arg2)
        {
            InjectedLogger.DebugFormat(format, arg0, arg1, arg2);
        }

        public void Error(object message)
        {
            InjectedLogger.Error(message);
        }

        public void Error(object message, Exception exception)
        {
            InjectedLogger.Error(message, exception);
        }

        public void ErrorFormat(string format, object arg0)
        {
            InjectedLogger.ErrorFormat(format, arg0);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            InjectedLogger.ErrorFormat(format, args);
        }

        public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            InjectedLogger.ErrorFormat(provider, format, args);
        }

        public void ErrorFormat(string format, object arg0, object arg1)
        {
            InjectedLogger.ErrorFormat(format, arg0, arg1);
        }

        public void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            InjectedLogger.ErrorFormat(format, arg0, arg1, arg2);
        }

        public void Fatal(object message)
        {
            InjectedLogger.Fatal(message);
        }

        public void Fatal(object message, Exception exception)
        {
            InjectedLogger.Fatal(message, exception);
        }

        public void FatalFormat(string format, object arg0)
        {
            InjectedLogger.FatalFormat(format, arg0);
        }

        public void FatalFormat(string format, params object[] args)
        {
            InjectedLogger.FatalFormat(format, args);
        }

        public void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            InjectedLogger.FatalFormat(provider, format, args);
        }

        public void FatalFormat(string format, object arg0, object arg1)
        {
            InjectedLogger.FatalFormat(format, arg0, arg1);
        }

        public void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            InjectedLogger.FatalFormat(format, arg0, arg1, arg2);
        }

        public void Info(object message)
        {
            InjectedLogger.Info(message);
        }

        public void Info(object message, Exception exception)
        {
            InjectedLogger.Info(message, exception);
        }

        public void InfoFormat(string format, object arg0)
        {
            InjectedLogger.InfoFormat(format, arg0);
        }

        public void InfoFormat(string format, params object[] args)
        {
            InjectedLogger.InfoFormat(format, args);
        }

        public void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            InjectedLogger.InfoFormat(provider, format, args);
        }

        public void InfoFormat(string format, object arg0, object arg1)
        {
            InjectedLogger.InfoFormat(format, arg0, arg1);
        }

        public void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            InjectedLogger.InfoFormat(format, arg0, arg1, arg2);
        }

        public void Warn(object message)
        {
            InjectedLogger.Warn(message);
        }

        public void Warn(object message, Exception exception)
        {
            InjectedLogger.Warn(message, exception);
        }

        public void WarnFormat(string format, object arg0)
        {
            InjectedLogger.WarnFormat(format, arg0);
        }

        public void WarnFormat(string format, params object[] args)
        {
            InjectedLogger.WarnFormat(format, args);
        }

        public void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            InjectedLogger.WarnFormat(provider, format, args);
        }

        public void WarnFormat(string format, object arg0, object arg1)
        {
            InjectedLogger.WarnFormat(format, arg0, arg1);
        }

        public void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            InjectedLogger.WarnFormat(format, arg0, arg1, arg2);
        }
        
        public string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string HostName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        
        public void TestMessage(ObjectContainer message)
        {
            throw new NotImplementedException();
        }

        public void Debug(object message)
        {
            throw new NotImplementedException();
        }
    }
}

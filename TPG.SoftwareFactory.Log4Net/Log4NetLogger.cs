using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPG.SoftwareFactory.Contract;
using log4net;
using log4net.Config;

namespace TPG.SoftwareFactory.Log4Net
{
    [Serializable]
    public class Log4NetLogger : ILogger
    {
        private ILog Logger = LogManager.GetLogger("Appender");
        
        public Log4NetLogger()
        {
            XmlConfigurator.Configure();
        }
        public void Debug(string message)
        {
            Logger.Debug(message);
        }
        public void Debug(object message)
        {
            Logger.Debug(message);
        }

        public void Debug(object message, Exception exception)
        {
            Logger.Debug(message, exception);
        }

        public void DebugFormat(string format, object arg0)
        {
            Logger.DebugFormat(format, arg0);
        }

        public void DebugFormat(string format, params object[] args)
        {
            Logger.DebugFormat(format, args);
        }

        public void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            Logger.DebugFormat(provider, format, args);
        }

        public void DebugFormat(string format, object arg0, object arg1)
        {
            Logger.DebugFormat(format, arg0, arg1);
        }

        public void DebugFormat(string format, object arg0, object arg1, object arg2)
        {
            Logger.DebugFormat(format, arg0, arg1, arg2);
        }

        public void Error(object message)
        {
            Logger.Error(message);
        }

        public void Error(object message, Exception exception)
        {
            Logger.Error(message, exception);
        }

        public void ErrorFormat(string format, object arg0)
        {
            Logger.ErrorFormat(format, arg0);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            Logger.ErrorFormat(format, args);
        }

        public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            Logger.ErrorFormat(provider, format, args);
        }

        public void ErrorFormat(string format, object arg0, object arg1)
        {
            Logger.ErrorFormat(format, arg0, arg1);
        }

        public void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            Logger.ErrorFormat(format, arg0, arg1, arg2);
        }

        public void Fatal(object message)
        {
            Logger.Fatal(message);
        }

        public void Fatal(object message, Exception exception)
        {
            Logger.Fatal(message, exception);
        }

        public void FatalFormat(string format, object arg0)
        {
            Logger.FatalFormat(format, arg0);
        }

        public void FatalFormat(string format, params object[] args)
        {
            Logger.FatalFormat(format, args);
        }

        public void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            Logger.FatalFormat(provider, format, args);
        }

        public void FatalFormat(string format, object arg0, object arg1)
        {
            Logger.FatalFormat(format, arg0, arg1);
        }

        public void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            Logger.FatalFormat(format, arg0, arg1, arg2);
        }

        public void Info(object message)
        {
            Logger.Info(message);
        }

        public void Info(object message, Exception exception)
        {
            Logger.Info(message, exception);
        }

        public void InfoFormat(string format, object arg0)
        {
            Logger.InfoFormat(format, arg0);
        }

        public void InfoFormat(string format, params object[] args)
        {
            Logger.InfoFormat(format, args);
        }

        public void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            Logger.InfoFormat(provider, format, args);
        }

        public void InfoFormat(string format, object arg0, object arg1)
        {
            Logger.InfoFormat(format, arg0, arg1);
        }

        public void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            Logger.InfoFormat(format, arg0, arg1, arg2);
        }

        public void Warn(object message)
        {
            Logger.Warn(message);
        }

        public void Warn(object message, Exception exception)
        {
            Logger.Warn(message, exception);
        }

        public void WarnFormat(string format, object arg0)
        {
            Logger.WarnFormat(format, arg0);
        }

        public void WarnFormat(string format, params object[] args)
        {
            Logger.WarnFormat(format, args);
        }

        public void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            Logger.WarnFormat(provider, format, args);
        }

        public void WarnFormat(string format, object arg0, object arg1)
        {
            Logger.WarnFormat(format, arg0, arg1);
        }

        public void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            Logger.WarnFormat(format, arg0, arg1, arg2);
        }


        public void TestMessage(ObjectContainer message)
        {
            throw new NotImplementedException();
        }
    }
}

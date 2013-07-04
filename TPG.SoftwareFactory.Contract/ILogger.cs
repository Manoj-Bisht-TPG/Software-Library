using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace TPG.SoftwareFactory.Contract
{
    [ServiceContract]
    [ServiceKnownType(typeof(ObjectContainer))]
    public interface ILogger 
    {
        [OperationContract(Name = "TestMessage")]
        void TestMessage(ObjectContainer message);
        [OperationContract(Name = "DebugMessage")]
        void Debug(object message);
        [OperationContract(Name = "DebugMessageException")]
        void Debug(object message, Exception exception);
        [OperationContract(Name = "DebugFormatArg")]
        void DebugFormat(string format, object arg0);
        [OperationContract(Name = "DebugFormatParams")]
        void DebugFormat(string format, params object[] args);
        [OperationContract(Name = "DebugProviderFormatParams")]
        void DebugFormat(IFormatProvider provider, string format, params object[] args);
        [OperationContract(Name = "DebugFormatTwoArgs")]
        void DebugFormat(string format, object arg0, object arg1);
        [OperationContract(Name = "DebugFormatThreeArgs")]
        void DebugFormat(string format, object arg0, object arg1, object arg2);

        [OperationContract(Name = "ErrorMessage")]
        void Error(object message);
        [OperationContract(Name = "ErrorMessageException")]
        void Error(object message, Exception exception);
        [OperationContract(Name = "ErrorFormatArg")]
        void ErrorFormat(string format, object arg0);
        [OperationContract(Name = "ErrorFormatParams")]
        void ErrorFormat(string format, params object[] args);
        [OperationContract(Name = "ErrorProviderFormatParams")]
        void ErrorFormat(IFormatProvider provider, string format, params object[] args);
        [OperationContract(Name = "ErrorFormatTwoArgs")]
        void ErrorFormat(string format, object arg0, object arg1);
        [OperationContract(Name = "ErrorFormatThreeArgs")]
        void ErrorFormat(string format, object arg0, object arg1, object arg2);

        [OperationContract(Name = "FatalMessage")]
        void Fatal(object message);
        [OperationContract(Name = "FatalMessageException")]
        void Fatal(object message, Exception exception);
        [OperationContract(Name = "FatalFormatArg")]
        void FatalFormat(string format, object arg0);
        [OperationContract(Name = "FatalFormatParams")]
        void FatalFormat(string format, params object[] args);
        [OperationContract(Name = "FatalProviderFormatParams")]
        void FatalFormat(IFormatProvider provider, string format, params object[] args);
        [OperationContract(Name = "FatalFormatTwoArgs")]
        void FatalFormat(string format, object arg0, object arg1);
        [OperationContract(Name = "FatalFormatThreeArgs")]
        void FatalFormat(string format, object arg0, object arg1, object arg2);

        [OperationContract(Name = "InfoMessage")]
        void Info(object message);
        [OperationContract(Name = "InfoMessageException")]
        void Info(object message, Exception exception);
        [OperationContract(Name = "InfoFormatArg")]
        void InfoFormat(string format, object arg0);
        [OperationContract(Name = "InfoFormatParams")]
        void InfoFormat(string format, params object[] args);
        [OperationContract(Name = "InfoProviderFormatParams")]
        void InfoFormat(IFormatProvider provider, string format, params object[] args);
        [OperationContract(Name = "InfoFormatTwoArgs")]
        void InfoFormat(string format, object arg0, object arg1);
        [OperationContract(Name = "InfoFormatThreeArgs")]
        void InfoFormat(string format, object arg0, object arg1, object arg2);

        [OperationContract(Name = "WarnMessage")]
        void Warn(object message);
        [OperationContract(Name = "WarnMessageException")]
        void Warn(object message, Exception exception);
        [OperationContract(Name = "WarnFormatArg")]
        void WarnFormat(string format, object arg0);
        [OperationContract(Name = "WarnFormatParams")]
        void WarnFormat(string format, params object[] args);
        [OperationContract(Name = "WarnProviderFormatParams")]
        void WarnFormat(IFormatProvider provider, string format, params object[] args);
        [OperationContract(Name = "WarnFormatTwoArgs")]
        void WarnFormat(string format, object arg0, object arg1);
        [OperationContract(Name = "WarnFormatThreeArgs")]
        void WarnFormat(string format, object arg0, object arg1, object arg2);
    }

    [DataContract]
    public class ObjectContainer
    {
        public ObjectContainer(object o)
        {
            this.o = o;
        }
        
        [DataMember]
        public object o;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPG.SoftwareFactory.Model.Queue;
using System.ServiceModel;

namespace TPG.SoftwareFactory.Contract
{
    [ServiceContract]
    public interface IQueueEngine
    {
        [OperationContract]
        QCommandResponse Operation(Boolean IsAsyn,  QType type, QCommandResponse response, params object[] arguments);

        [OperationContract]
        Object Get(Type ObjectType, string guid);

        [OperationContract]
        Guid Put(QItem p);
    }
}

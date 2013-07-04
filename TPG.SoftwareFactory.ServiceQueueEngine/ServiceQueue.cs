using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPG.SoftwareFactory.Contract;

namespace TPG.SoftwareFactory.ServiceQueueEngine
{
    public class ServiceQueue : IQueueEngine
    {
        public Model.Queue.QCommandResponse Operation(bool IsAsyn,Model.Queue.QType type, Model.Queue.QCommandResponse response, params object[] arguments)
        {
            throw new NotImplementedException();
        }

        public object Get(Type ObjectType, string guid)
        {
            throw new NotImplementedException();
        }

        public Guid Put(Model.Queue.QItem p)
        {
            throw new NotImplementedException();
        }
    }
}

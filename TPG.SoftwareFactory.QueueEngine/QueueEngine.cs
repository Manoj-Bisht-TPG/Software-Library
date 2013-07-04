using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPG.SoftwareFactory.Contract;

namespace TPG.SoftwareFactory.QueueEngine
{
    public class QueueEngine : IQueueEngine
    {
        public Contract.IQueueEngine injectedQueueEngine;

        public QueueEngine(Contract.IQueueEngine queueEngine)
        {
            this.injectedQueueEngine = queueEngine;

        }

        public QueueEngine()
        {
        }


        public Model.Queue.QCommandResponse Operation(bool IsAsyn, Model.Queue.QType type, Model.Queue.QCommandResponse response, params object[] arguments)
        {
            return injectedQueueEngine.Operation(IsAsyn,  type, response, arguments);
        }

        public object Get(Type ObjectType, string guid)
        {
            return injectedQueueEngine.Get(ObjectType, guid);
        }

        public Guid Put(Model.Queue.QItem p)
        {
            return injectedQueueEngine.Put(p);
        }
    }
}

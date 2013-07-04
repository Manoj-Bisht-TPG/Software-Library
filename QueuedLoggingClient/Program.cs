using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPG.SoftwareFactory.ComponentFactory;
using TPG.SoftwareFactory.Contract;
using System.Reflection;
using TPG.SoftwareFactory.Model.Queue;
using TPG.SoftwareFactory.QueueProcessor;

namespace QueuedLoggingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerFactory factory = new LoggerFactory();
            ILogger logger = factory.GetLogger("LoggerContainer");

            string applicationName = Assembly.GetExecutingAssembly().GetName().FullName;
            string logMessage = string.Format("Application name: {0} , Message: {1}", applicationName, " The sample to log from client with Queue ");

            for (int i = 0; i < 100; i++)
            {
                QType type = new QType(logger);
                type.MethodName = "Info";

                QCommandResponse queueResponse = new QCommandResponse();
                QueueEngineFactory qEngineFactory = new QueueEngineFactory();

                IQueueEngine qEngine = qEngineFactory.GetQueueEngine();
                queueResponse = qEngine.Operation(true, type, queueResponse, logMessage + i);
            }

            Console.WriteLine("Press any key to exit");
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using TPG.SoftwareFactory.ComponentFactory;
using TPG.SoftwareFactory.Contract;

namespace TPG.SoftwareFactory.QueueProcessorHost
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //#if(!DEBUG)
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
			{ 
				new QueueProcessorHost() 
			};
            ServiceBase.Run(ServicesToRun);
            //#else
            // Perform main service function here...
            //            LoggerFactory factory = new LoggerFactory();
            //            ILogger logger = factory.GetLogger("BGServiceLoggerContainer");

            //            try
            //            {
            //                QueueProcessor.QueueProcessor processor = new QueueProcessor.QueueProcessor(logger);
            //                processor.Process();
            //            }
            //            catch (Exception ex)
            //            {
            //                logger.Debug(ex, ex);
            //            }
            //#endif
        }
    }
}

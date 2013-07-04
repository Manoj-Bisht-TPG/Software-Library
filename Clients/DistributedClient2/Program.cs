using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPG.SoftwareFactory.ComponentFactory;
using TPG.SoftwareFactory.Contract;
using System.Reflection;

namespace DistributedClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerFactory factory = new LoggerFactory();
            ILogger logger = factory.GetLogger("LoggerContainer");

            string applicationName = Assembly.GetExecutingAssembly().GetName().FullName;

            string logMessage = string.Format("Application name: {0} , Message: {1}", applicationName, " The sample to log from Distributed client");

            logger.Info(logMessage);

            try
            {
                int i = 0;
                int result = 10 / i;
            }
            catch (Exception ex)
            {
                logMessage = string.Format("Application name: {0} , Message: {1}", applicationName, ex.Message);
                logger.Debug(logMessage); 
                Console.WriteLine("Exception has been logged successfully.");
                
            }
            Console.WriteLine("Press any key to exit");
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPG.SoftwareFactory.ComponentFactory;
using TPG.SoftwareFactory.Contract;
//using TPG.SoftwareFactory.EnterpriseLibrary;
//using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
//using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerFactory factory = new LoggerFactory();
            ILogger logger = factory.GetLogger();
            Console.WriteLine("logger.Debug() Calling.... ");
            logger.Debug("Hello");
            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}

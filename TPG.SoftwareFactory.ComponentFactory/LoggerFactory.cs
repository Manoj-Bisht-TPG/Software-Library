using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using TPG.SoftwareFactory.Contract;
using TPG.SoftwareFactory.Logger;

namespace TPG.SoftwareFactory.ComponentFactory
{
    public class LoggerFactory
    {
        public ILogger GetLogger(string container)
        {
            Contract.ILogger logger;
            //Iniitate default logger
            IUnityContainer containerVal = new UnityContainer();
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            //section.Containers["LoggerContainer"].Configure(containerVal);
            section.Configure(containerVal, container);
            // get the injected logger 
            logger = containerVal.Resolve<Logger.Logger>();
            //return logger object
            return logger;
        }
    }
}

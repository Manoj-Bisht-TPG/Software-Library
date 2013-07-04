using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPG.SoftwareFactory.Contract;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

namespace TPG.SoftwareFactory.ComponentFactory
{
    public class QueueEngineFactory
    {
        public IQueueEngine GetQueueEngine()
        {
            Contract.IQueueEngine qEngine;
            //Iniitate default logger
            IUnityContainer containerVal = new UnityContainer();
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            //section.Containers["LoggerContainer"].Configure(containerVal);
            section.Configure(containerVal, "QueueContainer");
            // get the injected logger to fetch the toplist from prediggo
            qEngine = containerVal.Resolve<QueueEngine.QueueEngine>();
            //return logger object
            return qEngine;
        }
    }
}

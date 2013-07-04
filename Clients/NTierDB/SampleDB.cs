using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPG.SoftwareFactory.ComponentFactory;
using TPG.SoftwareFactory.Contract;
using System.Reflection;

namespace NTierDB
{
    public class SampleDB
    {
        public void LoggedDBFailureInfo(ILogger logger)
        {
            string applicationName = Assembly.GetExecutingAssembly().GetName().FullName;

            string logMessage = string.Format("Application name: {0} , Message: {1}", applicationName, " The sample to log from DB Layer ");

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
            }
        }
    }
}

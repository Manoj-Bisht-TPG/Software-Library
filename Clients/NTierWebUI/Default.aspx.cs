using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NTierDB;
using TPG.SoftwareFactory.ComponentFactory;
using TPG.SoftwareFactory.Contract;
using System.Reflection;

namespace NTierWebUI
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Label1.Text = "In Progress";

            LoggerFactory factory = new LoggerFactory();
            ILogger logger = factory.GetLogger("LoggerContainer");

            string applicationName = Assembly.GetExecutingAssembly().GetName().FullName;

            string logMessage = string.Format("Application name: {0} , Message: {1}", applicationName, " The sample to log from frontend Layer ");

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

            try
            {
                new SampleDB().LoggedDBFailureInfo(logger);
            }
            catch
            {
            }

            Label1.Text = "Exception has been logged successfully!!";
        }
    }
}

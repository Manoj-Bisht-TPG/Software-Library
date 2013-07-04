using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;
using TPG.SoftwareFactory.ComponentFactory;
using TPG.SoftwareFactory.Contract;
using System.Reflection;

namespace DistributedClient1
{
    public partial class SampleForm : Form
    {
        public SampleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoggerFactory factory = new LoggerFactory();
            ILogger logger = factory.GetLogger("LoggerContainer");

            string applicationName = Assembly.GetExecutingAssembly().GetName().FullName;

            string logMessage = string.Format("Application name: {0} , Message: {1}", applicationName, " The sample to log from Distributed client ");

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

            MessageBox.Show("Messages are logged ");
        }
    }
}

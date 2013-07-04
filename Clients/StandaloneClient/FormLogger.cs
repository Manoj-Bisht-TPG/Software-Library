using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TPG.SoftwareFactory.ComponentFactory;
using TPG.SoftwareFactory.Contract;
using System.Configuration;

namespace Client.StandAlone
{
    public partial class FormLogger : Form
    {
        public FormLogger()
        {
            InitializeComponent();
            txtLog.Focus();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            LoggerFactory factory = new LoggerFactory();
            ILogger logger = factory.GetLogger("LoggerContainer");
            logger.Info(txtLog.Text.Trim());
            lblMessage.Text = "Logged sucessfully";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstLogInfo.Items.Clear();
            string myFile = ConfigurationManager.AppSettings["filePath"].ToString();
            string[] lines = File.ReadAllLines(myFile);
            var lineCount = lines.Length;
            for (int i = 0; i < lines.Length; i++)
                lstLogInfo.Items.Add(lines[i]);
        }
    }
}

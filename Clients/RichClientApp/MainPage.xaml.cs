using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace RichClientApp
{
    public partial class MainPage : UserControl
    {
        LoggerServiceRef.LoggerClient serviceLogger;

        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string applicationName = "Silverlight Application";

            string logMessage = string.Format("Application name: {0} , Message: {1}", applicationName, " The sample to log from Rich client");

            serviceLogger = new LoggerServiceRef.LoggerClient();

            LoggerServiceRef.DebugMessageRequest request = new LoggerServiceRef.DebugMessageRequest();
            request.message = logMessage;
            serviceLogger.DebugMessageAsync(request);
            serviceLogger.CloseAsync();
        }
    }
}

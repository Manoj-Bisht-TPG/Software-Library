using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using TPG.SoftwareFactory.ComponentFactory;
using TPG.SoftwareFactory.Contract;

namespace TPG.SoftwareFactory.QueueProcessorHost
{
    public partial class QueueProcessorHost : ServiceBase
    {
        private bool stopping;
        private ManualResetEvent stoppedEvent;

        public QueueProcessorHost()
        {
            InitializeComponent();

            this.stopping = false;
            this.stoppedEvent = new ManualResetEvent(false);
        }

        protected override void OnStart(string[] args)
        {
            // Queue the main service function for execution in a worker thread.
            ThreadPool.QueueUserWorkItem(new WaitCallback(ServiceWorkerThread));
        }

        /// <summary>
        /// The method performs the main function of the service. It runs on 
        /// a thread pool worker thread.
        /// </summary>
        /// <param name="state"></param>
        private void ServiceWorkerThread(object state)
        {
            // Perform main service function here...
            LoggerFactory factory = new LoggerFactory();
            ILogger logger = factory.GetLogger("BGServiceLoggerContainer");
            
            // Periodically check if the service is stopping.
            while (!this.stopping)
            {
                try
                {
                    QueueProcessor.QueueProcessor processor = new QueueProcessor.QueueProcessor(logger);
                    processor.Process();
                }
                catch (Exception ex)
                {
                    logger.Debug(ex, ex);
                }
            }

            // Signal the stopped event.
            this.stoppedEvent.Set();
        }

        protected override void OnStop()
        {
            // Indicate that the service is stopping and wait for the finish 
            // of the main service function (ServiceWorkerThread).
            this.stopping = true;
            this.stoppedEvent.WaitOne();
        }
    }
}

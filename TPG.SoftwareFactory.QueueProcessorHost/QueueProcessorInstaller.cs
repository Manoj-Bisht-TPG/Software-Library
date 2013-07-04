using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;


namespace TPG.SoftwareFactory.QueueProcessorHost
{
    [RunInstaller(true)]
    public partial class QueueProcessorInstaller : System.Configuration.Install.Installer
    {
        public QueueProcessorInstaller()
        {
            InitializeComponent();
        }
    }
}

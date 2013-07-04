namespace TPG.SoftwareFactory.QueueProcessorHost
{
    partial class QueueProcessorInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.queueHostInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.queueHostServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // queueHostInstaller
            // 
            this.queueHostInstaller.Account = System.ServiceProcess.ServiceAccount.LocalService;
            this.queueHostInstaller.Password = null;
            this.queueHostInstaller.Username = null;
            // 
            // queueHostServiceInstaller
            // 
            this.queueHostServiceInstaller.DisplayName = "QueueProcessorHostService";
            this.queueHostServiceInstaller.ServiceName = "QueueProcessorHost";
            // 
            // QueueProcessorInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.queueHostInstaller,
            this.queueHostServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller queueHostInstaller;
        private System.ServiceProcess.ServiceInstaller queueHostServiceInstaller;
    }
}
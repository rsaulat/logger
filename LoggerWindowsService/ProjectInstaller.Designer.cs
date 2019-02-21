namespace LoggerWindowsService
{
    partial class ProjectInstaller
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
            this.BMCWindowsServiceInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.BMCWindowsService = new System.ServiceProcess.ServiceInstaller();
            // 
            // BMCWindowsServiceInstaller
            // 
            this.BMCWindowsServiceInstaller.Account = System.ServiceProcess.ServiceAccount.LocalService;
            this.BMCWindowsServiceInstaller.Password = null;
            this.BMCWindowsServiceInstaller.Username = null;
            // 
            // BMCWindowsService
            // 
            this.BMCWindowsService.ServiceName = "BMCLoggerService";
            this.BMCWindowsService.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.BMCWindowsServiceInstaller,
            this.BMCWindowsService});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller BMCWindowsServiceInstaller;
        private System.ServiceProcess.ServiceInstaller BMCWindowsService;
    }
}
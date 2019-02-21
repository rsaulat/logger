using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace BMC
{
    public partial class LoggerWindowsService : ServiceBase
    {
        FileLogger fl;
        
        public LoggerWindowsService()
        {
            InitializeComponent();            
        }

        protected override void OnStart(string[] args)
        {
            fl = new FileLogger();
            fl.StartLogging();

        }

        protected override void OnStop()
        {
            fl.StopLogging();
            fl = null;
        }
    }
}

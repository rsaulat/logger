using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Timers;

namespace BMC
{
    [Serializable(), ClassInterface(ClassInterfaceType.AutoDual), ComVisible(true)]
    public class FileLogger
    {
        private Timer aTimer;
        private readonly string directory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

        private void LogTimeToFile()
        {
            StreamWriter sw = File.AppendText(directory + @"\BMCTimelog.txt");
            sw.WriteLine("The Time now is: " + System.DateTime.Now.ToString());
            sw.Flush();
            sw.Close();            
        }

        public void StartLogging()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += ATimer_Elapsed;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void ATimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            LogTimeToFile();
        }

        public void StopLogging()
        {
            aTimer.Stop();
            aTimer = null;
        }
    }
}

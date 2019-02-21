using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMC;
namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
            Console.ReadLine();
        }

        FileLogger fl;
        private System.Timers.Timer aTimer;

        private void Start()
        {
            fl = new FileLogger();
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += ATimer_Elapsed;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void ATimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("inside ATimer");
            fl.LogTimeToFile();
            Console.WriteLine("After logfile");
        }
    }
}

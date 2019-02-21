using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMC
{
    public partial class Form1 : Form
    {
        FileLogger fl;

        public Form1()
        {
            InitializeComponent();
            fl = new FileLogger();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fl.StartLogging();
            label1.Text = "Logging is running..";
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fl.StopLogging();
            button1.Enabled = true;
            button2.Enabled = false;
            label1.Text = "Logging is not running..";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;


namespace General_Desktop_Timer
{
     //enable the demand security so that only full trust applications have class access
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name = "FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name = "FullTrust")]

    public partial class Form1 : Form
    {
        //using class level variables so we can write them at any time when the application is closed
        Timer statusChecktime;
        string statusName;
        Stopwatch actualTimer = new Stopwatch();
        List<agentTime> TimerData = new List<agentTime>();
        int counter;
        bool stopwatchCheck;
        string agentName = Environment.UserName;
        string dskPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        bool pausedFlag;
        public int labelTime;



        public Form1()
        {
            InitializeComponent();

            //this creates the timer that we use to check the amount of time a user is in the MISC status
            CreatingTimer();

            //binding the form closing and double click events so we can trigger off the action
            FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);

            notifyIcon1.ContextMenu = this.contextMenu1;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
             //load the icon on the start so we can hit it with balloon tips throughout
            notifyIcon1.Visible = true;
        }



        //resize event handler (minimize event)
        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                //throw the icon to the system tray and trigger the balloon to let the user know the application is still running and accessible
               
                notifyIcon1.ShowBalloonTip(500,"Important","The timer application is now running in the system tray. Double click the icon to return.",ToolTipIcon.Info);
                this.Hide();
            }

            //******************************From Ashy to Classy...This shouldn't be needed, but let's keep it just in case I screw something up**************************************
            //else if (FormWindowState.Normal == this.WindowState)
            //{
            //    notifyIcon1.Visible = false;
            //}
            //***********************************************************************************************************************************************************************
        }



        //event handler for the closing event -- the output dump is here so the timer can be used all day and captures even on an accidetnal close
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            //if the file exists we don't need to write the headers so we can skip the additional line write and just append the data created
            if (File.Exists(dskPath + "\\" + agentName + ".csv"))
            {
                using (var file = new StreamWriter(dskPath+"\\"  + agentName + ".csv", true, Encoding.UTF8))
                {

                    foreach (var data in TimerData)
                    {
                        file.WriteLine(string.Join(",", data.agentID, data.agentStatus, data.statusTime, data.startTime, data.currentDate));
                    }
                    file.Close();
                    notifyIcon1.Icon = null;
                    MessageBox.Show("The file for " + agentName + " has been written to your desktop.", "Application Closed");
                }
            }
            //if the file hasn't been created before we can drop the headers in for the columns
            else
            {
                using (var file = new StreamWriter(dskPath +"\\"+ agentName + ".csv", true, Encoding.UTF8))
                {
                    file.WriteLine(string.Join(",", "Agent ID", "Agent Status", "Status Time", "Start Time", "Current Date"));
                    foreach (var data in TimerData)
                    {
                        file.WriteLine(string.Join(",", data.agentID, data.agentStatus, data.statusTime, data.startTime, data.currentDate));
                    }
                    file.Close();
                    notifyIcon1.Icon = null;
                    MessageBox.Show("The file for " + agentName + " has been written to your desktop.","Application Closed");
                }
            }
        }








        //*****************************click and butten events below this line*********************************************************************


        //return the application from the double click of the application icon in the system tray
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }



        //start the main work timer
        private void button1_Click(object sender, EventArgs e)
        {
            stopwatchCheck = actualTimer.IsRunning;

            if (pausedFlag == true)
            {
                notifyIcon1.ShowBalloonTip(500, "Timer Paused", "Please Resume Your Current Session Before Changing Status", ToolTipIcon.Info);
                
            }

            else {
                //we need a check here to understand if the timer is actually running and if we need to write anything, or if we can just start the timer
                if (stopwatchCheck == true)
                {
                    actualTimer.Stop();
                    TimerData.Add(new agentTime() { agentStatus = statusName, agentID = agentName, statusTime = actualTimer.Elapsed.TotalSeconds, startTime = DateTime.Now, currentDate = DateTime.Today.ToString("d") });
                    actualTimer.Reset();
                    statusChecktime.Stop();
                    counter = 0;
                }

                statusChecktime.Start();
                actualTimer.Start();
                statusName = "Work Time";
                notifyIcon1.ShowBalloonTip(500, "Status Change", "You are now in Work Time status", ToolTipIcon.Info);

            } 
        }



        //start the pre-work timer
        private void button2_Click(object sender, EventArgs e)
        {
            stopwatchCheck = actualTimer.IsRunning;

            if (pausedFlag == true)
            {
                notifyIcon1.ShowBalloonTip(500, "Timer Paused", "Please Resume Your Current Session Before Changing Status", ToolTipIcon.Info);
                
            }

            else {

                //we need a check here to understand if the timer is actually running and if we need to write anything, or if we can just start the timer
                if (stopwatchCheck == true)
                {
                    actualTimer.Stop();
                    TimerData.Add(new agentTime() { agentStatus = statusName, agentID = agentName, statusTime = actualTimer.Elapsed.TotalSeconds, startTime = DateTime.Now, currentDate = DateTime.Today.ToString("d") });
                    actualTimer.Reset();
                    statusChecktime.Stop();
                    counter = 0;
                }

                statusChecktime.Start();
                actualTimer.Start();
                statusName = "Pre-Work";
                notifyIcon1.ShowBalloonTip(500, "Status Change", "You are now in Pre-Work status", ToolTipIcon.Info);
            }
        }


        //start the post-work timer
        private void button3_Click(object sender, EventArgs e)
        {
            stopwatchCheck = actualTimer.IsRunning;

            if (pausedFlag == true)
            {
                notifyIcon1.ShowBalloonTip(500, "Timer Paused", "Please Resume Your Current Session Before Changing Status", ToolTipIcon.Info);
               
            }

            else {

                //we need a check here to understand if the timer is actually running and if we need to write anything, or if we can just start the timer
                if (stopwatchCheck == true)
                {
                    actualTimer.Stop();
                    TimerData.Add(new agentTime() { agentStatus = statusName, agentID = agentName, statusTime = actualTimer.Elapsed.TotalSeconds, startTime = DateTime.Now, currentDate = DateTime.Today.ToString("d") });
                    actualTimer.Reset();
                    statusChecktime.Stop();
                    counter = 0;
                }

                statusChecktime.Start();
                actualTimer.Start();
                statusName = "Post-Work";
                notifyIcon1.ShowBalloonTip(500, "Status Change", "You are now in Post-Work status", ToolTipIcon.Info);

            }
        }



        //start the misc timer, requires a string be entered into the text field
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please Enter a Status Name");
                
            }
            else {

                string agentStatus = textBox1.Text.ToString();

                stopwatchCheck = actualTimer.IsRunning;

                if (pausedFlag == true)
                {
                    notifyIcon1.ShowBalloonTip(500, "Timer Paused", "Please Resume Your Current Session Before Changing Status", ToolTipIcon.Info);
                   
                }

                else {

                    //we need a check here to understand if the timer is actually running and if we need to write anything, or if we can just start the timer
                    if (stopwatchCheck == true)
                    {
                        actualTimer.Stop();
                        TimerData.Add(new agentTime() { agentStatus = statusName, agentID = agentName, statusTime = actualTimer.Elapsed.TotalSeconds, startTime = DateTime.Now, currentDate = DateTime.Today.ToString("d") });
                        actualTimer.Reset();
                        statusChecktime.Stop();
                        counter = 0;

                    }

                    statusChecktime.Start();
                    actualTimer.Start();
                    statusName = agentStatus;
                    notifyIcon1.ShowBalloonTip(500, "Status Change", "You are now in " + statusName + " status", ToolTipIcon.Info);

                }        
            }
        }


        //stop the timer regardless of which one is running
        private void button5_Click(object sender, EventArgs e)
        {
            if (pausedFlag == true)
            {
                pausedFlag = false;
            }

            actualTimer.Stop();
            statusChecktime.Stop();
            counter = 0;
            TimerData.Add(new agentTime() { agentStatus = statusName, agentID = agentName, statusTime = actualTimer.Elapsed.TotalSeconds, startTime = DateTime.Now, currentDate = DateTime.Today.ToString("d") });
            notifyIcon1.ShowBalloonTip(500, "Status Change", "Timer Stopped", ToolTipIcon.Info);
            actualTimer.Reset();
            label1.Text = "Timer Stopped";
        }


        //This timer does no writing or reset because we simply want to hold the timer, if the user clicks another button when paused we'll throw a secondary check to ensure they want to overwrite the pause
        private void button6_Click(object sender, EventArgs e)
        {
            stopwatchCheck = actualTimer.IsRunning;

            if (stopwatchCheck == true)
            {
                //if the clock isn't running than we can skip all this and do nothing but flag the user
                actualTimer.Stop();
                statusChecktime.Stop();
                pausedFlag = true;
                button6.BackColor = Color.Red;
            }

            else if(pausedFlag==true && stopwatchCheck==false)
            {
                //we shouldn't need the flag on the stopwatchCheck, but I'd rather be safe then sorry and we can patch if necesdsary
                actualTimer.Start();
                statusChecktime.Start();
                pausedFlag = false;
                button6.BackColor = Color.Green;
            }

            else
            {
                MessageBox.Show("The Timer is not running");
            }

        }

        //*******************************context menu items and actions******************************************************************************


        //start the main work timer
        private void menuItem1_Click(object Sender, EventArgs e)
        {
            stopwatchCheck = actualTimer.IsRunning;

            if (pausedFlag == true)
            {
                notifyIcon1.ShowBalloonTip(500, "Timer Paused", "Please Resume Your Current Session Before Changing Status", ToolTipIcon.Info);

            }

            else {

                //we need a check here to understand if the timer is actually running and if we need to write anything, or if we can just start the timer
                if (stopwatchCheck == true)
                {
                    actualTimer.Stop();
                    TimerData.Add(new agentTime() { agentStatus = statusName, agentID = agentName, statusTime = actualTimer.Elapsed.TotalSeconds, startTime = DateTime.Now, currentDate = DateTime.Today.ToString("d") });
                    actualTimer.Reset();
                    statusChecktime.Stop();
                    counter = 0;
                }

                actualTimer.Start();
                statusName = "Work Time";
                notifyIcon1.ShowBalloonTip(500, "Status Change", "You are now in Work Time status", ToolTipIcon.Info);
            }
        }


        //start the pre-work timer
        private void menuItem2_Click(object Sender, EventArgs e)
        {
            stopwatchCheck = actualTimer.IsRunning;

            if (pausedFlag == true)
            {
                notifyIcon1.ShowBalloonTip(500, "Timer Paused", "Please Resume Your Current Session Before Changing Status", ToolTipIcon.Info);

            }

            else {


                //we need a check here to understand if the timer is actually running and if we need to write anything, or if we can just start the timer
                if (stopwatchCheck == true)
                {
                    actualTimer.Stop();
                    TimerData.Add(new agentTime() { agentStatus = statusName, agentID = agentName, statusTime = actualTimer.Elapsed.TotalSeconds, startTime = DateTime.Now, currentDate = DateTime.Today.ToString("d") });
                    actualTimer.Reset();
                    statusChecktime.Stop();
                    counter = 0;
                }

                actualTimer.Start();
                statusChecktime.Start();
                statusName = "Pre-Work";
                notifyIcon1.ShowBalloonTip(500, "Status Change", "You are now in Pre-Work status", ToolTipIcon.Info);
            }
        }



        //start the post-work timer
        private void menuItem3_Click(object Sender, EventArgs e)
        {
            stopwatchCheck = actualTimer.IsRunning;

            if (pausedFlag == true)
            {
                notifyIcon1.ShowBalloonTip(500, "Timer Paused", "Please Resume Your Current Session Before Changing Status", ToolTipIcon.Info);

            }

            else {


                //we need a check here to understand if the timer is actually running and if we need to write anything, or if we can just start the timer
                if (stopwatchCheck == true)
                {
                    actualTimer.Stop();
                    TimerData.Add(new agentTime() { agentStatus = statusName, agentID = agentName, statusTime = actualTimer.Elapsed.TotalSeconds, startTime = DateTime.Now, currentDate = DateTime.Today.ToString("d") });
                    actualTimer.Reset();
                    statusChecktime.Stop();
                    counter = 0;
                }

                actualTimer.Start();
                statusChecktime.Start();
                statusName = "Post-Work";
                notifyIcon1.ShowBalloonTip(500, "Status Change", "You are now in Post-Work status", ToolTipIcon.Info);
            }
        }



        //stop the timer regardless of status
        private void menuItem4_Click(object Sender, EventArgs e)
        {
            actualTimer.Stop();
            statusChecktime.Stop();
  
            TimerData.Add(new agentTime() { agentStatus = statusName, agentID = agentName, statusTime = actualTimer.Elapsed.TotalSeconds, startTime = DateTime.Now, currentDate = DateTime.Today.ToString("d") });
            this.Close();

        }

        //Pause the timer in from the system tray via this call
        private void menuItem9_Click(object sender, EventArgs e)
        {
            stopwatchCheck = actualTimer.IsRunning;

            if (stopwatchCheck == true)
            {
                actualTimer.Stop();
                statusChecktime.Stop();
                pausedFlag = true;
                button6.BackColor = Color.Red;
            }

            else if (pausedFlag == true && stopwatchCheck == false)
            {
                actualTimer.Start();
                statusChecktime.Start();
                pausedFlag = false;
                button6.BackColor = Color.Green;
            }

            else
            {
                MessageBox.Show("The Timer is not running");
            }
        }

        //start the misc timer, the options here are truncated to pre-selected options since it's running from the system tray
        private void SubmenuItem_Click(object sender, EventArgs e)
        {
            var clickedMenuItem = sender as MenuItem;
            stopwatchCheck = actualTimer.IsRunning;


            if (pausedFlag == true)
            {
                notifyIcon1.ShowBalloonTip(500, "Timer Paused", "Please Resume Your Current Session Before Changing Status", ToolTipIcon.Info);

            }

            else {

                //we need a check here to understand if the timer is actually running and if we need to write anything, or if we can just start the timer
                if (stopwatchCheck == true)
                {
                    actualTimer.Stop();
                    TimerData.Add(new agentTime() { agentStatus = statusName, agentID = agentName, statusTime = actualTimer.Elapsed.TotalSeconds, startTime = DateTime.Now, currentDate = DateTime.Today.ToString("d") });
                    actualTimer.Reset();
                    statusChecktime.Stop();
                    counter = 0;
                }

                actualTimer.Start();
                statusChecktime.Start();
                statusName = clickedMenuItem.Text;
                notifyIcon1.ShowBalloonTip(500, "Status Change", "You are now in " + statusName + " status", ToolTipIcon.Info);
            }

        }








        //*************************************************************************setup function****************************************************

        //tick timer that checks to see how long the agent has been sitting in the misc timer status, reminds them after 5 mintues to ensure correct status is used
        private void statusTime_Tick(object sender, EventArgs e)
        {
            counter++;
            //The timespan will handle the push from the elapsed time in seconds to the label so we can update the user
            //This shouldn't require a background worker since it's a fairly small app and nothing is resource heavy

            var timespan = TimeSpan.FromSeconds(actualTimer.Elapsed.Seconds);

            //convert the time in seconds to the format requested by the user
            label1.Text=("Elapsed Time in " + statusName+" "+ timespan.ToString(@"mm\:ss"));

            //pull the thread into updating the UI
            Application.DoEvents();


            
        }

        //generates the timer object that will be used to track the time in status
        private void CreatingTimer()
        {
            statusChecktime = new Timer();
            statusChecktime.Tick += new EventHandler(statusTime_Tick);
            statusChecktime.Interval = 1000;
        }


    }





    //limit the access to this public class to fully trusted calls only
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name = "FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name = "FullTrust")]





    //this class handles the array information we'll use to stor the data for writing later on
    public class agentTime
    {
        public string agentStatus { get; set; }

        public string agentID { get; set; }

        public double statusTime { get; set; }

        public DateTime startTime { get; set; }

        public string currentDate { get; set; }

        public string hydraTask { get;  set;}
    }
}













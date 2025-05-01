using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CSCI492OnsiteMonitor
{
    public partial class MonitorPage : Form
    {
        private System.Timers.Timer _timer;
        //private System.Timers.Timer _messageTimer;
        public MonitorPage()
        {
            InitializeComponent();
            SetupTimer();
            //SetupMessageTimer();
        }
        private void SetupTimer()
        {
            _timer = new System.Timers.Timer(1000); // 1 seconds interval for checks
            _timer.Elapsed += UpdateGaugeValue;
            _timer.AutoReset = true;
            _timer.Start();
        }
        private void UpdateGaugeValue(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                // Setup for Testing Specifically with random data but can be changed in InputDataMaker
                radialGaugeFluidPressure.Value = InputDataMaker.ChangeData("Error", radialGaugeFluidPressure.Value);
                radialGaugePumpSpeed.Value = InputDataMaker.ChangeData("Test", radialGaugePumpSpeed.Value);
                radialGaugeHotTempIn.Value = InputDataMaker.ChangeData("Test", radialGaugeHotTempIn.Value);
                radialGaugeHotTempOut.Value = InputDataMaker.ChangeData("Test", radialGaugeHotTempOut.Value);
                radialGaugeColdTempIn.Value = InputDataMaker.ChangeData("Test", radialGaugeColdTempIn.Value);
                radialGaugeColdTempOut.Value = InputDataMaker.ChangeData("Test", radialGaugeColdTempOut.Value);
                radialGaugeFryerTempIn.Value = InputDataMaker.ChangeData("Test", radialGaugeFryerTempIn.Value);
                radialGaugeFryerTempOut.Value = InputDataMaker.ChangeData("Test", radialGaugeFryerTempOut.Value);
                UpdateMessage();
            }));
        }
        /*
        //Testing of Message Timer
        private void SetupMessageTimer()
        {
            _messageTimer = new System.Timers.Timer(1000); //60000
            _messageTimer.Elapsed += (s, e) => UpdateMessage();
            _messageTimer.Start();
        }
        */
        private void UpdateMessage()
        {
            Invoke(new Action(() =>
            {
                //Testing the update message
                checkGauges();
                // Setup for Testing Specifically with random data but can be changed in InputDataMaker
                // Get current text (if any)
                string[] lines = messageBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                // Update first line, preserve the rest
                string updatedText = "Current Time: " + DateTime.Now.ToString("G");
                if (lines.Length > 1)
                {
                    updatedText += Environment.NewLine + string.Join(Environment.NewLine, lines.Skip(1));
                    if (lines.Length > 21)
                    {
                        string longrun = "Current Time: " + DateTime.Now.ToString("G") + Environment.NewLine + string.Join(Environment.NewLine, lines.Skip(lines.Count() - 20));
                        messageBox.Text = longrun;
                    }
                    else
                    {
                        messageBox.Text = updatedText;
                    }
                }
            }));
        }
        private void checkGauges()
        {
            if (radialGaugeFluidPressure.Value < 80 &&
            radialGaugePumpSpeed.Value < 80 &&
            radialGaugeHotTempIn.Value < 80 &&
            radialGaugeHotTempOut.Value < 80 &&
            radialGaugeColdTempIn.Value < 80 &&
            radialGaugeColdTempOut.Value < 80 &&
            radialGaugeFryerTempIn.Value < 80 &&
            radialGaugeFryerTempOut.Value < 80)
            {
                systemHealthIndicator.Image = Properties.Resources.Good;
            }
            else
            {
                if (radialGaugeFluidPressure.Value >= 80)
                {
                    if (radialGaugeFluidPressure.Value >= 100)
                    {
                        messageBox.Text += Environment.NewLine + DateTime.Now.ToString("G") + ": Danger, Fluid Pressure Critical";
                        systemHealthIndicator.Image = Properties.Resources.Failure;
                    }
                    else
                    {
                        messageBox.Text += Environment.NewLine + DateTime.Now.ToString("G") + ": Warning, Fluid Pressure High";
                        systemHealthIndicator.Image = Properties.Resources.Warning;
                    }
                }
                if (radialGaugePumpSpeed.Value >= 80)
                {
                    if (radialGaugePumpSpeed.Value >= 100)
                    {
                        messageBox.Text += Environment.NewLine + DateTime.Now.ToString("G") + ": Danger, Pump Speed Critical";
                        systemHealthIndicator.Image = Properties.Resources.Failure;
                    }
                    else
                    {
                        messageBox.Text += Environment.NewLine + DateTime.Now.ToString("G") + ": Warning, Pump Speed High";
                        systemHealthIndicator.Image = Properties.Resources.Warning;
                    }
                }
                if (radialGaugeHotTempIn.Value >= 80)
                {
                    if (radialGaugeHotTempIn.Value >= 100)
                    {
                        messageBox.Text += Environment.NewLine + DateTime.Now.ToString("G") + ": Danger, Hot Temp In Critical";
                        systemHealthIndicator.Image = Properties.Resources.Failure;
                    }
                    else
                    {
                        messageBox.Text += Environment.NewLine + DateTime.Now.ToString("G") + ": Warning, Hot Temp In High";
                        systemHealthIndicator.Image = Properties.Resources.Warning;
                    }
                }
                if (radialGaugeHotTempOut.Value >= 80)
                {
                    if (radialGaugeHotTempOut.Value >= 100)
                    {
                        messageBox.Text += Environment.NewLine + DateTime.Now.ToString("G") + ": Danger, Hot Temp Out Critical";
                        systemHealthIndicator.Image = Properties.Resources.Failure;
                    }
                    else
                    {
                        messageBox.Text += Environment.NewLine + DateTime.Now.ToString("G") + ": Warning, Hot Temp Out High";
                        systemHealthIndicator.Image = Properties.Resources.Warning;
                    }
                } 
                if (radialGaugeColdTempIn.Value >= 80)
                {
                    if (radialGaugeColdTempIn.Value >= 100)
                    {
                        messageBox.Text += Environment.NewLine + DateTime.Now.ToString("G") + ": Danger, Cold Temp In Critical";
                        systemHealthIndicator.Image = Properties.Resources.Failure;
                    }
                    else
                    {
                        messageBox.Text += Environment.NewLine + DateTime.Now.ToString("G") + ": Warning, Cold Temp In High";
                        systemHealthIndicator.Image = Properties.Resources.Warning;
                    }
                }
                if (radialGaugeColdTempOut.Value >= 80)
                {
                    if (radialGaugeColdTempOut.Value >= 100)
                    {
                        messageBox.Text += Environment.NewLine + DateTime.Now.ToString("G") + ": Danger, Cold Temp Out Critical";
                        systemHealthIndicator.Image = Properties.Resources.Failure;
                    }
                    else
                    {
                        messageBox.Text += Environment.NewLine + DateTime.Now.ToString("G") + ": Warning, Cold Temp Out High";
                        systemHealthIndicator.Image = Properties.Resources.Warning;
                    }
                }
                if (radialGaugeFryerTempIn.Value >= 80)
                {
                    if (radialGaugeFryerTempIn.Value >= 100)
                    {
                        messageBox.Text += Environment.NewLine + DateTime.Now.ToString("G") + ": Danger, Fryer Temp In Critical";
                        systemHealthIndicator.Image = Properties.Resources.Failure;
                    }
                    else
                    {
                        messageBox.Text += Environment.NewLine + DateTime.Now.ToString("G") + ": Warning, Fryer Temp Out High";
                        systemHealthIndicator.Image = Properties.Resources.Warning;
                    }
                }
                if (radialGaugeFryerTempOut.Value >= 80)
                {
                    if (radialGaugeFryerTempOut.Value >= 100)
                    {
                        messageBox.Text += Environment.NewLine + DateTime.Now.ToString("G") + ": Danger, Fryer Temp Out Critical";
                        systemHealthIndicator.Image = Properties.Resources.Failure;
                    }
                    else
                    {
                        messageBox.Text += Environment.NewLine + DateTime.Now.ToString("G") + ": Warning, Fryer Temp In  High";
                        systemHealthIndicator.Image = Properties.Resources.Warning;
                    }
                }
            }
        }

        //For manual Testing of Email Alerts
        private void TestButton_Click(object sender, EventArgs e)
        {
            SendEmailAlert.alertEmail();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TempetureGauge_Click(object sender, EventArgs e)
        {

        }

        private void systemInformation_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, systemInformation.ClientRectangle,
               Color.White, 0, ButtonBorderStyle.Solid, // left
               Color.White, 0, ButtonBorderStyle.Solid, // top
               Color.White, 0, ButtonBorderStyle.Solid, // right
               Color.White, 2, ButtonBorderStyle.Solid);// bottom
        }

        private void monitorLogo_Click(object sender, EventArgs e)
        {

        }

        private void systemName_Click(object sender, EventArgs e)
        {

        }

        private void connectionStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void connectionStatus_Paint(object sender, EventArgs e)
        {

        }

        private void radialGauge3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radialGauge3_Click_1(object sender, EventArgs e)
        {

        }

        private void radialGauge2_Click(object sender, EventArgs e)
        {

        }

        private void radialGauge1_Click(object sender, EventArgs e)
        {

        }

        private void radialGauge5_Click(object sender, EventArgs e)
        {

        }

        private void pumpSpeedGaugeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

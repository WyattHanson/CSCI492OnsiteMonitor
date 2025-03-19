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

namespace CSCI492OnsiteMonitor
{
    public partial class MonitorPage : Form
    {
        private System.Timers.Timer _timer;
        public MonitorPage()
        {
            InitializeComponent();
            SetupTimer();
        }
        private void SetupTimer()
        {
            _timer = new System.Timers.Timer(500); // .5 seconds interval for checks
            _timer.Elapsed += UpdateGaugeValue;
            _timer.AutoReset = true;
            _timer.Start();
        }
        private void UpdateGaugeValue(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                // Setup for Testing Specifically with random data but can be changed in InputDataMaker
                radialGaugeFluidPressure.Value = InputDataMaker.ChangeData("Test");
                radialGaugePumpSpeed.Value = InputDataMaker.ChangeData("Test");
                radialGaugeHotTempIn.Value = InputDataMaker.ChangeData("Test");
                radialGaugeHotTempOut.Value = InputDataMaker.ChangeData("Test");
                radialGaugeColdTempIn.Value = InputDataMaker.ChangeData("Test");
                radialGaugeColdTempOut.Value = InputDataMaker.ChangeData("Test");
                radialGaugeFryerTempIn.Value = InputDataMaker.ChangeData("Test");
                radialGaugeFryerTempOut.Value = InputDataMaker.ChangeData("Test");
            }));
        }

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

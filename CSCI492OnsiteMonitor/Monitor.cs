using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI492OnsiteMonitor
{
    public partial class MonitorPage : Form
    {
        public MonitorPage()
        {
            InitializeComponent();
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

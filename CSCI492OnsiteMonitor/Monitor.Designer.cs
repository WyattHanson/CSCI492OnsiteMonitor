using Microsoft.VisualBasic;
using Syncfusion.Windows.Shared;

namespace CSCI492OnsiteMonitor
{
    partial class MonitorPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Gauge.Range range1 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range2 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range3 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range4 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range5 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range6 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range7 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range8 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range9 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range10 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range11 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range12 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range13 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range14 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range15 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range16 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range17 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range18 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range19 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range20 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range21 = new Syncfusion.Windows.Forms.Gauge.Range();
            TestButton = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            tempIn = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            leftOverViewPanel = new System.Windows.Forms.Panel();
            messageBox = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            systemHealthIndicator = new System.Windows.Forms.PictureBox();
            systemPowerIndicator = new System.Windows.Forms.PictureBox();
            systemHealthLabel = new System.Windows.Forms.Label();
            PowerLabel = new System.Windows.Forms.Label();
            systemOverviewLabel = new System.Windows.Forms.Label();
            connectionStatusIndicator = new System.Windows.Forms.PictureBox();
            connectionStatusLabel = new System.Windows.Forms.Label();
            systemInformation = new System.Windows.Forms.Panel();
            monitoringType = new System.Windows.Forms.Label();
            systemName = new System.Windows.Forms.Label();
            monitorLogo = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            panel3 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            radialGauge5 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            radialGauge2 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            panel4 = new System.Windows.Forms.Panel();
            radialGauge3 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            panel5 = new System.Windows.Forms.Panel();
            radialGauge4 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            panel7 = new System.Windows.Forms.Panel();
            radialGauge6 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            panel1.SuspendLayout();
            leftOverViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)systemHealthIndicator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)systemPowerIndicator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectionStatusIndicator).BeginInit();
            systemInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)monitorLogo).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // TestButton
            // 
            TestButton.Location = new System.Drawing.Point(525, 832);
            TestButton.Name = "TestButton";
            TestButton.Size = new System.Drawing.Size(129, 31);
            TestButton.TabIndex = 3;
            TestButton.Text = "Test Email Alert";
            TestButton.UseVisualStyleBackColor = true;
            TestButton.Visible = false;
            TestButton.Click += TestButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(tempIn);
            panel1.ForeColor = System.Drawing.Color.Gray;
            panel1.Location = new System.Drawing.Point(406, 45);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(289, 285);
            panel1.TabIndex = 5;
            // 
            // tempIn
            // 
            tempIn.ArcThickness = 5F;
            tempIn.BackgroundGradientStartColor = System.Drawing.SystemColors.ButtonFace;
            tempIn.EnableCustomNeedles = false;
            tempIn.FillColor = System.Drawing.Color.DarkGray;
            tempIn.FrameThickness = 12;
            tempIn.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.QuarterCircle;
            tempIn.GaugeLabel = "Gauge";
            tempIn.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tempIn.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tempIn.InnerFrameGradientStartColor = System.Drawing.SystemColors.ActiveBorder;
            tempIn.Location = new System.Drawing.Point(-2, -2);
            tempIn.MajorTickMarkHeight = 0;
            tempIn.MinimumSize = new System.Drawing.Size(125, 125);
            tempIn.MinorInnerLinesHeight = 0;
            tempIn.MinorTickMarkHeight = 0;
            tempIn.Name = "tempIn";
            range1.Color = System.Drawing.Color.FromArgb(0, 255, 0);
            range1.EndValue = 80F;
            range1.Height = 5;
            range1.InRange = false;
            range1.Name = "GaugeRange1";
            range1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range1.StartValue = 0F;
            range2.Color = System.Drawing.Color.Yellow;
            range2.EndValue = 100F;
            range2.Height = 5;
            range2.InRange = false;
            range2.Name = "GaugeRange2";
            range2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range2.StartValue = 80F;
            range3.Color = System.Drawing.Color.FromArgb(192, 0, 0);
            range3.EndValue = 120F;
            range3.Height = 5;
            range3.InRange = false;
            range3.Name = "GaugeRange3";
            range3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range3.StartValue = 100F;
            tempIn.Ranges.Add(range1);
            tempIn.Ranges.Add(range2);
            tempIn.Ranges.Add(range3);
            tempIn.ShowTicks = true;
            tempIn.Size = new System.Drawing.Size(539, 539);
            tempIn.StartAngle = 180;
            tempIn.SweepAngle = 90;
            tempIn.TabIndex = 10;
            tempIn.Click += radialGauge3_Click;
            // 
            // leftOverViewPanel
            // 
            leftOverViewPanel.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            leftOverViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            leftOverViewPanel.Controls.Add(messageBox);
            leftOverViewPanel.Controls.Add(label1);
            leftOverViewPanel.Controls.Add(systemHealthIndicator);
            leftOverViewPanel.Controls.Add(systemPowerIndicator);
            leftOverViewPanel.Controls.Add(systemHealthLabel);
            leftOverViewPanel.Controls.Add(PowerLabel);
            leftOverViewPanel.Controls.Add(systemOverviewLabel);
            leftOverViewPanel.Controls.Add(connectionStatusIndicator);
            leftOverViewPanel.Controls.Add(connectionStatusLabel);
            leftOverViewPanel.Controls.Add(systemInformation);
            leftOverViewPanel.Dock = System.Windows.Forms.DockStyle.Left;
            leftOverViewPanel.Location = new System.Drawing.Point(0, 0);
            leftOverViewPanel.Name = "leftOverViewPanel";
            leftOverViewPanel.Size = new System.Drawing.Size(290, 875);
            leftOverViewPanel.TabIndex = 7;
            // 
            // messageBox
            // 
            messageBox.BackColor = System.Drawing.SystemColors.ControlText;
            messageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            messageBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            messageBox.Location = new System.Drawing.Point(15, 533);
            messageBox.Name = "messageBox";
            messageBox.Size = new System.Drawing.Size(256, 328);
            messageBox.TabIndex = 15;
            messageBox.Text = "2/5/2025 12:00:00 AM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            label1.Location = new System.Drawing.Point(5, 480);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(281, 40);
            label1.TabIndex = 14;
            label1.Text = "-System Messages-";
            // 
            // systemHealthIndicator
            // 
            systemHealthIndicator.Image = Properties.Resources.Good;
            systemHealthIndicator.Location = new System.Drawing.Point(186, 408);
            systemHealthIndicator.Name = "systemHealthIndicator";
            systemHealthIndicator.Size = new System.Drawing.Size(100, 69);
            systemHealthIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            systemHealthIndicator.TabIndex = 13;
            systemHealthIndicator.TabStop = false;
            // 
            // systemPowerIndicator
            // 
            systemPowerIndicator.Image = Properties.Resources.Good;
            systemPowerIndicator.Location = new System.Drawing.Point(186, 271);
            systemPowerIndicator.Name = "systemPowerIndicator";
            systemPowerIndicator.Size = new System.Drawing.Size(100, 69);
            systemPowerIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            systemPowerIndicator.TabIndex = 12;
            systemPowerIndicator.TabStop = false;
            // 
            // systemHealthLabel
            // 
            systemHealthLabel.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            systemHealthLabel.ForeColor = System.Drawing.SystemColors.Window;
            systemHealthLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            systemHealthLabel.Location = new System.Drawing.Point(-1, 412);
            systemHealthLabel.Name = "systemHealthLabel";
            systemHealthLabel.Size = new System.Drawing.Size(287, 69);
            systemHealthLabel.TabIndex = 11;
            systemHealthLabel.Text = "System Health";
            systemHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PowerLabel
            // 
            PowerLabel.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            PowerLabel.ForeColor = System.Drawing.SystemColors.Window;
            PowerLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            PowerLabel.Location = new System.Drawing.Point(-1, 274);
            PowerLabel.Name = "PowerLabel";
            PowerLabel.Size = new System.Drawing.Size(287, 69);
            PowerLabel.TabIndex = 10;
            PowerLabel.Text = "System Power";
            PowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // systemOverviewLabel
            // 
            systemOverviewLabel.AutoSize = true;
            systemOverviewLabel.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            systemOverviewLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            systemOverviewLabel.Location = new System.Drawing.Point(5, 234);
            systemOverviewLabel.Name = "systemOverviewLabel";
            systemOverviewLabel.Size = new System.Drawing.Size(275, 40);
            systemOverviewLabel.TabIndex = 9;
            systemOverviewLabel.Text = "-System Overview-";
            // 
            // connectionStatusIndicator
            // 
            connectionStatusIndicator.Image = Properties.Resources.Good;
            connectionStatusIndicator.Location = new System.Drawing.Point(186, 340);
            connectionStatusIndicator.Name = "connectionStatusIndicator";
            connectionStatusIndicator.Size = new System.Drawing.Size(100, 69);
            connectionStatusIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            connectionStatusIndicator.TabIndex = 8;
            connectionStatusIndicator.TabStop = false;
            // 
            // connectionStatusLabel
            // 
            connectionStatusLabel.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            connectionStatusLabel.ForeColor = System.Drawing.SystemColors.Window;
            connectionStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            connectionStatusLabel.Location = new System.Drawing.Point(-1, 343);
            connectionStatusLabel.Name = "connectionStatusLabel";
            connectionStatusLabel.Size = new System.Drawing.Size(287, 69);
            connectionStatusLabel.TabIndex = 2;
            connectionStatusLabel.Text = "Connection Status";
            connectionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            connectionStatusLabel.Click += connectionStatusLabel_Click;
            // 
            // systemInformation
            // 
            systemInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            systemInformation.Controls.Add(monitoringType);
            systemInformation.Controls.Add(systemName);
            systemInformation.Controls.Add(monitorLogo);
            systemInformation.Dock = System.Windows.Forms.DockStyle.Top;
            systemInformation.Location = new System.Drawing.Point(0, 0);
            systemInformation.Name = "systemInformation";
            systemInformation.Size = new System.Drawing.Size(286, 235);
            systemInformation.TabIndex = 0;
            systemInformation.Paint += systemInformation_Paint;
            // 
            // monitoringType
            // 
            monitoringType.AutoSize = true;
            monitoringType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            monitoringType.ForeColor = System.Drawing.SystemColors.ScrollBar;
            monitoringType.Location = new System.Drawing.Point(60, 212);
            monitoringType.Name = "monitoringType";
            monitoringType.Size = new System.Drawing.Size(163, 16);
            monitoringType.TabIndex = 2;
            monitoringType.Text = "Whole System Service";
            monitoringType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // systemName
            // 
            systemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            systemName.AutoSize = true;
            systemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            systemName.ForeColor = System.Drawing.Color.White;
            systemName.Location = new System.Drawing.Point(32, 190);
            systemName.Name = "systemName";
            systemName.Size = new System.Drawing.Size(215, 24);
            systemName.TabIndex = 1;
            systemName.Text = "Prototype Site Monitor";
            systemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            systemName.Click += systemName_Click;
            // 
            // monitorLogo
            // 
            monitorLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            monitorLogo.Image = Properties.Resources.CroppedUND_RJ_Energy_With_Hawk_overlooking_but_has_weird_symbol;
            monitorLogo.Location = new System.Drawing.Point(14, 14);
            monitorLogo.Name = "monitorLogo";
            monitorLogo.Size = new System.Drawing.Size(256, 173);
            monitorLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            monitorLogo.TabIndex = 0;
            monitorLogo.TabStop = false;
            monitorLogo.Click += monitorLogo_Click;
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel2.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.Controls.Add(radialGauge1);
            panel2.ForeColor = System.Drawing.Color.Gray;
            panel2.Location = new System.Drawing.Point(406, 462);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(289, 285);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // radialGauge1
            // 
            radialGauge1.ArcThickness = 5F;
            radialGauge1.BackgroundGradientStartColor = System.Drawing.SystemColors.ButtonFace;
            radialGauge1.EnableCustomNeedles = false;
            radialGauge1.FillColor = System.Drawing.Color.DarkGray;
            radialGauge1.FrameThickness = 12;
            radialGauge1.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.QuarterCircle;
            radialGauge1.GaugeLabel = "Gauge";
            radialGauge1.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radialGauge1.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radialGauge1.InnerFrameGradientStartColor = System.Drawing.SystemColors.ActiveBorder;
            radialGauge1.Location = new System.Drawing.Point(-12, -2);
            radialGauge1.MajorTickMarkHeight = 0;
            radialGauge1.MinimumSize = new System.Drawing.Size(125, 125);
            radialGauge1.MinorInnerLinesHeight = 0;
            radialGauge1.MinorTickMarkHeight = 0;
            radialGauge1.Name = "radialGauge1";
            range4.Color = System.Drawing.Color.FromArgb(0, 255, 0);
            range4.EndValue = 80F;
            range4.Height = 5;
            range4.InRange = false;
            range4.Name = "GaugeRange1";
            range4.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range4.StartValue = 0F;
            range5.Color = System.Drawing.Color.Yellow;
            range5.EndValue = 100F;
            range5.Height = 5;
            range5.InRange = false;
            range5.Name = "GaugeRange2";
            range5.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range5.StartValue = 80F;
            range6.Color = System.Drawing.Color.FromArgb(192, 0, 0);
            range6.EndValue = 120F;
            range6.Height = 5;
            range6.InRange = false;
            range6.Name = "GaugeRange3";
            range6.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range6.StartValue = 100F;
            radialGauge1.Ranges.Add(range4);
            radialGauge1.Ranges.Add(range5);
            radialGauge1.Ranges.Add(range6);
            radialGauge1.ShowTicks = true;
            radialGauge1.Size = new System.Drawing.Size(539, 539);
            radialGauge1.StartAngle = 180;
            radialGauge1.SweepAngle = 90;
            radialGauge1.TabIndex = 10;
            radialGauge1.Click += radialGauge1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel3.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(radialGauge2);
            panel3.ForeColor = System.Drawing.Color.Gray;
            panel3.Location = new System.Drawing.Point(843, 462);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(289, 285);
            panel3.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel6.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel6.Controls.Add(radialGauge5);
            panel6.ForeColor = System.Drawing.Color.Gray;
            panel6.Location = new System.Drawing.Point(-2, -2);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(289, 285);
            panel6.TabIndex = 11;
            // 
            // radialGauge5
            // 
            radialGauge5.ArcThickness = 5F;
            radialGauge5.BackgroundGradientStartColor = System.Drawing.SystemColors.ButtonFace;
            radialGauge5.EnableCustomNeedles = false;
            radialGauge5.FillColor = System.Drawing.Color.DarkGray;
            radialGauge5.FrameThickness = 12;
            radialGauge5.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.QuarterCircle;
            radialGauge5.GaugeLabel = "Gauge";
            radialGauge5.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radialGauge5.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radialGauge5.InnerFrameGradientStartColor = System.Drawing.SystemColors.ActiveBorder;
            radialGauge5.Location = new System.Drawing.Point(-2, -2);
            radialGauge5.MajorTickMarkHeight = 0;
            radialGauge5.MinimumSize = new System.Drawing.Size(125, 125);
            radialGauge5.MinorInnerLinesHeight = 0;
            radialGauge5.MinorTickMarkHeight = 0;
            radialGauge5.Name = "radialGauge5";
            range7.Color = System.Drawing.Color.FromArgb(0, 255, 0);
            range7.EndValue = 80F;
            range7.Height = 5;
            range7.InRange = false;
            range7.Name = "GaugeRange1";
            range7.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range7.StartValue = 0F;
            range8.Color = System.Drawing.Color.Yellow;
            range8.EndValue = 100F;
            range8.Height = 5;
            range8.InRange = false;
            range8.Name = "GaugeRange2";
            range8.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range8.StartValue = 80F;
            range9.Color = System.Drawing.Color.FromArgb(192, 0, 0);
            range9.EndValue = 120F;
            range9.Height = 5;
            range9.InRange = false;
            range9.Name = "GaugeRange3";
            range9.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range9.StartValue = 100F;
            radialGauge5.Ranges.Add(range7);
            radialGauge5.Ranges.Add(range8);
            radialGauge5.Ranges.Add(range9);
            radialGauge5.ShowTicks = true;
            radialGauge5.Size = new System.Drawing.Size(539, 539);
            radialGauge5.StartAngle = 180;
            radialGauge5.SweepAngle = 90;
            radialGauge5.TabIndex = 10;
            radialGauge5.Click += radialGauge5_Click;
            // 
            // radialGauge2
            // 
            radialGauge2.ArcThickness = 5F;
            radialGauge2.BackgroundGradientStartColor = System.Drawing.SystemColors.ButtonFace;
            radialGauge2.EnableCustomNeedles = false;
            radialGauge2.FillColor = System.Drawing.Color.DarkGray;
            radialGauge2.FrameThickness = 12;
            radialGauge2.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.QuarterCircle;
            radialGauge2.GaugeLabel = "Gauge";
            radialGauge2.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radialGauge2.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radialGauge2.InnerFrameGradientStartColor = System.Drawing.SystemColors.ActiveBorder;
            radialGauge2.Location = new System.Drawing.Point(-2, -15);
            radialGauge2.MajorTickMarkHeight = 0;
            radialGauge2.MinimumSize = new System.Drawing.Size(125, 125);
            radialGauge2.MinorInnerLinesHeight = 0;
            radialGauge2.MinorTickMarkHeight = 0;
            radialGauge2.Name = "radialGauge2";
            range10.Color = System.Drawing.Color.FromArgb(0, 255, 0);
            range10.EndValue = 80F;
            range10.Height = 5;
            range10.InRange = false;
            range10.Name = "GaugeRange1";
            range10.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range10.StartValue = 0F;
            range11.Color = System.Drawing.Color.Yellow;
            range11.EndValue = 100F;
            range11.Height = 5;
            range11.InRange = false;
            range11.Name = "GaugeRange2";
            range11.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range11.StartValue = 80F;
            range12.Color = System.Drawing.Color.FromArgb(192, 0, 0);
            range12.EndValue = 120F;
            range12.Height = 5;
            range12.InRange = false;
            range12.Name = "GaugeRange3";
            range12.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range12.StartValue = 100F;
            radialGauge2.Ranges.Add(range10);
            radialGauge2.Ranges.Add(range11);
            radialGauge2.Ranges.Add(range12);
            radialGauge2.ShowTicks = true;
            radialGauge2.Size = new System.Drawing.Size(539, 539);
            radialGauge2.StartAngle = 180;
            radialGauge2.SweepAngle = 90;
            radialGauge2.TabIndex = 10;
            radialGauge2.Click += radialGauge2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel4.Controls.Add(radialGauge3);
            panel4.ForeColor = System.Drawing.Color.Gray;
            panel4.Location = new System.Drawing.Point(843, 45);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(289, 285);
            panel4.TabIndex = 9;
            // 
            // radialGauge3
            // 
            radialGauge3.ArcThickness = 5F;
            radialGauge3.BackgroundGradientStartColor = System.Drawing.SystemColors.ButtonFace;
            radialGauge3.EnableCustomNeedles = false;
            radialGauge3.FillColor = System.Drawing.Color.DarkGray;
            radialGauge3.FrameThickness = 12;
            radialGauge3.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.QuarterCircle;
            radialGauge3.GaugeLabel = "Gauge";
            radialGauge3.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radialGauge3.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radialGauge3.InnerFrameGradientStartColor = System.Drawing.SystemColors.ActiveBorder;
            radialGauge3.Location = new System.Drawing.Point(3, 3);
            radialGauge3.MajorTickMarkHeight = 0;
            radialGauge3.MinimumSize = new System.Drawing.Size(125, 125);
            radialGauge3.MinorInnerLinesHeight = 0;
            radialGauge3.MinorTickMarkHeight = 0;
            radialGauge3.Name = "radialGauge3";
            range13.Color = System.Drawing.Color.FromArgb(0, 255, 0);
            range13.EndValue = 80F;
            range13.Height = 5;
            range13.InRange = false;
            range13.Name = "GaugeRange1";
            range13.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range13.StartValue = 0F;
            range14.Color = System.Drawing.Color.Yellow;
            range14.EndValue = 100F;
            range14.Height = 5;
            range14.InRange = false;
            range14.Name = "GaugeRange2";
            range14.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range14.StartValue = 80F;
            range15.Color = System.Drawing.Color.FromArgb(192, 0, 0);
            range15.EndValue = 120F;
            range15.Height = 5;
            range15.InRange = false;
            range15.Name = "GaugeRange3";
            range15.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range15.StartValue = 100F;
            radialGauge3.Ranges.Add(range13);
            radialGauge3.Ranges.Add(range14);
            radialGauge3.Ranges.Add(range15);
            radialGauge3.ShowTicks = true;
            radialGauge3.Size = new System.Drawing.Size(539, 539);
            radialGauge3.StartAngle = 180;
            radialGauge3.SweepAngle = 90;
            radialGauge3.TabIndex = 10;
            radialGauge3.Click += radialGauge3_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel5.Controls.Add(radialGauge4);
            panel5.ForeColor = System.Drawing.Color.Gray;
            panel5.Location = new System.Drawing.Point(1294, 45);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(289, 285);
            panel5.TabIndex = 11;
            // 
            // radialGauge4
            // 
            radialGauge4.ArcThickness = 5F;
            radialGauge4.BackgroundGradientStartColor = System.Drawing.SystemColors.ButtonFace;
            radialGauge4.EnableCustomNeedles = false;
            radialGauge4.FillColor = System.Drawing.Color.DarkGray;
            radialGauge4.FrameThickness = 12;
            radialGauge4.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.QuarterCircle;
            radialGauge4.GaugeLabel = "Gauge";
            radialGauge4.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radialGauge4.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radialGauge4.InnerFrameGradientStartColor = System.Drawing.SystemColors.ActiveBorder;
            radialGauge4.Location = new System.Drawing.Point(3, -2);
            radialGauge4.MajorTickMarkHeight = 0;
            radialGauge4.MinimumSize = new System.Drawing.Size(125, 125);
            radialGauge4.MinorInnerLinesHeight = 0;
            radialGauge4.MinorTickMarkHeight = 0;
            radialGauge4.Name = "radialGauge4";
            range16.Color = System.Drawing.Color.FromArgb(0, 255, 0);
            range16.EndValue = 80F;
            range16.Height = 5;
            range16.InRange = false;
            range16.Name = "GaugeRange1";
            range16.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range16.StartValue = 0F;
            range17.Color = System.Drawing.Color.Yellow;
            range17.EndValue = 100F;
            range17.Height = 5;
            range17.InRange = false;
            range17.Name = "GaugeRange2";
            range17.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range17.StartValue = 80F;
            range18.Color = System.Drawing.Color.FromArgb(192, 0, 0);
            range18.EndValue = 120F;
            range18.Height = 5;
            range18.InRange = false;
            range18.Name = "GaugeRange3";
            range18.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range18.StartValue = 100F;
            radialGauge4.Ranges.Add(range16);
            radialGauge4.Ranges.Add(range17);
            radialGauge4.Ranges.Add(range18);
            radialGauge4.ShowTicks = true;
            radialGauge4.Size = new System.Drawing.Size(539, 539);
            radialGauge4.StartAngle = 180;
            radialGauge4.SweepAngle = 90;
            radialGauge4.TabIndex = 10;
            // 
            // panel7
            // 
            panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel7.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel7.Controls.Add(radialGauge6);
            panel7.ForeColor = System.Drawing.Color.Gray;
            panel7.Location = new System.Drawing.Point(1294, 462);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(289, 285);
            panel7.TabIndex = 12;
            // 
            // radialGauge6
            // 
            radialGauge6.ArcThickness = 5F;
            radialGauge6.BackgroundGradientStartColor = System.Drawing.SystemColors.ButtonFace;
            radialGauge6.EnableCustomNeedles = false;
            radialGauge6.FillColor = System.Drawing.Color.DarkGray;
            radialGauge6.FrameThickness = 12;
            radialGauge6.FrameType = Syncfusion.Windows.Forms.Gauge.FrameType.QuarterCircle;
            radialGauge6.GaugeLabel = "Gauge";
            radialGauge6.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radialGauge6.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radialGauge6.InnerFrameGradientStartColor = System.Drawing.SystemColors.ActiveBorder;
            radialGauge6.Location = new System.Drawing.Point(-2, -2);
            radialGauge6.MajorTickMarkHeight = 0;
            radialGauge6.MinimumSize = new System.Drawing.Size(125, 125);
            radialGauge6.MinorInnerLinesHeight = 0;
            radialGauge6.MinorTickMarkHeight = 0;
            radialGauge6.Name = "radialGauge6";
            range19.Color = System.Drawing.Color.FromArgb(0, 255, 0);
            range19.EndValue = 80F;
            range19.Height = 5;
            range19.InRange = false;
            range19.Name = "GaugeRange1";
            range19.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range19.StartValue = 0F;
            range20.Color = System.Drawing.Color.Yellow;
            range20.EndValue = 100F;
            range20.Height = 5;
            range20.InRange = false;
            range20.Name = "GaugeRange2";
            range20.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range20.StartValue = 80F;
            range21.Color = System.Drawing.Color.FromArgb(192, 0, 0);
            range21.EndValue = 120F;
            range21.Height = 5;
            range21.InRange = false;
            range21.Name = "GaugeRange3";
            range21.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.OutSide;
            range21.StartValue = 100F;
            radialGauge6.Ranges.Add(range19);
            radialGauge6.Ranges.Add(range20);
            radialGauge6.Ranges.Add(range21);
            radialGauge6.ShowTicks = true;
            radialGauge6.Size = new System.Drawing.Size(539, 539);
            radialGauge6.StartAngle = 180;
            radialGauge6.SweepAngle = 90;
            radialGauge6.TabIndex = 10;
            // 
            // MonitorPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            ClientSize = new System.Drawing.Size(1785, 875);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(TestButton);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(leftOverViewPanel);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "MonitorPage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Monitor";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            leftOverViewPanel.ResumeLayout(false);
            leftOverViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)systemHealthIndicator).EndInit();
            ((System.ComponentModel.ISupportInitialize)systemPowerIndicator).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectionStatusIndicator).EndInit();
            systemInformation.ResumeLayout(false);
            systemInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)monitorLogo).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel leftOverViewPanel;
        private System.Windows.Forms.Panel systemInformation;
        private System.Windows.Forms.PictureBox monitorLogo;
        private System.Windows.Forms.Label systemName;
        private System.Windows.Forms.Label monitoringType;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.PictureBox connectionStatusIndicator;
        private System.Windows.Forms.Label systemOverviewLabel;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Label systemHealthLabel;
        private System.Windows.Forms.PictureBox systemHealthIndicator;
        private System.Windows.Forms.PictureBox systemPowerIndicator;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge tempIn;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        private System.Windows.Forms.Panel panel3;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge2;
        private System.Windows.Forms.Panel panel4;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge3;
        private System.Windows.Forms.Panel panel5;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge4;
        private System.Windows.Forms.Panel panel6;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge5;
        private System.Windows.Forms.Panel panel7;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge6;
        private System.Windows.Forms.Label messageBox;
    }
}


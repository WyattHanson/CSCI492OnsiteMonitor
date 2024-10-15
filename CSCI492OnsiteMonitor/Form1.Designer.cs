namespace CSCI492OnsiteMonitor
{
    partial class Form1
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
            Syncfusion.Windows.Forms.Gauge.Range range6 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range7 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range8 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range9 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range10 = new Syncfusion.Windows.Forms.Gauge.Range();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fluidTempetureGauge = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.rjEnergyLogo = new System.Windows.Forms.PictureBox();
            this.undLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rjEnergyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.undLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // fluidTempetureGauge
            // 
            this.fluidTempetureGauge.ArcThickness = 0F;
            this.fluidTempetureGauge.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.fluidTempetureGauge.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.fluidTempetureGauge.EnableCustomNeedles = false;
            this.fluidTempetureGauge.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.fluidTempetureGauge.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fluidTempetureGauge.FrameThickness = 12;
            this.fluidTempetureGauge.GaugeArcColor = System.Drawing.Color.White;
            this.fluidTempetureGauge.GaugeLabel = "GaugeTemp";
            this.fluidTempetureGauge.GaugeLableFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluidTempetureGauge.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluidTempetureGauge.InnerFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.fluidTempetureGauge.InnerFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.fluidTempetureGauge.InterLinesColor = System.Drawing.Color.White;
            this.fluidTempetureGauge.LabelPlacement = Syncfusion.Windows.Forms.Gauge.LabelPlacement.Outside;
            this.fluidTempetureGauge.Location = new System.Drawing.Point(-5, 86);
            this.fluidTempetureGauge.MajorDifference = 10F;
            this.fluidTempetureGauge.MajorTickMarkColor = System.Drawing.Color.White;
            this.fluidTempetureGauge.MinimumSize = new System.Drawing.Size(125, 125);
            this.fluidTempetureGauge.MinorTickMarkColor = System.Drawing.Color.White;
            this.fluidTempetureGauge.Name = "fluidTempetureGauge";
            this.fluidTempetureGauge.NeedleColor = System.Drawing.Color.White;
            this.fluidTempetureGauge.NeedleStyle = Syncfusion.Windows.Forms.Gauge.NeedleStyle.Advanced;
            this.fluidTempetureGauge.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.fluidTempetureGauge.OuterFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            range6.Color = System.Drawing.Color.Red;
            range6.EndValue = 36F;
            range6.Height = 5;
            range6.InRange = false;
            range6.Name = "FreezingRange";
            range6.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range6.StartValue = 0F;
            range7.Color = System.Drawing.Color.Yellow;
            range7.EndValue = 50F;
            range7.Height = 5;
            range7.InRange = true;
            range7.Name = "Low Warning Range";
            range7.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range7.StartValue = 36F;
            range8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            range8.EndValue = 60F;
            range8.Height = 5;
            range8.InRange = false;
            range8.Name = "GoodRange";
            range8.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range8.StartValue = 50F;
            range9.Color = System.Drawing.Color.Yellow;
            range9.EndValue = 80F;
            range9.Height = 5;
            range9.InRange = false;
            range9.Name = "High Warning Range";
            range9.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range9.StartValue = 60F;
            range10.Color = System.Drawing.Color.Red;
            range10.EndValue = 120F;
            range10.Height = 5;
            range10.InRange = false;
            range10.Name = "MeltDown";
            range10.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range10.StartValue = 80F;
            this.fluidTempetureGauge.Ranges.Add(range6);
            this.fluidTempetureGauge.Ranges.Add(range7);
            this.fluidTempetureGauge.Ranges.Add(range8);
            this.fluidTempetureGauge.Ranges.Add(range9);
            this.fluidTempetureGauge.Ranges.Add(range10);
            this.fluidTempetureGauge.ScaleLabelColor = System.Drawing.Color.White;
            this.fluidTempetureGauge.ShowTicks = true;
            this.fluidTempetureGauge.Size = new System.Drawing.Size(273, 273);
            this.fluidTempetureGauge.TabIndex = 0;
            this.fluidTempetureGauge.ThemeName = "Black";
            this.fluidTempetureGauge.ThemeStyle.ArcThickness = 20F;
            this.fluidTempetureGauge.Value = 40F;
            this.fluidTempetureGauge.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Black;
            // 
            // rjEnergyLogo
            // 
            this.rjEnergyLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rjEnergyLogo.Image = ((System.Drawing.Image)(resources.GetObject("rjEnergyLogo.Image")));
            this.rjEnergyLogo.Location = new System.Drawing.Point(-5, -34);
            this.rjEnergyLogo.Name = "rjEnergyLogo";
            this.rjEnergyLogo.Size = new System.Drawing.Size(273, 148);
            this.rjEnergyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjEnergyLogo.TabIndex = 1;
            this.rjEnergyLogo.TabStop = false;
            // 
            // undLogo
            // 
            this.undLogo.Image = ((System.Drawing.Image)(resources.GetObject("undLogo.Image")));
            this.undLogo.Location = new System.Drawing.Point(300, 0);
            this.undLogo.Name = "undLogo";
            this.undLogo.Size = new System.Drawing.Size(449, 77);
            this.undLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.undLogo.TabIndex = 2;
            this.undLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.undLogo);
            this.Controls.Add(this.fluidTempetureGauge);
            this.Controls.Add(this.rjEnergyLogo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rjEnergyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.undLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Gauge.RadialGauge fluidTempetureGauge;
        private System.Windows.Forms.PictureBox rjEnergyLogo;
        private System.Windows.Forms.PictureBox undLogo;
    }
}


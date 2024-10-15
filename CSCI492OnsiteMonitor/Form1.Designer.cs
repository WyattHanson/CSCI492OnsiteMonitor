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
            Syncfusion.Windows.Forms.Gauge.Range range1 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range2 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range3 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range4 = new Syncfusion.Windows.Forms.Gauge.Range();
            Syncfusion.Windows.Forms.Gauge.Range range5 = new Syncfusion.Windows.Forms.Gauge.Range();
            this.fluidTempetureGauge = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
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
            this.fluidTempetureGauge.Location = new System.Drawing.Point(12, 12);
            this.fluidTempetureGauge.MajorDifference = 10F;
            this.fluidTempetureGauge.MajorTickMarkColor = System.Drawing.Color.White;
            this.fluidTempetureGauge.MinimumSize = new System.Drawing.Size(125, 125);
            this.fluidTempetureGauge.MinorTickMarkColor = System.Drawing.Color.White;
            this.fluidTempetureGauge.Name = "fluidTempetureGauge";
            this.fluidTempetureGauge.NeedleColor = System.Drawing.Color.White;
            this.fluidTempetureGauge.NeedleStyle = Syncfusion.Windows.Forms.Gauge.NeedleStyle.Advanced;
            this.fluidTempetureGauge.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.fluidTempetureGauge.OuterFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            range1.Color = System.Drawing.Color.Red;
            range1.EndValue = 36F;
            range1.Height = 5;
            range1.InRange = false;
            range1.Name = "FreezingRange";
            range1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range1.StartValue = 0F;
            range2.Color = System.Drawing.Color.Yellow;
            range2.EndValue = 50F;
            range2.Height = 5;
            range2.InRange = true;
            range2.Name = "Low Warning Range";
            range2.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range2.StartValue = 36F;
            range3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            range3.EndValue = 60F;
            range3.Height = 5;
            range3.InRange = false;
            range3.Name = "GoodRange";
            range3.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range3.StartValue = 50F;
            range4.Color = System.Drawing.Color.Yellow;
            range4.EndValue = 80F;
            range4.Height = 5;
            range4.InRange = false;
            range4.Name = "High Warning Range";
            range4.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range4.StartValue = 60F;
            range5.Color = System.Drawing.Color.Red;
            range5.EndValue = 120F;
            range5.Height = 5;
            range5.InRange = false;
            range5.Name = "MeltDown";
            range5.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            range5.StartValue = 80F;
            this.fluidTempetureGauge.Ranges.Add(range1);
            this.fluidTempetureGauge.Ranges.Add(range2);
            this.fluidTempetureGauge.Ranges.Add(range3);
            this.fluidTempetureGauge.Ranges.Add(range4);
            this.fluidTempetureGauge.Ranges.Add(range5);
            this.fluidTempetureGauge.ScaleLabelColor = System.Drawing.Color.White;
            this.fluidTempetureGauge.ShowTicks = true;
            this.fluidTempetureGauge.Size = new System.Drawing.Size(273, 273);
            this.fluidTempetureGauge.TabIndex = 0;
            this.fluidTempetureGauge.ThemeName = "Black";
            this.fluidTempetureGauge.ThemeStyle.ArcThickness = 20F;
            this.fluidTempetureGauge.Value = 40F;
            this.fluidTempetureGauge.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Black;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fluidTempetureGauge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Gauge.RadialGauge fluidTempetureGauge;
    }
}


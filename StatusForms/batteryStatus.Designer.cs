
namespace MissionPlanner.StatusForms
{
    partial class batteryStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(batteryStatusForm));
            this.battGauge = new AGaugeApp.AGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrPultGauge = new AGaugeApp.AGauge();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // battGauge
            // 
            this.battGauge.BackColor = System.Drawing.Color.Transparent;
            this.battGauge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("battGauge.BackgroundImage")));
            this.battGauge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.battGauge.BaseArcColor = System.Drawing.Color.Transparent;
            this.battGauge.BaseArcRadius = 70;
            this.battGauge.BaseArcStart = 135;
            this.battGauge.BaseArcSweep = 270;
            this.battGauge.BaseArcWidth = 2;
            this.battGauge.Cap_Idx = ((byte)(1));
            this.battGauge.CapColor = System.Drawing.Color.White;
            this.battGauge.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.battGauge.CapPosition = new System.Drawing.Point(54, 110);
            this.battGauge.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(56, 85),
        new System.Drawing.Point(54, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.battGauge.CapsText = new string[] {
        "VOLTS",
        "16.2 Volt",
        "",
        "",
        ""};
            this.battGauge.CapText = "16.2 Volt";
            this.battGauge.Center = new System.Drawing.Point(75, 75);
            this.battGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battGauge.Location = new System.Drawing.Point(9, 42);
            this.battGauge.Margin = new System.Windows.Forms.Padding(0);
            this.battGauge.MaxValue = 18F;
            this.battGauge.MinValue = 12F;
            this.battGauge.Name = "battGauge";
            this.battGauge.Need_Idx = ((byte)(0));
            this.battGauge.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Red;
            this.battGauge.NeedleColor2 = System.Drawing.Color.White;
            this.battGauge.NeedleEnabled = true;
            this.battGauge.NeedleRadius = 60;
            this.battGauge.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.battGauge.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.battGauge.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.battGauge.NeedlesRadius = new int[] {
        60,
        50,
        70,
        70};
            this.battGauge.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.battGauge.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.battGauge.NeedleType = 0;
            this.battGauge.NeedleWidth = 2;
            this.battGauge.Range_Idx = ((byte)(3));
            this.battGauge.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.battGauge.RangeEnabled = true;
            this.battGauge.RangeEndValue = 18F;
            this.battGauge.RangeInnerRadius = 60;
            this.battGauge.RangeOuterRadius = 70;
            this.battGauge.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Lime,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.SystemColors.Control};
            this.battGauge.RangesEnabled = new bool[] {
        true,
        true,
        true,
        true,
        false};
            this.battGauge.RangesEndValue = new float[] {
        13.2F,
        14F,
        16.8F,
        18F,
        0F};
            this.battGauge.RangesInnerRadius = new int[] {
        60,
        60,
        60,
        60,
        70};
            this.battGauge.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        70,
        80};
            this.battGauge.RangesStartValue = new float[] {
        12F,
        13.2F,
        14F,
        16.8F,
        0F};
            this.battGauge.RangeStartValue = 16.8F;
            this.battGauge.ScaleLinesInterColor = System.Drawing.Color.White;
            this.battGauge.ScaleLinesInterInnerRadius = 52;
            this.battGauge.ScaleLinesInterOuterRadius = 60;
            this.battGauge.ScaleLinesInterWidth = 1;
            this.battGauge.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.battGauge.ScaleLinesMajorInnerRadius = 50;
            this.battGauge.ScaleLinesMajorOuterRadius = 60;
            this.battGauge.ScaleLinesMajorStepValue = 1F;
            this.battGauge.ScaleLinesMajorWidth = 2;
            this.battGauge.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.battGauge.ScaleLinesMinorInnerRadius = 55;
            this.battGauge.ScaleLinesMinorNumOf = 5;
            this.battGauge.ScaleLinesMinorOuterRadius = 60;
            this.battGauge.ScaleLinesMinorWidth = 1;
            this.battGauge.ScaleNumbersColor = System.Drawing.Color.White;
            this.battGauge.ScaleNumbersFormat = null;
            this.battGauge.ScaleNumbersRadius = 42;
            this.battGauge.ScaleNumbersRotation = 0;
            this.battGauge.ScaleNumbersStartScaleLine = 1;
            this.battGauge.ScaleNumbersStepScaleLines = 1;
            this.battGauge.Size = new System.Drawing.Size(185, 185);
            this.battGauge.TabIndex = 82;
            this.battGauge.Value = 0F;
            this.battGauge.Value0 = 0F;
            this.battGauge.Value1 = 0F;
            this.battGauge.Value2 = 0F;
            this.battGauge.Value3 = 0F;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 83;
            this.label1.Text = "Flight Battery";
            // 
            // ctrPultGauge
            // 
            this.ctrPultGauge.BackColor = System.Drawing.Color.Transparent;
            this.ctrPultGauge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrPultGauge.BackgroundImage")));
            this.ctrPultGauge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctrPultGauge.BaseArcColor = System.Drawing.Color.Transparent;
            this.ctrPultGauge.BaseArcRadius = 70;
            this.ctrPultGauge.BaseArcStart = 135;
            this.ctrPultGauge.BaseArcSweep = 270;
            this.ctrPultGauge.BaseArcWidth = 2;
            this.ctrPultGauge.Cap_Idx = ((byte)(2));
            this.ctrPultGauge.CapColor = System.Drawing.Color.White;
            this.ctrPultGauge.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.ctrPultGauge.CapPosition = new System.Drawing.Point(100, 100);
            this.ctrPultGauge.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(70, 85),
        new System.Drawing.Point(44, 100),
        new System.Drawing.Point(100, 100),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.ctrPultGauge.CapsText = new string[] {
        "%",
        "",
        "",
        "",
        ""};
            this.ctrPultGauge.CapText = "";
            this.ctrPultGauge.Center = new System.Drawing.Point(75, 75);
            this.ctrPultGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPultGauge.Location = new System.Drawing.Point(203, 42);
            this.ctrPultGauge.Margin = new System.Windows.Forms.Padding(0);
            this.ctrPultGauge.MaxValue = 100F;
            this.ctrPultGauge.MinValue = 0F;
            this.ctrPultGauge.Name = "ctrPultGauge";
            this.ctrPultGauge.Need_Idx = ((byte)(3));
            this.ctrPultGauge.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.ctrPultGauge.NeedleColor2 = System.Drawing.Color.Brown;
            this.ctrPultGauge.NeedleEnabled = false;
            this.ctrPultGauge.NeedleRadius = 70;
            this.ctrPultGauge.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.ctrPultGauge.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.ctrPultGauge.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.ctrPultGauge.NeedlesRadius = new int[] {
        60,
        50,
        70,
        70};
            this.ctrPultGauge.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.ctrPultGauge.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.ctrPultGauge.NeedleType = 0;
            this.ctrPultGauge.NeedleWidth = 2;
            this.ctrPultGauge.Range_Idx = ((byte)(1));
            this.ctrPultGauge.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ctrPultGauge.RangeEnabled = true;
            this.ctrPultGauge.RangeEndValue = 20F;
            this.ctrPultGauge.RangeInnerRadius = 60;
            this.ctrPultGauge.RangeOuterRadius = 70;
            this.ctrPultGauge.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Lime,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.SystemColors.Control};
            this.ctrPultGauge.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.ctrPultGauge.RangesEndValue = new float[] {
        10F,
        20F,
        100F,
        50F,
        0F};
            this.ctrPultGauge.RangesInnerRadius = new int[] {
        60,
        60,
        60,
        60,
        70};
            this.ctrPultGauge.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        70,
        80};
            this.ctrPultGauge.RangesStartValue = new float[] {
        0F,
        10F,
        20F,
        42F,
        0F};
            this.ctrPultGauge.RangeStartValue = 10F;
            this.ctrPultGauge.ScaleLinesInterColor = System.Drawing.Color.White;
            this.ctrPultGauge.ScaleLinesInterInnerRadius = 52;
            this.ctrPultGauge.ScaleLinesInterOuterRadius = 60;
            this.ctrPultGauge.ScaleLinesInterWidth = 1;
            this.ctrPultGauge.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.ctrPultGauge.ScaleLinesMajorInnerRadius = 50;
            this.ctrPultGauge.ScaleLinesMajorOuterRadius = 60;
            this.ctrPultGauge.ScaleLinesMajorStepValue = 20F;
            this.ctrPultGauge.ScaleLinesMajorWidth = 2;
            this.ctrPultGauge.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.ctrPultGauge.ScaleLinesMinorInnerRadius = 55;
            this.ctrPultGauge.ScaleLinesMinorNumOf = 9;
            this.ctrPultGauge.ScaleLinesMinorOuterRadius = 60;
            this.ctrPultGauge.ScaleLinesMinorWidth = 1;
            this.ctrPultGauge.ScaleNumbersColor = System.Drawing.Color.White;
            this.ctrPultGauge.ScaleNumbersFormat = null;
            this.ctrPultGauge.ScaleNumbersRadius = 42;
            this.ctrPultGauge.ScaleNumbersRotation = 0;
            this.ctrPultGauge.ScaleNumbersStartScaleLine = 1;
            this.ctrPultGauge.ScaleNumbersStepScaleLines = 1;
            this.ctrPultGauge.Size = new System.Drawing.Size(185, 185);
            this.ctrPultGauge.TabIndex = 84;
            this.ctrPultGauge.Value = 40F;
            this.ctrPultGauge.Value0 = 28.6F;
            this.ctrPultGauge.Value1 = 0F;
            this.ctrPultGauge.Value2 = 0F;
            this.ctrPultGauge.Value3 = 40F;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 85;
            this.label2.Text = "Control Pult Battery";
            // 
            // batteryStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 238);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrPultGauge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.battGauge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "batteryStatusForm";
            this.Text = "batteryStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AGaugeApp.AGauge battGauge;
        private System.Windows.Forms.Label label1;
        private AGaugeApp.AGauge ctrPultGauge;
        private System.Windows.Forms.Label label2;
    }
}
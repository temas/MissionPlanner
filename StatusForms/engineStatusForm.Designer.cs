namespace MissionPlanner.StatusForms
{
    partial class engineStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(engineStatusForm));
            this.Gspeed = new AGaugeApp.AGauge();
            this.aGauge1 = new AGaugeApp.AGauge();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.myButtonNoTheme1 = new MissionPlanner.Controls.myButtonNoTheme();
            this.myButtonNoTheme2 = new MissionPlanner.Controls.myButtonNoTheme();
            this.SuspendLayout();
            // 
            // Gspeed
            // 
            this.Gspeed.BackColor = System.Drawing.Color.Transparent;
            this.Gspeed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Gspeed.BackgroundImage")));
            this.Gspeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Gspeed.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gspeed.BaseArcRadius = 70;
            this.Gspeed.BaseArcStart = 135;
            this.Gspeed.BaseArcSweep = 270;
            this.Gspeed.BaseArcWidth = 2;
            this.Gspeed.Cap_Idx = ((byte)(1));
            this.Gspeed.CapColor = System.Drawing.Color.White;
            this.Gspeed.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gspeed.CapPosition = new System.Drawing.Point(62, 110);
            this.Gspeed.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(47, 85),
        new System.Drawing.Point(62, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gspeed.CapsText = new string[] {
        "RPM x1000",
        "28600",
        "",
        "",
        ""};
            this.Gspeed.CapText = "28600";
            this.Gspeed.Center = new System.Drawing.Point(75, 75);
            this.Gspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gspeed.Location = new System.Drawing.Point(9, 9);
            this.Gspeed.Margin = new System.Windows.Forms.Padding(0);
            this.Gspeed.MaxValue = 135F;
            this.Gspeed.MinValue = 0F;
            this.Gspeed.Name = "Gspeed";
            this.Gspeed.Need_Idx = ((byte)(3));
            this.Gspeed.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gspeed.NeedleColor2 = System.Drawing.Color.Brown;
            this.Gspeed.NeedleEnabled = false;
            this.Gspeed.NeedleRadius = 70;
            this.Gspeed.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gspeed.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.Gspeed.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.Gspeed.NeedlesRadius = new int[] {
        60,
        50,
        70,
        70};
            this.Gspeed.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gspeed.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.Gspeed.NeedleType = 0;
            this.Gspeed.NeedleWidth = 2;
            this.Gspeed.Range_Idx = ((byte)(2));
            this.Gspeed.RangeColor = System.Drawing.Color.Orange;
            this.Gspeed.RangeEnabled = true;
            this.Gspeed.RangeEndValue = 120F;
            this.Gspeed.RangeInnerRadius = 60;
            this.Gspeed.RangeOuterRadius = 70;
            this.Gspeed.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Lime,
        System.Drawing.Color.Orange,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.SystemColors.Control};
            this.Gspeed.RangesEnabled = new bool[] {
        true,
        true,
        true,
        true,
        false};
            this.Gspeed.RangesEndValue = new float[] {
        20F,
        90F,
        120F,
        135F,
        0F};
            this.Gspeed.RangesInnerRadius = new int[] {
        60,
        60,
        60,
        60,
        70};
            this.Gspeed.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        70,
        80};
            this.Gspeed.RangesStartValue = new float[] {
        0F,
        20F,
        90F,
        120F,
        0F};
            this.Gspeed.RangeStartValue = 90F;
            this.Gspeed.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesInterInnerRadius = 52;
            this.Gspeed.ScaleLinesInterOuterRadius = 60;
            this.Gspeed.ScaleLinesInterWidth = 1;
            this.Gspeed.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesMajorInnerRadius = 50;
            this.Gspeed.ScaleLinesMajorOuterRadius = 60;
            this.Gspeed.ScaleLinesMajorStepValue = 15F;
            this.Gspeed.ScaleLinesMajorWidth = 2;
            this.Gspeed.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesMinorInnerRadius = 55;
            this.Gspeed.ScaleLinesMinorNumOf = 9;
            this.Gspeed.ScaleLinesMinorOuterRadius = 60;
            this.Gspeed.ScaleLinesMinorWidth = 1;
            this.Gspeed.ScaleNumbersColor = System.Drawing.Color.White;
            this.Gspeed.ScaleNumbersFormat = null;
            this.Gspeed.ScaleNumbersRadius = 42;
            this.Gspeed.ScaleNumbersRotation = 0;
            this.Gspeed.ScaleNumbersStartScaleLine = 1;
            this.Gspeed.ScaleNumbersStepScaleLines = 1;
            this.Gspeed.Size = new System.Drawing.Size(209, 209);
            this.Gspeed.TabIndex = 80;
            this.Gspeed.Value = 40F;
            this.Gspeed.Value0 = 28.6F;
            this.Gspeed.Value1 = 0F;
            this.Gspeed.Value2 = 0F;
            this.Gspeed.Value3 = 40F;
            // 
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.Color.Transparent;
            this.aGauge1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aGauge1.BackgroundImage")));
            this.aGauge1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aGauge1.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge1.BaseArcRadius = 70;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Cap_Idx = ((byte)(0));
            this.aGauge1.CapColor = System.Drawing.Color.White;
            this.aGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CapPosition = new System.Drawing.Point(47, 85);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(47, 85),
        new System.Drawing.Point(62, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "EXH. TEMP",
        "364 C°",
        "",
        "",
        ""};
            this.aGauge1.CapText = "EXH. TEMP";
            this.aGauge1.Center = new System.Drawing.Point(75, 75);
            this.aGauge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge1.Location = new System.Drawing.Point(218, 9);
            this.aGauge1.Margin = new System.Windows.Forms.Padding(0);
            this.aGauge1.MaxValue = 750F;
            this.aGauge1.MinValue = 150F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.Need_Idx = ((byte)(3));
            this.aGauge1.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.Brown;
            this.aGauge1.NeedleEnabled = false;
            this.aGauge1.NeedleRadius = 70;
            this.aGauge1.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge1.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.aGauge1.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.aGauge1.NeedlesRadius = new int[] {
        60,
        50,
        70,
        70};
            this.aGauge1.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge1.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.Range_Idx = ((byte)(2));
            this.aGauge1.RangeColor = System.Drawing.Color.Orange;
            this.aGauge1.RangeEnabled = true;
            this.aGauge1.RangeEndValue = 650F;
            this.aGauge1.RangeInnerRadius = 60;
            this.aGauge1.RangeOuterRadius = 70;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Lime,
        System.Drawing.Color.Orange,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        true,
        true,
        true,
        true,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        250F,
        550F,
        650F,
        750F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        60,
        60,
        60,
        60,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        70,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        150F,
        250F,
        550F,
        650F,
        0F};
            this.aGauge1.RangeStartValue = 550F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge1.ScaleLinesInterInnerRadius = 52;
            this.aGauge1.ScaleLinesInterOuterRadius = 60;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge1.ScaleLinesMajorInnerRadius = 50;
            this.aGauge1.ScaleLinesMajorOuterRadius = 60;
            this.aGauge1.ScaleLinesMajorStepValue = 150F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge1.ScaleLinesMinorInnerRadius = 55;
            this.aGauge1.ScaleLinesMinorNumOf = 5;
            this.aGauge1.ScaleLinesMinorOuterRadius = 60;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 42;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 1;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(209, 209);
            this.aGauge1.TabIndex = 81;
            this.aGauge1.Value = 40F;
            this.aGauge1.Value0 = 340F;
            this.aGauge1.Value1 = 0F;
            this.aGauge1.Value2 = 0F;
            this.aGauge1.Value3 = 40F;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(9, 221);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 130);
            this.textBox1.TabIndex = 83;
            this.textBox1.Text = "Engine flameout!\r\nRestart in progress...";
            // 
            // myButtonNoTheme1
            // 
            this.myButtonNoTheme1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButtonNoTheme1.Location = new System.Drawing.Point(225, 227);
            this.myButtonNoTheme1.Name = "myButtonNoTheme1";
            this.myButtonNoTheme1.Size = new System.Drawing.Size(201, 47);
            this.myButtonNoTheme1.TabIndex = 87;
            this.myButtonNoTheme1.Text = "START ENGINE";
            this.myButtonNoTheme1.UseVisualStyleBackColor = true;
            // 
            // myButtonNoTheme2
            // 
            this.myButtonNoTheme2.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.myButtonNoTheme2.BGGradTop = System.Drawing.Color.Red;
            this.myButtonNoTheme2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButtonNoTheme2.Location = new System.Drawing.Point(226, 304);
            this.myButtonNoTheme2.Name = "myButtonNoTheme2";
            this.myButtonNoTheme2.Outline = System.Drawing.Color.Red;
            this.myButtonNoTheme2.Size = new System.Drawing.Size(201, 47);
            this.myButtonNoTheme2.TabIndex = 88;
            this.myButtonNoTheme2.Text = "STOP ENGINE";
            this.myButtonNoTheme2.TextColor = System.Drawing.Color.White;
            this.myButtonNoTheme2.UseVisualStyleBackColor = true;
            // 
            // engineStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 363);
            this.Controls.Add(this.myButtonNoTheme2);
            this.Controls.Add(this.myButtonNoTheme1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.Gspeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "engineStatusForm";
            this.Text = "engineStatusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AGaugeApp.AGauge Gspeed;
        private AGaugeApp.AGauge aGauge1;
        private System.Windows.Forms.TextBox textBox1;
        private Controls.myButtonNoTheme myButtonNoTheme1;
        private Controls.myButtonNoTheme myButtonNoTheme2;
    }
}
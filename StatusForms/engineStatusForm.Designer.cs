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
            this.engineRpmGauge = new AGaugeApp.AGauge();
            this.engineTempGauge = new AGaugeApp.AGauge();
            this.engineStatusText = new System.Windows.Forms.TextBox();
            this.myButtonNoTheme1 = new MissionPlanner.Controls.myButtonNoTheme();
            this.myButtonNoTheme2 = new MissionPlanner.Controls.myButtonNoTheme();
            this.btnArmVehicle = new MissionPlanner.Controls.myButtonNoTheme();
            this.SuspendLayout();
            // 
            // engineRpmGauge
            // 
            this.engineRpmGauge.BackColor = System.Drawing.Color.Transparent;
            this.engineRpmGauge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("engineRpmGauge.BackgroundImage")));
            this.engineRpmGauge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.engineRpmGauge.BaseArcColor = System.Drawing.Color.Transparent;
            this.engineRpmGauge.BaseArcRadius = 70;
            this.engineRpmGauge.BaseArcStart = 135;
            this.engineRpmGauge.BaseArcSweep = 270;
            this.engineRpmGauge.BaseArcWidth = 2;
            this.engineRpmGauge.Cap_Idx = ((byte)(1));
            this.engineRpmGauge.CapColor = System.Drawing.Color.White;
            this.engineRpmGauge.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.engineRpmGauge.CapPosition = new System.Drawing.Point(62, 110);
            this.engineRpmGauge.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(47, 85),
        new System.Drawing.Point(62, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.engineRpmGauge.CapsText = new string[] {
        "RPM x1000",
        "28600",
        "",
        "",
        ""};
            this.engineRpmGauge.CapText = "28600";
            this.engineRpmGauge.Center = new System.Drawing.Point(75, 75);
            this.engineRpmGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineRpmGauge.Location = new System.Drawing.Point(9, 9);
            this.engineRpmGauge.Margin = new System.Windows.Forms.Padding(0);
            this.engineRpmGauge.MaxValue = 135F;
            this.engineRpmGauge.MinValue = 0F;
            this.engineRpmGauge.Name = "engineRpmGauge";
            this.engineRpmGauge.Need_Idx = ((byte)(0));
            this.engineRpmGauge.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Red;
            this.engineRpmGauge.NeedleColor2 = System.Drawing.Color.White;
            this.engineRpmGauge.NeedleEnabled = true;
            this.engineRpmGauge.NeedleRadius = 60;
            this.engineRpmGauge.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.engineRpmGauge.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.engineRpmGauge.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.engineRpmGauge.NeedlesRadius = new int[] {
        60,
        50,
        70,
        70};
            this.engineRpmGauge.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.engineRpmGauge.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.engineRpmGauge.NeedleType = 0;
            this.engineRpmGauge.NeedleWidth = 2;
            this.engineRpmGauge.Range_Idx = ((byte)(2));
            this.engineRpmGauge.RangeColor = System.Drawing.Color.Orange;
            this.engineRpmGauge.RangeEnabled = true;
            this.engineRpmGauge.RangeEndValue = 120F;
            this.engineRpmGauge.RangeInnerRadius = 60;
            this.engineRpmGauge.RangeOuterRadius = 70;
            this.engineRpmGauge.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Lime,
        System.Drawing.Color.Orange,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.SystemColors.Control};
            this.engineRpmGauge.RangesEnabled = new bool[] {
        true,
        true,
        true,
        true,
        false};
            this.engineRpmGauge.RangesEndValue = new float[] {
        20F,
        90F,
        120F,
        135F,
        0F};
            this.engineRpmGauge.RangesInnerRadius = new int[] {
        60,
        60,
        60,
        60,
        70};
            this.engineRpmGauge.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        70,
        80};
            this.engineRpmGauge.RangesStartValue = new float[] {
        0F,
        20F,
        90F,
        120F,
        0F};
            this.engineRpmGauge.RangeStartValue = 90F;
            this.engineRpmGauge.ScaleLinesInterColor = System.Drawing.Color.White;
            this.engineRpmGauge.ScaleLinesInterInnerRadius = 52;
            this.engineRpmGauge.ScaleLinesInterOuterRadius = 60;
            this.engineRpmGauge.ScaleLinesInterWidth = 1;
            this.engineRpmGauge.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.engineRpmGauge.ScaleLinesMajorInnerRadius = 50;
            this.engineRpmGauge.ScaleLinesMajorOuterRadius = 60;
            this.engineRpmGauge.ScaleLinesMajorStepValue = 15F;
            this.engineRpmGauge.ScaleLinesMajorWidth = 2;
            this.engineRpmGauge.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.engineRpmGauge.ScaleLinesMinorInnerRadius = 55;
            this.engineRpmGauge.ScaleLinesMinorNumOf = 9;
            this.engineRpmGauge.ScaleLinesMinorOuterRadius = 60;
            this.engineRpmGauge.ScaleLinesMinorWidth = 1;
            this.engineRpmGauge.ScaleNumbersColor = System.Drawing.Color.White;
            this.engineRpmGauge.ScaleNumbersFormat = null;
            this.engineRpmGauge.ScaleNumbersRadius = 42;
            this.engineRpmGauge.ScaleNumbersRotation = 0;
            this.engineRpmGauge.ScaleNumbersStartScaleLine = 1;
            this.engineRpmGauge.ScaleNumbersStepScaleLines = 1;
            this.engineRpmGauge.Size = new System.Drawing.Size(209, 209);
            this.engineRpmGauge.TabIndex = 80;
            this.engineRpmGauge.Value = 0F;
            this.engineRpmGauge.Value0 = 0F;
            this.engineRpmGauge.Value1 = 0F;
            this.engineRpmGauge.Value2 = 0F;
            this.engineRpmGauge.Value3 = 40F;
            // 
            // engineTempGauge
            // 
            this.engineTempGauge.BackColor = System.Drawing.Color.Transparent;
            this.engineTempGauge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("engineTempGauge.BackgroundImage")));
            this.engineTempGauge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.engineTempGauge.BaseArcColor = System.Drawing.Color.Transparent;
            this.engineTempGauge.BaseArcRadius = 70;
            this.engineTempGauge.BaseArcStart = 135;
            this.engineTempGauge.BaseArcSweep = 270;
            this.engineTempGauge.BaseArcWidth = 2;
            this.engineTempGauge.Cap_Idx = ((byte)(1));
            this.engineTempGauge.CapColor = System.Drawing.Color.White;
            this.engineTempGauge.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.engineTempGauge.CapPosition = new System.Drawing.Point(62, 110);
            this.engineTempGauge.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(47, 85),
        new System.Drawing.Point(62, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.engineTempGauge.CapsText = new string[] {
        "EXH. TEMP",
        "364 C°",
        "",
        "",
        ""};
            this.engineTempGauge.CapText = "364 C°";
            this.engineTempGauge.Center = new System.Drawing.Point(75, 75);
            this.engineTempGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineTempGauge.Location = new System.Drawing.Point(218, 9);
            this.engineTempGauge.Margin = new System.Windows.Forms.Padding(0);
            this.engineTempGauge.MaxValue = 750F;
            this.engineTempGauge.MinValue = 150F;
            this.engineTempGauge.Name = "engineTempGauge";
            this.engineTempGauge.Need_Idx = ((byte)(0));
            this.engineTempGauge.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Red;
            this.engineTempGauge.NeedleColor2 = System.Drawing.Color.White;
            this.engineTempGauge.NeedleEnabled = true;
            this.engineTempGauge.NeedleRadius = 60;
            this.engineTempGauge.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.engineTempGauge.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.engineTempGauge.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.engineTempGauge.NeedlesRadius = new int[] {
        60,
        50,
        70,
        70};
            this.engineTempGauge.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.engineTempGauge.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.engineTempGauge.NeedleType = 0;
            this.engineTempGauge.NeedleWidth = 2;
            this.engineTempGauge.Range_Idx = ((byte)(2));
            this.engineTempGauge.RangeColor = System.Drawing.Color.Orange;
            this.engineTempGauge.RangeEnabled = true;
            this.engineTempGauge.RangeEndValue = 650F;
            this.engineTempGauge.RangeInnerRadius = 60;
            this.engineTempGauge.RangeOuterRadius = 70;
            this.engineTempGauge.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Lime,
        System.Drawing.Color.Orange,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.SystemColors.Control};
            this.engineTempGauge.RangesEnabled = new bool[] {
        true,
        true,
        true,
        true,
        false};
            this.engineTempGauge.RangesEndValue = new float[] {
        250F,
        550F,
        650F,
        750F,
        0F};
            this.engineTempGauge.RangesInnerRadius = new int[] {
        60,
        60,
        60,
        60,
        70};
            this.engineTempGauge.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        70,
        80};
            this.engineTempGauge.RangesStartValue = new float[] {
        150F,
        250F,
        550F,
        650F,
        0F};
            this.engineTempGauge.RangeStartValue = 550F;
            this.engineTempGauge.ScaleLinesInterColor = System.Drawing.Color.White;
            this.engineTempGauge.ScaleLinesInterInnerRadius = 52;
            this.engineTempGauge.ScaleLinesInterOuterRadius = 60;
            this.engineTempGauge.ScaleLinesInterWidth = 1;
            this.engineTempGauge.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.engineTempGauge.ScaleLinesMajorInnerRadius = 50;
            this.engineTempGauge.ScaleLinesMajorOuterRadius = 60;
            this.engineTempGauge.ScaleLinesMajorStepValue = 150F;
            this.engineTempGauge.ScaleLinesMajorWidth = 2;
            this.engineTempGauge.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.engineTempGauge.ScaleLinesMinorInnerRadius = 55;
            this.engineTempGauge.ScaleLinesMinorNumOf = 5;
            this.engineTempGauge.ScaleLinesMinorOuterRadius = 60;
            this.engineTempGauge.ScaleLinesMinorWidth = 1;
            this.engineTempGauge.ScaleNumbersColor = System.Drawing.Color.White;
            this.engineTempGauge.ScaleNumbersFormat = null;
            this.engineTempGauge.ScaleNumbersRadius = 42;
            this.engineTempGauge.ScaleNumbersRotation = 0;
            this.engineTempGauge.ScaleNumbersStartScaleLine = 1;
            this.engineTempGauge.ScaleNumbersStepScaleLines = 1;
            this.engineTempGauge.Size = new System.Drawing.Size(209, 209);
            this.engineTempGauge.TabIndex = 81;
            this.engineTempGauge.Value = 150F;
            this.engineTempGauge.Value0 = 150F;
            this.engineTempGauge.Value1 = 0F;
            this.engineTempGauge.Value2 = 0F;
            this.engineTempGauge.Value3 = 40F;
            // 
            // engineStatusText
            // 
            this.engineStatusText.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineStatusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.engineStatusText.Location = new System.Drawing.Point(9, 221);
            this.engineStatusText.Multiline = true;
            this.engineStatusText.Name = "engineStatusText";
            this.engineStatusText.Size = new System.Drawing.Size(209, 219);
            this.engineStatusText.TabIndex = 83;
            // 
            // myButtonNoTheme1
            // 
            this.myButtonNoTheme1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButtonNoTheme1.Location = new System.Drawing.Point(225, 305);
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
            this.myButtonNoTheme2.Location = new System.Drawing.Point(224, 393);
            this.myButtonNoTheme2.Name = "myButtonNoTheme2";
            this.myButtonNoTheme2.Outline = System.Drawing.Color.Red;
            this.myButtonNoTheme2.Size = new System.Drawing.Size(201, 47);
            this.myButtonNoTheme2.TabIndex = 88;
            this.myButtonNoTheme2.Text = "STOP ENGINE";
            this.myButtonNoTheme2.TextColor = System.Drawing.Color.White;
            this.myButtonNoTheme2.UseVisualStyleBackColor = true;
            // 
            // btnArmVehicle
            // 
            this.btnArmVehicle.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnArmVehicle.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnArmVehicle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArmVehicle.Location = new System.Drawing.Point(225, 221);
            this.btnArmVehicle.Name = "btnArmVehicle";
            this.btnArmVehicle.Size = new System.Drawing.Size(201, 47);
            this.btnArmVehicle.TabIndex = 89;
            this.btnArmVehicle.Text = "ARM VEHICLE";
            this.btnArmVehicle.UseVisualStyleBackColor = true;
            this.btnArmVehicle.Click += new System.EventHandler(this.btnArmVehicle_Click);
            // 
            // engineStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 452);
            this.Controls.Add(this.btnArmVehicle);
            this.Controls.Add(this.myButtonNoTheme2);
            this.Controls.Add(this.myButtonNoTheme1);
            this.Controls.Add(this.engineStatusText);
            this.Controls.Add(this.engineTempGauge);
            this.Controls.Add(this.engineRpmGauge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "engineStatusForm";
            this.Text = "engineStatusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AGaugeApp.AGauge engineRpmGauge;
        private AGaugeApp.AGauge engineTempGauge;
        private System.Windows.Forms.TextBox engineStatusText;
        private Controls.myButtonNoTheme myButtonNoTheme1;
        private Controls.myButtonNoTheme myButtonNoTheme2;
        private Controls.myButtonNoTheme btnArmVehicle;
    }
}
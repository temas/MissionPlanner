
namespace MissionPlanner.StatusForms
{
    partial class fuelStatusForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fuelStatusForm));
            this.gaugeFuelLevel = new AGaugeApp.AGauge();
            this.bindingSourceFuelForm = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFuelForm)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugeFuelLevel
            // 
            this.gaugeFuelLevel.BackColor = System.Drawing.Color.Transparent;
            this.gaugeFuelLevel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gaugeFuelLevel.BackgroundImage")));
            this.gaugeFuelLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gaugeFuelLevel.BaseArcColor = System.Drawing.Color.Transparent;
            this.gaugeFuelLevel.BaseArcRadius = 70;
            this.gaugeFuelLevel.BaseArcStart = 135;
            this.gaugeFuelLevel.BaseArcSweep = 270;
            this.gaugeFuelLevel.BaseArcWidth = 2;
            this.gaugeFuelLevel.Cap_Idx = ((byte)(0));
            this.gaugeFuelLevel.CapColor = System.Drawing.Color.White;
            this.gaugeFuelLevel.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.gaugeFuelLevel.CapPosition = new System.Drawing.Point(43, 50);
            this.gaugeFuelLevel.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(43, 50),
        new System.Drawing.Point(44, 100),
        new System.Drawing.Point(100, 100),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.gaugeFuelLevel.CapsText = new string[] {
        "FUEL LEVEL",
        "E",
        "F",
        "",
        ""};
            this.gaugeFuelLevel.CapText = "FUEL LEVEL";
            this.gaugeFuelLevel.Center = new System.Drawing.Point(75, 75);
            this.gaugeFuelLevel.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSourceFuelForm, "fuelLevel", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.gaugeFuelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaugeFuelLevel.Location = new System.Drawing.Point(9, 9);
            this.gaugeFuelLevel.Margin = new System.Windows.Forms.Padding(0);
            this.gaugeFuelLevel.MaxValue = 100F;
            this.gaugeFuelLevel.MinValue = 0F;
            this.gaugeFuelLevel.Name = "gaugeFuelLevel";
            this.gaugeFuelLevel.Need_Idx = ((byte)(3));
            this.gaugeFuelLevel.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.gaugeFuelLevel.NeedleColor2 = System.Drawing.Color.Brown;
            this.gaugeFuelLevel.NeedleEnabled = false;
            this.gaugeFuelLevel.NeedleRadius = 70;
            this.gaugeFuelLevel.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.gaugeFuelLevel.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.gaugeFuelLevel.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.gaugeFuelLevel.NeedlesRadius = new int[] {
        60,
        50,
        70,
        70};
            this.gaugeFuelLevel.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.gaugeFuelLevel.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.gaugeFuelLevel.NeedleType = 0;
            this.gaugeFuelLevel.NeedleWidth = 2;
            this.gaugeFuelLevel.Range_Idx = ((byte)(2));
            this.gaugeFuelLevel.RangeColor = System.Drawing.Color.Lime;
            this.gaugeFuelLevel.RangeEnabled = true;
            this.gaugeFuelLevel.RangeEndValue = 100F;
            this.gaugeFuelLevel.RangeInnerRadius = 60;
            this.gaugeFuelLevel.RangeOuterRadius = 70;
            this.gaugeFuelLevel.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Lime,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.SystemColors.Control};
            this.gaugeFuelLevel.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.gaugeFuelLevel.RangesEndValue = new float[] {
        15F,
        30F,
        100F,
        50F,
        0F};
            this.gaugeFuelLevel.RangesInnerRadius = new int[] {
        60,
        60,
        60,
        60,
        70};
            this.gaugeFuelLevel.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        70,
        80};
            this.gaugeFuelLevel.RangesStartValue = new float[] {
        0F,
        15F,
        30F,
        42F,
        0F};
            this.gaugeFuelLevel.RangeStartValue = 30F;
            this.gaugeFuelLevel.ScaleLinesInterColor = System.Drawing.Color.White;
            this.gaugeFuelLevel.ScaleLinesInterInnerRadius = 52;
            this.gaugeFuelLevel.ScaleLinesInterOuterRadius = 60;
            this.gaugeFuelLevel.ScaleLinesInterWidth = 1;
            this.gaugeFuelLevel.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.gaugeFuelLevel.ScaleLinesMajorInnerRadius = 50;
            this.gaugeFuelLevel.ScaleLinesMajorOuterRadius = 60;
            this.gaugeFuelLevel.ScaleLinesMajorStepValue = 10F;
            this.gaugeFuelLevel.ScaleLinesMajorWidth = 2;
            this.gaugeFuelLevel.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.gaugeFuelLevel.ScaleLinesMinorInnerRadius = 55;
            this.gaugeFuelLevel.ScaleLinesMinorNumOf = 9;
            this.gaugeFuelLevel.ScaleLinesMinorOuterRadius = 60;
            this.gaugeFuelLevel.ScaleLinesMinorWidth = 1;
            this.gaugeFuelLevel.ScaleNumbersColor = System.Drawing.Color.Transparent;
            this.gaugeFuelLevel.ScaleNumbersFormat = null;
            this.gaugeFuelLevel.ScaleNumbersRadius = 42;
            this.gaugeFuelLevel.ScaleNumbersRotation = 0;
            this.gaugeFuelLevel.ScaleNumbersStartScaleLine = 1;
            this.gaugeFuelLevel.ScaleNumbersStepScaleLines = 1;
            this.gaugeFuelLevel.Size = new System.Drawing.Size(209, 209);
            this.gaugeFuelLevel.TabIndex = 81;
            this.gaugeFuelLevel.Value = 40F;
            this.gaugeFuelLevel.Value0 = 0F;
            this.gaugeFuelLevel.Value1 = 0F;
            this.gaugeFuelLevel.Value2 = 0F;
            this.gaugeFuelLevel.Value3 = 40F;
            // 
            // bindingSourceFuelForm
            // 
            this.bindingSourceFuelForm.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // fuelStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 228);
            this.Controls.Add(this.gaugeFuelLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fuelStatusForm";
            this.Text = "fuelStatusForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFuelForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AGaugeApp.AGauge gaugeFuelLevel;
        public System.Windows.Forms.BindingSource bindingSourceFuelForm;
    }
}
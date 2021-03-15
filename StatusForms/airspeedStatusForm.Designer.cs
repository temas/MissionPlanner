
namespace MissionPlanner.StatusForms
{
    partial class airspeedStatusForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lAirSpeed = new System.Windows.Forms.Label();
            this.bindingSourceAirpseedForm = new System.Windows.Forms.BindingSource(this.components);
            this.lAirSpeedError = new System.Windows.Forms.Label();
            this.lGroundSpeed = new System.Windows.Forms.Label();
            this.bDoPreflight = new MissionPlanner.Controls.myButtonNoTheme();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAirpseedForm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Airspeed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Groundspeed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Airspeed error:";
            // 
            // lAirSpeed
            // 
            this.lAirSpeed.AutoSize = true;
            this.lAirSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceAirpseedForm, "airspeed", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "N1"));
            this.lAirSpeed.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAirSpeed.Location = new System.Drawing.Point(138, 9);
            this.lAirSpeed.Name = "lAirSpeed";
            this.lAirSpeed.Size = new System.Drawing.Size(37, 23);
            this.lAirSpeed.TabIndex = 3;
            this.lAirSpeed.Text = "000";
            // 
            // bindingSourceAirpseedForm
            // 
            this.bindingSourceAirpseedForm.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // lAirSpeedError
            // 
            this.lAirSpeedError.AutoSize = true;
            this.lAirSpeedError.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceAirpseedForm, "aspd_error", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "N1"));
            this.lAirSpeedError.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAirSpeedError.Location = new System.Drawing.Point(138, 55);
            this.lAirSpeedError.Name = "lAirSpeedError";
            this.lAirSpeedError.Size = new System.Drawing.Size(37, 23);
            this.lAirSpeedError.TabIndex = 4;
            this.lAirSpeedError.Text = "000";
            // 
            // lGroundSpeed
            // 
            this.lGroundSpeed.AutoSize = true;
            this.lGroundSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceAirpseedForm, "groundspeed", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "N1"));
            this.lGroundSpeed.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGroundSpeed.Location = new System.Drawing.Point(138, 32);
            this.lGroundSpeed.Name = "lGroundSpeed";
            this.lGroundSpeed.Size = new System.Drawing.Size(37, 23);
            this.lGroundSpeed.TabIndex = 5;
            this.lGroundSpeed.Text = "000";
            // 
            // bDoPreflight
            // 
            this.bDoPreflight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDoPreflight.Location = new System.Drawing.Point(226, 12);
            this.bDoPreflight.Name = "bDoPreflight";
            this.bDoPreflight.Size = new System.Drawing.Size(242, 66);
            this.bDoPreflight.TabIndex = 6;
            this.bDoPreflight.Text = "PREFLIGHT CALIBRATION";
            this.bDoPreflight.UseVisualStyleBackColor = true;
            this.bDoPreflight.Click += new System.EventHandler(this.bDoPreflight_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 94);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 205);
            this.textBox1.TabIndex = 7;
            // 
            // airspeedStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 317);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bDoPreflight);
            this.Controls.Add(this.lGroundSpeed);
            this.Controls.Add(this.lAirSpeedError);
            this.Controls.Add(this.lAirSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "airspeedStatusForm";
            this.Text = "airspeedStatusForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAirpseedForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lAirSpeed;
        private System.Windows.Forms.Label lAirSpeedError;
        private System.Windows.Forms.Label lGroundSpeed;
        private Controls.myButtonNoTheme bDoPreflight;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.BindingSource bindingSourceAirpseedForm;
    }
}

namespace MissionPlanner.StatusForms
{
    partial class chuteStatusForm
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
            this.bAirspeed = new MissionPlanner.Controls.myButtonNoTheme();
            this.bFuel = new MissionPlanner.Controls.myButtonNoTheme();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new MissionPlanner.Controls.myButtonNoTheme();
            this.btnExecute = new MissionPlanner.Controls.myButtonNoTheme();
            this.SuspendLayout();
            // 
            // bAirspeed
            // 
            this.bAirspeed.Enabled = false;
            this.bAirspeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAirspeed.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAirspeed.Location = new System.Drawing.Point(16, 49);
            this.bAirspeed.Name = "bAirspeed";
            this.bAirspeed.Size = new System.Drawing.Size(220, 54);
            this.bAirspeed.TabIndex = 0;
            this.bAirspeed.Text = "AIRSPEED TOO HIGH";
            this.bAirspeed.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bAirspeed.UseVisualStyleBackColor = true;
            // 
            // bFuel
            // 
            this.bFuel.Enabled = false;
            this.bFuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFuel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFuel.Location = new System.Drawing.Point(16, 109);
            this.bFuel.Name = "bFuel";
            this.bFuel.Size = new System.Drawing.Size(220, 54);
            this.bFuel.TabIndex = 1;
            this.bFuel.Text = "FUEL LEVEL TOO HIGH";
            this.bFuel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bFuel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANUAL PARACHUTE OPEN";
            // 
            // btnStart
            // 
            this.btnStart.BGGradBot = System.Drawing.Color.Gray;
            this.btnStart.BGGradTop = System.Drawing.Color.Gray;
            this.btnStart.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(16, 217);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(220, 54);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "SELECT TO OPEN";
            this.btnStart.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.BGGradBot = System.Drawing.Color.Gray;
            this.btnExecute.BGGradTop = System.Drawing.Color.Gray;
            this.btnExecute.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(16, 307);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(220, 54);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "EXECUTE";
            this.btnExecute.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // chuteStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 381);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bFuel);
            this.Controls.Add(this.bAirspeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chuteStatusForm";
            this.Text = "chuteStatusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.myButtonNoTheme bAirspeed;
        private Controls.myButtonNoTheme bFuel;
        private System.Windows.Forms.Label label1;
        private Controls.myButtonNoTheme btnStart;
        private Controls.myButtonNoTheme btnExecute;
    }
}
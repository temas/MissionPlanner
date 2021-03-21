
namespace MissionPlanner.StatusForms
{
    partial class payloadStatusForm
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
            this.pinStatusButton = new MissionPlanner.Controls.myButtonNoTheme();
            this.payloadsetup1 = new MissionPlanner.Controls.payloadsetup();
            this.payloadSetupButton = new MissionPlanner.Controls.myButtonNoTheme();
            this.SuspendLayout();
            // 
            // pinStatusButton
            // 
            this.pinStatusButton.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pinStatusButton.BGGradTop = System.Drawing.Color.Red;
            this.pinStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pinStatusButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinStatusButton.Location = new System.Drawing.Point(12, 12);
            this.pinStatusButton.Name = "pinStatusButton";
            this.pinStatusButton.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pinStatusButton.Size = new System.Drawing.Size(404, 44);
            this.pinStatusButton.TabIndex = 0;
            this.pinStatusButton.Text = "SAFETY PIN IN PLACE";
            this.pinStatusButton.TextColor = System.Drawing.Color.White;
            this.pinStatusButton.UseVisualStyleBackColor = true;
            // 
            // payloadsetup1
            // 
            this.payloadsetup1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.payloadsetup1.Location = new System.Drawing.Point(12, 122);
            this.payloadsetup1.Name = "payloadsetup1";
            this.payloadsetup1.Size = new System.Drawing.Size(404, 411);
            this.payloadsetup1.TabIndex = 1;
            this.payloadsetup1.igniteClicked += new System.EventHandler(this.payloadsetup1_igniteClicked);
            // 
            // payloadSetupButton
            // 
            this.payloadSetupButton.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.payloadSetupButton.BGGradTop = System.Drawing.Color.Lime;
            this.payloadSetupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payloadSetupButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payloadSetupButton.Location = new System.Drawing.Point(12, 72);
            this.payloadSetupButton.Name = "payloadSetupButton";
            this.payloadSetupButton.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.payloadSetupButton.Size = new System.Drawing.Size(404, 44);
            this.payloadSetupButton.TabIndex = 2;
            this.payloadSetupButton.Text = "RECONFIGURE PAYLOADS";
            this.payloadSetupButton.TextColor = System.Drawing.Color.White;
            this.payloadSetupButton.UseVisualStyleBackColor = true;
            this.payloadSetupButton.Click += new System.EventHandler(this.payloadSetupButton_Click);
            // 
            // payloadStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(428, 545);
            this.Controls.Add(this.payloadSetupButton);
            this.Controls.Add(this.payloadsetup1);
            this.Controls.Add(this.pinStatusButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "payloadStatusForm";
            this.Text = "payloadStatusForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.myButtonNoTheme pinStatusButton;
        private Controls.payloadsetup payloadsetup1;
        private Controls.myButtonNoTheme payloadSetupButton;
    }
}
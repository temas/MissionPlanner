
namespace MissionPlanner.StatusForms
{
    partial class messagesStatusForm
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
            this.txtMessagebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMessagebox
            // 
            this.txtMessagebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessagebox.Location = new System.Drawing.Point(0, 0);
            this.txtMessagebox.Multiline = true;
            this.txtMessagebox.Name = "txtMessagebox";
            this.txtMessagebox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessagebox.Size = new System.Drawing.Size(436, 569);
            this.txtMessagebox.TabIndex = 1;
            // 
            // messagesStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 569);
            this.Controls.Add(this.txtMessagebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "messagesStatusForm";
            this.Text = "messagesStatusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessagebox;
    }
}
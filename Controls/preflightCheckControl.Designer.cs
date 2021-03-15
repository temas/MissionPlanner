
namespace MissionPlanner.Controls
{
    partial class preflightCheckControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lName = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bPrev = new MissionPlanner.Controls.myButtonNoTheme();
            this.bNext = new MissionPlanner.Controls.myButtonNoTheme();
            this.bDone = new MissionPlanner.Controls.myButtonNoTheme();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(3, 3);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(55, 23);
            this.lName.TabIndex = 0;
            this.lName.Text = "label1";
            // 
            // lDesc
            // 
            this.lDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lDesc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lDesc.Location = new System.Drawing.Point(3, 26);
            this.lDesc.Name = "lDesc";
            this.lDesc.Size = new System.Drawing.Size(400, 128);
            this.lDesc.TabIndex = 1;
            this.lDesc.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // bPrev
            // 
            this.bPrev.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrev.Location = new System.Drawing.Point(3, 563);
            this.bPrev.Name = "bPrev";
            this.bPrev.Size = new System.Drawing.Size(99, 55);
            this.bPrev.TabIndex = 4;
            this.bPrev.Text = "<<<<<";
            this.bPrev.UseVisualStyleBackColor = true;
            this.bPrev.Click += new System.EventHandler(this.bPrev_Click);
            // 
            // bNext
            // 
            this.bNext.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNext.Location = new System.Drawing.Point(304, 563);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(99, 55);
            this.bNext.TabIndex = 5;
            this.bNext.Text = ">>>>>";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bDone
            // 
            this.bDone.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDone.Location = new System.Drawing.Point(104, 563);
            this.bDone.Name = "bDone";
            this.bDone.Size = new System.Drawing.Size(196, 55);
            this.bDone.TabIndex = 6;
            this.bDone.Text = "ELLENŐRIZVE";
            this.bDone.UseVisualStyleBackColor = true;
            this.bDone.Click += new System.EventHandler(this.bDone_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Location = new System.Drawing.Point(409, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 621);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // preflightCheckControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bDone);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bPrev);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.lName);
            this.Name = "preflightCheckControl";
            this.Size = new System.Drawing.Size(427, 627);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private myButtonNoTheme bPrev;
        private myButtonNoTheme bNext;
        private myButtonNoTheme bDone;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

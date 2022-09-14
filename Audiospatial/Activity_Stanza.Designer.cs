namespace Audiospatial
{
    partial class Activity_Stanza
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
            this.labCenter = new System.Windows.Forms.Label();
            this.labTimeCounter = new System.Windows.Forms.Label();
            this.pbEast = new System.Windows.Forms.PictureBox();
            this.pbNorth = new System.Windows.Forms.PictureBox();
            this.pbWest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWest)).BeginInit();
            this.SuspendLayout();
            // 
            // labCenter
            // 
            this.labCenter.AutoSize = true;
            this.labCenter.BackColor = System.Drawing.Color.Transparent;
            this.labCenter.Font = new System.Drawing.Font("Comic Sans MS", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCenter.Location = new System.Drawing.Point(382, 460);
            this.labCenter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCenter.Name = "labCenter";
            this.labCenter.Size = new System.Drawing.Size(244, 334);
            this.labCenter.TabIndex = 23;
            this.labCenter.Text = ".";
            this.labCenter.Visible = false;
            this.labCenter.Click += new System.EventHandler(this.labCenter_Click);
            // 
            // labTimeCounter
            // 
            this.labTimeCounter.AutoSize = true;
            this.labTimeCounter.BackColor = System.Drawing.Color.Transparent;
            this.labTimeCounter.Font = new System.Drawing.Font("Comic Sans MS", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTimeCounter.Location = new System.Drawing.Point(963, -9);
            this.labTimeCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTimeCounter.Name = "labTimeCounter";
            this.labTimeCounter.Size = new System.Drawing.Size(143, 195);
            this.labTimeCounter.TabIndex = 24;
            this.labTimeCounter.Text = ".";
            this.labTimeCounter.Visible = false;
            this.labTimeCounter.Click += new System.EventHandler(this.labTimeCounter_Click);
            // 
            // pbEast
            // 
            this.pbEast.BackColor = System.Drawing.Color.Transparent;
            this.pbEast.Location = new System.Drawing.Point(1269, 69);
            this.pbEast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbEast.Name = "pbEast";
            this.pbEast.Size = new System.Drawing.Size(188, 192);
            this.pbEast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEast.TabIndex = 22;
            this.pbEast.TabStop = false;
            this.pbEast.Visible = false;
            // 
            // pbNorth
            // 
            this.pbNorth.BackColor = System.Drawing.Color.Transparent;
            this.pbNorth.Location = new System.Drawing.Point(186, 69);
            this.pbNorth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbNorth.Name = "pbNorth";
            this.pbNorth.Size = new System.Drawing.Size(188, 192);
            this.pbNorth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNorth.TabIndex = 21;
            this.pbNorth.TabStop = false;
            this.pbNorth.Visible = false;
            // 
            // pbWest
            // 
            this.pbWest.BackColor = System.Drawing.Color.Transparent;
            this.pbWest.Location = new System.Drawing.Point(186, 738);
            this.pbWest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbWest.Name = "pbWest";
            this.pbWest.Size = new System.Drawing.Size(188, 192);
            this.pbWest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWest.TabIndex = 20;
            this.pbWest.TabStop = false;
            this.pbWest.Visible = false;
            // 
            // Activity_Stanza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.labTimeCounter);
            this.Controls.Add(this.labCenter);
            this.Controls.Add(this.pbEast);
            this.Controls.Add(this.pbNorth);
            this.Controls.Add(this.pbWest);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Activity_Stanza";
            this.Size = new System.Drawing.Size(1541, 1004);
            this.Load += new System.EventHandler(this.Activity_Stanza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWest;
        private System.Windows.Forms.PictureBox pbNorth;
        private System.Windows.Forms.PictureBox pbEast;
        private System.Windows.Forms.Label labCenter;
        private System.Windows.Forms.Label labTimeCounter;
    }
}

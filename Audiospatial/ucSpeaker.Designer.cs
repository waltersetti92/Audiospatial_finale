namespace Audiospatial
{
    partial class ucSpeaker
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
            this.label1 = new System.Windows.Forms.Label();
            this.labCenter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1701, 129);
            this.label1.TabIndex = 0;
            this.label1.Text = "L\'ULTIMO RISULTATO ERA:";
            // 
            // labCenter
            // 
            this.labCenter.AutoSize = true;
            this.labCenter.BackColor = System.Drawing.Color.Transparent;
            this.labCenter.Font = new System.Drawing.Font("Comic Sans MS", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCenter.Location = new System.Drawing.Point(853, 363);
            this.labCenter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCenter.Name = "labCenter";
            this.labCenter.Size = new System.Drawing.Size(163, 223);
            this.labCenter.TabIndex = 24;
            this.labCenter.Text = ".";
            this.labCenter.Visible = false;
            this.labCenter.Click += new System.EventHandler(this.labCenter_Click);
            // 
            // ucSpeaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labCenter);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucSpeaker";
            this.Size = new System.Drawing.Size(1315, 534);
            this.Load += new System.EventHandler(this.ucSpeaker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labCenter;
    }
}

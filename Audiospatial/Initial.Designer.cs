namespace Audiospatial
{
    partial class Initial
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
            this.labLuda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labLuda
            // 
            this.labLuda.AutoSize = true;
            this.labLuda.BackColor = System.Drawing.Color.Transparent;
            this.labLuda.Font = new System.Drawing.Font("Snap ITC", 90F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLuda.ForeColor = System.Drawing.Color.Green;
            this.labLuda.Location = new System.Drawing.Point(71, 378);
            this.labLuda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labLuda.Name = "labLuda";
            this.labLuda.Size = new System.Drawing.Size(1690, 231);
            this.labLuda.TabIndex = 1;
            this.labLuda.Text = "IL BUCO NERO";
            // 
            // Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labLuda);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Initial";
            this.Size = new System.Drawing.Size(1838, 806);
            this.Load += new System.EventHandler(this.Initial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLuda;
    }
}

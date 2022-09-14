namespace Audiospatial
{
    partial class debugInfo
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
            this.labCurrNumber = new System.Windows.Forms.Label();
            this.labDebugOperation = new System.Windows.Forms.Label();
            this.labDebugNewNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labDebugResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labCurrNumber
            // 
            this.labCurrNumber.AutoSize = true;
            this.labCurrNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCurrNumber.Location = new System.Drawing.Point(4, 0);
            this.labCurrNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCurrNumber.Name = "labCurrNumber";
            this.labCurrNumber.Size = new System.Drawing.Size(85, 61);
            this.labCurrNumber.TabIndex = 14;
            this.labCurrNumber.Text = "00";
            // 
            // labDebugOperation
            // 
            this.labDebugOperation.AutoSize = true;
            this.labDebugOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDebugOperation.Location = new System.Drawing.Point(78, 0);
            this.labDebugOperation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDebugOperation.Name = "labDebugOperation";
            this.labDebugOperation.Size = new System.Drawing.Size(85, 61);
            this.labDebugOperation.TabIndex = 15;
            this.labDebugOperation.Text = "00";
            // 
            // labDebugNewNumber
            // 
            this.labDebugNewNumber.AutoSize = true;
            this.labDebugNewNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDebugNewNumber.Location = new System.Drawing.Point(152, 2);
            this.labDebugNewNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDebugNewNumber.Name = "labDebugNewNumber";
            this.labDebugNewNumber.Size = new System.Drawing.Size(85, 61);
            this.labDebugNewNumber.TabIndex = 16;
            this.labDebugNewNumber.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 61);
            this.label1.TabIndex = 17;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labDebugResult
            // 
            this.labDebugResult.AutoSize = true;
            this.labDebugResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDebugResult.Location = new System.Drawing.Point(292, 0);
            this.labDebugResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDebugResult.Name = "labDebugResult";
            this.labDebugResult.Size = new System.Drawing.Size(85, 61);
            this.labDebugResult.TabIndex = 18;
            this.labDebugResult.Text = "00";
            this.labDebugResult.Click += new System.EventHandler(this.labDebugResult_Click);
            // 
            // debugInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labDebugResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labDebugNewNumber);
            this.Controls.Add(this.labDebugOperation);
            this.Controls.Add(this.labCurrNumber);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "debugInfo";
            this.Size = new System.Drawing.Size(390, 62);
            this.Load += new System.EventHandler(this.debugInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCurrNumber;
        private System.Windows.Forms.Label labDebugOperation;
        private System.Windows.Forms.Label labDebugNewNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labDebugResult;
    }
}

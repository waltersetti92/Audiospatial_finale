namespace Audiospatial
{
    partial class AnswerUC
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
            this.components = new System.ComponentModel.Container();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btAnswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(213, 246);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(200, 74);
            this.txtResult.TabIndex = 9;
            // 
            // btAnswer
            // 
            this.btAnswer.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnswer.Location = new System.Drawing.Point(464, 246);
            this.btAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAnswer.Name = "btAnswer";
            this.btAnswer.Size = new System.Drawing.Size(410, 80);
            this.btAnswer.TabIndex = 10;
            this.btAnswer.Text = "RISPONDI";
            this.btAnswer.UseVisualStyleBackColor = true;
            this.btAnswer.Click += new System.EventHandler(this.btAnswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 130);
            this.label1.TabIndex = 11;
            this.label1.Text = "RISPONDI!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerlabel
            // 
            this.timerlabel.AutoSize = true;
            this.timerlabel.BackColor = System.Drawing.Color.Transparent;
            this.timerlabel.Font = new System.Drawing.Font("Snap ITC", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerlabel.ForeColor = System.Drawing.Color.Black;
            this.timerlabel.Location = new System.Drawing.Point(266, 196);
            this.timerlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerlabel.Name = "timerlabel";
            this.timerlabel.Size = new System.Drawing.Size(189, 130);
            this.timerlabel.TabIndex = 12;
            this.timerlabel.Text = "15";
            this.timerlabel.Click += new System.EventHandler(this.timerlabel_Click);
            // 
            // AnswerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.timerlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAnswer);
            this.Controls.Add(this.txtResult);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnswerUC";
            this.Size = new System.Drawing.Size(1276, 589);
            this.Load += new System.EventHandler(this.AnswerUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerlabel;
    }
}

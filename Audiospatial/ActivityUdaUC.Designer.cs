namespace Audiospatial
{
    partial class ActivityUdaUC
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.cmbParticipants = new System.Windows.Forms.ComboBox();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 45);
            this.label2.TabIndex = 15;
            this.label2.Text = "Numero Partecipanti";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Livello di difficoltà";
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.ForeColor = System.Drawing.Color.DarkGreen;
            this.btStart.Location = new System.Drawing.Point(11, 132);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(592, 74);
            this.btStart.TabIndex = 19;
            this.btStart.Text = "INIZIA";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btExit.Location = new System.Drawing.Point(11, 212);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(592, 74);
            this.btExit.TabIndex = 20;
            this.btExit.Text = "ESCI";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // cmbParticipants
            // 
            this.cmbParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParticipants.FormattingEnabled = true;
            this.cmbParticipants.Location = new System.Drawing.Point(345, 15);
            this.cmbParticipants.Name = "cmbParticipants";
            this.cmbParticipants.Size = new System.Drawing.Size(243, 45);
            this.cmbParticipants.TabIndex = 21;
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Location = new System.Drawing.Point(345, 66);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(243, 53);
            this.cmbDifficulty.TabIndex = 22;
            // 
            // ActivityUdaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.cmbParticipants);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ActivityUdaUC";
            this.Size = new System.Drawing.Size(609, 309);
            this.Load += new System.EventHandler(this.ActivityUdaUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ComboBox cmbParticipants;
        private System.Windows.Forms.ComboBox cmbDifficulty;
    }
}

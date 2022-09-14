using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Audiospatial
{
    public partial class MessageUC : UserControl
    {
        public Main parentForm { get; set; }
        public ActivityUdaUC parentForm1 { get; set; }
        public int index;
        public MessageUC()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            this.BackColor = Color.Transparent;
        }
        public void setMessage(string msg, string bt_text)
        {
            Visible = true;
            label.Text = msg;

            label.Location = new Point(Width / 2 - label.Width / 2, Height / 2 - label.Height / 2);

            if (bt_text.Length > 0)
            {
                btClose.Text = bt_text;
                btClose.Visible = true;
                btClose.Select();
            }
            else
            {
                btClose.Text = "";
                btClose.Visible = false;
            }
        }
        public void setPos(int w, int h)
        {
            Width = w;
            Height = h;
            Location = new Point(0, 0);
            btClose.Location = new Point(Width / 2 - btClose.Width / 2, Height / 2 + btClose.Height);
        }
        private void label_Click(object sender, EventArgs e)
        {

        }
        private void onKeyPress(object sender, KeyPressEventArgs e)
        {

            parentForm.closeMessage();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (parentForm.onactivity == 2 && parentForm.ripetiz == 0)
            {
                parentForm.messaggio = 2; // Questo per il messaggio da mandare in show message  
                parentForm.onStartActivity(parentForm.iDifficulty, 0, parentForm.participants, "1");
            }
           else  if (parentForm.onactivity == 3 && parentForm.ripetiz == 0)
            {
                parentForm.messaggio = 3; // Questo per il messaggio da mandare in show message   
                parentForm.onStartActivity(parentForm.iDifficulty, 0, parentForm.participants, "1");
            }
            else if (parentForm.onactivity == 4 && parentForm.ripetiz == 0)
            {
                parentForm.messaggio = 4; // Questo per il messaggio da mandare in show message  
                parentForm.onStartActivity(parentForm.iDifficulty, 0, parentForm.participants, "1");
            }
            else if (parentForm.onactivity == 5 && parentForm.ripetiz == 0)
            {
                parentForm.messaggio = 5; // Questo per il messaggio da mandare in show message 
                parentForm.onStartActivity(parentForm.iDifficulty, 0, parentForm.participants, "1");
            }
            else if (parentForm.onactivity == 6 && parentForm.ripetiz == 0)
            {
                parentForm.messaggio = 6; // Questo per il messaggio da mandare in show message  
                parentForm.onStartActivity(parentForm.iDifficulty, 0, parentForm.participants, "1");
            }
            else if (parentForm.onactivity == 7 && parentForm.ripetiz == 0)
            {
                parentForm.messaggio = 7; // Questo per il messaggio da mandare in show message  
                parentForm.finale();
                
            }
            if (parentForm.ripetiz == 1)
            {
                parentForm.closeMessage1();
            }
        }

        private void MessageUC_Load(object sender, EventArgs e)
        {

        }
    }
}

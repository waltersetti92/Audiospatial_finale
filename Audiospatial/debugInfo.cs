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
    public partial class debugInfo : UserControl
    {
        public Main parentForm { get; set; }
        public debugInfo()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            this.BackColor = Color.Transparent;
        }
        public void setDebugInfo(string currnumber, string operation, string newoperand, string result)
        {
            labCurrNumber.Text = currnumber;
            labDebugOperation.Text = operation;
            labDebugNewNumber.Text = newoperand;
            labDebugResult.Text = result;
        }
        public void setPos(int w, int h)
        {
            Location = new Point(w - Width / 2 - 150, h - Height / 2 - 150);
        }
        internal void nextOperand()
        {
            if (Main.IS_DEBUG == true) Visible = true;
            else Visible = false;

            setDebugInfo("", "", "", "");
        }
        private void debugInfo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labDebugResult_Click(object sender, EventArgs e)
        {

        }
    }
}

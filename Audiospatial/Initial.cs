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
    public partial class Initial : UserControl
    {
        public Main parentForm { get; set; }
        public Initial()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            labLuda.BackColor = Color.Transparent;
            this.BackColor = Color.Transparent;
        }

        private void Initial_Load(object sender, EventArgs e)
        {

        }
        public void setPos(int w, int h)
        {
            int offset = 100;
            Location = new Point(offset, offset);
            Width = w - 2 * offset;
            Height = h - 2 * offset;
            labLuda.Location = new Point(w / 2 - labLuda.Width / 2 - offset, 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //parentForm.onStart();
        }
    }
}

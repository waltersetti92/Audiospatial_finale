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
    public partial class Final : UserControl
    {
        public Main parentForm { get; set; }
        public Final()
        {
            InitializeComponent();
        }
        public void setPos(int w, int h)
        {

            int offset = 0;
            Location = new Point(offset, offset);
            Width = w - 1 * offset;
            Height = h - 1 * offset;

        }
        private void Final_Load(object sender, EventArgs e)
        {

        }
    }
}

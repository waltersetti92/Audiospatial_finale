using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Audiospatial
{
    public partial class ucSpeaker : UserControl
    {
        public Main parentForm { get; set; }
        private Speakers speakers = null;
        public int value_lbl=0;

        public ucSpeaker()
        {
            InitializeComponent();
            labCenter.Text= Convert.ToString(value_lbl);

        }
        public void setPos(int w, int h)
        {

            int offset = 0;
            Location = new Point(offset, offset);
            Width = w - 1 * offset;
            Height = h - 1 * offset;

        }
        public void init(Speakers spk)
        {
            
        }

        public void change_number()
        {
            labCenter.Text = Convert.ToString(value_lbl);
            this.Update();
            labCenter.Visible = true;
            this.Update();
            Thread.Sleep(7000);
            this.Visible = false;
            value_lbl = 0;
        }
        private void ucSpeaker_Load(object sender, EventArgs e)
        {          

        }

        private void cmbCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void labCenter_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Audiospatial
{
    public partial class Finale_Scenario : UserControl
    {
        public Main parentForm { get; set; }
        public string completed;
        public Finale_Scenario()
        {
            InitializeComponent();
            completed = "api/uda/put/?i=5&k=16";

        }
        public void setPos(int w, int h)
        {

            int offset = 0;
            Location = new Point(offset, offset);
            Width = w - 1 * offset;
            Height = h - 1 * offset;

        }

        public async void Image_Indizio(string a)
        {
            while (true)
            {
                string k = parentForm.Status_Changed(parentForm.activity_form);
                int status = int.Parse(k);
                if (status != 9 && status != 8)
                {
                    if (status == 11 || status == 12)
                    {
                        Application.Exit();
                        Environment.Exit(0);
                    }
                    if (status == 13)
                    {
                        this.Hide();
                        parentForm.Abort_UDA();
                        break;
                    }
                    else if (status == 10 || status == 7 || status == 16)
                    {

                        pictureBox1.WaitOnLoad = true;
                        pictureBox1.ImageLocation = Main.resourcesPath + "\\" + a + ".png";
                        pictureBox1.Visible = true;
                        this.Update();
                        break;
                    }
                }
            }

        }

            public async void indizio()
        {
            await uda_server_communication.Server_Request(completed);
            Image_Indizio(uda_server_communication.indizio + "_" + uda_server_communication.turno);
            Thread.Sleep(2000);
            // parentForm.video_reproduction("C:\\Users\\wsetti\\Documents\\Video_LUDA\\UDA_Inglese_0.mov");
            /*}*/
        }


        private void Finale_Scenario_Load(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

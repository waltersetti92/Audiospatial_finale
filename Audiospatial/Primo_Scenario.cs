using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Audiospatial
{
    public partial class Primo_Scenario : UserControl
    {
        public Main parentForm { get; set; }
        public Speakers speakers = null;
        public int timeleft = 2; //timeleft deve essere 0
        public int timer_game = 0;
        public int seconds = 0;
        public int minutes = 5;
        public string put_started;
        public string put_wait_data;

        public Primo_Scenario()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.lion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            speakers = new Speakers();
            put_started = "/api/uda/put/?i=5&k=7";
            put_wait_data = "/api/uda/put/?i=5&k=14" + "&data=" + "{\"answer\": \"Inserisci il risultato corretto\", \"input_type\":\"\"}";
            timerlabel.Text = "02";
            timeleft = 2;
     

        }
        public void setPos(int w, int h)
        {

            int offset = 0;
            Location = new Point(offset, offset);
            Width = w - 1 * offset;
            Height = h - 1 * offset;

        }
        public void setMessage_ps(string bt_text)
        {
            Visible = true;
            if (bt_text.Length > 0)
            {
   
                //Start.Visible = true;
                //Start.Select();
            }
            else
            {
               // Start.Text = "";
                //Start.Visible = false;
            }
        }

        private void Primo_Scenario_Load(object sender, EventArgs e)
        {
           // parentForm.PutStarted();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //parentForm.playbackResourceAudio("Alarm_sound");
        }
        public void counter()
        {
            timerlabel.Visible = true;
            timeleft = 2;
            timerlabel.Text = "02";
            timer1.Enabled = true;
            parentForm.PutStarted();
            timer1.Start();
            parentForm.PutStarted();

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                while (true)
                {      
                    string k = parentForm.Status_Changed(parentForm.activity_form);
                    int status = int.Parse(k);

                    if (status != 9 && status != 8)
                    {
                        if (status == 11 || status == 12)
                        {
                            System.Diagnostics.Process.GetCurrentProcess().Kill();
                        }
                        if (status == 13)
                        {
                            this.Hide();
                            parentForm.Abort_UDA();
                            break;
                        }
                        if (status == 10)
                        {
                            parentForm.contatore_iniziale = 0;
                            await uda_server_communication.Server_Request(put_started);
                        }
                        Thread.Sleep(1000);
                        timeleft = timeleft - 1;
                        if(timeleft<10 && timeleft>0)
                            timerlabel.Text = "0" + timeleft.ToString();
                        else
                        timerlabel.Text = timeleft.ToString();
                        this.Update();
                    }
                    Thread.Sleep(400);
                    break;
                }
            }
            else if (timeleft == 0)
            {
                while (true)
                {
                    string k = parentForm.Status_Changed(parentForm.activity_form);
                    int status = int.Parse(k);
                    if (status != 9 && status != 8)
                    {
                        if (status == 11 || status == 12)
                        {
                            System.Diagnostics.Process.GetCurrentProcess().Kill();
                        }
                        if (status == 13)
                        {
                            this.Hide();
                            parentForm.Abort_UDA();
                            break;
                        }
                        if (status == 10 || status==7)
                        {
                            parentForm.contatore_iniziale = 1;
                            await uda_server_communication.Server_Request(put_started);
                        }
                        timerlabel.Text = "00";
                        this.Update();
                        timer1.Stop();
                        //await uda_server_communication.Server_Request(put_wait_data);
                        parentForm.contatore_iniziale = 1;
                        parentForm.closeMessage();
                    }
                    Thread.Sleep(400);
                    break;
                }
 
            }
        }

        private void timerlabel_Click(object sender, EventArgs e)
        {

        }

        private void labPrimoScenario_Click(object sender, EventArgs e)
        {

        }
    }
}

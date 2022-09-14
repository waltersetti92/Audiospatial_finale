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
    public partial class Terzo_Scenario : UserControl
    {
        public Main parentForm { get; set; }
        public Speakers speakers = null;
        public int timeleft = 15;
        public int timer_game = 0;
        private int total_seconds;
        public int seconds = 0;
        public int minutes = 5;
        public string put_started;
        public string put_wait_data;
        public Terzo_Scenario()
        {
            InitializeComponent();
            speakers = new Speakers();
            put_started = "/api/uda/put/?i=5&k=7";
            put_wait_data = "/api/uda/put/?i=5&k=14" + "&data=" + "{\"answer\": \"Inserisci il risultato corretto\", \"input_type\":\"\"}";
            timerlabel.Text = "15";
            timeleft = 15;

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
                //Start.Text = "";
               // Start.Visible = false;
            }
        }
        public void counter()
        {
            timerlabel.Visible = true;
            timeleft = 15;
            timerlabel.Text = "15";
            timer1.Enabled = true;
            timer1.Start();

        }
        private void Terzo_Scenario_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            parentForm.closeMessage();
        }

        private void Alarm_Click(object sender, EventArgs e)
        {
            parentForm.playbackResourceAudio("Thunder");
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
                            Application.Exit();
                            Environment.Exit(0);
                        }
                        if (status == 13)
                        {
                            this.Hide();
                            parentForm.Abort_UDA();
                            break;
                        }
                        if (status == 10 || status == 7)
                        {
                            await uda_server_communication.Server_Request(put_wait_data);
                        }
                        Thread.Sleep(1000);
                        timeleft = timeleft - 1;
                        if (timeleft < 10 && timeleft > 0)
                            timerlabel.Text = "0" + timeleft.ToString();
                        else
                            timerlabel.Text = timeleft.ToString();
                        this.Update();
                    }
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
                            Application.Exit();
                            Environment.Exit(0);
                        }
                        if (status == 13)
                        {
                            this.Hide();
                            parentForm.Abort_UDA();
                            break;
                        }
                        if (status == 10 || status == 7)
                        {
                            await uda_server_communication.Server_Request(put_wait_data);
                        }
                        timerlabel.Text = "00";
                        this.Update();
                        timer1.Stop();
                        await uda_server_communication.Server_Request(put_started);
                        parentForm.closeMessage();
                        this.timer1.Stop();
                       // timerlabel.Enabled = false;
                        //timerlabel.Visible = false;
                       
                    }
                    break;
                }

            }
        }
    }
}

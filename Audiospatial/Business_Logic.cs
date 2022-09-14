using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Collections;
using System.Timers;
using System.Windows;
using System.Diagnostics;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Timer = System.Timers.Timer;
namespace Audiospatial
{
    class Business_Logic
    {
        private Main mn;
        public string save_status;
        private static System.Timers.Timer aTimer;
        public int counter_timer;
        public bool firststart = true;
        public Business_Logic(Main form)
        {
            mn = form;
            counter_timer = 0;
            aTimer = new System.Timers.Timer(10000);
            aTimer.Elapsed += new ElapsedEventHandler(New_Status_UDA);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;
        }
        public async void New_Status_UDA(object source, ElapsedEventArgs e)
        {
            string get_status_uda = "api/uda/get/?i=5";  // url per ottenere lo stato dell'UDA  
            try
            {
                string uda_status = await uda_server_communication.Server_Request(get_status_uda); //stato dell'UDA ottenuto con la classe UDA_server_communication
                if (string.Equals(uda_status, "6"))
                {
                    mn.data_start = await uda_server_communication.Server_Request_started(get_status_uda);
                }

                if (counter_timer == 0) // salvo lo stato dell'UDA al tempo t=0 e la prima volta che cambia
                {
                    save_status = uda_status;
                    mn.Status_Changed(uda_status);
                    mn.activity_form = uda_status;
                    string put_server;
                    if (firststart || Equals(uda_status, "0"))
                    {
                        mn.onactivity = 1;
                        mn.messaggio = 1;
                        mn.scenario = 1;
                        mn.participants = 0;    
                        put_server = Url_Put("5"); // creo la stringa per il put al server che notifica il cambio di stato dell'UDA
                        firststart = false;

                    }
                    else
                    {
                        put_server = Url_Put(uda_status);
                    }
                    await uda_server_communication.Server_Request(put_server); // qui mando al server il comando  
                    counter_timer++;
                }
                else //verifico che lo stato corrente sia diverso dallo stato salvato
                {
                    if (!string.Equals(uda_status, save_status))
                    {
                        counter_timer = 0;
                        int status = int.Parse(uda_status);
                        mn.Status_Changed(uda_status);
                        mn.activity_form = uda_status;
                        string put_server = Url_Put(uda_status);
                        await uda_server_communication.Server_Request(put_server);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error", ex);
                aTimer.Stop();
            }
        }
        public string Url_Put(string k)
        {
            int ik = Int32.Parse(k);
            int ik1 = ik + 1;
            if (ik >= 0 && ik < 20)
            {
                if (ik == 11 || ik == 8)
                    return "/api/uda/put/?i=5" + "&k=" + ik1.ToString();
                else if (ik == 6)
                    return "/api/uda/put/?i=5" + "&k=" + ik1.ToString() + "&data=" + mn.data_start;
                else
                    return "/api/uda/put/?i=5" + "&k=" + ik.ToString();
            }
            else
                return "";

        }
    }
}


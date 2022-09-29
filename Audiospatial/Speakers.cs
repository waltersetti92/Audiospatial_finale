using System;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Audiospatial
{

    public class Speakers
    {
        public Main parentForm { get; set; }
        public String sound_to_play = "";
        String url = "http://192.168.10.1:8766/"; //quello giusto
        //String url = "https://luda.nixo.xyz/";
         //String url = "http://192.168.10.1.8767/"; 
        public string status_uda;


        private Dictionary<string, string> soundmap = new Dictionary<string, string> {
            { "sveglia", "alarm"},
            { "clacson", "clacson"},
            { "thunder", "pesto"},
            { "bongo", "bongo"},
            { "ruggito", "prezzemolo"},
            { "acchiappasogni", "acchiappasogni"}
        };
        public Speakers()
        {
        }

        public async Task<bool> play(string speaker)
        {


            while (true)
            {
                string status_uda1 = status_uda;
                if (String.Equals(status_uda1, "11" )|| String.Equals(status_uda1, "12"))
                {
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
                if (String.Equals(status_uda1, "7") || String.Equals(status_uda1, "10"))
                {
                    string filename = soundmap[sound_to_play];
                    try
                    {
                        WebRequest server = HttpWebRequest.Create(url + "?speaker=" + speaker + "&file=" + filename);
                        var response = server.GetResponse();
                        using (var reader = new StreamReader(response.GetResponseStream()))
                        {
                            var result = await reader.ReadToEndAsync();
                        }
                        Thread.Sleep(1500);
                        return true;
                    }
                    catch (Exception ex)
                    {
                    }
                    break;
                }
               
          
            }
                
    
          
            return true;
        }
    }
}
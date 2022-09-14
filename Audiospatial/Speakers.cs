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
        //String url = "http://192.168.100.4:8766/"; //quello giusto
        String url = "https://luda.nixo.xyz/";

        private Dictionary<string, string> soundmap = new Dictionary<string, string> {
            { "sveglia", "menta"},
            { "clacson", "panna"},
            { "thunder", "pesto"},
            { "bongo", "ninfea"},
            { "ruggito", "prezzemolo"},
            { "acchiappasogni", "prosciutto"}
        };
        public Speakers()
        {
        }

        public async Task<bool> play(string speaker)
        {
            while (true)
            {
                string k = parentForm.Status_Changed(parentForm.activity_form);
                int status = int.Parse(k);
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
                    // Connection failed
                }
                break;
            }

            return true;
        }
    }
}
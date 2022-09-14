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
using System.Windows;
using System.Diagnostics;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Audiospatial
{
    class uda_server_communication
    {
        public static int[] explorers;
        public static int turno;
        public static int indizio;
        public static string server_url = "https://luda.nixo.xyz/";
        public uda_server_communication()
        {
        }
        public async static Task<string> Server_Request(string url)
        {
            try
            {
                WebRequest server = HttpWebRequest.Create(server_url + url);
                var response = server.GetResponse();
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var result = await reader.ReadToEndAsync();
                    JObject json_parsed = JObject.Parse(result);
                    explorers = json_parsed["explorers"].Values<int>().ToArray();
                    turno = (int)json_parsed["turno"].ToObject<int>();
                    indizio = (int)json_parsed["indizio"].ToObject<int>();
                    string current_status = (string)json_parsed["status"];
                    return current_status;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error", ex);
            }
        }
        public async static Task<JToken> Server_Request_datasent(string url)
        {
            try
            {
                WebRequest server = HttpWebRequest.Create(server_url + url);
                var response = server.GetResponse();
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var result = await reader.ReadToEndAsync();
                    JObject json_parsed = JObject.Parse(result);
                    return json_parsed["data"];
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error", ex);
            }
        }
        public async static Task<string> Server_Request_started(string url)
        {
            try
            {
                WebRequest server = HttpWebRequest.Create(server_url + url);
                var response = server.GetResponse();
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var result = await reader.ReadToEndAsync();
                    JObject json_parsed = JObject.Parse(result);
                    string current_status = (string)json_parsed["data"];
                    return current_status;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error", ex);
            }
        }
    }
}



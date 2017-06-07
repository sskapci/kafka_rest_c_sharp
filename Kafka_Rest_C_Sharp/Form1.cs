using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Kafka_Rest_C_Sharp
{
    public partial class Form1 : Form
    {

        private static Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string content = "{\"records\":[{\"value\":{\"message\":\"" + txt_message.Text + "\"}}]}";
            POST(txt_server.Text, content);
        }

        void POST(string url, string jsonContent)
        {

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";

                System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                Byte[] byteArray = encoding.GetBytes(jsonContent);

                request.ContentLength = byteArray.Length;
                request.ContentType = @"application/vnd.kafka.json.v2+json";

                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }
                long length = 0;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    length = response.ContentLength;
                    txt_info.Text = response.StatusCode.ToString();
                }
            }
            catch (WebException ex)
            {
                // Log exception and throw as for GET example above
            }
        }

        // Returns JSON string
        string GET(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
            }
        }

        //TODO generate background process
        private void btn_auto_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                string content = "{\"records\":[{\"value\":{\"message\":\"" + RandomString(6) + "\"}}]}";
                POST(txt_server.Text, content);
            }
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            txt_info.Text = GET(txt_server.Text);
        }
    }
}

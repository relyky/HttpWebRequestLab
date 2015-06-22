using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace httpWebRequestLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                //# prefix actions
                txtOutput.Clear();

                //
                string url = txtUrl.Text.Trim();
                txtMessage.AppendText("\r\n### ### ### ### ### ###\r\n");
                txtMessage.AppendText(string.Format("URL : {0}\r\n", url));

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                // Set some reasonable limits on resources used by this request
                request.MaximumAutomaticRedirections = 4;
                request.MaximumResponseHeadersLength = 4;
                request.Timeout = (int)numTimeOut.Value; // milliseconds

                // Set credentials to use for this request.
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                txtMessage.AppendText(string.Format("Content Length : {0}\r\n", response.ContentLength));
                txtMessage.AppendText(string.Format("Content Type : {0}\r\n", response.ContentType));
                txtMessage.AppendText(string.Format("Content Encoding : {0}\r\n", response.ContentEncoding));

                // Get the stream associated with the response.
                //Stream receiveStream = response.GetResponseStream();

                // Pipes the stream to a higher level stream reader with the required encoding format. 
                StreamReader readStream = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                txtMessage.AppendText(string.Format("Response stream received."));

                // 
                txtOutput.AppendText(readStream.ReadToEnd());

                response.Close();
                readStream.Close();                    
            }
            catch(Exception ex)
            {
                txtMessage.AppendText("\r\n ===>>><<<===\r\n");
                txtMessage.AppendText(string.Format("EXCEPTION : {0}\r\n", ex.GetType().Name));
                txtMessage.AppendText(string.Format("MESSAGE : {0}\r\n", ex.Message));
            }

        }
    }
}

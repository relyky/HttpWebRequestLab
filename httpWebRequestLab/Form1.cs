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
using System.Text.RegularExpressions;
using System.Net.Security;
using System.Collections;
using NCCUCS.AspectW;

namespace httpWebRequestLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //# init. : cbxAuthLevel
            ArrayList authLevelItems = new ArrayList();
            foreach (AuthenticationLevel c in Enum.GetValues(typeof(AuthenticationLevel)))
                authLevelItems.Add(new KeyValuePair<AuthenticationLevel, string>(c, c.ToString()));

            cbxAuthLevel.ValueMember = "Key";
            cbxAuthLevel.DisplayMember = "Value";
            cbxAuthLevel.DataSource = authLevelItems;

            // 初使化
            cboUrl.SelectedIndex = 0;
        }

        /// <summary>
        /// One of Aspect Function
        /// </summary>
        private void TraceExceptionHanler(Exception ex)
        {
            txtMessage.AppendText("\r\n ===>>><<<===\r\n");
            txtMessage.AppendText(string.Format("EXCEPTION : {0}\r\n", ex.GetType().Name));
            txtMessage.AppendText(string.Format("MESSAGE : {0}\r\n", ex.Message));
        }

        /// <summary>
        /// One of Aspect Function
        /// </summary>
        private void TraceHowLongHanler(TimeSpan ts)
        {
            txtMessage.AppendText(string.Format("SPAND : {0} seconds\r\n", ts.TotalSeconds));
        }

        private void TraceLine(string msg)
        {
            txtMessage.AppendText(msg + "\r\n");
        }

        private void TraceLine(string format, params object[] args)
        {
            txtMessage.AppendText(string.Format(format + "\r\n", args));
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            AspectW.Define
                .WaitCursor(this, btnGo)
                .Ignore()
                .TraceException(TraceExceptionHanler)
                .TraceHowLong(TraceHowLongHanler)
                .Do(()=>
                {
                    //# prefix actions
                    txtOutput.Clear();

                    //
                    string url = cboUrl.Text.Trim();
                    TraceLine("\r\n### ### ### ### ### ###");
                    TraceLine("URL : {0}", url);

                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                    // Set some reasonable limits on resources used by this request
                    request.MaximumAutomaticRedirections = 4;
                    request.MaximumResponseHeadersLength = 4;
                    request.Timeout = (int)numTimeOut.Value; // milliseconds

                    // Set credentials to use for this request.
                    request.Credentials = CredentialCache.DefaultCredentials;
                    request.AuthenticationLevel = (AuthenticationLevel)cbxAuthLevel.SelectedValue; // AuthenticationLevel.None;
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    // Show some properties
                    TraceLine("Content Length : {0:N0}", response.ContentLength);
                    TraceLine("Content Type : {0}", response.ContentType);
                    TraceLine("Content Encoding : {0}", response.ContentEncoding);
                    TraceLine("Is mutually authenticated? {0}", response.IsMutuallyAuthenticated);

                    // Pipes the stream to a higher level stream reader with the required encoding format. 
                    StreamReader readStream = new StreamReader(response.GetResponseStream(), Encoding.ASCII);
                    TraceLine("Response stream received.");

                    // show URL content
                    txtOutput.AppendText(readStream.ReadToEnd());

                    // check is match pattern or not with 10 seconds timeout.
                    if (Regex.IsMatch(txtOutput.Text, txtPattern.Text, RegexOptions.None, new TimeSpan(0, 0, 10)))
                        TraceLine("Match the RegEx pattern.");
                    else
                        TraceLine("NOT match the RegEx pattern.");

                    response.Close();
                    readStream.Close(); 
                });
        }

        //private void btnGo_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.Cursor = Cursors.WaitCursor;
        //
        //        //# prefix actions
        //        txtOutput.Clear();
        //
        //        //
        //        string url = cboUrl.Text.Trim();
        //        txtMessage.AppendText("\r\n### ### ### ### ### ###\r\n");
        //        txtMessage.AppendText(string.Format("URL : {0}\r\n", url));
        //
        //        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        //
        //        // Set some reasonable limits on resources used by this request
        //        request.MaximumAutomaticRedirections = 4;
        //        request.MaximumResponseHeadersLength = 4;
        //        request.Timeout = (int)numTimeOut.Value; // milliseconds
        //
        //        // Set credentials to use for this request.
        //        request.Credentials = CredentialCache.DefaultCredentials;
        //        request.AuthenticationLevel = (AuthenticationLevel)cbxAuthLevel.SelectedValue; // AuthenticationLevel.None;
        //        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //
        //        // Show some properties
        //        txtMessage.AppendText(string.Format("Content Length : {0:N0}\r\n", response.ContentLength));
        //        txtMessage.AppendText(string.Format("Content Type : {0}\r\n", response.ContentType));
        //        txtMessage.AppendText(string.Format("Content Encoding : {0}\r\n", response.ContentEncoding));
        //        txtMessage.AppendText(string.Format("Is mutually authenticated? {0}\r\n", response.IsMutuallyAuthenticated));
        //
        //        // Pipes the stream to a higher level stream reader with the required encoding format. 
        //        StreamReader readStream = new StreamReader(response.GetResponseStream(), Encoding.ASCII);
        //        txtMessage.AppendText("Response stream received.\r\n");
        //
        //        // show URL content
        //        txtOutput.AppendText(readStream.ReadToEnd());
        //
        //        // check is match pattern or not with 10 seconds timeout.
        //        if (Regex.IsMatch(txtOutput.Text, txtPattern.Text, RegexOptions.None, new TimeSpan(0, 0, 10)))
        //            txtMessage.AppendText("Match the RegEx pattern.\r\n");
        //        else
        //            txtMessage.AppendText("NOT match the RegEx pattern.\r\n");
        //
        //        response.Close();
        //        readStream.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        txtMessage.AppendText("\r\n ===>>><<<===\r\n");
        //        txtMessage.AppendText(string.Format("EXCEPTION : {0}\r\n", ex.GetType().Name));
        //        txtMessage.AppendText(string.Format("MESSAGE : {0}\r\n", ex.Message));
        //    }
        //    finally
        //    {
        //        this.Cursor = Cursors.Default;
        //    }
        //}
    }
}

using System;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace store_client.Views
{
    public partial class Home : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Home()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserManagement.User user = new UserManagement.User(txtMail.Text, txtPassword.Text);

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:9000/auth/login");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string jsonData = JsonConvert.SerializeObject(user);
                streamWriter.Write(jsonData);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                lblStatusLogin.Text = "Success";
                // Open chatroom        
                new Thread(() =>
                {
                    // TODO: Store doesn't have constructor with user
                    // Application.Run(new Store(user));
                    Application.Run(new Store());
                }).Start();
                this.Close();
            }
            catch (WebException ex)
            {
                using (var stream = ex.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    //Console.WriteLine(reader.ReadToEnd());
                    lblStatusLogin.Text = "Login failed, try again.";
                }
            }
            catch (Exception ex)
            {
                // Something more serious happened
                // like for example you don't have network access
                // we cannot talk about a server exception here as
                // the server probably was never reached
            }

            /*
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                lblStatusLogin.Text = result;  
            }*/
        }
    }
}

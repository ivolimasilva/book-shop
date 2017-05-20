using System;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;

namespace store_client.Views
{
    public partial class Home : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Home()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
      /*      var values = new Dictionary<string, string>
            {
               { "mail", txtMail.Text },
               { "password", txtPassword.Text }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("http://localhost:9000/auth/login", content);

            var responseString = await response.Content.ReadAsStringAsync();*/

            
            WebRequest request = WebRequest.Create("http://localhost:9000/auth/login");
            request.Method = "POST";

            UserManagement.User user = new UserManagement.User(txtMail.Text, txtPassword.Text);
            
            string jsonData = JsonConvert.SerializeObject(user);
            byte[] byteArray = Encoding.UTF8.GetBytes(jsonData);
            // Set the ContentType property of the WebRequest.  
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.  
            request.ContentLength = byteArray.Length;
            // Get the request stream.  
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.  
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.  
            dataStream.Close();

            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.  
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Display the content.  
            Console.WriteLine(responseFromServer);
            // Clean up the streams.  
            reader.Close();
            dataStream.Close();
            response.Close();



        /*    if (user == null)
            {
                lblStatusLogin.Text = "Login failed, try again.";
            }
            else
            {
                // Open chatroom
                new Thread(() =>
                {
                    Application.Run(new Dashboard(user));
                }).Start();
                this.Close();
            }*/
        }
    }
}

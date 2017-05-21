using System;
using System.Net;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading;
using store_client.UserManagement;
using RestSharp;

namespace store_client.Views
{
    public partial class Home : Form
    {
        private RestClient rClient;
        private static readonly HttpClient client = new HttpClient();

        public Home()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            rClient = new RestClient("http://localhost:9000/");
            var request = new RestRequest("auth/login", Method.POST);
          
            request.AddParameter("email", txtMail.Text);
            request.AddParameter("password", txtPassword.Text);
            try
            {
                rClient.ExecuteAsync<User>(request, response =>
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        User user = new User(response.Data.email, response.Data.password, response.Data.address, response.Data.token);
                        // Open Store        
                        new Thread(() =>
                        {
                            Application.Run(new Store(user));
                        }).Start();
                        if (this.InvokeRequired)
                        {
                            this.BeginInvoke((MethodInvoker)delegate ()
                            {
                                this.Close();
                            });
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        lblStatusLogin.Text = "Login failed, try again.";
                    }
                });
            }
            catch (Exception error)
            {
                // Log
            }                              
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Commented because it's not ready to deploy

        //    rClient = new RestClient("http://localhost:9000/");
        //    var request = new RestRequest("auth/register", Method.POST);         
        }

    }
}

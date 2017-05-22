using System;

namespace store_client.UserManagement
{
    [Serializable]
    public class User
    {        
        public string email { get; set; }
        public string password { get; set; }
        public  string address { get; set; }
        public string token { get; set; }
        public string name { get; set; }

        public User() { }

        public User(string _mail, string _pass)
        {
            email = _mail;
            password = _pass;
        }

        public User(string _email, string _name, string _address, string _token, int n)
        {
            email = _email;
            name = _name;
            address = _address;
            token = _token;
        }

        public User(string _mail, string _pass, string _address, string _token)
        {
            email = _mail;
            password = _pass;
            address = _address;
            token = _token;
        }
    }
}

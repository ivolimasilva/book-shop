using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_client.UserManagement
{
    [Serializable]
    public class User
    {
        public string email { get; set; }
        public string password { get; set; }

        public User(string _mail, string _pass)
        {
            email = _mail;
            password = _pass;
        }

    }
}

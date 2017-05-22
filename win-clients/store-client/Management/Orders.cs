using store_client.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_client.Management
{
    [Serializable]
    public class Orders
    {
        public string status { get; set; }
        public string date { get; set; }
        public int total { get; set; }        
        public User user { get; set; }
        public List<Book> books { get; set; }

        public Orders() { }

        public Orders(string _status, string _date, int _total, User _user, List<Book> _books)
        {
            status = _status;
            date = _date;
            total = _total;
            user = _user;
            books = _books;
        }
    }
}

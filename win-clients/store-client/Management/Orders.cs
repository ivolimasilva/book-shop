using store_client.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_client.Management
{
    [Serializable]
    class Orders
    {
        public string state { get; set; }
        public int total { get; set; }
        public User user { get; set; }
        public List<Book> books { get; set; }

        public Orders() { }

        public Orders(string _state, int _total, User _user, List<Book> _books)
        {
            state = _state;
            total = _total;
            user = _user;
            books = _books;
        }
    }
}

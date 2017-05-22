using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_client.Management
{
    class BookToSell
    {
        public string _id { get; set; }
        public int quantity { get; set; }

        public BookToSell()
        {           
        }

        public BookToSell(string _id, int quantity)
        {
            this._id = _id;
            this.quantity = quantity;
        }
    }
}

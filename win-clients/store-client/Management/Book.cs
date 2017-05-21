using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_client.Management
{
    [Serializable]
    class Book
    {        
        public string isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int year { get; set; }
        public string publisher { get; set; }
        public float price { get; set; }
        public int  stock { get; set; }
        public string imageurl { get; set; }        

        public Book() { }

        public Book(string _isbn, string _title, string _author, int _year, string _publisher, float _price, int _stock, string _imageurl)
        {
            isbn = _isbn;
            title = _title;
            author = _author;
            year = _year;
            publisher = _publisher;
            price = _price;
            stock = _stock;
            imageurl = _imageurl;
        }

        public Book(String json)
        {
            JObject jObject = JObject.Parse(json);
            JToken jBook = jObject["book"];
            isbn = (string)jBook["isbn"];
            title = (string)jBook["title"];
            author = (string)jBook["author"];
            year = (int)jBook["year"];
            publisher = (string)jBook["publisher"];
            price = (float)jBook["price"];
            stock = (int)jBook["stock"];
            imageurl = (string)jBook["imageurl"];
        }
    }
}
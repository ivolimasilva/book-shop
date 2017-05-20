using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using store_client.UserManagement;
using System.Net;
using System.Net.Http;
using store_client.Management;
using Newtonsoft.Json;

namespace store_client.Views
{
    public partial class Store : Form
    {
        User user;        

        public Store()
        {
            InitializeComponent();
            updateBookList();
        }

        public Store(User _user)
        {
            InitializeComponent();
            user = _user;
        }

        private async void updateBookList()
        {
            listView.Items.Clear();
            HttpClient httpClient = new HttpClient();
            ListViewItem itm;
            //Book book;
            Task<String> bookInfo = getBookList("http://localhost:9000/book", httpClient);
            await bookInfo;
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(bookInfo.Result);
            // Book book = new Management.Book(bookInfo.Result);
            // Return a named reference type with a multi-line statement lambda.
            /*  Task<Test> task2 = Task<Test>.Factory.StartNew(() =>
              {
                  string s = ".NET";
                  double d = 4.0;
                  return new Test { Name = s, Number = d };
              });
              Test test = task2.Result;*/
            foreach (Book book in books)
            {
                string[] arr = new string[8];
                arr[0] = book.isbn;
                arr[1] = book.stock.ToString();
                arr[2] = book.title;
                arr[3] = book.author;
                arr[4] = book.publisher;
                arr[5] = book.price.ToString();
                arr[6] = book.year.ToString();
                itm = new ListViewItem(arr);
                listView.Items.Add(itm);
            }
       /*     string[] arr = new string[8];
            arr[0] = books[0].isbn;
            arr[1] = books[0].stock.ToString();
            arr[2] = books[0].title;
            arr[3] = books[0].author;
            arr[4] = books[0].publisher;
            arr[5] = books[0].price.ToString();
            arr[6] = books[0].year.ToString();
            itm = new ListViewItem(arr);
            listView.Items.Add(itm);*/
        }

        private async Task<String> getBookList(string url , HttpClient client)
        {
            String getInfo = await client.GetStringAsync(url);            

            return getInfo;
        }

        private void closeStore(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            updateBookList();
        }
    }
}

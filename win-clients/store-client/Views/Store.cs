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
using System.Threading;

namespace store_client.Views
{
    public partial class Store : Form
    {
        User user;
        List<Book> books = null;
        List<Orders> orders = null;

        public Store()
        {
            InitializeComponent();
            updateBookList();
            updateOrdersList();
        }

        public Store(User _user)
        {
            InitializeComponent();
            user = _user;
            updateBookList();
            updateOrdersList();
        }

        private async void updateBookList()
        {
            listViewStock.Items.Clear();
            HttpClient httpClient = new HttpClient();
            ListViewItem itm;
            Task<String> bookInfo = getBookList("http://localhost:9000/book", httpClient);
            await bookInfo;
            books = JsonConvert.DeserializeObject<List<Book>>(bookInfo.Result);

            foreach (Book book in books)
            {
                string[] arr = new string[7];
                arr[0] = book.isbn;
                arr[1] = book.stock.ToString();
                arr[2] = book.title;
                arr[3] = book.author;
                arr[4] = book.publisher;
                arr[5] = book.price.ToString();
                arr[6] = book.year.ToString();
                itm = new ListViewItem(arr);
                listViewStock.Items.Add(itm);
            }
            changeColorStock();
        }

        private async void updateOrdersList()
        {
            listViewOrders.Items.Clear();
            //HttpClient httpClient = new HttpClient();

            Uri uri = new Uri("http://localhost:9000/order");
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = new CookieContainer();            
            handler.CookieContainer.Add(uri, new Cookie("session", user.token)); // Adding a Cookie
            HttpClient httpClient = new HttpClient(handler);
            Task<String> ordersInfo = getOrdersList("http://localhost:9000/order", httpClient);
            CookieCollection collection = handler.CookieContainer.GetCookies(uri); // Retrieving a Cookie   

            ListViewItem itm;
            await ordersInfo;
            orders = JsonConvert.DeserializeObject<List<Orders>>(ordersInfo.Result);

            foreach (Orders order in orders)
            {
                string[] arr = new string[6];
                arr[0] = order.status;
                arr[1] = order.date;
                arr[2] = order.total.ToString();
                arr[3] = order.user.email;
                arr[4] = order.user.name;
                arr[5] = order.books.Count.ToString();

                itm = new ListViewItem(arr);
                listViewOrders.Items.Add(itm);
            }
        }        

        private async Task<String> getBookList(string url , HttpClient client)
        {
            String getInfo = await client.GetStringAsync(url);            

            return getInfo;
        }

        private async Task<String> getOrdersList(string url, HttpClient client)
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

        private void btnRefreshOrders_Click(object sender, EventArgs e)
        {
            updateOrdersList();
        }

        private void changeColorStock()
        {
           foreach (ListViewItem lvw in listViewStock.Items)
            {                                             
                if (Int32.Parse(lvw.SubItems[1].Text) < 10)
                {
                    lvw.BackColor = Color.Red;
                }
            }
        }

        private void listViewStock_Click(object sender, EventArgs e)
        {
            if (listViewStock.SelectedItems.Count > 0)
            {
                //MessageBox.Show(listView.SelectedItems[0].SubItems[0].Text);
                String isbn = listViewStock.SelectedItems[0].SubItems[0].Text;
                String stockNo = listViewStock.SelectedItems[0].SubItems[1].Text;
                String title = listViewStock.SelectedItems[0].SubItems[2].Text;
                new Thread(() =>
                {
                    Application.Run(new RequestStock(isbn, stockNo, title));
                }).Start();
            }                           
        }

        private void listViewOrders_Click(object sender, EventArgs e)
        {
           /* if (listViewOrders.SelectedItems.Count > 0)
            {
                //MessageBox.Show(listView.SelectedItems[0].SubItems[0].Text);
                String isbn = listViewOrders.SelectedItems[0].SubItems[0].Text;
                String stockNo = listViewOrders.SelectedItems[0].SubItems[1].Text;
                String title = listViewOrders.SelectedItems[0].SubItems[2].Text;
                new Thread(() =>
                {
                    Application.Run(new RequestStock(isbn, stockNo, title));
                }).Start();
            }*/
        }
    }
}

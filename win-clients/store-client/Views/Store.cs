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
                string[] arr = new string[8];
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
            HttpClient httpClient = new HttpClient();
            ListViewItem itm;
        }

        private async Task<String> getBookList(string url , HttpClient client)
        {
            String getInfo = await client.GetStringAsync(url);            

            return getInfo;
        }

        private async Task<String> getOrderList(string url, HttpClient client)
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
    }
}

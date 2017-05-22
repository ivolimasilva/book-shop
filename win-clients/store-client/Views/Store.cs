using Newtonsoft.Json;
using RestSharp;
using store_client.Management;
using store_client.UserManagement;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_client.Views
{
    public partial class Store : Form
    {
        User user;
        private RestClient rClient;
        List<Book> books = null;
        List<Orders> orders = null;
        List<BookToSell> booksToSell = new List<BookToSell>();
        public List<Stock> stockRequests;

        public Store()
        {
            InitializeComponent();

            rClient = new RestClient("http://localhost:9000");

            updateStock();
            updateBookList();
            updateOrdersList();
        }

        public Store(User _user)
        {
            InitializeComponent();
            rClient = new RestClient("http://localhost:9000");

            updateStock();
            user = _user;
            updateBookList();
            updateOrdersList();
            btnSale.Enabled = false;
        }

        private async void updateBookList()
        {
            listViewStock.Items.Clear();
            HttpClient httpClient = new HttpClient();
            ListViewItem itm;
            ListViewItem itm1;
            Task<String> bookInfo = getList("http://localhost:9000/book", httpClient);
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

                string[] arr1 = new string[5];
                arr1[0] = book.isbn;
                arr1[1] = book.stock.ToString();
                arr1[2] = book.title;
                arr1[3] = book.price.ToString();
                arr1[4] = book._id;

                itm = new ListViewItem(arr);
                itm1 = new ListViewItem(arr1);
                listViewStock.Items.Add(itm);
                listViewSalesList.Items.Add(itm1);
            }

            changeColorBooks();
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
            Task<String> ordersInfo = getList("http://localhost:9000/order", httpClient);
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

        private async Task<String> getList(string url, HttpClient client)
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

        private void btnRefreshSaleList_Click(object sender, EventArgs e)
        {
            updateBookList();
        }

        private void btnRefreshOrders_Click(object sender, EventArgs e)
        {
            updateOrdersList();
        }

        private void changeColorBooks()
        {
            foreach (ListViewItem lvw in listViewStock.Items)
            {
                if (Int32.Parse(lvw.SubItems[1].Text) < 10)
                {
                    lvw.BackColor = Color.Red;
                }
            }
            foreach (ListViewItem lvw in listViewSalesList.Items)
            {
                if (Int32.Parse(lvw.SubItems[1].Text) < 10)
                {
                    lvw.BackColor = Color.Red;
                }
            }
        }

        private void listViewBook_Click(object sender, EventArgs e)
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

        private void listViewSalesList_Click(object sender, EventArgs e)
        {
            if (listViewSalesList.SelectedItems.Count > 0)
            {
                ListViewItem itm;
                string[] arr = new string[4];
                arr[0] = listViewSalesList.SelectedItems[0].SubItems[2].Text;
                arr[1] = "1";
                arr[2] = listViewSalesList.SelectedItems[0].SubItems[3].Text;
                arr[3] = (Int32.Parse(arr[2]) * Int32.Parse(arr[1])).ToString();
                itm = new ListViewItem(arr);
                listViewSaleOrder.Items.Add(itm);

                /* if (txtboxSaleMail.Text.Length > 0 && txtboxSaleName.Text.Length > 0 && txtboxSaleAddress.Text.Length > 0)
                 {
                     btnSale.Enabled = true;
                 }*/
                btnSale.Enabled = true;

                // booksToSell = books.Where(_book => _book.title == bookTitle).ToList();
                var _book = new BookToSell(listViewSalesList.SelectedItems[0].SubItems[4].Text, 1);
                booksToSell.Add(_book);
            }

        }

        // http://stackoverflow.com/questions/2340439/how-to-copy-the-selected-items-from-one-listview-to-another-on-button-click-in-c
        private static void CopySelectedItems(ListView source, ListView target)
        {
            foreach (ListViewItem item in source.SelectedItems)
            {
                target.Items.Add((ListViewItem)item.Clone());
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            // rClient = new RestClient("http://localhost:9000/");
            var request = new RestRequest("order", Method.POST);

            rClient.CookieContainer = new CookieContainer();
            request.AddCookie("session", user.token);

            var json = new
            {
                user = JsonConvert.SerializeObject(new User(txtboxSaleMail.Text, txtboxSaleName.Text, txtboxSaleAddress.Text, user.token, 0)),
                books = JsonConvert.SerializeObject(booksToSell)
            };

            request.AddObject(json);
            try
            {
                rClient.ExecuteAsync<Orders>(request, response =>
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        new Thread(() =>
                        {
                            Application.Run(new Order(response.Data));
                        }).Start();
                    }
                    else
                    {
                        MessageBox.Show("Sale failed, try again.");
                    }
                });
            }
            catch (Exception error)
            {
                // Log
            }
        }

        private void btnDeleteSaleList_Click(object sender, EventArgs e)
        {
            listViewSaleOrder.Items.Clear();
        }

        private void updateStock()
        {
            var _stockRequest = new RestRequest("stock", Method.GET);
            rClient.ExecuteAsync<List<Stock>>(_stockRequest, _response =>
            {
                stockRequests = _response.Data;
                updateListStock(listStock);
            });
        }

        private void updateListStock(ListView list)
        {
            foreach (Stock stock in stockRequests)
            {
                string[] row = {
                    stock._id_order,
                    stock.isbn,
                    stock.quantity.ToString(),
                    stock.accepted.ToString()
                };

                ListViewItem item = new ListViewItem(row);

                if (list.InvokeRequired)
                {
                    list.BeginInvoke((MethodInvoker)delegate ()
                    {
                        list.Items.Add(item);
                    });
                }
                else
                {
                    list.Items.Add(item);
                }
            }
        }
    }
}

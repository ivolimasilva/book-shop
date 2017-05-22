using RestSharp;
using System.Collections.Generic;
using System.Windows.Forms;
using warehouse_client.Objects;
using System;
using System.Net;

namespace warehouse_client
{
    public partial class Home : Form
    {
        private RestClient rClient;
        public List<Book> books;
        public List<Stock> stockRequests;

        public Home()
        {
            InitializeComponent();

            rClient = new RestClient("http://localhost:9090");

            updateBooks();

            updateStock();
        }

        private void updateListStock(ListView list)
        {
            foreach (Stock stock in stockRequests)
            {
                string[] row = {
                    stock._id_order,
                    stock.isbn,
                    stock.quantity.ToString()
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

        private void updateListBook(ListView list)
        {
            foreach (Book book in books)
            {
                string[] row = {
                    book.isbn,
                    book.title,
                    book.author,
                    book.year.ToString(),
                    book.publisher,
                    book.price.ToString() + "€",
                    book.stock.ToString()
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

        private void listStock_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Accept stock request?", "Stock request", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                var stockRequest = new RestRequest("stock", Method.POST);
                stockRequest.AddParameter("_id", listStock.SelectedItems[0].Text);
                rClient.ExecuteAsync<List<Book>>(stockRequest, response =>
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        MessageBox.Show("Stock request accepted.");
                        updateStock();
                    }
                });
            }
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

        private void updateBooks()
        {
            var bookRequest = new RestRequest("book", Method.GET);
            rClient.ExecuteAsync<List<Book>>(bookRequest, response =>
            {
                books = response.Data;

                updateListBook(listBooks);
            });
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            updateStock();
        }

        private void buttonRefreshBooks_Click(object sender, EventArgs e)
        {
            updateBooks();
        }
    }
}
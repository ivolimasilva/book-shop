using RestSharp;
using System.Collections.Generic;
using System.Windows.Forms;
using warehouse_client.Objects;

namespace warehouse_client
{
    public partial class Home : Form
    {
        private RestClient rClient;
        public List<Book> books;

        public Home()
        {
            InitializeComponent();

            rClient = new RestClient("http://localhost:9090");

            var request = new RestRequest("book", Method.GET);

            rClient.ExecuteAsync<List<Book>>(request, response =>
            {
                books = response.Data;

                updateList(listStock);
            });
        }

        private void updateList(ListView list)
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
    }
}
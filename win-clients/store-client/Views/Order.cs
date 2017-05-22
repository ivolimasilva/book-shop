using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using store_client.Management;
using System.Drawing.Printing;

namespace store_client.Views
{
    public partial class Order : Form
    {
        public Order(Orders order)
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Title", typeof(string)), new DataColumn("Quantity", typeof(int)), new DataColumn("Price", typeof(float)) });
            foreach (var book in order.books)
            {
                dt.Rows.Add(book.title, book.quantity, book.price);
            }
            this.dataGridView1.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Bitmap bitmap;
        private void button1_Click(object sender, EventArgs e)
        {
            //Resize DataGridView to full height.

            int height = 2 * dataGridView1.Height;
            dataGridView1.Height = 2 * dataGridView1.RowCount * dataGridView1.RowTemplate.Height;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height * 10);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height * 10));

            //Resize DataGridView back to original height.
            dataGridView1.Height = height * 10;

            //Show the Print Preview Dialog.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}

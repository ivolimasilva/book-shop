using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_client.Views
{
    public partial class RequestStock : Form
    {
        public RequestStock()
        {
            InitializeComponent();
        }

        public RequestStock(String isbn, String stockNo, String title)
        {
            InitializeComponent();
            this.Text = isbn;
            lblCurrent.Text = stockNo;
            lblTitle.Text = title;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

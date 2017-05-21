namespace store_client.Views
{
    partial class Store
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.stockPage = new System.Windows.Forms.TabPage();
            this.btnRefreshStock = new System.Windows.Forms.Button();
            this.listViewStock = new System.Windows.Forms.ListView();
            this.isbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unit_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageOrder = new System.Windows.Forms.TabPage();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefreshOrders = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.stockPage.SuspendLayout();
            this.pageOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.stockPage);
            this.tabControl.Controls.Add(this.pageOrder);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(25, 28);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1008, 562);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            // 
            // stockPage
            // 
            this.stockPage.Controls.Add(this.btnRefreshStock);
            this.stockPage.Controls.Add(this.listViewStock);
            this.stockPage.Location = new System.Drawing.Point(4, 4);
            this.stockPage.Name = "stockPage";
            this.stockPage.Padding = new System.Windows.Forms.Padding(3);
            this.stockPage.Size = new System.Drawing.Size(1000, 526);
            this.stockPage.TabIndex = 0;
            this.stockPage.Text = "Stock";
            this.stockPage.UseVisualStyleBackColor = true;
            // 
            // btnRefreshStock
            // 
            this.btnRefreshStock.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshStock.Image")));
            this.btnRefreshStock.Location = new System.Drawing.Point(3, 8);
            this.btnRefreshStock.Name = "btnRefreshStock";
            this.btnRefreshStock.Size = new System.Drawing.Size(25, 27);
            this.btnRefreshStock.TabIndex = 1;
            this.btnRefreshStock.UseVisualStyleBackColor = true;
            this.btnRefreshStock.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // listViewStock
            // 
            this.listViewStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.isbn,
            this.stock,
            this.title,
            this.author,
            this.publisher,
            this.unit_Price,
            this.year});
            this.listViewStock.FullRowSelect = true;
            this.listViewStock.Location = new System.Drawing.Point(34, 8);
            this.listViewStock.Name = "listViewStock";
            this.listViewStock.Size = new System.Drawing.Size(958, 512);
            this.listViewStock.TabIndex = 0;
            this.listViewStock.UseCompatibleStateImageBehavior = false;
            this.listViewStock.View = System.Windows.Forms.View.Details;
            this.listViewStock.Click += new System.EventHandler(this.listViewStock_Click);
            // 
            // isbn
            // 
            this.isbn.Text = "ISBN";
            this.isbn.Width = 110;
            // 
            // stock
            // 
            this.stock.Text = "Stock";
            this.stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stock.Width = 55;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.Width = 250;
            // 
            // author
            // 
            this.author.Text = "Author";
            this.author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.author.Width = 250;
            // 
            // publisher
            // 
            this.publisher.Text = "Publisher";
            this.publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.publisher.Width = 125;
            // 
            // unit_Price
            // 
            this.unit_Price.Text = "Price (Unit)";
            this.unit_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unit_Price.Width = 100;
            // 
            // year
            // 
            this.year.Text = "Year";
            this.year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.year.Width = 55;
            // 
            // pageOrder
            // 
            this.pageOrder.Controls.Add(this.listViewOrders);
            this.pageOrder.Controls.Add(this.btnRefreshOrders);
            this.pageOrder.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageOrder.Location = new System.Drawing.Point(4, 4);
            this.pageOrder.Name = "pageOrder";
            this.pageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.pageOrder.Size = new System.Drawing.Size(1000, 526);
            this.pageOrder.TabIndex = 1;
            this.pageOrder.Text = "Orders";
            this.pageOrder.UseVisualStyleBackColor = true;
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.state,
            this.total,
            this.email});
            this.listViewOrders.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.Location = new System.Drawing.Point(34, 8);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(958, 512);
            this.listViewOrders.TabIndex = 3;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // state
            // 
            this.state.Text = "State";
            this.state.Width = 200;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.total.Width = 80;
            // 
            // email
            // 
            this.email.Text = "email";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email.Width = 200;
            // 
            // btnRefreshOrders
            // 
            this.btnRefreshOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshOrders.Image")));
            this.btnRefreshOrders.Location = new System.Drawing.Point(3, 8);
            this.btnRefreshOrders.Name = "btnRefreshOrders";
            this.btnRefreshOrders.Size = new System.Drawing.Size(25, 27);
            this.btnRefreshOrders.TabIndex = 2;
            this.btnRefreshOrders.UseVisualStyleBackColor = true;
            this.btnRefreshOrders.Click += new System.EventHandler(this.btnRefreshOrders_Click);
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.tabControl);
            this.Name = "Store";
            this.Text = "Store";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeStore);
            this.tabControl.ResumeLayout(false);
            this.stockPage.ResumeLayout(false);
            this.pageOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageOrder;
        private System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.ListView listViewStock;
        private System.Windows.Forms.ColumnHeader isbn;
        private System.Windows.Forms.ColumnHeader stock;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader publisher;
        private System.Windows.Forms.ColumnHeader unit_Price;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.Button btnRefreshStock;
        private System.Windows.Forms.Button btnRefreshOrders;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader email;
    }
}
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
            this.bookIsbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageOrder = new System.Windows.Forms.TabPage();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalBooks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefreshOrders = new System.Windows.Forms.Button();
            this.stockReq = new System.Windows.Forms.TabPage();
            this.listStock = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAccepted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sale = new System.Windows.Forms.TabPage();
            this.btnDeleteSaleList = new System.Windows.Forms.Button();
            this.btnRefreshSaleList = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.listViewSaleOrder = new System.Windows.Forms.ListView();
            this.orderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtboxSaleAddress = new System.Windows.Forms.TextBox();
            this.txtboxSaleName = new System.Windows.Forms.TextBox();
            this.txtboxSaleMail = new System.Windows.Forms.TextBox();
            this.lblSaleAddress = new System.Windows.Forms.Label();
            this.lblSaleName = new System.Windows.Forms.Label();
            this.lblSaleMail = new System.Windows.Forms.Label();
            this.listViewSalesList = new System.Windows.Forms.ListView();
            this.saleISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saleStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saleTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.stockPage.SuspendLayout();
            this.pageOrder.SuspendLayout();
            this.stockReq.SuspendLayout();
            this.sale.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.stockPage);
            this.tabControl.Controls.Add(this.pageOrder);
            this.tabControl.Controls.Add(this.stockReq);
            this.tabControl.Controls.Add(this.sale);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(25, 28);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1264, 730);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            // 
            // stockPage
            // 
            this.stockPage.Controls.Add(this.btnRefreshStock);
            this.stockPage.Controls.Add(this.listViewStock);
            this.stockPage.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockPage.Location = new System.Drawing.Point(4, 4);
            this.stockPage.Name = "stockPage";
            this.stockPage.Padding = new System.Windows.Forms.Padding(3);
            this.stockPage.Size = new System.Drawing.Size(1256, 694);
            this.stockPage.TabIndex = 0;
            this.stockPage.Text = "Books";
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
            this.bookIsbn,
            this.bookStock,
            this.bookTitle,
            this.bookAuthor,
            this.publisher,
            this.bookPrice,
            this.bookYear});
            this.listViewStock.FullRowSelect = true;
            this.listViewStock.Location = new System.Drawing.Point(34, 8);
            this.listViewStock.Name = "listViewStock";
            this.listViewStock.Size = new System.Drawing.Size(1219, 680);
            this.listViewStock.TabIndex = 0;
            this.listViewStock.UseCompatibleStateImageBehavior = false;
            this.listViewStock.View = System.Windows.Forms.View.Details;
            this.listViewStock.Click += new System.EventHandler(this.listViewBook_Click);
            // 
            // bookIsbn
            // 
            this.bookIsbn.Text = "ISBN";
            this.bookIsbn.Width = 110;
            // 
            // bookStock
            // 
            this.bookStock.Text = "Stock";
            this.bookStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookStock.Width = 55;
            // 
            // bookTitle
            // 
            this.bookTitle.Text = "Title";
            this.bookTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookTitle.Width = 300;
            // 
            // bookAuthor
            // 
            this.bookAuthor.Text = "Author";
            this.bookAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookAuthor.Width = 250;
            // 
            // publisher
            // 
            this.publisher.Text = "Publisher";
            this.publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.publisher.Width = 125;
            // 
            // bookPrice
            // 
            this.bookPrice.Text = "Price (Unit)";
            this.bookPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookPrice.Width = 120;
            // 
            // bookYear
            // 
            this.bookYear.Text = "Year";
            this.bookYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookYear.Width = 55;
            // 
            // pageOrder
            // 
            this.pageOrder.Controls.Add(this.listViewOrders);
            this.pageOrder.Controls.Add(this.btnRefreshOrders);
            this.pageOrder.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageOrder.Location = new System.Drawing.Point(4, 4);
            this.pageOrder.Name = "pageOrder";
            this.pageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.pageOrder.Size = new System.Drawing.Size(1256, 694);
            this.pageOrder.TabIndex = 1;
            this.pageOrder.Text = "Orders";
            this.pageOrder.UseVisualStyleBackColor = true;
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.status,
            this.date,
            this.total,
            this.email,
            this.name,
            this.totalBooks});
            this.listViewOrders.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.Location = new System.Drawing.Point(34, 8);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(1214, 680);
            this.listViewOrders.TabIndex = 3;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 240;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.Width = 120;
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
            // name
            // 
            this.name.Text = "Name";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 120;
            // 
            // totalBooks
            // 
            this.totalBooks.Text = "Total Books";
            this.totalBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalBooks.Width = 120;
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
            // stockReq
            // 
            this.stockReq.Controls.Add(this.listStock);
            this.stockReq.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockReq.Location = new System.Drawing.Point(4, 4);
            this.stockReq.Name = "stockReq";
            this.stockReq.Size = new System.Drawing.Size(1256, 694);
            this.stockReq.TabIndex = 2;
            this.stockReq.Text = "Stock Requests";
            this.stockReq.UseVisualStyleBackColor = true;
            // 
            // listStock
            // 
            this.listStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnOrderID,
            this.columnISBN,
            this.columnQuantity,
            this.columnAccepted});
            this.listStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listStock.Location = new System.Drawing.Point(0, 0);
            this.listStock.Name = "listStock";
            this.listStock.Size = new System.Drawing.Size(1256, 694);
            this.listStock.TabIndex = 0;
            this.listStock.UseCompatibleStateImageBehavior = false;
            this.listStock.View = System.Windows.Forms.View.Details;
            this.listStock.Click += new System.EventHandler(this.listStock_Click);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnOrderID
            // 
            this.columnOrderID.Text = "Order ID";
            this.columnOrderID.Width = 352;
            // 
            // columnISBN
            // 
            this.columnISBN.Text = "ISBN";
            this.columnISBN.Width = 371;
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "Quantity";
            this.columnQuantity.Width = 122;
            // 
            // columnAccepted
            // 
            this.columnAccepted.Text = "Accepted";
            this.columnAccepted.Width = 110;
            // 
            // sale
            // 
            this.sale.Controls.Add(this.btnDeleteSaleList);
            this.sale.Controls.Add(this.btnRefreshSaleList);
            this.sale.Controls.Add(this.btnSale);
            this.sale.Controls.Add(this.listViewSaleOrder);
            this.sale.Controls.Add(this.txtboxSaleAddress);
            this.sale.Controls.Add(this.txtboxSaleName);
            this.sale.Controls.Add(this.txtboxSaleMail);
            this.sale.Controls.Add(this.lblSaleAddress);
            this.sale.Controls.Add(this.lblSaleName);
            this.sale.Controls.Add(this.lblSaleMail);
            this.sale.Controls.Add(this.listViewSalesList);
            this.sale.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale.Location = new System.Drawing.Point(4, 4);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(1256, 694);
            this.sale.TabIndex = 3;
            this.sale.Text = "Store Sale";
            this.sale.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSaleList
            // 
            this.btnDeleteSaleList.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSaleList.Image")));
            this.btnDeleteSaleList.Location = new System.Drawing.Point(522, 41);
            this.btnDeleteSaleList.Name = "btnDeleteSaleList";
            this.btnDeleteSaleList.Size = new System.Drawing.Size(25, 27);
            this.btnDeleteSaleList.TabIndex = 10;
            this.btnDeleteSaleList.UseVisualStyleBackColor = true;
            this.btnDeleteSaleList.Click += new System.EventHandler(this.btnDeleteSaleList_Click);
            // 
            // btnRefreshSaleList
            // 
            this.btnRefreshSaleList.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshSaleList.Image")));
            this.btnRefreshSaleList.Location = new System.Drawing.Point(522, 8);
            this.btnRefreshSaleList.Name = "btnRefreshSaleList";
            this.btnRefreshSaleList.Size = new System.Drawing.Size(25, 27);
            this.btnRefreshSaleList.TabIndex = 9;
            this.btnRefreshSaleList.UseVisualStyleBackColor = true;
            this.btnRefreshSaleList.Click += new System.EventHandler(this.btnRefreshSaleList_Click);
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(855, 648);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(75, 30);
            this.btnSale.TabIndex = 8;
            this.btnSale.Text = "Sell";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // listViewSaleOrder
            // 
            this.listViewSaleOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderTitle,
            this.orderQuantity,
            this.orderPrice,
            this.orderTotal});
            this.listViewSaleOrder.Location = new System.Drawing.Point(522, 80);
            this.listViewSaleOrder.Name = "listViewSaleOrder";
            this.listViewSaleOrder.Size = new System.Drawing.Size(726, 562);
            this.listViewSaleOrder.TabIndex = 7;
            this.listViewSaleOrder.UseCompatibleStateImageBehavior = false;
            this.listViewSaleOrder.View = System.Windows.Forms.View.Details;
            // 
            // orderTitle
            // 
            this.orderTitle.Text = "Title";
            this.orderTitle.Width = 250;
            // 
            // orderQuantity
            // 
            this.orderQuantity.Text = "Quantity";
            this.orderQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orderQuantity.Width = 100;
            // 
            // orderPrice
            // 
            this.orderPrice.Text = "Price (Unit)";
            this.orderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orderPrice.Width = 120;
            // 
            // orderTotal
            // 
            this.orderTotal.Text = "Total";
            this.orderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxSaleAddress
            // 
            this.txtboxSaleAddress.Location = new System.Drawing.Point(653, 44);
            this.txtboxSaleAddress.Name = "txtboxSaleAddress";
            this.txtboxSaleAddress.Size = new System.Drawing.Size(500, 30);
            this.txtboxSaleAddress.TabIndex = 6;
            // 
            // txtboxSaleName
            // 
            this.txtboxSaleName.Location = new System.Drawing.Point(998, 8);
            this.txtboxSaleName.Name = "txtboxSaleName";
            this.txtboxSaleName.Size = new System.Drawing.Size(250, 30);
            this.txtboxSaleName.TabIndex = 5;
            // 
            // txtboxSaleMail
            // 
            this.txtboxSaleMail.Location = new System.Drawing.Point(653, 8);
            this.txtboxSaleMail.Name = "txtboxSaleMail";
            this.txtboxSaleMail.Size = new System.Drawing.Size(250, 30);
            this.txtboxSaleMail.TabIndex = 4;
            // 
            // lblSaleAddress
            // 
            this.lblSaleAddress.AutoSize = true;
            this.lblSaleAddress.Location = new System.Drawing.Point(572, 47);
            this.lblSaleAddress.Name = "lblSaleAddress";
            this.lblSaleAddress.Size = new System.Drawing.Size(75, 23);
            this.lblSaleAddress.TabIndex = 3;
            this.lblSaleAddress.Text = "Address";
            // 
            // lblSaleName
            // 
            this.lblSaleName.AutoSize = true;
            this.lblSaleName.Location = new System.Drawing.Point(922, 11);
            this.lblSaleName.Name = "lblSaleName";
            this.lblSaleName.Size = new System.Drawing.Size(57, 23);
            this.lblSaleName.TabIndex = 2;
            this.lblSaleName.Text = "Name";
            // 
            // lblSaleMail
            // 
            this.lblSaleMail.AutoSize = true;
            this.lblSaleMail.Location = new System.Drawing.Point(572, 11);
            this.lblSaleMail.Name = "lblSaleMail";
            this.lblSaleMail.Size = new System.Drawing.Size(46, 23);
            this.lblSaleMail.TabIndex = 1;
            this.lblSaleMail.Text = "Mail";
            // 
            // listViewSalesList
            // 
            this.listViewSalesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.saleISBN,
            this.saleStock,
            this.saleTitle,
            this.salePrice});
            this.listViewSalesList.Location = new System.Drawing.Point(3, 8);
            this.listViewSalesList.Name = "listViewSalesList";
            this.listViewSalesList.Size = new System.Drawing.Size(512, 683);
            this.listViewSalesList.TabIndex = 0;
            this.listViewSalesList.UseCompatibleStateImageBehavior = false;
            this.listViewSalesList.View = System.Windows.Forms.View.Details;
            this.listViewSalesList.Click += new System.EventHandler(this.listViewSalesList_Click);
            // 
            // saleISBN
            // 
            this.saleISBN.Text = "ISBN";
            this.saleISBN.Width = 110;
            // 
            // saleStock
            // 
            this.saleStock.Text = "Stock";
            this.saleStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saleStock.Width = 55;
            // 
            // saleTitle
            // 
            this.saleTitle.Text = "Title";
            this.saleTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saleTitle.Width = 200;
            // 
            // salePrice
            // 
            this.salePrice.Text = "Price (Unit)";
            this.salePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salePrice.Width = 120;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 730);
            this.Controls.Add(this.tabControl);
            this.Name = "Store";
            this.Text = "Store";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeStore);
            this.tabControl.ResumeLayout(false);
            this.stockPage.ResumeLayout(false);
            this.pageOrder.ResumeLayout(false);
            this.stockReq.ResumeLayout(false);
            this.sale.ResumeLayout(false);
            this.sale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageOrder;
        private System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.ListView listViewStock;
        private System.Windows.Forms.ColumnHeader bookIsbn;
        private System.Windows.Forms.ColumnHeader bookStock;
        private System.Windows.Forms.ColumnHeader bookTitle;
        private System.Windows.Forms.ColumnHeader bookAuthor;
        private System.Windows.Forms.ColumnHeader publisher;
        private System.Windows.Forms.ColumnHeader bookPrice;
        private System.Windows.Forms.ColumnHeader bookYear;
        private System.Windows.Forms.Button btnRefreshStock;
        private System.Windows.Forms.Button btnRefreshOrders;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader totalBooks;
        private System.Windows.Forms.TabPage stockReq;
        private System.Windows.Forms.TabPage sale;
        private System.Windows.Forms.TextBox txtboxSaleAddress;
        private System.Windows.Forms.TextBox txtboxSaleName;
        private System.Windows.Forms.TextBox txtboxSaleMail;
        private System.Windows.Forms.Label lblSaleAddress;
        private System.Windows.Forms.Label lblSaleName;
        private System.Windows.Forms.Label lblSaleMail;
        private System.Windows.Forms.ListView listViewSalesList;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.ListView listViewSaleOrder;
        private System.Windows.Forms.ColumnHeader saleISBN;
        private System.Windows.Forms.ColumnHeader saleStock;
        private System.Windows.Forms.ColumnHeader saleTitle;
        private System.Windows.Forms.ColumnHeader salePrice;
        private System.Windows.Forms.Button btnRefreshSaleList;
        private System.Windows.Forms.ColumnHeader orderTitle;
        private System.Windows.Forms.ColumnHeader orderQuantity;
        private System.Windows.Forms.ColumnHeader orderPrice;
        private System.Windows.Forms.ColumnHeader orderTotal;
        private System.Windows.Forms.Button btnDeleteSaleList;
        private System.Windows.Forms.ListView listStock;
        private System.Windows.Forms.ColumnHeader columnOrderID;
        private System.Windows.Forms.ColumnHeader columnISBN;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.ColumnHeader columnAccepted;
        private System.Windows.Forms.ColumnHeader columnID;
    }
}
namespace warehouse_client
{
    partial class Home
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageBooks = new System.Windows.Forms.TabPage();
            this.listBooks = new System.Windows.Forms.ListView();
            this.columnISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageStock = new System.Windows.Forms.TabPage();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.listStock = new System.Windows.Forms.ListView();
            this.columnOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnISBNStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRefreshBooks = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.pageBooks.SuspendLayout();
            this.pageStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageBooks);
            this.tabControl.Controls.Add(this.pageStock);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1264, 681);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            // 
            // pageBooks
            // 
            this.pageBooks.Controls.Add(this.buttonRefreshBooks);
            this.pageBooks.Controls.Add(this.listBooks);
            this.pageBooks.Location = new System.Drawing.Point(4, 27);
            this.pageBooks.Name = "pageBooks";
            this.pageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.pageBooks.Size = new System.Drawing.Size(1256, 650);
            this.pageBooks.TabIndex = 0;
            this.pageBooks.Text = "Books";
            this.pageBooks.UseVisualStyleBackColor = true;
            // 
            // listBooks
            // 
            this.listBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnISBN,
            this.columnTitle,
            this.columnAuthor,
            this.columnYear,
            this.columnPublisher,
            this.columnPrice,
            this.columnStock});
            this.listBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBooks.Location = new System.Drawing.Point(3, 3);
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(1250, 644);
            this.listBooks.TabIndex = 0;
            this.listBooks.UseCompatibleStateImageBehavior = false;
            this.listBooks.View = System.Windows.Forms.View.Details;
            // 
            // columnISBN
            // 
            this.columnISBN.Text = "ISBN";
            this.columnISBN.Width = 150;
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            this.columnTitle.Width = 721;
            // 
            // columnAuthor
            // 
            this.columnAuthor.Text = "Author";
            this.columnAuthor.Width = 101;
            // 
            // columnYear
            // 
            this.columnYear.Text = "Year";
            this.columnYear.Width = 50;
            // 
            // columnPublisher
            // 
            this.columnPublisher.Text = "Publisher";
            this.columnPublisher.Width = 100;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 50;
            // 
            // columnStock
            // 
            this.columnStock.Text = "Units";
            this.columnStock.Width = 50;
            // 
            // pageStock
            // 
            this.pageStock.Controls.Add(this.buttonRefresh);
            this.pageStock.Controls.Add(this.listStock);
            this.pageStock.Location = new System.Drawing.Point(4, 27);
            this.pageStock.Name = "pageStock";
            this.pageStock.Padding = new System.Windows.Forms.Padding(3);
            this.pageStock.Size = new System.Drawing.Size(1256, 650);
            this.pageStock.TabIndex = 1;
            this.pageStock.Text = "Stock Requests";
            this.pageStock.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(1173, 619);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // listStock
            // 
            this.listStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOrderID,
            this.columnISBNStock,
            this.columnQuantity});
            this.listStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listStock.Location = new System.Drawing.Point(3, 3);
            this.listStock.Name = "listStock";
            this.listStock.Size = new System.Drawing.Size(1250, 644);
            this.listStock.TabIndex = 0;
            this.listStock.UseCompatibleStateImageBehavior = false;
            this.listStock.View = System.Windows.Forms.View.Details;
            this.listStock.Click += new System.EventHandler(this.listStock_Click);
            // 
            // columnOrderID
            // 
            this.columnOrderID.Text = "Order ID";
            this.columnOrderID.Width = 174;
            // 
            // columnISBNStock
            // 
            this.columnISBNStock.Text = "ISBN";
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "Quantity";
            this.columnQuantity.Width = 90;
            // 
            // buttonRefreshBooks
            // 
            this.buttonRefreshBooks.Location = new System.Drawing.Point(1175, 619);
            this.buttonRefreshBooks.Name = "buttonRefreshBooks";
            this.buttonRefreshBooks.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshBooks.TabIndex = 1;
            this.buttonRefreshBooks.Text = "Refresh";
            this.buttonRefreshBooks.UseVisualStyleBackColor = true;
            this.buttonRefreshBooks.Click += new System.EventHandler(this.buttonRefreshBooks_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.tabControl.ResumeLayout(false);
            this.pageBooks.ResumeLayout(false);
            this.pageStock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageBooks;
        private System.Windows.Forms.TabPage pageStock;
        private System.Windows.Forms.ListView listBooks;
        private System.Windows.Forms.ColumnHeader columnISBN;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnAuthor;
        private System.Windows.Forms.ColumnHeader columnYear;
        private System.Windows.Forms.ColumnHeader columnPublisher;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnStock;
        private System.Windows.Forms.ListView listStock;
        private System.Windows.Forms.ColumnHeader columnISBNStock;
        private System.Windows.Forms.ColumnHeader columnOrderID;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonRefreshBooks;
    }
}
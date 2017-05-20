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
            this.listView = new System.Windows.Forms.ListView();
            this.isbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unit_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageOrder = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.stockPage.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(624, 442);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            // 
            // stockPage
            // 
            this.stockPage.Controls.Add(this.btnRefresh);
            this.stockPage.Controls.Add(this.listView);
            this.stockPage.Location = new System.Drawing.Point(4, 4);
            this.stockPage.Name = "stockPage";
            this.stockPage.Padding = new System.Windows.Forms.Padding(3);
            this.stockPage.Size = new System.Drawing.Size(616, 406);
            this.stockPage.TabIndex = 0;
            this.stockPage.Text = "Stock";
            this.stockPage.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.isbn,
            this.stock,
            this.title,
            this.author,
            this.publisher,
            this.unit_Price,
            this.year});
            this.listView.Location = new System.Drawing.Point(34, 8);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(582, 395);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // isbn
            // 
            this.isbn.Text = "ISBN";
            // 
            // stock
            // 
            this.stock.Text = "Stock";
            // 
            // title
            // 
            this.title.Text = "Title";
            // 
            // author
            // 
            this.author.Text = "Author";
            // 
            // publisher
            // 
            this.publisher.Text = "Publisher";
            // 
            // unit_Price
            // 
            this.unit_Price.Text = "Price (Unit)";
            // 
            // year
            // 
            this.year.Text = "Year";
            // 
            // pageOrder
            // 
            this.pageOrder.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageOrder.Location = new System.Drawing.Point(4, 4);
            this.pageOrder.Name = "pageOrder";
            this.pageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.pageOrder.Size = new System.Drawing.Size(616, 406);
            this.pageOrder.TabIndex = 1;
            this.pageOrder.Text = "Orders";
            this.pageOrder.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(3, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 27);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tabControl);
            this.Name = "Store";
            this.Text = "Store";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeStore);
            this.tabControl.ResumeLayout(false);
            this.stockPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageOrder;
        private System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader isbn;
        private System.Windows.Forms.ColumnHeader stock;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader publisher;
        private System.Windows.Forms.ColumnHeader unit_Price;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.Button btnRefresh;
    }
}
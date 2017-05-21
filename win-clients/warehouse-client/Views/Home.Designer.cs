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
            this.pageStock = new System.Windows.Forms.TabPage();
            this.listStock = new System.Windows.Forms.ListView();
            this.columnISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageOrders = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.pageStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageStock);
            this.tabControl.Controls.Add(this.pageOrders);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1264, 681);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            // 
            // pageStock
            // 
            this.pageStock.Controls.Add(this.listStock);
            this.pageStock.Location = new System.Drawing.Point(4, 27);
            this.pageStock.Name = "pageStock";
            this.pageStock.Padding = new System.Windows.Forms.Padding(3);
            this.pageStock.Size = new System.Drawing.Size(1256, 650);
            this.pageStock.TabIndex = 0;
            this.pageStock.Text = "Stock";
            this.pageStock.UseVisualStyleBackColor = true;
            // 
            // listStock
            // 
            this.listStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnISBN,
            this.columnTitle,
            this.columnAuthor,
            this.columnYear,
            this.columnPublisher,
            this.columnPrice,
            this.columnStock});
            this.listStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listStock.Location = new System.Drawing.Point(3, 3);
            this.listStock.Name = "listStock";
            this.listStock.Size = new System.Drawing.Size(1250, 644);
            this.listStock.TabIndex = 0;
            this.listStock.UseCompatibleStateImageBehavior = false;
            this.listStock.View = System.Windows.Forms.View.Details;
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
            // pageOrders
            // 
            this.pageOrders.Location = new System.Drawing.Point(4, 27);
            this.pageOrders.Name = "pageOrders";
            this.pageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.pageOrders.Size = new System.Drawing.Size(1256, 650);
            this.pageOrders.TabIndex = 1;
            this.pageOrders.Text = "Orders";
            this.pageOrders.UseVisualStyleBackColor = true;
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
            this.pageStock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageStock;
        private System.Windows.Forms.TabPage pageOrders;
        private System.Windows.Forms.ListView listStock;
        private System.Windows.Forms.ColumnHeader columnISBN;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnAuthor;
        private System.Windows.Forms.ColumnHeader columnYear;
        private System.Windows.Forms.ColumnHeader columnPublisher;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnStock;
    }
}
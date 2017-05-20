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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageOrder = new System.Windows.Forms.TabPage();
            this.stockPage = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
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
            // stockPage
            // 
            this.stockPage.Location = new System.Drawing.Point(4, 4);
            this.stockPage.Name = "stockPage";
            this.stockPage.Padding = new System.Windows.Forms.Padding(3);
            this.stockPage.Size = new System.Drawing.Size(616, 406);
            this.stockPage.TabIndex = 0;
            this.stockPage.Text = "Stock";
            this.stockPage.UseVisualStyleBackColor = true;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tabControl);
            this.Name = "Store";
            this.Text = "Store";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageOrder;
        private System.Windows.Forms.TabPage stockPage;
    }
}
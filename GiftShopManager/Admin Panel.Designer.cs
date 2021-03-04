namespace GiftShopManager
{
    partial class Admin_Panel
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
            this.LblAvailableItem = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnInsertItem = new System.Windows.Forms.Button();
            this.BtnUpdateItem = new System.Windows.Forms.Button();
            this.BtnDeleteItem = new System.Windows.Forms.Button();
            this.TxtQuan = new System.Windows.Forms.TextBox();
            this.TxtItems = new System.Windows.Forms.TextBox();
            this.TxtPrices = new System.Windows.Forms.TextBox();
            this.LblItems = new System.Windows.Forms.Label();
            this.LblQuan = new System.Windows.Forms.Label();
            this.LblPrices = new System.Windows.Forms.Label();
            this.BtnAdminLogout = new System.Windows.Forms.Button();
            this.BtnSalesReport = new System.Windows.Forms.Button();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.TxtSale = new System.Windows.Forms.TextBox();
            this.LblProfit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtProfit = new System.Windows.Forms.TextBox();
            this.LblHaving = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAvailableItem
            // 
            this.LblAvailableItem.AutoSize = true;
            this.LblAvailableItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblAvailableItem.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAvailableItem.Location = new System.Drawing.Point(61, 145);
            this.LblAvailableItem.Name = "LblAvailableItem";
            this.LblAvailableItem.Size = new System.Drawing.Size(124, 19);
            this.LblAvailableItem.TabIndex = 0;
            this.LblAvailableItem.Text = "Available Items :";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewItems.Location = new System.Drawing.Point(59, 178);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(688, 475);
            this.dataGridViewItems.TabIndex = 1;
            this.dataGridViewItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewItems_MouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "ITEMS";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "QUANTITY";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "BUYING PRICE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SELLING PRICE";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // BtnInsertItem
            // 
            this.BtnInsertItem.BackColor = System.Drawing.Color.Lavender;
            this.BtnInsertItem.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertItem.Location = new System.Drawing.Point(736, 17);
            this.BtnInsertItem.Name = "BtnInsertItem";
            this.BtnInsertItem.Size = new System.Drawing.Size(441, 41);
            this.BtnInsertItem.TabIndex = 2;
            this.BtnInsertItem.Text = "INSERT";
            this.BtnInsertItem.UseVisualStyleBackColor = false;
            this.BtnInsertItem.Click += new System.EventHandler(this.BtnInsertItem_Click);
            // 
            // BtnUpdateItem
            // 
            this.BtnUpdateItem.BackColor = System.Drawing.Color.Lavender;
            this.BtnUpdateItem.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateItem.Location = new System.Drawing.Point(736, 63);
            this.BtnUpdateItem.Name = "BtnUpdateItem";
            this.BtnUpdateItem.Size = new System.Drawing.Size(441, 41);
            this.BtnUpdateItem.TabIndex = 2;
            this.BtnUpdateItem.Text = "UPDATE";
            this.BtnUpdateItem.UseVisualStyleBackColor = false;
            this.BtnUpdateItem.Click += new System.EventHandler(this.BtnUpdateItem_Click);
            // 
            // BtnDeleteItem
            // 
            this.BtnDeleteItem.BackColor = System.Drawing.Color.Lavender;
            this.BtnDeleteItem.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteItem.Location = new System.Drawing.Point(736, 108);
            this.BtnDeleteItem.Name = "BtnDeleteItem";
            this.BtnDeleteItem.Size = new System.Drawing.Size(441, 41);
            this.BtnDeleteItem.TabIndex = 2;
            this.BtnDeleteItem.Text = "DELETE";
            this.BtnDeleteItem.UseVisualStyleBackColor = false;
            this.BtnDeleteItem.Click += new System.EventHandler(this.BtnDeleteItem_Click);
            // 
            // TxtQuan
            // 
            this.TxtQuan.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuan.Location = new System.Drawing.Point(522, 24);
            this.TxtQuan.Name = "TxtQuan";
            this.TxtQuan.Size = new System.Drawing.Size(165, 21);
            this.TxtQuan.TabIndex = 3;
            // 
            // TxtItems
            // 
            this.TxtItems.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtItems.Location = new System.Drawing.Point(209, 24);
            this.TxtItems.Name = "TxtItems";
            this.TxtItems.Size = new System.Drawing.Size(165, 21);
            this.TxtItems.TabIndex = 4;
            // 
            // TxtPrices
            // 
            this.TxtPrices.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrices.Location = new System.Drawing.Point(209, 61);
            this.TxtPrices.Name = "TxtPrices";
            this.TxtPrices.Size = new System.Drawing.Size(165, 21);
            this.TxtPrices.TabIndex = 5;
            // 
            // LblItems
            // 
            this.LblItems.AutoSize = true;
            this.LblItems.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblItems.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItems.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblItems.Location = new System.Drawing.Point(65, 27);
            this.LblItems.Name = "LblItems";
            this.LblItems.Size = new System.Drawing.Size(42, 14);
            this.LblItems.TabIndex = 6;
            this.LblItems.Text = "ITEM:";
            // 
            // LblQuan
            // 
            this.LblQuan.AutoSize = true;
            this.LblQuan.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblQuan.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblQuan.Location = new System.Drawing.Point(413, 24);
            this.LblQuan.Name = "LblQuan";
            this.LblQuan.Size = new System.Drawing.Size(78, 14);
            this.LblQuan.TabIndex = 6;
            this.LblQuan.Text = "QUANTITY:";
            // 
            // LblPrices
            // 
            this.LblPrices.AutoSize = true;
            this.LblPrices.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblPrices.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrices.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblPrices.Location = new System.Drawing.Point(65, 64);
            this.LblPrices.Name = "LblPrices";
            this.LblPrices.Size = new System.Drawing.Size(101, 14);
            this.LblPrices.TabIndex = 6;
            this.LblPrices.Text = "BUYING PRICE:";
            // 
            // BtnAdminLogout
            // 
            this.BtnAdminLogout.BackColor = System.Drawing.Color.Lavender;
            this.BtnAdminLogout.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdminLogout.Location = new System.Drawing.Point(885, 513);
            this.BtnAdminLogout.Name = "BtnAdminLogout";
            this.BtnAdminLogout.Size = new System.Drawing.Size(191, 56);
            this.BtnAdminLogout.TabIndex = 7;
            this.BtnAdminLogout.Text = "LOGOUT";
            this.BtnAdminLogout.UseVisualStyleBackColor = false;
            this.BtnAdminLogout.Click += new System.EventHandler(this.BtnAdminLogout_Click);
            // 
            // BtnSalesReport
            // 
            this.BtnSalesReport.BackColor = System.Drawing.Color.Lavender;
            this.BtnSalesReport.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalesReport.Location = new System.Drawing.Point(885, 442);
            this.BtnSalesReport.Name = "BtnSalesReport";
            this.BtnSalesReport.Size = new System.Drawing.Size(191, 62);
            this.BtnSalesReport.TabIndex = 8;
            this.BtnSalesReport.Text = "TOTAL SALES REPORT";
            this.BtnSalesReport.UseVisualStyleBackColor = false;
            this.BtnSalesReport.Click += new System.EventHandler(this.BtnSalesReport_Click);
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.Color.Lavender;
            this.BtnOrder.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.Location = new System.Drawing.Point(885, 375);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(191, 58);
            this.BtnOrder.TabIndex = 9;
            this.BtnOrder.Text = "NEW ORDER";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // TxtSale
            // 
            this.TxtSale.Location = new System.Drawing.Point(209, 99);
            this.TxtSale.Name = "TxtSale";
            this.TxtSale.Size = new System.Drawing.Size(165, 21);
            this.TxtSale.TabIndex = 14;
            // 
            // LblProfit
            // 
            this.LblProfit.AutoSize = true;
            this.LblProfit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblProfit.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfit.Location = new System.Drawing.Point(595, 66);
            this.LblProfit.Name = "LblProfit";
            this.LblProfit.Size = new System.Drawing.Size(53, 14);
            this.LblProfit.TabIndex = 12;
            this.LblProfit.Text = "PROFIT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "%";
            // 
            // TxtProfit
            // 
            this.TxtProfit.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProfit.Location = new System.Drawing.Point(497, 64);
            this.TxtProfit.Name = "TxtProfit";
            this.TxtProfit.Size = new System.Drawing.Size(52, 21);
            this.TxtProfit.TabIndex = 11;
            // 
            // LblHaving
            // 
            this.LblHaving.AutoSize = true;
            this.LblHaving.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblHaving.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHaving.Location = new System.Drawing.Point(413, 68);
            this.LblHaving.Name = "LblHaving";
            this.LblHaving.Size = new System.Drawing.Size(58, 14);
            this.LblHaving.TabIndex = 10;
            this.LblHaving.Text = "HAVING";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "SELLING PRICE";
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::GiftShopManager.Properties.Resources.minecraft_background_potion_shop_by_michael3216_d5clvys;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblProfit);
            this.Controls.Add(this.TxtProfit);
            this.Controls.Add(this.LblHaving);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.BtnSalesReport);
            this.Controls.Add(this.BtnAdminLogout);
            this.Controls.Add(this.LblPrices);
            this.Controls.Add(this.LblQuan);
            this.Controls.Add(this.LblItems);
            this.Controls.Add(this.TxtPrices);
            this.Controls.Add(this.TxtItems);
            this.Controls.Add(this.TxtQuan);
            this.Controls.Add(this.BtnDeleteItem);
            this.Controls.Add(this.BtnUpdateItem);
            this.Controls.Add(this.BtnInsertItem);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.LblAvailableItem);
            this.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Admin_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAvailableItem;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button BtnInsertItem;
        private System.Windows.Forms.Button BtnUpdateItem;
        private System.Windows.Forms.Button BtnDeleteItem;
        private System.Windows.Forms.TextBox TxtQuan;
        private System.Windows.Forms.TextBox TxtItems;
        private System.Windows.Forms.TextBox TxtPrices;
        private System.Windows.Forms.Label LblItems;
        private System.Windows.Forms.Label LblQuan;
        private System.Windows.Forms.Label LblPrices;
        private System.Windows.Forms.Button BtnAdminLogout;
        private System.Windows.Forms.Button BtnSalesReport;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox TxtSale;
        private System.Windows.Forms.Label LblProfit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtProfit;
        private System.Windows.Forms.Label LblHaving;
        private System.Windows.Forms.Label label1;
    }
}
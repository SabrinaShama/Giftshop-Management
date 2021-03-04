namespace GiftShopManager
{
    partial class GiftShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiftShop));
            this.DashLabel = new System.Windows.Forms.Label();
            this.Form = new System.Windows.Forms.TabControl();
            this.TabForm = new System.Windows.Forms.TabPage();
            this.BtnClearAll = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnPrintPreview = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.LblUser = new System.Windows.Forms.Label();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblOrder = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblCustomer = new System.Windows.Forms.Label();
            this.ComboItem = new System.Windows.Forms.ComboBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.LblPhone = new System.Windows.Forms.Label();
            this.TxtOrder = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblItem = new System.Windows.Forms.Label();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.LblQty = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtCustomer = new System.Windows.Forms.TextBox();
            this.TabCustomer = new System.Windows.Forms.TabPage();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Form.SuspendLayout();
            this.TabForm.SuspendLayout();
            this.TabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DashLabel
            // 
            this.DashLabel.AutoSize = true;
            this.DashLabel.Location = new System.Drawing.Point(243, 549);
            this.DashLabel.Name = "DashLabel";
            this.DashLabel.Size = new System.Drawing.Size(520, 13);
            this.DashLabel.TabIndex = 7;
            this.DashLabel.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "----------";
            // 
            // Form
            // 
            this.Form.Controls.Add(this.TabForm);
            this.Form.Controls.Add(this.TabCustomer);
            this.Form.Location = new System.Drawing.Point(-2, -2);
            this.Form.Name = "Form";
            this.Form.SelectedIndex = 0;
            this.Form.Size = new System.Drawing.Size(1200, 670);
            this.Form.TabIndex = 9;
            // 
            // TabForm
            // 
            this.TabForm.BackColor = System.Drawing.Color.CadetBlue;
            this.TabForm.BackgroundImage = global::GiftShopManager.Properties.Resources.Brisbane_Shopping_Centre_2;
            this.TabForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabForm.Controls.Add(this.BtnClearAll);
            this.TabForm.Controls.Add(this.listBox1);
            this.TabForm.Controls.Add(this.BtnPrintPreview);
            this.TabForm.Controls.Add(this.BtnPrint);
            this.TabForm.Controls.Add(this.LblUser);
            this.TabForm.Controls.Add(this.BtnLogout);
            this.TabForm.Controls.Add(this.UserName);
            this.TabForm.Controls.Add(this.LblDate);
            this.TabForm.Controls.Add(this.LblOrder);
            this.TabForm.Controls.Add(this.dateTimePicker1);
            this.TabForm.Controls.Add(this.LblCustomer);
            this.TabForm.Controls.Add(this.ComboItem);
            this.TabForm.Controls.Add(this.BtnInsert);
            this.TabForm.Controls.Add(this.BtnNew);
            this.TabForm.Controls.Add(this.LblPhone);
            this.TabForm.Controls.Add(this.TxtOrder);
            this.TabForm.Controls.Add(this.TxtTotal);
            this.TabForm.Controls.Add(this.LblItem);
            this.TabForm.Controls.Add(this.TxtQty);
            this.TabForm.Controls.Add(this.LblPrice);
            this.TabForm.Controls.Add(this.TxtPrice);
            this.TabForm.Controls.Add(this.LblQty);
            this.TabForm.Controls.Add(this.TxtPhone);
            this.TabForm.Controls.Add(this.LblTotal);
            this.TabForm.Controls.Add(this.TxtCustomer);
            this.TabForm.Location = new System.Drawing.Point(4, 22);
            this.TabForm.Name = "TabForm";
            this.TabForm.Padding = new System.Windows.Forms.Padding(3);
            this.TabForm.Size = new System.Drawing.Size(1192, 644);
            this.TabForm.TabIndex = 0;
            this.TabForm.Text = "User Form";
            this.TabForm.Click += new System.EventHandler(this.TabForm_Click);
            // 
            // BtnClearAll
            // 
            this.BtnClearAll.BackColor = System.Drawing.Color.Lavender;
            this.BtnClearAll.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearAll.Location = new System.Drawing.Point(777, 578);
            this.BtnClearAll.Name = "BtnClearAll";
            this.BtnClearAll.Size = new System.Drawing.Size(194, 28);
            this.BtnClearAll.TabIndex = 13;
            this.BtnClearAll.Text = "CLEAR";
            this.BtnClearAll.UseVisualStyleBackColor = false;
            this.BtnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Lavender;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(777, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(397, 537);
            this.listBox1.TabIndex = 12;
            // 
            // BtnPrintPreview
            // 
            this.BtnPrintPreview.BackColor = System.Drawing.Color.Lavender;
            this.BtnPrintPreview.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintPreview.Location = new System.Drawing.Point(503, 273);
            this.BtnPrintPreview.Name = "BtnPrintPreview";
            this.BtnPrintPreview.Size = new System.Drawing.Size(215, 64);
            this.BtnPrintPreview.TabIndex = 10;
            this.BtnPrintPreview.Text = "PRINT PREVIEW";
            this.BtnPrintPreview.UseVisualStyleBackColor = false;
            this.BtnPrintPreview.Click += new System.EventHandler(this.BtnPrintPreview_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.Lavender;
            this.BtnPrint.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.Location = new System.Drawing.Point(503, 343);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(215, 61);
            this.BtnPrint.TabIndex = 11;
            this.BtnPrint.Text = "PRINT";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblUser.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblUser.Location = new System.Drawing.Point(38, 39);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(64, 20);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "USER#";
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.Lavender;
            this.BtnLogout.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Location = new System.Drawing.Point(977, 578);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(197, 58);
            this.BtnLogout.TabIndex = 1;
            this.BtnLogout.Text = "LOGOUT";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.SystemColors.ControlText;
            this.UserName.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.UserName.Location = new System.Drawing.Point(111, 39);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(53, 20);
            this.UserName.TabIndex = 6;
            this.UserName.Text = "USER";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblDate.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblDate.Location = new System.Drawing.Point(82, 122);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(47, 17);
            this.LblDate.TabIndex = 0;
            this.LblDate.Text = "Date :";
            // 
            // LblOrder
            // 
            this.LblOrder.AutoSize = true;
            this.LblOrder.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblOrder.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrder.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblOrder.Location = new System.Drawing.Point(82, 186);
            this.LblOrder.Name = "LblOrder";
            this.LblOrder.Size = new System.Drawing.Size(55, 17);
            this.LblOrder.TabIndex = 0;
            this.LblOrder.Text = "Order#";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy     HH:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(254, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2016, 4, 24, 0, 0, 0, 0);
            // 
            // LblCustomer
            // 
            this.LblCustomer.AutoSize = true;
            this.LblCustomer.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblCustomer.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblCustomer.Location = new System.Drawing.Point(82, 250);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(122, 17);
            this.LblCustomer.TabIndex = 0;
            this.LblCustomer.Text = "Customer Name :";
            // 
            // ComboItem
            // 
            this.ComboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboItem.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboItem.FormattingEnabled = true;
            this.ComboItem.Location = new System.Drawing.Point(254, 378);
            this.ComboItem.MaxDropDownItems = 10;
            this.ComboItem.Name = "ComboItem";
            this.ComboItem.Size = new System.Drawing.Size(200, 25);
            this.ComboItem.TabIndex = 3;
            this.ComboItem.SelectedIndexChanged += new System.EventHandler(this.ComboItem_SelectedIndexChanged);
            // 
            // BtnInsert
            // 
            this.BtnInsert.BackColor = System.Drawing.Color.Lavender;
            this.BtnInsert.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsert.ForeColor = System.Drawing.Color.Black;
            this.BtnInsert.Location = new System.Drawing.Point(503, 202);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(215, 65);
            this.BtnInsert.TabIndex = 1;
            this.BtnInsert.Text = "INSERT";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.BackColor = System.Drawing.Color.Lavender;
            this.BtnNew.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.ForeColor = System.Drawing.Color.Black;
            this.BtnNew.Location = new System.Drawing.Point(503, 131);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(215, 65);
            this.BtnNew.TabIndex = 1;
            this.BtnNew.Text = "NEW";
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblPhone.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhone.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblPhone.Location = new System.Drawing.Point(82, 314);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(123, 17);
            this.LblPhone.TabIndex = 0;
            this.LblPhone.Text = "Customer Phone :";
            // 
            // TxtOrder
            // 
            this.TxtOrder.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOrder.Location = new System.Drawing.Point(254, 186);
            this.TxtOrder.Name = "TxtOrder";
            this.TxtOrder.Size = new System.Drawing.Size(200, 25);
            this.TxtOrder.TabIndex = 2;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(254, 570);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(200, 25);
            this.TxtTotal.TabIndex = 2;
            // 
            // LblItem
            // 
            this.LblItem.AutoSize = true;
            this.LblItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblItem.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblItem.Location = new System.Drawing.Point(82, 378);
            this.LblItem.Name = "LblItem";
            this.LblItem.Size = new System.Drawing.Size(83, 17);
            this.LblItem.TabIndex = 0;
            this.LblItem.Text = "Item Type :";
            // 
            // TxtQty
            // 
            this.TxtQty.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQty.Location = new System.Drawing.Point(254, 506);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(200, 25);
            this.TxtQty.TabIndex = 2;
            this.TxtQty.TextChanged += new System.EventHandler(this.TxtQty_TextChanged);
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblPrice.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblPrice.Location = new System.Drawing.Point(82, 442);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(48, 17);
            this.LblPrice.TabIndex = 0;
            this.LblPrice.Text = "Price :";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(254, 442);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.ReadOnly = true;
            this.TxtPrice.Size = new System.Drawing.Size(200, 25);
            this.TxtPrice.TabIndex = 2;
            // 
            // LblQty
            // 
            this.LblQty.AutoSize = true;
            this.LblQty.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblQty.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQty.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblQty.Location = new System.Drawing.Point(82, 506);
            this.LblQty.Name = "LblQty";
            this.LblQty.Size = new System.Drawing.Size(73, 17);
            this.LblQty.TabIndex = 0;
            this.LblQty.Text = "Quantity :";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(254, 314);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(200, 25);
            this.TxtPhone.TabIndex = 2;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblTotal.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblTotal.Location = new System.Drawing.Point(82, 570);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(100, 17);
            this.LblTotal.TabIndex = 0;
            this.LblTotal.Text = "Total To Pay :";
            // 
            // TxtCustomer
            // 
            this.TxtCustomer.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomer.Location = new System.Drawing.Point(254, 250);
            this.TxtCustomer.Name = "TxtCustomer";
            this.TxtCustomer.Size = new System.Drawing.Size(200, 25);
            this.TxtCustomer.TabIndex = 2;
            // 
            // TabCustomer
            // 
            this.TabCustomer.BackColor = System.Drawing.Color.BurlyWood;
            this.TabCustomer.Controls.Add(this.label2);
            this.TabCustomer.Controls.Add(this.label1);
            this.TabCustomer.Controls.Add(this.TxtSearch);
            this.TabCustomer.Controls.Add(this.SearchCombo);
            this.TabCustomer.Controls.Add(this.dataGridView1);
            this.TabCustomer.Location = new System.Drawing.Point(4, 22);
            this.TabCustomer.Name = "TabCustomer";
            this.TabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.TabCustomer.Size = new System.Drawing.Size(1192, 644);
            this.TabCustomer.TabIndex = 1;
            this.TabCustomer.Text = "Customer Info";
            this.TabCustomer.Click += new System.EventHandler(this.TabCustomer_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(128, 49);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(470, 20);
            this.TxtSearch.TabIndex = 5;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // SearchCombo
            // 
            this.SearchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Items.AddRange(new object[] {
            "ID",
            "DATE TIME",
            "RECEIPTIONIST",
            "CUSTOMER NAME",
            "ITEM"});
            this.SearchCombo.Location = new System.Drawing.Point(128, 16);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(470, 21);
            this.SearchCombo.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column9,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.GridColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.Location = new System.Drawing.Point(6, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1180, 550);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DateTime";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Receiptionist";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Customer Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Customer Phone No";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Item";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Quantity";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Total";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Using ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search For";
            // 
            // GiftShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1189, 661);
            this.Controls.Add(this.Form);
            this.Controls.Add(this.DashLabel);
            this.Name = "GiftShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gift Shop Manager";
            this.Load += new System.EventHandler(this.GiftShop_Load);
            this.Form.ResumeLayout(false);
            this.TabForm.ResumeLayout(false);
            this.TabForm.PerformLayout();
            this.TabCustomer.ResumeLayout(false);
            this.TabCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblOrder;
        private System.Windows.Forms.Label LblCustomer;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblItem;
        private System.Windows.Forms.Label LblQty;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.TextBox TxtCustomer;
        private System.Windows.Forms.TextBox TxtOrder;
        private System.Windows.Forms.ComboBox ComboItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label DashLabel;
        private System.Windows.Forms.TabControl Form;
        private System.Windows.Forms.TabPage TabForm;
        private System.Windows.Forms.TabPage TabCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox SearchCombo;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button BtnPrintPreview;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnClearAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
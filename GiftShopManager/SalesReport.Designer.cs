namespace GiftShopManager
{
    partial class SalesReport
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
            this.LblTotal = new System.Windows.Forms.Label();
            this.dataGridViewSalesReport = new System.Windows.Forms.DataGridView();
            this.LblData = new System.Windows.Forms.Label();
            this.TxtTtl = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.LblTo = new System.Windows.Forms.Label();
            this.LblFrom = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblTotal.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblTotal.Location = new System.Drawing.Point(69, 346);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(108, 19);
            this.LblTotal.TabIndex = 2;
            this.LblTotal.Text = "TOTAL SALE :";
            // 
            // dataGridViewSalesReport
            // 
            this.dataGridViewSalesReport.AllowUserToAddRows = false;
            this.dataGridViewSalesReport.AllowUserToDeleteRows = false;
            this.dataGridViewSalesReport.AllowUserToOrderColumns = true;
            this.dataGridViewSalesReport.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridViewSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewSalesReport.GridColor = System.Drawing.Color.PowderBlue;
            this.dataGridViewSalesReport.Location = new System.Drawing.Point(361, 121);
            this.dataGridViewSalesReport.Name = "dataGridViewSalesReport";
            this.dataGridViewSalesReport.ReadOnly = true;
            this.dataGridViewSalesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalesReport.Size = new System.Drawing.Size(816, 505);
            this.dataGridViewSalesReport.TabIndex = 3;
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LblData.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblData.Location = new System.Drawing.Point(529, 99);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(113, 19);
            this.LblData.TabIndex = 4;
            this.LblData.Text = "TOTAL ITEM :";
            // 
            // TxtTtl
            // 
            this.TxtTtl.AutoSize = true;
            this.TxtTtl.BackColor = System.Drawing.SystemColors.ControlText;
            this.TxtTtl.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTtl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TxtTtl.Location = new System.Drawing.Point(183, 348);
            this.TxtTtl.Name = "TxtTtl";
            this.TxtTtl.Size = new System.Drawing.Size(62, 17);
            this.TxtTtl.TabIndex = 5;
            this.TxtTtl.Text = "TOTAL";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(142, 172);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 6;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(142, 120);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 7;
            // 
            // LblTo
            // 
            this.LblTo.AutoSize = true;
            this.LblTo.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblTo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblTo.Location = new System.Drawing.Point(69, 172);
            this.LblTo.Name = "LblTo";
            this.LblTo.Size = new System.Drawing.Size(32, 19);
            this.LblTo.TabIndex = 8;
            this.LblTo.Text = "TO";
            // 
            // LblFrom
            // 
            this.LblFrom.AutoSize = true;
            this.LblFrom.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LblFrom.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFrom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblFrom.Location = new System.Drawing.Point(69, 120);
            this.LblFrom.Name = "LblFrom";
            this.LblFrom.Size = new System.Drawing.Size(55, 19);
            this.LblFrom.TabIndex = 9;
            this.LblFrom.Text = "FROM";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "ITEM NAME";
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
            this.Column3.HeaderText = "TOTAL BUYING PRICE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TOTAL SELLING PRICE";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "PROFIT";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::GiftShopManager.Properties.Resources.bigstock_Coffee_Shop_Blur_Background_Wi_86599157;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 661);
            this.Controls.Add(this.LblFrom);
            this.Controls.Add(this.LblTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.TxtTtl);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.dataGridViewSalesReport);
            this.Controls.Add(this.LblTotal);
            this.Name = "SalesReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Sales Report";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView dataGridViewSalesReport;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Label TxtTtl;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label LblTo;
        private System.Windows.Forms.Label LblFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
namespace GiftShopManager
{
    partial class New_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Order));
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnClearItem = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TxtItemQuan = new System.Windows.Forms.TextBox();
            this.TxtItemOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printPreviewDialogOrder = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentOrder = new System.Drawing.Printing.PrintDocument();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.Color.Lavender;
            this.BtnOrder.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.Location = new System.Drawing.Point(678, 471);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(226, 85);
            this.BtnOrder.TabIndex = 0;
            this.BtnOrder.Text = "ORDER";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // BtnClearItem
            // 
            this.BtnClearItem.BackColor = System.Drawing.Color.Lavender;
            this.BtnClearItem.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearItem.Location = new System.Drawing.Point(213, 562);
            this.BtnClearItem.Name = "BtnClearItem";
            this.BtnClearItem.Size = new System.Drawing.Size(204, 27);
            this.BtnClearItem.TabIndex = 1;
            this.BtnClearItem.Text = "CLEAR";
            this.BtnClearItem.UseVisualStyleBackColor = false;
            this.BtnClearItem.Click += new System.EventHandler(this.BtnClearItem_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Lavender;
            this.BtnAdd.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(761, 327);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(215, 36);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.Lavender;
            this.BtnRemove.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.Location = new System.Drawing.Point(761, 369);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(215, 36);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "REMOVE";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Lavender;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(213, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 485);
            this.listBox1.TabIndex = 4;
            // 
            // TxtItemQuan
            // 
            this.TxtItemQuan.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtItemQuan.Location = new System.Drawing.Point(764, 213);
            this.TxtItemQuan.Name = "TxtItemQuan";
            this.TxtItemQuan.Size = new System.Drawing.Size(212, 27);
            this.TxtItemQuan.TabIndex = 5;
            // 
            // TxtItemOrder
            // 
            this.TxtItemOrder.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtItemOrder.Location = new System.Drawing.Point(764, 158);
            this.TxtItemOrder.Name = "TxtItemOrder";
            this.TxtItemOrder.Size = new System.Drawing.Size(212, 27);
            this.TxtItemOrder.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(766, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(766, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantity: ";
            // 
            // printPreviewDialogOrder
            // 
            this.printPreviewDialogOrder.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogOrder.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogOrder.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogOrder.Enabled = true;
            this.printPreviewDialogOrder.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogOrder.Icon")));
            this.printPreviewDialogOrder.Name = "printPreviewDialogOrder";
            this.printPreviewDialogOrder.Visible = false;
            // 
            // printDocumentOrder
            // 
            this.printDocumentOrder.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentOrder_PrintPage);
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.BackColor = System.Drawing.SystemColors.ControlText;
            this.LblPrice.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblPrice.Location = new System.Drawing.Point(766, 251);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(48, 19);
            this.LblPrice.TabIndex = 7;
            this.LblPrice.Text = "Price:";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(764, 271);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(212, 27);
            this.TxtPrice.TabIndex = 5;
            // 
            // New_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::GiftShopManager.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtItemOrder);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtItemQuan);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnClearItem);
            this.Controls.Add(this.BtnOrder);
            this.Name = "New_Order";
            this.Text = "New Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Button BtnClearItem;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox TxtItemQuan;
        private System.Windows.Forms.TextBox TxtItemOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogOrder;
        private System.Drawing.Printing.PrintDocument printDocumentOrder;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxtPrice;
    }
}
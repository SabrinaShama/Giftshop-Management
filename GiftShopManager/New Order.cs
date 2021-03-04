using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GiftShopManager
{
    public partial class New_Order : Form
    {
        public New_Order()
        {
            InitializeComponent();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(TxtItemOrder.Text.PadRight(30) + TxtItemQuan.Text.PadRight(30) + TxtPrice.Text);
        }

        private void BtnClearItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            printPreviewDialogOrder.Document = printDocumentOrder;
            printPreviewDialogOrder.ShowDialog();
            printDocumentOrder.Print();
        }

        private void printDocumentOrder_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString(" Dhaka Gift Shop ", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            offset = offset + (int)fontHeight;
            graphic.DrawString("-------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            string top = "Item Name".PadRight(20) + "Quantity".PadRight(20) + "Price";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("-------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            foreach (string item in listBox1.Items)
            {
                string productDescription = item;
                string productTotal = item.Substring(item.Length - 6, 6);
                float productPrice = float.Parse(item.Substring(item.Length - 5, 5));

                string productLine = productDescription;
                graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }
        }


    }
}

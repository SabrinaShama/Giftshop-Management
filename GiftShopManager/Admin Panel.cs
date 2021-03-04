using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GiftShopManager
{
    
    public partial class Admin_Panel : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SABRINA;Initial Catalog=GiftShop;Integrated Security=True;MultipleActiveResultSets=true");
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            Display();
        }

        void Display()
        {
            SqlDataAdapter sad = new SqlDataAdapter("SELECT * from InventoryInfo", con);
            DataTable dt = new DataTable();
            sad.Fill(dt);
            dataGridViewItems.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridViewItems.Rows.Add();
                dataGridViewItems.Rows[n].Cells[0].Value = item["Item"].ToString();
                dataGridViewItems.Rows[n].Cells[1].Value = item["Quantity"].ToString();
                dataGridViewItems.Rows[n].Cells[2].Value = item["BuyingPrice"].ToString();
                dataGridViewItems.Rows[n].Cells[3].Value = item["SellingPrice"].ToString();
            }
        }

        private void BtnAdminLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void BtnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReport sr = new SalesReport();
            sr.ShowDialog();
        }

        private void BtnInsertItem_Click(object sender, EventArgs e)
        {
            DialogResult Dialog = MessageBox.Show("Have you paid the due balance for these items? ","Exit",MessageBoxButtons.YesNo);
            if (Dialog == DialogResult.Yes)
            {
                float pro = (Convert.ToSingle(TxtProfit.Text) / 100) * Convert.ToSingle(TxtPrices.Text);
                float sale = Convert.ToSingle(TxtPrices.Text) + pro;
                TxtSale.Text = sale.ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO InventoryInfo
                      (Item, Quantity, BuyingPrice, SellingPrice)
                       VALUES        ('" + TxtItems.Text + "','" + TxtQuan.Text + "','" + TxtPrices.Text + "','" + TxtSale.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
            }
            else if (Dialog == DialogResult.No) 
            {
                MessageBox.Show("Please Pay the Due First ! ");
            }
        }

        private void BtnUpdateItem_Click(object sender, EventArgs e)
        {
            float pro = (Convert.ToSingle(TxtProfit.Text) / 100) * Convert.ToSingle(TxtPrices.Text);
            float sale = Convert.ToSingle(TxtPrices.Text) + pro;
            TxtSale.Text = sale.ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE InventoryInfo SET Item = '" + TxtItems.Text + "', Quantity = '" + TxtQuan.Text + "', BuyingPrice = '" + TxtPrices.Text + "', SellingPrice = '" + TxtSale.Text + "' WHERE (Item = '" + TxtItems.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Display();
        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM InventoryInfo WHERE (Item = '" + TxtItems.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Display();
        }

        private void dataGridViewItems_MouseClick(object sender, MouseEventArgs e)
        {
            TxtItems.Text = dataGridViewItems.SelectedRows[0].Cells[0].Value.ToString();
            TxtQuan.Text = dataGridViewItems.SelectedRows[0].Cells[1].Value.ToString();
            TxtPrices.Text = dataGridViewItems.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            New_Order ord = new New_Order();
            ord.Show();
        }

    }
}

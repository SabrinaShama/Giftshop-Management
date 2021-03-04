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
    public partial class GiftShop : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SABRINA;Initial Catalog=GiftShop;Integrated Security=True;MultipleActiveResultSets=true");

        private String Us;
        public String PassId
        {
            get { return Us; }
            set { Us = value; }
        }

        public GiftShop()
        {
            InitializeComponent();
            FillCombo();
            TxtOrder.Focus();
        }

        void FillCombo()
        {
            SqlCommand cmdDatabase = new SqlCommand(@"Select * From InventoryInfo", con);
            SqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string Item = myReader.GetString(myReader.GetOrdinal("Item"));
                    ComboItem.Items.Add(Item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void GiftShop_Load(object sender, EventArgs e)
        {
            UserName.Text = Us;
            Display();
            dateTimePicker1.Value = System.DateTime.Today;
            TxtOrder.Text = RetrieveData().ToString();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = System.DateTime.Today;
            TxtOrder.Clear();
            TxtCustomer.Clear();
            TxtPhone.Clear();
            ComboItem.SelectedIndex = -1;
            TxtPrice.Clear();
            TxtQty.Clear();
            TxtTotal.Clear();
            TxtOrder.Focus();
        }

        private void TxtQty_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrice.Text != "" && TxtQty.Text != "")
            {
                Decimal TotalPay = Convert.ToInt32(TxtPrice.Text) * Convert.ToInt32(TxtQty.Text);
                TxtTotal.Text = TotalPay.ToString();
            }
            else
            {
                TxtTotal.Text = "0";
            }

            con.Open();
            SqlCommand cmdD = new SqlCommand(@"Select * From InventoryInfo where Item ='" + ComboItem.Text + "'", con);
            SqlDataReader Reader;
            Reader = cmdD.ExecuteReader();
            while (Reader.Read())
            {
                Int32 Quan = Convert.ToInt32(Reader["Quantity"]) - Convert.ToInt32(TxtQty.Text);
                if (Quan < 0)
                    MessageBox.Show("Don't Have Enough Item !!! ");

            }
            con.Close();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Customer
                      (ID, Date, Receiptionist, Customer, Phone, Item, Price, Quantity, Totalpay)
                       VALUES        ('" + TxtOrder.Text + "','" + dateTimePicker1.Text + "','" + UserName.Text + "','" + TxtCustomer.Text + "','" + TxtPhone.Text + "','" + ComboItem.Text + "','" + TxtPrice.Text + "','" + TxtQty.Text + "','" + TxtTotal.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Receipt Is Ready To Print...");

            SqlCommand cmdD = new SqlCommand(@"Select * From InventoryInfo where Item ='" + ComboItem.Text + "'", con);
            SqlDataReader Reader;
            Reader = cmdD.ExecuteReader();
            while (Reader.Read())
            {
                decimal Quan = Convert.ToInt32(Reader["Quantity"]) - Convert.ToInt32(TxtQty.Text);
                SqlCommand cmdDatabase = new SqlCommand(@"UPDATE InventoryInfo SET Quantity= '" + Quan + "' WHERE ( Item = '" + ComboItem.Text + "' )", con);
                cmdDatabase.ExecuteNonQuery();
            }
            listBox1.Items.Add(ComboItem.Text.PadRight(20) + TxtQty.Text.PadRight(20) + TxtPrice.Text);
            con.Close();
        }
        

        private void ComboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmdDatabase = new SqlCommand(@"Select * From InventoryInfo where Item ='" + ComboItem.Text + "'", con);
            SqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    TxtPrice.Text = Convert.ToString(myReader["SellingPrice"]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        public int RetrieveData()
        {
            int ID=0;
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT TOP 1 * FROM Customer ORDER BY ID DESC", con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                ID = Convert.ToInt32(myReader["ID"])+1001;
            }
            con.Close();
            return ID;
        }

        private void TabCustomer_Click(object sender, EventArgs e)
        {
            Display();
        }
        
        void Display()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Customer", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ID"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (SearchCombo.Text == "ID")
            {
                SqlDataAdapter sda=new SqlDataAdapter("SELECT * from Customer where ID like '%" + TxtSearch.Text + "%'",con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["ID"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                }
            }
            else if (SearchCombo.Text == "DATE TIME")
            {
                SqlDataAdapter sda=new SqlDataAdapter("SELECT * from Customer where Date like '%" + TxtSearch.Text + "%'",con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["ID"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                }
            }
            else if (SearchCombo.Text== "CUSTOMER NAME")
            {
                SqlDataAdapter sda=new SqlDataAdapter("SELECT * from Customer where Customer like '%" + TxtSearch.Text + "%'",con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["ID"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                }
            }
            else if (SearchCombo.Text == "ITEM")
            {
                SqlDataAdapter sda=new SqlDataAdapter("SELECT * from Customer where Item like '%" + TxtSearch.Text + "%'",con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["ID"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                }
            }
            else if (SearchCombo.Text == "RECEIPTIONIST")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Customer where Receiptionist like '%" + TxtSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["ID"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                }
            }
        }

        private void BtnPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString(" Dhaka Gift Shop", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            offset = offset + (int)fontHeight;
            graphic.DrawString("Customer: " + TxtCustomer.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("Date: " + dateTimePicker1.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("-------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            string top = "Item Name".PadRight(20) + "Quantity".PadRight(20) + "Price";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("-------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            float totalprice = 0.00f;

            foreach (string item in listBox1.Items)
            {
                string productDescription = item;
                string productTotal = item.Substring(item.Length - 6, 6);
                float productPrice = float.Parse(item.Substring(item.Length - 5, 5));

                totalprice += productPrice;
                string productLine = productDescription;
                graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }

            offset = offset + 20;
            graphic.DrawString("Total to pay ".PadRight(30) + String.Format("{0:c}", totalprice), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 30;
            graphic.DrawString("     Thank-you for your custom,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("       please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }

        private void TabForm_Click(object sender, EventArgs e)
        {

        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        
    }
}

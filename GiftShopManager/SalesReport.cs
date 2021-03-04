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
    public partial class SalesReport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SABRINA;Initial Catalog=GiftShop;Integrated Security=True;MultipleActiveResultSets=true");
        public SalesReport()
        {
            InitializeComponent();
        }

        
        
        private void SalesReport_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT Customer.Date, Customer.Quantity, InventoryInfo.BuyingPrice, Customer.Item, InventoryInfo.SellingPrice 
                                                        FROM Customer INNER JOIN InventoryInfo ON Customer.Item = InventoryInfo.Item
                                                        where Date BETWEEN '" + dateTimePickerFrom.Text + "' and '" + dateTimePickerTo.Text + "'", con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            
            while (myReader.Read())
            {
                SqlDataAdapter sdp = new SqlDataAdapter(@"SELECT Customer.Date, Customer.Quantity, InventoryInfo.BuyingPrice, Customer.Item, InventoryInfo.SellingPrice 
                                                        FROM Customer INNER JOIN InventoryInfo ON Customer.Item = InventoryInfo.Item 
                                                        where Date BETWEEN '" + dateTimePickerFrom.Text + "' and '" + dateTimePickerTo.Text + "'", con);
                DataTable dt2 = new DataTable();
                sdp.Fill(dt2);
                dataGridViewSalesReport.Rows.Clear();
                decimal sell = 0;
                decimal buy = 0;
                decimal quan = 0;
                decimal sellingprice = 0;
                decimal buyingprice = 0;
                decimal profit = 0;
                foreach (DataRow item in dt2.Rows)
                {
                    int n = dataGridViewSalesReport.Rows.Add();
                    sell = Convert.ToInt32(myReader["SellingPrice"]); 
                    buy = Convert.ToInt32(myReader["BuyingPrice"]);
                    quan = Convert.ToInt32(myReader["Quantity"]);
                    sellingprice = sell * quan;
                    buyingprice = buy * quan;
                    profit = sellingprice - buyingprice;
                    dataGridViewSalesReport.Rows[n].Cells[0].Value = item["Item"].ToString();
                    dataGridViewSalesReport.Rows[n].Cells[1].Value = item["Quantity"].ToString();
                    dataGridViewSalesReport.Rows[n].Cells[2].Value = item["BuyingPrice"].ToString();
                    dataGridViewSalesReport.Rows[n].Cells[3].Value = item["SellingPrice"].ToString();
                    dataGridViewSalesReport.Rows[n].Cells[4].Value = profit.ToString();
                }
                int sum = 0;
                for (int i = 0; i < dataGridViewSalesReport.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridViewSalesReport.Rows[i].Cells[2].Value);
                }
                TxtTtl.Text = Convert.ToString(sum);
            }
            con.Close();
            
        } 

        
    }
}

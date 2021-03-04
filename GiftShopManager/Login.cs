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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SABRINA;Initial Catalog=GiftShop;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            if (TxtPass.Text == "12345")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"Select Count(*) From AdminLogin where Username='" + TxtUser.Text + "' and Password='" + TxtPass.Text + "'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Admin_Panel ap = new Admin_Panel();
                    ap.Show();
                }
                else
                {
                    MessageBox.Show("Sorry ! You are not registered....");
                }
            }

            else if (TxtPass.Text == "123456")
            {
                SqlDataAdapter sda = new SqlDataAdapter(@"Select Count(*) From LOGIN where USERNAME='" + TxtUser.Text + "' and PASSWORD='" + TxtPass.Text + "'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    GiftShop gs = new GiftShop();
                    gs.PassId = TxtUser.Text;
                    gs.Show();
                }
                else
                {
                    MessageBox.Show("Sorry ! You are not registered....");
                }
            }
            else
            {
                MessageBox.Show("Please check your password");
            }
        }
        
    }
}

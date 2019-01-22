using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void BT_Clear_Click(object sender, EventArgs e)
        {
            TB_Username.Clear();
            TB_Password.Text = "";
        }

        private void BT_Login_Click(object sender, EventArgs e)
        {
            //string connection = "Data Source =.; Initial Catalog = Stock; Integrated Security = True";

            using (SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = Stock; Integrated Security = True"))            
            {
                string cmd = @"SELECT * FROM[dbo].[Login] WHERE [UserName] = '" + TB_Username.Text + "' AND [Password] = '"
                            + TB_Password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(cmd, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    StockMain Main = new StockMain();
                    Main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User Name or Password Invalid !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void LL_ForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

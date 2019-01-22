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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();           
        }      

        private void Products_Load(object sender, EventArgs e)
        {
            CB_Status.SelectedIndex = 0;
            LoadData();            
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = Stock; Integrated Security = True");
            
            // Insert Query Logic
            bool status = false;
            if (CB_Status.SelectedIndex == 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            con.Open();

            var sqlQuery = "";
            if (IfProductExists(con, TB_ProdCode.Text))
            {
                sqlQuery = @"UPDATE [dbo].[Products] SET [ProductName] = '" + TB_ProdName.Text + "' ,[ProductStatus] = '" + status + "' " +
                    "WHERE [ProductCode] = '" + TB_ProdCode.Text + "'";
            }
            else
            {
                sqlQuery = @"INSERT INTO [dbo].[Products] ([ProductCode],[ProductName],[ProductStatus]) VALUES
           ('" + TB_ProdCode.Text + "' , '" + TB_ProdName.Text + "' ,'" + status + "')";
            }

            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();

            // Reading Data
            LoadData();
        }

        private bool IfProductExists(SqlConnection con, string ProductCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [dbo].[Products] WHERE [ProductCode] = '" + ProductCode + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void LoadData()
        {
            // Reading Data
            SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = Stock; Integrated Security = True");            
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [dbo].[Products]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //sda.Fill(4,3,dt);
            
            DGV_Prod.Rows.Clear();

            //DGV_Prod.DataSource = dt;

            foreach (DataRow item in dt.Rows)
            {
                int n = DGV_Prod.Rows.Add();
                DGV_Prod.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                DGV_Prod.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                if ((bool)item["ProductStatus"])
                {
                    DGV_Prod.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    DGV_Prod.Rows[n].Cells[2].Value = "Inactive";
                }
            }
        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = Stock; Integrated Security = True"))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[Products] WHERE [ProductCode] = @Code", con))            
            {
                if (IfProductExists(con, TB_ProdCode.Text))
                {
                    con.Open();
                    //SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[Products] WHERE [ProductCode] = '" + TB_ProdCode.Text + "'", con);

                    //cmd.Parameters.Add("@Code", SqlDbType.Int);                
                    //cmd.Parameters["@Code"].Value = TB_ProdCode.Text;
                    
                    cmd.Parameters.Add(new SqlParameter("@Code", SqlDbType.Int) { Value = TB_ProdCode.Text });

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Record Doesn't Exist !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }

            // Reading Data
            LoadData();
        }

        private void DGV_Prod_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TB_ProdCode.Text = DGV_Prod.SelectedRows[0].Cells[0].Value.ToString();
            TB_ProdName.Text = DGV_Prod.SelectedRows[0].Cells[1].Value.ToString();
            if (DGV_Prod.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                CB_Status.SelectedIndex = 0;
            }
            else
            {
                CB_Status.SelectedIndex = 1;
            }           
        }
    }   
}

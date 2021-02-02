using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace LocalMiniMarket
{
    public partial class Product : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            var employeeName = Request.QueryString.Get("employeename");

            if (string.IsNullOrEmpty(employeeName))
            {
                throw new Exception("employee name is null");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);


            con.Open();

            DataSet ds = new DataSet();
            string sqlstr = "Select * from Product";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }

        protected void Button2_Clicked(object sender, EventArgs e)
        {


            

            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("addProduct", con);

            cmd.Parameters.Add("@ProductID", SqlDbType.SmallInt).Value = TextBox1.Text;
            cmd.Parameters.Add("@brandName", SqlDbType.NVarChar).Value = TextBox4.Text;
            cmd.Parameters.Add("@productName", SqlDbType.NVarChar).Value = TextBox2.Text;
            cmd.Parameters.Add("@comingPrice", SqlDbType.Decimal).Value = TextBox3.Text;
            cmd.Parameters.Add("@productType", SqlDbType.NVarChar).Value = TextBox5.Text;
            cmd.Parameters.Add("@stock", SqlDbType.TinyInt).Value = TextBox6.Text;
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button3_Clicked(object sender, EventArgs e)
        {
            string commandtext = "Delete From Product Where ProductID = @ProductID";

            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(commandtext, con);

            cmd.Parameters.Add("@ProductID", SqlDbType.SmallInt).Value = TextBox1.Text;
            
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        protected void Button4_Clicked(object sender, EventArgs e)
        {
            string commandtext = "Update Product Set salePrice = @salePrice Where productID = @ProductID";

            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(commandtext, con);

            cmd.Parameters.Add("@ProductID", SqlDbType.SmallInt).Value = TextBox1.Text;
            cmd.Parameters.Add("@salePrice", SqlDbType.Decimal).Value = TextBox7.Text;
            
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        protected void Button5_Clicked(object sender, EventArgs e)
        {
         
            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("updateSalePrice", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}

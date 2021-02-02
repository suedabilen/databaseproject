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
    public partial class Customer: System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1Customer_Click(object sender, EventArgs e)
        {
            string commandtext = "Insert Customer(customerID,name,age,regularCus,gender) Values(@customerID,@name,@age,@regularCus,@gender)";

            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(commandtext, con);

            cmd.Parameters.Add("@customerID", SqlDbType.TinyInt).Value = TextBox1.Text;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = TextBox2.Text;
            cmd.Parameters.Add("@age", SqlDbType.TinyInt).Value = TextBox3.Text;
            cmd.Parameters.Add("@regularCus", SqlDbType.Bit).Value = TextBox4.Text;
            cmd.Parameters.Add("@gender", SqlDbType.Char).Value = TextBox5.Text;
            cmd.CommandType = CommandType.Text;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        protected void Button2Customer_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            DataSet ds = new DataSet();
            string sqlstr = "Select * from Customer";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView2.DataSource = ds;
            GridView2.DataBind();
            con.Close();
        }
    }
}
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
    public partial class Shopping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);
           
            con.Open();

            DataSet ds = new DataSet();
            string sqlstr = "Select * from Shopping";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }
        protected void Button3_Click(object sender, EventArgs e)
        { 
            string commandtext = "Insert Shopping(ShoppingID,ProductId,quantity) Values(@ShoppingID,@ProductID,@quantity)";

            
            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();
           
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(commandtext, con);

            cmd.Parameters.Add("@ShoppingID", SqlDbType.TinyInt).Value = TextBox1.Text;
            cmd.Parameters.Add("@ProductID", SqlDbType.SmallInt).Value = TextBox2.Text;
            cmd.Parameters.Add("@quantity", SqlDbType.TinyInt).Value = TextBox3.Text;

            cmd.CommandType = CommandType.Text;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }
    }
  }

        
    

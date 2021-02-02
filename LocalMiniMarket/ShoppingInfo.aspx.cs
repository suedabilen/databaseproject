using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocalMiniMarket
{
    public partial class ShoppingInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_ClickInfo(object sender,EventArgs e)
        {
            string commandtext = "Insert Shopping_Info(ShoppingID,CustomerID) Values(@ShoppingID,@CustomerID)";


            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(commandtext, con);

            cmd.Parameters.Add("@ShoppingID", SqlDbType.TinyInt).Value = TextBox1.Text;
            cmd.Parameters.Add("@CustomerID", SqlDbType.TinyInt).Value = TextBox2.Text;

            cmd.CommandType = CommandType.Text;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
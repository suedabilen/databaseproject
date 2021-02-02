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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

                SqlConnection con = new SqlConnection(connectionString);


                con.Open();

                string sqlstr = "select * from employee";


                SqlCommand cmd = new SqlCommand(sqlstr, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList1.DataTextField = "EmployeeName";
                DropDownList1.DataValueField = "EmployeeName";

                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
                con.Close();
            }
           

        }


        protected void Button1_Click1(object sender, EventArgs e)
        {

            var employeeName = DropDownList1.Items[DropDownList1.SelectedIndex].Value;
            Response.Redirect($"product.aspx?EmployeeName={employeeName}");

        }
    }

}

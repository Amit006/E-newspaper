using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;


public partial class Update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Btnupdate_Click(object sender, EventArgs e)
    {
        string value = Session["AId"].ToString();

        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConName"].ToString());
        con.Open();
        string query = "update AdminProfile set Name=@nm,Address=@ad,Department=@de,Phone=@ph where AdminId='"+value+"'";
        SqlCommand com = new SqlCommand(query, con);
        com.Parameters.AddWithValue("@nm", Txtnem.Text);
        com.Parameters.AddWithValue("@ad", Txtadd.Text);
        com.Parameters.AddWithValue("@de", Txtdept.Text);
        com.Parameters.AddWithValue("@ph", Txtph.Text);
        com.ExecuteNonQuery();
        con.Close();
    }
}
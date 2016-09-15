using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Homepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void Btnshow_Click(object sender, EventArgs e)
    {
        string value = Session["AId"].ToString();

        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConName"].ToString());
        con.Open();
        string query = "select Name,Email,Address,Department,Position,State,Phone from AdminProfile where AdminId='"+value+"'";
        SqlDataAdapter adp = new SqlDataAdapter(query, con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        con.Close();

        GridView1.DataSource = ds;
        GridView1.DataBind();
        
    }
    protected void Lnkbtnup_Click(object sender, EventArgs e)
    {

    }
}
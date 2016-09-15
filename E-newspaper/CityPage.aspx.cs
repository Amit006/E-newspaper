using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class CityPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["city"] != null)
        {
            string value = Request.QueryString["city"].ToString();
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConName"].ToString());
            string query = "select City,Title,NewsID from Adminnews where City='" + value + "' order by [DateTime] desc";
            con.Open();
            SqlDataAdapter nadp = new SqlDataAdapter(query, con);
            DataSet nds = new DataSet();
            nadp.Fill(nds);
            GridView1.DataSource = nds;
            GridView1.DataBind();
            con.Close();
        }
        else
        {
            Response.Redirect("NewsPage.aspx");
        }

    }
    protected void Btndetail_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewsPage.aspx?Nid=" + TextBox1.Text);
    }
}
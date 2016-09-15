using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class CatagoryPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["Cat"] != null)
        {
            string value = Request.QueryString["Cat"].ToString();
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConName"].ToString());
            string query = "select Title,NewsID from Adminnews where CategoryId='" + value + "' order by [DateTime] desc";
            con.Open();
            SqlDataAdapter nadp = new SqlDataAdapter(query, con);
            DataSet nds = new DataSet();
            nadp.Fill(nds);
            GridView1.DataSource = nds;
            GridView1.DataBind();

            string iquery = "select Picturepath from Catagory where CatagoryID='" + value + "'";
            SqlDataAdapter iadp = new SqlDataAdapter(iquery, con);
            DataSet ids = new DataSet();
            iadp.Fill(ids);
            Image1.ImageUrl = ids.Tables[0].Rows[0].ItemArray[0].ToString();
            con.Close();
        }
        else
        {
            Response.Redirect("NewsPage.aspx");
        }

    }
    protected void BtnDetail_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewsPage.aspx?Nid=" + TxtcatagoryID.Text);
    }
}
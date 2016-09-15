using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class NewsPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["Nid"] != null)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConName"].ToString());
            string query = "select Title, [DateTime], City, picturepath, Body from Adminnews where NewsId = '" + Request.QueryString["Nid"].ToString() + "'";
            con.Open();
            SqlDataAdapter nadp = new SqlDataAdapter(query, con);
            DataSet nds = new DataSet();
            nadp.Fill(nds);
            LblTitl.Text = nds.Tables[0].Rows[0].ItemArray[0].ToString();
            Lblatetime.Text = nds.Tables[0].Rows[0].ItemArray[1].ToString();
            Lblcity.Text = nds.Tables[0].Rows[0].ItemArray[2].ToString();
            Image1.ImageUrl = nds.Tables[0].Rows[0].ItemArray[3].ToString();
            TextBox1.Text = nds.Tables[0].Rows[0].ItemArray[4].ToString();
            con.Close();
        }
        else
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConName"].ToString());
            string query = "select Title, [DateTime], City, picturepath, Body from Adminnews order by [DateTime] Desc";
            con.Open();
            SqlDataAdapter nadp = new SqlDataAdapter(query, con);
            DataSet nds = new DataSet();
            nadp.Fill(nds);
            LblTitl.Text = nds.Tables[0].Rows[0].ItemArray[0].ToString();
            Lblatetime.Text = nds.Tables[0].Rows[0].ItemArray[1].ToString();
            Lblcity.Text = nds.Tables[0].Rows[0].ItemArray[2].ToString();
            Image1.ImageUrl = nds.Tables[0].Rows[0].ItemArray[3].ToString();
            TextBox1.Text = nds.Tables[0].Rows[0].ItemArray[4].ToString();
            con.Close();
        }
        

    }
}
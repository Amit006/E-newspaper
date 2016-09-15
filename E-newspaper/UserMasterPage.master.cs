using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class UserMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConName"].ToString());
            string Query = "select CatagoryID, Catgorytype from Catagory";
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(Query, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            Lstcatagory.DataSource = ds;
            Lstcatagory.DataTextField = "Catgorytype";
            Lstcatagory.DataValueField = "CatagoryID";
            Lstcatagory.DataBind();
            con.Close();
        }

        SqlConnection ncon = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConName"].ToString());
        ncon.Open();
        string NewsT = "select Title, NewsId from Adminnews Order by [DateTime] Desc";
        SqlDataAdapter nadp = new SqlDataAdapter(NewsT, ncon);
        DataSet nds = new DataSet();
        nadp.Fill(nds);
        Hyp1.Text = nds.Tables[0].Rows[0].ItemArray[0].ToString();
        Hyp1.NavigateUrl = "NewsPage.aspx?Nid=" + nds.Tables[0].Rows[0].ItemArray[1].ToString();
        Hyp2.Text =  nds.Tables[0].Rows[1].ItemArray[0].ToString();
        Hyp2.NavigateUrl = "NewsPage.aspx?Nid=" + nds.Tables[0].Rows[1].ItemArray[1].ToString();
        Hyp3.Text = nds.Tables[0].Rows[2].ItemArray[0].ToString();
        Hyp3.NavigateUrl = "NewsPage.aspx?Nid=" + nds.Tables[0].Rows[2].ItemArray[1].ToString();

        Hyp4.Text = nds.Tables[0].Rows[3].ItemArray[0].ToString();
        Hyp5.Text = nds.Tables[0].Rows[4].ItemArray[0].ToString();
        ncon.Close();

    }
    protected void Lstcatagory_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("CatagoryPage.aspx?Cat=" + Lstcatagory.SelectedValue.ToString());


    }
    protected void DdlCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("CityPage.aspx?city=" + DdlCity.SelectedItem.ToString());
    }
}

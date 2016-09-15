using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;


public partial class CatagoryControl : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillList();
        }
    }
    public string savefileandreturnpath(FileUpload pic)
    {
        string filename = "";
        string saveLocation = "";
        string returnlocation = "";
        if (pic.PostedFile.ContentLength != 0)
        {
            filename = System.IO.Path.GetFileName(@"c:\" + pic.PostedFile.FileName.ToString());
            saveLocation= HttpContext.Current.Server.MapPath("~/Pic") + "\\" + filename;
            returnlocation="~/Pic/" + filename;

            if (!System.IO.File.Exists(saveLocation))
            {
                pic.PostedFile.SaveAs(saveLocation);
            }
            else
            {
                System.IO.File.Delete(saveLocation);
                pic.PostedFile.SaveAs(saveLocation);
            }
        }
        return returnlocation;
    }
    protected void Btnsv_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConName"].ToString());
        string Query = "insert into Catagory(Catgorytype, Picturepath) values (@ct, @pp)";
        con.Open();
        SqlCommand cmd = new SqlCommand(Query, con);
        string path = savefileandreturnpath(Filepic);
        cmd.Parameters.AddWithValue("@ct", Txtcat.Text);
        cmd.Parameters.AddWithValue("@pp", path);
        cmd.ExecuteNonQuery();
        con.Close();
        fillList();
    }
    public void fillList()
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConName"].ToString());
        string Query = "select CatagoryID, Catgorytype from Catagory";
        con.Open();
        SqlDataAdapter adp = new SqlDataAdapter(Query, con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        Lstcat.DataSource = ds;
        Lstcat.DataTextField = "Catgorytype";
        Lstcat.DataValueField = "CatagoryID";
        Lstcat.DataBind();
        con.Close();
    }
}
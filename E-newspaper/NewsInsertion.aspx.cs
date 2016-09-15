using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;


public partial class NewsInsertion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillDdl();
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
            saveLocation = HttpContext.Current.Server.MapPath("~/News") + "\\" + filename;
            returnlocation = "~/News/" + filename;

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
    protected void Btnnewssv_Click(object sender, EventArgs e)
    {

        string value = Session["AId"].ToString();
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConName"].ToString());
        string Query = "insert into Adminnews(AdminId,CategoryId,City,Title,DateTime,picturepath,Body) values (@adn,@ci,@ct,@ti,@dt,@pp,@by)";
        con.Open();
        SqlCommand cmd = new SqlCommand(Query, con);
        string path = savefileandreturnpath(FilePic);
        cmd.Parameters.AddWithValue("@ci", DdlCat.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("@ct", DdlCity.SelectedItem.ToString());
        cmd.Parameters.AddWithValue("@dt", DateTime.Now);
        cmd.Parameters.AddWithValue("@ti", Txttitle.Text);
        cmd.Parameters.AddWithValue("@by", Txtbody.Text);
        cmd.Parameters.AddWithValue("@pp", path);
        cmd.Parameters.AddWithValue("@adn", value);
        cmd.ExecuteNonQuery();
        con.Close();
        fillDdl();

        Txttitle.Text = Txtbody.Text = "";
        DdlCat.SelectedIndex = -1;
        DdlCity.SelectedIndex = -1;

    }
    public void fillDdl()
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConName"].ToString());
        string Query = "select CatagoryID, Catgorytype from Catagory";
        con.Open();
        SqlDataAdapter adp = new SqlDataAdapter(Query, con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DdlCat.DataSource = ds;
        DdlCat.DataTextField = "Catgorytype";
        DdlCat.DataValueField = "CatagoryID";
        DdlCat.DataBind();
        con.Close();
    }
}
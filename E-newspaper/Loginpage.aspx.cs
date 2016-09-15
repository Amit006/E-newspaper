using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Loginpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Btnsgnup_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConName"].ToString());
        con.Open();
        string query = "insert into AdminProfile(Name,Address,Department,Position,State,Phone,Email,Password)values(@nm,@ad,@de,@po,@st,@ph,@em,@pwd)";
        SqlCommand com = new SqlCommand(query, con);
        com.Parameters.AddWithValue("@nm", Txtname.Text);
        com.Parameters.AddWithValue("@ad", Txtadd.Text);
        com.Parameters.AddWithValue("@de", Txtdept.Text);
        object Txtpos = null;
        com.Parameters.AddWithValue("@po", Txtpos.Text);
        com.Parameters.AddWithValue("@st", Txtstate.Text);
        com.Parameters.AddWithValue("@ph", Txtph.Text);
        com.Parameters.AddWithValue("@em", Txtemail.Text);
        com.Parameters.AddWithValue("@pwd", Txtpwd.Text);
        com.ExecuteNonQuery();
        con.Close();
    


    }
    protected void Lnklogin_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConName"].ToString());
        con.Open();
        string query = "select AdminId from AdminProfile where Email='" + TxtlgEmail.Text + "' and Password='" + Txtlgpwd.Text + "'";
        SqlDataAdapter adp = new SqlDataAdapter(query, con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Session.Add("AId", ds.Tables[0].Rows[0].ItemArray[0].ToString());
            Response.Redirect("Homepage.aspx");
        }
        else
        {
            LblMsg.Text = "Email or Password was Wrong...";
        }
        con.Close();
   
    }

   
}
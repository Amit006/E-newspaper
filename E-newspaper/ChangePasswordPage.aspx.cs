using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class ChangePasswordPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Btnupdate_Click(object sender, EventArgs e)
    {
        string value = Session["AId"].ToString();

        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConName"].ToString());
        con.Open();
        string query = "select Password from AdminProfile where AdminId='" + value + "'";
         SqlDataAdapter adp = new SqlDataAdapter(query, con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        con.Close();
        if (Txtoldpass.Text == ds.Tables[0].Rows[0].ItemArray[0].ToString())
        {
            if (Txtnewpass.Text == Txtrepass.Text)
            {
                string update = "update AdminProfile set Password=@pwd where AdminId='" + value + "'";
                con.Open();
                SqlCommand com = new SqlCommand(update, con);
                com.Parameters.AddWithValue("@pwd", Txtnewpass.Text);
                com.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                LblMsg.Text = "NEWPASSWORD AND RE-PASSWORD MISMATCHED........";
            }

        }
        else
        {
            LblMsg.Text ="CHECK YOUR OLD PASSWORD........";
        }
    }
}
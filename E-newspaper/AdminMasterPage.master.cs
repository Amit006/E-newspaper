﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AId"] == null)
        {
            Response.Redirect("LoginPage.aspx");
        }

    }
    protected void Lnklgout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("LoginPage.aspx");


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;


public partial class Yonetim_AdminMain : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["Kullanici"] == null)
                Response.Redirect("giris.aspx");
            
        }
    }


    protected void lnkbtnCikis_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("giris.aspx");
    }

    protected void lnkSifreDegistir_Click(object sender, EventArgs e)
    {
        Response.Redirect("sifredegistir.aspx");
    }
}


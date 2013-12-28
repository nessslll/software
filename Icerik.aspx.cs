using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class Icerik : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = DBW.veriGetir("select * from MENULER where MENU_ID=" + Request.QueryString["id"] + "");

        if (dt.Rows.Count > 0)
        {
            lblBaslik.Text = dt.Rows[0]["MENU_ADI"].ToString();
            ltrIcerik.Text = dt.Rows[0]["MENU_ICERIGI"].ToString();
        }
        else
        {
            ltrIcerik.Text = "Aradığınız içerik bulunmamaktadır.";
        }
    }
}
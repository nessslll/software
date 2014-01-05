using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class duyurular : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        DataTable dt = DBW.veriGetir("select * from Duyurular where DuyuruID=" + Request.QueryString["id"] + "");

        if (dt.Rows.Count > 0)
        {
            lblBaslik.Text = dt.Rows[0]["Baslik"].ToString();
            ltrIcerik.Text = dt.Rows[0]["Icerik"].ToString();
        }
        else
        {
            ltrIcerik.Text = "Aradığınız duyuru bulunmamaktadır.";
        }

        duyurulariyukle();

    }

    void duyurulariyukle()
    {


        DataTable dt = DBW.veriGetir("select * from Duyurular order by DuyuruID DESC");

        repDuyuru.DataSource = dt;
        repDuyuru.DataBind();

    }
}
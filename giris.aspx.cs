using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class giris : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGiris_Click(object sender, EventArgs e)
    {
        try
        {
            ltrHata.Text = "";
            if (txtKullaniciAdi.Text != "" && txtSifre.Text != "")
            {
                DataTable dt = DBW.veriGetir("select * from Kullanici where uname='" + txtKullaniciAdi.Text + "' and passw='" + txtSifre.Text + "' ");
                //'" + txtKullaniciAdi.Text + "' && KULLANICI_PAROLA='" + txtSifre.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    Session["Kullanici"] = dt.Rows[0]["uname"].ToString();
                    Session["KULLANICI_ID"] = dt.Rows[0]["u_id"].ToString(); 
                    Response.Redirect("IcerikDuzenle.aspx");

                }
                else
                {
                    ltrHata.Text = "Hatalı Giriş!";
                }
            }
        }
        catch (Exception ex)
        {
            ltrHata.Text = "Sistem Hatası!(" + ex.Message + ")";
        }

    }
}
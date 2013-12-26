using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Yonetim_sifredegistir : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Kullanici"] == null)
            Response.Redirect("giris.aspx");
    }
    protected void btnGiris_Click(object sender, EventArgs e)
    {
        if (txtSifreEski.Text == "" | txtSifre1.Text == "" | txtSifre2.Text == "")
        {
            ltrHata.Text = "Eksik Giriş Yaptınız";
        }
        else
        if (txtSifre1.Text != txtSifre2.Text)
        {
            ltrHata.Text = "Şifreler Uyuşmuyor";
        }
        else
        {
           
            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~/App_Data/db.mdb");
            OleDbConnection conn = new OleDbConnection(str);
            OleDbCommand komut = new OleDbCommand("UPDATE KULLANICILAR SET KULLANICI_PAROLA='" + txtSifre2.Text + "' where KULLANICI_ID=" + Session["KULLANICI_ID"] + " and KULLANICI_PAROLA='" + txtSifreEski.Text + "' ", conn);
            conn.Open();
            int x = komut.ExecuteNonQuery();
            if (x > 0)
            {
                ltrHata.Text = "Şifre Değiştirildi .<a href='giris.aspx'>Panel Giriş<a/>";    
            }
            else
            {
                ltrHata.Text = "Hata.";
            }
            conn.Close();
        }
    }
}
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
    SqlConnection baglanti = new SqlConnection("Data Source=M_AKIFEREN; Database=Database_Project;Integrated Security=true ");
    protected void Page_Load(object sender, EventArgs e)
    {
        baglanti.Open();
        string sql = "select * from  where mname='" + txtKullaniciAdi.Text + "' and mpassw='" + txtSifre.Text + "' ";


    }
    protected void btnGiris_Click(object sender, EventArgs e)
    {

        baglanti.Open();
        string sql = "select * from Manage where mname='" + txtKullaniciAdi.Text + "' and mpassw='" + txtSifre.Text + "' ";

        ltrHata.Text = "";
        if (txtKullaniciAdi.Text != "" && txtSifre.Text != "")
        {
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            if (dt.Rows.Count > 0)
            {
                Session["Kullanici"] = dt.Rows[0]["mname"].ToString();
                Response.Redirect("GaleriDuzenle.aspx");
            }

        }

        else
        {
            ltrHata.Text = "Hatalı Giriş!";
        }

        //ltrHata.Text = "";
        //if (txtKullaniciAdi.Text != "" && txtSifre.Text != "")
        //{
        //    DataTable dt = DBW.veriGetir("select * from Manage where mname='" + txtKullaniciAdi.Text + "' and mpassw='" + txtSifre.Text + "' ");
        //    //'" + txtKullaniciAdi.Text + "' && KULLANICI_PAROLA='" + txtSifre.Text + "'");
        //    if (dt.Rows.Count > 0)
        //    {
        //        //Session["Manage"] = dt.Rows[0]["mname"].ToString();
        //        //Session["Manage_ID"] = dt.Rows[0]["mpassw"].ToString(); 
        //        Response.Redirect("IcerikDuzenle.aspx");

        //    }
        //    else
        //    {
        //        ltrHata.Text = "Hatalı Giriş!";
        //    }
        //}


    }
}
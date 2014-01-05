using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kayit_ga_f : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userID"] == null)
        {
            Response.Redirect("userlogin.aspx");
        }
        if (!IsPostBack)
        {
            salonGetir();
        }

    }
    protected void btnKaydet_Click(object sender, EventArgs e)
    {
        int userID = int.Parse(Session["userID"].ToString());
        int s_id = int.Parse(dropSalon.SelectedValue);

        try
        {
            if (!kontrol())
            {
                if (!userkontrol())
                {
                    int a = DBW.InsertUpdate("INSERT INTO OnKayit (fk_sid,fk_uid) VALUES (" + s_id + "," + userID + ")");

                    if (a > 0)
                    {
                        lblUyari.Text = "Ön kaydınız tamamlandı.";
                        lblUyari.ForeColor = Color.Green;
                    }
                }
                else
                {
                    lblUyari.Text = "Daha Önceden Ön kaydınız yapılmış.";
                    lblUyari.ForeColor = Color.Red;
                }

            }

            else
            {
                lblUyari.Text = "Kontenjan Dolu Olduğu için Kaydınız yapılamadı.";
                lblUyari.ForeColor = Color.Red;
            }


        }
        catch (Exception)
        {
            lblUyari.Text = "Hata";
            lblUyari.ForeColor = Color.Red;

        }



    }


    bool kontrol()
    {


        bool deger = false;

        DataTable dt = DBW.veriGetir("select count(fk_sid) as sayi from OnKayit where fk_sid=" + dropSalon.SelectedValue + " group by fk_sid");
        DataTable dt1 = DBW.veriGetir("select * from GrupSalon");
        int sayi = 0;
        int sayi1 = 0;

        if (dt.Rows.Count > 0)
        {
            sayi = int.Parse(dt.Rows[0]["sayi"].ToString());
        }

        if (dt1.Rows.Count > 0)
        {
            sayi1 = int.Parse(dt1.Rows[0]["kontenjan"].ToString());
        }


        if (sayi > sayi1)
        {
            deger = true;
        }



        return deger;
    }

    bool userkontrol()
    {

        int userID = int.Parse(Session["userID"].ToString());
        int s_id = int.Parse(dropSalon.SelectedValue);
        bool deger = false;

        DataTable dt = DBW.veriGetir("select * from OnKayit where fk_uid=" + userID + " and fk_sid=" + s_id);


        if (dt.Rows.Count > 0)
        {
            deger = true;
        }



        return deger;
    }


    void salonGetir()
    {
        DataTable dt = DBW.veriGetir("select * from GrupSalon");

        dropSalon.DataTextField = "sname";
        dropSalon.DataValueField = "sid";

        dropSalon.DataSource = dt;
        dropSalon.DataBind();

    }
}
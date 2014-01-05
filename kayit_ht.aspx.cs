using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kayit_ht : System.Web.UI.Page
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
            userRezervasyonGetir();
        }

    }
    protected void btnKaydet_Click(object sender, EventArgs e)
    {
        int userID = int.Parse(Session["userID"].ToString());
        int s_id = int.Parse(dropSalon.SelectedValue);

        string tarih = datepicker.Value.ToString();
        string saat = dropSaat.SelectedItem.Text.ToString();

        if (!kontrol())
        {
            int a = DBW.InsertUpdate("INSERT INTO Reservation_Relation (fk_uid,fk_sid,r_tarih,r_saati) VALUES (" + userID + "," + s_id + ",'" + tarih + "','" + saat + "')");

            if (a > 0)
            {
                lblUyari.Text = "Rezervasyon tamamlandı.";
                lblUyari.ForeColor = Color.Green;
                userRezervasyonGetir();
            }
        }
        else
        {
            lblUyari.Text = "Bu tarih ve saatte rezervasyon yapılmaz.";
            lblUyari.ForeColor = Color.Red;
        }

    }

    bool kontrol()
    {
        string tarih = datepicker.Value;
        string saat = dropSaat.SelectedItem.Text;

        bool deger = false;

        DataTable dt = DBW.veriGetir("select * from Reservation_Relation where fk_sid=" + dropSalon.SelectedValue + " and r_tarih='" + tarih + "' and r_saati='" + saat + "'");

        if (dt.Rows.Count > 0)
        {
            deger = true;
        }

        return deger;
    }

    void salonGetir()
    {
        DataTable dt = DBW.veriGetir("select * from Saloons");

        dropSalon.DataTextField = "sname";
        dropSalon.DataValueField = "s_id";

        dropSalon.DataSource = dt;
        dropSalon.DataBind();

    }

    void userRezervasyonGetir()
    {
        int userID = int.Parse(Session["userID"].ToString());

        DataTable dt = DBW.veriGetir("select r.r_tarih,r.r_saati,k.uname,k.ulname,k.ogrno,k.mail,k.phone,s.sname from Reservation_Relation r,Kullanici k,Saloons s where r.fk_uid=k.u_id and r.fk_sid=s.s_id and r.fk_uid=" + userID);

        gridrezervasyon.DataSource = dt;
        gridrezervasyon.DataBind();

    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Yonetim_Rezervasyonlar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        rezervasyonGetir();
        rezervasyonGetir1();
    }


    void rezervasyonGetir()
    {
        DataTable dt = DBW.veriGetir("select r.r_tarih,r.r_saati,k.uname,k.ulname,k.ogrno,k.mail,k.phone,s.sname from Reservation_Relation r,Kullanici k,Saloons s where r.fk_uid=k.u_id and r.fk_sid=s.s_id");

        gridRezervasyon.DataSource = dt;
        gridRezervasyon.DataBind();
    }

    void rezervasyonGetir1()
    {
        DataTable dt = DBW.veriGetir("select k.uname,k.ulname,k.ogrno,k.mail,k.phone,s.sname from OnKayit r,Kullanici k,GrupSalon s where r.fk_uid=k.u_id and r.fk_sid=s.sid");

        gridRezervasyon1.DataSource = dt;
        gridRezervasyon1.DataBind();
    }
}
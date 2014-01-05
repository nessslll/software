using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        duyurulariyukle();
        if (Session["userID"] != null)
        {
            ligiris.Visible = false;
            liuser.Visible = true;
            licikis.Visible = true;
            KullaniciBilgiGetir();
        }
        else
        {
            liuser.Visible = false;
            licikis.Visible = false;
        }

    }

    void duyurulariyukle()
    {
        try
        {

            DataTable dt = DBW.veriGetir("select * from Duyurular order by DuyuruID DESC");

            repDuyuru.DataSource = dt;
            repDuyuru.DataBind();



        }
        catch (Exception)
        {


        }


    }


    void KullaniciBilgiGetir()
    {
        try
        {

            DataTable dt = DBW.veriGetir("select * from Kullanici where u_id=" + Session["userID"].ToString());

            if (dt.Rows.Count>0)
            {
                lblUser.Text = dt.Rows[0]["uname"].ToString();
            }


        }
        catch (Exception)
        {


        }


    }
}
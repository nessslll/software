using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
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

    


    void KullaniciBilgiGetir()
    {
        try
        {

            DataTable dt = DBW.veriGetir("select * from Kullanici where u_id=" + Session["userID"].ToString());

            if (dt.Rows.Count > 0)
            {
                lblUser.Text = dt.Rows[0]["uname"].ToString();
            }


        }
        catch (Exception)
        {


        }


    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class duyurular : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        DataTable dt = DBW.veriGetir("select * from DUYURULAR where DUYURU_ID=" + Request.QueryString["id"] + "");

        if (dt.Rows.Count > 0)
        {
            lblBaslik.Text = dt.Rows[0]["DUYURU_BASLIGI"].ToString();
            ltrIcerik.Text = dt.Rows[0]["DUYURU_ICERIGI"].ToString();
        }
        else
        {
            ltrIcerik.Text = "Aradığınız duyuru bulunmamaktadır.";
        }

        duyurulariyukle();

    }

    void duyurulariyukle()
    {
        OleDbConnection baglan = new OleDbConnection();
        baglan.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source=" + Server.MapPath("App_Data\\db.mdb");
        baglan.Open();
        OleDbCommand cmd = new OleDbCommand();
        cmd.Connection = baglan;
        cmd.CommandText = "select * from DUYURULAR ORDER BY  DUYURU_ID DESC ";
        OleDbDataReader drliste = cmd.ExecuteReader();
        DataTable dt = new DataTable();
        dt.Load(drliste);

        repDuyuru.DataSource = dt;
        repDuyuru.DataBind();

        drliste.Close();
        baglan.Close();
    }
}
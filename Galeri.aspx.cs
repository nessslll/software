using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Galeri : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        galeriyukle();
    }

    void galeriyukle()
    {
        OleDbConnection baglan = new OleDbConnection();
        baglan.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source=" + Server.MapPath("App_Data\\db.mdb");
        baglan.Open();
        OleDbCommand cmd = new OleDbCommand();
        cmd.Connection = baglan;
        cmd.CommandText = "select * from Galeri ORDER BY Id ";
        OleDbDataReader drliste = cmd.ExecuteReader();
        DataTable dt = new DataTable();
        dt.Load(drliste);

        repGaleri.DataSource = dt;
        repGaleri.DataBind();

        drliste.Close();
        baglan.Close();
    }
}
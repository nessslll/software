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
        menuleriyukle();
    }

    void menuleriyukle()
    {
        OleDbConnection baglan = new OleDbConnection();
        baglan.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source=" + Server.MapPath("App_Data\\db.mdb");
        baglan.Open();
        OleDbCommand cmd = new OleDbCommand();
        cmd.Connection = baglan;
        cmd.CommandText = "select * from MENULER ORDER BY MENU_ID ";
        OleDbDataReader drliste = cmd.ExecuteReader();
        DataTable dt = new DataTable();
        dt.Load(drliste);

        repBaslik.DataSource = dt;
        repBaslik.DataBind();

        drliste.Close();
        baglan.Close();
    }
}

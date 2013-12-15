using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        duyurulariyukle();
    }

    void duyurulariyukle()
    {
        OleDbConnection baglan = new OleDbConnection();
        baglan.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source=" + Server.MapPath("App_Data\\db.mdb");
        baglan.Open();
        OleDbCommand cmd = new OleDbCommand();
        cmd.Connection = baglan;
        cmd.CommandText = "select TOP 5 * from DUYURULAR ORDER BY DUYURU_ID DESC   ";
        OleDbDataReader drliste = cmd.ExecuteReader();
        DataTable dt = new DataTable();
        dt.Load(drliste);

        repDuyuru.DataSource = dt;
        repDuyuru.DataBind();

        drliste.Close();
        baglan.Close();
    }
}
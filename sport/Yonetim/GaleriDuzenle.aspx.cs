using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;


public partial class Yonetim_GaleriDuzenle : System.Web.UI.Page
{
    OleDbConnection baglan = new OleDbConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            yukle();
        }

    }

    public void yukle()
    {
        baglan.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source=" + Server.MapPath("../App_Data\\db.mdb");
        baglan.Open();
        OleDbCommand listele = new OleDbCommand();
        listele.Connection = baglan;
        listele.CommandText = "SELECT * from Galeri";
        OleDbDataReader drliste = listele.ExecuteReader();
        DataTable dtliste = new DataTable();
        dtliste.Load(drliste);
        Repeater1.DataSource = dtliste;
        Repeater1.DataBind();
        drliste.Close();
        baglan.Close();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {

            FileUpload1.SaveAs(Server.MapPath("../images/galeri/full/" + FileUpload1.FileName));
            String ressim = FileUpload1.FileName;
            ressim = "images/galeri/full/" + ressim;
            baglan.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source=" + Server.MapPath("../App_Data\\db.mdb");
            baglan.Open();
            OleDbCommand resimekle = new OleDbCommand();
            resimekle.Connection = baglan;
            resimekle.CommandText = "insert into Galeri(Resim) values(@ResimYolu)";
            resimekle.Parameters.AddWithValue("@ResimYolu", ressim);
            resimekle.ExecuteNonQuery();
            baglan.Close();
            Response.Redirect("GaleriDuzenle.aspx");
        }

        else
        {
            alarm.Show("RESİM SECİNİZ");
        }

    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandArgument.Equals("sil"))
        {
            baglan.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source=" + Server.MapPath("../App_Data\\db.mdb");
            baglan.Open();
            OleDbCommand urunsil = new OleDbCommand();
            urunsil.Connection = baglan;
            urunsil.CommandText = "delete from Galeri where ID=@ID";
            urunsil.Parameters.AddWithValue("@ID", ((Label)e.Item.FindControl("lblID")).Text);
            urunsil.ExecuteNonQuery();  
            Response.Redirect("GaleriDuzenle.aspx");
            alarm.Show("RESİM SİLİNDİ");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;


public partial class Yonetim_IcerikDuzenle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            lblHata.Text = "";
           
                menuyukle();
              
        }

    }

    void menuyukle()
    {
        DataTable dt = DBW.veriGetir("select * from  order by MENU_ID");
        gridMenuler.DataSource = dt;
        gridMenuler.DataBind();
        string detay = dt.Rows[0][2].ToString();

    }

    protected void gridMenuler_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selectedRowIndex;
        selectedRowIndex = gridMenuler.SelectedIndex;
        GridViewRow row = gridMenuler.Rows[selectedRowIndex];
        DataTable dt = DBW.veriGetir("select * from MENULER where MENU_ID=" + row.Cells[0].Text + "");
        lblId.Text = dt.Rows[0][0].ToString();
        TxtMenuAdi.Text = dt.Rows[0][1].ToString();
        CKDetay.Text = dt.Rows[0][2].ToString();
        lblHata.Text = "";

    }

    

    protected void btnKaydet_Click(object sender, EventArgs e)
    {
        if (TxtMenuAdi.Text != "" & lblId.Text != "")
        {

            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~/App_Data/db.mdb");
            OleDbConnection conn = new OleDbConnection(str);
            OleDbCommand komut = new OleDbCommand("update MENULER set MENU_ADI='" + TxtMenuAdi.Text + "',MENU_ICERIGI='" + CKDetay.Text + "' where MENU_ID=" + lblId.Text + "", conn);

            conn.Open();
            int x = komut.ExecuteNonQuery();
            if (x > 0)
            {
                lblHata.Text = "İçerik Güncellendi.";
            }
            else
            {

                lblHata.Text = "Hata Oluştu";
            }
            conn.Close();
            menuyukle();
        }
        else
        {
            CKDetay.Text = "";
            TxtMenuAdi.Text = "";
            lblId.Text = "";
            menuyukle();
        }
    }
    protected void btnSil_Click(object sender, EventArgs e)
   
    {
        if (TxtMenuAdi.Text != "" & lblId.Text != "")
        {

            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~/App_Data/db.mdb");
            OleDbConnection conn = new OleDbConnection(str);
            OleDbCommand komut = new OleDbCommand("delete from MENULER where MENU_ID=" + lblId.Text + "", conn);

            conn.Open();
            int x = komut.ExecuteNonQuery();
            if (x > 0)
            {
                lblHata.Text = "İçerik Silindi.";
            }
            else
            {

                lblHata.Text = "Hata Oluştu";
            }
            conn.Close();
            menuyukle();
        }
        else
        {
            CKDetay.Text = "";
            TxtMenuAdi.Text = "";
            lblId.Text = "";
            menuyukle();
        }
    }


    protected void btnYeni_Click(object sender, EventArgs e)
    {
        if (TxtMenuAdi.Text != "")
        {

            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~/App_Data/db.mdb");
            OleDbConnection conn = new OleDbConnection(str);
            OleDbCommand komut = new OleDbCommand("insert into MENULER (MENU_ADI,MENU_ICERIGI) values ('" + TxtMenuAdi.Text + "' , '" + CKDetay.Text + "')", conn);

            conn.Open();
            int x = komut.ExecuteNonQuery();
            if (x > 0)
            {
                lblHata.Text = "Yeni İçerik Eklendi.";
            }
            else
            {

                lblHata.Text = "Hata Oluştu";
            }
            conn.Close();
            menuyukle();
        }
        else
        {
            CKDetay.Text = "";
            TxtMenuAdi.Text = "";
            lblId.Text = "";
            menuyukle();
        }

    }
}
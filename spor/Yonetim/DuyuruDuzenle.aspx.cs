using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class Yonetim_DuyuruDuzenle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            lblHata.Text = "";

            duyuruyukle();

        }

    }

    void duyuruyukle()
    {
        DataTable dt = DBW.veriGetir("select * from DUYURULAR order by DUYURU_ID");
        gridDuyurular.DataSource = dt;
        gridDuyurular.DataBind();
  

    }

    protected void gridMenuler_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selectedRowIndex;
        selectedRowIndex = gridDuyurular.SelectedIndex;
        GridViewRow row = gridDuyurular.Rows[selectedRowIndex];
        DataTable dt = DBW.veriGetir("select * from DUYURULAR where DUYURU_ID=" + row.Cells[0].Text + "");
        lblId.Text = dt.Rows[0][0].ToString();
        TxtDuyuruBaslik.Text = dt.Rows[0][1].ToString();
        CKDetay.Text = dt.Rows[0][2].ToString();
        lblHata.Text = "";

    }


    //GÜNCELLE
    protected void btnKaydet_Click(object sender, EventArgs e)
    {
        if (TxtDuyuruBaslik.Text != "" & lblId.Text != "")
        {

            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~/App_Data/db.mdb");
            OleDbConnection conn = new OleDbConnection(str);
            OleDbCommand komut = new OleDbCommand("update DUYURULAR set DUYURU_BASLIGI='" + TxtDuyuruBaslik.Text + "',DUYURU_ICERIGI='" + CKDetay.Text + "' where DUYURU_ID=" + lblId.Text + "", conn);

            conn.Open();
            int x = komut.ExecuteNonQuery();
            if (x > 0)
            {
                lblHata.Text = "Duyuru Güncellendi.";
            }
            else
            {

                lblHata.Text = "Hata Oluştu";
            }
            conn.Close();
            duyuruyukle();
        }
        else
        {
            lblHata.Text = "Seçim Yapınız";
            CKDetay.Text = "";
            TxtDuyuruBaslik.Text = "";
            lblId.Text = "";
            duyuruyukle();
        }



    }
    protected void btnSil_Click(object sender, EventArgs e)
    {
        if (TxtDuyuruBaslik.Text != "" & lblId.Text != "")
        {

            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~/App_Data/db.mdb");
            OleDbConnection conn = new OleDbConnection(str);
            OleDbCommand komut = new OleDbCommand("delete from DUYURULAR where DUYURU_ID=" + lblId.Text + "", conn);

            conn.Open();
            int x = komut.ExecuteNonQuery();
            if (x > 0)
            {
                lblHata.Text = "Duyuru Silindi.";
            }
            else
            {

                lblHata.Text = "Hata Oluştu";
            }
            conn.Close();
            duyuruyukle();
        }
        else
        {
            CKDetay.Text = "";
            TxtDuyuruBaslik.Text = "";
            lblId.Text = "";
            duyuruyukle();
        }

       
    }



    protected void btnYeni_Click(object sender, EventArgs e)
    {
        if (TxtDuyuruBaslik.Text != "" )
        {

            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~/App_Data/db.mdb");
            OleDbConnection conn = new OleDbConnection(str);
            OleDbCommand komut = new OleDbCommand("insert into DUYURULAR (DUYURU_BASLIGI,DUYURU_ICERIGI) values ('" + TxtDuyuruBaslik.Text + "' , '" + CKDetay.Text + "')", conn);

            conn.Open();
            int x = komut.ExecuteNonQuery();
            if (x > 0)
            {
                lblHata.Text = "Yeni Duyuru Eklendi.";
            }
            else
            {

                lblHata.Text = "Hata Oluştu";
            }
            conn.Close();
            duyuruyukle();
        }
        else
        {
            CKDetay.Text = "";
            TxtDuyuruBaslik.Text = "";
            lblId.Text = "";
            duyuruyukle();
        }


    }
}
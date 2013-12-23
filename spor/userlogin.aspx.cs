using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class userlogin : System.Web.UI.Page
{
    SqlConnection baglanti = new SqlConnection("Data Source=M_AKIFEREN; Database=Database_Project;Integrated Security=true ");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGiris_Click(object sender, EventArgs e)
    {
    
            baglanti.Open();
            string sql = "select * from Kullanici where nick='" + txtKullaniciAdi.Text + "' and passw='" + txtSifre.Text + "' ";

            ltrHata.Text = "";
            if (txtKullaniciAdi.Text != "" && txtSifre.Text != "")
            {
                SqlCommand cmd = new SqlCommand(sql, baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    Session["userID"]=dt.Rows[0]["u_id"].ToString();
                    Response.Redirect("Default.aspx");
                }

            }

            else
            {
                ltrHata.Text = "Hatalı Giriş!";
            }

            
        

    }
}
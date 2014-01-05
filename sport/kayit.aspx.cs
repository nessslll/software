using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class kayit : System.Web.UI.Page
{
    SqlConnection baglanti = new SqlConnection("Data Source=NESLISAH_EFE; Database=Database_Project");

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            
        baglanti.Open();
        
        
        
      string  adi = TextBox1.Text;
      string  soyadi = TextBox2.Text;
      string telno = TextBox7.Text;
      string  ogrencino = TextBox11.Text;
      string nick = TextBox8.Text;
      string  sifre = TextBox4.Text;
        string mail=TextBox6.Text; 
        bool cinsiyet;
        if (RadioButton1.Checked==true)
            cinsiyet=true;
        else cinsiyet=false;
        SqlCommand komut = new SqlCommand();
        komut.Connection = baglanti;
        if (TextBox4.Text == TextBox5.Text)
        {
            komut.CommandText = "insert into kullanici (uname,ulname,ogrno,passw,cinsiyet,u_katkod,nick,phone,mail) values (" + adi + "," + soyadi + "," + ogrencino + "," + sifre + "," + cinsiyet + "," + DropDownList1.SelectedValue + "," + nick + "," + telno + "," + mail;
            komut.ExecuteNonQuery();
        }
        baglanti.Close();
        
        }
        catch (Exception)
        {
            
            throw;
        }
            

       // AdminWork.kullaniciOlustur(DropDownList1.SelectedIndex, TextBox1.Text, TextBox2.Text, int.Parse(TextBox11.Text), TextBox8.Text, TextBox4.Text);
    }
    
}
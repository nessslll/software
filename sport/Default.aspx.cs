using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;



public partial class _Default : System.Web.UI.Page
{
     SqlConnection conn = new SqlConnection("Data Source=NESLISAH_EFE; Initial Catalog=Database_Project;Integrated Security= true");
    protected void Page_Load(object sender, EventArgs e)
    {
        duyurulariyukle();
    }

    void duyurulariyukle()
    {        
         conn.Open();        

        
        
        /*catch (Exception ex){
            Console.WriteLine(ex.Message);
        }*/

        TextBox1.Text = "1";
        int i = -1;
        SqlCommand komut = new SqlCommand();
        komut.Connection = conn;
        komut.CommandText = "select * from Manage";
        SqlDataReader dr = komut.ExecuteReader();
        while (dr.Read()) {
            i++;
            if (dr[i].ToString() == TextBox1.Text)
                Response.Redirect("sahaaktivite.aspx");            
            else TextBox1.Text="YOOOOOOOOOOOOOOOOOOOOOOOOK";

        }
        dr.Close();
        conn.Close();
        
        
        
        
        
        
        /*
        SqlConnection conn = new SqlConnection("Data source=./; Initial Catalog=Data_Project.mdf; Integrated Security=true");
       /* SqlCommand komut = new SqlCommand();
        DataTable tb = new DataTable();
        SqlDataAdapter adtr;*/
       // SqlConnection conn = new SqlConnection();
        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)/v11.0;AttachDbFilename=C:\Users\makiferen\Documents\Visual Studio 2012\Projects\spor\App_Data\Database_Project.mdf;Integrated Security=True");
        //conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename= Database_Project.mdf;Integrated Security=True";
       // SqlConnection conn = new SqlConnection();
        //conn.ConnectionString = @"Data Source=(LocalDB)/v11.0;AttachDbFilename=C:\Users\makiferen\Documents\Visual Studio 2012\Projects\Sport\App_Data\Database_Project.mdf;Integrated Security=True;Connect Timeout=30";
      /*
        conn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "select TOP 5 * from Kullanici";
        SqlDataReader drliste = cmd.ExecuteReader();
        DataTable dt = new DataTable();
        dt.Load(drliste);

        repDuyuru.DataSource = dt;
        repDuyuru.DataBind();

        drliste.Close();
        conn.Close();*/
    }
}
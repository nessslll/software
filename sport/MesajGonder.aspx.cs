using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class MesajGonder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGonder_Click(object sender, EventArgs e)
    {
        {
            string ad = txtAdSoyad.Text;
            string tel = txtTelefon.Text;
            string mailX = txtEposta.Text;
            string konu = txtKonu.Text;
            string mesaj = txtMesaj.Text;

            try
            {
                string fromAddress = "xxx@gmail.com";
                string fromName = "ESOGÜ Spor Salonu";
                string toMail = "xxx2@gmail.com";
                string toNme = "ESOGÜ Spor Salonu";
                string msgSubject = "Yeni  Mesaj";
                string sifre = "sifre";


                string msgBody = "ESOGÜ Spor Salonu tarafından bir mesaj aldınız ; \n"
                + "\n"
                + "\n"

                + "Gönderenin Adı Soyadı         :" + ad + "\n"
                + "Gönderenin Telefonu           :" + tel + "\n"
                + "Gönderenin Emaili             :" + mailX + "\n"
                + "Gönderenin Konusu             :" + konu + "\n"
                + "Gönderenin Mesajı             :" + mesaj + "\n"
                + "\n"
                + "============================"
                + "\n"
                + "ESOGÜ Spor Salonu iletişim Formu"
                + "\n"
                + "============================"
                + "\n";


                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential(fromAddress, sifre);
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                MailAddress from = new MailAddress(fromAddress, fromName);
                MailAddress to = new MailAddress(toMail, toNme);
                MailMessage message = new MailMessage(from, to);
                message.Subject = msgSubject;
                message.Body = msgBody;
                client.Send(message);
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
                txtEposta.Text = "";
                txtKonu.Text = "";
                txtMesaj.Text = "";
                lblDurum.Visible = true;
                lblDurum.Text = "Teşekkürler! En kısa zamanda size ulaşacağız.";


            }
            catch
            {
                lblDurum.Visible = true;
                lblDurum.Text = "Bir hata oluştu tekrar deneyiniz.";
                lblDurum.ForeColor = System.Drawing.Color.DarkRed;
            }
        }
    }
}
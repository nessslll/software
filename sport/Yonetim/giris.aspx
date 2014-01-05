<%@ Page Language="C#" AutoEventWireup="true" CodeFile="giris.aspx.cs" Inherits="giris" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
 
<link href="login.css" rel="stylesheet" type="text/css" />

 <link href="Content/themes/base/jquery.ui.all.css" rel="stylesheet" type="text/css" />
    <link href="Content/themes/base/jquery-ui.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery-2.0.2.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery-ui-1.10.3.js" type="text/javascript"></script>
    <script src="js/default.js" type="text/javascript"></script>


     <title>ESOGÜ Spor Salonu</title>
</head>
<body>
<div class="container">
	<section id="content">
		<form id="Form1" name="login-form" method="post" runat="server">
			<h2>ESOGÜ Spor Salonu</h2>
              <h4>Yönetim Panel Giriş</h4>
			<div>
				   <asp:TextBox ID="txtKullaniciAdi" runat="server"  placeholder="Kullanıcı Adı"></asp:TextBox>	
			</div>
			<div>
				   <asp:TextBox ID="txtSifre" runat="server" placeholder="Şifre" TextMode="Password"></asp:TextBox>	
			</div>
			<div>
				   <asp:Button ID="btnGiris" runat="server" Text="Giriş" onclick="btnGiris_Click"  />
				
				
			</div>  
            
             <asp:Literal ID="ltrHata" runat="server"></asp:Literal>
		</form>
	</section>
</div>
</body>
</html>

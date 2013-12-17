<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="MesajGonder.aspx.cs" Inherits="MesajGonder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>İletişim Bilgileri</h3>
				  <table width="100%" height="144px" border="0" cellpadding="5" cellspacing="0">
			<tr align="left">
                <td colspan="3" valign="top">
                    <h4>Adres Bilgileri</h4>
                                <ul>
                                   
                                    <li>Üniversite  </li> 
                                    <li>Üniversite</li>   
                                    <li>Üniversite</li>               
                                    <li>  ESKİŞEHİR</li> 
                                    <li>Mail: <a href="#">xxxx@ogu.edu.tr</a> </li>
                                   
                                </ul> <h4>Sosyal Ağ</h4>
                                    <ul>
                                       
                                        <a href="https://www.facebook.com/" target="blank">
                                            <img src="images/sosyal/facebook.png" alt="facebook" width="64" height="64"></a>
                                        <a href="https://twitter.com/" target="blank">
                                            <img src="images/sosyal/twitter.png" alt="twitter" width="64" height="64"></a>
                                        <a href="#">
                                            <img src="images/sosyal/google.png" alt="google" width="64" height="64"></a>
                                </ul>
                                   
                </td> 
              </tr>
                   
                       <tr align="left">
                <td colspan="3" valign="top">
                    <h4>İletişim Formu</h4> 
                </td> 
              </tr>     
              <tr>                    
                <td width="27%" align="left" valign="top">Adınız Soyadınız 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtAdSoyad" ErrorMessage="!"></asp:RequiredFieldValidator>
                  </td>
                <td width="3%" align="center" valign="top">:</td>
                <td width="70%" align="left" valign="top">
                    <asp:TextBox ID="txtAdSoyad" CssClass="IletisimInput" runat="server"></asp:TextBox>
                  </td>
              </tr>
                     

              <tr>
                <td align="left" valign="top">Telefon Numaranız 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtTelefon" ErrorMessage="!"></asp:RequiredFieldValidator>
                  </td>
                <td align="center" valign="top">:</td>
                <td align="left" valign="top">
                    <asp:TextBox ID="txtTelefon" CssClass="IletisimInput" runat="server"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                <td align="left" valign="top">Email Adresiniz 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtEposta" ErrorMessage="!"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtEposta" ErrorMessage="!" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                  </td>
                <td align="center" valign="top">:</td>
                <td align="left" valign="top">
                    <asp:TextBox ID="txtEposta" CssClass="IletisimInput" runat="server"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                <td align="left" valign="top">Konu<asp:RequiredFieldValidator 
                        ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtKonu" 
                        ErrorMessage="!"></asp:RequiredFieldValidator>
                  </td>
                <td align="center" valign="top">:</td>
                <td align="left" valign="top">
                    <asp:TextBox ID="txtKonu" CssClass="IletisimInput" runat="server"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                <td align="left" valign="top">Mesajınız<asp:RequiredFieldValidator 
                        ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtMesaj" 
                        ErrorMessage="!"></asp:RequiredFieldValidator>
                  </td>
                <td align="center" valign="top">:</td>
                <td align="left" valign="top">
                    <asp:TextBox ID="txtMesaj" CssClass="IletisimInput" runat="server" Rows="5" 
                        TextMode="MultiLine"></asp:TextBox>
                  </td>
              </tr>
			  
			    <tr>
                <td align="left" valign="top"></td>
                <td align="center" valign="top"></td>
                <td align="left" valign="top">
				
                     
                  <asp:Button ID="btnGonder" class="FRMButon" runat="server" Text="Gönder" 
                        onclick="btnGonder_Click" />
                                <asp:Label ID="lblDurum" runat="server" Text="" 
                        Visible="False"></asp:Label>
                                </td>
                    
              </tr>
            </table>
			<table width="86%" border="0" cellpadding="5" cellspacing="0">
                    <tbody><tr>
                      <td colspan="3">
					 <iframe width="650" height="500" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://maps.google.com/maps?ie=UTF8&amp;t=h&amp;ll=39.788234,30.489303&amp;spn=0.004122,0.007499&amp;z=17&amp;output=embed"></iframe><br /><small><a href="https://maps.google.com/maps?ie=UTF8&amp;t=h&amp;ll=39.788234,30.489303&amp;spn=0.004122,0.007499&amp;z=17&amp;source=embed" style="color:#0000FF;text-align:left">Daha Büyük Görüntüle</a></small>
                            </td>
                      </tr>
                  </tbody></table>
		
</asp:Content>



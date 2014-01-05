<%@ Page Language="VB" AutoEventWireup="false" CodeFile="kayit.aspx.vb" Inherits="kayit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 96px;
        }
        .auto-style1 {
            width: 420px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <table border="1" style="height: 414px; width: 563px">
           <tr><td class="auto-style2"> 
               <asp:Label ID="Label12" runat="server" Text="Kategori:"></asp:Label>
               </td>
               <td class="auto-style1"> 
                   <asp:DropDownList ID="DropDownList1" runat="server">
                   </asp:DropDownList>
               </td>
            </tr>
           <tr><td class="auto-style2"> 
               <asp:Label ID="Label1" runat="server" Text="Adı :"></asp:Label>
               </td>
               <td class="auto-style1"> 
                   <asp:TextBox ID="TextBox1" runat="server" Width="164px"></asp:TextBox>
               </td>
            </tr>
           <tr>
           <td class="auto-style2">  
               <asp:Label ID="Label2" runat="server" Text="Soyadı :"></asp:Label>
           </td>
               <td class="auto-style1"> 
                   <asp:TextBox ID="TextBox2" runat="server" Width="164px"></asp:TextBox>
           </td>
           </tr>
           <tr>
           <td class="auto-style2">  
               <asp:Label ID="Label11" runat="server" Text="Cinsiyet:"></asp:Label>
               </td>
               <td class="auto-style1"> 
&nbsp;<asp:RadioButton ID="RadioButton1" runat="server" />
                   <asp:RadioButton ID="RadioButton2" runat="server" Checked="True" />
               </td>
           </tr>
           <tr>
           <td class="auto-style2"> 
               <asp:Label ID="Label3" runat="server" Text="Öğrenci No:"></asp:Label>
           </td>
               <td class="auto-style1"> 
                   <asp:TextBox ID="TextBox11" runat="server" Width="164px"></asp:TextBox>
           </td>
            </tr>
           <tr>
           <td class="auto-style2">   
               <asp:Label ID="Label4" runat="server" Text="Şifre:"></asp:Label>
           </td> <td class="auto-style1"> 
               <asp:TextBox ID="TextBox4" runat="server" Width="164px"></asp:TextBox>
           </td>
        
           </tr>
             <tr>
            <td class="auto-style2">   
                <asp:Label ID="Label5" runat="server" Text="Şifre(Tekrar):"></asp:Label>
           </td> <td class="auto-style1"> 
               <asp:TextBox ID="TextBox5" runat="server" Width="164px"></asp:TextBox>
           </td>
           </tr>
             <tr>
            <td class="auto-style2">   
                <asp:Label ID="Label6" runat="server" Text="Mail:"></asp:Label>
           </td><td class="auto-style1"> 
               <asp:TextBox ID="TextBox6" runat="server" Width="164px"></asp:TextBox>
           </td>
                   </tr>
           <tr>
            <td class="auto-style2">   
                <asp:Label ID="Label7" runat="server" Text="Tel No:"></asp:Label>
           </td><td class="auto-style1"> 
               <asp:TextBox ID="TextBox7" runat="server" Width="164px"></asp:TextBox>
           </td>
               </tr>
           <tr>
           <td class="auto-style2">   
               <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
           </td><td class="auto-style1"> 
               <asp:TextBox ID="TextBox8" runat="server" Width="164px"></asp:TextBox>
           </td>
               </tr>
           <tr>
           <td class="auto-style2">   
               <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
           </td><td class="auto-style1"> 
               <asp:TextBox ID="TextBox9" runat="server" Width="164px"></asp:TextBox>
           </td>
               </tr>
           <tr>
             <td class="auto-style2">   
                 <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
           </td><td class="auto-style1"> 
               <asp:TextBox ID="TextBox10" runat="server" Width="164px"></asp:TextBox>
           </td> 
           </tr>

           <tr>
            <td> 
              
                <asp:Button ID="Button1" runat="server" Text="Kaydet" />
              
           </td>
                 </tr>
       </table>
    </div>
    </form>
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="kayit_ht.aspx.cs" Inherits="kayit_ht" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css">
  <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
  <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
  <link rel="stylesheet" href="/resources/demos/style.css">
  <script>
      $(function () {
          $("#ctl00_ContentPlaceHolder1_datepicker").datepicker();
      });
  </script>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 162px;
        }
        .auto-style3 {
            width: 135px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Saha Aktiviteleri</td>
            <td class="auto-style3">
                <asp:DropDownList ID="dropSalon" runat="server" Width="100" >
                   
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Tarih</td>
            <td class="auto-style3">
               <input runat="server"  type="text" id="datepicker" style="width:100px;">
            </td>
            <td>
                <asp:Label ID="lblUyari" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style2">Saat</td>
            <td class="auto-style3">
                <asp:DropDownList ID="dropSaat" runat="server">
                    <asp:ListItem Value="0">10.00-11.00</asp:ListItem>
                    <asp:ListItem Value="1">11.00-12.00</asp:ListItem>
                    <asp:ListItem Value="2">12.00-13.00</asp:ListItem>
                    <asp:ListItem Value="3">13.00-14.00</asp:ListItem>
                    <asp:ListItem Value="4">14.00-15.00</asp:ListItem>
                    <asp:ListItem Value="5">15.00-16.00</asp:ListItem>
                    <asp:ListItem Value="6">16.00-17.00</asp:ListItem>
                    <asp:ListItem Value="7">17.00-18.00</asp:ListItem>
                    <asp:ListItem Value="8">18.00-19.00</asp:ListItem>
                    <asp:ListItem Value="9">19.00-20.00</asp:ListItem>
                    <asp:ListItem Value="10">20.00-21.00</asp:ListItem>
                    <asp:ListItem Value="11">21.00-22.00</asp:ListItem>
                    <asp:ListItem Value="12">22.00-23.00</asp:ListItem>
                </asp:DropDownList>
&nbsp;</td>
        </tr>
        <tr>
            <td></td>
            <td class="auto-style3">
                <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" /></td>

        </tr>
    </table>
    <br /><br />
    <h3>REZERVASYONLARIM</h3>

    <asp:GridView ID="gridrezervasyon" runat="server" BackColor="White" Width="100%" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" EnableModelValidation="True">
        
        
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
    </asp:GridView>

</asp:Content>


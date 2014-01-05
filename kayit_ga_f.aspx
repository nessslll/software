<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="kayit_ga_f.aspx.cs" Inherits="kayit_ga_f" %>

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
            <td><asp:Label ID="lblUyari" runat="server" Text=""></asp:Label></td>
        </tr>
       
        <tr>
            <td></td>
            <td class="auto-style3">
                <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" /></td>

        </tr>
    </table>



</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetim/AdminMain.master" AutoEventWireup="true" CodeFile="Rezervasyonlar.aspx.cs" Inherits="Yonetim_Rezervasyonlar" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">


    <h3>Rezervasyonlar</h3>
    <p>

        <asp:GridView ID="gridRezervasyon" runat="server" CellPadding="3" Width="100%" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" EnableModelValidation="True">
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle CssClass="GridRow" ForeColor="#000066" />
            <SelectedRowStyle CssClass="GridSelectedRow" BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle CssClass="GridHeader" BackColor="#006699" Font-Bold="True" ForeColor="White" />

        </asp:GridView>
    </p>
    <br />

    <h3>Ön Kayıtlar</h3>
    <p>

        <asp:GridView ID="gridRezervasyon1" runat="server" CellPadding="3" Width="100%" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" EnableModelValidation="True">
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle CssClass="GridRow" ForeColor="#000066" />
            <SelectedRowStyle CssClass="GridSelectedRow" BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle CssClass="GridHeader" BackColor="#006699" Font-Bold="True" ForeColor="White" />

        </asp:GridView>
    </p>




</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="duyurular.aspx.cs" Inherits="duyurular" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>
        <asp:Label ID="lblBaslik" runat="server" Text=""></asp:Label></h3>
    <asp:Literal ID="ltrIcerik" runat="server"></asp:Literal>

    <h4>TÜM DUYURULAR</h4>
    <ul>
        <asp:Repeater ID="repDuyuru" runat="server">
            <ItemTemplate>
                <li><a href="duyurular.aspx?id=<%#Eval("DUYURU_ID")%>"><%#Eval("DUYURU_BASLIGI")%></a></li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetim/AdminMain.master" AutoEventWireup="true" CodeFile="IcerikDuzenle.aspx.cs" Inherits="Yonetim_IcerikDuzenle" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">


    <h3>Menü Düzenleme</h3>
    <p>

        <asp:GridView ID="gridMenuler" runat="server" AutoGenerateColumns="False"
            CssClass="GridMain" CellPadding="4" GridLines="None" OnSelectedIndexChanged="gridMenuler_SelectedIndexChanged">
            <RowStyle CssClass="GridRow" />
            <SelectedRowStyle CssClass="GridSelectedRow" />
            <HeaderStyle CssClass="GridHeader" />
            <Columns>
                <asp:BoundField DataField="MENU_ID" HeaderText="MENU ID" />
                <asp:BoundField DataField="MENU_ADI" HeaderText="MENU ADI" />
                <asp:ButtonField CommandName="Select" Text="Seçiniz" />
             
            </Columns>
        </asp:GridView>
    </p>
    <asp:Label ID="Label2" runat="server" Text="Menu Adı"></asp:Label>
    <br />
    <asp:TextBox ID="TxtMenuAdi" CssClass="textbox" runat="server" placeholder="Menü Adı"></asp:TextBox>

    <asp:Button ID="btnKaydet" CssClass="buttonkaydet" runat="server" Text="Güncelle" OnClick="btnKaydet_Click" />
    <asp:Button ID="btnYeni" CssClass="buttonkaydet" runat="server" Text="EKLE" OnClick="btnYeni_Click"/>
    <asp:Button ID="btnSil" CssClass="buttonkaydet" runat="server" Text="Sil" OnClick="btnSil_Click" onclientclick="javascript:return confirm('Silmek İstediğinizden Emin misiniz?');" />
      

    <asp:Label ID="lblId" runat="server" Visible="False"></asp:Label>
    <asp:Label ID="lblHata" runat="server" ForeColor="#990000"></asp:Label>

    <br />
    <p>
        <CKEditor:CKEditorControl ID="CKDetay" runat="server" Height="500px"></CKEditor:CKEditorControl>
    </p>

</asp:Content>



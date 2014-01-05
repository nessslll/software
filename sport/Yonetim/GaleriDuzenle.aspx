<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetim/AdminMain.master" AutoEventWireup="true" CodeFile="GaleriDuzenle.aspx.cs" Inherits="Yonetim_GaleriDuzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <div id="data-table">
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" CssClass="buttonkaydet" Text="Kaydet" OnClick="Button1_Click" />
        <br />
        <table class="style1 datatable">
            <thead>
                <tr>

                    <th>Resim
                    </th>
                    <th>#
                    </th>
                    <th></th>
                    <th></th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater OnItemCommand="Repeater1_ItemCommand" ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Label Visible="false" ID="lblID" runat="server" Text='<%#Eval ("Id") %>'></asp:Label><%#Eval("Id") %>
                            </td>
                            <td>
                                <img src='<%# "../"+ Eval("Resim") %>' width="250px" height="150px" />
                            </td>
                            <td>
                                <asp:ImageButton ID="lnkSil" CssClass="icon16 fl-space2" CommandArgument="sil" CommandName="Repeater1_ItemCommand"
                                    ToolTip="Sil" runat="server" onclientclick="javascript:return confirm('Silmek İstediğinizden Emin misiniz?');" ImageUrl="delete.png" />
                            </td>
                            <td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>

</asp:Content>


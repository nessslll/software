<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="Galeri.aspx.cs" Inherits="Galeri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="gallery" class="one_half">
        <section>
            <figure>
                <h2>Galleri</h2>
                <ul class="clear">
                    <asp:repeater id="repGaleri" runat="server">
                <ItemTemplate>
                            <li class="one_half first"><a href="#"><img src="<%#Eval("Resim")%>" alt="" /></a> </li> 
                </ItemTemplate>
            </asp:repeater>
                </ul>
            </figure>
        </section>
        <!-- ####################################################################################################### -->

    </div>
</asp:Content>


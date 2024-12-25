<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="OgrenciListe.aspx.cs" Inherits="YazOkulu.OgrenciListe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <title></title>
    <style type="text/css">
        td {
           
        }
    </style>

    <div>
        <table class="table-bordered table table-hover" style="height: 217px">
            <tr>
                <th>Id</th>
                <th>Ad</th>
                <th>Soyad</th>
                <th>Numara</th>
                <th>Bakiye</th>
                <th>Fotoğraf</th>
                <th>Şifre</th>
                <th>Sil</th>
                <th>Güncelle</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("ID")%></td>
                            <td><%#Eval("AD")%></td>
                            <td><%#Eval("SOYAD")%></td>
                            <td><%#Eval("NUMARA")%></td>
                            <td><%#Eval("BAKIYE")%></td>
                            <td><%#Eval("FOTOGRAF")%></td>
                            <td><%#Eval("SIFRE")%></td>
                            <td><asp:HyperLink NavigateUrl='<%# "~/OgrenciSil.aspx?id=" + Eval("ID") %>' CssClass="btn btn-danger" ID="HyperLink1" runat="server">Sil</asp:HyperLink></td>
                            <td><asp:HyperLink NavigateUrl='<%# "~/OgrenciGuncelle.aspx?id=" + Eval("ID") %>' CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>

</asp:Content>

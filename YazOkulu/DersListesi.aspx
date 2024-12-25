<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="DersListesi.aspx.cs" Inherits="YazOkulu.DersListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="table table-bordered">
        <tr>
            <th>Ders Id</th>
            <th>Ders Adı</th>
            <th>Minimum Kontenjan</th>
            <th>Maksimum Kontenjan</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Id") %></td>
                        <td><%# Eval("DersAd") %></td>
                        <td><%# Eval("Min") %></td>
                        <td><%# Eval("Max") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>

</asp:Content>

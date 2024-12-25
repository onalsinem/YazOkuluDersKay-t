<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="YazOkulu.OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="form-group">
         <div>
            <asp:Label for="ID" runat="server" Text="Id:" style="font-weight: 700; font-size: large"></asp:Label>
            <asp:TextBox ID="ID" runat="server" CssClass="form-control"></asp:TextBox>
         </div>
        <div>
            <asp:Label for="txtad" runat="server" Text="Ad:" style="font-weight: 700; font-size: large"></asp:Label>
            <asp:TextBox ID="txtad" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="txtsoyad" runat="server" Text="Soyad:" style="font-weight: 700; font-size: large"></asp:Label>
            <asp:TextBox ID="txtsoyad" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="txtnumara" runat="server" Text="Numara:" style="font-size: large; font-weight: 700"></asp:Label>
            <asp:TextBox ID="txtnumara" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="txtsifre" runat="server" Text="Sifre:" style="font-size: large; font-weight: 700"></asp:Label>
            <asp:TextBox ID="txtsifre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br 
         <div>
            <asp:Label for="txtfotograf" runat="server" Text="Fotoğraf:" style="font-weight: 700; font-size: large"></asp:Label>
           <asp:TextBox ID="txtfotograf" runat="server" CssClass="form-control" ></asp:TextBox>
         </div>
        <br />
    </div>
   

    <asp:Button ID="Button2" runat="server" Text="Güncelle" Height="46px" cssClass="btn btn-warning" Width="138px" OnClick="Button2_Click" />
</asp:Content>


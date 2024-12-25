<%--<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="YazOkulu.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" Height="29px" OnClick="Button1_Click" />
    </form>
</body>
</html>--%>

<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="OgrenciKaydet.aspx.cs" Inherits="YazOkulu.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 
        <div class="form-group">
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
               <asp:TextBox ID="txtfotograf" runat="server" CssClass="form-control" OnTextChanged="txtfotograf_TextChanged"></asp:TextBox>
             </div>
            <br />
        </div>
   
    <asp:Button ID="Button1" runat="server" Text="Kaydet" Height="46px" cssClass="btn btn-info" OnClick="Button1_Click " Width="138px" />
</asp:Content>


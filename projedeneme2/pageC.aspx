<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pageC.aspx.cs" Inherits="projedeneme2.pageC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Yeni Kullanıcı Ekleme Sayfası<br />
            <br />
            AD:<asp:TextBox ID="TextBoxXX" runat="server"></asp:TextBox>
            <br />
            <br />
            ŞİFRE:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="AdminYetkileri" TextAlign="Left" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="44px" OnClick="buttonClick" Text="Button" Width="118px" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

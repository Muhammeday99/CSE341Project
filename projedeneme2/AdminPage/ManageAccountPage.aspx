<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageAccountPage.aspx.cs" Inherits="projedeneme2.AdminPage.ManageAccountPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Kullanıcı
            <asp:Label ID="nameLabel" runat="server" Text="nameLabel"></asp:Label>
&nbsp;düzenleme ekranı<br />
            <br />
            Yeni ad :
            <asp:TextBox ID="NewnameText" runat="server"></asp:TextBox>
            <br />
            <br />
            Yeni şifre:<asp:TextBox ID="NewpassText" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="applyChanges" runat="server" OnClick="applyChanges_Click" Text="Değişiklikleri Kaydet" />
            <br />
            <br />
            <asp:Label ID="errorLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>

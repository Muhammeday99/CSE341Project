<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAccount.aspx.cs" Inherits="projedeneme2.AdminPage.AddAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        Yeni kullanıcı ekleme sayfası<br />
        <br />
        email:<br />
        <asp:TextBox ID="emailBox" runat="server"></asp:TextBox>
        <br />
        <br />
        şifre:<br />
        <asp:TextBox ID="passwordBox" runat="server" AutoPostBack="True" OnTextChanged="passwordtext_Changed"></asp:TextBox>
        &nbsp;Şifre Gücü :
        <asp:Label ID="passwordLevelLabel" runat="server" Text="Yok"></asp:Label>
        <br />
        <br />
        foto:<br />
        <asp:FileUpload ID="photoUpload" runat="server" />
        <br />
        <br />
        Kişi Bilgileri:<br />
        <br />
        İsim:<br />
        <asp:TextBox ID="nameTextbox" runat="server" EnableTheming="True"></asp:TextBox>
        <br />
        Soyisim:<br />
        <asp:TextBox ID="surnameTextbox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" Height = "100" Width = "100" />
        <br />
        <asp:CheckBox ID="adminOrNot" runat="server" Text="Admin yetkileri" />
        <br />
        <br />
        <asp:Button ID="saveAccount" runat="server" OnClick="saveButtonClick" Text="Kaydet." />
        <br />
        <br />
        <asp:Label ID="errorLabel" runat="server" Text="."></asp:Label>
        <br />
        <br />
    </form>
</body>
</html>

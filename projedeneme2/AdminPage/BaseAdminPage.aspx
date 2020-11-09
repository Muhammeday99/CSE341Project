<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BaseAdminPage.aspx.cs" Inherits="projedeneme2.AdminPage.BaseAdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Admin Page<br />
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Button ID="newUserButton" runat="server" Height="40px" OnClick="newUserButton_Click" Text="Yeni Kullanıcı" Width="160px" />
            <br />
            <br />
            <asp:Button ID="listUserButton" runat="server" Height="40px" OnClick="listUserButton_Click" Text="Kullanıcıları Listele" Width="160px" PostBackUrl="~/pageb2.aspx" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pageA.aspx.cs" Inherits="projedeneme2.pageA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            USERNAME<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            PASSWORD<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="EKLE" OnClick="Button1_Click" />
            <asp:CheckBox ID="CheckBox1" runat="server" />
        </div>
    </form>
</body>
</html>

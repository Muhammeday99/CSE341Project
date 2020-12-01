<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBillInfo.aspx.cs" Inherits="projedeneme2.BillPage.AddBillInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        Add Bill Info<br />
        <br />
        BillNo:<br />
        <asp:TextBox ID="BillNoBox" runat="server"></asp:TextBox>
        <br />
        <br />
        BillDate:<br />
        <asp:TextBox ID="BillDateBox" runat="server"></asp:TextBox>
        <br />
        <br />
        entityCode:<br />
        <asp:Label ID="entity" runat="server"></asp:Label>
        <br />
        <br />
        BillDescription:<br />
        <asp:TextBox ID="BillDescriptionBox" runat="server"></asp:TextBox>
        <br />
        <br />
        PaymentDate:<br />
         <asp:TextBox ID="PaymentDateBox" runat="server"></asp:TextBox>
        <br />
        <br />
        KDV(%):<br />
         <asp:TextBox ID="KDVBox" runat="server"></asp:TextBox>
        <br />
        <br />
       Amount:<br />
         <asp:TextBox ID="AmountBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="saveAccount" runat="server" OnClick="saveButtonClick" Text="Kaydet." />
        <br />
        <br />
        <asp:Label ID="TotalamountTitle" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="TotalAmount" runat="server" Text=""></asp:Label>
        <br />
        <br />
        
    </form>
</body>
</html>
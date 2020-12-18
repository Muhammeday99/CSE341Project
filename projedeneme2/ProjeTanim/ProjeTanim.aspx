<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProjeTanim.aspx.cs" Inherits="projedeneme2.ProjeTanim.ProjeTanim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            PROJE TANIM:<br />
            <br />
            Proje Adı :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="projectName" runat="server"></asp:TextBox>
            <br />
            Proje Kodu:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="projectCode" runat="server"></asp:TextBox>
            <br />
            <br />
            Müşteri Kodu:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="clientCode" runat="server"></asp:TextBox>
            <br />
            Sipariş Kodu:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="orderCode" runat="server"></asp:TextBox>
            <br />
            Arge Fatura Numarası:<asp:TextBox ID="billCode" runat="server"></asp:TextBox>
            <br />
            <br />
            Başlangıç TarBaşlangıç Tarihi:<asp:TextBox runat="server" TextMode="Date" ID="startDate" ></asp:TextBox></asp:TextBox>
            <br />
            Bitiş Tarihi:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox runat="server" TextMode="Date" ID="finishDate" ></asp:TextBox>
            <br />
            <br />
            Döviz Kodu:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="exchangeCode" runat="server"></asp:TextBox>
            <br />
            Bedel:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="feeBox" runat="server"></asp:TextBox>
            <br />
            KDV:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="KDVbox" runat="server"></asp:TextBox>
            <br />
            İşçilik Ücreti:&nbsp;&nbsp;
            <asp:TextBox ID="workFee" runat="server"></asp:TextBox>
            <br />
            Toplam Tutar: <asp:Label ID="totalMoneyLabel" runat="server"></asp:Label>
            <br />
            <br />
            Proje Yetkilisi:<asp:TextBox ID="authorizedBox" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;<asp:Ch&nbsp;<asp:CheckBox ID="activeProject" runat="server" Text="Aktif Proje" TextAlign="Left" />
            <br />
            <br />
            <asp:Button ID="saveButton" runat="server" Text="Button" OnClick="saveButton_Click" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

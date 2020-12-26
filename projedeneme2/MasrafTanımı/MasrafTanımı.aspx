<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MasrafTanımı.aspx.cs" Inherits="projedeneme2.MasrafTanımı.MasrafTanımı" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID='ScriptManager1' runat='server' EnablePageMethods='true' />
        <div>
            <div class="table-responsive">
                <table class="table">
                    <thead>
                    </thead>
                    <tbody>
                        <tr>
                            <td style="width: 20%;">Masraf Kodu<br></td>
                            <td><asp:Textbox runat="server" id="ExpenseCode" placeholder="ExpenseCode" style="min-width: 100%;"></asp:Textbox></td>
                        </tr>
                        <tr>
                        <td>Masraf Adı<br></td>
                        <td><asp:Textbox runat="server" id="ExpenseName" placeholder="ExpenseName" style="min-width: 100%;"></asp:Textbox></td>
                        </tr>
                        <tr>
                            <td>Başlangıç Tarihi<br></td>
                            <td><asp:Textbox runat="server" TextMode="Date" id="ExpenseDate" name="ExpenseDate"></asp:Textbox></td>
                        </tr>
                                                        
                    </tbody>
                </table>
            </div>
        </div>
        <div>

            <asp:Button ID="SaveButton" runat="server" Text="Ekle" OnClick="SaveButton_Click" />

        </div>
        <div>

            <asp:Button ID="DeleteButton" runat="server" Text="Sil" OnClick="DeleteButton_Click" />

        </div>

    </form>
</body>
</html>

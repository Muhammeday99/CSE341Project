<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAccountList.aspx.cs" Inherits="projedeneme2.AdminPage.ShowAccountList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="pageb" runat ="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField ="ID" HeaderText ="ID" />
                    <asp:BoundField DataField ="Name" HeaderText ="First Name" />
                    <asp:BoundField DataField ="Email" HeaderText ="Email" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkSelect" Text ="Update" runat="server" CommandArgument='<k%# Eval("ID") %>' OnClick="lnkSelect_Click" />

                        </ItemTemplate>

                    </asp:TemplateField>

                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
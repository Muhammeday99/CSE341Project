<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAndUpdateCompanyInfo.aspx.cs" Inherits="projedeneme2.CompanyPage.ShowAndUpdateCompanyInfo" %>

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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="6" OnRowCancelingEdit="GridView1_RowCancelingEdit"   
  
OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">  
            <Columns>  
                <asp:TemplateField>  
                    <ItemTemplate>  
                        <asp:Button ID="editButton" runat="server" Text="Edit" CommandName="Edit" />  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:Button ID="updateButton" runat="server" Text="Update" CommandName="Update"/>  
                        <asp:Button ID="cancelButton" runat="server" Text="Cancel" CommandName="Cancel"/>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Name">  
                    <ItemTemplate>  
                        <asp:Label ID="nameLabel" runat="server" Text='<%#Eval("Name") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="nameTextBox" runat="server" Text='<%#Eval("Name") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="SiteURL">  
                    <ItemTemplate>  
                        <asp:Label ID="URLLabel" runat="server" Text='<%#Eval("SiteURL") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="urlTextBox" runat="server" Text='<%#Eval("SiteURL") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="PhoneContryCode">  
                    <ItemTemplate>  
                        <asp:Label ID="phoneCodeLabel" runat="server" Text='<%#Eval("PhoneContryCode") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="phoneCodeTextBox" runat="server" Text='<%#Eval("PhoneContryCode") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="PhoneNumber">  
                    <ItemTemplate>  
                        <asp:Label ID="phoneNumberLabel" runat="server" Text='<%#Eval("PhoneNumber") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="phoneNumberTextBox" runat="server" Text='<%#Eval("PhoneNumber") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="IBAN">  
                    <ItemTemplate>  
                        <asp:Label ID="ibanLabel" runat="server" Text='<%#Eval("IBAN") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="ibanTextBox" runat="server" Text='<%#Eval("IBAN") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Company_Description">  
                    <ItemTemplate>  
                        <asp:Label ID="descriptionLabel" runat="server" Text='<%#Eval("Company_Description") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="descriptionTextBox" runat="server" Text='<%#Eval("Company_Description") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Tax_Admin">  
                    <ItemTemplate>  
                        <asp:Label ID="taxAdminLabel" runat="server" Text='<%#Eval("Tax_Admin") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="taxAdminTextBox" runat="server" Text='<%#Eval("Tax_Admin") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Tax_number">  
                    <ItemTemplate>  
                        <asp:Label ID="taxNumberLabel" runat="server" Text='<%#Eval("Tax_number") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="taxNumberText" runat="server" Text='<%#Eval("Tax_number") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>
            </Columns>  
            <HeaderStyle BackColor="#663300" ForeColor="#ffffff"/>  
            <RowStyle BackColor="#e7ceb6"/>  
        </asp:GridView>  
      
    </div>  
</form>  
</body>
</html>

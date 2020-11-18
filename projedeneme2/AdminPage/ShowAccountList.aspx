<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAccountList.aspx.cs" Inherits="projedeneme2.AdminPage.ShowAccountList" %>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">  
    <div>      
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="6" OnRowCancelingEdit="GridView1_RowCancelingEdit" 
  
OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" BackColor="#000066">  
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
                <asp:TemplateField HeaderText="UserID">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_ID" runat="server" Text='<%#Eval("UserID") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Password">  
                    <ItemTemplate>  
                        <asp:Label ID="passwordLabel" runat="server" Text='<%#Eval("Password") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="passwordTextBox" runat="server" Text='<%#Eval("Password") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="ProfilePicture">  
                    <ItemTemplate>  
                        <asp:Label ID="ProfileFotoLabel" runat="server" Text='<%#Eval("ProfilePicture") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="ProfileFotoTextBox" runat="server" Text='<%#Eval("ProfilePicture") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="UserEmail">  
                    <ItemTemplate>  
                        <asp:Label ID="useremailLabel" runat="server" Text='<%#Eval("UserEmail") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="useremailTextBox" runat="server" Text='<%#Eval("UserEmail") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Status">
                    <ItemTemplate>
                        <asp:CheckBox ID="status" runat="server" Checked='<%# Eval("Status") %>'></asp:CheckBox>
                    </ItemTemplate>
                </asp:TemplateField>

                
            </Columns>  
            <HeaderStyle BackColor="#663300" ForeColor="#ffffff"/>  
            <RowStyle BackColor="#e7ceb6"/>  
        </asp:GridView>  
      
    </div>  
</form>  
</body>
</html>

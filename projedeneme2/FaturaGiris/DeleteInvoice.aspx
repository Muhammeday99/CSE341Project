<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteInvoice.aspx.cs" Inherits="projedeneme2.FaturaGiris.DeleteInvoice" %>

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
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="InvoiceNumber" AutoGenerateColumns="False" CellPadding="6" OnRowCancelingEdit="GridView1_RowCancelingEdit" 
   OnRowDeleting="GridView1_RowDeleting" EmptyDataText="No records has been added." BackColor="#000066"> 
            <Columns>  
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="deleteButton" runat="server" CommandName="Delete" Text="Delete" OnClientClick="return confirm('Are you sure you want to delete?');"/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Invoice Number">  
                    <ItemTemplate>  
                        <asp:Label ID="InvoiceNumber" runat="server" Text='<%#Eval("InvoiceNumber") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Invoice Date">  
                    <ItemTemplate>  
                        <asp:Label ID="InvoiceDateLabel" runat="server" Text='<%#Eval("InvoiceDate") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="InvoiceDateText" runat="server" Text='<%#Eval("InvoiceDate") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="EntityCode">  
                    <ItemTemplate>  
                        <asp:Label ID="entityCodeLabel" runat="server" Text='<%#Eval("entityCode") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="entityCodeText" runat="server" Text='<%#Eval("entityCode") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="Invoice Description">  
                    <ItemTemplate>  
                        <asp:Label ID="InvoiceDescriptionLabel" runat="server" Text='<%#Eval("InvoiceDescription") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="InvoiceDescriptionText" runat="server" Text='<%#Eval("InvoiceDescription") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>
                <asp:TemplateField HeaderText="PaymentDate">  
                    <ItemTemplate>  
                        <asp:Label ID="PaymentDateLabel" runat="server" Text='<%#Eval("PaymentDate") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="PaymentDateText" runat="server" Text='<%#Eval("PaymentDate") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="CurrencyCode">  
                    <ItemTemplate>  
                        <asp:Label ID="CurrencyCodeLabel" runat="server" Text='<%#Eval("CurrencyCode") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="CurrencyCodeTextBox" runat="server" Text='<%#Eval("CurrencyCode") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Amount">  
                    <ItemTemplate>  
                        <asp:Label ID="AmountLabel" runat="server" Text='<%#Eval("Amount") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="AmountTextBox" runat="server" Text='<%#Eval("Amount") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="KDVpercentage">  
                    <ItemTemplate>  
                        <asp:Label ID="KDVpercentageLabel" runat="server" Text='<%#Eval("KDVpercentage") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="KDVpercentageTextBox" runat="server" Text='<%#Eval("KDVpercentage") %>'></asp:TextBox>  
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

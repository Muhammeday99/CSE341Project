<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAndUpdateCompanyInfo.aspx.cs" Inherits="projedeneme2.CompanyPage.ShowAndUpdateCompanyInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">  
        <title>Untitled Page</title>  
        <style type="text/css">  
            .Gridview {  
                font-family: Verdana;  
                font-size: 10pt;  
                font-weight: normal;  
                color: black;  
            }  
        </style>  
        <script type="text/javascript">  
        </script>  
    </head>  
  
    <body>  
        <form id="form1" runat="server">  
            <div>  
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="Name" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">  
                    <Columns>  
                        <asp:BoundField DataField="Name" HeaderText="Name" />  
                        <asp:BoundField DataField="SiteURL" HeaderText="SiteURL" />  
                        <asp:BoundField DataField="PhoneContryCode" HeaderText="PhoneContryCode" />  
                        <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" />  
                        <asp:BoundField DataField="IBAN" HeaderText="IBAN" />  
                        <asp:BoundField DataField="Company_Description" HeaderText="Company_Description" />  
                        <asp:BoundField DataField="Tax_Admin" HeaderText="Tax_Admin" />  
                        <asp:BoundField DataField="Tax_number" HeaderText="Tax_number" />  
                        <asp:CommandField ShowEditButton="true" />  
                        <asp:CommandField ShowDeleteButton="true" /> </Columns>  
                </asp:GridView>  
            </div>  
            <div>  
                <asp:Label ID="lblresult" runat="server"></asp:Label>  
            </div>  
        </form>  
    </body>  
  
    </html>  

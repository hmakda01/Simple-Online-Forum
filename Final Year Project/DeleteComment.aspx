<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteComment.aspx.cs" Inherits="Final_Year_Project.DeleteComment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: lightgrey">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 212px; top: 110px; position: absolute; height: 63px; width: 302px;" Text="Are you sure you want to delete this?" Font-Size="X-Large"></asp:Label>
        <asp:Button ID="btnYES" runat="server" OnClick="btnYES_Click" style="z-index: 1; left: 221px; top: 194px; position: absolute; height: 30px; width: 70px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 374px; top: 194px; position: absolute; height: 30px; width: 70px" Text="No" OnClick="btnNo_Click"  />
    </form>
  
</body></html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteHealthSpecialist.aspx.cs" Inherits="Final_Year_Project.DeleteHealthSpecialist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: lightgrey">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 105px; top: 73px; position: absolute" Text="Are you sure you want to delete this?"></asp:Label>
        <asp:Button ID="btnYES" runat="server" style="z-index: 1; left: 134px; top: 118px; position: absolute; height: 26px; width: 70px" Text="Yes" OnClick="btnYES_Click" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 254px; top: 118px; position: absolute; width: 70px" Text="No" OnClick="btnNo_Click"  />
  
    </form>
</body>
</html>

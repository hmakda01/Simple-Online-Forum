<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Final_Year_Project.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: lightgrey">
    <form id="form1" runat="server">
        <div>
        </div>
    <p>    
        <asp:Label ID="L" runat="server" Font-Bold="True" Font-Size="32pt" style="z-index: 1; left: 11px; top: 17px; position: absolute; height: 57px; width: 1140px" Text="COVID CONVERSATIONS" BackColor="#33CCFF" ForeColor="Black"></asp:Label>
        </p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 155px; top: 166px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 156px; top: 215px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 252px; top: 167px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 251px; top: 214px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 80px; top: 278px; position: absolute"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 348px; top: 258px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 251px; top: 260px; position: absolute" Text="Cancel" />
    </form>
    </body>
</html>

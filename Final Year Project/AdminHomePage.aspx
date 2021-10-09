<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="Final_Year_Project.AdminHomePage" %>

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
           
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="32pt" style="z-index: 1; left: 14px; top: 18px; position: absolute; height: 57px; width: 1140px" Text="COVID CONVERSATIONS" BackColor="#33CCFF" ForeColor="Black"></asp:Label>
        </p>
         <asp:Button ID="btnAdminUser" runat="server" BackColor="Blue" ForeColor="White" style="z-index: 1; left: 230px; top: 169px; position: absolute; height: 70px; width: 214px; right: 521px;" Text="User" OnClick="btnAdminUser_Click"  />
        <asp:Button ID="btnAdminForum" runat="server" BackColor="Blue" ForeColor="White" style="z-index: 1; left: 230px; top: 315px; position: absolute; height: 70px; width: 214px; right: 521px;" Text="Forums" OnClick="btnAdminForum_Click" />
        <asp:Button ID="btnAdmin" runat="server" BackColor="Blue" ForeColor="White" style="z-index: 1; left: 570px; top: 169px; position: absolute; height: 70px; width: 214px;" Text="Admin" OnClick="btnAdmin_Click" />
        <asp:Button ID="btnHealth" runat="server" BackColor="Blue" ForeColor="White" style="z-index: 1; left: 570px; top: 315px; position: absolute; height: 70px; width: 214px;" Text="Health Specialist" OnClick="btnHealth_Click" />
        <asp:Button ID="Button1" runat="server" BackColor="Gray" style="z-index: 1; left: 738px; top: 33px; position: absolute; height: 27px; width: 131px" Text="Log Out" OnClick="Button1_Click" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 412px; top: 105px; position: absolute" Text="Admin Home Page" BackColor="#66CCFF" Font-Size="X-Large"></asp:Label>
   
    </form>
</body>
</html>

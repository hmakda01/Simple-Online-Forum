<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForumPage.aspx.cs" Inherits="Final_Year_Project.ForumPage" %>

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
       <asp:TextBox ID="txtEmail" runat="server" BackColor="LightGray" style="z-index: 1; left: 592px; top: 41px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" BackColor="LightGray" style="z-index: 1; left: 788px; top: 41px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" BackColor="DarkGray" ForeColor="Black" style="z-index: 1; left: 972px; top: 36px; position: absolute; height: 26px; width: 73px;" Text="Login" />
        <asp:Button ID="btnRegister" runat="server" BackColor="DarkGray" ForeColor="Black" style="z-index: 1; left: 1068px; top: 37px; position: absolute; height: 26px;" Text="Register" OnClick="btnRegister_Click" />
       <asp:Label ID="Label2" runat="server" BackColor="#33CCFF" Font-Names="Calibri" Font-Size="X-Large" ForeColor="White" style="z-index: 1; left: 367px; top: 99px; position: absolute; height: 35px; width: 546px" Text="Forums"></asp:Label>
        <asp:Button ID="btnAddPost" runat="server" BackColor="Gray" Font-Names="Calibri" ForeColor="White" style="z-index: 1; left: 534px; top: 155px; position: absolute; height: 29px; width: 173px" Text="Add new Post" Font-Size="Large" OnClick="btnAddPost_Click" />
        <asp:ListBox ID="lstPostss" runat="server" style="z-index: 1; left: 270px; top: 201px; position: absolute; height: 274px; width: 743px"></asp:ListBox>
 
        <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" style="z-index: 1; left: 586px; top: 489px; position: absolute" Text="View Posts" BackColor="#999999" Font-Size="Large" ForeColor="White" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 86px; top: 322px; position: absolute"></asp:Label>
 
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserForumPage.aspx.cs" Inherits="Final_Year_Project.UserForumPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: lightgrey">
    <form id="form1" runat="server">
        <div>
        </div>
        <div>
        </div>
         <p>
           <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="32pt" style="z-index: 1; left: 14px; top: 18px; position: absolute; height: 57px; width: 1140px" Text="COVID CONVERSATIONS" BackColor="#33CCFF" ForeColor="Black"></asp:Label>
        </p>
        <asp:Button ID="btnLogOut" runat="server" BackColor="DarkGray" ForeColor="Black" style="z-index: 1; left: 924px; top: 37px; position: absolute" Text="LogOut" OnClick="btnLogOut_Click"  />
        <asp:Button ID="btnPersonalDetails" runat="server" BackColor="DarkGray" ForeColor="Black" style="z-index: 1; left: 1008px; top: 38px; position: absolute" Text="Personal Details" OnClick="btnPersonalDetails_Click" />
         <asp:Button ID="btnForum" runat="server" BackColor="Red" ForeColor="White" style="z-index: 1; left: 482px; top: 118px; position: absolute; height: 30px; width: 170px" Text="Forum" />
        <asp:Button ID="btnPost" runat="server" BackColor="Blue" ForeColor="White" style="z-index: 1; left: 655px; top: 118px; position: absolute; height: 30px; width: 170px;" Text="Help and Guidance" OnClick="btnPost_Click" />
        <asp:Button ID="btnPopular" runat="server" BackColor="Blue" ForeColor="White" style="z-index: 1; left: 309px; top: 117px; position: absolute; height: 30px; width: 170px; " Text="Home" OnClick="btnPopular_Click"  />
       
        <asp:Button ID="btnAddPost" runat="server" BackColor="Gray" Font-Names="Calibri" ForeColor="White" style="z-index: 1; left: 519px; top: 166px; position: absolute; height: 29px; width: 173px; right: 498px;" Text="Add new Post" Font-Size="Large" OnClick="btnAddPost_Click" />
        <asp:ListBox ID="lstPostss" runat="server" style="z-index: 1; left: 270px; top: 201px; position: absolute; height: 274px; width: 743px"></asp:ListBox>
 
        <asp:Button ID="btnView" runat="server" style="z-index: 1; left: 578px; top: 486px; position: absolute" Text="View Posts" OnClick="btnView_Click" BackColor="Gray" Font-Size="Large" ForeColor="White" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 86px; top: 322px; position: absolute" ForeColor="Red"></asp:Label>
 
    </form>
</body>
</html>

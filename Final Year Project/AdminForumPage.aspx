<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminForumPage.aspx.cs" Inherits="Final_Year_Project.AdminForumPage" %>

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
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="32pt" Style="z-index: 1; left: 14px; top: 18px; position: absolute; height: 57px; width: 1140px" Text="COVID CONVERSATIONS" BackColor="#33CCFF" ForeColor="Black"></asp:Label>
        </p>
        <asp:Button ID="btnLogOut" runat="server" BackColor="DarkGray" ForeColor="Black" Style="z-index: 1; left: 924px; top: 37px; position: absolute" Text="LogOut" OnClick="btnLogOut_Click" />
        <asp:Button ID="btnPersonalDetails" runat="server" BackColor="DarkGray" ForeColor="Black" Style="z-index: 1; left: 1008px; top: 38px; position: absolute" Text="Personal Details" />
        <asp:Label ID="Label2" runat="server" BackColor="Gray" Font-Names="Calibri" Font-Size="Larger" ForeColor="White" Style="z-index: 1; left: 382px; top: 106px; position: absolute; height: 26px; width: 531px" Text="Forums"></asp:Label>
        <asp:ListBox ID="lstPosts" runat="server" Style="z-index: 1; left: 274px; top: 144px; position: absolute; height: 229px; width: 703px"></asp:ListBox>

        <asp:Button ID="btnEdit" runat="server" Style="z-index: 1; left: 379px; top: 419px; position: absolute; height: 33px; width: 132px" Text="Edit" OnClick="btnEdit_Click" />

        <asp:Button ID="btnDelete" runat="server" Style="z-index: 1; left: 740px; top: 419px; position: absolute; height: 33px; width: 132px" Text="Delete" OnClick="btnDelete_Click" />


        <asp:Label ID="lblError" runat="server" Style="z-index: 1; left: 893px; top: 422px; position: absolute" ForeColor="#FF3300"></asp:Label>

        <asp:Button ID="Button1" runat="server" BackColor="#999999" Style="z-index: 1; left: 56px; top: 163px; position: absolute" Text="Go Back" OnClick="Button1_Click" />
    </form>
</body>
</html>

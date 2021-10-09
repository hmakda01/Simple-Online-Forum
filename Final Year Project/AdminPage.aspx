<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Final_Year_Project.AdminPage1" %>

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
        <asp:Label ID="Label2" runat="server" BackColor="Gray" Font-Names="Calibri" Font-Size="Larger" ForeColor="White" Style="z-index: 1; left: 382px; top: 106px; position: absolute; height: 26px; width: 531px" Text="Admins"></asp:Label>
        <asp:ListBox ID="lstAdmins" runat="server" Style="z-index: 1; left: 281px; top: 178px; position: absolute; height: 229px; width: 703px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" BackColor="Silver" ForeColor="White" Style="z-index: 1; left: 330px; top: 450px; position: absolute; height: 30px; width: 170px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" BackColor="Silver" ForeColor="White" Style="z-index: 1; left: 500px; top: 450px; position: absolute; height: 30px; width: 170px;" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" BackColor="Silver" ForeColor="White" Style="z-index: 1; left: 669px; top: 450px; position: absolute; height: 30px; width: 170px;" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="Button1" runat="server" BackColor="#999999" Style="z-index: 1; left: 56px; top: 163px; position: absolute" Text="Go Back" OnClick="Button1_Click" />
        <asp:Label ID="lblError" runat="server" Style="z-index: 1; left: 893px; top: 422px; position: absolute"></asp:Label>


        <p>
            &nbsp;
        </p>


    </form>
</body>
</html>

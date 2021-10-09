<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHealthSpecPage.aspx.cs" Inherits="Final_Year_Project.AdminHealthSpecPage" %>

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
            <asp:Label ID="L" runat="server" Font-Bold="True" Font-Size="32pt" Style="z-index: 1; left: 11px; top: 17px; position: absolute; height: 57px; width: 1140px" Text="COVID CONVERSATIONS" BackColor="#33CCFF" ForeColor="Black"></asp:Label>
        </p>

        <asp:Label ID="Lk" runat="server" BackColor="#9BBCFF" Style="z-index: 1; left: 183px; top: 156px; position: absolute; height: 327px; width: 792px"></asp:Label>
        <asp:Label ID="Label2" runat="server" Style="z-index: 1; left: 191px; top: 106px; position: absolute; height: 36px; width: 607px;" Text="Admin Health Spec Page" Font-Names="Calibri" Font-Size="XX-Large" BackColor="Silver" ForeColor="White"></asp:Label>
        <asp:ListBox ID="lstHealthSpecialist" runat="server" Style="z-index: 1; left: 448px; top: 203px; position: absolute; height: 200px; width: 288px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" BackColor="Silver" ForeColor="White" Style="z-index: 1; left: 330px; top: 450px; position: absolute; height: 30px; width: 170px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" BackColor="Silver" ForeColor="White" Style="z-index: 1; left: 500px; top: 450px; position: absolute; height: 30px; width: 170px;" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" BackColor="Silver" ForeColor="White" Style="z-index: 1; left: 669px; top: 450px; position: absolute; height: 30px; width: 170px;" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="Button1" runat="server" BackColor="#999999" Style="z-index: 1; left: 56px; top: 163px; position: absolute" Text="Go Back" OnClick="Button1_Click1" />
        <asp:Label ID="lblError" runat="server" Style="z-index: 1; left: 266px; top: 413px; position: absolute" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>

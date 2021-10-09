<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HealthSpecPage.aspx.cs" Inherits="Final_Year_Project.HealthForum" %>

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
        <asp:Button ID="btnLogOut" runat="server" BackColor="DarkGray" ForeColor="Black" style="z-index: 1; left: 924px; top: 38px; position: absolute" Text="LogOut" OnClick="btnLogOut_Click"  />
        <asp:Button ID="btnPersonalDetails" runat="server" BackColor="DarkGray" ForeColor="Black" style="z-index: 1; left: 1008px; top: 38px; position: absolute" Text="Personal Details" OnClick="btnPersonalDetails_Click"  />
        <asp:Label ID="Label2" runat="server" BackColor="#33CCCC" Font-Names="Calibri" Font-Size="XX-Large" ForeColor="Black" style="z-index: 1; left: 327px; top: 104px; position: absolute; height: 42px; width: 555px" Text="     Health Specialist Page"></asp:Label>
        <asp:ListBox ID="lstPostss" runat="server" style="z-index: 1; left: 175px; top: 170px; position: absolute; height: 274px; width: 399px" BackColor="#CCCCCC"></asp:ListBox>
 
        <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" style="z-index: 1; left: 280px; top: 467px; position: absolute; height: 32px; width: 94px;" Text="View Posts" BackColor="Gray" Font-Names="Calibri" Font-Size="Large" ForeColor="#FFFFCC" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 429px; top: 533px; position: absolute; height: 28px; width: 123px;" ForeColor="Red"></asp:Label>
 
        <asp:Button ID="btnAddComment" runat="server" style="z-index: 1; left: 604px; top: 465px; position: absolute; height: 34px; width: 100px; right: 269px;" Text="Add Comment" BackColor="Gray" Font-Names="Calibri" Font-Size="Small" ForeColor="#FFFFCC" OnClick="btnComment_Click1" />
 
        <asp:ListBox ID="lstComments" runat="server" style="z-index: 1; left: 611px; top: 170px; position: absolute; height: 274px; width: 399px" BackColor="#CCCCCC"></asp:ListBox>
 
        <asp:Button ID="btnEditComment" runat="server" style="z-index: 1; left: 722px; top: 465px; position: absolute; height: 34px; width: 100px; right: 343px;" Text="Edit Comment" BackColor="Gray" Font-Names="Calibri" Font-Size="Small" ForeColor="#FFFFCC" OnClick="btnEditComment_Click" />
        <asp:Button ID="btnDeleteComment" runat="server" style="z-index: 1; left: 843px; top: 465px; position: absolute; height: 34px; width: 100px" Text="Delete Comment" BackColor="Gray" Font-Names="Calibri" Font-Size="Small" ForeColor="#FFFFCC" OnClick="btnDeleteComment_Click" />
 
        <asp:Button ID="btnViewComments" runat="server" style="z-index: 1; left: 1023px; top: 411px; position: absolute" Text="View Comments" BackColor="Gray" Font-Names="Calibri" Font-Size="Large" ForeColor="#FFFFCC" OnClick="Button1_Click" />
 
    </form>
</body>
</html>

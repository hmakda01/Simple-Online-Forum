<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewComment.aspx.cs" Inherits="Final_Year_Project.ViewComment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body  style="background-color: lightgrey">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
           <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="32pt" style="z-index: 1; left: 14px; top: 18px; position: absolute; height: 57px; width: 1140px" Text="COVID CONVERSATIONS" BackColor="#33CCFF" ForeColor="Black"></asp:Label>
        </p>
        <asp:Button ID="btnLogOut" runat="server" BackColor="DarkGray" ForeColor="Black" style="z-index: 1; left: 924px; top: 38px; position: absolute" Text="LogOut" OnClick="btnLogOut_Click"  />
        <asp:Button ID="btnPersonalDetails" runat="server" BackColor="DarkGray" ForeColor="Black" style="z-index: 1; left: 1008px; top: 38px; position: absolute" Text="Personal Details" OnClick="btnPersonalDetails_Click"  />
        <asp:TextBox ID="txtCommentDescription" runat="server" style="z-index: 1; left: 426px; top: 151px; position: absolute; height: 122px; width: 384px" ReadOnly="True" Rows="4" TextMode="MultiLine"></asp:TextBox>
        <asp:TextBox ID="txtCommentDate" runat="server" style="z-index: 1; left: 428px; top: 299px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label12" runat="server" style="z-index: 1; left: 308px; top: 150px; position: absolute" Text="Comment"></asp:Label>
        <asp:Label ID="Label13" runat="server" style="z-index: 1; left: 338px; top: 297px; position: absolute; height: 23px; width: 46px;" Text="Date"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 341px; top: 494px; position: absolute"></asp:Label>
        <asp:Button ID="btnGoBack" runat="server" style="z-index: 1; left: 41px; top: 103px; position: absolute; height: 29px; width: 145px;" Text="Go Back" BackColor="Gray" ForeColor="#FFFFCC" OnClick="btnGoBack_Click" />
        <asp:Label ID="Label14" runat="server" BackColor="#FFCC00" Font-Names="Calibri" Font-Size="XX-Large" ForeColor="Black" style="z-index: 1; left: 432px; top: 90px; position: absolute; height: 40px; width: 384px" Text="View Comment"></asp:Label>
        
    </form>
</body>
</html>

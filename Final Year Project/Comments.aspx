<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comments.aspx.cs" Inherits="Final_Year_Project.Comments" %>

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
        <asp:Button ID="btnLogOut" runat="server" BackColor="DarkGray" ForeColor="Black" style="z-index: 1; left: 924px; top: 38px; position: absolute" Text="LogOut"  />
        <asp:Button ID="btnPersonalDetails" runat="server" BackColor="DarkGray" ForeColor="Black" style="z-index: 1; left: 1008px; top: 38px; position: absolute" Text="Personal Details" OnClick="btnPersonalDetails_Click"  />
        <asp:TextBox ID="txtCommentDescription" runat="server" style="z-index: 1; left: 426px; top: 131px; position: absolute; height: 110px; width: 419px" Columns="4" Rows="4" TextMode="MultiLine"></asp:TextBox>
        <asp:TextBox ID="txtCommentDate" runat="server" style="z-index: 1; left: 428px; top: 267px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label12" runat="server" style="z-index: 1; left: 308px; top: 136px; position: absolute" Text="Comment"></asp:Label>
        <asp:Label ID="Label13" runat="server" style="z-index: 1; left: 338px; top: 266px; position: absolute; height: 23px; width: 46px;" Text="Date"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 341px; top: 494px; position: absolute"></asp:Label>
        <asp:Button ID="btnGoBack" runat="server" style="z-index: 1; left: 41px; top: 103px; position: absolute; height: 29px; width: 145px;" Text="Go Back" BackColor="Gray" ForeColor="#FFFFCC" OnClick="btnGoBack_Click1" />

        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 609px; top: 320px; position: absolute; height: 27px; width: 117px;" Text="Add" BackColor="Lime" Font-Names="Calibri" Font-Size="Large" ForeColor="Black" />

    </form>
</body>
</html>

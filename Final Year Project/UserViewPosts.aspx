<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserViewPosts.aspx.cs" Inherits="Final_Year_Project.UserViewPosts" %>

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
        <asp:Button ID="btnPersonalDetails" runat="server" BackColor="DarkGray" ForeColor="Black" style="z-index: 1; left: 1008px; top: 38px; position: absolute" Text="Personal Details" OnClick="btnPersonalDetails_Click" />
        <asp:Label ID="Label2" runat="server" BackColor="Gray" Font-Names="Calibri" Font-Size="X-Large" ForeColor="White" style="z-index: 1; left: 360px; top: 101px; position: absolute; height: 35px; width: 553px" Text="View Posts"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 220px; top: 229px; position: absolute" Text="Thread Title:"></asp:Label>
        <asp:Label runat="server" BackColor="#99CCFF" style="z-index: 1; left: 200px; top: 152px; position: absolute; height: 266px; width: 795px"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 220px; top: 213px; position: absolute" Text="Forum Title:"></asp:Label>
        <asp:TextBox ID="txtForumTitle" runat="server" style="z-index: 1; left: 350px; top: 213px; position: absolute; height: 18px; width: 628px" BackColor="White"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 220px; top: 257px; position: absolute" Text="Description:"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 350px; top: 263px; position: absolute; height: 107px; width: 628px" BackColor="White" Rows="3" TextMode="MultiLine"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 227px; top: 384px; position: absolute" Text="Post Date:"></asp:Label>
        <asp:TextBox ID="txtPostDate" runat="server" style="z-index: 1; left: 354px; top: 389px; position: absolute"></asp:TextBox>

        <asp:Button ID="btnGoBack" runat="server" OnClick="btnGoBack_Click" style="z-index: 1; left: 47px; top: 152px; position: absolute" Text="Go Back" BackColor="#999999" Font-Size="Large" />
        <asp:Button ID="btnResponse" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 846px; top: 431px; position: absolute; height: 33px; width: 147px;" Text="View Responses" BackColor="#CCFFCC" Font-Names="Calibri" Font-Size="Medium" ForeColor="Black" />

    </form>
</body>
</html>

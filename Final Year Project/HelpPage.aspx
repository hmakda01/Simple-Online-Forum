<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelpPage.aspx.cs" Inherits="Final_Year_Project.HelpPage" %>

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
         <asp:Button ID="btnForum" runat="server" BackColor="Blue" ForeColor="White" style="z-index: 1; left: 653px; top: 118px; position: absolute; height: 30px; width: 170px; right: 367px;" Text="Forum" OnClick="btnForum_Click" />
        <asp:Button ID="btnPost" runat="server" BackColor="Red" ForeColor="White" style="z-index: 1; left: 481px; top: 118px; position: absolute; height: 30px; width: 170px;" Text="Help and Guidance"/>
        <asp:Button ID="btnPopular" runat="server" BackColor="Blue" ForeColor="White" style="z-index: 1; left: 309px; top: 117px; position: absolute; height: 30px; width: 170px; right: 711px;" Text="Home" OnClick="btnPopular_Click" />
       
        <asp:ListBox ID="lstComments" runat="server" style="z-index: 1; left: 194px; top: 182px; position: absolute; height: 354px; width: 823px" BackColor="#999999" Font-Bold="True" Font-Names="Calibri" Font-Size="X-Large" ForeColor="#FFFFCC" SelectionMode="Multiple"></asp:ListBox>
 
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 86px; top: 322px; position: absolute"></asp:Label>
 
      
 
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 40px; top: 492px; position: absolute" Text="View Comment" />
 
      
 
    </form>
</body>
</html>

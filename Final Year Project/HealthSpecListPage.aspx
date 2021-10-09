<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HealthSpecListPage.aspx.cs" Inherits="Final_Year_Project.HealthSpecListPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" rel="" />
    <title></title>
</head>
<body style="background-color: lightgrey">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>    
        <asp:Label ID="L" runat="server" Font-Bold="True" Font-Size="32pt" style="z-index: 1; left: 11px; top: 17px; position: absolute; height: 57px; width: 1140px" Text="COVID CONVERSATIONS" BackColor="#33CCFF" ForeColor="Black"></asp:Label>
        </p>
         <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 103px; top: 306px; position: absolute"></asp:Label>
         
         
         
         <asp:Label ID="Lk" runat="server" BackColor="#66FFFF" style="z-index: 1; left: 183px; top: 156px; position: absolute; height: 327px; width: 792px"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 191px; top: 106px; position: absolute; height: 36px; width: 607px;" Text="Health Specialist Page" Font-Names="Calibri" Font-Size="XX-Large" BackColor="Silver" ForeColor="White"></asp:Label>
        <asp:Button ID="btnSearch" runat="server" style="z-index: 1; left: 538px; top: 410px; position: absolute" Text=" Search " OnClick="btnSearch_Click" />
        <asp:TextBox ID="txtEmailFilter" runat="server" style="z-index: 1; left: 496px; top: 171px; position: absolute; right: 489px; height: 18px;" TextMode="Search">Enter Email</asp:TextBox>
       <asp:ListBox ID="lstHealthSpecialist" runat="server" style="z-index: 1; left: 448px; top: 203px; position: absolute; height: 200px; width: 288px" BackColor="#CCCCCC"></asp:ListBox>
        <asp:Button ID="btnEdit" runat="server" BackColor="Silver" ForeColor="White" style="z-index: 1; left: 389px; top: 442px; position: absolute; height: 30px; width: 170px;" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" BackColor="Silver" ForeColor="White" style="z-index: 1; left: 627px; top: 442px; position: absolute; height: 30px; width: 170px;" Text="Delete" OnClick="btnDelete_Click" />
  
   
    </form>
</body>
</html>

﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminCreateNewAccount.aspx.cs" Inherits="Final_Year_Project.AdminCreateNewAccount" %>

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
        <asp:Label ID="L" runat="server" Font-Bold="True" Font-Size="32pt" style="z-index: 1; left: 11px; top: 17px; position: absolute; height: 57px; width: 1140px" Text="COVID CONVERSATIONS" BackColor="#33CCFF" ForeColor="Black"></asp:Label>
        </p>
          
          <asp:Label ID="Lk" runat="server" BackColor="#9BBCFF" style="z-index: 1; left: 266px; top: 180px; position: absolute; height: 273px; width: 696px"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 518px; top: 128px; position: absolute; height: 26px; width: 121px;" Text="Create an Account"></asp:Label>
         <asp:Label ID="Label3" runat="server" BackColor="White" style="z-index: 1; left: 369px; top: 201px; position: absolute; height: 26px; width: 260px; bottom: 164px;" Text="First Name"></asp:Label>
        <asp:Label ID="Label4" runat="server" BackColor="White" style="z-index: 1; left: 369px; top: 233px; position: absolute; height: 26px; width: 260px" Text="Last Name"></asp:Label>
        <asp:Label ID="Label6" runat="server" BackColor="White" style="z-index: 1; left: 369px; top: 267px; position: absolute; height: 26px; width: 260px;" Text="Telephone Number"></asp:Label>
         <asp:Label ID="Label5" runat="server" BackColor="White" style="z-index: 1; left: 369px; top: 303px; position: absolute; height: 26px; width: 260px;" Text="Email"></asp:Label>
        <asp:Label ID="Label10" runat="server" BackColor="White" style="z-index: 1; left: 369px; top: 340px; position: absolute; height: 26px; width: 260px;" Text="Password"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"  style="z-index: 1; left: 632px; top: 204px; position: absolute" ></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server"  style="z-index: 1; left: 630px; top: 235px; position: absolute"></asp:TextBox>
         <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 630px; top: 303px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTelephone" runat="server" style="z-index: 1; left: 630px; top: 266px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 630px; top: 342px; position: absolute" TextMode="Password"></asp:TextBox>
       <asp:TextBox ID="txtPasswordConfirm" runat="server" style="z-index: 1; left: 444px; top: 387px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnCreate" runat="server" style="z-index: 1; left: 621px; top: 399px; position: absolute" Text="Create Account" BackColor="DarkGray" OnClick="btnCreate_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 364px; top: 394px; position: absolute" Text="Cancel" BackColor="DarkGray" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 107px; top: 365px; position: absolute; height: 25px; width: 113px;"></asp:Label>
 
    </form>
</body>
</html>

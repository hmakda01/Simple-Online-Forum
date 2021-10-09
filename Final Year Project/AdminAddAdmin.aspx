<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminAddAdmin.aspx.cs" Inherits="Final_Year_Project.AdminAddAdmin" %>

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
        <asp:Label ID="Lk" runat="server" BackColor="#9BBCFF" Style="z-index: 1; left: 266px; top: 180px; position: absolute; height: 273px; width: 696px"></asp:Label>
        <asp:Label ID="Label2" runat="server" Style="z-index: 1; left: 369px; top: 101px; position: absolute; height: 26px; width: 337px;" Text="Create new Admin" Font-Size="XX-Large" ForeColor="Red"></asp:Label>
        <asp:Label ID="Label3" runat="server" Style="z-index: 1; left: 369px; top: 201px; position: absolute; height: 26px; width: 260px; bottom: 164px;" Text="First Name"></asp:Label>
        <asp:Label ID="Label4" runat="server" Style="z-index: 1; left: 369px; top: 233px; position: absolute; height: 26px; width: 260px" Text="Last Name"></asp:Label>
        <asp:Label ID="Label6" runat="server" Style="z-index: 1; left: 369px; top: 267px; position: absolute; height: 26px; width: 260px;" Text="Telephone Number"></asp:Label>
        <asp:Label ID="Label5" runat="server" Style="z-index: 1; left: 369px; top: 303px; position: absolute; height: 26px; width: 260px;" Text="Email"></asp:Label>
        <asp:Label ID="Label10" runat="server" Style="z-index: 1; left: 369px; top: 340px; position: absolute; height: 26px; width: 260px;" Text="Password"></asp:Label>
        <asp:Label ID="Label11" runat="server" Style="z-index: 1; left: 373px; top: 383px; position: absolute; height: 29px; width: 230px" Text="Password Confirm:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" Style="z-index: 1; left: 632px; top: 204px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" Style="z-index: 1; left: 630px; top: 235px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" Style="z-index: 1; left: 628px; top: 270px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTelephone" runat="server" Style="z-index: 1; left: 628px; top: 310px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" Style="z-index: 1; left: 630px; top: 342px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtPasswordConfirm" runat="server" Style="z-index: 1; left: 630px; top: 384px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnSave" runat="server" BackColor="#99CC00" style="z-index: 1; left: 803px; top: 418px; position: absolute; width: 69px;" Text="Save" OnClick="btnSave_Click" />
        <asp:Button ID="btnCreate" runat="server" Style="z-index: 1; left: 621px; top: 423px; position: absolute" Text="Create Account" BackColor="DarkGray" OnClick="btnCreate_Click" />
        <asp:Button ID="btnCancel" runat="server" Style="z-index: 1; left: 409px; top: 421px; position: absolute" Text="Cancel" BackColor="DarkGray" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" Style="z-index: 1; left: 107px; top: 365px; position: absolute; height: 25px; width: 113px;"></asp:Label>

    </form>
</body>
</html>

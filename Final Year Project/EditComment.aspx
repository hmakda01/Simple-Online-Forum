<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditComment.aspx.cs" Inherits="Final_Year_Project.EditComment" %>

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
        <asp:Button ID="btnPersonalDetails" runat="server" BackColor="DarkGray" ForeColor="Black" style="z-index: 1; left: 1008px; top: 38px; position: absolute" Text="Personal Details" OnClick="btnPersonalDetails_Click"  />
        <asp:TextBox ID="txtCommentDescription" runat="server" style="z-index: 1; left: 426px; top: 148px; position: absolute; height: 122px; width: 384px" Rows="4" TextMode="MultiLine"></asp:TextBox>
        <asp:TextBox ID="txtCommentDate" runat="server" style="z-index: 1; left: 428px; top: 292px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label12" runat="server" style="z-index: 1; left: 308px; top: 150px; position: absolute" Text="Comment"></asp:Label>
        <asp:Label ID="Label13" runat="server" style="z-index: 1; left: 338px; top: 291px; position: absolute; height: 23px; width: 46px;" Text="Date"></asp:Label>
        <asp:Button ID="btnGoBack" runat="server" style="z-index: 1; left: 38px; top: 134px; position: absolute; height: 29px; width: 145px;" Text="Go Back" BackColor="Gray" ForeColor="#FFFFCC" OnClick="btnGoBack_Click" />

        
        <asp:Button ID="Save" runat="server" style="z-index: 1; left: 657px; top: 306px; position: absolute; height: 31px; width: 140px;" Text="Save" BackColor="Lime" Font-Names="Calibri" Font-Size="Large" ForeColor="Black" OnClick="Save_Click" />

        
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 229px; top: 315px; position: absolute; right: 876px"></asp:Label>

        
        <asp:Label ID="Label14" runat="server" BackColor="#FFCC00" Font-Names="Calibri" Font-Size="XX-Large" ForeColor="Black" style="z-index: 1; left: 429px; top: 91px; position: absolute; height: 40px; width: 384px" Text="Edit Comment"></asp:Label>

        
    </form>
</body>
</html>

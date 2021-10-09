 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Final_Year_Project.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
    <body style="background-color: lightgrey; height: 858px;">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="32pt" style="z-index: 1; left: 14px; top: 18px; position: absolute; height: 57px; width: 1140px" Text="COVID CONVERSATIONS" BackColor="#33CCFF" ForeColor="Black"></asp:Label>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 713px; top: 80px; position: absolute"></asp:Label>
        </p>
        <asp:TextBox ID="txtEmail" runat="server" BackColor="LightGray" style="z-index: 1; left: 569px; top: 35px; position: absolute; right: 105px;">Enter Email</asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" BackColor="LightGray" style="z-index: 1; left: 767px; top: 35px; position: absolute" TextMode="Password">Enter Password</asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" BackColor="DarkGray" ForeColor="Black" style="z-index: 1; left: 989px; top: 35px; position: absolute; height: 26px; width: 73px;" Text="Login" OnClick="btnLogin_Click"  />
        <asp:Button ID="btnRegister" runat="server" BackColor="DarkGray" ForeColor="Black" style="z-index: 1; left: 1073px; top: 35px; position: absolute; height: 26px;" Text="Register" OnClick="btnRegister_Click" />
        <asp:Button ID="btnForum" runat="server" BackColor="Blue" ForeColor="White" style="z-index: 1; left: 482px; top: 118px; position: absolute; height: 30px; width: 170px" Text="Forum" OnClick="btnForum_Click" />
        <asp:Button ID="btnPost" runat="server" BackColor="Blue" ForeColor="White" style="z-index: 1; left: 655px; top: 118px; position: absolute; height: 30px; width: 170px;" Text="Help and Guidance" OnClick="btnPost_Click" />
        <asp:Button ID="btnPopular" runat="server" BackColor="Blue" ForeColor="White" style="z-index: 1; left: 309px; top: 117px; position: absolute; height: 30px; width: 170px; right: 711px;" Text="Home" OnClick="btnPopular_Click" />
    <p>
        &nbsp;</p>
    <p>
    
        &nbsp;</p>
    
        <p>
            &nbsp;</p>
    
        &nbsp;<img class="auto-style4" src="https://coronavirus.beyondblue.org.au/images/librariesprovider2/default-album/bey1948_bb_c19micro_1170x315px_v2.png?sfvrsn=e79beeda_0&amp;quality=70" style="margin-top: 0px; width: 1168px; top: 150px; height: 235px;" /><p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" BackColor="Silver" Font-Bold="True" Font-Names="Calibri" Font-Size="15pt" ForeColor="Black" style="z-index: 1; left: 133px; top: 577px; position: absolute; height: 155px; width: 942px; margin-top: 3px;" TextMode="MultiLine">Here at Covid Conversations , we want to make sure that you’re getting the most out of our community forums. With the conversations around the novel coronavirus and COVID-19 growing daily, we wanted to make sure that forum members have a home to discuss breaking news regarding the virus, where they can easily find expert opinions and mature debates, and take part in informed discussions based on scientific facts and reports.</asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="50pt" ForeColor="Blue" style="z-index: 1; left: 190px; top: 486px; position: absolute" Text="Coronavirus Support Service"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
&nbsp;<p>
            &nbsp;</p>

        </form>
        </body>
</html>

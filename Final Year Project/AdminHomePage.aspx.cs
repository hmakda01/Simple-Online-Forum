using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Year_Project
{
    public partial class AdminHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdminUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminUserPage.aspx");
        }

        protected void btnAdminForum_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminForumPage.aspx");
        }

        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage.aspx");
        }

        protected void btnHealth_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHealthSpecPage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}
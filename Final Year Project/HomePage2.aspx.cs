using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Year_Project
{
    public partial class HomePage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnForum_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserForumPage.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void btnPersonalDetail_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserListPage.aspx");
        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
            Response.Redirect("HelpPage.aspx");
        }

        protected void btnPopular_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage2.aspx");
        }
    }
}
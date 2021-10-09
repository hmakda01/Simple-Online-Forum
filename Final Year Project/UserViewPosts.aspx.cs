using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class UserViewPosts : System.Web.UI.Page
    {
        Int32 PostId;
        protected void Page_Load(object sender, EventArgs e)
        {
            PostId = Convert.ToInt32(Session["PostId"]);
            if (IsPostBack == false)
            {
                // Populate the list
                DisplayPost();
                // If this is not a new record
                if (PostId != -1)
                {
                    // Display the current datat or the record
                    DisplayPost();
                }
            }
        }


        void DisplayPost()
        {
            clsPostCollection PostBook = new clsPostCollection();
            // Find the record to update
            PostBook.ThisPost.Find(PostId);
            // Display  data
            txtForumTitle.Text = PostBook.ThisPost.PostTitle;
            txtDescription.Text = PostBook.ThisPost.PostDescription;
            txtPostDate.Text = PostBook.ThisPost.PostDate.ToString();
        }



        protected void btnGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserForumPage.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HelpPage.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void btnPersonalDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserListPage.aspx");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class UserForumPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                // Update the list
                DisplayPost();
            
            }
        }

        void DisplayPost()
        {
            clsPostCollection Post = new clsPostCollection();
            lstPostss.DataSource = Post.PostList;
            // Set the name of the primary key
            lstPostss.DataValueField = "PostId";
            lstPostss.DataTextField = "PostTitle";
            lstPostss.DataBind();
        }

        protected void btnAddPost_Click(object sender, EventArgs e)
        {
            Session["PostId"] = -1;
            Response.Redirect("AddNewPost.aspx");
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            // Var to store the primary key value tro be stored
            Int32 PostId;
            //if a record has been selected form the list
            if (lstPostss.SelectedIndex != -1)
            {
                // Get the primary value to delete
                PostId = Convert.ToInt32(lstPostss.SelectedValue);
                // Store the data
                Session["PostId"] = PostId;
                // Redirect back
                Response.Redirect("UserViewPosts.aspx");
            }
            else
            {
                // Display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        protected void btnPersonalDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserListPage.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void btnPopular_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage2.aspx");
        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
            Response.Redirect("HelpPage.aspx");
        }
    }
}
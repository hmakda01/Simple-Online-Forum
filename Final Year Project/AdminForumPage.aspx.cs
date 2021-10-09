using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;
namespace Final_Year_Project
{
    public partial class AdminForumPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                // Display the Post
                DisplayPost();
            }
        }

        void DisplayPost()
        {
            clsPostCollection Post = new clsPostCollection();
            lstPosts.DataSource = Post.PostList;
            // Set the name of the primary key
            lstPosts.DataValueField = "PostId";
            lstPosts.DataTextField = "PostTitle";
            lstPosts.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // Var to store the primary key value to be stored
            Int32 PostId;
            // If a record has been selected form the list
            if (lstPosts.SelectedIndex != -1)
            {
                // Get the primary value to delete
                PostId = Convert.ToInt32(lstPosts.SelectedValue);
                // Store the data
                Session["PostId"] = PostId;
                // Redirect back
                Response.Redirect("DeletePost.aspx");
            }
            else
            {
                // Display an error
                lblError.Text = "Please select a record to delete from the list";
            }

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            // Var to store the primary key value tro be stored
            Int32 PostId;
            // If a record has been selected form the list
            if (lstPosts.SelectedIndex != -1)
            {
                // Get the primary value to delete
                PostId = Convert.ToInt32(lstPosts.SelectedValue);
                // Store the data
                Session["PostId"] = PostId;
                // Redirect back
                Response.Redirect("AdminEditForum.aspx");
            }
            else
            {
                // Display an error
                lblError.Text = "Please select a record to edit from the list";
            }

        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomePage.aspx");
        }
    }
}
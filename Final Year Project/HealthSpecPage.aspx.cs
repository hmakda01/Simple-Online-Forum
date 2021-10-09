using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class HealthForum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                // Display the list
                DisplayPost();
                // DisplayThread();
                DisplayComment();
            }
        }
        void DisplayComment()
        {
            clsCommentCollection Comment = new clsCommentCollection();
            lstComments.DataSource = Comment.CommentList;
            // Set the name of the primary key
            lstComments.DataValueField = "CommentId";
            lstComments.DataTextField = "CommentDescription";
            lstComments.DataBind();
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

        protected void btnView_Click(object sender, EventArgs e)
        {
            // Var to store the primary key value tro be stored
            Int32 PostId;
            // If a record has been selected form the list
            if (lstPostss.SelectedIndex != -1)
            {
                // Get the primary value to delete
                PostId = Convert.ToInt32(lstPostss.SelectedValue);
                // Store the data
                Session["PostId"] = PostId;
                // Redirect back
                Response.Redirect("HealthSpecViewPosts.aspx");
            }
            else
            {
                // Display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

       

        protected void btnComment_Click1(object sender, EventArgs e)
        {
            Session["CommentId"] = -1;
            Response.Redirect("Comments.aspx");
        }

        protected void btnPersonalDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("HealthSpecListPage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Var to store the primary key value tro be stored
            Int32 CommentId;
            // If a record has been selected form the list
            if (lstComments.SelectedIndex != -1)
            {
                // Get the primary value to delete
                CommentId = Convert.ToInt32(lstComments.SelectedValue);
                // Store the data
                Session["CommentId"] = CommentId;
                // Redirect back
                Response.Redirect("ViewComment.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to view from the list";
            }
        }

        protected void btnEditComment_Click(object sender, EventArgs e)
        {
            // Var to store the primary key value tro be stored
            Int32 CommentId;
            // If a record has been selected form the list
            if (lstComments.SelectedIndex != -1)
            {
                // Get the primary value to delete
                CommentId = Convert.ToInt32(lstComments.SelectedValue);
                // Store the data
                Session["CommentId"] = CommentId;
                // Redirect to edit comment page
                Response.Redirect("EditComment.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
            
        }

        protected void btnDeleteComment_Click(object sender, EventArgs e)
        {
             //var to store the primary key value tro be stored
            Int32 CommentId;
            //if a record has been selected form the list
            if (lstComments.SelectedIndex != -1)
            {
                //get the primary value to delete
                CommentId = Convert.ToInt32(lstComments.SelectedValue);
                //store the data
                Session["CommentId"] = CommentId;
                //redirect back
                Response.Redirect("DeleteComment.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}
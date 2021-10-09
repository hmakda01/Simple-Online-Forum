using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class AdminEditForum : System.Web.UI.Page
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
                    // Display the current da or the record
                    DisplayPost();
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Update();
            Response.Redirect("AdminForumPage.aspx");
        }

        //function for editing records
        void Update()
        {
            // Create an instance for Post
            clsPostCollection PostBook = new clsPostCollection();
            // Validate the data on the web form
            String Error = PostBook.ThisPost.Valid(txtForumTitle.Text, txtDescription.Text, txtPostDate.Text);
            // If the data is ok then add it to the object
            if (Error == "")
            {
                PostBook.ThisPost.Find(PostId);
                // Get the data enetered by the user
                PostBook.ThisPost.PostTitle = txtForumTitle.Text;
                PostBook.ThisPost.PostDescription = txtDescription.Text;
                PostBook.ThisPost.PostDate = Convert.ToDateTime(txtPostDate.Text);
                // Update the record
                PostBook.Update();
                lblError.Text = "Success";

            }
            else
            {
                // Report an error
                lblError.Text = "There were problems with the data entered" + Error;
            }

        }

        void DisplayPost()
        {
            clsPostCollection PostBook = new clsPostCollection();
            // Find the record to update
            PostBook.ThisPost.Find(PostId);
            // DispLay  data
            txtForumTitle.Text = PostBook.ThisPost.PostTitle;
            txtDescription.Text = PostBook.ThisPost.PostDescription;
            txtPostDate.Text = PostBook.ThisPost.PostDate.ToString();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminForumPage.aspx");
        }

        protected void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
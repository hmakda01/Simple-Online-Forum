using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class EditComment : System.Web.UI.Page
    {
        Int32 CommentId;
        protected void Page_Load(object sender, EventArgs e)
        {
            CommentId = Convert.ToInt32(Session["CommentId"]);
            if (IsPostBack == false)
            {
                //popute the list
                DisplayComment();
                //if his is not a new record
                if (CommentId != -1)
                {
                    //display the current da or the record
                    DisplayComment();
                }
            }
        }

        // Function for editing records
        void Update()
        {
            // Create an instance for Comment
            clsCommentCollection CommentBook = new clsCommentCollection();
            // Validate the data on the web form
            String Error = CommentBook.ThisComment.Valid(txtCommentDescription.Text, txtCommentDate.Text);
            // If the data is ok then add it to the object
            if (Error == "")
            {
                // Find the Comment Id
                CommentBook.ThisComment.Find(CommentId);
                // Get the data enetered by the user
                CommentBook.ThisComment.CommentDescription = txtCommentDescription.Text;
                CommentBook.ThisComment.CommentDate = Convert.ToDateTime(txtCommentDate.Text);
                //add the record
                CommentBook.Update();
                lblError.Text = "Success";

            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered" + Error;
            }

        }

        void DisplayComment()
        {
            clsCommentCollection CommentBook = new clsCommentCollection();
            // Find the record to update
            CommentBook.ThisComment.Find(CommentId);
            // Display  data
            txtCommentDescription.Text = CommentBook.ThisComment.CommentDescription;
            txtCommentDate.Text = CommentBook.ThisComment.CommentDate.ToString();
        }


        protected void btnGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("HealthSpecPage.aspx");
        }

        protected void btnPersonalDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("HealthSpecListPage.aspx");
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            Update();
            Response.Redirect("HealthSpecPage.aspx");
        }
    }
}
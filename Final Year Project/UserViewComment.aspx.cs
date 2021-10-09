using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class UserViewComment : System.Web.UI.Page
    {
        Int32 CommentId;
        protected void Page_Load(object sender, EventArgs e)
        {
            CommentId = Convert.ToInt32(Session["CommentId"]);
            if (IsPostBack == false)
            {
                // Populate the list
                DisplayComment();
                // If this is not a new record
                if (CommentId != -1)
                {
                    // Display the current da or the record
                    DisplayComment();
                }
            }
        }

        void DisplayComment()
        {
            clsCommentCollection CommentBook = new clsCommentCollection();
            // Find the record to update
            CommentBook.ThisComment.Find(CommentId);
            // Display the data
            txtCommentDescription.Text = CommentBook.ThisComment.CommentDescription;
            txtCommentDate.Text = CommentBook.ThisComment.CommentDate.ToString();
        }

        protected void btnGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("HelpPage.aspx");
        }

       
    }
}

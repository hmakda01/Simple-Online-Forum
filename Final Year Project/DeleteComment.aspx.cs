using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class DeleteComment : System.Web.UI.Page
    {
        Int32 CommentId;
        protected void Page_Load(object sender, EventArgs e)
        {
            CommentId = Convert.ToInt32(Session["CommentId"]);
        }

        void DeleteComments()
        {
            // Create a new instance for the class
            clsCommentCollection CommentBook = new clsCommentCollection();
            // Find the record to delete
            CommentBook.ThisComment.Find(CommentId);
            // Delete the record
            CommentBook.Delete();
        }

        protected void btnYES_Click(object sender, EventArgs e)
        {
            // Delete the Comment
            DeleteComments();
            // Redirect back to the page
            Response.Redirect("HealthSpecPage.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("HealthSpecPage.aspx");
        }
    }
}

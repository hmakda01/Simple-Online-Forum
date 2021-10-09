using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class DeletePost : System.Web.UI.Page
    {
        Int32 PostId;
        protected void Page_Load(object sender, EventArgs e)
        {
            PostId = Convert.ToInt32(Session["PostId"]);
        }

        void DeletePosts()
        {
            //cratae a new instance for the class
            clsPostCollection PostBook = new clsPostCollection();
            //finsd the record to delete
            PostBook.ThisPost.Find(PostId);
            //delete the record
            PostBook.Delete();
        }

        protected void btnYES_Click(object sender, EventArgs e)
        {
            // delete the Post
            DeletePosts();
            //redierect back to amin page
            Response.Redirect("AdminForumPage.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminForumPage.aspx");
        }
    }
}
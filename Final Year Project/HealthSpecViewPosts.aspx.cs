using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class HealthSpecViewPosts : System.Web.UI.Page
    {
        Int32 PostId;
        protected void Page_Load(object sender, EventArgs e)
        {
            PostId = Convert.ToInt32(Session["PostId"]);
            if (IsPostBack == false)
            {
                //popute the list
                DisplayPost();
                //if his is not a new record
                if (PostId != -1)
                {
                    //display the current da or the record
                    DisplayPost();
                }
            }
        }


        void DisplayPost()
        {
            clsPostCollection PostBook = new clsPostCollection();
            //find the record to update
            PostBook.ThisPost.Find(PostId);
            //dispy  data
            //txtPostId.Text = PostBook.ThisPost.PostId.ToString();
            txtForumTitle.Text = PostBook.ThisPost.PostTitle;
            txtDescription.Text = PostBook.ThisPost.PostDescription;
            txtPostDate.Text = PostBook.ThisPost.PostDate.ToString();
        }



        protected void btnGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("HealthSpecPage.aspx");
        }

    }
}
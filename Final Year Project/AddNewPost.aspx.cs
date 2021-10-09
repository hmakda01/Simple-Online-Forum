using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class AddNewPost : System.Web.UI.Page
    {
        Int32 PostId;
        protected void Page_Load(object sender, EventArgs e)
        {
            PostId = Convert.ToInt32(Session["PostId"]);
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Add();
            Response.Redirect("UserForumPage.aspx");

        }

        //function for adding records
        void Add()
        {
            //create an instance for Post
            clsPostCollection PostBook = new clsPostCollection();
            //validate the data on the web form
            String Error = PostBook.ThisPost.Valid(txtForumTitle.Text, txtDescription.Text, txtPostDate.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                PostBook.ThisPost.Find(PostId);
                //get the data enetered by the user
                //PostBook.ThisPost.PostId = Convert.ToInt32(txtPostId.Text);
                PostBook.ThisPost.PostTitle = txtForumTitle.Text;
                PostBook.ThisPost.PostDescription = txtDescription.Text;
                PostBook.ThisPost.PostDate = Convert.ToDateTime(txtPostDate.Text);
                //add the record
                PostBook.Add();
                lblError.Text = "Success";

            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered" + Error;
            }

        }


        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserForumPage.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class Comments : System.Web.UI.Page
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

        //function for adding records
        void Add()
        {
            //create an instance for Comment
            clsCommentCollection CommentBook = new clsCommentCollection();
            //validate the data on the web form
            String Error = CommentBook.ThisComment.Valid(txtCommentDescription.Text, txtCommentDate.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //get the data enetered by the user
                //CommentBook.ThisComment.CommentId = Convert.ToInt32(txtCommentId.Text);
                CommentBook.ThisComment.CommentDescription = txtCommentDescription.Text;
                CommentBook.ThisComment.CommentDate = Convert.ToDateTime(txtCommentDate.Text);
                //add the record
                CommentBook.Add();
                lblError.Text = "Success";

            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered" + Error;
            }

        }


        //function for editing records
        void Update()
        {
            //create an instance for Comment
            clsCommentCollection CommentBook = new clsCommentCollection();
            //validate the data on the web form
            String Error = CommentBook.ThisComment.Valid(txtCommentDescription.Text, txtCommentDate.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //get the data enetered by the user
                //CommentBook.ThisComment.CommentId = Convert.ToInt32(txtCommentId.Text);
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
            //find the record to update
            CommentBook.ThisComment.Find(CommentId);
            //dispy  data
            //txtCommentId.Text = CommentBook.ThisComment.CommentId.ToString();
            txtCommentDescription.Text = CommentBook.ThisComment.CommentDescription;
            txtCommentDate.Text = CommentBook.ThisComment.CommentDate.ToString();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            Response.Redirect("HealthSpecPage.aspx");
        }

        protected void btnPersonalDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("HealthSpecListPage.aspx");
        }

        protected void btnGoBack_Click1(object sender, EventArgs e)
        {
            Response.Redirect("HealthSpecPage.aspx");
        }
    }
}
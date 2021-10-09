using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class HelpPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //IPDAT ETHE LIST
                DisplayComment();
                // DisplayThread();
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


        protected void lstComments_SelectedIndexChanged()
        {

        }

        protected void btnPopular_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage2.aspx");
        }

        protected void btnForum_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserForumPage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
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
                Response.Redirect("UserViewComment.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to view from the list";
            }
          
        }
    }
}
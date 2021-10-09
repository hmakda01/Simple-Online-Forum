using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class ForumPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //IPDAT ETHE LIST
                 DisplayPost();
               // DisplayThread();
            }
        }

        void DisplayPost()
        {
            clsPostCollection Post = new clsPostCollection();
            lstPostss.DataSource = Post.PostList;
            //set the name of the primary key
            lstPostss.DataValueField = "PostId";
            lstPostss.DataTextField = "PostTitle";
            //lstPostss.DataTextField = "PostDescription";
            //lstPostss.DataTextField = "PostDate";
            lstPostss.DataBind();
        }

        protected void btnAddPost_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("CreateNewAccount.aspx");
        }

     

        protected void btnView_Click(object sender, EventArgs e)
        {
            //var to store the primary key value tro be stored
            Int32 PostId;
            //if a record has been selected form the list
            if (lstPostss.SelectedIndex != -1)
            {
                //get the primary value to delete
                PostId = Convert.ToInt32(lstPostss.SelectedValue);
                //store the data
                Session["PostId"] = PostId;
                //redirect back
                Response.Redirect("ViewPosts.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to view from the list";
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateNewAccount.aspx");
        }
    }
}
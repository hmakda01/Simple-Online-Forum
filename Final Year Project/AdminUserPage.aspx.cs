using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class AdminPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //IPDAT ETHE LIST
                DisplayUsers();
            }


        }

        void DisplayUsers()
        {
            clsUserCollection Users = new clsUserCollection();
            lstUser.DataSource = Users.UserList;
            //set the name of the primary key
            lstUser.DataValueField = "UserId";
            lstUser.DataTextField = "UserFirstName";
            lstUser.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object 
            Session["UserId"] = -1;
            //redirect to the entry page
            Response.Redirect("AdminCreateUserAccount.aspx");
        }


        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value tro be stored
            Int32 UserId;
            //if a record has been selected form the list
            if (lstUser.SelectedIndex != -1)
            {
                //get the primary value to delete
                UserId = Convert.ToInt32(lstUser.SelectedValue);
                //store the data
                Session["UserId"] = UserId;
                //redirect back
                Response.Redirect("DeleteUser.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value tro be stored
            Int32 UserId;
            //if a record has been selected form the list
            if (lstUser.SelectedIndex != -1)
            {
                //get the primary value to delete
                UserId = Convert.ToInt32(lstUser.SelectedValue);
                //store the data
                Session["UserId"] = UserId;
                //redirect back
                Response.Redirect("AdminEditUser.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomePage.aspx");
        }
    }
}
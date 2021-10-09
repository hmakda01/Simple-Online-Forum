using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class AdminEditUser : System.Web.UI.Page
    {
        Int32 UserId;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserId = Convert.ToInt32(Session["UserId"]);
            if (IsPostBack == false)
            {
                //popute the list
                DisplayUser();
                //if his is not a new record
                if (UserId != -1)
                {
                    //display the current da or the record
                    DisplayUser();
                }
            }
        }

        void DisplayUser()
        {
            clsUserCollection UserBook = new clsUserCollection();
            //find the record to update
            UserBook.ThisUser.Find(UserId);
            //dispy  data
            //txtUserId.Text = UserBook.ThisUser.UserId.ToString();
            txtFirstName.Text = UserBook.ThisUser.UserFirstName;
            txtLastName.Text = UserBook.ThisUser.UserLastName;
            txtTelephone.Text = UserBook.ThisUser.UserTelephone;
            txtEmail.Text = UserBook.ThisUser.UserEmail;
            txtUserPasword.Text = UserBook.ThisUser.UserPassword;
           

        }

       

        

        void Update()
        {
            //create an instance for User
            clsUserCollection UserBook = new clsUserCollection();
            //validate the data on the web form
            String Error = UserBook.ThisUser.Valid(txtFirstName.Text, txtLastName.Text, txtTelephone.Text, txtEmail.Text, txtUserPasword.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //find the record to update
                UserBook.ThisUser.Find(UserId);
                //get the data enetered by the user
                //UserBook.ThisUser.UserId = Convert.ToInt32(txtUserId.Text);
                UserBook.ThisUser.UserFirstName = txtFirstName.Text;
                UserBook.ThisUser.UserLastName = txtLastName.Text;
                UserBook.ThisUser.UserTelephone = txtTelephone.Text;
                UserBook.ThisUser.UserEmail = txtEmail.Text;
                UserBook.ThisUser.UserPassword = txtUserPasword.Text;

                //add the record
                UserBook.Update();
                lblError.Text = "Success";

            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered" + Error;
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Update();
            Response.Redirect("AdminUserPage.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminUserPage.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class AdminEditAdmin : System.Web.UI.Page
    {
        Int32 AdminId;
        protected void Page_Load(object sender, EventArgs e)
        {
            AdminId = Convert.ToInt32(Session["AdminId"]);
            if (IsPostBack == false)
            {
                //popute the list
                DisplayAdmin();
                //if his is not a new record
                if (AdminId != -1)
                {
                    //display the current da or the record
                    DisplayAdmin();
                }
            }
        }

        void DisplayAdmin()
        {
            clsAdminCollection AdminBook = new clsAdminCollection();
            // Find the record to update
            AdminBook.ThisAdmin.Find(AdminId);
            // Display  data
            txtFirstName.Text = AdminBook.ThisAdmin.AdminFirstName;
            txtLastName.Text = AdminBook.ThisAdmin.AdminLastName;
            txtTelephone.Text = AdminBook.ThisAdmin.AdminTelephone;
            txtEmail.Text = AdminBook.ThisAdmin.AdminEmail;
            txtAdminPassword.Text = AdminBook.ThisAdmin.AdminPassword;
        }

        

        void Update()
        {
            // Create an instance for Admin
            clsAdminCollection AdminBook = new clsAdminCollection();
            // Validate the data on the web form
            String Error = AdminBook.ThisAdmin.Valid(txtFirstName.Text, txtLastName.Text, txtTelephone.Text, txtEmail.Text, txtAdminPassword.Text);
            // If the data is ok then add it to the object
            if (Error == "")
            {
                AdminBook.ThisAdmin.Find(AdminId);
                // Get the data enetered by the Admin
                AdminBook.ThisAdmin.AdminFirstName = txtFirstName.Text;
                AdminBook.ThisAdmin.AdminLastName = txtLastName.Text;
                AdminBook.ThisAdmin.AdminTelephone = txtTelephone.Text;
                AdminBook.ThisAdmin.AdminEmail = txtEmail.Text;
                AdminBook.ThisAdmin.AdminPassword = txtAdminPassword.Text;
                // Update the record
                AdminBook.Update();
                lblError.Text = "Success";

            }
            else
            {
                // Report an error
                lblError.Text = "There were problems with the data entered" + Error;
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Update();
            Response.Redirect("AdminPage.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage.aspx");
        }
    }
}
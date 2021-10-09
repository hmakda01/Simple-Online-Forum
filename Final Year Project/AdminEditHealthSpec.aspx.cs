using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class AdminEditHealthSpec : System.Web.UI.Page
    {
        // Var to store the primary key
        Int32 HealthSpecialistId;

        // Event handler for the Page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            HealthSpecialistId = Convert.ToInt32(Session["HealthSpecialistId"]);
            if (IsPostBack == false)
            {
                // Populate the list
                DisplayHealthSpecialist();
                // If This is not a new record
                if (HealthSpecialistId != -1)
                {
                    // Display the current data or the record
                    DisplayHealthSpecialist();
                }
            }
        }

        void DisplayHealthSpecialist()
        {
            clsHealthSpecialistCollection HealthSpecialistBook = new clsHealthSpecialistCollection();
            // Find the record to update
            HealthSpecialistBook.ThisHealthSpecialist.Find(HealthSpecialistId);
            // Display  data
            txtFirstName.Text = HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistFirstName;
            txtLastName.Text = HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistLastName;
            txtTelephone.Text = HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistTelephone;
            txtEmail.Text = HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistEmail;
            txtHealthSpecialistPasword.Text = HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistPassword;

        }


        void Update()
        {
            // Create an instance for HealthSpecialist
            clsHealthSpecialistCollection HealthSpecialistBook = new clsHealthSpecialistCollection();
            // Validate the data on the web form
            String Error = HealthSpecialistBook.ThisHealthSpecialist.Valid(txtFirstName.Text, txtLastName.Text, txtTelephone.Text, txtEmail.Text, txtHealthSpecialistPasword.Text);
            // If the data is ok then add it to the object
            if (Error == "")
            {
                // Find the record to update
                HealthSpecialistBook.ThisHealthSpecialist.Find(HealthSpecialistId);
                // Get the data enetered by the HealthSpecialist
                HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistFirstName = txtFirstName.Text;
                HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistLastName = txtLastName.Text;
                HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistTelephone = txtTelephone.Text;
                HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistEmail = txtEmail.Text;
                HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistPassword = txtHealthSpecialistPasword.Text;
                // Update the record
                HealthSpecialistBook.Update();
                Response.Redirect("AdminHealthSpecPage.aspx");

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
            Response.Redirect("AdminHealthSpecPage.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHealthSpecPage.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class HealthSpecialistEdit : System.Web.UI.Page
    {
       Int32 HealthSpecialistId;
        protected void Page_Load(object sender, EventArgs e)
        {
            HealthSpecialistId = Convert.ToInt32(Session["HealthSpecialistId"]);
            if (IsPostBack == false)
            {
                //popute the list
                DisplayHealthSpecialist();
                //if his is not a new record
                if (HealthSpecialistId != -1)
                {
                    //display the current da or the record
                    DisplayHealthSpecialist();
                }
            }
        }

        void DisplayHealthSpecialist()
        {
            clsHealthSpecialistCollection HealthSpecialistBook = new clsHealthSpecialistCollection();
            //find the record to update
            HealthSpecialistBook.ThisHealthSpecialist.Find(HealthSpecialistId);
            //dispy  data
            //txtHealthSpecialistId.Text = HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistId.ToString();
            txtFirstName.Text = HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistFirstName;
            txtLastName.Text = HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistLastName;
            txtTelephone.Text = HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistTelephone.ToString();
            txtEmail.Text = HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistEmail;
            txtHealthSpecialistPasword.Text = HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistPassword;

        }

        //function for Updating records

        void Update()
        {
            //create an instance for HealthSpecialist
            clsHealthSpecialistCollection HealthSpecialistBook = new clsHealthSpecialistCollection();
            //validate the data on the web form
            String Error = HealthSpecialistBook.ThisHealthSpecialist.Valid(txtFirstName.Text, txtLastName.Text, txtTelephone.Text, txtEmail.Text, txtHealthSpecialistPasword.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                // Find the record to update
                HealthSpecialistBook.ThisHealthSpecialist.Find(HealthSpecialistId);
                //get the data enetered by the HealthSpecialist
                HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistFirstName = txtFirstName.Text;
                HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistLastName = txtLastName.Text;
                HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistTelephone = txtTelephone.Text;
                HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistEmail = txtEmail.Text;
                HealthSpecialistBook.ThisHealthSpecialist.HealthSpecialistPassword = txtHealthSpecialistPasword.Text;
                //add the record
                HealthSpecialistBook.Update();
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
            Response.Redirect("HealthSpecListPage.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("HealthSpecListPage.aspx");
        }
    }
}
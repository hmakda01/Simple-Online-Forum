using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class AdminHealthSpecPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                // Display the list
                DisplayHealthSpecialists();
            }
        }

        void DisplayHealthSpecialists()
        {
            clsHealthSpecialistCollection HealthSpecialists = new clsHealthSpecialistCollection();
            lstHealthSpecialist.DataSource = HealthSpecialists.HealthSpecialistList;
            // Set the name of the primary key
            lstHealthSpecialist.DataValueField = "HealthSpecialistId";
            lstHealthSpecialist.DataTextField = "HealthSpecialistFirstName";
            lstHealthSpecialist.DataBind();
        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // Store -1 into the session object 
            Session["HealthSpecialistId"] = -1;
            // Redirect to the entry page
            Response.Redirect("AdminAddHealth.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            // Var to store the primary key value tro be stored
            Int32 HealthSpecialistId;
            // If a record has been selected form the list
            if (lstHealthSpecialist.SelectedIndex != -1)
            {
                // Get the primary value to delete
                HealthSpecialistId = Convert.ToInt32(lstHealthSpecialist.SelectedValue);
                // Store the data
                Session["HealthSpecialistId"] = HealthSpecialistId;
                // Redirect back
                Response.Redirect("AdminEditHealthSpec.aspx");
            }
            else
            {
                // Display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // Var to store the primary key value tro be stored
            Int32 HealthSpecialistId;
            // If a record has been selected form the list
            if (lstHealthSpecialist.SelectedIndex != -1)
            {
                // Get the primary value to delete
                HealthSpecialistId = Convert.ToInt32(lstHealthSpecialist.SelectedValue);
                // Store the data
                Session["HealthSpecialistId"] = HealthSpecialistId;
                // Redirect back
                Response.Redirect("AdminDeleteHealthSpec.aspx");
            }
            else
            {
                // Display an error
                lblError.Text = "Please select a record to delete from the list";
            }

        }

      

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomePage.aspx");
        }
    }
}
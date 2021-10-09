using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class HomePage : System.Web.UI.Page
    {
        //creates scope
       clsSecuritys Sec;
        protected void Page_Load(object sender, EventArgs e)
        {
            Sec = (clsSecuritys)Session["Sec"];

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            // Direct to the create account Page
            Response.Redirect("CreateNewAccount.aspx");
        }

        protected void btnForum_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForumPage.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Login for the User
            clsSecuritys Sec = new clsSecuritys();
            string UserEmail = txtEmail.Text;
            string UserPassword = txtPassword.Text;

            lblError.Text = Sec.UserSignIn(txtEmail.Text, txtPassword.Text);
            if (lblError.Text == "")
            {
                Response.Redirect("HomePage2.aspx");
            }
            else
            {
                lblError.Text = lblError.Text;
            }

            // Login for the admin
            string AdminEmail = txtEmail.Text;
            string AdminPassword = txtPassword.Text;

            lblError.Text = Sec.AdminSignIn(txtEmail.Text, txtPassword.Text);
            if (lblError.Text == "")
            {
                Response.Redirect("AdminHomePage.aspx");
            }
            else
            {
                lblError.Text = lblError.Text;
            }

            // Login for the Health specilaist
            string HealthSpecialistEmail = txtEmail.Text;
            string HealthSpecialistPassword = txtPassword.Text;

            lblError.Text = Sec.HealthSpecialistSignIn(txtEmail.Text, txtPassword.Text);
            if (lblError.Text == "")
            {
                Response.Redirect("HealthSpecPage.aspx");
            }
            else
            {
                lblError.Text = lblError.Text;
            }
        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
            Response.Redirect("HelpPage.aspx");
        }

        protected void btnPopular_Click(object sender, EventArgs e)
        {
            Response.Redirect("More.aspx");
        }

    }

      
    
}
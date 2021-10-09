using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;
namespace Final_Year_Project
{
    public partial class AdminAddHealth : System.Web.UI.Page
    {
        Int32 HealthSpecialistId;
        protected void Page_Load(object sender, EventArgs e)
        {
            // Get the number of the admin to be processed
            HealthSpecialistId = Convert.ToInt32(Session["HealthSpecialistId"]);
        }
        protected void btnCreate_Click(object sender, EventArgs e)
        {
            clsSecuritys Sec = new clsSecuritys();
            string HealthSpecialistFirstName = txtFirstName.Text;
            string HealthSpecialistLastName = txtLastName.Text;
            string HealthSpecialistTelephone = txtTelephone.Text;
            string HealthSpecialistEmail = txtEmail.Text;
            string HealthSpecialistPassword = txtPassword.Text;
            string PasswordConfirm = txtConfirmPassword.Text;


            lblError.Text = Sec.HealthSpecialistSignUp(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistEmail, HealthSpecialistTelephone, HealthSpecialistPassword, PasswordConfirm);
            if (Sec.HealthSpecialistEmailTaken(txtEmail.Text) == true)
            {
                if (lblError.Text == "")
                {
                    Response.Redirect("AdminHealthSpecPage.aspx");
                }
                else
                {
                    lblError.Text = lblError.Text;
                }
            }
            else
            {
                lblError.Text = lblError.Text;
            }
            Session["Sec"] = Sec;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHealthSpecPage.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHealthSpecPage.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class AdminAddAdmin : System.Web.UI.Page
    {
        Int32 AdminId;
        protected void Page_Load(object sender, EventArgs e)
        {
            // Get the number of the admin to be processed
            AdminId = Convert.ToInt32(Session["AdminId"]);
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            clsSecuritys Sec = new clsSecuritys();
            string AdminFirstName = txtFirstName.Text;
            string AdminLastName = txtLastName.Text;
            string AdminTelephone = txtTelephone.Text;
            string AdminEmail = txtEmail.Text;
            string AdminPassword = txtPassword.Text;
            string PasswordConfirm = txtPasswordConfirm.Text;


            lblError.Text = Sec.AdminSignUp(AdminFirstName, AdminLastName, AdminEmail, AdminTelephone, AdminPassword, PasswordConfirm);
            if (Sec.AdminEmailTaken(txtEmail.Text) == true)
            {
                if (lblError.Text == "")
                {
                    Response.Redirect("AdminPage.aspx");
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
            Response.Redirect("AdminPage.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;
namespace Final_Year_Project
{
    public partial class CreateNewAccount : System.Web.UI.Page
    {
        Int32 UserId;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserId = Convert.ToInt32(Session["UserId"]);
          
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }


        protected void btnCreate_Click(object sender, EventArgs e)
        {
            clsSecuritys Sec = new clsSecuritys();
            string UserFirstName = txtFirstName.Text;
            string UserLastName = txtLastName.Text;
            string UserTelephone = txtTelephone.Text;
            string UserEmail = txtEmail.Text;
            string UserPassword = txtPassword.Text;
            string PasswordConfirm = txtPasswordConfirm.Text;

            lblError.Text = Sec.SignUp(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword, PasswordConfirm);
            if (Sec.EmailTaken(txtEmail.Text)==true)
            {
                if (lblError.Text == "")
                {
                    Response.Redirect("HomePage.aspx");
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
       

    }


    


}

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
    public partial class AdminLogin : System.Web.UI.Page
    {
        //creates scope
        clsSecuritys Sec;
        protected void Page_Load(object sender, EventArgs e)
        {
            Sec = (clsSecuritys)Session["Sec"];
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            clsSecuritys Sec = new clsSecuritys();
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




            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString2"].ConnectionString);
            //conn.Open();
            //string Checkuser = "select count(*) from tblAdmin where AdminEmail='" + txtEmail.Text + "'";
            //SqlCommand com = new SqlCommand(Checkuser, conn);
            //int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            //conn.Close();
            //if (temp == 1)
            //{
            //    conn.Open();
            //    string checkPasswordQuery = "select AdminPassword from tblAdmin where AdminEmail='" + txtEmail.Text + "'";
            //    SqlCommand passComm = new SqlCommand(checkPasswordQuery, conn);
            //    string password = passComm.ExecuteScalar().ToString().Replace(" ", " ");
            //    if (password == txtPassword.Text)
            //    {
            //        Session["New"] = txtEmail.Text;
            //        Response.Redirect("AdminHomePage.aspx");
            //    }
            //    else
            //    {
            //        Response.Write("Password is not correct");
            //    }
            //}
            //else
            //{
            //    Response.Write("Username is not correct");
            //}
        }
    }
}
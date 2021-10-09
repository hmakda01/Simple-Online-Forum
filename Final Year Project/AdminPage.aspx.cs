using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class AdminPage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //IPDAT ETHE LIST
                DisplayAdmin();
            }
        }


        void DisplayAdmin()
        {
            clsAdminCollection Admin = new clsAdminCollection();
            lstAdmins.DataSource = Admin.AdminList;
            //set the name of the primary key
            lstAdmins.DataValueField = "AdminId";
            lstAdmins.DataTextField = "AdminFirstName";
            lstAdmins.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object 
            Session["AdminId"] = -1;
            //redirect to the entry page
            Response.Redirect("AdminAddAdmin.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value tro be stored
            Int32 AdminId;
            //if a record has been selected form the list
            if (lstAdmins.SelectedIndex != -1)
            {
                //get the primary value to delete
                AdminId = Convert.ToInt32(lstAdmins.SelectedValue);
                //store the data
                Session["AdminId"] = AdminId;
                //redirect back
                Response.Redirect("AdminEditAdmin.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // var to store the primary key value tro be stored
             Int32 AdminId;
            //if a record has been selected form the list
            if (lstAdmins.SelectedIndex != -1)
            {
                //get the primary value to delete
                AdminId = Convert.ToInt32(lstAdmins.SelectedValue);
                //store the data
                Session["AdminId"] = AdminId;
                //redirect back
                Response.Redirect("DeleteAdmin.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomePage.aspx");
        }
    }
}
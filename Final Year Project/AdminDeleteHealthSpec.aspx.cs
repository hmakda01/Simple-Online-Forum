using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class AdminDeleteHealthSpec : System.Web.UI.Page
    {
        Int32 HealthSpecialistId;
        protected void Page_Load(object sender, EventArgs e)
        {
            HealthSpecialistId = Convert.ToInt32(Session["HealthSpecialistId"]);
        }

        void DeleteHealthSpecialists()
        {
            // Create a new instance for the class
            clsHealthSpecialistCollection HealthSpecialistBook = new clsHealthSpecialistCollection();
            // Find the record to delete
            HealthSpecialistBook.ThisHealthSpecialist.Find(HealthSpecialistId);
            // Delete the record
            HealthSpecialistBook.Delete();
        }

        protected void btnYES_Click(object sender, EventArgs e)
        {
            // Delete the HealthSpecialist
            DeleteHealthSpecialists();
            // Redirect back to the page
            Response.Redirect("AdminHealthSpecPage.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHealthSpecPage.aspx");
        }
    }
}
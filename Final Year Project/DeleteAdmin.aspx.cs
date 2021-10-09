using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;
namespace Final_Year_Project
{
    public partial class DeleteAdmin : System.Web.UI.Page
    {
        Int32 AdminId;
        protected void Page_Load(object sender, EventArgs e)
        {
            AdminId = Convert.ToInt32(Session["AdminId"]);
        }

        void DeleteAdmins()
        {
            //cratae a new instance for the class
            clsAdminCollection AdminBook = new clsAdminCollection();
            //finsd the record to delete
            AdminBook.ThisAdmin.Find(AdminId);
            //delete the record
            AdminBook.Delete();
        }

        protected void btnYES_Click(object sender, EventArgs e)
        {
            // delete the Admin
            DeleteAdmins();
            //redierect back to amin page
            Response.Redirect("AdminPage.aspx");
        }
    }
}
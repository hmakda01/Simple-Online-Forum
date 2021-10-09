using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;
namespace Final_Year_Project
{
    public partial class DeleteUser : System.Web.UI.Page
    {
        Int32 UserId;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserId = Convert.ToInt32(Session["UserId"]);
        }
        void DeleteUsers()
        {
            //cratae a new instance for the class
            clsUserCollection UserBook = new clsUserCollection();
            //finsd the record to delete
            UserBook.ThisUser.Find(UserId);
            //delete the record
            UserBook.Delete();
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage.aspx");
        }

        protected void btnYES_Click(object sender, EventArgs e)
        {
            // delete the User
            DeleteUsers();
            //redierect back to amin page
            Response.Redirect("AdminUserPage.aspx");
        }
    }
}
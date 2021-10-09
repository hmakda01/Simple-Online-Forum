using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class UserListPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void btnEdit_Click(object sender, EventArgs e)
        {
            // Var to store the primary key value tro be stored
            Int32 UserId;
            // If a record has been selected form the list
            if (lstUser.SelectedIndex != -1)
            {
                // Get the primary value to delete
                UserId = Convert.ToInt32(lstUser.SelectedValue);
                // Store the data
                Session["UserId"] = UserId;
                // Redirect back
                Response.Redirect("UserEdit.aspx");
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
            Int32 UserId;
            // If a record has been selected form the list
            if (lstUser.SelectedIndex != -1)
            {
                // Get the primary value to delete
                UserId = Convert.ToInt32(lstUser.SelectedValue);
                // Store the data
                Session["UserId"] = UserId;
                // Redirect back
                Response.Redirect("DeleteUser.aspx");
            }
            else
            {
                // Display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            // Declare var to store record count
            Int32 RecordCount;
            // Var to store string
            string UserEmail = txtEmailFilter.Text;
            // If text is empty
            if (UserEmail == "")
            {
                lblError.Text = "Please enter your UserEmail";
            }
            else
            {

                RecordCount = DisplayFilterUser(txtEmailFilter.Text);
                lblError.Text = RecordCount + " Record Found";
            }

        }

        Int32 DisplayFilterUser(string UserEmailFilter)
        {
            Int32 UserId;
            // String email
            string UserEmail;
            clsUserCollection UserBook = new clsUserCollection();
            UserBook.ReportByUserEmail(UserEmailFilter);
            Int32 RecordCount;
            Int32 Index = 0;
            RecordCount = UserBook.Count;
            lstUser.Items.Clear();
            while (Index < RecordCount)
            {
                UserId = UserBook.UserList[Index].UserId;
                UserEmail = UserBook.UserList[Index].UserLastName;
                ListItem NewEntry = new ListItem(UserEmail + "", UserId.ToString());
                lstUser.Items.Add(NewEntry);
                Index++;
            }
            return RecordCount;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage2.aspx");
        }
    }
}
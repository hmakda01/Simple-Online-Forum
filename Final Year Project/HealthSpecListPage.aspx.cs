using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineForumClasses;

namespace Final_Year_Project
{
    public partial class HealthSpecListPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value tro be stored
            Int32 HealthSpecialistId;
            //if a record has been selected form the list
            if (lstHealthSpecialist.SelectedIndex != -1)
            {
                //get the primary value to delete
                HealthSpecialistId = Convert.ToInt32(lstHealthSpecialist.SelectedValue);
                //store the data
                Session["HealthSpecialistId"] = HealthSpecialistId;
                //redirect back
                Response.Redirect("HealthSpecialistEdit.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value tro be stored
            Int32 HealthSpecialistId;
            //if a record has been selected form the list
            if (lstHealthSpecialist.SelectedIndex != -1)
            {
                //get the primary value to delete
                HealthSpecialistId = Convert.ToInt32(lstHealthSpecialist.SelectedValue);
                //store the data
                Session["HealthSpecialistId"] = HealthSpecialistId;
                //redirect back
                Response.Redirect("DeleteHealthSpecialist.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //declare var to store record count
            Int32 RecordCount;
            //var to store string
            string HealthSpecialistEmail = txtEmailFilter.Text;
            //if text is empty
            if (HealthSpecialistEmail == "")
            {
                lblError.Text = "Please enter your HealthSpecialistEmail";
            }
            else
            {

                RecordCount = DisplayFilterHealthSpecialist(txtEmailFilter.Text);
                lblError.Text = RecordCount + " Record Found";
            }

        }

        Int32 DisplayFilterHealthSpecialist(string HealthSpecialistEmailFilter)
        {
            Int32 HealthSpecialistId;
            //string last name
            string HealthSpecialistEmail;
            clsHealthSpecialistCollection HealthSpecialistBook = new clsHealthSpecialistCollection();
            HealthSpecialistBook.ReportByHealthSpecialistEmail(HealthSpecialistEmailFilter);
            Int32 RecordCount;
            Int32 Index = 0;
            RecordCount = HealthSpecialistBook.Count;
            lstHealthSpecialist.Items.Clear();
            while (Index < RecordCount)
            {
                HealthSpecialistId = HealthSpecialistBook.HealthSpecialistList[Index].HealthSpecialistId;
                HealthSpecialistEmail = HealthSpecialistBook.HealthSpecialistList[Index].HealthSpecialistLastName;
                ListItem NewEntry = new ListItem(HealthSpecialistEmail + "", HealthSpecialistId.ToString());
                lstHealthSpecialist.Items.Add(NewEntry);
                Index++;
            }
            return RecordCount;
        }
    }
}
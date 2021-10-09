using System.Collections.Generic;
using System;

namespace OnlineForumClasses
{
    public class clsHealthSpecialistCollection
    {
        private List<clsHealthSpecialist> mHealthSpecialistList = new List<clsHealthSpecialist>();
        clsHealthSpecialist mThisHealthSpecialist = new clsHealthSpecialist();
        public List<clsHealthSpecialist> HealthSpecialistList
        {
            get
            {
                return mHealthSpecialistList;
            }

            set
            {
                mHealthSpecialistList = value;
            }
        }


        //public property for cout
        public int Count
        {
            get
            {
                //return the count list
                return mHealthSpecialistList.Count;
            }
            set
            {
                //later
            }
        }


        public clsHealthSpecialist ThisHealthSpecialist
        {
            get
            {
                //retturn the private data
                return mThisHealthSpecialist;
            }

            set
            {
                mThisHealthSpecialist = value;
            }
        }

        public clsHealthSpecialistCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the rcord count
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            //exeucte the stored procudure
            DB.Execute("sproc_tblHealthSpecialist_SelectAll");
            //get th oucnt of the records
            RecordCount = DB.Count;
            //while records to process
            while (Index < RecordCount)
            {
                clsHealthSpecialist AnHealthSpecialist = new clsHealthSpecialist();
                AnHealthSpecialist.HealthSpecialistId = Convert.ToInt32(DB.DataTable.Rows[Index]["HealthSpecialistId"]);
                AnHealthSpecialist.HealthSpecialistFirstName = Convert.ToString(DB.DataTable.Rows[Index]["HealthSpecialistFirstName"]);
                AnHealthSpecialist.HealthSpecialistLastName = Convert.ToString(DB.DataTable.Rows[Index]["HealthSpecialistLastName"]);
                AnHealthSpecialist.HealthSpecialistTelephone = Convert.ToString(DB.DataTable.Rows[Index]["HealthSpecialistTelephone"]);
                AnHealthSpecialist.HealthSpecialistEmail = Convert.ToString(DB.DataTable.Rows[Index]["HealthSpecialistEmail"]);
                AnHealthSpecialist.HealthSpecialistPassword = Convert.ToString(DB.DataTable.Rows[Index]["HealthSpecialistPassword"]);
                //add the reocrd to the private data
                mHealthSpecialistList.Add(AnHealthSpecialist);
                //point at the nect record
                Index++;

            }
        }



        public int Add()
        {
            //adds a  new reocrd to the databse
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the stroed procudure
            // DB.AddParameter("HealthSpecialistId", mThisHealthSpecialist.HealthSpecialistId);
            DB.AddParameter("HealthSpecialistFirstName", ThisHealthSpecialist.HealthSpecialistFirstName);
            DB.AddParameter("HealthSpecialistLastName", ThisHealthSpecialist.HealthSpecialistLastName);
            DB.AddParameter("HealthSpecialistTelephone", ThisHealthSpecialist.HealthSpecialistTelephone);
            DB.AddParameter("HealthSpecialistEmail", ThisHealthSpecialist.HealthSpecialistEmail);
            DB.AddParameter("HealthSpecialistPassword", ThisHealthSpecialist.HealthSpecialistPassword);
            //execute the qeury
            return DB.Execute("sproc_tblHealthSpecialist_Insert");
        }

        public void Delete()
        {
            //deleted the record pointed to by ThisHealthSpecialist
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramerers for the stored rocudure
            DB.AddParameter("@HealthSpecialistId", mThisHealthSpecialist.HealthSpecialistId);
            //execute the stored procudure
            DB.Execute("sproc_tblHealthSpecialist_Delete");


        }

        public void Update()
        {
            //adds a  new reocrd to the databse
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the stroed procudure
            DB.AddParameter("HealthSpecialistId", mThisHealthSpecialist.HealthSpecialistId);
            DB.AddParameter("HealthSpecialistFirstName", ThisHealthSpecialist.HealthSpecialistFirstName);
            DB.AddParameter("HealthSpecialistLastName", ThisHealthSpecialist.HealthSpecialistLastName);
            DB.AddParameter("HealthSpecialistTelephone", ThisHealthSpecialist.HealthSpecialistTelephone);
            DB.AddParameter("HealthSpecialistEmail", ThisHealthSpecialist.HealthSpecialistEmail);
            DB.AddParameter("HealthSpecialistPassword", ThisHealthSpecialist.HealthSpecialistPassword);
            //execute the qeury
            DB.Execute("sproc_tblHealthSpecialist_Update");
        }

        public void ReportByHealthSpecialistEmail(string HealthSpecialistEmail)
        {
            //filters the record based on a full or partial fisrtname
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send the name parameter to the database
            DB.AddParameter("@HealthSpecialistEmail", HealthSpecialistEmail);
            //execute the styored procudure 
            DB.Execute("sproc_tblHealthSpecialist_FilterByHealthSpecialistEmail");
            //popoulate the array list with the table
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            //VAR FOR THE INDEX
            Int32 Index = 0;
            //var to store the rrdeord count
            Int32 RecordCount = 0;
            //object for data connection
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mHealthSpecialistList = new List<clsHealthSpecialist>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //cretae a blank HealthSpecialist
                clsHealthSpecialist AnHealthSpecialist = new clsHealthSpecialist();
                //read in fields form the current record
                AnHealthSpecialist.HealthSpecialistId = Convert.ToInt32(DB.DataTable.Rows[Index]["HealthSpecialistId"]);
                AnHealthSpecialist.HealthSpecialistFirstName = Convert.ToString(DB.DataTable.Rows[Index]["HealthSpecialistFirstName"]);
                AnHealthSpecialist.HealthSpecialistLastName = Convert.ToString(DB.DataTable.Rows[Index]["HealthSpecialistLastName"]);
                AnHealthSpecialist.HealthSpecialistTelephone = Convert.ToString(DB.DataTable.Rows[Index]["HealthSpecialistTelephone"]);
                AnHealthSpecialist.HealthSpecialistEmail = Convert.ToString(DB.DataTable.Rows[Index]["HealthSpecialistEmail"]);
                AnHealthSpecialist.HealthSpecialistPassword = Convert.ToString(DB.DataTable.Rows[Index]["HealthSpecialistPassword"]);
                //add the record to the private data memeber
                mHealthSpecialistList.Add(AnHealthSpecialist);
                //POINT AT the next index
                Index++;
            }
        }


    }
}
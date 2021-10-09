using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineForumClasses;
using System.Collections.Generic;

///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2013

namespace OnlineForumsTests
{
    [TestClass]
    public class tstAdminCollection
    {
        [TestMethod]

        public void InstanceOK()
        {
            clsAdminCollection AllAdmins = new clsAdminCollection();
            Assert.IsNotNull(AllAdmins);
        }

        [TestMethod]
        public void AdminListOK()
        {
            //cretae an instance of the class we want to create
            clsAdminCollection AllAdmin = new clsAdminCollection();
            //create some test dat to assign to thwe property
            //in this case the data needs to be a list of objects
            List<clsAdmin> TestList = new List<clsAdmin>();
            //add a item to the ;list
            //cretae the item of test data
            clsAdmin TestItem = new clsAdmin();
            //set its properties
            TestItem.AdminId = 1;
            TestItem.AdminFirstName = "John";
            TestItem.AdminLastName = "Smith";
            TestItem.AdminTelephone = "01163480420";
            TestItem.AdminEmail = "";
            TestItem.AdminPassword = "";
            //ad the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAdmin.AdminList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAdmin.AdminList, TestList);

        }


        [TestMethod]

        public void ThisAdminPropertyOK()
        {
            clsAdminCollection AllAdmin = new clsAdminCollection();
            clsAdmin TestAdmin = new clsAdmin();
            //set its properties
            TestAdmin.AdminId = 1;
            TestAdmin.AdminFirstName = "John";
            TestAdmin.AdminLastName = "Smith";
            TestAdmin.AdminTelephone = "01163480420";
            TestAdmin.AdminEmail = "";
            TestAdmin.AdminPassword = "";
            //assign the data to the property
            AllAdmin.ThisAdmin = TestAdmin;
            //test to see that the two values are the same
            Assert.AreEqual(AllAdmin.ThisAdmin, TestAdmin);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsAdminCollection AllAdmin = new clsAdminCollection();
            //cretae the item of test data
            clsAdmin TestItem = new clsAdmin();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
            //TestItem.AdminId = 7;
            TestItem.AdminFirstName = "Eden";
            TestItem.AdminLastName = "Hazard";
            TestItem.AdminTelephone = "01164497370";
            TestItem.AdminEmail = "hazard@hotmail.com";
            TestItem.AdminPassword = "Password12";
            //set thr Admin to the test data
            AllAdmin.ThisAdmin = TestItem;
            //add the record
            PrimaryKey = AllAdmin.Add();
            //set the primary key tpo the dtaa
            TestItem.AdminId = PrimaryKey;
            //find the record
            AllAdmin.ThisAdmin.Find(PrimaryKey);
            //TEST TO SEE IF THE TWO VLAUES ARE THE SAME 
            Assert.AreEqual(AllAdmin.ThisAdmin, TestItem);

        }

        [TestMethod]
        
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsAdminCollection AllAdmin = new clsAdminCollection();
            //cretae the item of test data
            clsAdmin TestItem = new clsAdmin();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
            //TestItem.AdminId = 7;
            TestItem.AdminFirstName = "Eden";
            TestItem.AdminLastName = "Hazard";
            TestItem.AdminTelephone = "01164497370";
            TestItem.AdminEmail = "hazard@hotmail.com";
            TestItem.AdminPassword = "Password12";
            //set thr Admin to the test data
            AllAdmin.ThisAdmin = TestItem;
            //add the record
            PrimaryKey = AllAdmin.Add();
            //set the primary key tpo the dtaa
            TestItem.AdminId = PrimaryKey;
            //find the record
            AllAdmin.ThisAdmin.Find(PrimaryKey);
            //delete the record
            AllAdmin.Delete();
            //nw ind the ecord
            Boolean Found = AllAdmin.ThisAdmin.Find(PrimaryKey);
            //TEST TO SEEthat the reocrd is found
            Assert.IsFalse(Found);

        }


        [TestMethod]

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsAdminCollection AllAdmin = new clsAdminCollection();
            //cretae the item of test data
            clsAdmin TestItem = new clsAdmin();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
            //TestItem.AdminId = 7;
            TestItem.AdminFirstName = "Eden";
            TestItem.AdminLastName = "Hazard";
            TestItem.AdminTelephone = "01164497370";
            TestItem.AdminEmail = "hazard@hotmail.com";
            TestItem.AdminPassword = "Password12";
            //set thr Admin to the test data
            AllAdmin.ThisAdmin = TestItem;
            //add the record
            PrimaryKey = AllAdmin.Add();
            //set the primary key tpo the dtaa
            TestItem.AdminId = PrimaryKey;
            TestItem.AdminFirstName = "Mason";
            TestItem.AdminLastName = "Mount";
            TestItem.AdminTelephone = "01164493370";
            TestItem.AdminEmail = "mount@hotmail.com";
            TestItem.AdminPassword = "Password12";
            //set thr Admin to the test data
            AllAdmin.ThisAdmin = TestItem;
            //update the record
            AllAdmin.Update();
            //find the record
            AllAdmin.ThisAdmin.Find(PrimaryKey);
            //TEST TO SEEthat the reocrd is found
            Assert.AreEqual(AllAdmin.ThisAdmin, TestItem);
        }

        [TestMethod]

        public void ReportByAdminLastName()
        {
            //create an intance of the class contsining unfiltered results
            clsAdminCollection AllAdmin = new clsAdminCollection();
            //create an instance of the filtered data
            clsAdminCollection FilteredAdmin = new clsAdminCollection();
            //apply a blank string (should return all records)
            FilteredAdmin.ReportByAdminLastName("");
            //test to see that are tewo values are the same
            Assert.AreEqual(AllAdmin.Count, FilteredAdmin.Count);
        }


        [TestMethod]

        public void ReportByAdminLastNameNoneFound()
        {
            //create an instance of the filtered data
            clsAdminCollection FilteredAdmin = new clsAdminCollection();
            //apply a blank string (should return all records)
            FilteredAdmin.ReportByAdminLastName("xxxxxxx");
            //test to see that are tewo values are the same
            Assert.AreEqual(0, FilteredAdmin.Count);
        }


        [TestMethod]

        public void ReportByAdminLastNameTestDataFound()
        {
            //create an intance of the filtered data
            clsAdminCollection FilteredAdmin = new clsAdminCollection();
            //var to store outcome
            Boolean OK = true;
            //apply the fisrtname 
            FilteredAdmin.ReportByAdminLastName("Tuchel");
            //check the correct the number found 
            if (FilteredAdmin.Count == 2)
            {
                //check the firsdt record is id 1
                if (FilteredAdmin.AdminList[0].AdminId != 65)
                {
                    OK = false;
                }
                //check the first id is 2
                if (FilteredAdmin.AdminList[1].AdminId != 66)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);

        }



    }

}

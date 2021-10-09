using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineForumClasses;
using System.Collections.Generic;

///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2013

namespace OnlineForumsTests
{
    [TestClass]
    public class tstUserCollection
    {
    
        [TestMethod]

        public void InstanceOK()
        {
            clsUserCollection AllUsers = new clsUserCollection();
            Assert.IsNotNull(AllUsers);
        }

        [TestMethod]
        public void UserListOK()
        {
            //cretae an instance of the class we want to create
            clsUserCollection AllUser = new clsUserCollection();
            //create some test dat to assign to thwe property
            //in this case the data needs to be a list of objects
            List<clsUser> TestList = new List<clsUser>();
            //add a item to the ;list
            //cretae the item of test data
            clsUser TestItem = new clsUser();
            //set its properties
            TestItem.UserId = 1;
            TestItem.UserFirstName = "John";
            TestItem.UserLastName = "Smith";
            TestItem.UserTelephone = "01163480420";
            TestItem.UserEmail = "";
            TestItem.UserPassword = "";
            //ad the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllUser.UserList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllUser.UserList, TestList);

        }


        [TestMethod]

        public void ThisUserPropertyOK()
        {
            clsUserCollection AllUser = new clsUserCollection();
            clsUser TestUser = new clsUser();
            //set its properties
            TestUser.UserId = 1;
            TestUser.UserFirstName = "John";
            TestUser.UserLastName = "Smith";
            TestUser.UserTelephone = "01163480420";
            TestUser.UserEmail = "";
            TestUser.UserPassword = "";
            //assign the data to the property
            AllUser.ThisUser = TestUser;
            //test to see that the two values are the same
            Assert.AreEqual(AllUser.ThisUser, TestUser);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            // Create an instance of the class we want to create
            clsUserCollection AllUser = new clsUserCollection();
            // Create the item of test data
            clsUser TestItem = new clsUser();
            // Var to store the primary key
            Int32 PrimaryKey = 0;
            // Tests it properties
            // Set its properties
            TestItem.UserFirstName = "Eden";
            TestItem.UserLastName = "Hazard";
            TestItem.UserTelephone = "01164497370";
            TestItem.UserEmail = "hazard@hotmail.com";
            TestItem.UserPassword = "Password23";
            //set thr User to the test data
            AllUser.ThisUser = TestItem;
            // Add the record
            PrimaryKey = AllUser.Add();
            // Set the primary key tpo the dtaa
            TestItem.UserId = PrimaryKey;
            // Find the record
            AllUser.ThisUser.Find(PrimaryKey);
            // TEST TO SEE IF THE TWO VLAUES ARE THE SAME 
            Assert.AreEqual(AllUser.ThisUser, TestItem);

        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUser = new clsUserCollection();
            //cretae the item of test data
            clsUser TestItem = new clsUser();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
            //TestItem.UserId = 7;
            TestItem.UserFirstName = "Eden";
            TestItem.UserLastName = "Hazard";
            TestItem.UserTelephone = "01164497370";
            TestItem.UserEmail = "hazard@hotmail.com";
            TestItem.UserPassword = "Password23";
            //set thr User to the test data
            AllUser.ThisUser = TestItem;
            //add the record
            PrimaryKey = AllUser.Add();
            //set the primary key tpo the dtaa
            TestItem.UserId = PrimaryKey;
            //find the record
            AllUser.ThisUser.Find(PrimaryKey);
            //delete the record
            AllUser.Delete();
            //nw ind the ecord
            Boolean Found = AllUser.ThisUser.Find(PrimaryKey);
            //TEST TO SEEthat the reocrd is found
            Assert.IsFalse(Found);

        }


        [TestMethod]

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUser = new clsUserCollection();
            //cretae the item of test data
            clsUser TestItem = new clsUser();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
            //TestItem.UserId = 7;
            TestItem.UserFirstName = "Eden";
            TestItem.UserLastName = "Hazard";
            TestItem.UserTelephone = "01164497370";
            TestItem.UserEmail = "hazard@hotmail.com";
            TestItem.UserPassword = "Password23";
            //set thr User to the test data
            AllUser.ThisUser = TestItem;
            //add the record
            PrimaryKey = AllUser.Add();
            //set the primary key tpo the dtaa
            TestItem.UserId = PrimaryKey;
            TestItem.UserFirstName = "Mason";
            TestItem.UserLastName = "Mount";
            TestItem.UserTelephone = "01164493370";
            TestItem.UserEmail = "mount@hotmail.com";
            TestItem.UserPassword = "Password23";
            //set thr User to the test data
            AllUser.ThisUser = TestItem;
            //update the record
            AllUser.Update();
            //find the record
            AllUser.ThisUser.Find(PrimaryKey);
            //TEST TO SEEthat the reocrd is found
            Assert.AreEqual(AllUser.ThisUser, TestItem);
        }

        [TestMethod]

        public void ReportByUserEmail()
        {
            //create an intance of the class contsining unfiltered results
            clsUserCollection AllUser = new clsUserCollection();
            //create an instance of the filtered data
            clsUserCollection FilteredUser = new clsUserCollection();
            //apply a blank string (should return all records)
            FilteredUser.ReportByUserEmail("");
            //test to see that are tewo values are the same
            Assert.AreEqual(AllUser.Count, FilteredUser.Count);
        }


        [TestMethod]

        public void ReportByUserEmailNoneFound()
        {
            //create an instance of the filtered data
            clsUserCollection FilteredUser = new clsUserCollection();
            //apply a blank string (should return all records)
            FilteredUser.ReportByUserEmail("xxxxxxx");
            //test to see that are tewo values are the same
            Assert.AreEqual(0, FilteredUser.Count);
        }


        [TestMethod]

        public void ReportByUserEmailTestDataFound()
        {
            //create an intance of the filtered data
            clsUserCollection FilteredUser = new clsUserCollection();
            //var to store outcome
            Boolean OK = true;
            //apply the fisrtname 
            FilteredUser.ReportByUserEmail("hm@gmail.com");
            //check the correct the number found 
            if (FilteredUser.Count == 2)
            {
                //check the firsdt record is id 1
                if (FilteredUser.UserList[0].UserId != 73)
                {
                    OK = false;
                }
                //check the first id is 2
                if (FilteredUser.UserList[1].UserId != 74)
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

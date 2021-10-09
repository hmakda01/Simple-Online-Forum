using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineForumClasses;
using System.Collections.Generic;

///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2013

namespace OnlineForumsTests
{
    [TestClass]
    public class tstHealthSpecialistCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]

        public void InstanceOK()
        {
            clsHealthSpecialistCollection AllHealthSpecialists = new clsHealthSpecialistCollection();
            Assert.IsNotNull(AllHealthSpecialists);
        }

        [TestMethod]
        public void HealthSpecialistListOK()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialistCollection AllHealthSpecialist = new clsHealthSpecialistCollection();
            //create some test dat to assign to thwe property
            //in this case the data needs to be a list of objects
            List<clsHealthSpecialist> TestList = new List<clsHealthSpecialist>();
            //add a item to the ;list
            //cretae the item of test data
            clsHealthSpecialist TestItem = new clsHealthSpecialist();
            //set its properties
            TestItem.HealthSpecialistId = 1;
            TestItem.HealthSpecialistFirstName = "John";
            TestItem.HealthSpecialistLastName = "Smith";
            TestItem.HealthSpecialistTelephone = "01163480420";
            TestItem.HealthSpecialistEmail = "";
            TestItem.HealthSpecialistPassword = "";
            //ad the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllHealthSpecialist.HealthSpecialistList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllHealthSpecialist.HealthSpecialistList, TestList);

        }


        [TestMethod]

        public void ThisHealthSpecialistPropertyOK()
        {
            clsHealthSpecialistCollection AllHealthSpecialist = new clsHealthSpecialistCollection();
            clsHealthSpecialist TestHealthSpecialist = new clsHealthSpecialist();
            //set its properties
            TestHealthSpecialist.HealthSpecialistId = 1;
            TestHealthSpecialist.HealthSpecialistFirstName = "John";
            TestHealthSpecialist.HealthSpecialistLastName = "Smith";
            TestHealthSpecialist.HealthSpecialistTelephone = "01163480420";
            TestHealthSpecialist.HealthSpecialistEmail = "";
            TestHealthSpecialist.HealthSpecialistPassword = "";
            //assign the data to the property
            AllHealthSpecialist.ThisHealthSpecialist = TestHealthSpecialist;
            //test to see that the two values are the same
            Assert.AreEqual(AllHealthSpecialist.ThisHealthSpecialist, TestHealthSpecialist);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsHealthSpecialistCollection AllHealthSpecialist = new clsHealthSpecialistCollection();
            //cretae the item of test data
            clsHealthSpecialist TestItem = new clsHealthSpecialist();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
            //TestItem.HealthSpecialistId = 7;
            TestItem.HealthSpecialistFirstName = "Dr Dave";
            TestItem.HealthSpecialistLastName = "Smith";
            TestItem.HealthSpecialistTelephone = "01165497370";
            TestItem.HealthSpecialistEmail = "DS@hotmail.com";
            TestItem.HealthSpecialistPassword = "Password33";
            //set thr HealthSpecialist to the test data
            AllHealthSpecialist.ThisHealthSpecialist = TestItem;
            //add the record
            PrimaryKey = AllHealthSpecialist.Add();
            //set the primary key tpo the dtaa
            TestItem.HealthSpecialistId = PrimaryKey;
            //find the record
            AllHealthSpecialist.ThisHealthSpecialist.Find(PrimaryKey);
            //TEST TO SEE IF THE TWO VLAUES ARE THE SAME 
            Assert.AreEqual(AllHealthSpecialist.ThisHealthSpecialist, TestItem);

        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsHealthSpecialistCollection AllHealthSpecialist = new clsHealthSpecialistCollection();
            //cretae the item of test data
            clsHealthSpecialist TestItem = new clsHealthSpecialist();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
            //TestItem.HealthSpecialistId = 7;
            TestItem.HealthSpecialistFirstName = "Dr Dave";
            TestItem.HealthSpecialistLastName = "Smith";
            TestItem.HealthSpecialistTelephone = "01165497370";
            TestItem.HealthSpecialistEmail = "DS@hotmail.com";
            TestItem.HealthSpecialistPassword = "Password33";
            //set thr HealthSpecialist to the test data
            AllHealthSpecialist.ThisHealthSpecialist = TestItem;
            //add the record
            PrimaryKey = AllHealthSpecialist.Add();
            //set the primary key tpo the dtaa
            TestItem.HealthSpecialistId = PrimaryKey;
            //find the record
            AllHealthSpecialist.ThisHealthSpecialist.Find(PrimaryKey);
            //delete the record
            AllHealthSpecialist.Delete();
            //nw ind the ecord
            Boolean Found = AllHealthSpecialist.ThisHealthSpecialist.Find(PrimaryKey);
            //TEST TO SEEthat the reocrd is found
            Assert.IsFalse(Found);

        }


        [TestMethod]

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsHealthSpecialistCollection AllHealthSpecialist = new clsHealthSpecialistCollection();
            //cretae the item of test data
            clsHealthSpecialist TestItem = new clsHealthSpecialist();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
            //TestItem.HealthSpecialistId = 7;
            TestItem.HealthSpecialistFirstName = "Dr Dave";
            TestItem.HealthSpecialistLastName = "Smith";
            TestItem.HealthSpecialistTelephone = "01165497370";
            TestItem.HealthSpecialistEmail = "DS@hotmail.com";
            TestItem.HealthSpecialistPassword = "Password33";
            //set thr HealthSpecialist to the test data
            AllHealthSpecialist.ThisHealthSpecialist = TestItem;
            //add the record
            PrimaryKey = AllHealthSpecialist.Add();
            //set the primary key tpo the dtaa
            TestItem.HealthSpecialistId = PrimaryKey;
            TestItem.HealthSpecialistFirstName = " Dr Kevin";
            TestItem.HealthSpecialistLastName = "Mount";
            TestItem.HealthSpecialistTelephone = "01164493370";
            TestItem.HealthSpecialistEmail = "mount@hotmail.com";
            TestItem.HealthSpecialistPassword = "Password33";
            //set thr HealthSpecialist to the test data
            AllHealthSpecialist.ThisHealthSpecialist = TestItem;
            //update the record
            AllHealthSpecialist.Update();
            //find the record
            AllHealthSpecialist.ThisHealthSpecialist.Find(PrimaryKey);
            //TEST TO SEEthat the reocrd is found
            Assert.AreEqual(AllHealthSpecialist.ThisHealthSpecialist, TestItem);
        }

        [TestMethod]

        public void ReportByHealthSpecialistEmail()
        {
            //create an intance of the class contsining unfiltered results
            clsHealthSpecialistCollection AllHealthSpecialist = new clsHealthSpecialistCollection();
            //create an instance of the filtered data
            clsHealthSpecialistCollection FilteredHealthSpecialist = new clsHealthSpecialistCollection();
            //apply a blank string (should return all records)
            FilteredHealthSpecialist.ReportByHealthSpecialistEmail("");
            //test to see that are tewo values are the same
            Assert.AreEqual(AllHealthSpecialist.Count, FilteredHealthSpecialist.Count);
        }


        [TestMethod]

        public void ReportByHealthSpecialistEmailNoneFound()
        {
            //create an instance of the filtered data
            clsHealthSpecialistCollection FilteredHealthSpecialist = new clsHealthSpecialistCollection();
            //apply a blank string (should return all records)
            FilteredHealthSpecialist.ReportByHealthSpecialistEmail("xxxxxxx");
            //test to see that are tewo values are the same
            Assert.AreEqual(0, FilteredHealthSpecialist.Count);
        }


        [TestMethod]

        public void ReportByHealthSpecialistEmailTestDataFound()
        {
            //create an intance of the filtered data
            clsHealthSpecialistCollection FilteredHealthSpecialist = new clsHealthSpecialistCollection();
            //var to store outcome
            Boolean OK = true;
            //apply the fisrtname 
            FilteredHealthSpecialist.ReportByHealthSpecialistEmail("mount3@hotmail.com");
            //check the correct the number found 
            if (FilteredHealthSpecialist.Count == 2)
            {
                //check the firsdt record is id 1
                if (FilteredHealthSpecialist.HealthSpecialistList[0].HealthSpecialistId != 4)
                {
                    OK = false;
                }
                //check the first id is 2
                if (FilteredHealthSpecialist.HealthSpecialistList[1].HealthSpecialistId != 5)
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

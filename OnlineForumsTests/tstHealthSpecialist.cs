using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineForumClasses;

///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2013

namespace OnlineForumsTests
{


    [TestClass]
    public class tstHealthSpecialist
    {
        string HealthSpecialistFirstName = "John";
        string HealthSpecialistLastName = "Smith";
        string HealthSpecialistTelephone = "01163480420";
        string HealthSpecialistEmail = "hfhggfh";
        string HealthSpecialistPassword = "Passowrd43";

        public void InstanceOk()
        {
            //create an instance of the class
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //test to see of it exists
            Assert.IsNotNull(AHealthSpecialist);
        }

        [TestMethod]
        public void HealthSpecialistId()
        {
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            Int32 TestData = 1;
            //assgn the data to the property
            AHealthSpecialist.HealthSpecialistId = TestData;
            //applythe test
            Assert.AreEqual(AHealthSpecialist.HealthSpecialistId, TestData);
        }

        [TestMethod]
        public void HealthSpecialistFirstNameOK()
        {
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create some tests data
            string TestData = "Husain";
            //assign the data to the property
            AHealthSpecialist.HealthSpecialistFirstName = TestData;
            //test tpos ee if it works
            Assert.AreEqual(AHealthSpecialist.HealthSpecialistFirstName, TestData);
        }

        [TestMethod]
        public void HealthSpecialistLastNameOK()
        {
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create some tests data
            string TestData = "Makda";
            //assign the data to the property
            AHealthSpecialist.HealthSpecialistLastName = TestData;
            //test tpos ee if it works
            Assert.AreEqual(AHealthSpecialist.HealthSpecialistLastName, TestData);
        }

        [TestMethod]
        public void HealthSpecialistTelephoneOK()
        {
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create some tests data
            string TestData = "01163480420";
            //assign the data to the property
            AHealthSpecialist.HealthSpecialistTelephone = TestData;
            //test tpos ee if it works
            Assert.AreEqual(AHealthSpecialist.HealthSpecialistTelephone, TestData);
        }

        [TestMethod]
        public void HealthSpecialistEmailOK()
        {
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create some tests data
            string TestData = "yeyeye@gmail.com";
            //assign the data to the property
            AHealthSpecialist.HealthSpecialistEmail = TestData;
            //test tpos ee if it works
            Assert.AreEqual(AHealthSpecialist.HealthSpecialistEmail, TestData);
        }

        [TestMethod]

        public void HealthSpecialistPasswordOK()
        {
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create some test data
            string TestData = "Passowrd12";
            //assign the data tot he property
            AHealthSpecialist.HealthSpecialistPassword = TestData;
            //test to see of it works
            Assert.AreEqual(AHealthSpecialist.HealthSpecialistPassword, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an intance of the class
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //create some test data to use
            Int32 HealthSpecialistId = 1;
            //invoke the method
            Found = AHealthSpecialist.Find(HealthSpecialistId);
            //test to see if the result is ok
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestHealthSpecialistIdFound()
        {
            //create an intance of the class
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 HealthSpecialistId = 1;
            //invoke the method
            Found = AHealthSpecialist.Find(HealthSpecialistId);
            //check the HealthSpecialistid
            if (AHealthSpecialist.HealthSpecialistId != 1)
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestHealthSpecialistFirstNameFound()
        {
            //create an intance of the class
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 HealthSpecialistId = 1;
            //invoke the method
            Found = AHealthSpecialist.Find(HealthSpecialistId);
            //check the HealthSpecialistid
            if (AHealthSpecialist.HealthSpecialistFirstName != "Dr Ritz")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestHealthSpecialistLastNameFound()
        {
            //create an intance of the class
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 HealthSpecialistId = 1;
            //invoke the method
            Found = AHealthSpecialist.Find(HealthSpecialistId);
            //check the HealthSpecialistid
            if (AHealthSpecialist.HealthSpecialistLastName != "Patel")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestHealthSpecialistTelephoneFound()
        {
            //create an intance of the class
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 HealthSpecialistId = 1;
            //invoke the method
            Found = AHealthSpecialist.Find(HealthSpecialistId);
            //check the HealthSpecialistid
            if (AHealthSpecialist.HealthSpecialistTelephone != "34512365")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestHealthSpecialistEmailFound()
        {
            //create an intance of the class
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 HealthSpecialistId = 1;
            //invoke the method
            Found = AHealthSpecialist.Find(HealthSpecialistId);
            //check the HealthSpecialistid
            if (AHealthSpecialist.HealthSpecialistEmail != "dr@gmail.com")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestHealthSpecialistPasswordFound()
        {
            //create an instance of the new class
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //boolan varibale to store the result 
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 HealthSpecialistId = 1;
            //invoke the method
            Found = AHealthSpecialist.Find(HealthSpecialistId);
            if (AHealthSpecialist.HealthSpecialistPassword != "blue8")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }


        //[TestMethod]

        //public void ValidMethodOk()
        //{
        //    clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
        //    //cretae a stirng variavle to store the result
        //    String Error = "";
        //    //create some test data
        //    string HealthSpecialistFirstName = "John";
        //    //invoke the method
        //    Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
        //    //test to se if its ok
        //    Assert.AreEqual(Error, "");
        //}

        [TestMethod]

        public void HealthSpecialistFirstNameMinLessOne()
        {
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            String Error = "";
            string HealthSpecialistFirstName = "a";
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void HealthSpecialistFirstNameMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string HealthSpecialistFirstName = "aa";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistFirstNameMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistFirstName = "aaa";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistFirstNameMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistFirstName = "kkkkkkkkkkkkkkkkkkkkkkkkk";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistFirstNameMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistFirstName = "oooooooooooooooooooooooooo";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistFirstNameMid()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistFirstName = "0123456789";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistFirstNameExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistFirstName = "";
            //pad the string with chracters
            HealthSpecialistFirstName = HealthSpecialistFirstName.PadRight(500, 'a');
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void HealthSpecialistLastNameMinLessOne()
        {
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            String Error = "";
            string HealthSpecialistLastName = "a";
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void HealthSpecialistLastNameMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string HealthSpecialistLastName = "aa";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistLastNameMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistLastName = "aaa";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistLastNameMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistLastName = "kkkkkkkkkkkkkkkkkkkkkkkkk";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistLastNameMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistLastName = "oooooooooooooooooooooooooo";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistLastNameMid()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistLastName = "aaaaaaaaaa";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistLastNameExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistLastName = "";
            //pad the string with chracters
            HealthSpecialistLastName = HealthSpecialistLastName.PadRight(500, 'a');
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistTelephoneMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string HealthSpecialistTelephone = "4";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistTelephoneMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistTelephone = "22";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistTelephoneNameMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistTelephone = "1234567890";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistTelephoneMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistTelephone = "01165432546464378234987654";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistTelephoneMid()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistTelephone = "0123456789";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistTelephoneExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistTelephone = "";
            //pad the string with chracters
            HealthSpecialistTelephone = HealthSpecialistTelephone.PadRight(500, 'a');
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void HealthSpecialistEmailMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string HealthSpecialistEmail = "aaaaa";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistEmailMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistEmail = "aaaaaa";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistEmailMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistEmail = "kkkkkkkkkkkkkkkkkkkkkkkk";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistEmaiMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistEmail = "llllllllllllllllllllllllllllllllllllllllllllllllll111";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistEmailMid()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistEmail = "0123456@789";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void HealthSpecialistEmailExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistEmail = "";
            //pad the string with chracters
            HealthSpecialistEmail = HealthSpecialistEmail.PadRight(500, 'a');
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistPasswordMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string HealthSpecialistPassword = "aaaaaaaa";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistPasswordMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistPassword = "aaaaaaaaa";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistPasswordMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistPassword = "kkkkkkkkkkkkkkkkkkkkkkkk";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistPasswordMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistPassword = "llllllllllllllllllllllllllllllllllllllllllllllllll111";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HealthSpecialistPasswordMid()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistPassword = "0123456i789";
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void HealthSpecialistPasswordExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsHealthSpecialist AHealthSpecialist = new clsHealthSpecialist();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string HealthSpecialistPassword = "";
            //pad the string with chracters
            HealthSpecialistPassword = HealthSpecialistPassword.PadRight(500, 'a');
            //invoke the methoid
            Error = AHealthSpecialist.Valid(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }



    }




}






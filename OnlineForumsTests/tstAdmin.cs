using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineForumClasses;

///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2013

namespace OnlineForumsTests
{


    [TestClass]
    public class tstAdmin
    {
        string AdminFirstName = "John";
        string AdminLastName = "Smith";
        string AdminTelephone = "01163480420";
        string AdminEmail = "hfhggfh";
        string AdminPassword = "Password12";

        public void InstanceOk()
        {
            //create an instance of the class
            clsAdmin AAdmin = new clsAdmin();
            //test to see of it exists
            Assert.IsNotNull(AAdmin);
        }

        [TestMethod]
        public void AdminId()
        {
            clsAdmin AAdmin = new clsAdmin();
            Int32 TestData = 1;
            //assgn the data to the property
            AAdmin.AdminId = TestData;
            //applythe test
            Assert.AreEqual(AAdmin.AdminId, TestData);
        }

        [TestMethod]
        public void AdminFirstNameOK()
        {
            clsAdmin AAdmin = new clsAdmin();
            //create some tests data
            string TestData = "Husain";
            //assign the data to the property
            AAdmin.AdminFirstName = TestData;
            //test tpos ee if it works
            Assert.AreEqual(AAdmin.AdminFirstName, TestData);
        }

        [TestMethod]
        public void AdminLastNameOK()
        {
            clsAdmin AAdmin = new clsAdmin();
            //create some tests data
            string TestData = "Makda";
            //assign the data to the property
            AAdmin.AdminLastName = TestData;
            //test tpos ee if it works
            Assert.AreEqual(AAdmin.AdminLastName, TestData);
        }

        [TestMethod]
        public void AdminTelephoneOK()
        {
            clsAdmin AAdmin = new clsAdmin();
            //create some tests data
            string TestData = "01163480420";
            //assign the data to the property
            AAdmin.AdminTelephone = TestData;
            //test tpos ee if it works
            Assert.AreEqual(AAdmin.AdminTelephone, TestData);
        }

        [TestMethod]
        public void AdminEmailOK()
        {
            clsAdmin AAdmin = new clsAdmin();
            //create some tests data
            string TestData = "yeyeye@gmail.com";
            //assign the data to the property
            AAdmin.AdminEmail = TestData;
            //test tpos ee if it works
            Assert.AreEqual(AAdmin.AdminEmail, TestData);
        }

        [TestMethod]

        public void AdminPasswordOK()
        {
            clsAdmin AAdmin = new clsAdmin();
            //create some tests data
            string TestData = "Password32";
            //assign the data to the property
            AAdmin.AdminPassword = TestData;
            //test tpos ee if it works
            Assert.AreEqual(AAdmin.AdminPassword, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an intance of the class
            clsAdmin AAdmin = new clsAdmin();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //create some test data to use
            Int32 AdminId = 2;
            //invoke the method
            Found = AAdmin.Find(AdminId);
            //test to see if the result is ok
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAdminIdFound()
        {
            //create an intance of the class
            clsAdmin AAdmin = new clsAdmin();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AdminId = 2;
            //invoke the method
            Found = AAdmin.Find(AdminId);
            //check the Adminid
            if (AAdmin.AdminId != 2)
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestAdminFirstNameFound()
        {
            //create an intance of the class
            clsAdmin AAdmin = new clsAdmin();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AdminId = 2;
            //invoke the method
            Found = AAdmin.Find(AdminId);
            //check the Adminid
            if (AAdmin.AdminFirstName != "Abdi")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestAdminLastNameFound()
        {
            //create an intance of the class
            clsAdmin AAdmin = new clsAdmin();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AdminId = 2;
            //invoke the method
            Found = AAdmin.Find(AdminId);
            //check the Adminid
            if (AAdmin.AdminLastName != "suldan")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestAdminTelephoneFound()
        {
            //create an intance of the class
            clsAdmin AAdmin = new clsAdmin();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AdminId = 2;
            //invoke the method
            Found = AAdmin.Find(AdminId);
            //check the Adminid
            if (AAdmin.AdminTelephone != "555544433")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestAdminEmailFound()
        {
            //create an intance of the class
            clsAdmin AAdmin = new clsAdmin();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AdminId = 2;
            //invoke the method
            Found = AAdmin.Find(AdminId);
            //check the Adminid
            if (AAdmin.AdminEmail != "forehead@rgmail.com")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestAdminPasswordFound()
        {
            //create an intance of the class
            clsAdmin AAdmin = new clsAdmin();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AdminId = 2;
            //invoke the method
            Found = AAdmin.Find(AdminId);
            //check the Adminid
            if (AAdmin.AdminPassword != "bigigigi")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }


        //[TestMethod]

        //public void ValidMethodOk()
        //{
        //    clsAdmin AAdmin = new clsAdmin();
        //    //cretae a stirng variavle to store the result
        //    String Error = "";
        //    //create some test data
        //    string AdminFirstName = "John";
        //    //invoke the method
        //    Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
        //    //test to se if its ok
        //    Assert.AreEqual(Error, "");
        //}

        [TestMethod]

        public void AdminFirstNameMinLessOne()
        {
            clsAdmin AAdmin = new clsAdmin();
            String Error = "";
            string AdminFirstName = "A";
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AdminFirstNameMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string AdminFirstName = "aa";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminFirstNameMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminFirstName = "aaa";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminFirstNameMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminFirstName = "kkkkkkkkkkkkkkkkkkkkkkkkk";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminFirstNameMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminFirstName = "oooooooooooooooooooooooooo";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminFirstNameMid()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminFirstName = "0123456789";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminFirstNameExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminFirstName = "";
            //pad the string with chracters
            AdminFirstName = AdminFirstName.PadRight(500, 'a');
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void AdminLastNameMinLessOne()
        {
            clsAdmin AAdmin = new clsAdmin();
            String Error = "";
            string AdminLastName = "a";
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AdminLastNameMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "aa";
            //create some test dat
            string AdminLastName = "aa";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminLastNameMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminLastName = "aaa";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminLastNameMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminLastName = "kkkkkkkkkkkkkkkkkkkkkkkkk";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminLastNameMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminLastName = "oooooooooooooooooooooooooo";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminLastNameMid()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminLastName = "0123456789";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminLastNameExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminLastName = "";
            //pad the string with chracters
            AdminLastName = AdminLastName.PadRight(500, 'a');
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminTelephoneMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string AdminTelephone = "4";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminTelephoneMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminTelephone = "22";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminTelephoneNameMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminTelephone = "1234567890";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminTelephoneMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminTelephone = "012345678901";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminTelephoneMid()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminTelephone = "0123456789";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminTelephoneExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminTelephone = "";
            //pad the string with chracters
            AdminTelephone = AdminTelephone.PadRight(500, 'a');
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AdminEmailMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string AdminEmail = "aaaaa";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminEmailMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminEmail = "aaaaaa";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminEmailMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminEmail = "kkkkkkkkkkkkkkkkkkkkkkkk";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminEmaiMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminEmail = "llllllllllllllllllllllllllllllllllllllllllllllllll111";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminEmailMid()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminEmail = "0123456@789";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AdminEmailExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminEmail = "";
            //pad the string with chracters
            AdminEmail = AdminEmail.PadRight(500, 'a');
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AdminPasswordMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string AdminPassword = "aaaaaaaa";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminPasswordMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminPassword = "aaaaaaaaa";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminPasswordMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminPassword = "kkkkkkkkkkkkkkkkkkkkkkkk";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminPasswordMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminPassword = "llllllllllllllllllllllllllllllllllllllllllllllllll111";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AdminPasswordMid()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminPassword = "0123456i789";
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AdminPasswordExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsAdmin AAdmin = new clsAdmin();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string AdminPassword = "";
            //pad the string with chracters
            AdminPassword = AdminPassword.PadRight(500, 'a');
            //invoke the methoid
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }



    }
}

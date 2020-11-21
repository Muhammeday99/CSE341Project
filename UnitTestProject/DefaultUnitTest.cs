using Microsoft.VisualStudio.TestTools.UnitTesting;
using projedeneme2;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class DefaultUnitTest
    {
        [TestMethod]
        public void TestIsValidLogin1()
        {
            //This test is made for checking our login, for our base user: Admin.

            Default testPart = new Default();
            Assert.IsTrue(testPart.IsValidLogin("testadmin@email.com", "unittest"));
        }

        [TestMethod]
        public void TestIsValidLogin2()
        {
            //This test is made for checking our login, for our base user: User.

            Default testPart = new Default();
            Assert.IsTrue(testPart.IsValidLogin("testuser@email.com", "unittest"));
        }

        /*********************************************/

        [TestMethod]
        public void TestcheckUser1()
        {
            //This test is made for checking our checkUser(), for our base user: Admin.

            Default testPart = new Default();
            Assert.IsTrue(testPart.checkUser("testadmin@email.com", "unittest"));
        }

        [TestMethod]
        public void TestcheckUser2()
        {
            //This test is made for checking our checkUser(), for our base user: User.

            Default testPart = new Default();
            Assert.IsFalse(testPart.checkUser("testuser@email.com", "unittest"));
        }
    }
}

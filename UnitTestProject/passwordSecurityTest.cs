using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using projedeneme2.InputControllers;

using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;


namespace UnitTestProject
{
    [TestClass]
    public class passwordSecurityTest
    {

        //They are protected functions, as they should be. Since its
        //their final form, i will be copying the code for direct test.
        [TestMethod]
        public void passwordSecurity_Test1()
        {
            encryption testPart = new encryption();
            string result = encryption.EnryptString("123321");
            Assert.AreEqual("MTIzMzIx", result);
            
        }
           //DecryptStingTesting Fail
        [TestMethod]
        public void passwordSecurity_Test2()
        {
            encryption testPart = new encryption();
            string result = encryption.DecryptString("MTIzMzIx");
            Assert.AreEqual("123321", result);

        }

    }
}

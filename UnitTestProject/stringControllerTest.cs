using Microsoft.VisualStudio.TestTools.UnitTesting;
using projedeneme2.InputControllers;
using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class stringControllerTest
    {

        [TestMethod]
        public void listStringController_Test1()
        {
            List<string> inputs = new List<string>();
            inputs.Add("string1");
            inputs.Add("string2");
            inputs.Add("string3");
            inputs.Add("string4");

            Assert.IsTrue(stringController.listStringController(inputs));
        }

        [TestMethod]
        public void listStringController_Test2()
        {
            List<string> inputs = new List<string>();
            inputs.Add("string1");
            inputs.Add("string2");
            inputs.Add("s");
            inputs.Add("string4");

            Assert.IsFalse(stringController.listStringController(inputs));
        }


        [TestMethod]
        public void singleStringController_Test1()
        {
            Assert.IsTrue(stringController.singleStringController("longstring"));
        }

        [TestMethod]
        public void singleStringController_Test2()
        {
            Assert.IsFalse(stringController.singleStringController("s"));
        }

        [TestMethod]
        public void passwordSecurity_Test1()
        {
            Assert.AreEqual(stringController.passwordSecurity("Password"), stringController.passwordSecurity("pa2ssword"));
        }
    }
}

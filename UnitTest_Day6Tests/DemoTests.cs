using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest_Day6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Day6.Tests
{
    [TestClass]
    public class DemoTests
    {
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            Console.WriteLine(string.Format("{0} - ClassInitialize", Demo.Get()));
            Demo.Now += 1;
        }

        [TestInitialize]
        public void TestInit()
        {
            Console.WriteLine(string.Format("{0} - TestInitialize", Demo.Get()));
            Demo.Now += 1;
        }

        [TestMethod]
        public void GetTest()
        {
            Console.WriteLine(string.Format("{0} - Test1", Demo.Get()));
            Demo.Now += 1;
        }

        [TestMethod]
        public void GetTest2()
        {
            Console.WriteLine(string.Format("{0} - Test2", Demo.Get()));
            Demo.Now += 1;
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            Console.WriteLine(string.Format("{0} - TestCleanup", Demo.Get()));
            Demo.Now += 1;
        }

        [ClassCleanup]
        public static void ClassCleanUp()
        {
            Console.WriteLine(string.Format("{0} - ClassCleanup", Demo.Get()));
            Demo.Now += 1;
        }
    }
}
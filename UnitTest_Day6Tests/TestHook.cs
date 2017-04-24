using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest_Day6;
using System.Diagnostics;

namespace UnitTest_Day6Tests
{
    [TestClass]
    public class TestHook
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            Console.WriteLine(string.Format("{0} - AssemblyInitialize", Demo.Get()));
            Demo.Now += 1;
        }

        [AssemblyCleanup]
        public static void AssemblyCleanUp()
        {
            Console.WriteLine(string.Format("{0} - AssemblyCleanup", Demo.Get()));
            Demo.Now += 1;
        }
    }
}

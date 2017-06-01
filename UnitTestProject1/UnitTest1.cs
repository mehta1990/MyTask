using System;
using System.IO;
using System.Collections;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string line;
            int counter = 0;
            Testnames.Sorting.sortFile(@"names.txt");
            System.IO.StreamReader file = new System.IO.StreamReader(@"names.txt");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine();
                counter++;

            }
            file.Close();
            System.Diagnostics.Debug.WriteLine("This is the output");
            Console.ReadLine();

        }

    }
}

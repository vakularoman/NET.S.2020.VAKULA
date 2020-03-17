using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace FilterDigit.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> input = new List<int>() { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            List<int> result = new List<int>() { 7, 70, 17 };

            NumberSort.FilterDigit(input);

            for (int i = 0;i <result.Count;i++)
                Assert.AreEqual(input[i], result[i]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNull()
        {
            List<int> input = null;
            NumberSort.FilterDigit(input);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyArgument()
        {
            List<int> input = new List<int>{ };
            NumberSort.FilterDigit(input);
        }


    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InsertNumber.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SuccsesfullTests()
        {
            Assert.AreEqual(BitInsert.InsertNumber(15, 15, 0, 0), 15);
            Assert.AreEqual(BitInsert.InsertNumber(8, 15, 3, 8), 120);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WrongArgument()
        {
            BitInsert.InsertNumber(15, 15, 0, 32);
        }

    }
}

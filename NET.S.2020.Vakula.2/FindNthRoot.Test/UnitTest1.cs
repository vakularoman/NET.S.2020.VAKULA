using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindNthRoot;
using System;

namespace FindNthRoot.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SuccsesfullTests()
        {
            Assert.AreEqual(NewtonRoot.FindNthRoot(1, 5, 0.0001), 1);
            Assert.AreEqual(NewtonRoot.FindNthRoot(8, 3, 0.0001), 2);
            Assert.AreEqual(NewtonRoot.FindNthRoot(0.001, 3, 0.0001), 0.1);
            Assert.AreEqual(NewtonRoot.FindNthRoot(0.04100625, 4, 0.0001), 0.45);
            Assert.AreEqual(NewtonRoot.FindNthRoot(0.0279936, 7, 0.0001), 0.6);
            Assert.AreEqual(NewtonRoot.FindNthRoot(0.0081, 4, 0.1), 0.3);
            Assert.AreEqual(NewtonRoot.FindNthRoot(-0.008, 3, 0.1), -0.2);
            Assert.AreEqual(NewtonRoot.FindNthRoot(0.004241979, 9, 0.00000001), 0.545);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeArgument()
        {
            NewtonRoot.FindNthRoot(0.0279936, -3,-4);
        }

    }
}

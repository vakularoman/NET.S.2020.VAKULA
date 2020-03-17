using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FindNextBiggerNumber.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SuccsesfullTests()
        {
            Assert.AreEqual(BiggerNumber.FindNextBiggerNumber(12).Item1, 21);
            Assert.AreEqual(BiggerNumber.FindNextBiggerNumber(513).Item1, 531);
            Assert.AreEqual(BiggerNumber.FindNextBiggerNumber(2017).Item1, 2071);
            Assert.AreEqual(BiggerNumber.FindNextBiggerNumber(414).Item1, 441);
            Assert.AreEqual(BiggerNumber.FindNextBiggerNumber(144).Item1, 414);
            Assert.AreEqual(BiggerNumber.FindNextBiggerNumber(1234321).Item1, 1241233);
            Assert.AreEqual(BiggerNumber.FindNextBiggerNumber(1234126).Item1, 1234162);
            Assert.AreEqual(BiggerNumber.FindNextBiggerNumber(3456432).Item1, 3462345);

        }
        [TestMethod]
        public void UnsuccsesfullTests()
        {
            Assert.AreEqual(BiggerNumber.FindNextBiggerNumber(10).Item1, -1);
            Assert.AreEqual(BiggerNumber.FindNextBiggerNumber(20).Item1, -1);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeArgument()
        {
            BiggerNumber.FindNextBiggerNumber(-10) ;
        }
    }
}

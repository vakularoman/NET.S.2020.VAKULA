using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using GCD;

namespace GCD.Tests
{
    [TestClass]
    public class GCDTests
    {

        [TestMethod]
        public void EuclidPositiveNumbersCorrectResult()
        {
            List<int> input = new List<int> { 252,444,1080,876 };
            Assert.AreEqual(GCD.Euclid(input,out _) ,12);
        }

        [TestMethod]
        public void EuclidListConsistZeroCorrectResult()
        {
            List<int> input = new List<int> { 252, 444, 1080, 876, 0 };
            Assert.AreEqual(GCD.Euclid(input, out _), 12);
        }

        [TestMethod]
        public void EuclidListNegativeAndPositiveNumbersCorrectResult()
        {
            List<int> input = new List<int> { 252, -444, -1080, 876};
            Assert.AreEqual(GCD.Euclid(input, out _), 12);
        }

        [TestMethod]
        public void EuclidTimerMoreThanZero()
        {
            List<int> input = new List<int> { 252, -444, -1080, 876 };
            GCD.Euclid(input, out double x);

            Assert.IsTrue(x > 0);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EuclidArgumentNullException()
        {
            List<int> input = null;
            GCD.Euclid(input,out _ );
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EuclidListLengthLessThanTwoArgumentException()
        {
            List<int> input = new List<int> {2 };
            GCD.Euclid(input, out _);
        }

        //------------------- Stain Tests

        [TestMethod]
        public void StainPositiveNumbersCorrectResult()
        {
            List<int> input = new List<int> { 252, 444, 1080, 876 };
            Assert.AreEqual(GCD.Stain(input, out _), 12);
        }

        [TestMethod]
        public void StainListConsistZeroCorrectResult()
        {
            List<int> input = new List<int> { 252, 444, 1080, 876, 0 };
            Assert.AreEqual(GCD.Stain(input, out _), 12);
        }

        [TestMethod]
        public void StainListNegativeAndPositiveNumbersCorrectResult()
        {
            List<int> input = new List<int> { 252, -444, -1080, 876 };
            Assert.AreEqual(GCD.Stain(input, out _), 12);
        }

        [TestMethod]
        public void StainTimerMoreThanZero()
        {
            List<int> input = new List<int> { 252, -444, -1080, 876 };
            GCD.Stain(input, out double x);

            Assert.IsTrue(x > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StaindArgumentNullException()
        {
            List<int> input = null;
            GCD.Stain(input, out _);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StainListLengthLessThanTwoArgumentException()
        {
            List<int> input = new List<int> { 2 };
            GCD.Stain(input, out _);
        }

    }
}

using NUnit.Framework;
using System;
using P = NET.S._2020.Vakula._6;

namespace Polynomial.Tests
{
    [TestFixture]
    public class PolymonialTests 
    {
        /// <summary>
        /// Testing object override methods
        /// </summary>

        [TestCase(new double[] { 3.3, 5, 2, -3, 0, 21.6 }, "3.3 + 5x^1 + 2x^2 - 3x^3 + 21.6x^5")]
        [TestCase(new double[] { 0, 0, 0, 0, 0, -1.13 }, " - 1.13x^5")]

        [Test]
        public void ToStringCoefCorrectAns(double[] arr, string result)
        {
            Assert.AreEqual(new P.Polynomial(arr).ToString(), result);
        }

        [TestCase(new double[] { 3, 5, 2, -3, 0, 21 }, new double[] { 0, 0, 0, 0, 0, 21 })]

        [Test]
        public void GetHashCodeDifferentCoefNotEqual(double[] arr1, double[] arr2)
        {
            Assert.AreNotEqual(new P.Polynomial(arr1).GetHashCode(),
                new P.Polynomial(arr2).GetHashCode());
        }

        [TestCase(new double[] { 3, 5, 2, -3, 0, 21 }, new double[] { 3, 5, 2, -3, 0, 21 })]

        [Test]
        public void GetHashCodeSameCoefEqual(double[] arr1, double[] arr2)
        {
            Assert.AreEqual(new P.Polynomial(arr1).GetHashCode(),
                new P.Polynomial(arr2).GetHashCode());
        }

        [TestCase(new double[] { 3, 5, 2, -3, 0, 21 }, new double[] { 3, 5, 2, -3, 0, 21 })]
        [TestCase(new double[] { 0, 0, 0, 0, 0, 0 }, new double[] { 0, 0, 0, 0, 0, 0 })]

        [Test]
        public void EquialSameCoefTrue(double[] arr1, double[] arr2)
        {
            P.Polynomial poly1 = new P.Polynomial(arr1);
            P.Polynomial poly2 = new P.Polynomial(arr2);
            Assert.IsTrue(poly1.Equals(poly2));
        }

        [TestCase(new double[] { 3, 5, 2, -3, 0, 21 }, new double[] { 1, 4 })]
        [TestCase(new double[] { 0, 0, 0, 0, 0, 0 }, new double[] { 0, 0, 0, 1, 0, 0 })]

        [Test]
        public void EquialDiffCoefFalse(double[] arr1, double[] arr2)
        {
            P.Polynomial poly1 = new P.Polynomial(arr1);
            P.Polynomial poly2 = new P.Polynomial(arr2);
            Assert.IsFalse(poly1.Equals(poly2));
        }

        /// <summary>
        ///  Testing + - * overrids
        /// </summary>

        [TestCase(new double[] { 3, 5, 2, -3, 0 }, new double[] { 1, 4 },
            new double[] { 4, 9, 2, -3, 0 })]

        [TestCase(new double[] { 1.3, 4.5, 5.3, 0 }, new double[] { 0, 0.3, 1, 2 },
            new double[] { 1.3, 4.8, 6.3, 2 })]


        [Test]
        public void PlusOverrideDefaultNumbCorrect(double[] arr1, double[] arr2, double[] result)
        {
            P.Polynomial poly1 = new P.Polynomial(arr1);
            P.Polynomial poly2 = new P.Polynomial(arr2);
            Assert.AreEqual((poly1 + poly2).Coef, result);
        }

        [TestCase(new double[] { 3, 5, 2, -3, 0 }, new double[] { 1, 4 },
            new double[] { 2, 1, 2, -3, 0 })]
        [TestCase(new double[] { 1.3, 4.5, 5.3, 0 }, new double[] { 0, -0.3, 1, 2 },
            new double[] { 1.3, 4.8, 4.3, -2 })]

        [Test]
        public void MinusOverrideDefaultNumbCorrect(double[] arr1, double[] arr2, double[] result)
        {
            P.Polynomial poly1 = new P.Polynomial(arr1);
            P.Polynomial poly2 = new P.Polynomial(arr2);
            Assert.AreEqual((poly1 - poly2).Coef, result);
        }

        [TestCase(new double[] { 5, 4, 3 }, new double[] { 1, 6, 5, 2 },
           new double[] { 5, 34, 52, 48, 23, 6 })]
        [TestCase(new double[] { 0, -2, 6, 0, 3 }, new double[] { 12, 0, -4, 3 },
           new double[] { 0, -24, 72, 8, 6, 18, -12, 9 })]

        [Test]
        public void MultiplyOverrideDefaultNumbCorrect(double[] arr1, double[] arr2, double[] result)
        {
            P.Polynomial poly1 = new P.Polynomial(arr1);
            P.Polynomial poly2 = new P.Polynomial(arr2);
            Assert.AreEqual(result, (poly1 * poly2).Coef);
        }

        /// <summary>
        /// Testing override == !=
        /// </summary>

        [TestCase(new double[] { 3, 5, 2, -3, 0, 21 }, new double[] { 3, 5, 2, -3, 0, 21 })]
        [TestCase(new double[] { 0, 0, 0, 0, 0, 0 }, new double[] { 0, 0, 0, 0, 0, 0 })]

        [Test]
        public void EquialSignSameCoefTrue(double[] arr1, double[] arr2)
        {
            Assert.IsTrue((new P.Polynomial(arr2)) == (new P.Polynomial(arr1)));

        }

        [TestCase(new double[] { 3, 5, 2, -3, 0, 2 }, new double[] { 3, 5, 2, -3, 0, 21 })]
        [TestCase(new double[] { 0, 0, 0, 0, 0, 0 }, new double[] { 0, 0, 0, 0, 0 })]

        [Test]
        public void EquialSignDiffCoefFalse(double[] arr1, double[] arr2)
        {
            Assert.IsFalse((new P.Polynomial(arr2)) == (new P.Polynomial(arr1)));

        }

        [TestCase(new double[] { 3, 5, 2, -3, 0, 2 }, new double[] { 3, 5, 2, -3, 0, 21 })]
        [TestCase(new double[] { 0, 0, 0, 0, 0, 0 }, new double[] { 0, 0, 0, 0, 0 })]

        public void NotEquialSignSameCoefTrue(double[] arr1, double[] arr2)
        {
            Assert.IsTrue((new P.Polynomial(arr2)) != (new P.Polynomial(arr1)));

        }

        [TestCase(new double[] { 3, 5, 2, -3, 0, 21 }, new double[] { 3, 5, 2, -3, 0, 21 })]
        [TestCase(new double[] { 0, 0, 0, 0, 0, 0 }, new double[] { 0, 0, 0, 0, 0, 0 })]

        [Test]
        public void NotEquialSignDiffCoefFalse(double[] arr1, double[] arr2)
        {
            Assert.IsFalse((new P.Polynomial(arr2)) != (new P.Polynomial(arr1)));

        }
        /// <summary>
        /// Exceptions tests
        /// </summary>

        [Test]
        public void ObjectMethodsWrongDataullReferenceException()
        {
            P.Polynomial p = null;

            Assert.Throws<NullReferenceException>(() => p.ToString());
            Assert.Throws<NullReferenceException>(() => p.GetHashCode());
            Assert.Throws<NullReferenceException>(() => p.Equals(13));

            P.Polynomial p2 = new P.Polynomial(new double[] { 3,4});
            Assert.Throws<NullReferenceException>(() => p2.Equals(null));

        }


        [Test]
        public void ExpectedExceptionTest()
        {
            P.Polynomial p2 = new P.Polynomial(new double[] { 3, 4 });
            P.Polynomial p1 = null;
            Assert.Throws<NullReferenceException>(delegate ()
            {
                P.Polynomial p3 = p1 + p2;
            });
            Assert.Throws<NullReferenceException>(delegate ()
            {
                P.Polynomial p3 = p1 - p2;
            });
            Assert.Throws<NullReferenceException>(delegate ()
            {
                P.Polynomial p3 = p1 * p2;
            });
        }

    }
}
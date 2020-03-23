using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomConverter;

namespace CustomConverter.Tests
{
    [TestClass]
    public class CustomConverterTests
    {
        [TestMethod]
        public void BinaryConvertShortNumbersCorrectResult()
        {
            double input = 255.255;
            string result = "0100000001101111111010000010100011110101110000101000111101011100";
            Assert.AreEqual(input.BinaryConvert(),result);

            input =  -255.255;
            result = "1100000001101111111010000010100011110101110000101000111101011100";
            Assert.AreEqual(input.BinaryConvert(), result);
        }

        [TestMethod]
        public void BinaryConvertBigNumbersCorrectResult()
        {
            double input = 4294967295.0;
            string result = "0100000111101111111111111111111111111111111000000000000000000000";
            Assert.AreEqual(input.BinaryConvert(), result);

            input = double.MinValue;
            result = "1111111111101111111111111111111111111111111111111111111111111111";
            Assert.AreEqual(input.BinaryConvert(), result);

            input = double.MaxValue;
            result = "0111111111101111111111111111111111111111111111111111111111111111";
            Assert.AreEqual(input.BinaryConvert(), result);
        }

        [TestMethod]
        public void BinaryConvertSmallNumbersCorrectResult()
        {
            double input = double.Epsilon;
            string result = "0000000000000000000000000000000000000000000000000000000000000001";
            Assert.AreEqual(input.BinaryConvert(), result);

        }

        [TestMethod]
        public void BinaryConvertNanandInfinityCorrectResult()
        {
            double input = double.NaN;
            string result = "1111111111111000000000000000000000000000000000000000000000000000";
            Assert.AreEqual(input.BinaryConvert(), result);

            input = double.NegativeInfinity;
            result = "1111111111110000000000000000000000000000000000000000000000000000";
            Assert.AreEqual(input.BinaryConvert(), result);

            input = double.PositiveInfinity;
            result = "0111111111110000000000000000000000000000000000000000000000000000";
            Assert.AreEqual(input.BinaryConvert(), result);
        }

        [TestMethod]
        public void BinaryConvertZeroCorrectResult()
        {
            double input = -0.0;
            string result = "1000000000000000000000000000000000000000000000000000000000000000";
            Assert.AreEqual(input.BinaryConvert(), result);

            input = 0.0;
            result = "0000000000000000000000000000000000000000000000000000000000000000";
            Assert.AreEqual(input.BinaryConvert(), result);
        }

    }
}

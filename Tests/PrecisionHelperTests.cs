using NUnit.Framework;
using V;

namespace Tests
{
    public class PrecisionHelperTests
    {
        [Test]
        [TestCase(0d, 0)]
        [TestCase(0.1d, 1)]
        [TestCase(0.01d, 2)]
        [TestCase(0.001d, 3)]
        [TestCase(0.0001d, 4)]
        [TestCase(0.00001d, 5)]
        [TestCase(0.000001d, 6)]
        [TestCase(0.0000001d, 7)]
        [TestCase(0.00000001d, 8)]
        [TestCase(0.000000001d, 9)]
        public void Test1(double value, int expectedNumbers)
        {
            //Act
            var result = PrecisionHelper.NumbersAfterDot(value);
            //Assert
            Assert.AreEqual(expectedNumbers, result);
        }

        [Test]
        [TestCase(0d, 0)]
        [TestCase(0.1d, 1)]
        [TestCase(0.01d, 2)]
        [TestCase(0.001d, 3)]
        [TestCase(0.0001d, 4)]
        [TestCase(0.00001d, 5)]
        [TestCase(0.000001d, 6)]
        [TestCase(0.0000001d, 7)]
        [TestCase(0.00000001d, 8)]
        [TestCase(0.000000001d, 9)]
        public void Test2(decimal value, int expectedNumbers)
        {
            //Act
            var result = PrecisionHelper.NumbersAfterDot(value);
            //Assert
            Assert.AreEqual(expectedNumbers, result);
        }

        [Test]
        [TestCase(0f, 0)]
        [TestCase(0.1f, 1)]
        [TestCase(0.01f, 2)]
        [TestCase(0.001f, 3)]
        [TestCase(0.0001f, 4)]
        [TestCase(0.00001f, 5)]
        [TestCase(0.000001f, 6)]
        [TestCase(0.0000001f, 7)]
        [TestCase(0.00000001f, 8)]
        [TestCase(0.000000001f, 9)]
        public void Test3(float value, int expectedNumbers)
        {
            //Act
            var result = PrecisionHelper.NumbersAfterDot(value);
            //Assert
            Assert.AreEqual(expectedNumbers, result);
        }
    }
}
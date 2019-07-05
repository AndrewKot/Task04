using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumericalMathMethods.Tests
{
    [TestClass]
    public class NumericalMathMethodsTests
    {
        [TestMethod]
        public void GetRootOfValue1000_10Returned()
        {
            // arrange
            double value = 1000d;
            float degree = 3f;
            double accuracy = 0.01d;
            double initialValue = 0.0001d;

            double expected = 10d;

            // act
            double actual = FindRootOfValue.GetRootOfValue(value, degree, accuracy, initialValue);

            // assert
            Assert.AreEqual(expected, actual, accuracy);
        }

        [TestMethod]
        //[ExpectedException]
        public void NullUserIdInConstructor()
        {
            // arrange
            double value = 1000d;
            float degree = 3f;
            double accuracy = 0.01d;
            double initialValue = 0d;

            double actual = FindRootOfValue.GetRootOfValue(value, degree, accuracy, initialValue);
        }
    }
}

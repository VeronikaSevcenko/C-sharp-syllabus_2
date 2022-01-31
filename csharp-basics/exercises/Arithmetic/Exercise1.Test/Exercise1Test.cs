using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise1.Test
{
    [TestClass]
    public class Exercise1Test
    {
        [DataTestMethod]
        [DataRow(12, 3, true)]
        [DataRow(10, 5, true)]
        [DataRow(15, 0, true)]
        [DataRow(25, 10, true)]
        [DataRow(6, 9, true)]
        public void TwoIntegersTheEitheroneIs15orSumOrDifferenceIs15_Numbers_ReturnTrue(int a, int b, bool expected)
        {
            //Act
            bool result = Exercise_1.CheckNumbers.TwoIntegers(a, b);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}

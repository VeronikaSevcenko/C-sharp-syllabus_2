using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckOddEven.Test
{
    [TestClass]
    public class CheckOddEvenTest
    {
        [DataTestMethod]
        [DataRow(8, false)]
        [DataRow(2, false)]
        [DataRow(1, true)]
        [DataRow(7, true)]
        [DataRow(88, false)]
        public void TheNumberIsOddOrNoup_Number_returnFalseOrTrue(int a, bool expected)
        {
            //Act
            bool result = Exercise_2.CheckOddNumber.OddNumber(a);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}

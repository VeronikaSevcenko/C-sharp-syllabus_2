using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise_6.Test
{
    [TestClass]
    public class CozaLozaWozaTest
    {
        private CozaLozaWoza _target;

        [TestMethod]
        public void NumberDivededByThree_Result_PrintLoza()
        {
            //Arrange
            _target = new CozaLozaWoza();
            var name = "Loza";
            var DividedByThree = "9";

            //Act
            var result = _target.GetCozaLozaWoza();

            //Assert
            StringAssert.Contains(name, result);
            Assert.AreEqual(DividedByThree, result);
            
        }
    }
}

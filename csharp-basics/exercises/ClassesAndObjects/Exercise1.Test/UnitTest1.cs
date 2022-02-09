using Exercise_1;
using NUnit.Framework;

namespace Exercise.Test
{
    public class Exercise1Test
    {
        [Test]
        public void ChangeBiggCount_Iphone5SPrice999Dot99Amount3_Result5()
        {
            //Arrange
            Product product2 = new Product("iPhone 5s", 999.99, 3);

            //Act
            double result = product2.ChangeBiggCount(2);

            //Assert
            Assert.AreEqual(5, result);

        }

        [Test]
        public void ChangeSmallCount_Iphone5SPrice999Dot99Amount3_Result1()
        {
            //Arrange
            Product product2 = new Product("iPhone 5s", 999.99, 3);

            //Act
            double result = product2.ChangeSmallCount(2);

            //Assert
            Assert.AreEqual(1, result);

        }

        [Test]
        public void InformationAboutSecondProduct_Iphone5SPrice999Dot99Amount3_ResultInfo()
        {
            //Arrange
            Product product2 = new Product("iPhone 5s", 999.99, 3);

            //Act
            string result = product2.PrintProduct();

            //Assert
            Assert.AreEqual("iPhone 5s, 999.99, 3", result);

        }
    }
}
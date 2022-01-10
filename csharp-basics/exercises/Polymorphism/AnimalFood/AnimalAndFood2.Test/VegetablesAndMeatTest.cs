using NUnit.Framework;
using Animals_and_Food;

namespace AnimalAndFood2.Test
{
    public class Tests
    {
        [Test]
        public void DisplayFood_Vegetable_ResultVegetable()
        {
            //Arrange
            Vegetable vegetable = new Vegetable(2);

            //Act
            string result = vegetable.ToString();

            //Assert
            Assert.AreEqual("Vegetable", result);
        }

        [Test]
        public void DisplayFood_Meat_ResultMeat()
        {
            //Arrange
            Meat vegetable = new Meat(4);

            //Act
            string result = vegetable.ToString();

            //Assert
            Assert.AreEqual("Meat", result);
        }
    }
}
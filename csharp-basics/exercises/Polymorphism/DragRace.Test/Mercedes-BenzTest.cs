using NUnit.Framework;

namespace DragRace.Test
{
    public class Test
    {
        [Test]
        public void SpeedUp_MercedesBenz30_Result30()
        {
            //Arrange
            ICar car = new Mercedes_Benz();

            //Act
            var result = car.SpeedUp();

            //Assert
            Assert.AreEqual(30, result);
        }

        [Test]
        public void SlowDown_MercedesBenz40_ResultMinus40()
        {
            //Arrange
            Mercedes_Benz car = new Mercedes_Benz();

            //Act
            var result = car.SlowDown();

            //Assert
            Assert.AreEqual(-40, result);
        }

        [Test]
        public void StartEngine_MercedesBenz_ResultLogoMercedesBenz()
        {
            //Arrange
            Mercedes_Benz car = new Mercedes_Benz();

            //Act
            string result = car.StartEngine();

            //Assert
            Assert.AreEqual("The Best or Nothing", result);
        }

        [Test]
        public void ShowCurrentSpeed_MercedesBenzSpeedZero_ResultZero()
        {
            //Arrange
            Mercedes_Benz car = new Mercedes_Benz();

            //Act
            string result = car.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("0", result);
        }
    }
}
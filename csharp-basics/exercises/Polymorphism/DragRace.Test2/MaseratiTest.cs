using NUnit.Framework;

namespace DragRace.Test2
{
    public class Tests
    {
        [Test]
        public void SpeedUp_Maserati50_Result50()
        {
            //Arrange
            Maserati masina = new Maserati();

            //Act
            var result = masina.SpeedUp();

            //Assert
            Assert.AreEqual(50, result);
        }

        [Test]
        public void SlowDown_MaseratiMinus50_ResultMinus50()
        {
            //Arrange
            Maserati masina = new Maserati();

            //Act
            var result = masina.SlowDown();

            //Assert
            Assert.AreEqual(-50, result);
        }

        [Test]
        public void StartEngine_Maserati_ResultVoiceMaserati()
        {
            //Arrange
            Maserati masina = new Maserati();

            //Act
            string result = masina.StartEngine();

            //Assert
            Assert.AreEqual("Run run run ", result);
        }

        [Test]
        public void ShowCurrentSpeed_MaseratiSpeedZero_ResultZero()
        {
            //Arrange
            Maserati masina = new Maserati();

            //Act
            string result = masina.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("0", result);
        }

        [Test]
        public void UseNitrousOxideEngine_Maserati_Result100()
        {
            //Arrange
            Maserati masina = new Maserati();

            //Act
            var result = masina.UseNitrousOxideEngine();

            //Assert
            Assert.AreEqual(100, result);
        }
    }
}
    

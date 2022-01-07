using NUnit.Framework;

namespace GravityCalculator.Test
{
    public class GravityCalculator
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NeedCheckFinalPositionFallingTimeIsTenInitialVelocityAndInitialPositionIsZero_Result490()
        {
            //Arrange
            var fallingTime = 10.0;
            var initialVelocity = 0.0;
            var initialPosition = 0.0;

            //Act
            var result = CheckGravityCalculator.GetTestGravity(initialVelocity, initialPosition, fallingTime);

            //Assert.Pass();
            Assert.AreEqual(-490.5, result);
        }
    }
}
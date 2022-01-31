using NUnit.Framework;

namespace CalculateArea.Test
{
    public class GeometryTest
    {
        [Test]
        public void AreaOfCircle_RadiusIs3_Result28dot3()
        {
            //Arrange
            int radius = 3;
            double result = 28.27d;

            //Act
            double p = Geometry.AreaOfCircle(radius);

            //Assert
            Assert.AreEqual(p, result);
        }

        [Test]
        public void AreaOfRectangle_TheLengthIs8TheWidthIs2_Result16()
        {
            //Arrange
            int length = 8;
            int width = 2;

            //Act
            double result = Geometry.AreaOfRectangle(length, width);

            //Assert
            Assert.AreEqual(16, result);
        }

        [Test]
        public void AreaOfTriangle_TheGroundIs8AndHIs4_Result16()
        {
            //Arrange
            int ground = 8;
            int h = 4;

            //Act
            double result = Geometry.AreaOfTriangle(ground, h);

            //Assert
            Assert.AreEqual(16, result);
        }
    }
}
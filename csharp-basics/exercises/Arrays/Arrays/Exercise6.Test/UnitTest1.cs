using Exercise_6;
using NUnit.Framework;

namespace Exercise6.Test
{
    public class Test
    {
        [Test]
        public void CheckLastNumberFirstAndSecondArray_ArrayLengthFrom1To100_ResultTrue()
        {
            //Arrange
            int min = 1;
            int max = 100;
            int[] array1 = new int[10];
            int[] array2 = new int[10];

            //Act
            LastNumbers.ChangeLastNumber( min, max, array1, array2);

            //Assert
            Assert.AreEqual(array1[array1.Length - 1], -7);
        }

        [Test]
        public void ChangeLastNumber_ArrayLengthFrom1To100_ResultTrue()
        {
            //Arrange
            int min = 1;
            int max = 100;
            int[] array1 = new int[10];
            int[] array2 = new int[10];

            //Act
            LastNumbers.ChangeLastNumber(min, max, array1, array2);

            //Assert
            for (int i = 0; i < array1.Length - 1; i++)

                Assert.AreEqual(array1[i], array2[i]);
        }
    }
}
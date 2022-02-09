using NUnit.Framework;
using Exercise_5;

namespace Exercise5.Test
{
    public class Exercise5Tests
    {
        [Test]
        public void DisplayInformation_Day28Month1Year2020_ResultMonth1()
        {
            //Arrange
            Date date = new Date(28, 1, 2020);

            //Act
            int result = date.GetMothDate(1);

            //Assert
            Assert.AreEqual(1, result);  
        }

        [Test]
        public void DisplayInformation_Day28Month1Year2020_ResultDay28()
        {
            //Arrange
            Date month = new Date(28, 1, 2020);

            //Act
            int result = month.GetDayDate(28);

            //Assert
            Assert.AreEqual(28, result);
        }

        [Test]
        public void DisplayInformation_Day28Month1Year2020_ResultYear2020()
        {
            //Arrange
            Date year = new Date(28, 1, 2020);

            //Act
            int result = year.GetYearDate(2020);

            //Assert
            Assert.AreEqual(2020, result);
        }

        [Test]
        public void DisplayInformation_Day28Month1Year2020_ResultAll()
        {
            //Arrange
            Date dayMonthYear = new Date(28, 1, 2020);

            //Act
            string result = dayMonthYear.DisplayDate();

            //Assert
            Assert.AreEqual(28, 1, 2020, result);
        }
    }
}
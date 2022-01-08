using NUnit.Framework;
using System.Collections.Generic;

namespace FlightPlanner.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckTripFromAnchorage_City_ResultAvaliable()
        {
            //Arrange
            string city = "Anchorage";
            List<string> cities = new List<string>() { "New York", "San Francisco", "Anchorage" };

            //Act
            var result = FligthPlannerProgram.Trip(city, cities);

            //Assert
            Assert.AreEqual("You can fly from Anchorage to New York or San Jose", result);
        }

        [Test]
        public void CheckTripFromNewYork_City_ResultAvaliable()
        {
            //Arrange
            string city = "New York";
            List<string> cities = new List<string>() { "New York", "San Francisco", "Anchorage" };

            //Act
            var result = FligthPlannerProgram.Trip(city, cities);

            //Assert
            Assert.AreEqual("You can fly from New York to Anchorage, San Jose, San Francisco, Honolulu", result);
        }

        [Test]
        public void RoundTrip_City_ResultFalse()
        {
            //Arrange
            string city = "Anchorage";
            List<string> cities = new List<string>() { "Anchorage", "New York", "San Jose", "New York" };

            //Act
            var result = FligthPlannerProgram.RoundTrip(city, cities);

            //Assert
            Assert.AreEqual(false, result);
        }
    }
}

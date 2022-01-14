using NUnit.Framework;
using System.Collections.Generic;
using FlightPlanner;

namespace FlightPlanner.Test
{
    public class Tests
    {
        [Test]
        public void NextTrip_CityCitiesAvailable_ResultWaitingNextTrip()
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
        public void CheckTrip_CityCitiesAvailable_ResultWaitingNextTrip()
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
        public void RoundTrip_CityCities_ResultFalse()
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

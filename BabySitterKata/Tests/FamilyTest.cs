using System;
using BabySitterKata.FamilyModels;
using NUnit.Framework;
namespace BabySitterKata.Tests
{
    [TestFixture()]
    public class FamilyTest
    {
        private DateTime _clockedInTime;

        private Family _familyChoiceA;

        private Family _familyChoiceB;

        private Family _familyChoiceC;

        private int expectedRate;

        [SetUp]
        public void SetUp()
        {
            _clockedInTime = DateTime.Parse("5PM");

            _familyChoiceA = new FamilyA();

            _familyChoiceB = new FamilyB();

            _familyChoiceC = new FamilyC();
        }
        [Test()]
        public void IfTheBabySitterSelectsFamilyAAndWorksAtLeastOneHourBetween5PMAnd11PMAValueOf15IsReturned()
        {
            //Arrange
            expectedRate = 15;

            //Act
            var actualRate = _familyChoiceA.BabySitterRates(_clockedInTime);

            //Assert
            Assert.AreEqual(expectedRate, actualRate);
        }

        [Test()]
        public void IfTheBabySitterSelectsFamilyAAndWorksAtLeastOneHourBetween11PMAnd4AMAValueOf20IsReturned()
        {
            //Arrange
            _clockedInTime = DateTime.Parse("1:00AM");
            expectedRate = 20;

            //Act
            var actualRate = _familyChoiceA.BabySitterRates(_clockedInTime);

            //Assert
            Assert.AreEqual(expectedRate, actualRate);
        }

        [Test()]
        public void IfTheBabySitterSelectsFamilyBAndWorksAtLeastOneHourBetween5PMAnd10PMAValueOf12IsReturned()
        {
            //Arrange
            expectedRate = 12;

            //Act
            var actualRate = _familyChoiceB.BabySitterRates(_clockedInTime);

            //Assert
            Assert.AreEqual(expectedRate, actualRate);
        }

        [Test()]
        public void IfTheBabySitterSelectsFamilyBAndWorksAtLeastOneHourBetween10PMAnd12AMAValueOf8IsReturned()
        {
            //Arrange
            expectedRate = 8;
            _clockedInTime = DateTime.Parse("10:30PM");

            //Act
            var actualRate = _familyChoiceB.BabySitterRates(_clockedInTime);

            //Assert
            Assert.AreEqual(expectedRate, actualRate);
        }

        [Test()]
        public void IfTheBabySitterSelectsFamilyBAndWorksAtLeastOneHourBetween12AMAnd4AMAValueOf16IsReturned()
        {
            //Arrange
            expectedRate = 16;
            _clockedInTime = DateTime.Parse("12:01AM");

            //Act
            var actualRate = _familyChoiceB.BabySitterRates(_clockedInTime);

            //Assert
            Assert.AreEqual(expectedRate, actualRate);
        }

        [Test()]
        public void IfTheBabySitterSelectsFamilyCAndWorksAtLeastOneHourBetween5PMAnd9PMAValueOf21IsReturned()
        {
            //Arrange
            expectedRate = 21;

            //Act
            var actualRate = _familyChoiceC.BabySitterRates(_clockedInTime);

            //Assert
            Assert.AreEqual(expectedRate, actualRate);
        }

        [Test()]
        public void IfTheBabySitterSelectsFamilyCAndWorksAtLeastOneHourBetween9PMAnd4AMAValueOf15IsReturned()
        {
            //Arrange
            expectedRate = 15;
            _clockedInTime = DateTime.Parse("10:00PM");

            //Act
            var actualRate = _familyChoiceC.BabySitterRates(_clockedInTime);

            //Assert
            Assert.AreEqual(expectedRate, actualRate);
        }

    }
}
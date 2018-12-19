﻿using System.Linq;
using BabySitterKata.FamilyModels;
using NUnit.Framework;

namespace BabySitterKata.Tests
{
	[TestFixture()]
	public class BabySitterTest
	{

		private string _clockInTime;

		private string _clockOutTime;

		private Family _familyChoiceA;

        private Family _familyChoiceB;

		private BabySitter _babySitter;

        private string rate;

		[SetUp]
		public void SetUp()
		{
			_clockInTime = "5PM";

			_clockOutTime = "6PM";

			_babySitter = new BabySitter();

			_familyChoiceA = new FamilyA();

            _familyChoiceB = new FamilyB();
		}

		[Test()]
		public void IfTheclockInTimeStartsEarlilerThan5PMAnErrorValidationMessageIsReturned()
		{
			//Arrange
			_clockInTime = "4PM";
			var earlyClockInTimeMessage = "You cannout work before 5PM";

			//Act
			var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceA).ToList();

			//Assert
			Assert.Contains(earlyClockInTimeMessage, earnings);
		}

		[Test()]
		public void IfTheBabySitterDoesNotSelectAFamilyAnErrorValidationMessageIsReturned()
		{
			//Arrange
			var selectAFamilyMessage = "You Must Select A Family";

			//Act
			var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, null).ToList();

			//Assert
			Assert.Contains(selectAFamilyMessage, earnings);
		}


		[Test()]
		public void IfTheclockoutTimeIsLaterThan4AMAnErrorValidationMessageIsReturned()
		{
			//Arrange
			_clockOutTime = "5AM";
			var lateClockOutTimeMessage = "You cannout work past 4AM";

			//Act
			var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceA).ToList();

			//Assert
			Assert.Contains(lateClockOutTimeMessage, earnings);
		}

		[Test()]
		public void IfTheclockoutTimeIsBeforeThanClockInTimeAnErrorValidationMessageIsReturned()
		{
			//Arrange
			_clockInTime = "8PM";
			_clockOutTime = "6PM";
			var errorClockOutTimeMessage = "Your end time cannot be before your start time";

			//Act
			var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceA).ToList();

			//Assert
			Assert.Contains(errorClockOutTimeMessage, earnings);
		}

        [Test()]         public void IfTheBabySitterDoesNotSelectAClockInTimeASelectClockInTimeErrorValidationmessageIsReturned()         {             //Arrange             _clockInTime = string.Empty;
            var selectAClockInTimeMessage = "You must select a start time";             //Act           var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceA).ToList();              //Assert            Assert.Contains(selectAClockInTimeMessage, earnings);         }

		[Test()]
		public void IfTheBabySitterDoesNotSelectAClockOutTimeASelectClockOutTimeErrorValidationmessageIsReturned()
		{
			//Arrange
            _clockOutTime = string.Empty;

			var selectAClockOutTimeMessage = "You must select an end time";

			//Act
			var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceA).ToList();

			//Assert
			Assert.Contains(selectAClockOutTimeMessage, earnings);
		}

		[Test()]
		public void IfTheBabySitterSelectsFamilyAAndWorksAtLeastOneHourBetween5PMAnd11PMAValueOf15IsReturned()
		{
			//Arrange
			rate = "15";

			//Act
			var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceA).ToList();

			//Assert
			Assert.Contains(rate, earnings);
		}

		[Test()]
		public void IfTheBabySitterSelectsFamilyAAndWorksAtLeastOneHourBetween11PMAnd4AMAValueOf20IsReturned()
		{
            //Arrange
            _clockInTime = "1:00AM";
            _clockOutTime = "4:00AM";
			rate = "20";

			//Act
			var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceA).ToList();

			//Assert
			Assert.Contains(rate, earnings);
		}

		[Test()]
		public void IfTheBabySitterSelectsFamilyBAndWorksAtLeastOneHourBetween5PMAnd10PMAValueOf12IsReturned()
		{
			//Arrange
			rate = "12";

			//Act
			var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceB).ToList();

			//Assert
			Assert.Contains(rate, earnings);
		}

		[Test()]
		public void IfTheBabySitterSelectsFamilyBAndWorksAtLeastOneHourBetween10PMAnd12AMAValueOf8IsReturned()
		{
			//Arrange
			rate = "8";
            _clockInTime = "10:30PM";
            _clockOutTime = "11:30PM";

			//Act
			var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceB).ToList();

			//Assert
			Assert.Contains(rate, earnings);
		}

		[Test()]
		public void IfTheBabySitterSelectsFamilyBAndWorksAtLeastOneHourBetween12AMAnd4AMAValueOf16IsReturned()
		{
			//Arrange
			rate = "16";
			_clockInTime = "12:01AM";
			_clockOutTime = "3:00AM";

			//Act
			var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceB).ToList();

			//Assert
			Assert.Contains(rate, earnings);
		}
	}
}
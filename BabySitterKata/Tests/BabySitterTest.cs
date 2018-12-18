using System.Linq;
using BabySitterKata.FamilyModels;
using NUnit.Framework;

namespace BabySitterKata.Tests
{
	[TestFixture()]
	public class BabySitterTest
	{

		private string _clockInTime;

		private string _clockOutTime;

		private Family _familyChoice;

		private BabySitter _babySitter;

		[SetUp]
		public void SetUp()
		{
			_clockInTime = "5PM";

			_clockOutTime = "6PM";

			_babySitter = new BabySitter();

			_familyChoice = new FamilyA();
		}

		[Test()]
		public void IfTheclockInTimeStartsEarlilerThan5PMAnErrorValidationMessageIsReturned()
		{
			//Arrange
			_clockInTime = "4PM";
			var earlyClockInTimeMessage = "You cannout work before 5PM";

			//Act
			var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoice).ToList();

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
			var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoice).ToList();

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
			var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoice).ToList();

			//Assert
			Assert.Contains(errorClockOutTimeMessage, earnings);
		}
	}
}
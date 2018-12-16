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
        public void WhenTheBabySitterCalculatesNightlyChargeItReturnsANumber()
        {
            //Arrange

            //Act
            var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoice);

            //Assert
            Assert.IsNotNull(earnings);
        }

        [Test()]
        public void IfTheclockInTimeStartsEarlilerThan5PMAnErrorValidationMessageIsReturned()
        {
            //Arrange
            _clockInTime = "4PM";
            var earlyClockInTimeMessage = "You you cannout work before 5PM";

            //Act
            var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoice);

            //Assert
            Assert.AreEqual(earlyClockInTimeMessage, earnings);
        }

		[Test()]
        public void IfTheBabySitterDoesNotSelectAFamilyAnErrorValidationMessageIsReturned()
		{
			//Arrange
			var selectAFamilyMessage = "You Must Select A Family";

			//Act
			var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, null);

			//Assert
			Assert.AreEqual(selectAFamilyMessage, earnings);
		}


        [Test()]
        public void IfTheclockoutTimeIsLaterThan4AMAnErrorValidationMessageIsReturned()
        {
            //Arrange
            _clockOutTime = "5AM";
            var lateClockOutTimeMessage = "You cannout work past 4AM";

            //Act
            var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoice);

            //Assert
            Assert.AreEqual(lateClockOutTimeMessage, earnings);
        }

    }
}
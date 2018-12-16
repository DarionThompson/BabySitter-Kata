using BabySitterKata.FamilyModels;
using NUnit.Framework;

namespace BabySitterKata.Tests
{
    [TestFixture()]
    public class BabySitterTest
    {

        private string clockInTime;

        private string clockOutTime;

        private Family familyChoice;

        private BabySitter babySitter;

        [SetUp]
        public void SetUp()
        {
            clockInTime = "5PM";

            clockOutTime = "6PM";

            babySitter = new BabySitter();

            familyChoice = new FamilyA();
        }

        [Test()]
        public void WhenTheBabySitterCalculatesNightlyChargeItReturnsANumber()
        {
            //Arrange

            //Act
            var earnings = babySitter.CalculateNightlyCharge(clockInTime, clockOutTime, familyChoice);

            //Assert
            Assert.IsNotNull(earnings);
        }

        [Test()]
        public void IfTheclockInTimeStartsEarlilerThan5PMAnErrorValidationMessageIsReturned()
        {
            //Arrange
            clockInTime = "4PM";
            var earlyClockInTimeMessage = "You Cannot clock In Before 5PM";

            //Act
            var earnings = babySitter.CalculateNightlyCharge(clockInTime, clockOutTime, familyChoice);

            //Assert
            Assert.AreEqual(earnings, earlyClockInTimeMessage);
        }

		[Test()]
        public void IfTheBabySitterDoesNotSelectAFamilyAnErrorValidationMessageIsReturned()
		{
			//Arrange
			var earlyClockInTimeMessage = "You Must Select A Family";

			//Act
			var earnings = babySitter.CalculateNightlyCharge(clockInTime, clockOutTime, null);

			//Assert
			Assert.AreEqual(earnings, earlyClockInTimeMessage);
		}


    }
}
using NUnit.Framework;

namespace BabySitterKata.Tests
{
    [TestFixture()]
    public class BabySitterTest
    {
        [Test()]
        public void WhenTheBabySitterCalculatesNightlyChargeItReturnsANumber()
        {
            //Arrange
            BabySitter babySitter = new BabySitter();
            var clockInTime = "5PM";
            var clockOutTime = "6";
            var family = string.Empty;

            //Act
            var earnings = babySitter.CalculateNightlyCharge(clockInTime, clockOutTime, family);

            //Assert
            Assert.IsNotNull(earnings);
        }

        [Test()]
        public void IfTheclockInTimeStartsEarlilerThan5PMAnErrorValidationMessageIsReturned()
        {
            //Arrange
            BabySitter babySitter = new BabySitter();
            var clockInTime = "4PM";
            var clockOutTime = string.Empty;
            var family = string.Empty;

            var earlyClockInTimeMessage = "You Cannot clock In Before 5PM";

            //Act
            var earnings = babySitter.CalculateNightlyCharge(clockInTime, clockOutTime, family);

            //Assert
            Assert.AreEqual(earnings, earlyClockInTimeMessage);
        }
    }
}
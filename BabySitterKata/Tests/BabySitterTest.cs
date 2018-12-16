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
            var clockInTime = string.Empty;
            var clockOutTime = string.Empty;
            var family = string.Empty;

            //Act
            var earnings = babySitter.CalculateNightlyCharge(clockInTime, clockOutTime, family);

            //Assert
            Assert.IsNotNull(earnings);
        }
    }
}

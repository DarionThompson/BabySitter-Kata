using NUnit.Framework;

namespace BabySitterKata.Tests
{
    [TestFixture()]
    public class BabySitterTest
    {
        [Test()]
        public void WhenTheBabySitterCalculatesNightlyChargeItReturnsANumber()
        {
            BabySitter babySitter = new BabySitter();
            var clockInTime = string.Empty;
            var clockOutTime = string.Empty;

            var earnings = babySitter.CalculateNightlyCharge(clockInTime, clockOutTime);

            Assert.IsNotNull(earnings);
        }
    }
}

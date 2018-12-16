using NUnit.Framework;

namespace BabySitterKata.Tests
{
    [TestFixture()]
    public class BabySitterTest
    {
        [Test()]
        public void WhenBabySitterCalculatesNightlyChargeItReturnsANumber()
        {
            BabySitter babySitter = new BabySitter();

            var earnings = babySitter.CalculateNightlyCharge();

            Assert.IsNotNull(earnings);

        }
    }
}

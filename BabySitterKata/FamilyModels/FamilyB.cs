using System;
namespace BabySitterKata.FamilyModels
{
    public class FamilyB
        : Family
    {
		private readonly DateTime _startOfFirstPayPeriod = DateTime.Parse("5PM");

		private readonly DateTime _endOfFirstPayPeriod = DateTime.Parse("10PM");

		private readonly DateTime _startOfSecondPayPeriod = DateTime.Parse("10:01PM");

        private readonly DateTime _endOfSecondPayPeriod = DateTime.Parse("12AM").AddDays(1);

        private readonly int firstHourlyCharge = 12;

        private readonly int secondHourlyCharge = 8;

        private readonly int thirdHourlyCharge = 16;

		public override int BabySitterRates(DateTime clockedInTime)
		{
            if (clockedInTime >= _startOfFirstPayPeriod && clockedInTime < _endOfFirstPayPeriod)
            {
                return firstHourlyCharge;
            }
            if(clockedInTime >= _startOfSecondPayPeriod && clockedInTime <= _endOfSecondPayPeriod)
            {
                return secondHourlyCharge;
            }

			return thirdHourlyCharge;
		}
    }
}

using System;
namespace BabySitterKata.FamilyModels
{
    public class FamilyB
        : Family
    {
		private DateTime _startOfFirstPayPeriod = DateTime.Parse("5PM");

		private DateTime _endOfFirstPayPeriod = DateTime.Parse("10PM");

		private DateTime _startOfSecondPayPeriod = DateTime.Parse("10:01PM");

        private DateTime _endOfSecondPayPeriod = DateTime.Parse("12AM").AddDays(1);

        private int firstHourlyCharge = 12;

        private int secondHourlyCharge = 8;

        private int thirdHourlyCharge = 16;

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

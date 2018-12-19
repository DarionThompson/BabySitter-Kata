using System;

namespace BabySitterKata.FamilyModels
{
    public class FamilyA
        : Family
    {
        private DateTime _startOfFirstPayPeriod = DateTime.Parse("5PM");

        private DateTime _endOfFirstPayPeriod = DateTime.Parse("11PM");

		private int firstHourlyCharge = 15;

		private int secondHourlyCharge = 20;

        public override int BabySitterRates(DateTime clockedInTime)
		{
			if (clockedInTime >= _startOfFirstPayPeriod && clockedInTime < _endOfFirstPayPeriod)
			{
                return firstHourlyCharge;
			}

			return secondHourlyCharge;
        }
    }
}

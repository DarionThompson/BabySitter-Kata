using System;
namespace BabySitterKata.FamilyModels
{
    public class FamilyC
        : Family
    {
		private DateTime _startOfFirstPayPeriod = DateTime.Parse("5PM");

		private DateTime _endOfFirstPayPeriod = DateTime.Parse("9PM");

		private int firstHourlyCharge = 21;

		private int secondHourlyCharge = 15;

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

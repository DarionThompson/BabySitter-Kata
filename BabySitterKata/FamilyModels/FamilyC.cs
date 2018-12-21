using System;
namespace BabySitterKata.FamilyModels
{
    public class FamilyC
        : Family
    {
		private readonly DateTime _startOfFirstPayPeriod = DateTime.Parse("5PM");

		private readonly DateTime _endOfFirstPayPeriod = DateTime.Parse("9PM");

		private readonly int firstHourlyCharge = 21;

		private readonly int secondHourlyCharge = 15;

        public override int BabySitterRates(DateTime clockedInTime)
        {
			if (clockedInTime >= _startOfFirstPayPeriod && clockedInTime < _endOfFirstPayPeriod)
			{
                return firstHourlyCharge;
			}

            return secondHourlyCharge;
        }

        public override int CalculateBabySitterPay(DateTime startTime, DateTime endTime)
        {
            int total = 0;

            while (!startTime.Equals(endTime) || startTime > endTime)
            {
                total += BabySitterRates(startTime);

                startTime = startTime.AddHours(1);
            }

            return total;
        }
    }
}

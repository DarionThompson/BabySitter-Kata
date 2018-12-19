using System;
namespace BabySitterKata.FamilyModels
{
    public class FamilyC
        : Family
    {
		private DateTime _startOfFirstPayPeriod = DateTime.Parse("5PM");

		private DateTime _endOfFirstPayPeriod = DateTime.Parse("9PM");

        public override int BabySitterRates(string startTime, string endTime)
        {
			var start = DateTime.Parse(startTime);

			if (start >= _startOfFirstPayPeriod && start < _endOfFirstPayPeriod)
			{
				return 21;
			}

            return 15;
        }
    }
}

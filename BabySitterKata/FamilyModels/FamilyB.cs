using System;
namespace BabySitterKata.FamilyModels
{
    public class FamilyB
        : Family
    {
		private DateTime _startOfFirstPayPeriod = DateTime.Parse("5PM");

		private DateTime _endOfFirstPayPeriod = DateTime.Parse("10PM");



		public override int BabySitterRates(string startTime, string endTime)
		{
			var start = DateTime.Parse(startTime);

			if (start >= _startOfFirstPayPeriod && start < _endOfFirstPayPeriod)
			{
				return 12;
			}

			return 8;
		}
    }
}

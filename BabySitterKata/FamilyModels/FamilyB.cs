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

		public override int BabySitterRates(string startTime, string endTime)
		{
			var start = DateTime.Parse(startTime);

            if (start >= _startOfFirstPayPeriod && start < _endOfFirstPayPeriod)
            {
                return 12;
            }
            if(start >= _startOfSecondPayPeriod && start <= _endOfSecondPayPeriod)
            {
                return 8;
            }

			return 16;
		}
    }
}

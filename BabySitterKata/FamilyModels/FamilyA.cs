using System;

namespace BabySitterKata.FamilyModels
{
    public class FamilyA
        : Family
    {
        private DateTime _endOfPayPeriodOne = DateTime.Parse("11PM");

        public override int BabySitterRates(string startTime, string endTime)
		{
			if (DateTime.Parse(startTime) <=_endOfPayPeriodOne)
			{
				return 15;
			}

			return 0;
        }
    }
}

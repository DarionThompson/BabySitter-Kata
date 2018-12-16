using System;
namespace BabySitterKata.TimePolicy
{
    public class TimeClockPolicy
        : ITimeClockPolicy
    {
        private DateTime _clockInRestriction = DateTime.Parse("5PM");

        private DateTime _clockOutRestriction = DateTime.Parse("4AM");


        public bool AssertStartTimePolicy(DateTime startTime)
        {
            return startTime < _clockInRestriction;
        }

		public bool AsserEndTimePolicy(DateTime endTime)
		{
            return endTime >= _clockOutRestriction && endTime <= _clockInRestriction;
		}
    }
}

using System;
using System.Collections.Generic;
using BabySitterKata.Helpers;

namespace BabySitterKata.TimePolicy
{
	public class TimeClockPolicy
		: ITimeClockPolicy
	{
		private DateTime _clockInRestriction = DateTime.Parse("5PM");

		private DateTime _clockOutRestriction = DateTime.Parse("4AM");


		public IList<string> ValidateTimeClockEnties(IList<string> messages, string clockInTime, string clockOutTime)
		{   
			var startTime = DateTime.Parse(clockInTime);

			var endTime = DateTime.Parse(clockOutTime);

			if (AssertStartTimePolicy(startTime))
			{
				messages.Add(MessageHelper.earlyStartTimeMessage);
			}
			else if (AsserEndTimePolicy(endTime))
			{
				messages.Add(MessageHelper.lateEndTimeMessage);
			}

			else if (AssertStartTimeAndEndTimeTimePolicy(startTime, endTime))
			{
				messages.Add(MessageHelper.errorEndTimeMessage);
			}

			return messages;
		}

		private bool AssertStartTimePolicy(DateTime startTime)
		{
			return startTime < _clockInRestriction;
		}

		private bool AsserEndTimePolicy(DateTime endTime)
		{
			return endTime >= _clockOutRestriction && endTime <= _clockInRestriction;
		}

		private bool AssertStartTimeAndEndTimeTimePolicy(DateTime startTime, DateTime endTime)
		{
			return endTime < startTime;
		}
	}
}

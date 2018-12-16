using System;

namespace BabySitterKata.TimePolicy
{
    public interface ITimeClockPolicy
    {
        bool AssertStartTimePolicy(DateTime startTime);

        bool AsserEndTimePolicy(DateTime endTime);

        bool AssertStartTimeAndEndTimeTimePolicy(DateTime startTime, DateTime endTime);
    }
}

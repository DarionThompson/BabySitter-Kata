using System.Collections.Generic;

namespace BabySitterKata.TimePolicy
{
    public interface ITimeClockPolicy
    {
        IList<string> ValidateTimeClockEnties(IList<string> messages, string clockInTime, string clockOutTime);
    }
}

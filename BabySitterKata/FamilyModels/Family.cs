using System;

namespace BabySitterKata.FamilyModels
{
    public abstract class Family
    {
        public abstract int BabySitterRates(DateTime clockedInTime);

        public abstract int CalculateBabySitterPay(DateTime startTime, DateTime endTime);
    }
}
 
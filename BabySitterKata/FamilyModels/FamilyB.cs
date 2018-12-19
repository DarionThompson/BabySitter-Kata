using System;
namespace BabySitterKata.FamilyModels
{
    public class FamilyB
        : Family
    {
        public override int BabySitterRates(string startTime, string endTime)
        {
            return 12;
        }
    }
}

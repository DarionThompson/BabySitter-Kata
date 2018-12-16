using System;
using BabySitterKata.FamilyModels;

namespace BabySitterKata
{
    public class BabySitter
    {
        public string CalculateNightlyCharge(string clockInTime, string clockOutTime, Family familyChoice)
        {
            var result = "0";

            if (familyChoice == null){
                result = "You Must Select A Family";
            }

            if(DateTime.Parse(clockInTime) < DateTime.Parse("5PM")){
                result = "You Cannot clock In Before 5PM";
            }
            else if(DateTime.Parse(clockOutTime)  >= DateTime.Parse("4AM")
                   && DateTime.Parse(clockOutTime) <= DateTime.Parse("5PM")){
                result = "You Cannot clock out past 4AM";
            }

            return result;
        }
    }
}

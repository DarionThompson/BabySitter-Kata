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

            return result;
        }
    }
}

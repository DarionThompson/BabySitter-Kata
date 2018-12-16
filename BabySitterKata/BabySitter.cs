using System;
using BabySitterKata.FamilyModels;

namespace BabySitterKata
{
    public class BabySitter
    {
        public string CalculateNightlyCharge(string clockInTime, string clockOutTime, Family familyChoice)
        {
            if (familyChoice == null){
                return "You Must Select A Family";
            }
            if(DateTime.Parse(clockInTime) < DateTime.Parse("5PM")){
                return "You Cannot clock In Before 5PM";
            }

            return "0";
        }
    }
}

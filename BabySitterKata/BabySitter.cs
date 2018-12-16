using System;
using BabySitterKata.FamilyModels;

namespace BabySitterKata
{
    public class BabySitter
    {
        private const string _missingFamilyChoiceMessage = "You Must Select A Family";

        private const string _earlyStartTimeMessage = "You you cannout work before 5PM";

        private const string _lateEndTimeMessage = "You cannout work past 4AM";

        public string CalculateNightlyCharge(string clockInTime, string clockOutTime, Family familyChoice)
        {
            var result = "0";

            result = ValidateFamilyChoice(familyChoice);

            if (DateTime.Parse(clockInTime) < DateTime.Parse("5PM"))
            {
                result = _earlyStartTimeMessage;
            }
            else if (DateTime.Parse(clockOutTime) >= DateTime.Parse("4AM")
                   && DateTime.Parse(clockOutTime) <= DateTime.Parse("5PM"))
            {
                result = _lateEndTimeMessage;
            }

            return result;
        }

        private string ValidateFamilyChoice(Family familyChoice){
            var errorMessage = string.Empty;

            if (familyChoice == null)
			{
				errorMessage = _missingFamilyChoiceMessage;
			}
            return errorMessage;
        }
    }
}

using System;
using BabySitterKata.FamilyModels;
using BabySitterKata.TimePolicy;

namespace BabySitterKata
{
    public class BabySitter
    {
        private const string _missingFamilyChoiceMessage = "You Must Select A Family";

        private const string _earlyStartTimeMessage = "You cannout work before 5PM";

        private const string _lateEndTimeMessage = "You cannout work past 4AM";

        private readonly ITimeClockPolicy _timeClockPolicy;

        public BabySitter()
        {
            _timeClockPolicy = new TimeClockPolicy();
        }

        public string CalculateNightlyCharge(string clockInTime, string clockOutTime, Family familyChoice)
        {
            string result = string.Empty;

            result = ValidateFamilyChoice(result, familyChoice);

            result = ValidateTimeClockEnties(result, clockInTime, clockOutTime);


            return result != string.Empty ? result : "0";
        }

        private string ValidateFamilyChoice(string message, Family familyChoice){

            if (familyChoice == null)
			{
				message = _missingFamilyChoiceMessage;
			}
            return message;
        }

        private string ValidateTimeClockEnties(string message, string clockInTime, string clockOutTime){

            var startTime = DateTime.Parse(clockInTime);

            var endTime = DateTime.Parse(clockOutTime);

            if(_timeClockPolicy.AssertStartTimePolicy(startTime)){
                message = _earlyStartTimeMessage;
            }
            else if(_timeClockPolicy.AsserEndTimePolicy(endTime)){
                message = _lateEndTimeMessage;
            }

            return message;
        }
    }
}

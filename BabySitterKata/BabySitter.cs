using System;
using System.Collections.Generic;
using System.Linq;
using BabySitterKata.FamilyModels;
using BabySitterKata.Services;
using BabySitterKata.TimePolicy;

namespace BabySitterKata
{
	public class BabySitter
	{
		private readonly IValidationServices _validationServices;

		private readonly ITimeClockPolicy _timeClockPolicy;

		public BabySitter()
		{
			_timeClockPolicy = new TimeClockPolicy();
			_validationServices = new ValidationServices();
		}

		public IList<string> CalculateNightlyCharge(string clockInTime, string clockOutTime, Family familyChoice)
		{
			var result = _validationServices.ValidateUserInputs(clockInTime, clockOutTime, familyChoice);

            if (!result.Any())
            {
                result = _timeClockPolicy.ValidateTimeClockEnties(result, clockInTime, clockOutTime);

                if (!result.Any())
                {
                    result.Add(CalculateRates(clockInTime, clockOutTime, familyChoice).ToString()); 
                }
            }

			return result;
		}

        private int CalculateRates(string clockInTime, string clockOutTime, Family familyChoice)
        {
            if (familyChoice.GetType() == typeof(FamilyA))
            {
                var familyA = familyChoice as FamilyA;

                return familyA.BabySitterRates(clockInTime, clockOutTime);
            }
            if (familyChoice.GetType() == typeof(FamilyB))
            {
                var familyB = familyChoice as FamilyB;
                return familyB.BabySitterRates(clockInTime, clockOutTime);
            }

            var familyC = familyChoice as FamilyC;
            return familyC.BabySitterRates(clockInTime, clockOutTime);

        }
	}
}

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

			result = _timeClockPolicy.ValidateTimeClockEnties(result, clockInTime, clockOutTime);

			return result;
		}

	}
}

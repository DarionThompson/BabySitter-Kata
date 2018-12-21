﻿using System;
using System.Collections.Generic;
using System.Linq;
using BabySitterKata.FamilyModels;
using BabySitterKata.Helpers;
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
                var startTime = CheckIfTimeEntryContainsAm(clockInTime);

                var endTime = CheckIfTimeEntryContainsAm(clockOutTime);

                result = _timeClockPolicy.ValidateTimeClockEnties(result, startTime, endTime);

            }
			return result;
		}

        private DateTime CheckIfTimeEntryContainsAm(string time)
        {
            var convertedTime = DateTime.Parse(time);

            if (time.Contains(MessageHelper.amSuffix))
            {
                return convertedTime.AddDays(1);
            }

            return convertedTime;
        }
    }
}

using System.Collections.Generic;
using BabySitterKata.FamilyModels;
using BabySitterKata.Helpers;

namespace BabySitterKata.Services
{
	public class ValidationServices
	: IValidationServices
	{
		public IList<string> ValidateUserInputs(string clockInTime, string clockOutTime, Family familyChoice)
		{
			var result = new List<string>();

			var message = ValidateFamilyChoice(string.Empty, familyChoice);

			if (!string.IsNullOrEmpty(message))
			{
				result.Add(message);
			}

            if(string.IsNullOrEmpty(clockInTime))
            {
                result.Add(MessageHelper.missingStartTimeMessage);
            }

			return result;
		}

		private string ValidateFamilyChoice(string message, Family familyChoice)
		{
			if (familyChoice == null)
			{
				message = MessageHelper.missingFamilyChoiceMessage;
			}

			return message;
		}
	}
}

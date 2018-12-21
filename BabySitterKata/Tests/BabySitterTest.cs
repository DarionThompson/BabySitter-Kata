using System.Linq;
using BabySitterKata.FamilyModels;
using NUnit.Framework;

namespace BabySitterKata.Tests
{
    [TestFixture()]
    public class BabySitterTest
    {

        private string _clockInTime;

        private string _clockOutTime;

        private Family _familyChoiceA;

        private Family _familyChoiceB;

        private Family _familyChoiceC;

        private BabySitter _babySitter;

        [SetUp]
        public void SetUp()
        {
            _clockInTime = "5PM";

            _clockOutTime = "6PM";

            _babySitter = new BabySitter();

            _familyChoiceA = new FamilyA();

            _familyChoiceB = new FamilyB();

            _familyChoiceC = new FamilyC();
        }

        [Test()]
        public void IfTheclockInTimeStartsEarlilerThan5PMAnErrorValidationMessageIsReturned()
        {
            //Arrange
            _clockInTime = "4PM";
            var earlyClockInTimeMessage = "You cannout work before 5PM";

            //Act
            var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceA).ToList();

            //Assert
            Assert.Contains(earlyClockInTimeMessage, earnings);
        }

        [Test()]
        public void IfTheBabySitterDoesNotSelectAFamilyAnErrorValidationMessageIsReturned()
        {
            //Arrange
            var selectAFamilyMessage = "You Must Select A Family";

            //Act
            var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, null).ToList();

            //Assert
            Assert.Contains(selectAFamilyMessage, earnings);
        }


        [Test()]
        public void IfTheclockoutTimeIsLaterThan4AMAnErrorValidationMessageIsReturned()
        {
            //Arrange
            _clockOutTime = "5AM";
            var lateClockOutTimeMessage = "You cannout work past 4AM";

            //Act
            var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceA).ToList();

            //Assert
            Assert.Contains(lateClockOutTimeMessage, earnings);
        }

        [Test()]
        public void IfTheclockoutTimeIsBeforeThanClockInTimeAnErrorValidationMessageIsReturned()
        {
            //Arrange
            _clockInTime = "8PM";
            _clockOutTime = "6PM";
            var errorClockOutTimeMessage = "Your end time cannot be before your start time";

            //Act
            var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceA).ToList();

            //Assert
            Assert.Contains(errorClockOutTimeMessage, earnings);
        }

        [Test()]         public void IfTheBabySitterDoesNotSelectAClockInTimeASelectClockInTimeErrorValidationmessageIsReturned()         {
            //Arrange
            _clockInTime = string.Empty;

            var selectAClockInTimeMessage = "You must select a start time";

            //Act
            var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceA).ToList();

            //Assert
            Assert.Contains(selectAClockInTimeMessage, earnings);         }

        [Test()]
        public void IfTheBabySitterDoesNotSelectAClockOutTimeASelectClockOutTimeErrorValidationmessageIsReturned()
        {
            //Arrange
            _clockOutTime = string.Empty;

            var selectAClockOutTimeMessage = "You must select an end time";

            //Act
            var earnings = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceA).ToList();

            //Assert
            Assert.Contains(selectAClockOutTimeMessage, earnings);
        }

        [Test()]
        public void IfTheBabySitterSelectsFamilyAAndWorksBetween5PMAnd11PMAValueOf90IsReturned()
        {
            //Arrange
            var expectedPay = "90";
            _clockOutTime = "11PM";

            //Act
            var actualPay = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceA).ToList();

            //Assert
            Assert.Contains(expectedPay, actualPay);
        }

        [Test()]
        public void IfTheBabySitterSelectsFamilyAAndWorksBetween5PMAnd4AMAValueOf190IsReturned()
        {
            //Arrange
            var expectedPay = "190";
            _clockOutTime = "4AM";

            //Act
            var actualPay = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceA).ToList();

            //Assert
            Assert.Contains(expectedPay, actualPay);
        }

        [Test()]
        public void IfTheBabySitterSelectsFamilyBAndWorksBetween5PMAnd10PMAValueOf60IsReturned()
        {
            //Arrange
            var expectedPay = "60";
            _clockOutTime = "10PM";

            //Act
            var actualPay = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceB).ToList();

            //Assert
            Assert.Contains(expectedPay, actualPay);
        }

        [Test()]
        public void IfTheBabySitterSelectsFamilyBAndWorksBetween5PMAnd12PMAValueOf76IsReturned()
        {
            //Arrange
            var expectedPay = "76";
            _clockOutTime = "12AM";

            //Act
            var actualPay = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceB).ToList();

            //Assert
            Assert.Contains(expectedPay, actualPay);
        }

        [Test()]
        public void IfTheBabySitterSelectsFamilyBAndWorksBetween5PMAnd4AMAValueOf140IsReturned()
        {
            //Arrange
            var expectedPay = "140";
            _clockOutTime = "4AM";

            //Act
            var actualPay = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceB).ToList();

            //Assert
            Assert.Contains(expectedPay, actualPay);
        }

        [Test()]
        public void IfTheBabySitterSelectsFamilyCAndWorksBetween5PMAnd9PMAValueOf84IsReturned()
        {
            //Arrange
            var expectedPay = "84";
            _clockOutTime = "9PM";

            //Act
            var actualPay = _babySitter.CalculateNightlyCharge(_clockInTime, _clockOutTime, _familyChoiceC).ToList();

            //Assert
            Assert.Contains(expectedPay, actualPay);
        }
    }
}
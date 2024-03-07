using InsurancePolicyQuote.Logic;
using System;

namespace InsurancePolicyQuoteUI
{
    public class DateHelper : IDateHelper
    {
        public int GetDayDifference(DateTime dateOne, DateTime dateTwo)
        {
            TimeSpan span = dateOne - dateTwo;

            return (int)span.TotalDays;
        }

        public int GetMonthDifference(DateTime dateOne, DateTime dateTwo)
        {
            int yearDifference = dateOne.Year - dateTwo.Year;
            int monthDifference = (yearDifference * 12) + (dateOne.Month - dateTwo.Month);

            // Adjust for the months that have passed in the earlier date's year
            if (dateOne.Month < dateTwo.Month || (dateOne.Month == dateTwo.Month && dateOne.Day < dateTwo.Day))
                monthDifference--;

            return monthDifference;
        }

        public int GetAgeDifference(DateTime dateOfBirth, DateTime specificDate)
        {
            TimeSpan ageSpan = specificDate - dateOfBirth;

            // Calculate the age in years
            int age = (int)ageSpan.TotalDays / 365;

            // Subtract one if the age is not a whole number of years
            if ((int)(ageSpan.TotalDays / 365) != age)
                age--;

            return age;
        }
    }
}

using System;

namespace InsurancePolicyQuote.Logic
{
    public interface IDateHelper
    {
        int GetDayDifference(DateTime dateOne, DateTime dateTwo);
        int GetMonthDifference(DateTime dateOne, DateTime dateTwo);
        int GetAgeDifference(DateTime dateOfBirth, DateTime specificDate);
    }
}
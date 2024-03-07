using System;

namespace InsurancePolicyQuote.Logic
{
    public interface IDateFormats
    {
        bool CheckValidDateFormat(string date);
        DateTime GetValidDate(string date);
        int GetYear(string date);
        int GetMonth(string date);
        bool CheckValidYear(string year);
    }
}
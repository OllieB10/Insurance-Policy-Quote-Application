namespace InsurancePolicyQuote.Logic
{
    public interface IValidateUserInput
    {
        bool CheckValidInteger(string number);
        decimal GetValidDecimalFromUser(string input);
        int GetValidInteger(string input);
        string GetValidUserInput(string input);
        string FormatInputString(string input);
    }
}
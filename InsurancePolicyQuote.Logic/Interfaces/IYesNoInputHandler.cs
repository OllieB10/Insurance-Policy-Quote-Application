namespace InsurancePolicyQuote.Logic
{
    public interface IYesNoInputHandler
    {
        string GetYesOrNoValue(string input);
        bool ReturnTrueOrFalse(string input);
    }
}
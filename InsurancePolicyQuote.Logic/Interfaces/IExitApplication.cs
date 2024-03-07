namespace InsurancePolicyQuote.Logic
{
    public interface IExitApplication
    {
        void CheckAndExitIfRequested(string userInput);
        void Exit();
    }
}
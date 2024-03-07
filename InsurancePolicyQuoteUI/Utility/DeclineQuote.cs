using InsurancePolicyQuote.Logic;

namespace InsurancePolicyQuoteUI
{
    public class DeclineQuote : IDeclineQuote
    {
        IReadFromConsole readFromConsole = Factory.ReadFromConsole();
        IExitApplication exitApplication = Factory.ExitApplication();
        public void Decline(string message)
        {
            System.Console.WriteLine(message);
            readFromConsole.ReadInputFromConsole();
            exitApplication.Exit();
        }
    }
}

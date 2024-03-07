using System;
using InsurancePolicyQuote.Logic;

namespace InsurancePolicyQuoteUI
{
    public class ExitApplication : IExitApplication
    {
        //Exits the application.
        public void Exit()
        {
            Environment.Exit(0);
        }

        public void CheckAndExitIfRequested(string userInput)
        {
            if (userInput.ToLower() == "exit")
            {
                Exit();
            }
        }
    }
}

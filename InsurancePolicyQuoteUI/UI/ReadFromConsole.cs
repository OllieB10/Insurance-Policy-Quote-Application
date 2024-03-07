using InsurancePolicyQuote.Logic;
using System;

namespace InsurancePolicyQuoteUI
{
    public class ReadFromConsole : IReadFromConsole
    {
        public string ReadInputFromConsole()
        {
            string usersInput = Console.ReadLine();

            return usersInput;
        }
    }
}

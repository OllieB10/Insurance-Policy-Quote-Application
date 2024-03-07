using InsurancePolicyQuote.Logic;
using System;

namespace InsurancePolicyQuoteUI
{
    public class WriteNewLine : IWriteNewLine
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}

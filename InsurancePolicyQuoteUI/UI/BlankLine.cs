using InsurancePolicyQuote.Logic;
using System;

namespace InsurancePolicyQuoteUI
{
    public class BlankLine : IBlankLine
    {
        public void CreateBlankLine()
        {
            Console.WriteLine();
        }
    }
}

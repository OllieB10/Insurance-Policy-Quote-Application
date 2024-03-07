using System;
using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public interface IPolicy
    {
        string Cover { get; set; }
        DateTime EndDate { get; set; }
        DateTime StartDate { get; set; }
        decimal NetPremium { get; set; }
        Proposer Proposer { get; set; }
        IList<Vehicle> Vehicles { get; set; }
        IList<Driver> Drivers { get; set; }
    }
}
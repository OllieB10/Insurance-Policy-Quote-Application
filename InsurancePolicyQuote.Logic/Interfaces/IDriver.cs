using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public interface IDriver
    {
        IList<MotorClaim> Claims { get; set; }
        bool InsurancePreviouslyRefused { get; set; }
        bool HasCriminalConvictions { get; set; }
        bool PreviouslyHadTermsApplied { get; set; }
        bool DisqualifiedFromDriving { get; set; }
    }
}
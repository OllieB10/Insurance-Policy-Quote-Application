
using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public class ClaimsTable : IClaimsTable
    {
        #region Claims Fault & Non-Fault
        public Dictionary<string, decimal> GetClaimsTable()
        {
            Dictionary<string,decimal> caseTable = new Dictionary<string, decimal>
            {
                { $"{NCB.NewBadge}{ClaimsFault.Zero}{ClaimsNonFault.Zero}", 1.00M},
                { $"{NCB.NewBadge}{ClaimsFault.One}{ClaimsNonFault.One}", 1.10M},
                { $"{NCB.NewBadge}{ClaimsFault.TwoPlus}{ClaimsNonFault.TwoPlus}", 1.15M},
                { $"{NCB.NewBadge}{ClaimsFault.Zero}{ClaimsNonFault.One}", 1.20M},
                { $"{NCB.NewBadge}{ClaimsFault.One}{ClaimsNonFault.Zero}", 1.25M},
                { $"{NCB.NewBadge}{ClaimsFault.TwoPlus}{ClaimsNonFault.Zero}", 1.30M},
                { $"{NCB.NewBadge}{ClaimsFault.Zero}{ClaimsNonFault.TwoPlus}", 1.35M},
                { $"{NCB.NewBadge}{ClaimsFault.TwoPlus}{ClaimsNonFault.One}", 1.40M},
                { $"{NCB.NewBadge}{ClaimsFault.One}{ClaimsNonFault.TwoPlus}", 1.45M},
                { $"{NCB.Zero}{ClaimsFault.Zero}{ClaimsNonFault.Zero}", 1.00M},
                { $"{NCB.Zero}{ClaimsFault.One}{ClaimsNonFault.One}", 1.09M},
                { $"{NCB.Zero}{ClaimsFault.TwoPlus}{ClaimsNonFault.TwoPlus}", 1.14M},
                { $"{NCB.Zero}{ClaimsFault.Zero}{ClaimsNonFault.One}", 1.19M},
                { $"{NCB.Zero}{ClaimsFault.One}{ClaimsNonFault.Zero}", 1.24M},
                { $"{NCB.Zero}{ClaimsFault.TwoPlus}{ClaimsNonFault.Zero}", 1.29M},
                { $"{NCB.Zero}{ClaimsFault.Zero}{ClaimsNonFault.TwoPlus}", 1.34M},
                { $"{NCB.Zero}{ClaimsFault.TwoPlus}{ClaimsNonFault.One}", 1.39M},
                { $"{NCB.Zero}{ClaimsFault.One}{ClaimsNonFault.TwoPlus}", 1.44M},
                { $"{NCB.One}{ClaimsFault.Zero}{ClaimsNonFault.Zero}", 1.00M},
                { $"{NCB.One}{ClaimsFault.One}{ClaimsNonFault.One}", 1.08M},
                { $"{NCB.One}{ClaimsFault.TwoPlus}{ClaimsNonFault.TwoPlus}", 1.13M},
                { $"{NCB.One}{ClaimsFault.Zero}{ClaimsNonFault.One}", 1.18M},
                { $"{NCB.One}{ClaimsFault.One}{ClaimsNonFault.Zero}", 1.23M},
                { $"{NCB.One}{ClaimsFault.TwoPlus}{ClaimsNonFault.Zero}", 1.28M},
                { $"{NCB.One}{ClaimsFault.Zero}{ClaimsNonFault.TwoPlus}", 1.33M},
                { $"{NCB.One}{ClaimsFault.TwoPlus}{ClaimsNonFault.One}", 1.38M},
                { $"{NCB.One}{ClaimsFault.One}{ClaimsNonFault.TwoPlus}", 1.43M},
                { $"{NCB.Two}{ClaimsFault.Zero}{ClaimsNonFault.Zero}", 1.00M},
                { $"{NCB.Two}{ClaimsFault.One}{ClaimsNonFault.One}", 1.07M},
                { $"{NCB.Two}{ClaimsFault.TwoPlus}{ClaimsNonFault.TwoPlus}", 1.12M},
                { $"{NCB.Two}{ClaimsFault.Zero}{ClaimsNonFault.One}", 1.17M},
                { $"{NCB.Two}{ClaimsFault.One}{ClaimsNonFault.Zero}", 1.22M},
                { $"{NCB.Two}{ClaimsFault.TwoPlus}{ClaimsNonFault.Zero}", 1.27M},
                { $"{NCB.Two}{ClaimsFault.Zero}{ClaimsNonFault.TwoPlus}", 1.32M},
                { $"{NCB.Two}{ClaimsFault.TwoPlus}{ClaimsNonFault.One}", 1.37M},
                { $"{NCB.Two}{ClaimsFault.One}{ClaimsNonFault.TwoPlus}", 1.42M},
                { $"{NCB.Three}{ClaimsFault.Zero}{ClaimsNonFault.Zero}", 1.00M},
                { $"{NCB.Three}{ClaimsFault.One}{ClaimsNonFault.One}", 1.06M},
                { $"{NCB.Three}{ClaimsFault.TwoPlus}{ClaimsNonFault.TwoPlus}", 1.11M},
                { $"{NCB.Three}{ClaimsFault.Zero}{ClaimsNonFault.One}", 1.16M},
                { $"{NCB.Three}{ClaimsFault.One}{ClaimsNonFault.Zero}", 1.21M},
                { $"{NCB.Three}{ClaimsFault.TwoPlus}{ClaimsNonFault.Zero}", 1.26M},
                { $"{NCB.Three}{ClaimsFault.Zero}{ClaimsNonFault.TwoPlus}", 1.31M},
                { $"{NCB.Three}{ClaimsFault.TwoPlus}{ClaimsNonFault.One}", 1.36M},
                { $"{NCB.Three}{ClaimsFault.One}{ClaimsNonFault.TwoPlus}", 1.41M},
                { $"{NCB.Four}{ClaimsFault.Zero}{ClaimsNonFault.Zero}", 1.00M},
                { $"{NCB.Four}{ClaimsFault.One}{ClaimsNonFault.One}", 1.05M},
                { $"{NCB.Four}{ClaimsFault.TwoPlus}{ClaimsNonFault.TwoPlus}", 1.10M},
                { $"{NCB.Four}{ClaimsFault.Zero}{ClaimsNonFault.One}", 1.15M},
                { $"{NCB.Four}{ClaimsFault.One}{ClaimsNonFault.Zero}", 1.20M},
                { $"{NCB.Four}{ClaimsFault.TwoPlus}{ClaimsNonFault.Zero}", 1.25M},
                { $"{NCB.Four}{ClaimsFault.Zero}{ClaimsNonFault.TwoPlus}", 1.30M},
                { $"{NCB.Four}{ClaimsFault.TwoPlus}{ClaimsNonFault.One}", 1.35M},
                { $"{NCB.Four}{ClaimsFault.One}{ClaimsNonFault.TwoPlus}", 1.40M},
                { $"{NCB.Five}{ClaimsFault.Zero}{ClaimsNonFault.Zero}", 1.00M},
                { $"{NCB.Five}{ClaimsFault.One}{ClaimsNonFault.One}", 1.04M},
                { $"{NCB.Five}{ClaimsFault.TwoPlus}{ClaimsNonFault.TwoPlus}", 1.09M},
                { $"{NCB.Five}{ClaimsFault.Zero}{ClaimsNonFault.One}", 1.14M},
                { $"{NCB.Five}{ClaimsFault.One}{ClaimsNonFault.Zero}", 1.19M},
                { $"{NCB.Five}{ClaimsFault.TwoPlus}{ClaimsNonFault.Zero}", 1.24M},
                { $"{NCB.Five}{ClaimsFault.Zero}{ClaimsNonFault.TwoPlus}", 1.29M},
                { $"{NCB.Five}{ClaimsFault.TwoPlus}{ClaimsNonFault.One}", 1.34M},
                { $"{NCB.Five}{ClaimsFault.One}{ClaimsNonFault.TwoPlus}", 1.39M},
                { $"DEFAULT", 1.0M},
            };

            return caseTable;
        }

        #endregion
    }
}

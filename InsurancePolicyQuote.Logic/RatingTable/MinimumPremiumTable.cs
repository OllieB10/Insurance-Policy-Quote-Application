
using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public class MinimumPremiumTable : IMinimumPremiumTable
    {
        #region Minimum Premium Table

        /// <summary>
        /// This is our minimum premium table which holds our values based on the criteria met.
        /// </summary>
        /// <returns></returns>
        public Dictionary<NCB,decimal> GetMinimumPremiumTable()
        {
            Dictionary<NCB, decimal> minimumPremiumTable = new Dictionary<NCB, decimal>
            {
                { NCB.NewBadge, 900.00M},
                { NCB.Zero, 880.00M},
                { NCB.One, 860.00M},
                { NCB.Two, 840.00M},
                { NCB.Three, 820.00M},
                { NCB.Four, 800.00M},
                { NCB.Five, 790.00M},
                { NCB.SixPlus, 750.00M}
            };

            return minimumPremiumTable;
        }

        #endregion
    }
}

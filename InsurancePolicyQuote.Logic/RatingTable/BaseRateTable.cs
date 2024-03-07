
using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public class BaseRateTable : IBaseRateTable
    {
        #region Base Rate Table

        /// <summary>
        /// This is our minimum premium table which holds our values based on the criteria met.
        /// </summary>
        /// <returns></returns>
        public Dictionary<NCB, decimal> GetBaseRateTable()
        {
            var baseRateTable = new Dictionary<NCB, decimal>
            {
               { NCB.NewBadge, 2200.00M },
               { NCB.Zero, 2000.00M },
               { NCB.One, 1800.00M },
               { NCB.Two, 1700.00M },
               { NCB.Three, 1650.00M },
               { NCB.Four, 1600.00M },
               { NCB.Five, 1600.00M },
               { NCB.SixPlus, 1600.00M }
            };

            return baseRateTable;
        }
        #endregion
    }
}

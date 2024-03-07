using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public class MotorConvictionsTable : IMotorConvictionsTable
    {
        #region Motor Convictions Table

        /// <summary>
        /// This is our minimum premium table which holds our values based on the criteria met.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, decimal> GetMotorConvictionsTable()
        {
            Dictionary<string, decimal> motorConvictionsTable = new Dictionary<string, decimal>
            {
               { "0", 1.0M },
               { "1", 1.05M },
               { "2+", 1.10M },
               { "DEFAULT", 1.00M },
            };

            // Return the table.
            return motorConvictionsTable;
        }
        #endregion
    }
}


using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public class VehicleValueTable : IVehicleValueTable
    {
        #region Vehicle Value Table

        public Dictionary<string, decimal> GetVehicleValueTable()
        {
            var vehValueTable = new Dictionary<string, decimal>
            {
                {$"{VehicleValue.ZeroToNineThousandNineHundredNinetyNine}", 1.05M },
                {$"{VehicleValue.TenThousandToNineteenThousandNineHundredNinetyNine}", 1.02M },
                {$"{VehicleValue.TwentyThousandPlus}", 1.03M },
            };

            return vehValueTable;
        }

        #endregion
    }
}

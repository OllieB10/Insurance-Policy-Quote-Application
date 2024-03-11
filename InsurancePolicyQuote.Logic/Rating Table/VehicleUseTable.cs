
using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public class VehicleUseTable : IVehicleUseTable
    {
        #region Vehicle Use Table

        public Dictionary<VehicleUse, decimal> GetVehicleUseTable()
        {
            var vehicleUseTable = new Dictionary<VehicleUse, decimal>
            {
                {VehicleUse.PublicHire, 1.10M},
                {VehicleUse.PrivateHire, 1.12M},
                {VehicleUse.Other, 1.15M},
            };

            return vehicleUseTable;
        }

        #endregion
    }
}

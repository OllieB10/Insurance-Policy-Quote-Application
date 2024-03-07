
using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public class VehicleTransmissionTable : IVehicleTransmissionTable
    {
        #region Vehicle Transmission Table
        public Dictionary<VehicleTransmission, decimal> GetVehicleTransmissionsTable()
        {
            Dictionary<VehicleTransmission, decimal> vehTransmissionsTable = new Dictionary<VehicleTransmission, decimal>
            {
                { VehicleTransmission.Automatic, 1.02M },
                { VehicleTransmission.Manual, 1.05M}
            };

            return vehTransmissionsTable;
        }

        #endregion
    }
}

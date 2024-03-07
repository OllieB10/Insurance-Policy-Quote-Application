
using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public class VehicleAgeTable : IVehicleAgeTable
    {
        #region Vehicle Age Table

        public Dictionary<string, decimal> GetVehicleAgeTable()
        {
            var vehicleAgeTable = new Dictionary<string, decimal>
            {
                { $"{VehicleAge.One}{NCB.Zero}", 1.05M},
                { $"{VehicleAge.One}{NCB.One}", 1.05M},
                { $"{VehicleAge.One}{NCB.Two}", 1.05M},
                { $"{VehicleAge.One}{NCB.Three}", 1.05M},
                { $"{VehicleAge.One}{NCB.Four}", 1.05M},
                { $"{VehicleAge.One}{NCB.Five}", 1.05M},
                { $"{VehicleAge.Two}{NCB.Zero}", 1.05M},
                { $"{VehicleAge.Two}{NCB.One}", 1.05M},
                { $"{VehicleAge.Two}{NCB.Two}", 1.05M},
                { $"{VehicleAge.Two}{NCB.Three}", 1.05M},
                { $"{VehicleAge.Two}{NCB.Four}", 1.05M},
                { $"{VehicleAge.Two}{NCB.Five}", 1.05M},
                { $"{VehicleAge.Three}{NCB.Zero}", 1.05M},
                { $"{VehicleAge.Three}{NCB.One}", 1.05M},
                { $"{VehicleAge.Three}{NCB.Two}", 1.05M},
                { $"{VehicleAge.Three}{NCB.Three}", 1.05M},
                { $"{VehicleAge.Three}{NCB.Four}", 1.05M},
                { $"{VehicleAge.Three}{NCB.Five}", 1.05M},
                { $"{VehicleAge.Four}{NCB.Zero}", 1.05M},
                { $"{VehicleAge.Four}{NCB.One}", 1.05M},
                { $"{VehicleAge.Four}{NCB.Two}", 1.05M},
                { $"{VehicleAge.Four}{NCB.Three}", 1.05M},
                { $"{VehicleAge.Four}{NCB.Four}", 1.05M},
                { $"{VehicleAge.Four}{NCB.Five}", 1.05M},
                { $"{VehicleAge.Five}{NCB.Zero}", 1.05M},
                { $"{VehicleAge.Five}{NCB.One}", 1.05M},
                { $"{VehicleAge.Five}{NCB.Two}", 1.05M},
                { $"{VehicleAge.Five}{NCB.Three}", 1.05M},
                { $"{VehicleAge.Five}{NCB.Four}", 1.05M},
                { $"{VehicleAge.Five}{NCB.Five}", 1.05M},

            };

            return vehicleAgeTable;
        }

        #endregion
    }
}

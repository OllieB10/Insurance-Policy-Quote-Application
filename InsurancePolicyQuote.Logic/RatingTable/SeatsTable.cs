
using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public class SeatsTable : ISeatsTable
    {
        #region Seats Table

        public Dictionary<VehicleSeats, decimal> GetSeatsTable()
        {
            Dictionary<VehicleSeats,decimal> seatsTable = new Dictionary<VehicleSeats, decimal>
            {
                {VehicleSeats.Five, 1.08M},
                {VehicleSeats.Six, 1.12M},
                {VehicleSeats.Seven, 1.14M},
                {VehicleSeats.Eight, 1.16M},
                {VehicleSeats.Nine, 1.18M},
            };

            return seatsTable;
        }

        #endregion

    }
}

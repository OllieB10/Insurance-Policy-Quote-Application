using InsurancePolicyQuote.Logic;
using System.Collections.Generic;

namespace InsurancePolicyQuoteUI
{
    public class Calculation : ICalculation
    {
        IBaseRateTable baseRateTable = Factory.CreateBaseRateTable();
        IDriverAgeTable driverAgeTable = Factory.CreateDriverAgeTable();
        IVehicleValueTable vehicleValueTable = Factory.CreateVehicleValue();
        IVehicleUseTable vehicleUseTable = Factory.CreateVehicleUseTable();
        ISeatsTable seats = Factory.CreateSeatsTable();
        IVehicleTransmissionTable vehicleTransmissionTable = Factory.CreateVehicleTransmissionTable();
        IMinimumPremiumTable minimumPremiumTable = Factory.CreateMinimumPremiumTable();
        IClaimsTable claimsTable = Factory.CreateClaimsTable();
        IMotorConvictionsTable motorConvictionsTable = Factory.CreateMotorConvictionsTable();

        public decimal CalculateBaseRate(NCB ncb)
        {
            // Get the base rate table.
            Dictionary<NCB, decimal> baseRates = baseRateTable.GetBaseRateTable();

            decimal baseRate = 0;

            bool gotBaseRate = false;

            if (ncb == NCB.NewBadge)
            {
                gotBaseRate = baseRates.TryGetValue(NCB.NewBadge, out baseRate);
            }
            else if (ncb == NCB.Zero)
            {
                gotBaseRate = baseRates.TryGetValue(NCB.Zero, out baseRate);
            }
            else if (ncb == NCB.One)
            {
                gotBaseRate = baseRates.TryGetValue(NCB.One, out baseRate);
            }
            else if (ncb == NCB.Two)
            {
                gotBaseRate = baseRates.TryGetValue(NCB.Two, out baseRate);
            }
            else if (ncb == NCB.Three)
            {
                gotBaseRate = baseRates.TryGetValue(NCB.Three, out baseRate);
            }
            else if (ncb == NCB.Four)
            {
                gotBaseRate = baseRates.TryGetValue(NCB.Four, out baseRate);
            }
            else if (ncb == NCB.Five)
            {
                gotBaseRate = baseRates.TryGetValue(NCB.Five, out baseRate);
            }
            else if (ncb == NCB.SixPlus)
            {
                gotBaseRate = baseRates.TryGetValue(NCB.SixPlus, out baseRate);
            }

            return baseRate;
        }
        public decimal CalculateDriversAge(NCB ncb, DriverAges driverAge)
        {
            decimal driversAgeRate = 0.0M;

            Dictionary<string, decimal> driverAgeTab = driverAgeTable.GetDriverAge();

            if (ncb == NCB.Zero)
            {
                driverAgeTab.TryGetValue($"{NCB.Zero}{driverAge}", out driversAgeRate);
            }
            else if (ncb == NCB.One)
            {
                driverAgeTab.TryGetValue($"{NCB.One}{driverAge}", out driversAgeRate);
            }
            else if (ncb == NCB.Two)
            {
                driverAgeTab.TryGetValue($"{NCB.Two}{driverAge}", out driversAgeRate);
            }
            else if (ncb == NCB.Three)
            {
                driverAgeTab.TryGetValue($"{NCB.Three}{driverAge}", out driversAgeRate);
            }
            else if (ncb == NCB.Four)
            {
                driverAgeTab.TryGetValue($"{NCB.Four}{driverAge}", out driversAgeRate);
            }
            else if (ncb == NCB.Five)
            {
                driverAgeTab.TryGetValue($"{NCB.Five}{driverAge}", out driversAgeRate);
            }
            else if (ncb == NCB.SixPlus)
            {
                driverAgeTab.TryGetValue($"{NCB.SixPlus}{driverAge}", out driversAgeRate);
            }
            else if (ncb == NCB.NewBadge)
            {
                driverAgeTab.TryGetValue($"{NCB.NewBadge}{driverAge}", out driversAgeRate);
            }

            return driversAgeRate;
        }
        public decimal CalculateVehicleValue(IVehicle vehicle)
        {
            Dictionary<string, decimal> vehiclevalue = vehicleValueTable.GetVehicleValueTable();

            // This needs to be placed in our Factory class to adhere to the Dependency Inversion principle.
            VehicleValue vehValue = new VehicleValue();

            decimal estimatedVehiclevalue = 0.0M;

            if (vehicle.EstimatedValue >= 0M && vehicle.EstimatedValue < 10000M)
            {
                vehValue = VehicleValue.ZeroToNineThousandNineHundredNinetyNine;
            }
            else if (vehicle.EstimatedValue >= 10000M && vehicle.EstimatedValue < 19999M)
            {
                vehValue = VehicleValue.TenThousandToNineteenThousandNineHundredNinetyNine;
            }
            else if (vehicle.EstimatedValue >= 20000)
            {
                vehValue = VehicleValue.TwentyThousandPlus;
            }

            if (vehValue == VehicleValue.ZeroToNineThousandNineHundredNinetyNine)
            {
                vehiclevalue.TryGetValue($"{VehicleValue.ZeroToNineThousandNineHundredNinetyNine}", out estimatedVehiclevalue);
            }
            else if (vehValue == VehicleValue.TenThousandToNineteenThousandNineHundredNinetyNine)
            {
                vehiclevalue.TryGetValue($"{VehicleValue.TenThousandToNineteenThousandNineHundredNinetyNine}", out estimatedVehiclevalue);
            }
            else if (vehValue == VehicleValue.TwentyThousandPlus)
            {
                vehiclevalue.TryGetValue($"{VehicleValue.TwentyThousandPlus}", out estimatedVehiclevalue);
            }

            return estimatedVehiclevalue;

        }
        public decimal CalculateVehicleUse(VehicleUse vehicleUse)
        {
            // Get out Vehicle Use table.
            Dictionary<VehicleUse, decimal> vehicleUseTab = vehicleUseTable.GetVehicleUseTable();

            // Set a default starting value 
            decimal vehicleUseRate = 0.0M;

            if (vehicleUse == VehicleUse.PrivateHire)
            {
                vehicleUseTab.TryGetValue(VehicleUse.PrivateHire, out vehicleUseRate);
            }
            else if (vehicleUse == VehicleUse.PublicHire)
            {
                vehicleUseTab.TryGetValue(VehicleUse.PublicHire, out vehicleUseRate);
            }
            else if (vehicleUse == VehicleUse.Other)
            {
                vehicleUseTab.TryGetValue(VehicleUse.Other, out vehicleUseRate);
            }

            return vehicleUseRate;
        }
        public decimal CalculateVehicleSeatsRate(IVehicle vehicle)
        {
            Dictionary<VehicleSeats, decimal> seatsTable = seats.GetSeatsTable();

            VehicleSeats vehicleSeats = new VehicleSeats();

            decimal seatsRate = 0.0M;

            if (vehicle.NoOfSeats == 5)
            {
                vehicleSeats = VehicleSeats.Five;
            }
            else if (vehicle.NoOfSeats == 6)
            {
                vehicleSeats = VehicleSeats.Six;
            }
            else if (vehicle.NoOfSeats == 7)
            {
                vehicleSeats = VehicleSeats.Seven;
            }
            else if (vehicle.NoOfSeats == 8)
            {
                vehicleSeats = VehicleSeats.Eight;
            }
            else if (vehicle.NoOfSeats == 9)
            {
                vehicleSeats = VehicleSeats.Nine;
            }

            seatsTable.TryGetValue(vehicleSeats, out seatsRate);

            return seatsRate;
        }
        public decimal CalculateVehicleTransmissionRate(VehicleTransmission vehicleTransmission)
        {
            Dictionary<VehicleTransmission, decimal> vehicleTransTable = vehicleTransmissionTable.GetVehicleTransmissionsTable();

            decimal vehicleTransmissionRate = 0;

            if (vehicleTransmission == VehicleTransmission.Manual)
            {
                vehicleTransTable.TryGetValue(VehicleTransmission.Manual, out vehicleTransmissionRate);
            }
            else if (vehicleTransmission == VehicleTransmission.Automatic)
            {
                vehicleTransTable.TryGetValue(VehicleTransmission.Automatic, out vehicleTransmissionRate);
            }

            return vehicleTransmissionRate;
        }
        public decimal CalculateMinimumPremium(NCB ncb)
        {
            Dictionary<NCB, decimal> minPremTable = minimumPremiumTable.GetMinimumPremiumTable();

            decimal minPremValue = 0.0M;

            if (ncb == NCB.NewBadge)
            {
                minPremTable.TryGetValue(NCB.NewBadge, out minPremValue);
            }
            else if (ncb == NCB.Zero)
            {
                minPremTable.TryGetValue(NCB.Zero, out minPremValue);
            }
            else if (ncb == NCB.One)
            {
                minPremTable.TryGetValue(NCB.One, out minPremValue);
            }
            else if (ncb == NCB.Two)
            {
                minPremTable.TryGetValue(NCB.Two, out minPremValue);
            }
            else if (ncb == NCB.Three)
            {
                minPremTable.TryGetValue(NCB.Three, out minPremValue);
            }
            else if (ncb == NCB.Four)
            {
                minPremTable.TryGetValue(NCB.Four, out minPremValue);
            }
            else if (ncb == NCB.Five)
            {
                minPremTable.TryGetValue(NCB.Five, out minPremValue);
            }
            else if (ncb == NCB.SixPlus)
            {
                minPremTable.TryGetValue(NCB.SixPlus, out minPremValue);
            }

            return minPremValue;
        }
        public decimal CalculateClaimsRate(List<MotorClaim> motorClaims, NCB ncb)
        {
            // Get the claims Table key.
            string claimsTableKey = GetClaimsKey(motorClaims, ncb);

            // Get the table contents.
            Dictionary<string, decimal> claims = claimsTable.GetClaimsTable();

            // Create our initial value.
            decimal claimsRate = 0.0M;

            // Get the rate or the default.
            claims.TryGetValue(claimsTableKey, out claimsRate);

            // Return the Rate e.g 1.04
            return claimsRate;
        }
        public string GetClaimsKey(List<MotorClaim> motorClaims, NCB ncb)
        {
            int nonFaultClaims = 0;
            int faultClaims = 0;

            if (motorClaims.Count != 0)
            {
                foreach (MotorClaim claim in motorClaims)
                {
                    if (claim.AtFault)
                    {
                        faultClaims++;
                    }
                    else if (!claim.AtFault)
                    {
                        nonFaultClaims++;
                    }
                }

                if (faultClaims == 0 && nonFaultClaims == 1)
                {
                    return $"{ncb}{ClaimsFault.Zero}{ClaimsNonFault.One}";
                }
                else if (faultClaims == 1 && nonFaultClaims == 0)
                {
                    return $"{ncb}{ClaimsFault.One}{ClaimsNonFault.Zero}";
                }
                else if (faultClaims == 1 && nonFaultClaims == 1)
                {
                    return $"{ncb}{ClaimsFault.One}{ClaimsNonFault.One}";
                }
                else if (faultClaims == 0 && nonFaultClaims >= 2)
                {
                    return $"{ncb}{ClaimsFault.Zero}{ClaimsNonFault.TwoPlus}";
                }
                else if (faultClaims >= 2 && nonFaultClaims >= 0)
                {
                    return $"{ncb}{ClaimsFault.TwoPlus}{ClaimsNonFault.Zero}";
                }
                else if (faultClaims == 1 && nonFaultClaims >= 2)
                {
                    return $"{ncb}{ClaimsFault.One}{ClaimsNonFault.TwoPlus}";
                }
                else if (faultClaims >= 2 && nonFaultClaims == 1)
                {
                    return $"{ncb}{ClaimsFault.TwoPlus}{ClaimsNonFault.One}";
                }
                else if (faultClaims >= 2 && nonFaultClaims >= 2)
                {
                    return $"{ncb}{ClaimsFault.TwoPlus}{ClaimsNonFault.One}";
                }
            }
            else
            {
               return $"{ncb}{ClaimsFault.Zero}{ClaimsNonFault.Zero}";
            }

            return "DEFAULT";
        }
        public decimal CalculateMotorConvictions(int motorConvictions)
        {
            string motorConTableKey = GetMotorConvictionsKey(motorConvictions);

            decimal motConRate = 0.0M;

            Dictionary<string, decimal> motorConTable = motorConvictionsTable.GetMotorConvictionsTable();

            motorConTable.TryGetValue(motorConTableKey, out motConRate);

            return motConRate;
        }
        public string GetMotorConvictionsKey(int motorConvictions)
        {

            if (motorConvictions == 0)
            {
                return "0";
            }
            else if (motorConvictions == 1)
            {
                return "1";
            }
            else if (motorConvictions >= 2)
            {
                return "2+";
            }
            else
            {
                return "DEFAULT";
            }
        }
    }
}

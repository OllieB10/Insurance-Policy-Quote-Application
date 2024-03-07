using System;
using System.Linq;
using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;

namespace InsurancePolicyQuoteUI
{
    public class VehicleInputDetails : IVehicleInputDetails
    {
        IReadFromConsole readFromConsole = Factory.ReadFromConsole();
        IProposerMessages proposerMessages = Factory.CreateProposerMessages();
        IExitApplication exitApplication = Factory.ExitApplication();
        IBlankLine blankLine = Factory.CreateBlankLine();
        IValidateUserInput validateUserInput = Factory.ValidateUserInput();

        private bool CheckValidParkingOvernightLocation(ParkingLocations parkingLocation)
        {
            ParkingLocations[] allowedUses = { ParkingLocations.Carpark, ParkingLocations.Garage, ParkingLocations.Driveway, ParkingLocations.Street, ParkingLocations.Other};

            return allowedUses.Contains(parkingLocation);
        }

        private bool CheckValidVehicleUse(VehicleUse vehicleUse)
        {
            VehicleUse[] allowedUses = { VehicleUse.PublicHire, VehicleUse.PrivateHire, VehicleUse.Other };

            return allowedUses.Contains(vehicleUse);
        }

        public VehicleUse GetVehicleUsage(string input)
        {
            input = validateUserInput.GetValidUserInput(input);

            VehicleUse vehicleUse;

            if (input.StartsWith("Public"))
            {
                input = "PublicHire";
            }
            else if (input.StartsWith("Private"))
            {
                input = "PrivateHire";
            }
            else if (input.StartsWith("Other"))
            {
                input = "Other";
            }

            //if the user input is invalid then keep them looped until the input is valid unless they choose to exit. 
            while (!Enum.TryParse(input, true, out vehicleUse) && CheckValidVehicleUse(vehicleUse))
            {
                blankLine.CreateBlankLine();

                proposerMessages.MessageUser("You have entered an invalid vehicle usage, it must not contain any special characters or must be one of the vehicle uses in the prior message, type exit to exit the application or type a valid vehicle use to continue with the quote. ");

                input = readFromConsole.ReadInputFromConsole();

                //Provide the user with the choice to exit.
                exitApplication.CheckAndExitIfRequested(input);
            }

            return vehicleUse;
        }

        private bool CheckValidVehicleTransmission(VehicleTransmission vehicleTransmission)
        {
            VehicleTransmission[] allowedTransmissions = { VehicleTransmission.Automatic, VehicleTransmission.Manual};

            return allowedTransmissions.Contains(vehicleTransmission);
        }

        public VehicleTransmission GetValidVehicleTransmission(string input)
        {
            input = validateUserInput.GetValidUserInput(input);

            VehicleTransmission vehicleTransmissions;

            //if the user input is invalid then keep them looped until input is valid unless they choose to exit. 
            while (!Enum.TryParse(input, true, out vehicleTransmissions) && CheckValidVehicleTransmission(vehicleTransmissions))
            {             
               blankLine.CreateBlankLine();

               proposerMessages.MessageUser("You have entered an invalid vehicle usage, it must not contain any special characters or must be one of the vehicle uses in the prior message, type 'exit' to quit the application or type a valid vehicle use to continue with your quote. ");

               input = readFromConsole.ReadInputFromConsole();

               //Provide the user with the choice to exit.
               exitApplication.CheckAndExitIfRequested(input);                      
            }

            return vehicleTransmissions;
        }

        public ParkingLocations GetValidParkingLocation(string input)
        {
            ParkingLocations parkingLocations;

            //if the user input is invalid then keep them looped until input is valid unless they choose to exit. 
            while (!Enum.TryParse(input, true, out parkingLocations) && CheckValidParkingOvernightLocation(parkingLocations))
            {
                proposerMessages.MessageUser("You have entered an invalid vehicle usage, it must not contain any special characters or must be one of the vehicle uses in the prior message, type exit to exit the application or type a valid vehicle use to continue with the quote. ");

                input = readFromConsole.ReadInputFromConsole();

                //Provide the user with the choice to exit.
                exitApplication.CheckAndExitIfRequested(input);
            }

            return parkingLocations;
        }

        public bool CheckNumberOfSeats(string input)
        {
            if (!int.TryParse(input, out int numberOfSeats))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int GetNumberOfSeats(string input)
        {
            int numberOfSeats = 0;

            int result = 0;

            if (CheckNumberOfSeats(input))
            {
                int.TryParse(input, out int vehicleSeats);
                result = vehicleSeats;  // Assign the value before the condition check

                if (result >= 5 && result <= 9)
                {
                    return result;  // Return the valid result immediately
                }
            }

            // Use the logical AND operator instead of logical OR in the while loop condition
            while (!CheckNumberOfSeats(input) || result < 5 || result > 9)
            {
                blankLine.CreateBlankLine();

                // Ask the user again for valid input.
                proposerMessages.MessageUser("You have entered an invalid number of seats, please enter a number from 1 to 9 or type 'exit' to exit the application.");

                input = readFromConsole.ReadInputFromConsole();

                // Provide the user with the choice to exit.
                exitApplication.CheckAndExitIfRequested(input);

                // if we can parse the input to an int and the value is within our parameters then return the number.
                if (int.TryParse(input, out numberOfSeats) && numberOfSeats >= 1 && numberOfSeats <= 16)
                {
                    return numberOfSeats; // Valid input, exit the loop.
                }

                // Assign the parsed value to result
                result = numberOfSeats;
            }

            // Return the number of seats
            return numberOfSeats;
        }

        public bool CheckEstimatedVehicleValue(string input)
        {
            if (!decimal.TryParse(input, out decimal vehicleValue))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public decimal GetEstimatedVehicleValue(string input)
        {
            if (input.StartsWith("£"))
            {
                input = input.Replace("£", "");
            }

            while (!CheckEstimatedVehicleValue(input))
            {
                blankLine.CreateBlankLine();

                proposerMessages.MessageUser("You have entered an invalid estimated vehicle value, enter the value again or type 'exit' to exit the application.");
                input = readFromConsole.ReadInputFromConsole();

                //Provide the user with the choice to exit.
                exitApplication.CheckAndExitIfRequested(input);
            }

            decimal result;

            decimal.TryParse(input, out result);

            return result;
        }
    }
}

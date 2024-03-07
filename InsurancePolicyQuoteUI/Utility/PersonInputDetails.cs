using InsurancePolicyQuote.Logic;
using InsurancePolicyQuoteUI;
using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace InsurancePolicyQuoteUI
{

    public class PersonInputDetails : IPersonInputDetails
    {
        IBlankLine blankLine = Factory.CreateBlankLine();
        IReadFromConsole readFromConsole = Factory.ReadFromConsole();
        IProposerMessages proposerMessages = Factory.CreateProposerMessages();
        IExitApplication exitApplication = Factory.ExitApplication();
        IValidateUserInput validateUserInput = Factory.ValidateUserInput();

        #region Gender Logic

        /// <summary>
        ///  Check if we have the gender the user has enterd.
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        public bool CheckValidGender(Gender gender)
        {
            Gender[] allowedGenders = { Gender.Male, Gender.Female, Gender.Other };

            return allowedGenders.Contains(gender);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isGenderValid"></param>
        /// <param name="gender"></param>
        /// <returns></returns>
        public Gender GetValidGender(string input)
        {
            input = validateUserInput.GetValidUserInput(input);

            // variable to store the users gender.
            Gender gender;

            // While we cannot parse or have the releavant gender the user wants then we keep them trpped until we have it.
            while (!Enum.TryParse(input, true, out gender) || !CheckValidGender(gender))
            {
                // New Line
                blankLine.CreateBlankLine();
                //Inform user
                proposerMessages.MessageUser("The gender you entered is invalid, it cannot contain any special characters and must be either Male, Female or Other. " +
                                                 "Please enter your gender again or type 'exit' to quit.");

                // Store the users new response.
                input = readFromConsole.ReadInputFromConsole();

                //Check the desire to exit the application.
                exitApplication.CheckAndExitIfRequested(input);
            }

            // We must have a valid gender to get to here.
            return gender;
        }

        #endregion

        #region Relationship Status

        private bool CheckValidRelationshipStatus(RelationshipStatus status)
        {
            RelationshipStatus[] allowedStatuses = { RelationshipStatus.Married, RelationshipStatus.Single, RelationshipStatus.Separated, RelationshipStatus.Widowed, RelationshipStatus.Divorced, RelationshipStatus.LivingWithPartner };

            return allowedStatuses.Contains(status);
        }

        public RelationshipStatus GetValidRelationshipStatus(string input)
        {
            input = validateUserInput.FormatInputString(input);

            RelationshipStatus status;

            while (!Enum.TryParse(input, true, out status) || !CheckValidRelationshipStatus(status))
            {
                // New Line
                blankLine.CreateBlankLine();

                // Inform user
                proposerMessages.MessageUser("The relationship status you entered is invalid, it cannot contain any special characters and must be either Married, Single Separated, Widowed, Divorced or Living with Partner");

                // New Line
                blankLine.CreateBlankLine();

                // Ask user to enter their first name again.
                proposerMessages.MessageUser("Please enter your relationship status again (or type 'exit' to quit):  ");
                input = readFromConsole.ReadInputFromConsole();

                // Check the desire to exit the application.
                exitApplication.CheckAndExitIfRequested(input);
            }

            return status;
        }

        #endregion

        #region Email Address Logic

        /// <summary>
        /// Check that the email address is valid using Regex.
        /// </summary>
        public bool CheckValidEmailAddress(string email)
        {
            //regex patterns are used to determine e.g whether it is valid.
            string pattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";

            //Check if the email is valid or not.
            bool isMatch = Regex.IsMatch(email, pattern);

            return isMatch;
        }

        /// <summary>
        /// Return a valid email address.
        /// </summary>
        /// <param name="isEmailValid"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public string GetValidEmailAddress(string email)
        {
            email = email.Trim();

            string pattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";

            if (!CheckValidEmailAddress(email))
            {
                //The email address is not valid, Keep them in here until they provide a legit email.
                while (!Regex.IsMatch(email, pattern))
                {
                    //Inform user.
                    proposerMessages.MessageUser("The email address you entered is invalid.");

                    // New Line
                    blankLine.CreateBlankLine();

                    //Ask user to enter their first name again.
                    proposerMessages.MessageUser("Please enter your email address again or type 'exit' to quit.  ");

                    email = readFromConsole.ReadInputFromConsole();

                    //Give the user a way to exit the application if desired.
                    exitApplication.CheckAndExitIfRequested(email);
                }

                //return the new valid email address.
                return email;
            }

            //Return the original email as it is valid.
            return email;
        }

        #endregion
    }
}

namespace InsurancePolicyQuote.Logic
{
    public interface IProposerMessages
    {
        void AskAnyCashPaymentsTaken();
        void AskAnyConvictions();
        void AskAnyCriminalConvictions();
        void AskAnyMoreIncidents();
        void AskAnyPointsGiven();
        void AskAtFault();
        void AskClaimMadeAgainstPolicy();
        void AskConvictionDate();
        void AskDateCurrentLicenceObtained();
        void AskDateOfBirth();
        void AskDatePurchasedVehicle();
        void AskDateResidentSince();
        void AskDisqualifiedFromDriving();
        void AskEmailAddress();
        void AskFirstName();
        void AskForClaimAmount();
        void AskForClaimStatus();
        void AskForClaimType();
        void AskForClaimDate();
        void AskForDVLAOffenceCode();
        void AskForFineAmount();
        void AskForIncidentdate();
        void AskForLicenceType();
        void AskForNumberOfSeats();
        void AskForPlatedCouncil();
        void AskForTheftType();
        void AskForTotalPoints();
        void AskGender();
        void AskHowLongBannedFor();
        void AskHowManyNCD();
        void AskIfFineOccurred();
        void AskIfProposerRegisteredKeeper();
        void AskIncidentType();
        void AskLastName();
        void AskNoClaimsDiscountAffected();
        void AskOffenceDate();
        void AskPolicyStartDate();
        void AskPreviouslyHadTermsApplied();
        void AskPreviouslyRefusedCover();
        void AskProtectNCB();
        void AskRelationshipStatus();
        void AskResidentSinceBirth();
        void AskVehicleImported();
        void AskVehicleKeptAtHomeOverNight();
        void AskVehicleLocationOverNight();
        void AskVehicleMileage();
        void AskVehicleUsage();
        void AskWhatCoverTheyWant();
        void AskWhetherHaveFullUkLicence();
        void AskWhoIsLegalOwner();
        void AskYearOfManufacture();
        void MessageUser(string message);
        void WelcomeUser();
        void AskAnyMotorClaims();
        void AskEstimatedVehicleValue();
        void AskVehicleTransmissionType();
        void AskHowManyMotorConvictions();
    }
}
using System;

namespace InsurancePolicyQuote.Logic
{
    public interface IProposer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        string EmailAddress { get; set; }
        bool ResidentSinceBirth { get; set; }
        bool HomeOwner { get; set; }
        int UKResidenceYears { get; set; }
        DateTime UKResidenceDate { get; set; }
        bool CriminalConvictions { get; set; }
        RelationshipStatus RelationshipStatus { get; set; }
    }
}
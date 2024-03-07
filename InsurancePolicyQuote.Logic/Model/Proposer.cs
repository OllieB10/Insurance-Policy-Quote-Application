using System;

namespace InsurancePolicyQuote.Logic
{
    public class Proposer : IProposer
    {
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
        public RelationshipStatus RelationshipStatus { get; set; }
        public bool CriminalConvictions { get; set; }
        public string LastName { get; set; }
        public bool ResidentSinceBirth { get; set; }
        public string Telephone { get; set; }
        public bool HomeOwner { get; set; }
        public int UKResidenceYears { get; set; }
        public DateTime UKResidenceDate { get; set; }
        
    }
}

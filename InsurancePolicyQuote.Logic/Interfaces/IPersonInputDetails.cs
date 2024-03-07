
namespace InsurancePolicyQuote.Logic
{
    public interface IPersonInputDetails
    {
        bool CheckValidEmailAddress(string email);
        bool CheckValidGender(Gender gender);
        string GetValidEmailAddress(string email);
        Gender GetValidGender(string input);
        RelationshipStatus GetValidRelationshipStatus(string input);
    }
}
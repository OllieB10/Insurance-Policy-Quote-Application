

namespace InsurancePolicyQuote.Logic
{
    public interface ILicenceInputDetails
    {
        LicenceType GetValidLicenceType(string input);
    }
}
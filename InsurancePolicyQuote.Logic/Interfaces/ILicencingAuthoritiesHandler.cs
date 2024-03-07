using System.Collections.Generic;

namespace InsurancePolicyQuote.Logic
{
    public interface ILicencingAuthoritiesHandler
    {
        bool CheckValidLicencingAuthority(string input);
        List<string> GetLicencingAuthoritiesTable();
        string GetValidLicencingAuthority(string input);
    }
}
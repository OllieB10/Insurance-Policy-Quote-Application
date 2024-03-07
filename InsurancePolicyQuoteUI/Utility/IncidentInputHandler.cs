using InsurancePolicyQuote.Logic;

namespace InsurancePolicyQuoteUI
{
    public class IncidentInputHandler : IIncidentInputHandler
    {
        public bool CheckMoreIncidents(bool moreIncidents)
        {
            // If we have more incidents repeat the questions and add the next claim to the list.
            if (moreIncidents)
            {
                return true;
            }
            // No more claims then exit the claims section.
            else
            {
                return false;
            }
        }
    }
}

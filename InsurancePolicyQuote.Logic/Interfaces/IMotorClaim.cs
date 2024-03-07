
namespace InsurancePolicyQuote.Logic
{
    public interface IMotorClaim
    {
        bool AtFault { get; set; }           
        IncidentType IncidentType { get; set; }       
    }
}
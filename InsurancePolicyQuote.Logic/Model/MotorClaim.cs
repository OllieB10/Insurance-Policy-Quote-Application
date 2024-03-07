
namespace InsurancePolicyQuote.Logic
{
    /// <summary>
    /// Motor claim object.
    /// </summary>
    public class MotorClaim : IMotorClaim
    {
        public bool AtFault { get; set; }
        public IncidentType IncidentType { get; set; }
    }
}

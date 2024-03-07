namespace InsurancePolicyQuote.Logic
{
    public interface IDriverInputDetails
    {
        IncidentType GetValidIncidentType(string input);
        DriverAges GetDriverAgeEnum(int yearAtInception);
    }
}
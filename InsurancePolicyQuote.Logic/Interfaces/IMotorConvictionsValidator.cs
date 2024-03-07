namespace InsurancePolicyQuote.Logic
{
    public interface IMotorConvictionsValidator
    {
        bool CheckMotoringConvictionsValidValue(string usersAnswer);
        int ConvertUsersMotoringConvictions(string usersAnswer);
        string GetMotorConvictionType(int crimConvicCode);
        string MotoringConvictions(int usersAnswer);
    }
}
namespace _2048.UserData.DataValidation
{
    public class DirectionDataValidation : IDataValidation<int>
    {
        public bool IsValid(int value)
        {
            bool result = value >= 0 && value <= 3;
            return result;
        }
    }
}

namespace _2048.UserData.DataValidation
{
    public interface IDataValidation<T>
    {
        bool IsValid(T value);
    }
}

using _2048.UserData.DataValidation;

namespace _2048.UserData
{
    public interface IUserInput<T>
    {
        T ReadSingleInput(IDataValidation<T> dataValidation);
        T[,] ReadGridInput(IDataValidation<T[,]> dataValidation, int gridSize);
    }
}

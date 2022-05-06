using _2048.UserData.DataConvertion;
using _2048.UserData.DataValidation;
using _2048.UserData.InputReader;
using System;

namespace _2048.UserData
{
    public class UserInput : IUserInput<int>
    {
        private readonly IInputRead _inputRead;
        private readonly IDataConverter<string, int> _dataConverter;

        public UserInput(
            IInputRead inputRead,
            IDataConverter<string, int> dataConverter)
        {
            _inputRead = inputRead;
            _dataConverter = dataConverter;
        }

        public int[,] ReadGridInput(IDataValidation<int[,]> dataValidation, int gridSize)
        {
            string[] userInputArray = new string[gridSize];
            for (int row = 0; row < gridSize; row++)
            {
                userInputArray[row] = _inputRead.RetreiveData();
            }
            int[,] gridArea = _dataConverter.Convert(userInputArray);
            if (dataValidation.IsValid(gridArea) == false)
            {
                throw new ArgumentException("Input not valid!");
            }
            return gridArea;
        }

        public int ReadSingleInput(IDataValidation<int> dataValidation)
        {
            string userInput = _inputRead.RetreiveData();
            int result = _dataConverter.Convert(userInput);
            if (dataValidation.IsValid(result) == false)
            {
                throw new ArgumentException("Input not valid!");
            }
            return result;
        }
    }
}

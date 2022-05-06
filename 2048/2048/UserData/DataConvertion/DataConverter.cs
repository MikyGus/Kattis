using System;

namespace _2048.UserData.DataConvertion
{
    public class DataConverter : IDataConverter<string, int>
    {

        public int Convert(string source)
        {
            if (!int.TryParse(source, out int convertedValue))
            {
                throw new ArgumentException("Invalid input, Not an integer!");
            }
            return convertedValue;
        }

        public int[,] Convert(string[] source)
        {
            int gridSize = source.GetLength(0);
            var grid = new int[gridSize, gridSize];
            for (int row = 0; row < gridSize; row++)
            {
                int[] inputArray = Convert(source[row], gridSize);
                for (int col = 0; col < gridSize; col++)
                {
                    grid[col, row] = inputArray[col];
                }
            }
            return grid;
        }

        public int[] Convert(string source, int arraySize)
        {
            int[] arrayWithInt = new int[arraySize];
            string[] arrayWithString = source.Split(' ');
            if (arrayWithString.Length != arraySize)
            {
                throw new ArgumentException("Invalid input, wrong length of array!");
            }
            for (int i = 0; i < arraySize; i++)
            {
                arrayWithInt[i] = Convert(arrayWithString[i]);
            }
            return arrayWithInt;

        }
    }
}

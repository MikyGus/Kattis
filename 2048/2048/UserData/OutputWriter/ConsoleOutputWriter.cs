using _2048.Grid;
using System;

namespace _2048.UserData.OutputWriter
{
    public class ConsoleOutputWriter : IOutputWrite
    {
        public void WriteData(IGridArea gridArea)
        {
            for (int row = 0; row < gridArea.GridSize; row++)
            {
                PrintRow(row, gridArea);
            }
        }

        private void PrintRow(int row, IGridArea gridArea)
        {
            for (int column = 0; column < gridArea.GridSize; column++)
            {
                PrintValue(gridArea.Grid[column, row], column, gridArea.GridSize);
            }
        }

        private void PrintValue(int value, int currentPosition, int gridSize)
        {
            if (currentPosition > 0)
            {
                Console.Write(" ");
            }
            if (currentPosition == gridSize - 1)
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.Write(value);
            }
        }
    }
}

using _2048.Grid;
using _2048.Grid.Movement;
using _2048.UserData;
using _2048.UserData.DataConvertion;
using _2048.UserData.DataValidation;
using _2048.UserData.InputReader;
using System;
using System.Drawing;

namespace _2048
{
    public class Program
    {
        static void Main()
        {
            IInputRead inputRead = new ConsoleInputRead();
            IDataConverter<string,int> dataConverter = new DataConverter();
            IDataValidation<int> directionValidation = new DirectionDataValidation();
            IDataValidation<int[,]> gridValidation = new GridDataValidation();
            IUserInput<int> userInput = new UserInput(inputRead,dataConverter);
            int[,] gridArea = userInput.ReadGridInput(gridValidation,4);
            int moveDirection = userInput.ReadSingleInput(directionValidation);


            IGridArea grid = new GridArea(gridArea);
            GridNavigator gridNavigator = new GridNavigator(grid);
            gridNavigator.MoveGridInDirection(moveDirection);

            //IGridManager gridManager = new GridManager(grid);



            //const int gridSize = 4;
            //DataValidator validator = new DataValidator();
            //___InputReader input = new ___InputReader(validator.IsValid2048Data);
            //int[,] grid = input.ReadInputToGrid(gridSize);
            //input.SetValidData(validator.IsValidDirection);
            //int moveDirection = input.ReadInputToInt();

            //GridManager gridManager = new GridManager(grid);
            //gridManager.FindCellToMoveTo(new Point(1, 2), moveDirection);
        }


    }
}

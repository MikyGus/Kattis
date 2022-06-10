using _2048.Grid;
using _2048.Grid.MoveDirection;
using _2048.UserData;
using _2048.UserData.DataConvertion;
using _2048.UserData.DataValidation;
using _2048.UserData.InputReader;
using _2048.UserData.OutputWriter;

namespace _2048
{
    public class Program
    {
        const int gridSize = 4;
        static void Main()
        {
            IInputRead inputRead = new ConsoleInputRead();
            IDataConverter<string, int> dataConverter = new DataConverter();
            IDataValidation<int> directionValidation = new DirectionDataValidation();
            IDataValidation<int[,]> gridValidation = new GridDataValidation();
            IUserInput<int> userInput = new UserInput(inputRead, dataConverter);
            int[,] gridArea = userInput.ReadGridInput(gridValidation, gridSize);
            int moveInput = userInput.ReadSingleInput(directionValidation);


            IGridArea grid = new GridArea(gridArea);
            IMoveDirection moveDirection = MoveDirectionFactory.Create(moveInput, gridSize);
            IGridNavigator gridNavigator = new GridNavigator(grid);
            gridNavigator.MoveGridInDirection(moveDirection);


            IOutputWrite output = new ConsoleOutputWriter();
            output.WriteData(gridNavigator.GetGridArea());
        }
    }
}

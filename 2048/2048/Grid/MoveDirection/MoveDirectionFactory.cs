namespace _2048.Grid.MoveDirection
{
    public class MoveDirectionFactory
    {
        public static IMoveDirection Create(int moveDirection, int gridSize)
        {
            switch (moveDirection)
            {
                case 0:                                                                                                              
                    return new MoveDirectionLeft(gridSize);
                case 1:
                    return new MoveDirectionUp(gridSize);
                case 2:
                    return new MoveDirectionRight(gridSize);
                case 3:
                    return new MoveDirectionDown(gridSize);
                default:
                    throw new Exceptions.InvalidMoveDirection(moveDirection);
            }
        }
    }
}

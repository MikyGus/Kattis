using _2048.Grid.MoveDirection;

namespace _2048.Grid
{
    public interface IGridNavigator
    {
        void MoveGridInDirection(IMoveDirection direction);
    }
}

using System.Drawing;

namespace _2048.Grid.MoveDirection
{
    public interface IMoveDirection
    {
        public Point Vector { get; }
        public Point StartPosition(int positionIndex);
    }
}

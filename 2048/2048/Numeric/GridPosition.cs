namespace _2048.Numeric
{
    public class GridPosition
    {
        public GridPosition()
        {
        }

        public GridPosition(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        public static GridPosition operator +(GridPosition a, GridPosition b)
            => new GridPosition(a.X + b.X, a.Y + b.Y);
        public static GridPosition operator -(GridPosition a, GridPosition b)
            => new GridPosition(a.X - b.X, a.Y - b.Y);
    }
}

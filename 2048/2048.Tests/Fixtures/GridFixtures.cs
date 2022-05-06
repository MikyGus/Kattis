using System.Drawing;

namespace _2048.Tests.Fixtures
{
    internal class GridFixtures
    {

        public static int[,] Origin()
        {
            return new int[,]
            {
                { 2, 2, 4, 4 },
                { 0, 4, 2, 2 },
                { 0, 0, 0, 2 },
                { 2, 0, 0, 2 }
            };
        }

        public static int[,] Result_Cell1x1Up()
        {
            return new int[,]
            {
                { 2, 2, 4, 4 },
                { 4, 0, 2, 2 },
                { 0, 0, 0, 2 },
                { 2, 0, 0, 2 }
            };
        }

        public static Point[] CellArrayWhenGridUp()
        {
            return new Point[]
                {
                    new Point(0, 1),
                    new Point(1, 1),
                    new Point(2, 1),
                    new Point(3, 1),

                    new Point(0, 2),
                    new Point(1, 2),
                    new Point(2, 2),
                    new Point(3, 2),

                    new Point(0, 3),
                    new Point(1, 3),
                    new Point(2, 3),
                    new Point(3, 3),
                };
        }

        public static Point[] CellArrayWhenGridLeft()
        {
            return new Point[]
                {
                    new Point(1, 0),
                    new Point(2, 0),
                    new Point(3, 0),

                    new Point(1, 1),
                    new Point(2, 1),
                    new Point(3, 1),

                    new Point(1, 2),
                    new Point(2, 2),
                    new Point(3, 2),

                    new Point(1, 3),
                    new Point(2, 3),
                    new Point(3, 3),
                };
        }

        // Valid values: { 0, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 }
        public static int[,] GridDataValid()
        {
            return new int[,]
            {
                { 2, 2, 4, 1024},
                { 2, 8, 2, 512 },
                { 0, 16, 64, 256 },
                { 2, 0, 0, 128 }
            };
        }
        public static int[,] GridDataInValid()
        {
            return new int[,]
            {
                { 2, 2, 4, 1024},
                { 2, 8, 26, 512 },
                { 0, 16, 64, 256 },
                { 2, 0, -10, 128 }
            };
        }
    }
}

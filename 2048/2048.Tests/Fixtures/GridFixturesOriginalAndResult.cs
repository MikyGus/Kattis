namespace _2048.Tests.Fixtures
{
    internal class GridFixturesOriginalAndResult
    {
        public static int[,] Start(int index)
        {
            switch (index)
            {
                case 0:
                    return new int[,]
                    {
                        { 2, 4, 2, 1024 },
                        { 0, 16, 64, 1024 },
                        { 0, 8, 32, 64 },
                        { 2, 2, 4, 0 }
                    };

                default:
                    return new int[,]
                    {
                        { 2, 2, 4, 4 },
                        { 0, 4, 2, 2 },
                        { 0, 0, 0, 2 },
                        { 2, 0, 0, 2 }
                    };
            }
        }

        public static int[,] Result(int index)
        {
            switch (index)
            {
                case 0:
                    return new int[,]
                    {
                        { 4, 4, 2, 2048 },
                        { 0, 16, 64, 64 },
                        { 0, 8, 32, 0 },
                        { 0, 2, 4, 0 }
                    };
                case 1:
                    return new int[,]
                    {
                        { 2, 4, 2, 1024 },
                        { 16, 64, 1024, 0 },
                        { 8, 32, 64, 0 },
                        { 4, 4, 0, 0 }
                    };
                case 2:
                    return new int[,]
                    {
                        { 0, 4, 2, 0 },
                        { 0, 16, 64, 0 },
                        { 0, 8, 32, 2048 },
                        { 4, 2, 4, 64 }
                    };
                case 3:
                    return new int[,]
                    {
                        { 2, 4, 2, 1024 },
                        { 0, 16, 64, 1024 },
                        { 0, 8, 32, 64 },
                        { 0, 0, 4, 4 }
                    };
                default:
                    return new int[,]
                    {
                        { 2, 2, 4, 4 },
                        { 0, 4, 2, 2 },
                        { 0, 0, 0, 2 },
                        { 2, 0, 0, 2 }
                    };
            }
        }

        private static int[,] Result_01(int direction)
        {
            switch (direction)
            {
                case 0:
                    return new int[,]
                    {
                        { 4, 4, 2, 2048 },
                        { 0, 16, 64, 64 },
                        { 0, 8, 32, 0 },
                        { 0, 2, 4, 0 }
                    };
                default:
                    return new int[,]
                    {
                        { 4, 4, 2, 2048 },
                        { 0, 16, 64, 64 },
                        { 0, 8, 32, 0 },
                        { 0, 2, 4, 0 }
                    };
            }
        }
    }
}

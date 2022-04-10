using System;

namespace R2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var R1S1 = Console.ReadLine();
            var r2s1Array = R1S1.Split(' ');
            if (r2s1Array.Length != 2)
            {
                throw new ArgumentException("Invalid input");
            }

            if (int.TryParse(r2s1Array[0],out int R1) && int.TryParse(r2s1Array[1],out int S1))
            {
                if (!IsValidInput(R1) && !IsValidInput(S1))
                {
                    throw new ArgumentException("Input Invalid");
                }

                Console.WriteLine(CalculateR2(R1,S1));
            }
        }

        static bool IsValidInput(int value)
        {
            if (value >= -1_000 && value <= 1_000)
            {
                return true;
            }
            return false;
        }

        public static int CalculateR2(int r1, int s1)
        {
            int N = 2;
            int r2 = (N * s1) - r1;
            return r2;
        }
    }
}

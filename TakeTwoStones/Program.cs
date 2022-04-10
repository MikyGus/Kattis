using System;

namespace TwoStones
{
    internal class Program
    {
        static void Main()
        {
            

            var NumberOfStonesStr = Console.ReadLine();
            if (int.TryParse(NumberOfStonesStr, out int NumberOfStones))
            {
                if (NumberOfStones < 1 && NumberOfStones > 10_000_000)
                {
                    throw new ArgumentException("Invalid amount of stones!");
                }
                bool IsStonesEven = NumberOfStones % 2 == 0;
                
                if (IsStonesEven)
                {
                    Console.WriteLine("Bob");
                }
                else
                {
                    Console.WriteLine("Alice");
                }
            }
        }
    }
}
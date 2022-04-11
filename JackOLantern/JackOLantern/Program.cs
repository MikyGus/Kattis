using System;

namespace JackOLantern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var uniqueDesigns = ConvertToIntArrayFromString(input);
            var uniqueLanterns = PossibleUniqueLanterns(uniqueDesigns);
            Console.WriteLine(uniqueLanterns);
        }

        public static int[] ConvertToIntArrayFromString(string UniqueDesignCount)
        {
            int designCount = 3;
            int[] uniqueDesignsInt = new int[designCount];
            string[] uniqueDesigns = UniqueDesignCount.Split(' ');
            if (uniqueDesigns.Length != designCount)
            {
                throw new ArgumentException("Invalid input");
            }
            for (int i = 0; i < designCount; i++)
            {
                if (!int.TryParse(uniqueDesigns[i], out int uniqueValue))
                {
                    throw new ArgumentException("Invalid input");
                }
                uniqueDesignsInt[i] = uniqueValue;
            }
            return uniqueDesignsInt;

        }

        public static int PossibleUniqueLanterns(int[] uniqueDesigns)
        {
            int uniqueLanterns = 1; //Starts at 1 so that multiplication dont change the end value
            foreach (var item in uniqueDesigns)
            {
                uniqueLanterns *= item;
            }
            return uniqueLanterns;
        }
    }
}

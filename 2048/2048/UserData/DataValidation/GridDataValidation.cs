using System;
using System.Linq;

namespace _2048.UserData.DataValidation
{
    public class GridDataValidation : IDataValidation<int[,]>
    {
        int[] validNumbers = new int[] { 0, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 };
        public bool IsValid(int[,] values)
        {
            foreach (var value in values)
            {
                if (validNumbers.Contains(value) == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

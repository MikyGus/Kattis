using System;

namespace _2048.UserData.InputReader
{
    public class ConsoleInputRead : IInputRead
    {
        public string RetreiveData()
        {
            return Console.ReadLine();
        }
    }
}

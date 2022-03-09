using System;

namespace Task_02_Exeption_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Hello, please enter parameter");
                    string strParam = Console.ReadLine();
                    int numParam = Int32.Parse(strParam);
                    Console.WriteLine($"Your parameter multipleyd by two: {numParam * 2}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter number and try again");
                }
            }
        }
    }
}

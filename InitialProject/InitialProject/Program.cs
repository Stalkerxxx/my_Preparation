using System;

namespace InitialProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            string textFirstNumber = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            string textSecondNumber = Console.ReadLine();

            Console.WriteLine("Select an action  * / - + ");
            string textMathematicalAction = Console.ReadLine();

            MyFunction n = new MyFunction();

            try
            {
                char mathematicalAction = char.Parse(textMathematicalAction);
                double firstNumber = double.Parse(textFirstNumber);
                double secondNumber = double.Parse(textSecondNumber);
                
                switch (mathematicalAction)
                {
                    case '*':
                        Console.WriteLine($"The result of the multiplication of the numbers= {n.Multiplication(firstNumber, secondNumber)}");
                        break;
                    case '/':
                        Console.WriteLine($"The result of the devision of the numbers = {n.Devision(firstNumber, secondNumber)}");
                        break;
                    case '+':
                        Console.WriteLine($"The result of the sum of the numbers = {n.Add(firstNumber, secondNumber)}");
                        break;

                    case '-':
                        Console.WriteLine($"The result of the difference of the numbers = {n.Difference(firstNumber, secondNumber)}");
                        break;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number and try again");
            }            
        }
    }
}

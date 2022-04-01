using System;
using System.Collections.Generic;


namespace Task10_Queue_
{
    /*Написать приложение которое будет запрашивать у пользователя целые
числа для отложенного вычисления (по команде) квадратного корня до тех
пор, пока пользователь не введет одну из двух команд:
● При вводе команды “run” программа должна вывести на экран расчеты
по всем задачам, накопившимся в очереди.
● При вводе команды “exit” программа выводит число оставшихся задач в
очереди на момент выхода и завершается.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Queue<double> queueSqrt = new();
            while (true)
            {
                Console.WriteLine("Please enter number or command:");
                var text = Console.ReadLine();
                var num = 0.0;
                var success = double.TryParse(text, out num);

                if (success == true)
                {
                    queueSqrt.Enqueue(num);
                }
                else if(success == false && text == "run")
                {
                    foreach (var i in queueSqrt)
                    {
                        Console.WriteLine(Math.Sqrt(i));
                    }
                    queueSqrt.Clear();
                }
                else if (success == false && text == "stop")
                {
                    Console.WriteLine(queueSqrt.Count);
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("You enter invalid command!!!");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}

using System;

namespace Task07_Interfaces_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    interface IWalck
    {
        void OutToConsole();
    }
    class Dog : IWalck
    {
        public void OutToConsole() => Console.WriteLine("Dog");
    }

    class Cat : IWalck
    {
        public void OutToConsole() => Console.WriteLine("Cat");
    }
}

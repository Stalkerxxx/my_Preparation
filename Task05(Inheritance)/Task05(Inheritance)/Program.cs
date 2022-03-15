using System;

namespace Task05_Inheritance_
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck truck1 = new(12690, "MAN", 'G', 120, 12, 3500);
            Console.WriteLine("\n First truck: ");
            truck1.OutToTheConsoleTruck();
            Console.WriteLine("\n First truck modified:");
            truck1.NewLoadCapacity(400);
            truck1.NewWheels(4);
            truck1.OutToTheConsoleTruck();
        }
    }
}

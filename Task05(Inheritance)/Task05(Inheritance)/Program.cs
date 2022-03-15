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

            Truck truck2 = new(15000, 'G', 8, 3000);
            Console.WriteLine("\n Second truck: ");
            Console.WriteLine("Enter model second truck:");
            truck2.model = Console.ReadLine();
            Console.WriteLine("Enter maximum speed second truck:");
            truck2.speedMax = int.Parse(Console.ReadLine());
            truck2.OutToTheConsoleTruck();
        }
    }
}

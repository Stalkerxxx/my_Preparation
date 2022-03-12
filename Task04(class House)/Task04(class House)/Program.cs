using System;

namespace Task04_class_House_
{
    class Program
    {
        static void Main(string[] args)
        {
            House residentialBuilding = new (1996, "residential building");
            House houseBusiness = new (2005, "business center", 65);
            residentialBuilding.OutputToTheConsole();
            Console.WriteLine($"Age business center: {House.AgeOfTheHouse(residentialBuilding.year)}");
            houseBusiness.OutputToTheConsole();
            Console.WriteLine($"Age business center: {House.AgeOfTheHouse(houseBusiness.year)}"); 
        }
    }
}

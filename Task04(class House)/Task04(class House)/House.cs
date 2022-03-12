using System;

namespace Task04_class_House_
{
    class House
    {
        public int floors;
        public int year;
        public string name;

        public void OutputToTheConsole()
        {
            Console.WriteLine($"Purpose house: {name}\n" +
                $"Year of construction: {year}\n" +
                $"Number of floors: {floors}");
        }
        public static int AgeOfTheHouse(int ageHouse) 
        {
            DateTime dt = DateTime.Now;
            int yearNow = dt.Year;
            return yearNow - ageHouse;
        }
        public House()
        {
            Console.WriteLine("Empty constructor");
        }
        public House(int year, string name)
        {
            this.year = year;
            this.name = name;
        }
        public House(int year, string name, int floors)
        {
            this.year = year;
            this.name = name;
            this.floors = floors;
        }
    }
}

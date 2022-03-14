using System;

namespace Task05_Inheritance_
{
    class Car
    {
        internal int weight;
        internal string model ;
        internal char color ;
        internal int speedMax;

        public void OutputToTheConsole() 
        {
            Console.WriteLine($"Model car: {model} \n" +
                $"Color car: {color} \n" +
                $"Maximum car speed: {speedMax} \n" +
                $"Weight car: {weight} kg.s");
        }
    }
}

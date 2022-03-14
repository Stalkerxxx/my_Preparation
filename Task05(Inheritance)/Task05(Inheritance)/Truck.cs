using System;

namespace Task05_Inheritance_
{
    class Truck : Car
    {
        private float numberOfWheels;
        private int loadCapacity;

        public float NewWheels(float x)
        {
            return numberOfWheels = x;
        }

        public int NewLoadCapacity(int x)
        {
            return loadCapacity = x;
        }

        public Truck(int weight, string model, char color, int speedMax)
        {
            this.weight = weight;
            this.model = model;
            this.color = color;
            this.speedMax = speedMax;
        }

        public void OutToTheConsoleTruck()
        {
            Console.WriteLine($"Model car: {model} \n" +
                $"Color car: {color} \n" +
                $"Maximum car speed: {speedMax} \n" +
                $"Weight car: {weight} kg.s \n" +
                $"Number of wheels: {numberOfWheels} \n" +
                $"Load capacity: {loadCapacity}");
        }
    }
}

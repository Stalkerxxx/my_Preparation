using System;

namespace Task03_classCar_
{
    class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public int Speed { get; set; }
        public Car(string model, string color, double weight, int speed)
        {
            Model = model;
            Color = color;
            Weight = weight;
            Speed = speed;
        }
        public void PrintToConsole()
        {
            Console.WriteLine($"Model: {Model}, color: {Color}, weight: {Weight}, speed: {Speed}");
        }
    }
}

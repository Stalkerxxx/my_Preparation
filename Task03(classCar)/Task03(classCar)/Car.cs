using System;

namespace Task03_classCar_
{
    class Car
    {
        private string Model { get; set; }
        private string Color { get; set; }
        private double Weight { get; set; }
        private int Speed { get; set; }
       
        public Car(string _model, string _color, 
            double _weight, int _speed)
        {
            Model = _model;
            Color = _color;
            Weight = _weight;
            Speed = _speed;
        }
        public Car(double _weight, int _speed)
        {
            Weight = _weight;
            Speed = _speed;
        }
        
        public void PrintToConsole1()
        {
            Console.WriteLine(
                $"Car 1: \n" + 
                $"Model: {Model} \n" +
                $"Color: {Color} \n" +
                $"Weight: {Weight} \n" +
                $"Speed: {Speed}"
                );
        }
        public void PrintToConsole2()
        {
            Console.WriteLine(
                $"Weight: {Weight} \n" +
                $"Speed: {Speed}"
                );
        }
    }
}

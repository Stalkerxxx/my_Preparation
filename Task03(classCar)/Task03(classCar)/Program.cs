using System;
namespace Task03_classCar_
{
    class Program 
    {
        static void Main(string[] args)
        {
            Car car1 = new ("Lada", "Black", 4.5, 240);
            car1.PrintToConsole1();

            while (true)
            {
                Console.WriteLine("Please enter the model and color of the car:");
                string modelCar2 = Console.ReadLine();
                string colorCar2 = Console.ReadLine();
                try
                {
                    if (String.IsNullOrEmpty(modelCar2) && String.IsNullOrEmpty(colorCar2))
                    {
                        Console.WriteLine("You were writing empty lines");
                        break;
                    }

                    if (modelCar2.Length == 0 && colorCar2.Length == 0)
                    {
                        break;
                    }
                    Car car2 = new(1.2, 220);
                    Console.WriteLine($"Car 2: \n" +
                        $"Model: {modelCar2} \n" +
                        $"Color: {colorCar2}");
                    car2.PrintToConsole2();
                    
                    break;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Please enter the model and color of the car");
                }
            }
        }
    }
}

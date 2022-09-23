using System;

namespace Task021_Exeption_
{
/*Пример работы программы (при корректном вводе):
> Введите тип фигуры (1 круг, 2 равносторонний треугольник, 3 прямоугольник):
> 3 /это ввод пользователя, соответствующий выбору прямоугольника/
> Введите длину прямоугольника:
> 12.1 /ввод пользователем ширины/
> Введите высоту прямоугольника:
> 9.4 /ввод пользователя высоты/
> Площадь поверхности: 113.74
> Длина периметра: 43
Пример работы программы (при неверном вводе):
> Введите тип фигуры (1 круг, 2 равносторонний треугольник, 3 прямоугольник):
> 3 /это ввод пользователя, соответствующий выбору прямоугольника/
> Введите длину прямоугольника:
> Abcd /ввод пользователем нечислового значения/
> Ошибка! Введено нечисловое значение!
  */
    class Program
    {
        static void Main(string[] args)
        {
            byte labelShape = default;
            Console.WriteLine("Enter number geometric shape\n" +
                        "Rectangle - 1, Equilateral triangle - 2, Cyrcle - 3 ");
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    labelShape = Convert.ToByte(Console.ReadLine());
                    if (labelShape > 3 || labelShape <= 0)
                    {
                        Console.WriteLine("Enter number geometric shape\n" +
                        "Rectangle - 1, Equilateral triangle - 2, Cyrcle - 3 ");
                        continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter number geometric shape\n" +
                        "Rectangle - 1, Equilateral triangle - 2, Cyrcle - 3 ");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter number geometric shape\n" +
                        "Rectangle - 1, Equilateral triangle - 2, Cyrcle - 3 ");
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (labelShape == 1)
                {
                    Console.WriteLine($"You choose rectangle \n" +
                        $"Enter its length and width:");
                    try
                    {
                        double x = Convert.ToDouble(Console.ReadLine());
                        double y = Convert.ToDouble(Console.ReadLine());
                        Rectangle(x, y);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You entered an incorrect value\n" +
                            "The sides of the rectangle must be a numeric value");
                    }
                }
                else if (labelShape == 2)
                {
                    Console.WriteLine($"You choose equilateral triangle\n" +
                        $"Enter its length sides");
                    try
                    {
                        double x = Convert.ToDouble(Console.ReadLine());
                        EquilateralTriangle(x);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You entered an incorrect value\n" +
                            "The sides of the equilateral triangle must be " +
                            "a numeric value");
                    }
                }
                else if (labelShape == 3)
                {
                    try
                    {
                        Console.WriteLine($"You choose circle\n" +
                        $"Enter its radius");
                        double x = Convert.ToDouble(Console.ReadLine());
                        Circle(x);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You entered an incorrect value\n" +
                            "The sides of the circle must be a numeric value");
                    }
                }
            }
            
            Console.ReadKey();
        }
        public static void Rectangle(double x, double y)
        {
            Console.WriteLine("Square: " + x * y); ;
            Console.WriteLine("Perimeter: " + 2 * (x + y));
        }
        public static void EquilateralTriangle(double x)
        {
            Console.WriteLine("Square: " + x * x * Math.Sqrt(3) / 4);
            Console.WriteLine("Perimeter: " + x * 3);
        }
        public static void Circle(double x)
        {
            Console.WriteLine("Square: " + Math.Pow(x, 2.0) * Math.PI);
            Console.WriteLine("Perimeter: " + 2 * x * Math.PI);
        }
    }
}

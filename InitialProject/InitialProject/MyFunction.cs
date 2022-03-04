using System;

namespace InitialProject
{
    class MyFunction
    {
        public double Add(double x, double y) 
        {
            return (x + y);
        }
        public double Multiplication(double x, double y)
        {
            return (x * y);
        }
        public double Devision(double x, double y)
        {
            return (x / y);
        }
        public double Difference(double x, double y)
        {
            return (x - y);
        }

        public static implicit operator MyFunction(double v)
        {
            throw new NotImplementedException();
        }
    }
}

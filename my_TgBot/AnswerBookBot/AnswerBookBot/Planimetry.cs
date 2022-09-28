namespace AnswerBookBot
{
    using System;
    public class Planimetry
    {
        public static double RectangleSquare(double x, double y) => x * y;
        public static double RectanglePerimeter(double x, double y) => 2 * (x + y);
        public static double TriangleSquare(double x, double y) => x * y;
        public static double TrianglePerimeter(double x, double y, double z) => x + y + z;
        public static double CircleSquare(double x) => Math.Pow(x, 2.0) * Math.PI;
        public static double CirclePerimeter(double x) => Math.Pow(x, 2.0) * Math.PI;
    }
}
  
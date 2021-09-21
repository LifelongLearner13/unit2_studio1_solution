using System;
namespace studio1_solution
{
    public static class Circle
    {
        public static double Diameter(double radius)
        {
            return 2 * radius;
        }

        public static double Circumference(double radius) => Math.PI * 2 * radius;

        public static double Area(double radius) => Math.PI * radius * radius;
    }

    /* ----- CLASS Version ----- */
    //public class Circle
    //{
    //    private double _radius;
    //    public Circle(double radius)
    //    {
    //        _radius = radius;
    //    }

    //    public double Diameter => 2 * _radius;

    //    public double Circumference => Math.PI * 2 * _radius;

    //    public double Area => Math.PI * _radius * _radius;
    //}
}

using System;

namespace Point_2D_3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Point 2D");
            Point2D point2D = new Point2D(5.6f, 12.11f);
            Console.WriteLine(point2D.ToString());
            Console.WriteLine();
            Console.WriteLine("Point 3D");
            Point3D point3D = new Point3D(6.6f, 1.2f, 1.1f);
            Console.WriteLine(point3D.ToString());
        }
    }
}
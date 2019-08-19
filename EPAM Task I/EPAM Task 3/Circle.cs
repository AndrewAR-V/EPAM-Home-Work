using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_3
{
    class Circle
    {       
        public Circle (string s)
        {
            const double p = 3.14;
            int radius = 0;
            radius = Int32.Parse(s);
            Perimeter(radius, p);
            Area(radius, p);
        }
        public static void Perimeter(int r, double p)
        {
            double perimeter = 2 * p * r;
            Console.WriteLine("Circle length = " + perimeter);
        }

        public static void Area(int r, double p)
        {
            double area = p * (r * r);
            Console.WriteLine("Circle area = " + area);
        }
    }
}

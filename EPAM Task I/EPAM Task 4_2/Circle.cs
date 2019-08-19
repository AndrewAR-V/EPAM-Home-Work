using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_4_2
{
    public static class Circle
    {
        const double p = 3.14;

        public static void Perimeter(int r)
        {
            double perimeter = 2 * p * r;
            Console.WriteLine("Circle length = " + perimeter);
        }

        public static void Area(int r)
        {
            double area = p * (r * r);
            Console.WriteLine("Circle area = " + area);
        }
    }
}

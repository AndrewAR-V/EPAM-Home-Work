using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of circle");
            string s = Console.ReadLine();
            int radius = Int32.Parse(s);

            Circle.Perimeter(radius);
            Circle.Area(radius);

            Console.WriteLine("Press any key to ESC");
            Console.ReadKey();
        }
    }
}

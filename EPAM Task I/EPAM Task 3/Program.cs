using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of circle");
            string s = Console.ReadLine();

            Circle parameters;
            parameters = new Circle(s);

            Console.WriteLine("Press any key to ESC");
            Console.ReadKey();
        }
    }
}

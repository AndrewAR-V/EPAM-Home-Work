using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square squere = new Square();
            Rectangle rect = new Rectangle();
            squere.Draw();
            rect.Draw();
            Console.WriteLine("Press any key to ESC");
            Console.ReadKey();
        }
    }
}

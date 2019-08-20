using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Square squere = new Square();
            Rectangle rect = new Rectangle();
            Figure figure = new Figure(7, 12);
            squere.Draw();
            rect.Draw();
            figure.Draw();
            Console.WriteLine("Press any key to ESC");
            Console.ReadKey();
        }
    }
}

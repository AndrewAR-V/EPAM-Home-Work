using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coordinates of the top left and bottom right corner");
            string[] s = Console.ReadLine().Split(' ');
            int TLX = int.Parse(s[0]);
            int TLY = int.Parse(s[1]);
            int BRX = int.Parse(s[2]);
            int BRY = int.Parse(s[3]);

            Rectangle.Perimeter(TLX, TLY, BRX, BRY);
            Rectangle.Area(TLX, TLY, BRX, BRY);

            Console.WriteLine("Press any key to ESC");
            Console.ReadKey();
        }
    }
}

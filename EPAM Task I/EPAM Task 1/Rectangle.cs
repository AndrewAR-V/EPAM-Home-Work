using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_1
{
    class Rectangle
    {
        public Rectangle (int tlx, int tly, int brx, int bry)
        {
            int width = brx - tlx;
            int height = tly - bry;
            Perimeter(width, height);
            Area(width, height);
        }
        public static void Perimeter(int w, int h)
        {
            int perimeter = w * 2 + h * 2;
            Console.WriteLine("Rectangle perimeter = " + perimeter);
        }

        public static void Area(int w, int h)
        {
            int area = w * h;
            Console.WriteLine("Rectangle area = " + area);

            Console.WriteLine("Press any key to ESC");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_4_1
{
    public static class Rectangle
    {
        public static void Perimeter(int tlx, int tly, int brx, int bry)
        {
            int perimeter = (brx - tlx) * 2 + (tly - bry) * 2;
            Console.WriteLine("Rectangle perimeter = " + perimeter);
        }

        public static void Area(int tlx, int tly, int brx, int bry)
        {
            int area = (brx - tlx) * (tly - bry);
            Console.WriteLine("Rectangle area = " + area);
        }
    }
}

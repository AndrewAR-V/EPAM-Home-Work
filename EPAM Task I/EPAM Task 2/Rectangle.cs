using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_2
{
    class Rectangle
    {
        int width;
        int height;

        public Rectangle (int tlx, int tly, int brx, int bry)
        {
            width = brx - tlx;
            height = tly - bry;
        }

        public int Perimeter
        {
            get { return width * 2 + height * 2; }
            set { }
        }

        public int Area 
        {
            get { return width * height; }
            set { }
        }
    }
}

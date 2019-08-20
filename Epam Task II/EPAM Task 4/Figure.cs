using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_4
{
    public class Figure:IDrawable
    {
        private readonly int X,Y;

        public Figure (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Figure " + X + " " + Y);
        }
    }
}

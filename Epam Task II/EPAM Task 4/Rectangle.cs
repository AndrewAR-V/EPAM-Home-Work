using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_4
{
    class Rectangle : Figure
    {
        public Rectangle() : base(0, 0) 
        { 
        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}

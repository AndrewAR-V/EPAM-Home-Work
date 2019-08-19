using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_2
{
    class Square : Figure
    {
        public Square() : base(0, 0) 
        { 
        }

        public override void Draw()
        {
            Console.WriteLine("Square");
        }
    }
}

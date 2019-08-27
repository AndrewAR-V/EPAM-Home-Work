using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_1
{
    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public IEnumerable<string> PhoneNumber { get; set; }
    }
}

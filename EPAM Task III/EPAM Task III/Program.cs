using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_1
{
    class Program
    {
        static void Main()
        {
            List<Person> person;
            person = new List<Person>();

            person.Add(new Person { Name = "Andrew", Age = 22, PhoneNumber = new string[] { "0630000001", " ", "0680000002", " ", "0930000003", " " } } );
            person.Add(new Person { Name = "Uliana", Age = 24, PhoneNumber = new string[] { "0630000004", " ", "0680000005", " ", "0930000006", " " } } );
            person.Add(new Person { Name = "Sergio", Age = 23, PhoneNumber = new string[] { "0630000007", " ", "0680000008", " ", "0930000009", " " } } );
            person.Add(new Person { Name = "Michael", Age = 21, PhoneNumber = new string[] { "0630000010", " ", "0680000011", " ", "0930000012", " " } });
            person.Add(new Person { Name = "Antony", Age = 35, PhoneNumber = new string[] { "0630000013", " ", "0680000014", " ", " " } } );
            person.Add(new Person { Name = "Ania", Age = 34, PhoneNumber = new string[] { "0630000015", " ", "0680000016", " ", " " } });
            person.Add(new Person { Name = "Alex", Age = 21, PhoneNumber = new string[] { "0630000017", " ", "0680000018", " ", "0930000019", " " } });

            foreach (var record in person)
            {
                Console.Write(record.Name + " " + record.Age + " ");

                foreach (var phone in record.PhoneNumber)
                {
                    Console.Write(phone);
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine( "Press any key to ESC");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_3
{
    class Program
    {
        static void Main()
        {
            var items = new List<string>();
            Pages page = new Pages { N = 200, WordLenght = 4 };

            items = page.CreateList(items);
            Console.WriteLine("Number of items before changes : " + items.Count);

            items = page.TransformerList(items);
            Console.WriteLine("Number of items after changes : " + items.Count);

            items.Sort();
            items.Reverse();

            try
            {
                Console.Write("Enter the number of page (1 - " + items.Count / 5 + " )");
                page.DisplayPage(Int32.Parse(Console.ReadLine()), items);
            }

            catch (FormatException)
            {
                Environment.Exit(0);
            }

            Console.ReadKey();
        }
    }
}

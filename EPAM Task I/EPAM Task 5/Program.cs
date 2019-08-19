using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first complex number (a b)");
            string[] s = Console.ReadLine().Split(' ');
            var number1 = new ComplexNumber { A = int.Parse(s[0]), B = int.Parse(s[1]) };

            Console.WriteLine("Enter second complex number (a b)");
            s = Console.ReadLine().Split(' ');
            var number2 = new ComplexNumber { A = int.Parse(s[0]), B = int.Parse(s[1]) };

            ComplexNumber multNumber = number1 * number2;
            ComplexNumber divNumber = number1 / number2;

            Console.WriteLine("Multiplication of complex number is : " + multNumber.A + " + " + multNumber.B + "i");
            Console.WriteLine("Division of complex number is : " + divNumber.A + " + " + divNumber.B + "i");
            Console.ReadKey();
        }
    }
}

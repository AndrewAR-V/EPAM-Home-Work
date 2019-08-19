using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_5
{
    class ComplexNumber
    {
        #region змінні і конструктор класу
        public int A { get; set; }
        public int B { get; set; }

        public ComplexNumber() { }

        #endregion

        #region перевизначення операцій
        public static ComplexNumber operator *(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber
            {
                A = number1.A * number2.A - (number1.B * number2.B),
                B = number1.A * number2.B + number1.B * number2.A
            };
        }

        public static ComplexNumber operator /(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber
            {
                A = (number1.A * number2.A + number1.B * number2.B) / ((number2.A * number2.A) + (number2.B * number2.B)),
                B = -(number1.A * number2.B - (number1.B * number2.A)) / ((number2.A * number2.A) + (number2.B * number2.B))
            };
        }
        #endregion

    }
}

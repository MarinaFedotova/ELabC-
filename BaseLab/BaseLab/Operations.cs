using System;
using System.Collections.Generic;
using System.Text;

namespace BaseLab
{
    class Operations
    {
        static public double Calc(double op1, string sign, double op2)
        {
            switch (sign)
            {
                case "+":
                    return op1 + op2;
                case "-":
                    return op1 - op2;
                case "/":
                    return op1 / op2;
                case "*":
                    return op1 * op2;
                default:
                    Console.WriteLine("Операция выбрана неверно или не существует!");
                    return 0;
            }
        }
    }
}

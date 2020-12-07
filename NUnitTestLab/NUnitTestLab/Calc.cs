using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestLab
{
    static class Calc
    {
        static public double Plus(double operand1, double operand2)
        {
            return operand1 + operand2;
        }
        
        static public double Minus(double operand1, double operand2) 
        {
            return operand1 - operand2;
        }
        
        static public double Division(double operand1, double operand2)
        {
            if (operand2 == 0)
                return 0;
            return operand1 / operand2;
        }
        
        static public double Multiplication(double operand1, double operand2)
        {
            return operand1 * operand2;
        }
    }
}

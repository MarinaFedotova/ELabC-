using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestLab
{
    class TestValue
    {
        static object[] DivisionCases =
        {
            new object[] { 10, 0, 0 },
            new object[] { 10, -2, -5 },
            new object[] { 10, 0.2, 50 },
            new object[] { 10, 4, 2.5 }
        };
        
        static object[] MultiplicationCases =
        {
            new object[] { 0, 0, 0 },
            new object[] { -1, -1, 1 },
            new object[] { 10, 0, 0 },
            new object[] { 10, 0.2, 2 }
        };
        static object[] OtherCases =
        {
            new object[] { 0, 0, 0 },
            new object[] { 10, 0, 10 },
        };
    }
}

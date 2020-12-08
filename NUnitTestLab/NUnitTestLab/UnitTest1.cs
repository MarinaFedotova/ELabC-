using NUnit.Framework;

namespace NUnitTestLab
{
    public class Tests
    {        
        [TestCaseSource(typeof(TestValue), "DivisionCases")]
        public void TestDivide(double x, double y, double z)
        {
            double result = Calc.Division(x, y);
            Assert.AreEqual(z, result);
        }
       
        [TestCaseSource(typeof(TestValue), "MultiplicationCases")]
        public void TestMultiplication(double x, double y, double z)
        {
            double result = Calc.Multiplication(x, y);
            Assert.AreEqual(z, result);
        }

        [TestCaseSource(typeof(TestValue), "OtherCases")]
        [TestCase(-1, -1, -2)]
        public void TestPlus(double x, double y, double z)
        {
            double result = Calc.Plus(x, y);
            Assert.AreEqual(z, result);
        }

        [TestCaseSource(typeof(TestValue), "OtherCases")]
        [TestCase(0, -10, 10)]
        public void TestMinus(double x, double y, double z)
        {
            double result = Calc.Minus(x, y);
            Assert.AreEqual(z, result);
        }
    }
}
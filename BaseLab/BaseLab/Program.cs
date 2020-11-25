using System;

namespace BaseLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------------------
            //Массив 
            //----------------------------------------------------------------------
            Console.Write("Введите количество элементов в массиве: ");
            int sizeArray = int.Parse(Console.ReadLine());
            int[] array = new int[sizeArray];

            Random rnd = new Random();
            for (int index = 0; index < sizeArray; index++)
            {
                array[index] = rnd.Next(-100, 100);
            }

            Console.WriteLine("Исходный массив:");
            Array.WriteArray(array);
            Console.WriteLine("Отсортированный массив по возрастанию:");
            Array.WriteArray(Array.ShekerSort(array));

            //----------------------------------------------------------------------
            //Калькулятор 
            //----------------------------------------------------------------------
            Console.Write("\nВведите операнд а = ");
            double operand1 = double.Parse(Console.ReadLine());
            Console.Write("Введите знак операции: ");
            string sign = Console.ReadLine();
            Console.Write("Введите операнд b = ");
            double operand2 = double.Parse(Console.ReadLine());
            double result = Operations.Calc(operand1, sign, operand2);
            Console.Write("{0} {1} {2} = {3}", operand1, sign, operand2, result);
        }
    }
}

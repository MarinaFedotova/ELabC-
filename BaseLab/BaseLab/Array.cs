using System;
using System.Collections.Generic;
using System.Text;

namespace BaseLab
{
    class Array
    {
        static public void WriteArray(int[] array)
        {
            foreach (int el in array)
            {
                Console.Write("{0}\t", el);
            }
            Console.WriteLine();
        }

        static public void Swap(ref int el1, ref int el2)
        {
            int temp = el2;
            el2 = el1;
            el1 = temp;
        }

        static public int[] ShekerSort(int[] array)
        {
            bool flag = true; //Массив отсортирован  
            int right = array.Length;
            int left = 0;
            while (flag && left < right)
            {
                for (int index = left; index < right - 1; index++)
                {
                    if (array[index] > array[index + 1])
                    {
                        Swap(ref array[index], ref array[index + 1]);
                        flag = false;
                    }
                }
                right--;
                for (int index = right; index > left; index--)
                {
                    if (array[index] < array[index - 1])
                    {
                        Swap(ref array[index], ref array[index - 1]);
                        flag = false;
                    }
                }
                left++;
                flag = true;
            }
            return array;
        }
    }
}

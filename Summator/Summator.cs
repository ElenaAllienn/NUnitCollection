using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        public static long Sum(int[] arr)
        {
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static double Avarage(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum /arr.Length;
        }


        //public static void Test_SumTwoNumbers()
        //{
        //    if (Sum(new int[] { 1, 2 }) != 3)
        //    {
        //        throw new Exception("1+2 != 3");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Test_SumTwoNumbers Pass!");
        //    }

        //}

        //public static void Test_SumEmptyArray()
        //{
        //    if (Sum(new int[] { }) != 0)
        //    {
        //        throw new Exception("sum [] != 0");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Test_SumEmptyArr Pass!");
        //    }
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class EvenOdd
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter Number to find Even or Odd ");
            int num = Convert.ToInt32(Console.ReadLine());
            FindEvenOdd(num);
        }
        private static void FindEvenOdd(int num)
        {
            if (num % 2 == 0)//if number divide by 2 it is even else odd
            {
                Console.WriteLine($"The Number {num} is EVEN");
            }
            else
            {
                Console.WriteLine($"The Number {num} is ODD");
            }
        }
    }
}

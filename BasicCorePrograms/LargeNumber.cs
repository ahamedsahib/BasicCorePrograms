using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class LargeNumber
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            FindLargeNumber(num1, num2, num3);
        }
        private static void FindLargeNumber(int a,int b,int c)
        {
            if(a>b && a > c)
            {
                Console.WriteLine($"{a} is greater");
            }
            else if (b > c)
            {
                Console.WriteLine($"{b} is greater");
            }
            else
            {
                Console.WriteLine($"{c} is greater");
            }
        }
    }
}

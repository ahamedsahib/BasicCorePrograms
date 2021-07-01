using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PowerOf2
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter The Nth Power of 2 ");
            int num = Convert.ToInt32(Console.ReadLine());
            FindPowerOf2(num);
        }
        private static void FindPowerOf2(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"2 ^ {i} = {Math.Pow(2, i)}");

            }

        }
    }
}

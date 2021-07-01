using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class HarmonicNumber
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter The Nth term ");
            int num = Convert.ToInt32(Console.ReadLine());
            FindHarmonicNumber(num);
        }
        private static void FindHarmonicNumber(int number)
        {
            double result=0;
            for (double i = 1; i <= number ; i++)
            {
                result += 1 / i;
            }
            Console.WriteLine("The Nth Harmonic Value is = " + result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class QuotientRemainder
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter Dividend value:");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor value:");
            int divisor = Convert.ToInt32(Console.ReadLine());
            FindQuotientRemainder(dividend,divisor);
        }
        private static void FindQuotientRemainder(int dividend,int divisor)
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine($"Quotient for {dividend}/{divisor} is {quotient} and Remainder is {remainder}");
        }
    }
}

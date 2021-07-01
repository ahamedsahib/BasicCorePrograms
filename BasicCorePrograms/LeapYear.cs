using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class LeapYear
    {
        public static void ReadInput()
        {
            Console.Write("Input an year : ");
            int year = Convert.ToInt32(Console.ReadLine());//read Year from User
            FindLeapYear(year);
        }

        private static void FindLeapYear(int year)
        {
            if ((year % 400) == 0)
            {
                Console.WriteLine("{0} is a leap year.\n", year);
            }
            else if ((year % 100) == 0)
            {
                Console.WriteLine("{0} is not a leap year.\n", year);
            }
            else if ((year % 4) == 0)
            {
                Console.WriteLine("{0} is a leap year.\n", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.\n", year);
            }
        }
    }
}


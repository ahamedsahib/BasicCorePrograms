using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PrimeFactors
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter The Number to Find Prime factors ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Prime Factors of {num}");
            FindPrimeFactors(num);
        }
        private static void FindPrimeFactors(int num)
        {
            int isPrime = 1;//to check whether the number is prime or not 
            for (int i = 2; i<= num; i++)
            {
                
                if (num % i == 0)
                {
                    isPrime = 1;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = 0;
                            break;
                        }
                    }
   
                    if (isPrime == 1)
                    {
                        Console.WriteLine(i); 
                    }
                }
            }
        }
    }
}

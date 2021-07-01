using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Core Programs");
            Console.WriteLine("Choose The Program You Want Run");
            Console.WriteLine("1)Flip Coin \n2)Leap Yaar \n3)PowerOf2 \n4)Exit");
            Console.WriteLine("Choose one");
            int option = Convert.ToInt32( Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin.ReadInput();
                    break;
                case 2:
                    LeapYear.ReadInput();
                    break;
                case 3:
                    PowerOf2.ReadInput();
                    break;
                default:
                    Console.WriteLine("Choose Correct Option");
                    break;
            }
            

        }
    }
}

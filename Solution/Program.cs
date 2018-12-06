using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            //Print 1 to 100. If /3 print Fizz, If /5 print Buzz, else print number

            for (int i = 1; i < 101; i++)
            {

                if (IsNumberDivisibleBy(i, 3) || IsNumberDivisibleBy(i, 5)) {

                    if (IsNumberDivisibleBy(i, 3))
                        Console.Write("Fizz");
                  
                    if (IsNumberDivisibleBy(i, 5))
                        Console.Write("Buzz");

                    Console.Write("\r\n");
                    continue;
                }

                //Only reaches here if not divisible by 3 or 5
                Console.Write(i.ToString() + "\r\n");

            }

            Console.WriteLine("\r\nThis program has ended. Press a key to close.");
            Console.ReadKey();

        }

        static bool IsNumberDivisibleBy(int input, int divisor)
        {

            //Purpose: Checks to see is a number is divisible by a N

            if (input % divisor == 0)
                return true;
           
            return false;

        }

    }
}

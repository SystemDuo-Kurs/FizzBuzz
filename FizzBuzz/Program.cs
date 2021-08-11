using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = 1;
            while (broj <= 100)
            {
                Console.Write(broj);
                if (broj % 3 == 0)
                {
                    Console.Write(" Fizz");
                }

                if (broj % 5 == 0)
                {
                    Console.Write(" Buzz");
                }

                Console.WriteLine();
                broj++;
            }
        }
    }
}

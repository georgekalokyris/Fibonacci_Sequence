using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           FibFor();

        }

        private static void FibFor()
        {
            Console.WriteLine("Please provide the length of the Fibonacci sequence");
            int nums = int.Parse(Console.ReadLine());
            int total = 0; //used in the calculation of the total number
            List<int> fibs = new List<int> { 0, 1 };
            for (int i = 0; i < nums; i++)
            {
                if (i == 0 || i == 1)
                {
                    total = 0;
                }
                else
                {
                    fibs.Add(fibs[i - 1] + fibs[i - 2]);
                    total = total + 1 + fibs[i];
                }
                Console.WriteLine(fibs[i]);

            }

            Console.WriteLine($"Total sum of the Fibonacci numbers is {total}");

            Console.ReadKey();
        }
    }
}

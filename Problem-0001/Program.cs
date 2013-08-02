using System;
using System.Linq;

namespace Problem_0001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] multiplesOf = { 3, 5 };
            int max = 0;
            int sum = 0;

            string input = "-";

            while (!int.TryParse(input, out max))
            {
                Console.Write("Please, enter the max number to find multiples: ");
                input = Console.ReadLine();
            }           

            for (int current = 0; current < max; current ++)
                if (multiplesOf.Any(x => current % x == 0))
                    sum += current;
            
            Console.WriteLine("Sum is {0}.", sum);
            Console.ReadLine();
        }
    }
}
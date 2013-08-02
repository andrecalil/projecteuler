using System;

namespace Problem_0002
{
    class Program
    {
        static void Main(string[] args)
        {
            int last = 1;
            int current = 2;
            int next = 0;
            int max = 4000000;
            //int max = 10;
            int sum = 2;

            while (true)
            {
                next = last + current;

                if (next >= max)
                    break;
                
                if (next % 2 == 0)
                    sum += next;

                last = current;
                current = next;
            }

            Console.WriteLine("Sum is {0}", sum);
            Console.ReadLine();
        }
    }
}
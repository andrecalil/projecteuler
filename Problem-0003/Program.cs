using System;

namespace Problem_0003
{
    class Program
    {
        static void Main(string[] args)
        {
            //This answer is according to the solution provided by the website
            //My first approach was more like... brute force

            long target = 600851475143;
            
            int lastFactor = 1;

            if (target % 2 == 0)
            {
                lastFactor = 2;

                while (target % 2 == 0)
                    target = target / 2;
            }

            int currentFactor = 3;
            double maxFactor = Math.Sqrt(target);

            while (target > 1 && currentFactor <= maxFactor)
            {
                if (target % currentFactor == 0)
                {
                    lastFactor = currentFactor;

                    while (target % currentFactor == 0)
                        target = target / currentFactor;

                    maxFactor = Math.Sqrt(target);
                }
                
                currentFactor += 2;
            }

            Console.WriteLine("Biggest factor is {0}", (target != 1? target : lastFactor));
            Console.ReadLine();
        }
    }
}
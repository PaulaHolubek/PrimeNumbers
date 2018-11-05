using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 2; counter < 100; counter++)
            {
                int primes = 0;
                for (int y = 1; y < counter; y++)
                {
                    if (counter % y == 0)
                        primes++;

                    if (primes == 2) break;
                }
                if (primes != 2)
                    Console.WriteLine(counter);

                primes = 0;
            }
            Console.ReadKey();
        }
    }
}

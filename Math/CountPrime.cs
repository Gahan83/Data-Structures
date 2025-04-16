using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class CountPrime
    {
        public int CountPrimes(int n)
        {
            if (n <= 2)
                return 0;

            // Step 1: Create a boolean array "isPrime[0..n-1]" and initialize all entries as true.
            bool[] isPrime = new bool[n];
            for (int i = 2; i < n; i++)
            {
                isPrime[i] = true;
            }

            // Step 2: Sieve of Eratosthenes
            for (int i = 2; i * i < n; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j < n; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            // Step 3: Count primes
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (isPrime[i])
                    count++;
            }

            return count;
        }
    }
}

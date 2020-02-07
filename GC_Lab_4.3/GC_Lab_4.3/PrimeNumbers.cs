using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_4._3
{
    public class PrimeNumbers
    {
        private List<int> knownPrimes;

        public PrimeNumbers()
        {
            knownPrimes = new List<int>();
            for (int i = 2; i < 10; i++)
            {
                if (IsNumberPrime(i))
                {
                    knownPrimes.Add(i);
                }
            }
        }


        public int GetNPrime(int num)
        {
            int index = num - 1;
            while (knownPrimes.Count <= index)
            {
                int lastIndesOflastKnowPrimes = knownPrimes.Count - 1;
                int lastKnownPrime = knownPrimes[lastIndesOflastKnowPrimes];
                int nextPrime = CalcNextPrime(lastKnownPrime);
                knownPrimes.Add(nextPrime);
            }
            int prime = knownPrimes[index];

            return prime;
        }

        private int CalcNextPrime(int num)
        {
            int currentNumber = num + 1;
            while (!IsNumberPrime(currentNumber))
            {
                currentNumber++;
            }

            return currentNumber;
        }

        public bool IsNumberPrime(int num)
        {
            // all calculations are done with positive numbers
            num = Math.Abs(num);

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

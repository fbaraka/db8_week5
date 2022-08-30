using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public class PrimeNumberGenerator
    {

        public static int GetPrime(int userNumber)
        {
            // to find primes, they can only be divided by themselves and nothing else
            // modulus will return with 0
            // if modulus returns with a remainder, not prime
            int primeCount = 0;
            int primeValue = 0;
     
                for (int i = 1; i <= 100000; i++)
                {
                    bool isPrime = CheckIfPrime(i);
                    if (isPrime)
                    {
                        primeCount++;

                    }
                    primeValue = i;

                    if (primeCount == userNumber)
                    {
                        break;
                    }
                }
            

            return primeValue;
        } 

        public static bool CheckIfPrime(int userNumber)
        {
            {
                int modCount = 0;
                for (int i = 1; i <= userNumber; i++)
                {
                    if (userNumber % i == 0)
                    {
                        modCount++;
                    }
                }
                if (modCount == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }

    }
}

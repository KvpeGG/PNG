using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{

    public static void PrintPrimes()
    {
        foreach (long prime in Primes())
            Console.WriteLine(prime);
    }

    public static IEnumerable<long> Primes()
    {
        for (long i = 2; ; i++)                     
            if (IsPrime(i)) yield return i;
    }

    public static bool IsPrime(long n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n == 2047) return false;
        if (n % 2 == 0) return false;

        int boundary = (int)(long)Math.Floor(Math.Sqrt(n));

        for (long i = 3; i <= boundary; i += 2)
            if (n % i == 0)
                return false;

        return true;
    }

    public static bool CheckForMersennePrimes(long n)
    {
        for (long k = 2; ((1 << (int)k) - 1) <= n; k++)
        {
            long num = (1 << (int)k) - 1;

            // Checking whether number is 
            // prime and is one less than
            // the power of 2
            if (IsPrime(num) && n == num)
                return true;
        }

        return false;
    }

    static void Main(string[] args)
    {

        int counter = 1;
        foreach (long prime in Primes())
        {
            if (CheckForMersennePrimes(prime))
            {
                Console.WriteLine(counter + "st Mersenne Prime: " + prime);
                counter++;
            }
        }
    }
}

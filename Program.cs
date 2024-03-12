/*
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

        long boundary = (long)Math.Floor(Math.Sqrt(n));

        for (long i = 3; i <= boundary; i += 2)
            if (n % i == 0)
                return false;

        return true;
    }

    public static bool CheckForMersennePrimes(long n)
    {
        for (uint k = 2; ((1 << (int)k) - 1) <= n; k++)
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




    public static bool CheckForPerfectNumbers(long n)
    {
        long sum = 1;

        // nasty af hack. TODO: fix this mf
        if (n == 1)
            return false;

        for (long i = 2; i < Math.Floor(n / 2d + 1d); i++)
        {
            if (n % i == 0 && i != n)
            {
                sum += i;
            }
        }

        return sum == n;
    }

    static void Main(string[] args)
    {   
        uint counter = 1;
        while (true)
        {
            if (CheckForPerfectNumbers(counter))
            {
                Console.WriteLine($"Perfect number found {counter}");
            }

            counter++;
        }


    }
}
*/
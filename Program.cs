using System;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{

    public static void PrintPrimes()
    {
        foreach (int prime in Primes())
            Console.WriteLine(prime);
    }

    public static IEnumerable<int> Primes()
    {
        for (int i = 2; ; i++)                     
            if (IsPrime(i)) yield return i;
    }

    public static bool IsPrime(long n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n == 2047) return false;
        if (n % 2 == 0) return false;

        int boundary = (int)Math.Floor(Math.Sqrt(n));

        for (int i = 3; i <= boundary; i += 2)
            if (n % i == 0)
                return false;

        return true;
    }

    public static void CheckForMessenePrimes(int n)
    {
        for (int k = 2; ((1 << k) - 1) <= n; k++)
        {
            long num = (1 << k) - 1;

            // Checking whether number is 
            // prime and is one less than
            // the power of 2
            if (IsPrime(num))
                Console.Write(num + " ");
        }
    }

    static void Main(string[] args)
    {
        for (int i = 0; ; i++)
        {
            
        }
        //PrintPrimes();
    }
}
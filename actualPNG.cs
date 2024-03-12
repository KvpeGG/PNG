using System;
using System.Numerics;


class Program
{

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
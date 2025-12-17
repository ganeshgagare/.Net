using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimeNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPrime(number))
                Console.WriteLine($"{number} is a Prime Number.");
            else
                Console.WriteLine($"{number} is NOT a Prime Number.");
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false; // 0, 1, and negatives are not prime
            if (num == 2) return true; // 2 is prime
            if (num % 2 == 0) return false; // Even numbers > 2 are not prime

            int boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}

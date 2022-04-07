using System;

namespace numberPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Escribe un numero");
            number = int.Parse(Console.ReadLine());
            if (IsPrime(number) == true)
                Console.WriteLine($"El {number} es un numero Primo");
            else
                Console.WriteLine($"El {number} no es un numero Primo");

            //Console.WriteLine(IsPrime(number));
        }

        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}

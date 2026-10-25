using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введіть висоту трикутника: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
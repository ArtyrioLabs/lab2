using System;
using System.Data;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть вираз:");
            string input = Console.ReadLine();

            DataTable dt = new DataTable();
            var result = dt.Compute(input, "");

            Console.WriteLine("Вiдповiдь програми: " + result);
            Console.ReadLine();
        }
    }
}
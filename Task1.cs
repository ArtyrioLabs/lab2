using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть рік: ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("Рiк є високосним");
            }
            else
            {
                Console.WriteLine("Рiк не високосний");
            }

            Console.ReadLine();
        }
    }
}
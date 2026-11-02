using System;
using System.Text;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            #region ЗАВДАННЯ 1: Розворот числа зі збереженням знака

            Console.WriteLine("=== ЗАВДАННЯ 1 ===");
            int number = 0;

            while (true)
            {
                Console.Write("Введіть ціле число: ");
                string inputNumberText = Console.ReadLine() ?? "";

                if (int.TryParse(inputNumberText, out number))
                {
                    if (number >= 10000 || number <= -10000)
                    {
                        break;
                    }
                    Console.WriteLine("Помилка: число має містити не менше 5 цифр! Спробуйте ще раз.");
                }
                else
                {
                    Console.WriteLine("Помилка: введіть коректне ціле число!");
                }
            }

            int reversedNumber = 0;

            while (number != 0)
            {
                int lastDigit = number % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                number = number / 10;
            }

            Console.WriteLine($"Результат: {reversedNumber}");
            Console.WriteLine("-------------------");

            #endregion


            #region ЗАВДАННЯ 2: Видалення перших Х слів із тексту

            Console.WriteLine("=== ЗАВДАННЯ 2 ===");
            Console.Write("Введіть речення: ");
            string userText = Console.ReadLine() ?? "";

            Console.Write("Введіть число X: ");
            string xInput = Console.ReadLine() ?? "0";
            int x = int.Parse(xInput);

            string[] words = userText.Split(' ');
            string resultText = "";

            for (int i = x; i < words.Length; i++)
            {
                resultText += words[i];
                if (i < words.Length - 1)
                {
                    resultText += " ";
                }
            }

            Console.WriteLine($"Результат: {resultText}");
            Console.WriteLine("-------------------");

            #endregion


            #region ЗАВДАННЯ 3: Обчислення площі фігури

            Console.WriteLine("=== ЗАВДАННЯ 3 ===");
            Console.WriteLine("Площу якої фігури ви хочете отримати?");
            Console.WriteLine("Введіть: Квадрат, Круг, Прямокутник або Трикутник");
            string figure = Console.ReadLine() ?? "";

            switch (figure)
            {
                case "Квадрат":
                case "квадрат":
                    {
                        Console.Write("Введіть розмір сторони: ");
                        string sideInput = Console.ReadLine() ?? "0";
                        float side = float.Parse(sideInput);
                        float area = side * side;
                        Console.WriteLine($"Площа = {area}");
                        break;
                    }
                case "Круг":
                case "круг":
                    {
                        Console.Write("Введіть розмір радіуса: ");
                        string radiusInput = Console.ReadLine() ?? "0";
                        float radius = float.Parse(radiusInput);
                        float pi = 3.14f;
                        float area = pi * radius * radius;
                        Console.WriteLine($"Площа = {area}");
                        break;
                    }
                case "Прямокутник":
                case "прямокутник":
                    {
                        Console.Write("Введіть першу сторону: ");
                        string sideAInput = Console.ReadLine() ?? "0";
                        float sideA = float.Parse(sideAInput);
                        Console.Write("Введіть другу сторону: ");
                        string sideBInput = Console.ReadLine() ?? "0";
                        float sideB = float.Parse(sideBInput);
                        float area = sideA * sideB;
                        Console.WriteLine($"Площа = {area}");
                        break;
                    }
                case "Трикутник":
                case "трикутник":
                    {
                        Console.Write("Введіть розмір основи: ");
                        string baseInput = Console.ReadLine() ?? "0";
                        float baseSize = float.Parse(baseInput);
                        Console.Write("Введіть розмір висоти: ");
                        string heightInput = Console.ReadLine() ?? "0";
                        float heightSize = float.Parse(heightInput);
                        float area = baseSize * heightSize / 2;
                        Console.WriteLine($"Площа = {area}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Невідома фігура");
                        break;
                    }
            }
            Console.WriteLine("-------------------");

            #endregion


            #region ЗАВДАННЯ 4: Заміна кожного 3-го, 5-го та 15-го символу

            Console.WriteLine("=== ЗАВДАННЯ 4 ===");
            Console.Write("Введіть будь-який текст: ");
            string textToReplace = Console.ReadLine() ?? "";

            char[] characters = textToReplace.ToCharArray();
            string modifiedText = "";

            for (int i = 0; i < characters.Length; i++)
            {
                int position = i + 1;

                if (position % 15 == 0)
                {
                    modifiedText += '?';
                }
                else if (position % 5 == 0)
                {
                    modifiedText += '9';
                }
                else if (position % 3 == 0)
                {
                    modifiedText += 'X';
                }
                else
                {
                    modifiedText += characters[i];
                }
            }

            Console.WriteLine($"Результат: {modifiedText}");
            Console.WriteLine("-------------------");

            #endregion
        }
    }
}
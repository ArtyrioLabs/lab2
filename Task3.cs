using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] question = new string[]
            {
                "Питання 1, якi кольору у прапору України?",
                "Питання 2, в якому мiстi знаходиться ДТЕУ?",
                "Питання 3, яка столиця України?",
                "Питання 4, скiльки днiв у високосному роцi?",
                "Питання 5, яка найдовша рiчка України?"
            };

            string[][] option = new string[][]
            {
                 new string[] { "1.жовтий i блакитний", "2.червоний i зелений", "3.чорний i жовтий", "4.зелений i фiолетовий" },
                new string[] { "1.Вiнниця", "2.Київ", "3.Львiв", "4.Одеса" },
                new string[] { "1.Харкiв", "2.Одеса", "3.Київ", "4.Днiпро" },
                new string[] { "1.365", "2.366", "3.364", "4.360" },
                new string[] { "1.Днiстер", "2.Пiвденний Буг", "3.Дунай", "4.Днiпро" }
            };

            int[] correctAnswers = new int[] { 1, 2, 3, 4, };

            int score = 0;

            for (int i = 0; i < question.Length; i++)
            {
                Console.WriteLine("Current User Score: " + score);
                Console.WriteLine(question[i]);
                for (int j = 0; j < option[i].Length; j++)
                {
                    Console.WriteLine(option[i][j]);
                }

                Console.Write("Ваша вiдповiдь: ");
                int answer = int.Parse(Console.ReadLine());

                if (answer == correctAnswers[i])
                {
                    score += 100;
                    Console.WriteLine("Correct answer");
                }
                else
                {
                    Console.WriteLine("Wrong Answer");
                    Console.WriteLine("кiнець програми.");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Current User Score: " + score);
            Console.WriteLine("Вiтаємо, ви вiдповiли на всi питання!");
            Console.ReadLine();
        }
    }
}
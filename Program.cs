using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select quiz: [0]Dansk Test [1]Water Quiz");
            int pick = Convert.ToInt32(Console.ReadLine());

            switch(pick)
            {
                case 0:
                List<Quiz> listDansk = new Logic().GetDanskTest();
                DanskTestViewer(listDansk);
                    break;
                case 1:
                List<Quiz> listWater = new Logic().GetWaterQuiz();
                WaterQuizViewer(listWater);
                    break;
                
                default: Console.WriteLine("Please only use 0 or 1");
                    break;
            }


        }

        private static void WaterQuizViewer(List<Quiz> list)
        {
            foreach (Quiz quiz in list)
            {
                Console.WriteLine(quiz.Question);
                for (int i = 0; i < quiz.Answers.Count; i++)
                {
                    Console.WriteLine($"[{i}] " + quiz.Answers[i]);
                }

                int choice;

                do
                {
                    Console.Write("Enter your choice:");
                    if (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    if (choice < 0 || choice > quiz.Answers.Count)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    break;

                } while (true);
                string result = (quiz.Answers[quiz.Correct] == quiz.Answers[choice]) ? "Correct answer!" : "Incorrect answer!";

                Console.WriteLine($"\n{result}\n{quiz.Description}\n");
            }
            Console.ReadKey();
        }
        private static void DanskTestViewer(List<Quiz> list)
        {

            foreach (Quiz quiz in list)
            {
                Console.WriteLine(quiz.Question);
                for (int i = 0; i < quiz.Options.Count; i++)
                {
                    Console.WriteLine($"[{i}] " + quiz.Options[i]);
                }

                int choice;

                do
                {
                    Console.Write("Enter your choice: ");
                    if (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    if (choice < 0 || choice > quiz.Options.Count)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    break;

                } while (true);
                string result = (quiz.Options[quiz.Answer] == quiz.Options[choice]) ? "Correct answer!": "Incorrect answer!";
                if (quiz.Answer == choice)
                {
                    quiz.Points++;
                }
                Console.WriteLine($"\n{result}\n");
                Console.WriteLine($"\nCurrent points: {quiz.Points} / 40");
            }
            Console.Clear();
            Console.ReadKey();
        }
    }
}

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
            List<Quiz> list = Logic.GetQuiz();

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
                    Console.Write("Enter your choice: [0] [1] [2] ");
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

    }
}

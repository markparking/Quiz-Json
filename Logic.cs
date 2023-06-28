using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JSONQuiz
{
    public class Quiz
    {
        public string Question { get; set; }
        public List<string> Answers { get; set; }
        public int Correct { get; set; }
        public string Description { get; set; }
    }

    internal class Logic
    {
        public static string fileName = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory() + "\\quiz.json"));
        
        public static List<Quiz> GetQuiz()
        {
            return JsonConvert.DeserializeObject<List<Quiz>>(fileName);
        }
    }
}

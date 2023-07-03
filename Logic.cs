using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
        public List<string> Options { get; set; }
        public int Answer { get; set; }
        public int Points { get; set; }
    }

    internal class Logic
    {
        private string fileNameWater = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory() + "\\quiz.json"));
        private string fileNameDansk = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory() + "\\DanskTest.json"));
        
        public List<Quiz> GetWaterQuiz()
        {
            return JsonConvert.DeserializeObject<List<Quiz>>(fileNameWater);
        }

        public List<Quiz> GetDanskTest()
        {
            return JsonConvert.DeserializeObject<List<Quiz>>(fileNameDansk);
        }

        public int PointCounter(int points)
        {
            return
        }
    }
}

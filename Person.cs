using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocCS
{
    internal class Person
    {

        public string Name { get; set; }
        public float MathScore { get; set; }
        public float EnglishScore { get; set; }
        public float ScienceScore { get; set; }

        public float AverageScore()
        {
            return (MathScore + EnglishScore + ScienceScore) / 3.0f;
        }

        public string GetClassification()
        {
            float average = AverageScore();
            if (average >= 8.5)
            {
                return "Giỏi.";
            }
            else if (average >= 7.0)
            {
                return "Khá.";
            }
            else if (average >= 5.0)
            {
                return "Trung Bình.";
            }
            else
            {
                return "Yếu.";
            }
        }


        public static float GetScore(string subject, string name)
        {
            float score;
            while (true)
            {
                try
                {
                    Console.Write("Nhập điểm {subject} của {name} là: ");
                    score = float.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi: Vui lòng nhập điểm dưới dạng số.");
                }
            }
            return score;
        }
    }
}

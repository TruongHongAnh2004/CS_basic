using System;
using System.Text;

namespace BaiTap
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Câu 1
            Console.Write("Nhập họ tên học sinh: ");
            string name = Console.ReadLine();

            Console.Write("Nhập điểm Toán của " + name + " là: ");
            float mathScore = float.Parse(Console.ReadLine());

            Console.Write("Nhập điểm Tiếng Anh của " + name + " là: ");
            float englishScore = float.Parse(Console.ReadLine());

            Console.Write("Nhập điểm Khoa học của " + name + " là: ");
            float scienceScore = float.Parse(Console.ReadLine());

            //Câu 2
            float averageScore = (mathScore + englishScore + scienceScore) / 3.0f;

            Console.WriteLine("Điểm Trung Bình của " + name + " là: " + averageScore);

            Console.WriteLine("Họ và tên: " + name);
            Console.WriteLine("Điểm các môn lần lượt là: "+ mathScore + " "+ englishScore + " "+ scienceScore);
            Console.WriteLine("DTB: " + averageScore);
            //Câu 3
            Console.Write("Xếp loại: ");
            if (averageScore >= 8.5)
            {
                Console.WriteLine("Giỏi.");
            }
            else
            {
                if (averageScore <= 8.4 && averageScore >= 7.0)
                {
                    Console.WriteLine("Khá.");
                }
                else if (averageScore <= 6.9 && averageScore >= 5.0)
                {
                    Console.WriteLine("Trung Bình.");
                }
                else
                {
                    Console.WriteLine("Yếu.");
                }
            }
            static float GetScore(string subject, string name)
            {
                float score;
                while (true)
                {
                    try
                    {
                        Console.Write($"Nhập điểm {subject} của {name} là: ");
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

}

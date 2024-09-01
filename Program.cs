using System.Text;
using HocCS;




Console.OutputEncoding = Encoding.UTF8;

var students = new Person();

Console.Write("Nhập số lượng học sinh: ");
int numOfStudents = int.Parse(Console.ReadLine());

for (int i = 0; i < numOfStudents; i++)
{
    Console.WriteLine("Nhập thông tin học sinh thứ "+ i+1 +" :");

    Person student = new Person();

    Console.Write("Nhập họ tên học sinh: ");
    student.Name = Console.ReadLine();

    student.MathScore = Person.GetScore("Toán", student.Name);
    student.EnglishScore = Person.GetScore("Tiếng Anh", student.Name);
    student.ScienceScore = Person.GetScore("Khoa học", student.Name);
}

Console.WriteLine("Danh sách học sinh đã nhập: ");
for (int i = 0; i < numOfStudents; i++)
{
    Console.WriteLine("Họ và tên: " + student.Name);
    Console.WriteLine("Điểm Toán: " + student.MathScore);
    Console.WriteLine("Điểm Tiếng Anh: " + student.EnglishScore);
    Console.WriteLine("Điểm Khoa học: " + student.ScienceScore);
    Console.WriteLine("Điểm Trung Bình: " + student.AverageScore());
    Console.WriteLine("Xếp loại: " + student.GetClassification());
}
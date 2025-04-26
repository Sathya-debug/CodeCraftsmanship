using StudentManagementSystem.Model;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        //1.Create a listy of Students
        List<Student> students = new List<Student>
        {
        new Student{ Name="John",Age=24,City="Salem",Marks=85 },
        new Student{ Name="Mike",Age=24,City="Chennai",Marks=90 },
        new Student{ Name="Ramesh",Age=24,City="Madurai",Marks=88 },
        new Student{ Name="Suresh",Age=24,City="Trichy",Marks=95 }
        };

        Console.WriteLine($"Students Older than 18:");
        var olderStudents = students.Where(s => s.Age > 18);
        foreach (Student student in olderStudents)
        {
            Console.WriteLine($"{student.Name} - Age: {student.Age}");
        }
        Console.WriteLine($"\nStudents who scored more than 80:");
        var topScorers = students.Where(s => s.Marks > 80);
        foreach (Student student in topScorers)
        {
            Console.WriteLine($"{student.Name} - Mark: {student.Marks}");
        }
        Console.WriteLine($"\nStudents Grouped by City:");
        var studentsByCity=students.GroupBy(s => s.City);
        foreach (var stu in studentsByCity) {
            Console.WriteLine( $"City:{stu.Key}");
            foreach (Student s in stu) 
            { 
                Console.WriteLine($"{s.Name}"); 
            }
        }
        Console.WriteLine($"\nStudent with highest Marks:");
        var topStudent=students.OrderByDescending(s => s.Marks).FirstOrDefault();
        if (topStudent != null)
        {
            Console.WriteLine($"{topStudent.Name} - {topStudent.Marks}");
        }
        Console.WriteLine($"\nAverage Marks of All Students:");
        double averageMarks=students.Average(s => s.Marks);
        Console.WriteLine($"Average Marks:{averageMarks:F2}");
        Console.ReadKey();
    }
}
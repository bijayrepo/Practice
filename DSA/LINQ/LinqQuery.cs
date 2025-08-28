using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LINQ
{
    internal class LinqQuery
    {
        public static void Linq()
        {
            int N = 2;
            var students = new List<Student>
                {
                    new Student { ClassName = "A", Name = "John", Marks = 85 },
                    new Student { ClassName = "A", Name = "Sara", Marks = 92 },
                    new Student { ClassName = "A", Name = "Tom",  Marks = 78 },
                    new Student { ClassName = "B", Name = "Mike", Marks = 88 },
                    new Student { ClassName = "B", Name = "Anna", Marks = 95 },
                    new Student { ClassName = "B", Name = "Sam",  Marks = 90 }
                };
            var topNStudentsPerClass = students.GroupBy(s => s.ClassName)
                                              .SelectMany(g => g.OrderByDescending(s => s.Marks).Take(N))
                                              .ToList();
                                            

            foreach (var student in topNStudentsPerClass)
            {
                Console.WriteLine($"Class: {student.ClassName}, Name: {student.Name}, Marks: {student.Marks}");
            }
        }
    }
    public class Student
    {
        public string ClassName { get; set; }=string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Marks { get; set; }
    }
}

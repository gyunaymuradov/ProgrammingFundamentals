using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsCount = int.Parse(Console.ReadLine());
            var students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                var currentStudent = ReadStudent();
                students.Add(currentStudent);
            }
            foreach (var currentStudent in students.OrderBy(a => a.Name).ThenByDescending(a => a.AverageGrade))
            {
                if (currentStudent.AverageGrade >= 5)
                {
                    Console.WriteLine($"{currentStudent.Name} -> {currentStudent.AverageGrade:F2}");
                }
            }
        }
        static Student ReadStudent()
        {
            var line = Console.ReadLine().Split(' ');
            return new Student
            {
                Name = line[0],
                Grades = line.Skip(1).Select(double.Parse).ToList()
            };
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade => Grades.Average();
    }
}
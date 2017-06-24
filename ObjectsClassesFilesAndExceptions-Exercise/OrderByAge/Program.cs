using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsList = ReadStudent();

            foreach (var student in studentsList.OrderBy(a => a.Age))
            {
                Console.WriteLine($"{student.Name} with ID: {student.Id} is {student.Age} years old.");
            }
        }
        static List<Student> ReadStudent()
        {
            var line = Console.ReadLine();
            var list = new List<Student>();
            while (line != "End")
            {
                var tokens = line.Split(' ');
                var name = tokens[0];
                var id = tokens[1];
                var age = int.Parse(tokens[2]);
                var currentStudent = new Student();
                currentStudent.Name = name;
                currentStudent.Id = id;
                currentStudent.Age = age;
                list.Add(currentStudent);
                line = Console.ReadLine();
            }
            return list;
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}

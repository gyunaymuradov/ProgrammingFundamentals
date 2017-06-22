using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var students = new List<Student>();

            while (input != "end of dates")
            {
                var tokens = input.Split(' ').ToArray();
                var name = tokens[0];
                var dateList = new List<DateTime>();

                if (tokens.Length > 1)
                {
                    var dates = tokens[1].Split(',').ToArray();
                    for (int i = 0; i < dates.Length; i++)
                    {
                        var currentDate = DateTime.ParseExact(dates[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        dateList.Add(currentDate);
                    }
                }
                if (!students.Any(x => x.Name == name))
                {
                    var newStudent = new Student();
                    newStudent.Name = name;
                    newStudent.AttendanceDates = dateList;
                    students.Add(newStudent);
                }
                else
                {
                    Student existingStudent = students.First(a => a.Name == name);
                    existingStudent.AttendanceDates.AddRange(dateList);
                }
                input = Console.ReadLine();
            }
            var secondInput = Console.ReadLine();
            while (secondInput != "end of comments")
            {
                var tokens = secondInput.Split('-').ToArray();
                var name = tokens[0];
                var comment = tokens[1];

                if (students.All(a => a.Name != name))
                {
                    secondInput = Console.ReadLine();
                    continue;
                }

                Student existingStudent = students.First(x => x.Name == name);
                var comments = new List<string>();
                comments.Add(comment);
                if (existingStudent.Comments != null)
                {
                    existingStudent.Comments.AddRange(comments);
                }
                else
                {
                    existingStudent.Comments = comments;
                }

                secondInput = Console.ReadLine();
            }

            foreach (Student student in students.OrderBy(a => a.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");

                if (student.Comments != null)
                {
                    foreach (var comment in student.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }

                Console.WriteLine("Dates attended:");
                foreach (var date in student.AttendanceDates.OrderBy(a => a))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> AttendanceDates { get; set; }
    }
}
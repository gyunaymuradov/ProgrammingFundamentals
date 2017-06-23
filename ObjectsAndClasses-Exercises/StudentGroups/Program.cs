using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfTowns = ReadTownsAndStudents();
            var listOfGroups = DistritubeStudentsIntoGroups(listOfTowns);

            int townsCount = listOfGroups.Select(a => a.Town).Distinct().Count();

            Console.WriteLine($"Created {listOfGroups.Count} groups in {townsCount} towns:");

            foreach (var group in listOfGroups)
            {
                Console.Write($"{group.Town.Name}=> ");
                Console.WriteLine(string.Join(", ", group.Student.Select(a => a.Email)));
            }
        }

        static List<Group> DistritubeStudentsIntoGroups(List<Town> listOfTowns)
        {
            var groupsList = new List<Group>();
            foreach (var town in listOfTowns.OrderBy(a => a.Name))
            {
                IEnumerable<Student> student = town.Students
                        .OrderBy(b => b.RegistrationTime)
                        .ThenBy(c => c.Name)
                        .ThenBy(d => d.Email);
                while (student.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Student = student.Take(group.Town.SeatsCount).ToList();
                    student = student.Skip(group.Town.SeatsCount);
                    groupsList.Add(group);
                }
            }
            return groupsList;
        }
        static List<Town> ReadTownsAndStudents()
        {
            var townsList = new List<Town>();
            var input = Console.ReadLine();
            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                    var tokens = input.Split(new char[] { '=', '>' });
                    var townName = tokens[0];
                    var seatsTokens = tokens[2].Split(' ').ToList();
                    var seats = int.Parse(seatsTokens[1]);

                    var town = new Town();
                    var studentsList = new List<Student>();
                    town.Name = townName;
                    town.SeatsCount = seats;
                    town.Students = studentsList;
                    townsList.Add(town);
                }
                else
                {
                    var tokens = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                    var studentName = tokens[0];
                    var email = tokens[1];
                    var date = DateTime.ParseExact(tokens[2], "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    var student = new Student();
                    student.Name = studentName;
                    student.Email = email;
                    student.RegistrationTime = date;
                    townsList.LastOrDefault().Students.Add(student);
                }
                input = Console.ReadLine();
            }
            return townsList;
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationTime { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Student { get; set; }
    }
}
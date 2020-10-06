using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace ListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var std1 = new Student()
            {
                Id = 1,
                Name = "Fred",
                GPA = 2.75,
                SAT = 1200
            };
            var std2 = new Student()
            {
                Id = 2,
                Name = "Alice",
                GPA = 3.25,
                SAT = 1350
            };
            var std3 = new Student()
            {
                Id = 3,
                Name = "Bob",
                GPA = 2.25,
                SAT = 1000
            };


            var StudentList = new List<Student>
            {
                std1, std2, std3
            };

            var StudentsDictionary = new Dictionary<int, Student>();
            //StudentsDictionary.Add(std1.Id, std1);
            //StudentsDictionary.Add(std2.Id, std2);
            //StudentsDictionary.Add(std3.Id, std3);
            foreach (var s in StudentList)
            {
                StudentsDictionary.Add(s.Id, s);
            }

            var s2 = StudentsDictionary[2];
            Console.WriteLine(s2.Name);

            var students = new List<Student>();
            students.Add(std1);
            students.Add(std2);
            students.Add(std3);
            //is students an honors student
            foreach (var student in students)
            {
                student.GPA += 0.10;
                if (student.SAT >= 1100)
                {
                  student.Honors = true;
                  Console.WriteLine($"{student.Name} is an honor student");
                }
                Console.WriteLine($"Name: {student.Name}, GPA: {student.GPA}");
            }


            var ints = new List<int>
            {
              286, 545, 268, 219, 324, 711, 471, 344, 990, 732, 542, 758, 372, 447, 497,
            };
            var total = 0;
            foreach(var rndo in ints)
            {
              total += rndo;
            }
              var avg = total / ints.Count;
              Console.WriteLine($" The Sum is {total} The Avg is {avg}");
        }
    }
}

namespace ExtensionMethodsDelegatesLamda
{
    using System;
    using System.Text;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Problem1Substring.SBExtensions;
    using Problem2IENumExtensions.Extensions;
    using Problem3FirstBeforeLast.Student;
    using ExtensionMethodsDelegatesLambda.Timer;
    public class TestingExtensionMethodsDelegatesLamda
    {
        static void Main(string[] args)
        {
            //TestProblemFrom3To5Students();
            //TestProblem6DivisibleBy7And3();
            //TestProblem7Timer();
            //TestProblemFrom9To15StudentGroups();
            //TestProblem17LongestString();
            TestProblem18GroupedByGroupNumber();
        }

        static void TestProblem1SubstringExtensions()
        {

        }

        static void TestProblem2IEnumerableExtensions()
        {

        }

        static void TestProblemFrom3To5Students()
        {
            Student[] students = new Student[]
            {
                new Student("Adragan", "Feratov", 10),
                new Student("Zera", "Chade", 18),
                new Student("Aesho", "Beshov", 25),
                new Student("Hrago", "Aetrov", 55),
                new Student("Kolyo", "Ficheto", 23)
            };

            //Problem 3. Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
            var sortedStudents =
                  from student in students
                  where string.Compare(student.FirstName, student.LastName) < 0
                  select student;

            foreach (var st in sortedStudents)
            {
                Console.WriteLine(st);
            }

            //Problem 4. Age range
            var studentsBetweenAge =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            foreach (var st in studentsBetweenAge)
            {
                Console.WriteLine(st);
            }

            //Problem 5. Order students
            Console.WriteLine("Lamda");
            //Lamda
            var sortedStudentsByLamda = students
                                .OrderByDescending(st => st.FirstName)
                                .ThenByDescending(st => st.LastName)
                                .ToArray();
            foreach (var st in sortedStudentsByLamda)
            {
                Console.WriteLine(st);
            }
            //LINQ
            Console.WriteLine("LINQ");
            var sortedStudentsByLINQ =
                from st in students
                orderby st.FirstName descending
                , st.LastName descending
                select st;

            foreach (var st in sortedStudentsByLINQ)
            {
                Console.WriteLine(st);
            }

        }

        static void TestProblem6DivisibleBy7And3()
        {
            int[] arr = new int[] { 2, 5, 10, 7, 14, 32, 64, 2323, 15 , 21, 63};

            Console.WriteLine("LAMDA");
            //LAMDA
            var arrDivisibleBy3And7Lamda =
                         arr.Where(x => x % 3 == 0 && x % 7 == 0)
                         .ToArray();
            foreach (var num in arrDivisibleBy3And7Lamda)
            {
                Console.WriteLine(num);
            }

            //LINQ
            Console.WriteLine("LINQ");
            var arrDivisibleBy3And7LINQ =
                from num in arr
                where num % 3 == 0 && num % 7 == 0
                select num;

            foreach (var num in arrDivisibleBy3And7LINQ)
            {
                Console.WriteLine(num);
            }
        }

        static void TestProblem7Timer()
        {
            var timer = new Timer("Makaroni", 1000, 3000);
        }

        static void TestProblemFrom9To15StudentGroups()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student("Adragan", "Feratov", 10, 1234206, "Adragan@gosho.com", 1, "0884089536"),
                new Student("Zera", "Chade", 18, 1234236, "Zera@gosho.com", 2, "0884451235" ),
                new Student("Aesho", "Beshov", 25, 1234006, "Aesho@abv.com", 3, "0984089251"),
                new Student("Hrago", "Aetrov", 55, 1234216, "Hrago@abv.com", 1, "0884083213"),
                new Student("Kolyo", "Ficheto", 23, 1634256, "Kolyo@gosho.com", 2, "0884011123")
            };

            studentList[0].Marks = new List<double>()
            {
                5, 6, 2.23
            };
            studentList[1].Marks = new List<double>()
            {
                4, 4, 3.4
            };
            studentList[2].Marks = new List<double>()
            {
                2
            };
            studentList[3].Marks = new List<double>()
            {
                2, 4, 6
            };
            studentList[4].Marks = new List<double>()
            {
                2, 2
            };

            //Problem 9
            //Getting students from group 2 with Lambda
            var studentsFromGroup2 = studentList.Where(st => st.GroupNumber == 2)
                                                .ToList();
            //Ordering students by first name with LINQ
            var studentsOrderedByFirstName =
                    from st in studentList
                    orderby st.FirstName ascending
                    select st;
            //Problem 11
            var studentsWithAbv =
                from st in studentList
                where st.Email.EndsWith("abv.com")
                select st;

            //Problem 12
            var studentsEmail =
                from st in studentList
                select st.PhoneNumber;

            //Problem 12
            var studentsWith1Mark6 =
                from st in studentList
                where st.Marks.Contains(6)
                select new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Marks = st.Marks
                };
            //Problem 14
            var studentsWith2Marks2 =
                from st in studentList
                where st.Marks.Count == 2 && st.Marks[0] == 2 && st.Marks[1] == 2
                select st;

            //Problem 15. Extract marks
            var marksFrom2006 =
                from st in studentList
                where st.FaculcyNumber.ToString()[5] == '0' && st.FaculcyNumber.ToString()[6] == '6'
                select st;
            Console.WriteLine();
        }

        static void TestProblem17LongestString()
        {
            var arrOfStr = new string[]{ "random", "strings", "are",
                                         "hard", "to", "think", "about", ":)"};

            string longest = arrOfStr.OrderByDescending(s => s.Length).First();

            Console.WriteLine();
            
        }

        static void TestProblem18GroupedByGroupNumber()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student("Adragan", "Feratov", 10, 1234206, "Adragan@gosho.com", 1, "0884089536"),
                new Student("Zera", "Chade", 18, 1234236, "Zera@gosho.com", 2, "0884451235" ),
                new Student("Aesho", "Beshov", 25, 1234006, "Aesho@abv.com", 3, "0984089251"),
                new Student("Hrago", "Aetrov", 55, 1234216, "Hrago@abv.com", 1, "0884083213"),
                new Student("Kolyo", "Ficheto", 23, 1634256, "Kolyo@gosho.com", 2, "0884011123")
            };

            var st =
                from std in studentList
                orderby std.GroupNumber ascending
                join x in studentList on std.GroupNumber equals x.GroupNumber
                select x;
            Console.WriteLine();
        }
    }
}

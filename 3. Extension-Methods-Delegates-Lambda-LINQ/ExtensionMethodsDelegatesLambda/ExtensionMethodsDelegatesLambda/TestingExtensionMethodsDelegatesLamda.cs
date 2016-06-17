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
    using ExtensionMethodsDelegatesLambda.Extensions;

    public class TestingExtensionMethodsDelegatesLamda
    {
        static void Main(string[] args)
        {
            TestProblem1SubstringExtensions();
            TestProblem2IEnumerableExtensions();
            TestProblemFrom3To5Students();
            TestProblem6DivisibleBy7And3();
            TestProblem7Timer();
            TestProblemFrom9To15StudentGroups();
            TestProblem17LongestString();
            TestProblem18GroupedByGroupNumber();
        }

        static void TestProblem1SubstringExtensions()
        {
            Console.WriteLine("Problem 1");
            StringBuilder str = new StringBuilder();
            str.Append("This homework consumed all of my time :3");
            Console.WriteLine(str.Substring(3, 10));
        }

        static void TestProblem2IEnumerableExtensions()
        {
            List<int> ints = new List<int>() { 3, 4, 5, 6, 21, 61 };
            Console.WriteLine("Sum: " + ints.Sum());
            Console.WriteLine("Product: " + ints.Product());
            Console.WriteLine("Min: " + ints.Min());
            Console.WriteLine("Max: " + ints.Max());
            Console.WriteLine("Avarage: " + ints.Avarage());
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
            Console.WriteLine("Problem 3");

            //Problem 3. Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
            var sortedStudents =
                  from student in students
                  where string.Compare(student.FirstName, student.LastName) < 0
                  select student;

            foreach (var st in sortedStudents)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("Problem 4");
            //Problem 4. Age range
            var studentsBetweenAge =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            foreach (var st in studentsBetweenAge)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("Problem 5");
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
            Console.WriteLine("Problem 6");
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
            Console.WriteLine("Problem 7: Timer");
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
            Console.WriteLine("Problem 9");
            var studentsFromGroup2 = studentList.Where(st => st.GroupNumber == 2)
                                                .ToList();
            //Ordering students by first name with LINQ
            var studentsOrderedByFirstName =
                    from st in studentList
                    orderby st.FirstName ascending
                    select st;
            foreach (var st in studentsFromGroup2)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("Problem 11");
            //Problem 11
            var studentsWithAbv =
                from st in studentList
                where st.Email.EndsWith("abv.com")
                select st;
            foreach (var item in studentsWithAbv)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Problem 12");
            //Problem 12
            var studentsEmail =
                from st in studentList
                select st.PhoneNumber;
            foreach (var item in studentsEmail)
            {
                Console.WriteLine(item);
            }
            //Problem 13
            Console.WriteLine("Problem 13");
            var studentsWith1Mark6 =
                from st in studentList
                where st.Marks.Contains(6)
                select new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Marks = st.Marks
                };
            foreach (var item in studentsWith1Mark6)
            {
                Console.WriteLine(item.FullName);
            }
            //Problem 14
            Console.WriteLine();
            Console.WriteLine("Problem 14");
            var studentsWith2Marks2 =
                from st in studentList
                where st.Marks.Count == 2 && st.Marks[0] == 2 && st.Marks[1] == 2
                select st;
            foreach (var item in studentsWith2Marks2)
            {
                Console.WriteLine(item);
            }
            //Problem 15. Extract marks
            Console.WriteLine("Problem 15");

            var marksFrom2006 =
                from st in studentList
                where st.FaculcyNumber.ToString()[5] == '0' && st.FaculcyNumber.ToString()[6] == '6'
                select st;
            foreach (var item in marksFrom2006)
            {
                Console.WriteLine(item);
            }
        }

        static void TestProblem17LongestString()
        {
            var arrOfStr = new string[]{ "random", "strings", "are",
                                         "hard", "to", "think", "about", ":)"};

            string longest = arrOfStr.OrderByDescending(s => s.Length).First();
            Console.WriteLine("Problem 17");

            Console.WriteLine("Longest string is: " + longest);
            
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
            //Problem 18
            Console.WriteLine("Problem 18");
            var groupedStudents =
                from std in studentList
                group std by std.GroupNumber;
            int i = 1;
            foreach (var students in groupedStudents)
            {
                Console.WriteLine("Group {0}", i);
                foreach (var student in students)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(student.GroupNumber);
                    }
                    Console.WriteLine(student.FirstName + " " + student.LastName);
                }
                Console.WriteLine();
                i++;
            }
            Console.WriteLine("Problem 19");
            //Problem 19
            studentList.GroupedByGroupNumber();
        }
    }
}

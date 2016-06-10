namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TestingAllExams
    {
        static void Main(string[] args)
        {
            TestingPointsFromTask1ToTask4();
            TestingGenericListFrom5To7();
            TestingMatrixFrom8To10();
        }

        static void TestingPointsFromTask1ToTask4()
        {
            Console.WriteLine("------------------- Testing Points From Task 1 To Task 4 -------------------");
            //********** TASK 1 **********
            Console.WriteLine("********** TASK 1 **********");
            //Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
            Point3D point = new Point3D(2, 5, 6);
            //Implement the ToString() to enable printing a 3D point.
            Console.WriteLine("This is Point3D.ToString(): {0}", point.ToString());

            //********** TASK 2 **********
            Console.WriteLine("********** TASK 2 **********");
            //Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
            //Add a static property to return the point O.
            Console.WriteLine("Start of the coordinate system: {0}", Point3D.ZeroPoint);

            //********** TASK 3 **********
            Console.WriteLine("********** TASK 3 **********");
            //Write a static class with a static method to calculate the distance between two points in the 3D space.
            Console.WriteLine("Distance between 2 points: {0}", Distance3D.CalculateDistance(point, Point3D.ZeroPoint));

            //********** TASK 4 **********
            Console.WriteLine("********** TASK 4 **********");
            //Create a class Path to hold a sequence of points in the 3D space.
            Path path = new Path();
            path.AddPoint(new Point3D(1, 2, 3));
            path.AddPoint(new Point3D(6, 8, 6));
            path.AddPoint(new Point3D(2, 5, 7));
            path.AddPoint(new Point3D(1, 2, 0));
            //Create a static class PathStorage with static methods to save and load paths from a text file.
            //Saving path to a file
            Console.WriteLine("Saving path to a file");
            PathStorage.SavePath(path, "file");
            //Loading paths from a file
            Path loadedPath = PathStorage.LoadPath("file");
            Console.WriteLine("Loading paths from a file");
            foreach (var item in loadedPath.Points)
            {
                Console.WriteLine(item);
            }
        }

        static void TestingGenericListFrom5To7()
        {
            Console.WriteLine("------------------- Testing Generic List From Task 5 To 7 -------------------");
            //********** TASK 5 **********
            Console.WriteLine("********** TASK 5 **********");
            //Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
            //Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
            GenericList<int> genericList = new GenericList<int>(5);
            //Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
            genericList.Add(5);
            Console.WriteLine("Added element to the list is: {0}", genericList[0]);
            genericList.RemoveByIndex(0);
            genericList.Insert(0, 100);
            Console.WriteLine("Element {0} is inserted at position 0 ", genericList[0]);
            genericList.Add(5);
            genericList.Add(1);
            genericList.Add(2);
            genericList.Add(3);
            Console.WriteLine("Find element in the list that its value is 5. Its index is: {0}", genericList.Find(5));
            Console.WriteLine("This is .ToString method: {0}", genericList.ToString());
            genericList.Clear();
            Console.WriteLine("The list is cleared.");

            //********** TASK 6 **********
            Console.WriteLine("********** TASK 6 **********");
            Console.WriteLine("The GenericList is growing automaticly");

            //********** TASK 7 **********
            Console.WriteLine("********** TASK 7 **********");
            //Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
            genericList.Add(5);
            genericList.Add(1);
            genericList.Add(2);
            genericList.Add(3);
            genericList.Add(231);
            Console.WriteLine("Min element on the list is: {0}", genericList.Min());
            Console.WriteLine("Max element on the list is: {0}", genericList.Max());
        }

        static void TestingMatrixFrom8To10()
        {
            Console.WriteLine("------------------- Testing Matrix From Task 8 To Task 10 -------------------");
            //********** TASK 8, 9, 10 **********
            //Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
            Matrix<int> matrix1 = new Matrix<int>(2, 2);
            matrix1[0, 0] = 5;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 15;
            Matrix<int> matrix2 = new Matrix<int>(2, 2);
            matrix2[0, 0] = 6;
            matrix2[0, 1] = 7;
            matrix2[1, 0] = 8;
            matrix2[1, 1] = -5;
            Console.WriteLine("matrix1 + matrix2 = ");
            Console.WriteLine(matrix1 + matrix2);
            Console.WriteLine("matrix1 - matrix2 = ");
            Console.WriteLine(matrix1 - matrix2);
            Console.WriteLine("matrix1 * matrix2 = ");
            Console.WriteLine(matrix1 * matrix2);
            Console.WriteLine("11 Exam is working");
        }
    }
}

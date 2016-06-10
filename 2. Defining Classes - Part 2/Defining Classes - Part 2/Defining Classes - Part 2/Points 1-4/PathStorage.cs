namespace DefiningClassesPart2
{
    using System.IO;

    public class PathStorage
    {
        public static void SavePath(Path path, string fileName)
        {
            using (StreamWriter sw = new StreamWriter("..//..//" + fileName + ".txt"))
            {
                for (int i = 0; i < path.Points.Count; i++)
                {
                    sw.WriteLine(path.Points[i]);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            filePath = "..//..//" + filePath + ".txt";
            Path path = new Path();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.EndOfStream == false)
                {
                    string nextPointTxt = sr.ReadLine();
                    Point3D nextPoint = Point3D.Parse(nextPointTxt);
                    path.AddPoint(nextPoint);
                }
            }
            return path;
        }
    }
}

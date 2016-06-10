namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Path
    {
        public Path()
        {
            this.Points = new List<Point3D>();
        }

        public List<Point3D> Points { get; set; }

        public void AddPoint(Point3D point)
        {
            this.Points.Add(point);
        }
        public void RemovePoint(Point3D point)
        {
            this.Points.Remove(point);
        }
    }
}

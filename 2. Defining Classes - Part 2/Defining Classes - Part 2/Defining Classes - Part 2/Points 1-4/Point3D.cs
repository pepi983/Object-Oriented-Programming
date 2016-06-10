namespace DefiningClassesPart2
{
    using System;

    public struct Point3D
    {
        private static readonly Point3D zeroPoint;

        static Point3D()
        {
            zeroPoint = new Point3D(0, 0, 0);
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D ZeroPoint
        {
            get
            {
                return zeroPoint;
            }
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }


        public override string ToString()
        {
            return String.Format("{0} {1} {2}", this.X, this.Y, this.Z);
        }

        public static Point3D Parse(string pointToParse)
        {
            string[] splittedPoint = pointToParse.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Point3D resultPoint = new Point3D(double.Parse(splittedPoint[0]), 
                                              double.Parse(splittedPoint[1]),
                                              double.Parse(splittedPoint[2]));
            return resultPoint;
        }
    }
}

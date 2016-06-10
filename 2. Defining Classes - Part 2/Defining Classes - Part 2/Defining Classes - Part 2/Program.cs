namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> m = new Matrix<int>(2, 2);
            m[0, 0] = 5;
            m[0, 1] = 5;
            m[1, 0] = 5;
            m[1, 1] = 5;
            Matrix<int> n = new Matrix<int>(2, 2);
            n[0, 0] = 5;
            n[0, 1] = 6;
            n[1, 0] = 5;
            n[1, 1] = 5;

            Matrix<int> res = m * n;
        }
    }
}

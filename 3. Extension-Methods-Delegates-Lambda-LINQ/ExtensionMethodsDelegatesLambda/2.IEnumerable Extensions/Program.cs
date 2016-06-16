namespace Problem2Extensions
{
    using System;
    using Problem2Extensions.Extensions;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(200);
            l.Add(-100);
            l.Add(23232);

            Console.WriteLine(l.Max());
        }
    }
}

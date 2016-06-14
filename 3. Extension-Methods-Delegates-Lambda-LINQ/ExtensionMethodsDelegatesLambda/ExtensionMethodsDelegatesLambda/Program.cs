using System;
using System.Text;
using ExtensionMethodsDelegatesLambda.Extensions;

namespace ExtensionMethodsDelegatesLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();
            str.Append("IDubbbz is gay retard");
            Console.WriteLine(str.Substring(10, 2));
            string test = "IDubbbz is gay retard";
            Console.WriteLine(test.Substring(10, 2));
        }
    }
}

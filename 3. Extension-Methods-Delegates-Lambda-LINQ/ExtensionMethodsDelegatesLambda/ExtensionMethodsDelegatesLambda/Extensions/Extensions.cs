namespace ExtensionMethodsDelegatesLambda.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Extensions
    {
        public static StringBuilder Substring (this StringBuilder sb, int index, int length)
        {
            StringBuilder res = new StringBuilder();
            for (int i = index; i < index + length; i++)
            {
                res.Append(sb[i]);
            }
            return res;
        }

        public static int Sum<T>(this IEnumerable<T> list)
        {
            int res = 0;
            foreach (var item in list)
            {
                res += item;
            }
            return 0;
        }
    }
}

namespace Problem1Substring.SBExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class SBExtensions
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
    }
}

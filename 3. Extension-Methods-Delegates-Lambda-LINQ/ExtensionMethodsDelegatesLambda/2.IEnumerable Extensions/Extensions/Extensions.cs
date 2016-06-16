namespace Problem2Extensions.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> elements)
              where T : struct, IComparable<T>, IEquatable<T>, IConvertible
        {
            ChechIfElementsAreNull(elements);

            T sum = new T();

            foreach (var item in elements)
            {
                sum = (dynamic)sum + item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> elements)
             where T : struct, IComparable<T>, IEquatable<T>, IConvertible
        {
            ChechIfElementsAreNull(elements);

            T product = (dynamic)1;

            foreach (var item in elements)
            {
                product = (dynamic)product * item;
            }

            return product;
        }

        public static T Avarage<T>(this IEnumerable<T> elements)
             where T : struct, IComparable<T>, IEquatable<T>, IConvertible
        {
            ChechIfElementsAreNull(elements);

            T sum = new T();
            int count = 0;

            foreach (var item in elements)
            {
                sum = (dynamic)sum + item;
                count++;
            }

            return (dynamic)sum / count;
        }

        public static T Min<T>(this IEnumerable<T> elements)
              where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            ChechIfElementsAreNull(elements);

            T min = elements.First();

            foreach (var item in elements)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> elements)
          where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            ChechIfElementsAreNull(elements);

            T max = elements.First();

            foreach (var item in elements)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }

            return max;
        }

        private static void ChechIfElementsAreNull<T>(IEnumerable<T> elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Elements cannot be emty");
            }
        }
    }
}

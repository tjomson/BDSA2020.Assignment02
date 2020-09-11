using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment02
{
    public static class Extensions
    {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> list)
        {
            foreach (var item in list)
            {
                foreach (var i in item)
                {
                    yield return i;
                }
            }
        }

        public static IEnumerable<int> Filter(this IEnumerable<int> items)
        {
            return items.Where(i => i % 7 == 0 & i > 42);
        }

        public static IEnumerable<int> LeapYears(this IEnumerable<int> items)
        {
            foreach (var year in items)
            {
                if (year % 4 == 0 && year % 100 != 0 && year >= 1582 || year % 400 == 0 && year >= 1582)
                {
                    yield return year;
                }
            }
        }


        public static bool IsSecure(this Uri uri)
        {
            var requestType = uri.Scheme;
            return requestType == "https";
        }

        public static int WordCount(this String str)
        {
            var pattern = "[a-zA-Z]+";
            var matches = Regex.Matches(str, pattern);
            return matches.Count;

        }


        public static string[] RowlingNamesExtension(this string str)
        {
            var sorted = str.Where(c => c.)
            }

    }
}
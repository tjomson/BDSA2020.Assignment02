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


        public static IEnumerable<string> RowlingNamesExtension(this IEnumerable<Wizard> wizards)
        {
            foreach(var wizard in wizards)
            {
                if (wizard.Creator == "J.K. Rowling")
                {
                    yield return wizard.Name;
                }
            }
        }

        public static int? DarthExtension(this IEnumerable<Wizard> wizards)
        {
            int? firstSithLordYear = null;
            foreach (var wizard in wizards)
            {
                var match = Regex.Match(wizard.Name, "^Darth.*");
                if (match.Captures.Count != 0)
                {
                    if (wizard.Year < firstSithLordYear || firstSithLordYear == null)
                    {
                        firstSithLordYear = wizard.Year;
                    }
                }
            }
            return firstSithLordYear;
        }

        public static IEnumerable<(string name, int? year)> HarryPotterExtension(this IEnumerable<Wizard> wizards)
        {  
            foreach(var wizard in wizards)
            {
                if (wizard.Medium == "Harry Potter")
                {
                    yield return (wizard.Name, wizard.Year);
                }
            }
        }

        public static IEnumerable<String> WizardNamesOrderedExtension(this IEnumerable<Wizard> wizards)
        {
            IEnumerable<Wizard> res  = wizards.OrderByDescending(wizards => wizards.Creator).ThenByDescending(wizards => wizards.Name);
            foreach (var wizard in res)
            {
                yield return wizard.Name;
            }
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment02
{
    public static class Extensions
    {
        public static IEnumerable<T> Flatten<T> (this IEnumerable<IEnumerable<T>> list) 
        {
           foreach (var item in list)
           {
               foreach (var i in item)
               {
                   yield return i;
               }
           }
        }
        
        public static IEnumerable<int> Filter (this IEnumerable<int> items) 
        {
            return items.Where( i => i % 7 == 0 & i > 42);
        }

         public static IEnumerable<int> LeapYears (this IEnumerable<int> items) 
        {
            foreach (var year in items)
            {
                if(year % 4 == 0 && year % 100 != 0 && year >= 1582 || year % 400 == 0 && year >= 1582) 
                {
                    yield return year;
                }
            }
        }


        public static bool IsSecure(this Uri uri)
        {
            var requestType = uri.Scheme;
            return requestType == "https";
         /*   
            return uri.Scheme == Uri.UriSchemeHttps;
    
            if(uri.Scheme == "https") {
                return true;
            } else {
                return false;
            }
       */
         
        }
   /*
        public static string WordCount(this String str)
        {
            if(str == null || str.Length == 0)
            {
                throw new Exception("Type sth");
            }

            string[] words = str.Split("")


        }*/
    } 
}
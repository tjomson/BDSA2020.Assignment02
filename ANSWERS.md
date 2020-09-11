# Answers

Extension methods:
1:
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

2:
public static IEnumerable<int> Filter (this IEnumerable<int> items) 
        {
            return items.Where( i => i % 7 == 0 & i > 42);
        }

3:
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

Delegates:

1:
Func<string,string> WordSplit = str => {
                char[] array = str.ToCharArray();
                Array.Reverse(array);
                return new String(array);
            };

2:
 Func<double,double,double> product = (x,y) => x * y;

3:
    Func<string,int,bool> Checker = (x,y) => {    
        int number;

        if(int.TryParse(x, out number) && number == y) {
            return true;
        } 
            return false;
    };  
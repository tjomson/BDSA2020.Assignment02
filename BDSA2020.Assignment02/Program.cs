using System;

namespace BDSA2020.Assignment02
{

    public class Program
    {
        public static void Main(string[] args)
        {
           Func<string,string> WordSplit = str => {
                char[] array = str.ToCharArray();
                Array.Reverse(array);
                return new String(array);
            };

            Console.WriteLine(WordSplit("hejmeddig"));

            
            Func<double, double, double> product = (a, b) => a * b;

            var wizards = Wizard.Wizards.Value;

            Console.WriteLine(product(45, 56));

        }
    }
}

using System;
using Xunit;

namespace BDSA2020.Assignment02.Tests
{
    public class DelegatesTests
    {
        [Theory]
        [InlineData("abcdefg", "gfedcba")]
        [InlineData("giiiiii", "iiiiiig")]        
        public void test_delegate_reverse_string(string input, string expected)
        {
             Func<string,string> WordSplit = str => {
                char[] array = str.ToCharArray();
                Array.Reverse(array);
                return new String(array);
            };

            var actual = WordSplit(input);
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 4, 20)]
        [InlineData(-2.6, 9.76, -25.376)]
        public void test_func_product_of_two_doubles(double input,double input2, double expected)
        {
            Func<double,double,double> product = (x,y) => x * y;

            var actual = product(input,input2);
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(" 0042", 42, true)]
        [InlineData("34", 34, true)]
        [InlineData("89", 23, false)]
        [InlineData("abc", 4, false)]
        public void test_func_Check_string_and_number(string input, int input2, bool expected)
        {
            Func<string,int,bool> Checker = (x,y) => {    
                int number;

                if(int.TryParse(x, out number) && number == y) {
                    return true;
                } 
                    return false;
            };  
            
            var actual = Checker(input,input2);
            
            Assert.Equal(expected, actual);
        }
        
    }
}

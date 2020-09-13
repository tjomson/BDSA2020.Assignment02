using System;
using System.Collections.Generic;
using Xunit;
using BDSA2020.Assignment02;
namespace BDSA2020.Assignment02.Tests
{
    public class ExtensionsTests
    {
        IEnumerable<int>[] xs;
        int[] ys = new int[]{70, 14, 12, 42, 49, 2004, 1900, 2000, 1757, 1923, 1800, 1648, 2052};
        
        [Fact]
        public void test_Flatten()
        {
            xs = new List<int>[]{new List<int>(){1,2}, new List<int>(){3,4}};
            var expectedOutput = new int[]{1,2,3,4};
            var actual = xs.Flatten();
            
            var counter = 0;
            foreach (var item in actual)
            {
                Assert.Equal(expectedOutput[counter], item);
                counter++;
            }
            Assert.Equal(4, counter);
        }

        [Fact]
        public void test_Filter() 
        {
            var expected = new int[] {70, 49, 1757};
            var actual = ys.Filter();
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void test_isLeapYear()
        {
            var expected = new int[] {2004, 2000, 1648, 2052};
            var actual = ys.LeapYears();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("https://sss.com", true)]
        [InlineData("http://dr.dk", false)]
        public void test_IsSecure(string uri, bool expected)
        {
            Uri testCase = new Uri(uri);
            Assert.Equal(expected, testCase.IsSecure());
        }

        [Theory]
        [InlineData("This is a test", 4)]
        [InlineData("1 2 test is fun 3 5", 3)]
        [InlineData("hej 2 ! % #", 1)]
        public void test_WordCount(string input, int expected)
        {
            var actual = input.WordCount();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void test_RowlingNamesExtension()
        {
            var wizards = Wizard.Wizards.Value;
            var actual = wizards.RowlingNamesExtension();
            var expected = new string[]{"Harry Potter", "Lord Voldemort"};

            var counter = 0;
            foreach(var name in actual)
            {
                Assert.Equal(expected[counter], name);
                counter++;
            }
            Assert.Equal(2, counter);
        }

        [Fact]
        public void test_DarthExtension()
        {
            var wizards = Wizard.Wizards.Value;
            var actual = wizards.DarthExtension();
            var expected = 1977;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void test_HarryPotterExtension()
        {
            var wizards = Wizard.Wizards.Value; 
            var actual = wizards.HarryPotterExtension();
            var expected = new (string name, int? year)[]{("Harry Potter", 1997), ("Lord Voldemort", 2002)};
            
            var counter = 0;
            foreach (var wizard in actual)
            {
                Assert.Equal(expected[counter], wizard);
                counter++;
            }
            Assert.Equal(2, counter);
        }

        [Fact]
        public void test_WizardNamesOrderedExtension()
        {
            var wizards = Wizard.Wizards.Value; 
            var actual = wizards.WizardNamesOrderedExtension();
            var expected = new string[]{"Shrek", "Sauron", "Lord Voldemort", "Harry Potter", "Lionel Messi", "Yoda", "Darth Vader", "Darth Plagueis", "Darth Maul", "boogieman"};
            var counter = 0;
            foreach (var name in actual)
            {
                Assert.Equal(expected[counter], name);
                counter++;
            }
            Assert.Equal(10, counter);
        }
    }
}

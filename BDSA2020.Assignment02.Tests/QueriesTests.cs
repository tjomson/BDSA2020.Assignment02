using System;
using Xunit;
using System.Collections.Generic;
namespace BDSA2020.Assignment02.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void Find_Rowling_Wizards()
        {
    
            var wizards = Wizard.Wizards.Value; 
            var actual = Queries.RowlingNamesLinq(wizards);
            string[] arr ={"Harry Potter", "Lord Voldemort"};
            string expected = String.Concat(arr);
            Assert.Equal(expected,actual.ToString());
        }

         [Fact]
        public void Find_First_Year_Darth_Wizards()
        {
            var expected = 1977;
            var wizards = Wizard.Wizards.Value; 
            var actual = Queries.DarthLinq(wizards);
            
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Find_Harry_Potter_Books()
        {
            var wizards = Wizard.Wizards.Value; 
            var actual = Queries.HarryPotterQueries(wizards);
            (string name, int? year)[] expected = new (string name, int? year)[]{("Harry Potter", 1997),("Lord Voldemort", 2002)};
            Assert.Equal(actual,expected);
        }

        [Fact]
        public void Find_Reverse_Order_Of_Wizards_Name_And_Creator()
        {
            var wizards = Wizard.Wizards.Value; 
            var actual = Queries.WizardNameOrderQuery(wizards);
            var expected = new string[]{"Shrek", "Sauron", "Lord Voldemort", "Harry Potter", "Lionel Messi", "Yoda", "Darth Vader", "Darth Plagueis", "Darth Maul", "boogieman"};
           
            Assert.Equal(expected,actual);
        }
    } 
}
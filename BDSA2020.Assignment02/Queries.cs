using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using System.Linq;
using System.Globalization;

namespace BDSA2020.Assignment02
{
    public class Queries
    {

        public static IEnumerable<Wizard> RowlingNamesLinq(IEnumerable<Wizard> wizards)
        {
             IEnumerable<Wizard> res  =
             from Wizard in wizards
             where Wizard.Creator.Equals("J.K Rowling")
             select Wizard;
            
            return res;
        }

        public static int DarthLinq(IEnumerable<Wizard> wizards)
        {
            var v = from w in wizards
            where w.Name.StartsWith("Darth")
            orderby w.Year ascending
            select w.Year;

            return (int) Enumerable.First(v);
        }       

         public static IEnumerable<(string name, int? year)> HarryPotterQueries(IEnumerable<Wizard> wizards)
        {
             IEnumerable<(string name, int? year)> res  =
             from Wizard in wizards
             where Wizard.Medium.Equals("Harry Potter")
             select (Wizard.Name, Wizard.Year);
            
            return res;
        }

          public static IEnumerable<string> WizardNameOrderQuery(IEnumerable<Wizard> wizards)
        {
             IEnumerable<string> res  =
             from w in wizards
             orderby w.Creator descending, w.Name descending
             select w.Name;
        
            return res;
        }
    }
}
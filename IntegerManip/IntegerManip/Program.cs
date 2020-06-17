using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerManip
{
    class Program
    {
        //As a team, write a project to prompt the user for up to 20 integers.  
        //The user will be allowed to choose from the following menu options until they decide to quit:
        //• Display the whole list of input
        //• Display every even number
        //• Display every odd number
        //• Display every 5th number
        //• Display the sum of the integers
        //• Display every number divisible by 3
        //• Quit
        public String EveryFifth()
        {
            if (10 > numbers.Count && numbers.Count >= 5)
            {
                return numbers.ElementAt(4).ToString();
            }
            if (15 > numbers.Count && numbers.Count >= 10)
            {
                return numbers.ElementAt(4).ToString() + "\n" +
                        numbers.ElementAt(9).ToString();
            }
            if (20 > numbers.Count && numbers.Count >= 15)
            {
                return numbers.ElementAt(4).ToString() + "\n" +
                        numbers.ElementAt(9).ToString() + "\n" +
                        numbers.ElementAt(14).ToString();
            }
            if (numbers.Count == 20)
            {
                return numbers.ElementAt(4).ToString() + "\n" +
                        numbers.ElementAt(9).ToString() + "\n" +
                        numbers.ElementAt(14).ToString() + "\n" +
                        numbers.ElementAt(19).ToString();
            }
            else
            {
                return "Not enough numbers.";
            }
        }
    }
}

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
            if (10 > numbers.size() && numbers.size() >= 5)
            {
                return numbers.get(4).toString();
            }
            if (15 > numbers.size() && numbers.size() >= 10)
            {
                return numbers.get(4).toString() + "\n" +
                        numbers.get(9).toString();
            }
            if (20 > numbers.size() && numbers.size() >= 15)
            {
                return numbers.get(4).toString() + "\n" +
                        numbers.get(9).toString() + "\n" +
                        numbers.get(14).toString();
            }
            if (numbers.size() == 20)
            {
                return numbers.get(4).toString() + "\n" +
                        numbers.get(9).toString() + "\n" +
                        numbers.get(14).toString() + "\n" +
                        numbers.get(19).toString();
            }
            else
            {
                return "Not enough numbers.";
            }
        }
    }
}

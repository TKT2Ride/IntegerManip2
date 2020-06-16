using System;
using System.Collections.Generic;
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
        public String DivisibleBy3()
        {
            String finish = "";
            for (Integer i = 0; i < numbers.size(); i++)
            {
                if (i % 3 == 0)
                {
                    finish = finish + "\n" + i.toString();
                }
            }
            return finish;
        }
    }
}

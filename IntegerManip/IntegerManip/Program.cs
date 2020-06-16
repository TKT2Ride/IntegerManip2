using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
        static void Main(string[] args)
        {

            

            

            for (int i = 0; i < numbers.Count; i++)
            {
                
                int x = (int)numbers[i];

                if((x % 2) == 1)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            

            Console.Read();



        }
    }
}

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
        static void Main(string[] args)
        {
            int cont2 = 1;
            while (cont2 != 7)
            {
                Console.WriteLine("1. Display all numbers");
                Console.WriteLine("2. Display every even number");
                Console.WriteLine("3. Display every odd number");
                Console.WriteLine("4. Display every 5th number");
                Console.WriteLine("5. Display the sum of the integers");
                Console.WriteLine("6. Display every number divisible by 3");
                Console.WriteLine("7. Quit");
                int menuoption = Convert.ToInt32(Console.ReadLine());
                if (menuoption == 1)
                {
                    for (int counter = 0; counter < numbers.Count; counter++)
                    {
                        Console.Write(numbers.ElementAt(counter) + " ");
                    }
                    Console.ReadLine();
                }
                if (menuoption == 2)
                {
                    evenNumbers();
                }
                if (menuoption == 3)
                {
                    OddNumbers();
                }
                if (menuoption == 4)
                {
                    Every5th();
                }
                if (menuoption == 5)
                {
                    numberSum();
                }
                if (menuoption == 6)
                {
                    DivisibleBy3();
                }
            }

        }
    }
}
    }
}

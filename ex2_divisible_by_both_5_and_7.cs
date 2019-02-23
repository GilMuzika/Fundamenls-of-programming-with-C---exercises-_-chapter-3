using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.
 */

namespace Fundamentals_of_computer_programming_with_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // function 'PleaseEnterSomeNumbers()' used for taking a number from the user input. 
            // This function returns an array so accsess to the first (and in this case only) member of the aray 
            // taken by indexation. The parameter that the function takes when called defines the number of its returned array members.
            int n = PleaseEnterSomeNumbers(1)[0];

             if (!(n % 5 == 0 && n % 7 == 0)) { Console.WriteLine("The number {0} can't be divided by 5 or 7 without a reminder.", n); }
             else { Console.WriteLine("The number {0} can be divided by 5 or 7 without a reminder. \nIt's division by 5 is {1} and by 7 is {2}", n, n/5, n/7); }           
        }






        static int[] PleaseEnterSomeNumbers(int iterations)
        {

            if (iterations == 1) { Console.WriteLine("Please enter one number:\n"); }
            else  { Console.WriteLine("Please enter {0} numbers:\n", iterations); }

            int[] arriterations = new int[iterations];

            for (int i = 0; i < iterations; i++) {
                if (i > 0) { Console.Clear(); }
                if (i != 0) { Console.WriteLine("Please enter a number: \n"); }
                int line;
                    EnterNumber:
                    if (Int32.TryParse(Console.ReadLine(), out line)) { arriterations[i] = line; }
                    else { Console.WriteLine("\n This is not a number! \nPlease enter only numbers. \nNow lets try again: \n"); goto EnterNumber; }
            }

            return arriterations;
        }
    }   
}






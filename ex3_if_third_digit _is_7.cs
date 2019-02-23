using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write an expression that looks for a given integer if its third digit (right to left) is 7.
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
            EntNum:
            int n = PleaseEnterSomeNumbers(1)[0];

            Console.WriteLine("-----------------\n");
            if (n.ToString().Length < 3) {Console.WriteLine("Your number {0} is {1}-digits number! \nYour number must have at lest 3 digits! \n Now plese try again!\n", n, n.ToString().Length); goto EntNum; }

            char[] charr = n.ToString().ToCharArray();

            if (charr[2] == '7') { Console.WriteLine("The third digit of your number is 7"); }
            else { Console.WriteLine("The third digit of your number is't 7"); }
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






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write an expression that checks whether the third bit in a given integer is 1 or 0.
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
            // 

            Console.WriteLine("Now we're about to calculate an area of trapezoid.");
            Console.WriteLine("Please enter three (3) numbers. \nThe first (1) number ment to be the trapezoid narrower base, \nthe second (2) is the wider respectively, \nand the third (3) is it's height. \n");
            int[] copyarr = (int[])PleaseEnterSomeNumbers(3).Clone();
            int b1 = copyarr[0];
            int b2 = copyarr[1];
            int h = copyarr[2];

            double s = (b1+b2)*h/2;
            Console.WriteLine("The area of the trapezoid is: "+s);











        }
        

        static int[] PleaseEnterSomeNumbers(int iterations)
        {

            if (iterations == 1) { Console.WriteLine("Please enter one number:\n"); }
            else  { Console.WriteLine("Please enter {0} numbers:\n", iterations); }

            int[] arriterations = new int[iterations];

            for (int i = 0; i < iterations; i++) {
                //if (i > 0) { Console.Clear(); }
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






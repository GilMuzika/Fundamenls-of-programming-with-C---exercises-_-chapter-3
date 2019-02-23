using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
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

            Console.WriteLine("Now we're about to calculate an area of a rectangle.");
            Console.WriteLine("Please enter two (2) numbers. \nEach of them are one side of the rectangle.\n");
            int[] copyarr = (int[])PleaseEnterSomeNumbers(2).Clone();
            int b1 = copyarr[0];
            int b2 = copyarr[1];

            double s = b1 * b2;
            Console.WriteLine("The area of the rectangle is: "+s);











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






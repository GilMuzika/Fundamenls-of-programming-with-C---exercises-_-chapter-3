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

            int n = PleaseEnterSomeNumbers(1)[0];

            if (DecimalToBinaryReprsentation(n).ToCharArray()[2] == '0') { Console.WriteLine("The third bit of your number is ZERO \"0\""); }
            if (DecimalToBinaryReprsentation(n).ToCharArray()[2] == '1') { Console.WriteLine("The third bit of your number is ONE \"1\""); }


        }
        

        static string DecimalToBinaryReprsentation(int num)
        {

            string result;


            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            return result;
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






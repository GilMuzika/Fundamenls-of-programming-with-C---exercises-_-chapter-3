using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 */

namespace Fundamentals_of_computer_programming_with_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that checks for a given point { x, y}
            // if it is within the circle K({ 0, 0}, R = 5). Explanation: the point { 0, 0} is the center of the circle and 5 is the radius.
            // 

            Console.WriteLine("Now we're about to calculate within the circle or not a specific position.");
            Console.WriteLine("The raius of the circle is 5. \nPlease enter two numbers, that define the position: \n");
             int[] copyarr = (int[])PleaseEnterSomeNumbers(2).Clone(); 
             double x = copyarr[0];
             double y = copyarr[1];



            if ((x * x + y * y) <= 25) { Console.WriteLine("The position [{0}, {1}] is inside the circle.\n", x, y); }
            else { { Console.WriteLine("The position [{0}, {1}] is outside the circle.\n", x, y); } }











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






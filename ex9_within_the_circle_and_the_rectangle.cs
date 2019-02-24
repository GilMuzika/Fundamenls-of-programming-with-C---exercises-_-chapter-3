using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write an expression that checks for given point {x, y} if it is within the circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. Clarification: for the rectangle the lower left and the upper right corners are given.
 */

namespace Fundamentals_of_computer_programming_with_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("Now we're about to calculate within the circle or not a specific position.");
            Console.WriteLine("The raius of the circle is 5. \nPlease enter two numbers, that define the position: \n");
             int[] copyarr = (int[])PleaseEnterSomeNumbers(2).Clone(); 
             double x = copyarr[0];
             double y = copyarr[1];

            // determinig if the specific position is within the circle and the rectangle
            if (WithinTheCircle(x, y) && WithinTheRectangle(x, y)) { Console.WriteLine("The position [{0}, {1}] lays within the circle AND the rectangle", x, y); }
            else { Console.WriteLine("The position [{0}, {1}] lays outside the circle OR the rectangle", x, y); }

        }

        // determinig if the specific position is within the circle with radius = 5
        static Boolean WithinTheCircle(double x, double y)
        {
            bool incircle = false;
            if ((x * x + y * y) <= 25) { incircle = true; }
            return incircle;
        }

        // determinig if the specific position is within the rectangle positioned by left lower corner [-1; 1] and right upper corner [5; 5]
        static Boolean WithinTheRectangle(double x, double y)
        {
            bool inrectangle = false;
            if (x >= -1 && x <=5 && y >= 1 && y<= 5) { inrectangle = true; }
            return inrectangle;
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






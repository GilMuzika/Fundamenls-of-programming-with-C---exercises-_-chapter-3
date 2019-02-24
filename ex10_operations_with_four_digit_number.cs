using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:
- Calculates the sum of the digits (in our example 2+0+1+1 = 4).
- Prints on the console the number in reversed order: dcba (in our example 1102).
- Puts the last digit in the first position: dabc (in our example 1201).
- Exchanges the second and the third digits: acbd (in our example 2101).
 */

namespace Fundamentals_of_computer_programming_with_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Now we're about to calculate within the circle or not a specific position.");
            Console.WriteLine("The raius of the circle is 5. \nPlease enter two numbers, that define the position: \n");

            int nstr = PleaseEnterSomeNumbers(1)[0];


            int[] copyarr = (int[])DecompileAMultidigitNumberTOIndividualDigits(nstr).Clone();

            //Console.WriteLine(copyarr[1]);

            //sum of individual digits: 
            int sum = 0;
            Console.Write("The sum of a digits in the number is: ");
            foreach (int one in copyarr)
            {
                string plus = "";
                if (one != copyarr[copyarr.Length-1]) { plus = "+"; }
                Console.Write("{0}{1}", one, plus);
                sum = sum + one;
            }
                Console.WriteLine(" = " + sum);

            Console.WriteLine("----------------------------------\n");

            //printing the number in reversed order:
            Console.Write("The number in reversed order is: ");
            
            for (int i = copyarr.Length - 1; i >= 0; i--)
                {
                Console.Write(copyarr[i]);
                }
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------\n");

            //putting the last digit in the first position:
            Console.Write("The number with the last digit in the first position is: ");
            Console.Write(copyarr[copyarr.Length - 1]);
            for (int i=0; i < copyarr.Length - 1; i++)
            {
                Console.Write(copyarr[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------\n");

            //excanging the second and the third digits:
            Console.Write("The number with the second and the first digits exchanged is: ");
            for (int i = 0; i <= copyarr.Length - 1; i++)
            {
                if (i == 1) { Console.Write(copyarr[2]); }
                if (i == 2) { Console.Write(copyarr[1]); }
                if (i != 2 && i != 1) { Console.Write(copyarr[i]); }
            }
            Console.WriteLine("\n");







        }


        static int[] DecompileAMultidigitNumberTOIndividualDigits (int n)
        {
            List<int> listOfInts = new List<int>();
            while (n > 0)
            {
                listOfInts.Add(n % 10);
                n = n / 10;
                
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }

        static int[] PleaseEnterSomeNumbers(int iterations)
        {

            if (iterations == 1) { Console.WriteLine("Please enter one number:\n"); }
            else { Console.WriteLine("Please enter {0} numbers:\n", iterations); }

            int[] arriterations = new int[iterations];

            for (int i = 0; i < iterations; i++)
            {
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




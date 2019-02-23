using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program, which compares correctly two real numbers with accuracy at least 0.000001.
 */ 

namespace Fundamentals_of_computer_programming_with_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number:");
            int n;
        EnterNumber:
            if (Int32.TryParse(Console.ReadLine(), out n)) { }
            else { Console.WriteLine("This is nit a numbeer. \nPlease try again: \n"); goto EnterNumber; }

            Console.WriteLine(n%2 == 0 ? "Even" : "Odd");
        }
    }
}

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main(string[] args) 
        {
           int num = 35;
           int position = 6;
           if ((num & (1 << position)) != 0) {Console.WriteLine("The bit on position {0} in the number {1} is 1", num, position);}
           else {Console.WriteLine("The bit on position {0} in the number {1} is 0", num, position);}
           
           //Console.Write((35 & (1 << 6)) != 0 ? true : false);
           
           Console.WriteLine("------------------\n");
           
           
           char v = 's';
           int p = 3;
           bool flag;
           
           
          if ((v & (1 << p)) != 0) flag=true;
          else flag = false;
           
           Console.Write($"The bit value of the position {p}  is: "); Console.WriteLine(flag ? "1" : "0");
        }
    }
}
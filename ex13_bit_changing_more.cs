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
            
            int n = 255;
            int v = 0; 
            int pos =4;
            
            
                if (IfPosition(n, pos) && v == 1) // if the bit on position 'pos' is 1
                    {
                    // no actions nedded, the bit is already v
                    }
                if (IfPosition(n, pos) && v == 0) //the bit is 1
                    {
                    //we need to change the bit to 0
                    
                       int d =  (n ^ (1 << pos)); Console.Write($"{n} ; {d}");
                    
                    }
                if (!(IfPosition(n, pos)) && v == 1) //the bit is 0
                    {
                    // we need to change the bit to 1
                        
                       int d =  (n | (1 << pos)); Console.Write($"{n} ; {d}");
                        
                    }
                if (!(IfPosition(n, pos)) && v == 0) //the bit is 0
                    {
                    // no changes needed, the bit is already 0
                    }
            
            
        }
        
        
        // if 'flag' that the fylunction returns is true
        // sovthe bit in 'n' on position 'pos' is 1
        // elswere is 0
        private static Boolean IfPosition(int n, int position)
            { bool flag;
                if ((n & (1 << position)) != 0) flag = true;
                else flag = false;
                return flag;
            }
            
            
        
    }
}
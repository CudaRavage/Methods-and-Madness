using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a number to be doubled: ");   
     
            int usrNum = Convert.ToInt32(Console.ReadLine());     
            Console.WriteLine("Answer is: " + Numm(usrNum));     
  
            Console.ReadKey();                                     
        }

        public static int Numm(int numm)    
        {
            int timesTwo = numm * 2; 
            return timesTwo;                 

        }
    }
}

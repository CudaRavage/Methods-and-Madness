using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4  // running this program gives a console window that shows "System.Int32[]" ten times
{
    class Program
    {
        static void Main(string[] args)
        {

            Testies();
            Printer();
            Console.ReadKey();

        }

        public static int[] Testies()
        {
            int[] numbers = new int[10];
            for (int index = 0; index < 10; index++ )
            {
                numbers[index] = index;
                
            }

                return numbers;
        }


        static void Printer()
        {
            for (int index = 0; index < 10; index++)
            {
                Console.Write(Testies());
            }
        }
    }
}
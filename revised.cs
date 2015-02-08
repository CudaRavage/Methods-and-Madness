using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4 
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testiesOutput = Testies();
            Testies();
            Printer(testiesOutput);

            Console.ReadKey();

        }

        static int[] Testies()
        {
            int[] numbers = new int[10];

            for (int index = 0; index < 10; index++ )
            {
                numbers[index] = index;
                
            }

                return numbers;
        }


        static void Printer(int[] testiesOutput)
        {
            for (int index = 0; index < 10; index++)
            {
                Console.Write(testiesOutput[index] + " ");
            }

       
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTableWithEntryNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Welcome to the Multiplication table.");
            Console.WriteLine("To start tell us a number that you like to know the table:");
            Console.Write("The number that a like to know is: ");
            
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Below is the table of {0}", number);

            for (int i = 1; i <= 10; i++) 
            {
                int result;

                result = number * i;

                Console.WriteLine("{0} x {1} = {2}", number, i, (number * i));
            }

            Console.ReadLine();

        }
    }
}

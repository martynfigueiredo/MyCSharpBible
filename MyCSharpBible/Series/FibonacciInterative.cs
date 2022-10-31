using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpBible.Series
{
    internal class FibonacciInterative
    {
        private static void Main()
        {
            int firstNumber = 0, secondNumber = 1, nextNumber = 0, numberOfElements;
            Console.Write("Enter the number of Elements to print : ");
            numberOfElements = int.Parse(Console.ReadLine());
            if (numberOfElements < 2)
            {
                Console.WriteLine("Please Enter a number greater than 2");
            }
            else
            {
                Console.Write("Sequence: " + firstNumber + " " + secondNumber + " ");

                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + secondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }
            }
            if (numberOfElements > 3 && nextNumber > 2)
            {
                Console.WriteLine("\nThe " + numberOfElements + "th number of the Fibonacci Sequence is: " + nextNumber);
            }
            
            Console.ReadKey();
        }
    }
}

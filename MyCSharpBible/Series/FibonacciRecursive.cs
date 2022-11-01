using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyCSharpBible.Series
{
    internal class FibonacciRecursive
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter the Length of the Fibonacci Series: ");
            int number = int.Parse(Console.ReadLine());
            FibonacciSeries(0, 1, 1, number);
            Console.ReadKey();
        }


        public static void FibonacciSeries(int firstNumber, int secondNumber, int counter, int number)
        {
            Console.Write(firstNumber + " ");
            if (counter < number)
            {
                FibonacciSeries(secondNumber, firstNumber + secondNumber, counter + 1, number);
            }
        }
    }
}
using System;

namespace LineComparison
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t################################################################");
            Console.WriteLine("\t\t\t\t\tWELCOME TO LINE COMPARISON COMPUTATATION PROGRAM");
            Console.WriteLine("\t\t\t\t################################################################");
           
            // Creating Instance of Class Line Comparison..
            LineComparison objLength = new LineComparison();
            objLength.calcLineLength();

            Console.ReadKey();
        }
    }
}